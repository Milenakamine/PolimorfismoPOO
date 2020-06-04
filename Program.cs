using System;

namespace PolimorfismoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Mario: ");
          Mario mario = new Mario();
          mario.Correr();
          
            System.Console.WriteLine("Luigi: ");
          Luigi luigi = new Luigi();
          luigi.Correr();
          luigi.Pular();
        }
    }
}
