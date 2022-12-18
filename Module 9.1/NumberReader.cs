using System;

namespace Module_9._1
{
    class NumberReader
    {
        public delegate void NumberEnteredDelegate(int number);
        public event NumberEnteredDelegate NumberEnteredEvent;

        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Введите 1 для сортировки от А до Я, введите 2 для сортировки от Я до А, 0 для остановки программы");
            int number = Convert.ToInt32(Console.ReadLine());
            MyException.TryCatchFinally(number);
            NumberEntered(number);
        }

        protected void NumberEntered(int number)
        {         
            NumberEnteredEvent?.Invoke(number);
        }
    }
}
