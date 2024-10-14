
namespace Boxing_Unboxing_In_CSharp;
public class PassingValueTypesToMethods
    {
        public static void Problem(object value)
        { 
            Console.WriteLine(value);
        }

        public static void Solution1(int value)
        { 
            Console.WriteLine(value);
        }

        public static void Solution2<T>(T value)
        { 
            Console.WriteLine(value);
        }

}
