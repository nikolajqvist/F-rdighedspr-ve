using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøve
{
    public class Member
    {
        private int _id;
        private string _name;
        private string _adress;
        private int _age;
        private int _phonenr;
        private int _birthYear;
        private string _email;
        private DateTime _now = DateTime.Now;
        
        public Member(int id, string name, string adress, int birthYear, int phonenr, string email)
        {
            Id = id;
            Name = name;
            Adress = adress;
            Phonenr = phonenr;
            Email = email;
            BirthYear = birthYear;
        }
        public string Email { get => _email; set => _email = value; }
        public int Phonenr { get => _phonenr; set => _phonenr = value; }
        public string Adress { get => _adress; set => _adress = value; }
        public string Name { get => _name; set => _name = value; }
        public int Id { get => _id; set => _id = value; }

        public int BirthYear { get => _birthYear; set => _birthYear = value; }
        public DateTime Now { get => _now; set => _now = value; }
        public int Age
        {
            get { return DateTime.Now.Year - _birthYear; }
        }
        public override string ToString()
        {
            return $"Id:{Id}\nNavn: {Name}. \nEmail:{Email}. \nAdresse:{Adress}. \nTelefon nr:{Phonenr}\nFødselsdag:{Age} år gammel";
        }
    }
}
