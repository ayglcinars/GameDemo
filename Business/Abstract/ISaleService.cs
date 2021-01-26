using System;
namespace GameDemo_.Business.Abstract
{
    public interface ISaleService
    {
        void BuyGame(Entities.IEntity game, Entities.IEntity player);
    }
}
