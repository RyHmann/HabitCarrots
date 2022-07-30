using HabitCarrots.Api.Filters;
using HabitCarrots.Application;
using HabitCarrots.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddApplication();
    builder.Services.AddInfrastructure(builder.Configuration);
    builder.Services.AddControllers();
    //builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());
}


var app = builder.Build();
{
    //app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

