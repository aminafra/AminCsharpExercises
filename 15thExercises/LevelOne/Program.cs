namespace LevelOne;

public class Program : object
{
    public Program() : base()
    {
    }

    public static void Main()
    {
        List<string> strList = new List<string> { "Parviz", "Iria", "Peter", "Asghar", "Pangoiler", "Arin", "Asghar", };

        strList.Where(x => !x.StartsWith("Pa")).ToList().ForEach(Console.WriteLine); //Prints words that don't start with "Pa"

        Console.WriteLine("-----------------------------------");

        strList.RemoveAll(x => x.StartsWith("Pa")); // delete words that start with "Pa" from list
        strList.ForEach(Console.WriteLine); // print list
    }
}