namespace Meth//16_Methoden03_Mehrere

{
    internal class Program
{
    static void Main(string[] args)
    {
        int add, multi;

        add = AddMulti(4, 5, out multi);

    }
    static int AddMulti(int a, int b, out int multi)
    {
        multi = a * b;
        return a + b;
    }
}
}
