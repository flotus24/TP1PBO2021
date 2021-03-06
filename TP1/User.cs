using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class User
    {
        public User() { }
        public string nama { get; set; }
        public string password { get; set; }
        public User(string nama, string password)
        {
            this.nama = nama;
            this.password = password;
        }
    }
}
