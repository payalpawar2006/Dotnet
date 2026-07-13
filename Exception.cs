/*using System;

class Exception
{

    static  void CkeckAge(int age)
    {
        if (age < 20)
        {
            throw new System.Exception ("not eleigible for placement drive");
        }
        Console.WriteLine("can attend placemnet drive");
    }
    static void Main()
    {
        try
        {
            int a =50;
            int b =5;
            int c = a/b;
            Console.WriteLine(c);

        }catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
        CkeckAge(25);

        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

}*/