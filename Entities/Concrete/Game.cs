using System;
namespace GameDemo_.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int RateOfDiscount { get; set; }
        
    }
}
