using System;

namespace John_Smith_Movies_Watched_2021_API.Models
{
    public class Playtime
    {
        public int Id { get; set; }
        public DateTime When
        {
            get
            {
                return dateCreated ?? DateTime.UtcNow;
            }

            set { dateCreated = value; }
        }

        private DateTime? dateCreated = null;

        public int PetId { get; set; }
    }
}