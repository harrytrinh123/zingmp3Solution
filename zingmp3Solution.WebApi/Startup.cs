using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zingmp3Solution.Application.Catalog.Comments;
using zingmp3Solution.Application.Catalog.Singers;
using zingmp3Solution.Application.Catalog.Playlists;
using zingmp3Solution.Application.Catalog.Posts;
using zingmp3Solution.Application.Catalog.Songs;
using zingmp3Solution.Application.Common;
using zingmp3Solution.Data.EF;
using zingmp3Solution.Data.Entities;

namespace zingmp3Solution.WebApi
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
      services.AddDbContext<ZingMp3DbContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("ZingMp3SolutionDb")));

      services.AddControllers();
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger Zingmp3", Version = "v1" });
      });


      //Depency injection
      services.AddTransient<ISongService, SongService>();
      services.AddTransient<IPlaylistService, PlaylistService>();

      services.AddScoped<ISingersService, SingersService>();
      services.AddScoped<ICommentsService, CommentsService>();
      services.AddTransient<IPostService, PostService>();
      services.AddTransient<IStorageService, FileStorageService>();

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            );
      app.UseStaticFiles();
      app.UseHttpsRedirection();
      app.UseRouting();

      app.UseAuthorization();
      app.UseSwagger();

      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Zingmp3 V1");
      });

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
