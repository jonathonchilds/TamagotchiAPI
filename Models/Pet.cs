using System;

namespace TamagotchiAPI.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday
        {
            get
            {
                return dateCreated ?? DateTime.UtcNow;
            }

            set { dateCreated = value; }
        }

        private DateTime? dateCreated = null;

        public int HungerLevel { get; set; }
        public int HappinessLevel { get; set; }
    }
}