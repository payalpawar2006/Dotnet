class SR
{
    public void Process(Payment p)
    {
        p.Pay();
    }
    static void Main()
    {
        SR c = new SR();
        c.Process(new Creditcard());
        c.Process(new Upi());
    }
}