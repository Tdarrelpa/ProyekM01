// See https://aka.ms/new-console-template for more information
public class Hello
{
    // main method
    public static void Main(string[] args)
    {
        string first = "John";
        string last = "Doe";

        string fullName = $"Nama saya adalah: {first} {last}";
        Console.WriteLine(fullName); // => John Doe

        string PanjangString = "Hello World!";
        Console.WriteLine(PanjangString.Length); // => 12
        Console.WriteLine(PanjangString.Contains("World")); // => True
    }
}
