using System;
using System.IO;
using System.Windows.Forms;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Quality.DTH.Queries;
using Serilog;
using Serilog.Events;

namespace Quality.DTH
{
    
    public class Program
    {
        public static readonly string Namespace = typeof(Program).Namespace;
        public static readonly string AppName = Namespace.Substring(Namespace.LastIndexOf('.', Namespace.LastIndexOf('.') - 1) + 1); 


        [STAThread]
        public static int Main(string[] args)
        {
            var configuration = GetConfiguration();

            Log.Logger = CreateSerilogLogger(configuration); 

            try
            {
                Log.Information("Configuring App host ({ApplicationContext})...", AppName);

                var container = new ContainerBuilder();
                container.RegisterModule(new ApplicationModule(configuration["ConnectionString"]));

                //container.Register(c => Log.Logger)
                //.As<ILogger>()
                //.InstancePerLifetimeScope();

                ContainerProvider.Container = container.Build();

                Log.Information("Starting App host ({ApplicationContext})...", AppName); 

                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(ContainerProvider.Container.Resolve<Form1>());
                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Program terminated unexpectedly ({ApplicationContext})!", AppName);
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            } 
        }

        public static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
              .AddEnvironmentVariables();

            return builder.Build();
        }

        private static Serilog.ILogger CreateSerilogLogger(IConfiguration configuration)
        { 
            string loggerTemplate = @"{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u4}]<{ThreadId}> [{SourceContext:l}] {Message:lj}{NewLine}{Exception}";
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var logfile = Path.Combine(baseDir, "App_Data", "logs", "log.txt");

            return new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .Enrich.WithProperty("ApplicationContext", AppName)
                .Enrich.FromLogContext()
                //.WriteTo.Console()
                .WriteTo.File(logfile, LogEventLevel.Information, loggerTemplate, rollingInterval: RollingInterval.Day, retainedFileCountLimit: 90)
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
        }
    }

    public static class ContainerProvider
    {
        public static IContainer Container { get; set; }
    }
}
