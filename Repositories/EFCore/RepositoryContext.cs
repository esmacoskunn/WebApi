using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{

    public class RepositoryContext : DbContext
    {

        public RepositoryContext(DbContextOptions options) : base(options) //base(options) burası dbcontexin yapıcı metodunu çağırır. RepositoryContext sınıfının içine eçşitli veriler eklendi. bu verileride options la kullanırsın........gelen paremetreyi optionla dbcontexe gönderdim.tek söylenen bu base olan yerde.
        {

        }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());
        }

    }

}
