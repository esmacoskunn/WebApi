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
        }
           //  Bu kod bloğu, Entity Framework Core'un DbContext sınıfını kullanarak SQL Server veritabanına bağlanmak için yapılandırmayı yapar. Bu, projede veritabanına erişim için gerekli olan DbContext'i ayarlar ve uygulamanın geri kalan kısmında bu DbContext'i enjekte edilebilir hale getirir. Böylece, veritabanı bağlantısı yapılandırması tek bir merkezi yerde belirtilir ve Dependency Injection ile diğer servisler veya bileşenler bu yapılandırmadan yararlanabilir.

        //Extension metotlarını ayrı bir dosyada tanımlamak, kodunuzu daha düzenli ve yönetilebilir hale getirir ve extension metotlarını farklı kısımlarda tekrar tekrar kullanmanızı sağlar. Ayrıca, extension metotları proje düzenini koruyan ve modüler bir yapıda düzenlemeyi destekler.

        //Eğer extension metotlarınızı Program.cs dosyasında tanımlamazsanız, bu extension metotları uygulamanızın diğer kısımlarında doğrudan kullanılamaz. Extension metotları, tanımlandıkları yerin dışında başka bir yerde kullanılabilmeleri için, ilgili türe ve namespace'e ait bir using bildirimi yapmanız gerekir.

        // Eğer extension metotlarınızı Program.cs dosyasında değil de başka bir dosyada(örneğin, ayrı bir "Extensions" klasöründe) tanımlarsanız, extension metotlarınızı kullanmak için o dosyanın bulunduğu namespace'e ve türe ait bir using bildirimi yapmanız gerekir.
        // public static void ConfigureSqlContext(this IServiceCollection services,  IConfiguration configurition) =>  services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(configurition.GetConnectionString("sqlConnection")));
        //void olduğu için bunu böylede kullanabilirdin....




        public static void ConfigureRepositoryManager(this IServiceCollection services) 
        {
             services.AddScoped<IRepositoryManager, RepositoryManager>();        
        }
        //IRepositoryManager, RepositoryManager bu iki yapıyı eşleştirir. eklemi işlemi IServiceCollection ait oan AddScoped bununla yapıyoruz.
        //Bu şekilde, IServiceCollection üzerinde IRepositoryManager ve RepositoryManager hizmetlerini bildirerek ve DI konteynerine ekleyerek, bağımlılıkların çözülmesini ve haberleşmeyi sağlayabilirsiniz.

        // Yukarıdaki kod bloğu, .NET Core tabanlı bir uygulamada IOC(Inversion of Control) prensibini ve Dependency Injection(Bağımlılık Enjeksiyonu) desenini kullanmıştır. Bu kod bloğu, bir IServiceCollection nesnesine IRepositoryManager arayüzünü RepositoryManager sınıfıyla ilişkilendirerek IOC kaydını yapmaktadır.

        public static void ConfigureServiceManagerr(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }

        public static void ConfigureLoggerService(this IServiceCollection services) =>
          services.AddSingleton<ILoggerService, LoggerManager>();





    }
}


