namespace Boxing_Unboxing_In_CSharp;

internal interface IPrint
{
    void Print();
}


internal struct PrintStruct : IPrint
{
    public readonly void Print()
    {
        Console.WriteLine("Hello World, From Print Class");
    }
}

internal class InterfacesWithValueTypes  
{
    public static void Problem(IPrint print)
    {
        print.Print();
    }

    public static void Solution<T>(T print) where T : IPrint
    {
        print.Print();
    }

}
