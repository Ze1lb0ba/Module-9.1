using System;
using System.IO;

namespace Module_9._1
{
    class Program
    {
        public static bool Active = true;
        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEvent += PrintNames;
            while (Active)
            {
                try
                {
                    numberReader.Read();
                }
                catch (MyException my)
                {
                    Console.WriteLine(my.Message);
                }
            }
        }

        static string[] NameSortirator(string[] names)
        {
            Array.Sort(names);
            return names;
        }

        static void PrintNames(int enter)
        {
            LastNameBase lastName = new LastNameBase();
            string[] names = NameSortirator(lastName.secondName);
            switch (enter)
            {
                case 1:
                    foreach(string s in names)
                    {
                        Console.WriteLine(s);   
                    }
                    break;
                case 2:
                    for (int i = names.Length-1; i >= 0; i--)
                    {
                        Console.WriteLine(names[i]);
                    }
                    break;
                case 0:
                    Active = false;
                    break;
            }
        }        
    }
}
