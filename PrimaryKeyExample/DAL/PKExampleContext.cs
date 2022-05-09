namespace PrimaryKeyExample.DAL
{
    using PrimaryKeyExample.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class PKExampleContext : DbContext
    {
        // Your context has been configured to use a 'PKExampleContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PrimaryKeyExample.DAL.PKExampleContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PKExampleContext' 
        // connection string in the application configuration file.
        public PKExampleContext()
            : base("name=PKExampleContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Firma> Firmalar { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Kitap> Kitaplar { get; set; }
        public virtual DbSet<Yazar> Yazarlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}