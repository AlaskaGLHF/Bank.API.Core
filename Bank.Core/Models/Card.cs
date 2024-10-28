using System.ComponentModel.DataAnnotations;

namespace Bank.Core.Models
{
    public class Card
    {

        public const int MAX_NAME_LENGTH = 250;

        private Card(Guid id, string email, string name, string hash_password, DateOnly created_at)
        {

            Id = id;
            Email = email;
            Name = name;
            Hash_password = hash_password;
            Created_at = created_at;

        }


        public Guid Id { get; set; }

        public string Email { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Hash_password { get; set; }

        public DateOnly Created_at { get; set; }

        public static (Card card, string error) Create(Guid id, string email, string name, string hash_password, DateOnly created_at)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(name) || name.Length > MAX_NAME_LENGTH)
            {

                error = "Name null or longer then 250 symbol";

            }


            var card = new Card(id, email, name, hash_password, created_at);

            return (card, error);
        }






    }
}