using MySql.Data.EntityFramework; //mysqldataef kütüphanesini ekledik
using System;
using System.Collections.Generic;
using System.Data.Entity; //Entity kütüphanesini ekledik
using System.Linq;
using System.Web;

namespace CreateModel.Models
{
   [DbConfigurationType(typeof(MySqlEFConfiguration))] 
    public class Context:DbContext // DbContext sınıfını ekledik.*2
    {
        public DbSet<Category> Categories { get; set; } // *3
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }




    // Context sınıfı oluşturduğumuz sayfaları veri tabanına aktarmamıza yarayan sınıftır.

    /*
     
     1.Adım: Manage NuGet Packages ' dan  Entity Framework 6.4.4 sürümünü ve
             MySql data ve MySql data entityframework 'ün 8.20 sürümünü indir.
     *2.Adım: DbContext sınıfına ait özellikleri Context sınıfında kullanabilmek için.
     *3.Adım: DbSet türünden Property oluşturup tabloya Categories ismini verdik.
     
     
     */

}