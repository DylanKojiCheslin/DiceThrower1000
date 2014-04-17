using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {   //generates a varible number of dice rolls for a dice with varible number of sides 
        static void ThrowDice(string diceString) //takes input (number of dice rolls)d(number of sides on dice)
        {
            //splits diceString
            string[] X = diceString.Split('d');
            int numRolls = Convert.ToInt32(X[0]);//converts to ints
            int numSides = Convert.ToInt32(X[1]);//converts to ints
            //prints Throwing: <diceString>
            Console.WriteLine("Throwing: "+ diceString);
            int i = 0;//counting var for loop
            Console.Write("Results: ");
            var r = new Random();//creates random  instance
            while (i < numRolls)//iterates dice rolls
	        {
                
                int roll = r.Next(1,numSides+1);//rolls for number of dice sides
                Console.Write(+ roll+"  ");//adds rolls to output
                i++;
	        }
            //in loop generates random roll/print 
                        
        }

        static void Main(string[] args)
        {
            ThrowDice("10d6");
            Console.WriteLine();
            ThrowDice("3d20");
            Console.WriteLine();
            ThrowDice("100d6");
            Console.ReadKey();
        }
    }
}
