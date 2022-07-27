

static class Program
{
    static void Main(string[] args)
    {
        var bc1 = new BullsCows();
        bc1.SetPos(5, 1);
        bc1.Run();

        var bc2 = new BullsCows();
        bc2.SetPos(45, 1);
        bc2.Run();
    }


}



