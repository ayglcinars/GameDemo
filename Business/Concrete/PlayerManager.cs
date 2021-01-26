using System;
using System.Collections.Generic;
using GameDemo_.Business.Abstract;
using GameDemo_.Entities;

namespace GameDemo_.Business.Concrete
{
    public class PlayerManager : IEntityService
    {
        private IValidationService _validationService;
        public PlayerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public void Add(IEntity entity)
        {
            if (_validationService.CheckRealPerson(entity))
            {
                Console.WriteLine("Yeni oyuncu eklendi : " + entity.Name);
            }
            else
            {
                Console.WriteLine("Oyuncu eklenemedi : " + entity.Name);
            }
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("Oyuncu silindi : " + entity.Name);
        }

        public void GetAll(List<IEntity> players)
        {
            foreach (var x in players)
            {
                Console.WriteLine(x.Name);
            }
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Oyuncu guncellendi : " + entity.Name);
        }
    }
}
