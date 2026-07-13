class OC
{
    public void Pay(string method)
    {
        if(method == "Creditcard")
        {
            Console.WriteLine("paid using credit card");

        }else if(method == "UPI")
        {
            Console.WriteLine("paid using UPI");
        }
        else if(method  == "cash")
        {
            Console.WriteLine("paid using cash in bank");
        }
    }
}