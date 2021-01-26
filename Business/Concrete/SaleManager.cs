using System;
using GameDemo_.Entities;

namespace GameDemo_.Business.Concrete
{
    public class SaleManager : Abstract.ISaleService
    {
        public void BuyGame(IEntity game, IEntity player)
        {
            Console.WriteLine(player.Name + " adlı oyuncu " + game.Name + " oyununu satın aldı.");
        }
    }
}
