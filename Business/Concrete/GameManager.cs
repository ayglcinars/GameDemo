using System;
using System.Collections.Generic;
using GameDemo_.Business.Abstract;
using GameDemo_.Entities;

namespace GameDemo_.Business.Concrete
{
    public class GameManager : IEntityService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine("Yeni oyun eklendi : " + entity.Name);
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("Oyun silindi : " + entity.Name);
        }

        public void GetAll(List<IEntity> games)
        {
            foreach (var x in games)
            {
                Console.WriteLine(x.Name);
            }
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Oyun güncellendi : " + entity.Name);
        }
    }
}
