using System;
namespace GameDemo_.Entities.Concrete
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TcNo { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
    }
}
