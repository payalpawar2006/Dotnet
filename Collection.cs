using System.Collections.Generic;

class Collections
{
    static void Main()
    {
        List<string> names = new List<string>();
        
        names.Add("KRUSHNA");
        names.Add("PAYAL");
        names.Add("SALONI");
        names.Add("VAISHNAVI");
        names.Add("KARAN");
        names.Add("GOURAV");
        
        foreach(string f in names)
        {
            Console.WriteLine(f);
        }    }
}