using System;
using System.Globalization;

namespace Open_Lab_02._02
{
    public class Formatter
    {        
        public void Format(double[] numbers)
        {
            string j = null;
            for (int i = 0; i < numbers.Length; i++)
           
            {
                double cislo = numbers[i];
                j = j + Math.Round(cislo, 2).ToString() + " ";
               
            }
            Console.Write(j.Replace(",", ".").TrimEnd());
           
        }
    }
}
