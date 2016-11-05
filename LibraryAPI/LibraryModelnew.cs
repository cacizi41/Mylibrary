namespace LibraryAPI
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LibraryModelnew : DbContext
    {
        // Your context has been configured to use a 'LibraryModelnew' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'LibraryAPI.LibraryModelnew' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'LibraryModelnew' 
        // connection string in the application configuration file.
        public LibraryModelnew()
            : base("name=LibraryModelnew")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<Book> Books { get; set; }
        // public virtual DbSet<Media> Media { get; set; }
        // public virtual DbSet<Author> Authors { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}