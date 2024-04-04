namespace DIEmployee.Models
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddTransient<ILoggerService, LoggerService>();
    }
}
