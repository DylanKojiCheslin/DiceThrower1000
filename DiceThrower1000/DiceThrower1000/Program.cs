using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {   //generates a variable number of dice rolls for a dice with variable number of sides
        static void ThrowDice(string diceString) //takes input (number of dice rolls)d(number of sides on dice)
        {
            //splits diceString
            string[] X = diceString.Split('d');
            int numRolls = Convert.ToInt32(X[0]);//converts to ints
            int numSides = Convert.ToInt32(X[1]);//converts to ints
            //prints Throwing: <diceString>
            Console.WriteLine("Throwing: " + diceString);
            int i = 0;//counting var for loop
            Console.Write("Results: ");
            var r = new Random();//creates random  instance
            while (i < numRolls)//iterates dice rolls
            {

                int roll = r.Next(1, numSides + 1);//rolls for number of dice sides
                Console.Write(+roll + "  ");//adds rolls to output
                i++;
            }
            Console.WriteLine();
        }

/// <summary>
/// takes input (number of dice rolls)d(number of sides on dice) prints and returns the average
/// </summary>
/// <param name="diceString">NdS</param>
/// <returns>the average roll</returns>
        static int ThrowDiceMean(string diceString) 
        {
            //splits diceString
            string[] X = diceString.Split('d');//makes array out of input
            int numRolls = Convert.ToInt32(X[0]);//converts to int
            int numSides = Convert.ToInt32(X[1]);//converts to int
            int totalRolls = 0;//keeps count of how many rolls are made
            int totalRollValue = 0;//total value of all dice rolled
            //prints Throwing: <diceString>
            Console.WriteLine("Throwing: " + diceString);
            int i = 0;//counting var for loop
            Console.Write("Results: ");
            var r = new Random();//creates random  instance
            while (i < numRolls)//iterates dice rolls
            {

                int roll = r.Next(1, numSides + 1);//rolls for number of dice sides
                Console.Write(+roll + "  ");//adds rolls to output
                totalRollValue = totalRollValue + roll;//adds this roll to totalRollValue
                totalRolls++;
                i++;
            }
            return totalRollValue;//the average of the rolls
        }
        //SuperThrowDice takes a string of (muliple dice notion separated by a space) and displays the the input, the results of each notion
        static void SuperThrowDice(string superString)
        {
            int total = 0;//sum of averages
            int numDiceSets = 0;
            string[] diceSets = superString.Split(' ');//splits up the string into an array
            int i = 0;//counter for while loop
            while (i<=diceSets.Length-1)//loops through array
            {
                int newAverage = ThrowDiceMean(diceSets[i]);//calls dice mean
                total = total + newAverage;//adds to total
                numDiceSets++;//add to divisor for average of all sets
                i++;
                Console.WriteLine();
                Console.WriteLine("the average for this set is "+ newAverage);
                Console.WriteLine();
            }


            Console.WriteLine("the average for all sets is "+(total/numDiceSets));

        }


        static void Main(string[] args)
        {
            ThrowDice("10d6");
            Console.WriteLine();
            ThrowDice("3d20");
            Console.WriteLine();
            ThrowDice("100d6");
            Console.WriteLine();
            SuperThrowDice("3d6 2d10 6d20");
            Console.ReadKey();
        }
    }

}