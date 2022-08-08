using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicATM.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Pin { get; set; }
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string Username { get; set; }
        public string Age { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Balance { get; set; }
        public bool IsCreditCard { get; set; }
    }
}
