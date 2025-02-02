namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X From Point 1: ");
            double XP1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Y From Point 1: ");
            double YP1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter X From Point 2: ");
            double XP2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Y From Point 2: ");
            double YP2 = double.Parse(Console.ReadLine());

            Point P1 = new Point(XP1, YP1);
            Point P2 = new Point(XP2, YP2);

            double Distance = P1.CalculateDistance(P2);
            Console.WriteLine($"Distance between 2D = {Distance}");
        }
    }
}
