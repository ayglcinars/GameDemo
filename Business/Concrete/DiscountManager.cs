using System;
using GameDemo_.Business.Abstract;
using GameDemo_.Entities;

namespace GameDemo_.Business.Concrete
{
    public class DiscountManager : IDiscountService
    {

       
        public void Add(Game game, int rateOfDiscound)
        {
            double newPrice = (game.Price * (100 - game.RateOfDiscount)) / 100;
            if (game.Price > newPrice)
            {
                Console.WriteLine(game.Name + " oyununun kampanya indirimi uygulanmistir.");
            }
            else
            {
                Console.WriteLine(game.Name + " oyununun kampanya indirimi uygulanmamistir.");
            }
        }

        public void Delete(IEntity game)
        {
            Console.WriteLine(game.Name + " oyununun kampanya indirimi sona ermistir.");
        }

        public void Update(IEntity game)
        {
            Console.WriteLine(game.Name + " oyununun kampanya indirimi guncellenmistir.");
        }

        
    }
}
