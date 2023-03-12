namespace RecursiveAndExtensionMethods;
class Program
{
    static void Main(string[] args)
    {
        Recursive rec = new();
        
        // Recursive Method
        Console.WriteLine(rec.Expo(4,5));   // 1024

        // Extension Methods
        string text =  "Hello World!";

        bool result = text.CheckSpaces();
        Console.WriteLine(result);          // True

        Console.WriteLine(text.RemoveSpaces());   // HelloWorld!

        Console.WriteLine(text.MakeUpperCase());  // HELLO WORLD!

        int[] array = {4,6,1,9,5};
        array.SortArray();              // 1,4,5,6,9
        array.WriteSortedArray();




    }
}

public class Recursive
{
    // Recursive Method
    public int Expo(int number, int power)
    {
        if(power<2)
        {
            return number;
        }
        return Expo(number,power-1) * number;
    }
}
public static class Extension
{
    // Extension Methods
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveSpaces(this string param)
    {
        string[] array = param.Split(" ");
        return string.Join("",array);
    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }

    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void WriteSortedArray(this int[] param)
    {
        foreach (var item in param)
        {
            Console.WriteLine(item);
        }
    }
}
