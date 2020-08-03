using System;
using System.IO;
using System.ServiceModel;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using SpotifySearcherNetCoreWebApi.Business.Helpers.Binding;
using SpotifySearcherNetCoreWebApi.Business.Modules.Song;

namespace SpotifySearcherNetCoreWebApi.Services
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Spotify API", Version = "1" });
                c.DescribeAllEnumsAsStrings();
                //Obtenemos el directorio actual
                var basePath = AppContext.BaseDirectory;
                //Obtenemos el nombre de la dll por medio de reflexión
                var assemblyName = System.Reflection.Assembly
                    .GetEntryAssembly().GetName().Name;
                //Al nombre del assembly le agregamos la extensión xml
                var fileName = System.IO.Path
                    .GetFileName(assemblyName + ".xml");
                //Agregamos el Path, es importante utilizar el comando
                // Path.Combine ya que entre windows y linux 
                // rutas de los archivos
                // En windows es por ejemplo c:/Uusuarios con / 
                // y en linux es \usr con \
                var xmlPath = Path.Combine(basePath, fileName);
                c.IncludeXmlComments(xmlPath);
            });

            var endpoint = Configuration["EndpointSpotifyWCF"];

            services.AddSingleton<SpotifyWCF.ISongService, SpotifyWCF.SongServiceClient>(provider =>
                new SpotifyWCF.SongServiceClient(BindingHelper.GetHttpBinding(), new EndpointAddress(endpoint)));

            services.AddScoped<ISongModule, SongModule>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors(options => options
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials()
                .AllowAnyOrigin()

            );

            app.UseHttpsRedirection();
            var option = new RewriteOptions();
            option.AddRedirect("^$", "swagger");
            app.UseRewriter(option);
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "Spotify API");
            });

            app.UseMvc();
        }
    }
}
