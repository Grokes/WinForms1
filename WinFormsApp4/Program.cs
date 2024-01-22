using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WinFormsApp4
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = Program.CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<AuthorizeForm>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            var host_builder = Host.CreateDefaultBuilder();
            host_builder.ConfigureServices(Program.ConfigureServices);
            return host_builder;
        }

        public static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {
            var connectionString = "Data Source=LAPTOP-J6B0K8DE;Initial Catalog=WinForms;Persist Security Info=True;User ID=sa;Password=admin;TrustServerCertificate=True";
            services.AddTransient<IUserRepository, UserRepository>(provider => new UserRepository(connectionString));
            services.AddTransient<MainWindow>();
            services.AddTransient<RegistrationForm>();
            services.AddTransient<AuthorizeForm>();
        }
    }
}