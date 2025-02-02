namespace Assignment1
{
    internal class Program
    {
        static Person CalculateOldestPerson(Person P1, Person P2, Person P3)
        {
            Person TemplatePerson = P1;

            if (P2.age > TemplatePerson.age)
                TemplatePerson = P2;
            if (P3.age > TemplatePerson.age)
                TemplatePerson = P3;

            return TemplatePerson;
        }
        static void Main(string[] args)
        {
            //////Q1)
            //Console.WriteLine("Enter X From Point 1: ");
            //double XP1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Y From Point 1: ");
            //double YP1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter X From Point 2: ");
            //double XP2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Y From Point 2: ");
            //double YP2 = double.Parse(Console.ReadLine());

            //Point P1 = new Point(XP1, YP1);
            //Point P2 = new Point(XP2, YP2);

            //double Distance = P1.CalculateDistance(P2);
            //Console.WriteLine($"Distance between 2D = {Distance}");

            /////////Q2)
            Console.Write("Enter Name From Person1: ");
            string NamePerson1 = Console.ReadLine();

            Console.Write("Enter Age From Person1: ");
            int AgePerson1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Name From Person2: ");
            string NamePerson2 = Console.ReadLine();

            Console.Write("Enter Age From Person2: ");
            int AgePerson2 = int.Parse(Console.ReadLine());

            Console.Write("Enter Name From Person3: ");
            string NamePerson3 = Console.ReadLine();

            Console.Write("Enter Age From Person3: ");
            int AgePerson3 = int.Parse(Console.ReadLine());

            Person P1 = new Person(NamePerson1, AgePerson1);
            Person P2 = new Person(NamePerson2, AgePerson2);
            Person P3 = new Person(NamePerson3, AgePerson3);
            
            Person OldestPerson = CalculateOldestPerson(P1 , P2, P3);

            Console.WriteLine($"The Oldest Person is {OldestPerson.name} and Age is {OldestPerson.age}");
        }
    }
}
