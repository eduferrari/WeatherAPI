using Polly;
using WeatherApi.Repository;
using WeatherApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<IWeatherService, WeatherService>()
    .AddTransientHttpErrorPolicy(p => p.WaitAndRetryAsync(3, _ => TimeSpan.FromMilliseconds(600)))
    .AddTransientHttpErrorPolicy(p => p.CircuitBreakerAsync(5, TimeSpan.FromSeconds(30)));
builder.Services.AddSingleton<IWeatherRepository, WeatherRepository>();
builder.Services.AddHostedService<WeatherBackgroundService>();
builder.Services.AddMemoryCache();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WeatherAPI v1"));
}

app.UseRouting();

app.UseStaticFiles();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapFallbackToFile("index.html");
});

app.Run();