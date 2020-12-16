namespace EntityFrameworkExamples.Test
{
    using System;
    using EntityFrameworkExamples.Models;
    using Microsoft.EntityFrameworkCore;
    using Xunit;

    public class Test
    {
        [Fact]
        public async void AddEntity()
        {
            await using var db = GetDbContext();
            await db.FruitBaskets.AddAsync(new FruitBasket
            {
                Banana = DateTime.UtcNow.Ticks.ToString(),
                Pear = DateTime.UtcNow.Ticks.ToString()
            });
            await db.SaveChangesAsync();
        }

        private static FruitsDbContext GetDbContext()
        {
            var context = new FruitsDbContext();
            context.Database.Migrate();
            return context;
        }
    }
}
