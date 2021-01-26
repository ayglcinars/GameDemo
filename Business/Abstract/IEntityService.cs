using System;
using System.Collections.Generic;

namespace GameDemo_.Business.Abstract
{
    public interface IEntityService
    {
        void GetAll(List<Entities.IEntity> entities);
        void Add(Entities.IEntity entity);
        void Update(Entities.IEntity entity);
        void Delete(Entities.IEntity entity);
    }
}
