using System;
namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket årtal är det");
            string årtalText = Console.ReadLine();
            int årtal = int.Parse(årtalText);
            int årtalSenare = årtal + 20;
            Console.WriteLine("Om 20 år är det år " +  årtalSenare);
            Console.ReadKey();
        }
    }
}
