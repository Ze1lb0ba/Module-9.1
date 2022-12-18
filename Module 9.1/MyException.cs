using System;

namespace Module_9._1
{
    class MyException : Exception
    {
        public MyException(string message) : base(message){ }
        public static MyException TryCatchFinally(int enter)
        {
            if (enter == 1 || enter == 2 || enter == 0)
            {
                return null;
            }
            else throw new MyException("Введено неправильное значение");
        }
    }
}
