using System;
using GameDemo_.Entities;

namespace GameDemo_.Business.Concrete
{
    public class ValidationManager : Abstract.IValidationService
    {
        public bool CheckRealPerson(IEntity entity)
        {
            Console.WriteLine("Oyuncu Dogrulandi");
            return true;
        }
    }
}
