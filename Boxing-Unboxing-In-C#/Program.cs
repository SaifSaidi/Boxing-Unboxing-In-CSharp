
using Boxing_Unboxing_In_CSharp;

Console.WriteLine("Non Generic Collections Using");

NonGenericCollections.Problem();

Console.WriteLine("Using Generic Collections");

NonGenericCollections.Solution();

Console.WriteLine("----- ------ -----");

int value = 100;

Console.WriteLine("Passing Value Types To Methods Problem");

PassingValueTypesToMethods.Problem(value); // boxing

Console.WriteLine("Passing Value Types To Methods Solution 1: Pass same datatype");

PassingValueTypesToMethods.Solution1(value);

Console.WriteLine("Passing Value Types To Methods Solution 2: Use generics to avoid boxing");

PassingValueTypesToMethods.Solution2<int>(value);


Console.WriteLine("----- ------ -----");

Console.WriteLine("Interfaces With Value Types Problem");

PrintStruct ps = new();

InterfacesWithValueTypes.Problem(ps); // boxing, ps is value type

Console.WriteLine("Interfaces With Value Types Solution");

InterfacesWithValueTypes.Solution(ps);
