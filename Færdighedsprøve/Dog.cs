using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Færdighedsprøve
{
    public class Dog
    {
        private int _id;
        private string _name;
        private int _yearOfBirth;
        private int _age;
        private DateTime _now;
        
        public Dog(int id, string name, int yearOfBirth)
        {
            _id = id;
            _name = name;
            _yearOfBirth = yearOfBirth;
        }
        public int YearOfBirth { get => _yearOfBirth; set => _yearOfBirth = value; }
        public string Name { get => _name; set => _name = value; }
        public int Id { get => _id; set => _id = value; }
        public DateTime Now { get => _now; set => _now = value; }

        public int Age
        {
            get { return DateTime.Now.Year - _yearOfBirth; }
        }
        public override string ToString()
        {
            return $"Id:{Id}\nNavn:{Name}\nFødselsår:{Age} år gammel";
        }
    }
}
