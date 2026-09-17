var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

DotNetEnv.Env.Load();
var environment = Environment.GetEnvironmentVariable("APP_ENV");
Console.WriteLine($"-----> environment is {environment}");

app.MapGet("/", () => "Hello World!");

app.Run();
