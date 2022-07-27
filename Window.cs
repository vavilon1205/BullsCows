class Window
{
    int x, y;

    public void SetPos(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    protected string Input(string hint = "")
    {
        Console.SetCursorPosition(x, y++);
        Console.Write(">>> ", hint);
        return Console.ReadLine();
    }

    protected void Print(string str)
    {
        Console.SetCursorPosition(x, y++);
        Console.WriteLine(str);
    }
    protected void Print(params object[] p)
    {
        Console.SetCursorPosition(x, y++);
        Console.WriteLine(string.Join("", p));
    }


}



