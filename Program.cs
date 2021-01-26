using System;
using System.Collections.Generic;
using GameDemo_.Business.Abstract;
using GameDemo_.Business.Concrete;
using GameDemo_.Entities;
using GameDemo_.Entities.Concrete;

namespace GameDemo_
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEntity player1 = new Player { Id = 1, Name = "Aygul", LastName = "Sevim", DateOfBirth = "1994", TcNo= "123456789" };
            IEntity player2 = new Player { Id = 2, Name = "Erhan", LastName = "Sevim", DateOfBirth = "1993", TcNo = "987654321" };
            IEntity player3 = new Player { Id = 3, Name = "Efkan", LastName = "Sevim", DateOfBirth = "1998", TcNo = "135792468" };

            IEntityService playerManager = new PlayerManager(new ValidationManager());
            playerManager.Add(player1);
            playerManager.Add(player2);
            playerManager.Add(player3);

            List<IEntity> players = new List<IEntity> { player1, player2, player3 };
            playerManager.GetAll(players);

            playerManager.Delete(player3);
            playerManager.Update(player2);

            IEntity game1 = new Game { Id = 1, Name = "Sims4", Price = 129.50, RateOfDiscount = 10 };
            IEntity game2 = new Game { Id = 2, Name = "GTA5", Price = 79.50, RateOfDiscount = 5 };
            IEntity game3 = new Game { Id = 3, Name = "Fifa20", Price = 179, RateOfDiscount = 15 };

            IEntityService gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);

            List<IEntity> games = new List<IEntity> { game1, game2, game3 };
            gameManager.GetAll(games);

            gameManager.Delete(game2);
            gameManager.Update(game3);

            ISaleService saleManager = new SaleManager();
            saleManager.BuyGame(game1,player1);

            IDiscountService discountManager = new DiscountManager();
            discountManager.Add(game1, 10);

        }
    }
}