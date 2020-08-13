using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Data.Repositories;
using CleanArchitecture.Domain.IRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CleanArchitecture.Application
            services.AddScoped<IBookService, BookService>();
            //CleanArchitecture.Domain.IRepositories
            services.AddScoped<IBookRepository, BookRepository>();
        }
    }
}
