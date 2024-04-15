using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion
{
    internal class Cliente
    {
        private string name;
        private string lastName;
        private string email;
        private string numCel;

        public string Name
        {
            get { return name; } //get;
            set { name = value; } //set;
            // the context is that is seter and geter so i can go for only get and set;
        }

        public string LastName
        {
            get { return lastName;}
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string NumCel
        {
            get { return numCel; }
            set { numCel = value; }
        }

        public string FullName
        {
            get { return name+" "+lastName; }
        }

        public override string ToString()
        {
            return FullName;
        } 
    }


}
