using System;

class statementandloops
{
  public void show()
    {
        int marks = 85;

        if (marks >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (marks >= 75)
        {
            Console.WriteLine("Grade B");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Grade C");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}