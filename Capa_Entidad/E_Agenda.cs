using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entity
{
    public class E_Agenda
    {
        private int iD;
        private string firstName;
        private string lastName;
        private string address;
        private DateTime dateOfBirth;
        private string mobilePhone;

        public int ID { get => iD; set => iD = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string MobilePhone { get => mobilePhone; set => mobilePhone = value; }
    }
}
