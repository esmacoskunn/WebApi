using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Contracts;
using Repositories.EFCore;
using Services;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configurition)
        {
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(configurition.GetConnectionString("sqlConnection")));
            // metotlarını çağırmak için sınıf örneği oluşturma zorunluluğunu ortadan kaldırır ve daha doğal bir kullanım sağlar.
        }
        // public static void ConfigureSqlContext(this IServiceCollection services,  IConfiguration configurition) =>  services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(configurition.GetConnectionString("sqlConnection")));
        //void olduğu için bunu böylede kullanabilirdin....

        public static void ConfigureRepositoryManager(this IServiceCollection services) //IServiceCollection bu bağımlılık olucağını söyler
        {
             services.AddScoped<IRepositoryManager, RepositoryManager>(); //IRepositoryManager, RepositoryManager bu iki yapıyı eşleştirir. eklemi işlemi IServiceCollection ait oan AddScoped bununla yapıyoruz.
            //Bu şekilde, IServiceCollection üzerinde IRepositoryManager ve RepositoryManager hizmetlerini bildirerek ve DI konteynerine ekleyerek, bağımlılıkların çözülmesini ve haberleşmeyi sağlayabilirsiniz.

           // Yukarıdaki kod bloğu, .NET Core tabanlı bir uygulamada IOC(Inversion of Control) prensibini ve Dependency Injection(Bağımlılık Enjeksiyonu) desenini kullanmıştır. Bu kod bloğu, bir IServiceCollection nesnesine IRepositoryManager arayüzünü RepositoryManager sınıfıyla ilişkilendirerek IOC kaydını yapmaktadır.
        }


        public static void ConfigureServiceManagerr(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }






    } 
}

//  STATİC SINIFLAR
//public class Logger
/*{
    public static void Log(string message)
    {
        Console.WriteLine(message);
    }
}
Yukarıdaki örnekte, Logger adında bir sınıfımız var ve Log adında bir statik metodu bulunuyor.
 Bu metot, verilen mesajı konsola yazdıran basit bir loglama işlemini temsil ediyor.

Bu statik metoda, bir sınıf örneği oluşturmadan doğrudan erişebilirsiniz. Örneğin:


Logger.Log("Bu bir log mesajıdır.");

Yukarıdaki örnekte, Logger.Log şeklinde sınıfın adını kullanarak statik metoda erişiyoruz ve log mesajını yazdırıyoruz.

Burada dikkat etmeniz gereken nokta, statik metotlara sınıf adıyla erişebileceğinizdir. 
Sınıfın bir örneği oluşturmadan doğrudan statik metotları çağırabilirsiniz. Bu, sınıfın herhangi bir örneği olmadan sınıf düzeyinde işlemler yapmanıza olanak sağlar.*/