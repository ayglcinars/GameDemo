using System;
namespace GameDemo_.Business.Abstract
{
    public interface IValidationService
    {
        bool CheckRealPerson(Entities.IEntity entity);
    }
}
