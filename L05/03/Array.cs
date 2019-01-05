using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Array
    {
        int[] array;
        public Array(params int[] array)
        {
            this.array = array;
        }
        
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public int Length()
        {
            return array.Length;
        }

        public void PrintAllArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i!=array.Length-1)
                {
                     Console.Write(array[i] + "; ");
                }
                else
                {
                    Console.Write(array[i]+".\n");
                }

               
            }
        }


    }
}
