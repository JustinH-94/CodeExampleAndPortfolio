using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CodeExample
{
    class Method
    {
        int size = 100;
        int[] SomeArray;
        public Method()
        {
            randomizer();
            Constant();
            Space();
            Linear();
            Space();
            Quadtratic();
            ReadKey(true);
        }

        void Constant() => WriteLine(SomeArray[20]); //Because the method is only calling for one input in the list. The time needed to execute this code will always be the same.

        void Linear() //This method calls for every element in the array. As the compiler runs through the array, time passes until every element in the array is displayed. 
        {             //Meaning time needed to run through the array remains consistent.
            for (int i = 1; i < SomeArray.Length; i++)
                WriteLine(SomeArray[i]);
        }

        void Quadtratic() //This method calls for every element in the array twice. Every element in the second foreach loop will be displayed as the first foreach loop will remain on its first.
        {                 //This will repeat itself until every element in the first foreach loop is displayed. This quadratic because despite having the same array size. The time needed to finish this code will greatly pass.
            foreach(int i in SomeArray)
            {
                foreach (int s in SomeArray)
                    WriteLine($"{i}, {s}");
            }
        }

        void randomizer()
        {
            SomeArray = new int[size+1];
            for (int i = 1; i < SomeArray.Length; i++)
                SomeArray[i] = i;
        }

        void Space() => WriteLine("\n\n\n\n\n");
    }
}
