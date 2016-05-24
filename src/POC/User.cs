using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC
{
    public class User
    {

        public User(int userID)
        {
            this.ID = userID;
        }

        public int ID { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public bool IsValid { get; set; }

        public bool IsSecure { get; set; }
    }
}
