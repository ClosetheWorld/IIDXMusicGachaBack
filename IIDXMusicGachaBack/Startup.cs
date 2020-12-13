using AutoMapper;
using IIDXMusicGachaBack.Infrastructures;
using IIDXMusicGachaBack.Interactors;
using IIDXMusicGachaBack.Repositories;
using IIDXMusicGachaBack.Usecases;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace IIDXMusicGachaBack
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddScoped<IGetSongUsecase, GetSongInteractor>();
            services.AddScoped<ISongRepository, SongRepository>();

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "IIDXMusicGachaBack",
                    Version = "v1"
                });

            });

            services.AddAutoMapper(typeof(Startup));
            services.AddSingleton<IMapper, Mapper>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseCors(b => b.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(s =>
                {
                    s.SwaggerEndpoint("/swagger/v1/swagger.json", "IIDXMusicGachaBack v1");
                });
            }

            app.UseCors(b => b.WithOrigins("https://*.closetheworld.me").SetIsOriginAllowedToAllowWildcardSubdomains().AllowAnyMethod().AllowAnyHeader());
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
