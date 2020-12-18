namespace EntityFrameworkExamples.Test
{
    using System;
    using System.Threading.Tasks;
    using EntityFrameworkExamples.Models;
    using Microsoft.EntityFrameworkCore;
    using Xunit;

    public class Test
    {
        [Fact]
        public async void LinkMakerBasket()
        {
            var basketID = await CreateBasket();
            var makerID = await CreateMaker();
            await using var db = GetDbContext();
            var basket = await db.FruitBaskets.FindAsync(basketID);
            Assert.Empty(basket.BasketMakers);
            var maker = await db.BasketMakers.FindAsync(makerID);
            Assert.Empty(maker.FruitBaskets);
            basket.BasketMakers.Add(maker);
            await db.SaveChangesAsync();
            var basketUpdated = await db.FruitBaskets
                .Include(b => b.BasketMakers)
                .SingleOrDefaultAsync(b => b.ID == basketID);
            Assert.NotEmpty(basketUpdated.BasketMakers);
            var makerUpdated = await db.BasketMakers
                .Include(m => m.FruitBaskets)
                .SingleOrDefaultAsync(m => m.ID == makerID);
            Assert.NotEmpty(makerUpdated.FruitBaskets);
        }

        private static async Task<int> CreateBasket()
        {
            await using var db = GetDbContext();
            var basket = new FruitBasket
            {
                Banana = DateTime.UtcNow.Ticks.ToString(),
                Pear = DateTime.UtcNow.Ticks.ToString()
            };
            await db.FruitBaskets.AddAsync(basket);
            await db.SaveChangesAsync();
            return basket.ID;
        }

        private static async Task<int> CreateMaker()
        {
            await using var db = GetDbContext();
            var basketMaker = new BasketMaker();
            await db.BasketMakers.AddAsync(basketMaker);
            await db.SaveChangesAsync();
            return basketMaker.ID;
        }

        private static FruitsDbContext GetDbContext()
        {
            var context = new FruitsDbContext();
            context.Database.Migrate();
            return context;
        }
    }
}
