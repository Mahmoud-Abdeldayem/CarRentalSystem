using BusinessLogicLayer.Abstractions;
using BusinessLogicLayer.Services;
using DataAccessLayer.Abstractions.UnitOfWork;
using DataAccessLayer.Abstractions.Repositories;
using DataAccessLayer.UnitOfWork;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using PresentationLayer.Forms.AdminForms;
using DataAccessLayer.Data;
using DataAccessLayer.Repositories.InMemoryRepos;
using DataAccessLayer.Entities;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            using var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            var loginForm = new LoginForm(ServicesManager.AccountService);
            Application.Run(loginForm);
        }

        public static class ServicesManager
        {
            public static IUnitOfWork UnitOfWork { get; private set; } = new UnitOfWork();
            public static ICarService CarService { get; private set; } = new CarService(UnitOfWork);
            public static IAccountService AccountService { get; private set; } = new AccountService(UnitOfWork);
        }
    }
}