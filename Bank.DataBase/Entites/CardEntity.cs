using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DataBase.Entites
{
    public class CardEntity
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Hash_password { get; set; }

        public DateOnly Created_at { get; set; }
    }
}
