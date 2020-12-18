namespace EntityFrameworkExamples
{
    using EntityFrameworkExamples.Models;
    using Microsoft.Data.SqlClient;
    using Microsoft.EntityFrameworkCore;

    public class FruitsDbContext : DbContext
    {
        private const string ConnectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Fruits;Integrated Security=True";

        public DbSet<FruitBasket> FruitBaskets =>
            Set<FruitBasket>();

        public DbSet<BasketMaker> BasketMakers =>
            Set<BasketMaker>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(new SqlConnection { ConnectionString = ConnectionString });
    }
}
