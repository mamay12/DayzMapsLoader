﻿using DayzMapsLoader.Application.Extensions;
using DayzMapsLoader.Infrastructure.Extensions;
using DayzMapsLoader.Presentation.WebApi.Extensions;
using MediatR;

namespace DayzMapsLoader.Presentation.WebApi;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplicationLayer();
        services.AddInfrastractureLayer();
        services.AddDatabase(_configuration);
        services.AddControllers();
        services.AddSwagger();
        services.AddCors();
        services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "DayzMapsLoader API V1");
            options.InjectStylesheet("/swagger-ui/theme-material.css");
        });
        app.UseRouting();
        app.UseStaticFiles();
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.UseCors(builder => builder.AllowAnyOrigin());
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}