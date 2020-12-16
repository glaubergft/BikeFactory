using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactoryBusinessLayer
{
    public class User : SerializableItem
    {
        private string userName;
        private string password;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}
