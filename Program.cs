// See https://aka.ms/new-console-template for more information
using Serilog;


Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

Log.Information("Hello World!");
Log.Information("Doing some maths");

int a = 10, b = 0;

try
{
    Log.Debug("Dividing {A} by {B}", a, b);
    Console.WriteLine(a / b);
}
catch (System.Exception ex)
{
    Log.Error(ex, "Something went wrong");
}
finally
{
    Log.CloseAndFlush();
}