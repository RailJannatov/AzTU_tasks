using System;

namespace ConsoleApp1
{
     static class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            Console.WriteLine(converter.Exchange(Currency.USD,5));
            //overload char-la
            //string text = "salam";
            int num = 17;
            //Console.WriteLine(text.CustomContains("alb"));
            //Console.WriteLine( text.CustomContains('b'));
            Console.WriteLine(num.IsPrimeNum());

        }
        //Overload char-la
         static bool CustomContains(this string text,char character)
        {
            foreach (var item in text)
            {
                if (item == character)
                {
                    return true;
                }
            }
            return false;
        }
        //salam
        //ala
        static bool CustomContains(this string text,string txt)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == txt[0])
                {
                    for (int j = 0; j < txt.Length; j++)
                    {
                        if (text[i + j] == txt[j])
                        {
                            count++;
                        }
                        else
                        {
                            count = 0;
                            break;
                        }
                    }
                    if (count == txt.Length)
                    {
                        return true;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            return false;
        }

        //isPrime
        static bool IsPrime(this int number)
        {
            bool result = true;

            for (int i = 2; i < number-1 ; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    return result;
                }
            }
            return result;
        }

        static bool IsPrimeNum(this int number)
        {
            int count = 0;
            //bool result = true;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count < 3)
            {
                return true;
            }
            return false;
        }
        
    }
}
