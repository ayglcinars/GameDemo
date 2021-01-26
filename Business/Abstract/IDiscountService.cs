using System;
namespace GameDemo_.Business.Abstract
{
    public interface IDiscountService
    {
        void Add(Entities.Game game, int rateOfDiscound);
        void Delete(Entities.IEntity game);
        void Update(Entities.IEntity game);
    }
}
