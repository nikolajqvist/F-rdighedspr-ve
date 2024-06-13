using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Færdighedsprøve
{
    public class Dogs
    {
        private Dog _dog;
        private List<Dog> _dogsList;
        public Dogs()
        {
            _dogsList = new List<Dog>() { new Dog(0, "Vaks", 2015), new Dog(1, "Fie", 2012), new Dog(2, "Bailey", 2015), new Dog(3, "Alba", 2005) };
        }

        public List<Dog> DogsList { get => _dogsList; set => _dogsList = value; }
        public Dog Dog { get => _dog; set => _dog = value; }

        public void GetAllDogs()
        {
            foreach(Dog dog in DogsList)
            {
                Console.WriteLine($"{dog}");
            }
        }
        public void CreateNewDog(string name, int id, int yearOfBirth)
        {
            Dog d1 = new Dog(id, name, yearOfBirth);
            DogsList.Add(d1);
        }
        public void AddDogToList(Dog dog)
        {
            DogsList.Add(dog);
        }
        public void UpdateDog(int newBirthYear, string name)
        {
            for (int i = 0; i < _dogsList.Count; i++)
            {
                if (string.Equals(_dogsList[i].Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    _dogsList[i].YearOfBirth = newBirthYear;
                }
            }
        }
        public void RemoveDogFromList(Dog dog)
        {
            DogsList.Remove(dog);
        }
    }
}
