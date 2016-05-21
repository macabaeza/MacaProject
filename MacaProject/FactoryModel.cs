namespace MacaProject
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FactoryModel : DbContext
    {
        // Your context has been configured to use a 'FatoeyModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MacaProject.FatoeyModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'FatoeyModel' 
        // connection string in the application configuration file.
        public FactoryModel()
            : base("name=FactoryModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see 
        
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Order> Orders{ get; set; }
        public virtual DbSet<Customer>Customers { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}