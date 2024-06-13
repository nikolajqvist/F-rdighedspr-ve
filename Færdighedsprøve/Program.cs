namespace Færdighedsprøve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dogs dd = new Dogs();
            Members mm = new Members();
            Console.WriteLine("Liste af members:");
            Console.WriteLine();
            mm.GetAllMembers();
            Console.WriteLine("Liste af hunde:");
            Console.WriteLine();
            dd.GetAllDogs();
            Console.WriteLine();
            Console.WriteLine("Fjernet en hund");
            dd.RemoveDogFromList(dd.DogsList[0]);
            dd.GetAllDogs();
            Console.WriteLine();
            dd.CreateNewDog("Vaks", 0, 2005);
            Console.WriteLine();
            Console.WriteLine("Ny registring af hunde:");
            dd.GetAllDogs();
            Console.WriteLine();

            dd.UpdateDog(2007, "Vaks");
            Console.WriteLine("Forkert registrering:");
            dd.GetAllDogs();
            Console.WriteLine();
            Console.WriteLine("Opdatering af alder:");
            mm.UpdateMember(2000, "Ulrik");
            Console.WriteLine("Opdaterede members:");
            mm.GetAllMembers();
            Console.WriteLine();

            Console.WriteLine("Registring af hunde:");
            mm.RegisterDog(dd.DogsList[2]);
            mm.RegisterDog(dd.DogsList[1]);
            mm.CalculateDogFee(mm.MembersList[0]);
            Console.WriteLine();
            mm.ShowDogsRegistreredOwner(mm.MembersList[0]);

            Console.WriteLine($"{mm.ToString()}");

        }
    }
}
