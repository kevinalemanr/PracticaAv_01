using NCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaA01
{
    public class Numbers
    {
        public List<int> numbers = new List<int>();
        public double vResult;
        public Numbers(int[] a)
        {
            for (int i = 0; i < a.Length; i++) 
            {
                numbers.Add(a[i]);
            }
        }


        public bool EvenNumbers(int num)
        {
            if (num % 2 == 0)
                return true;
            else
                return false;

        }

        public bool OddNumbers(int num)
        {
            if (num % 2 != 0)
                return true;
            else
                return false;
        }

        public void OrderAscending(int[] b)
        {
            List<int> ascList = new List<int>();

            for (int i = 0; i < b.Length; i++)
            {
                ascList.Add(b[i]);
            }
            ascList.Sort();

            foreach (int number in ascList)
            {
                Console.WriteLine(number);
            }
        }

        public List<int> OrderDescending(int[] a)
        {
            List<int> descList = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                descList.Add(a[i]);
            }
            descList.Sort();
            descList.Reverse();

            return descList;
        }

        public bool IsMultipleOfThree(int num)
        {
            if (num % 3 == 0)
                return true;
            else
                return false;
        }

        public void  GetMaxValue()
        {
            vResult = numbers.Max();
        }

        public void GetMinValue()
        {
            vResult = numbers.Min();
        }

        public void GetAverage()
        {
            int suma = numbers.Sum();
            vResult= suma / numbers.Count();
        }

        public void GetARMS()
        {
            List<int> squad = new List<int>();

            foreach (int number in numbers)
            {
                squad.Add(number * number);
            }
            vResult = Math.Sqrt((squad.Sum()) / squad.Count);
        }

        public void PrintResults(double result)
        {
            Console.WriteLine(" {0}", result);
        }

    }
}
