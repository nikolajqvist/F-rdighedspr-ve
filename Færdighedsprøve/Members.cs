using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Færdighedsprøve
{
    public class Members
    {
        private Member _member;
        private Dog _dog;
        private List<Dog> _dogsList = new List<Dog>();
        private int dogFee = 1000;
        private int clubhouse = 100;
        private int totalPrice;
        DateTime date = DateTime.Now;
        DayOfWeek day = DateTime.Now.DayOfWeek;
        private List<Member> _membersList;
        public Members()
        {
            _membersList = new List<Member>() { new Member(0, "Ulrik", "MogensAlle 69", 1999, 373747373, "Helpmeplzz")};
            _member = Member;
            Dog = Dog;
        }
        public Member Member { get => _member; set => _member = value; }
        public Dog Dog { get => _dog; set => _dog = value; }
        public List<Member> MembersList { get => _membersList; set => _membersList = value; }
        public int DogFee { get => dogFee; set => dogFee = value; }
        public int Clubhouse { get => clubhouse; set => clubhouse = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }

        public List<Dog> DogsList
        {
            get { return _dogsList; }
        }


        public void GetAllMembers()
        {
            foreach(Member member in _membersList)
            {
                Console.WriteLine($"{member}");
            }
        }
        public void CreateNewMember(string name, int id, string adress, int birthyear, int phonenr, string email)
        {
            Member m1 = new Member(id, name, adress, birthyear, phonenr, email);
            _membersList.Add(m1);
        }
        public void AddMemberTolist(Member member)
        {
            _membersList.Add(member);
        }
        public void RemoveMemberFromList(Member member)
        {
            _membersList.Remove(member);
        }
        public void UpdateMember(int newBirthYear, string name)
        {
            for (int i = 0; i < _membersList.Count; i++)
            {
                if (string.Equals(_membersList[i].Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    _membersList[i].BirthYear = newBirthYear;
                }
            }
        }
        public void RegisterDog(Dog dog)
        {
            DogsList.Add(dog);
        }
        public void ShowDogsRegistreredOwner(Member member)
        {
            Console.WriteLine($"{member}");
            foreach (Dog dog in _dogsList)
            {
                Console.WriteLine($"{dog}");
            }
        }
        public void CalculateDogFee(Member member)
        {
            foreach(Dog dog in _dogsList)
            {
                if (day == DayOfWeek.Saturday && day == DayOfWeek.Sunday)
                {
                    TotalPrice = DogFee + Clubhouse / 2;
                }
                else if (_dogsList.Count > 1 && day != DayOfWeek.Saturday || day != DayOfWeek.Sunday)
                {
                    TotalPrice = (_dogsList.Count * DogFee) / 2 + Clubhouse;
                }
                else if (_dogsList.Count > 1 && day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
                {
                    TotalPrice = (_dogsList.Count * DogFee) / 2 + Clubhouse / 2;
                }
                else if (_dogsList.Count > 5 || _dogsList.Count == 5 && day != DayOfWeek.Saturday || day != DayOfWeek.Sunday)
                {
                    TotalPrice = 2500;
                }
                else if (day != DayOfWeek.Saturday || day != DayOfWeek.Sunday && Member.Age > 65)
                {
                    TotalPrice = DogFee / 2 + Clubhouse / 2;
                }
                else if (Member.Age >= 18)
                {
                    Console.WriteLine("You cant go ind here or be registered.");
                }
            }           
        }
        public override string ToString()
        {
            return $"Prisen for {_dogsList.Count} er {totalPrice}kr.";
        }
    }
}
