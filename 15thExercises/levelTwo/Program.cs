namespace levelTwo;

public class Program : object
{
    public Program() : base()
    {
    }

    public static void Main()
    {
        List<int> x = new List<int>() { 5, 9, 3, 21, 68, 2453 };
        List<int> y = new List<int>() { 5, 9, 3, 21, 68, 2453 };

        Console.WriteLine(CompareLists(x, y));

        List<string> a = new List<string> { "Parviz", "Iria", "Peter", "Asghar", "Pangoiler", "Arin", "Asghar", };
        List<string> b = new List<string> { "Parviz", "Iria", "Peter", "Asghar", "Pangoiler", "Arin", "Asghar", };

        bool isEqual = CompareLists(a, b);
        Console.WriteLine(isEqual);


        //List<bool> c = new List<bool>() { true, false };
        //List<bool> d = new List<bool>() { true, false };
    }

    public static bool CompareLists<TList>(IEnumerable<TList> firstList, IEnumerable<TList> secondList)
    {
        var fList = firstList.ToList();
        var sList = secondList.ToList();
        bool result = false;
        if (fList.Count() != sList.Count())
        {
            return false;
        }

        for (int i = 0; i < firstList.Count(); i++)
        {
            if (!Equals(fList[i], sList[i]))
            {
                return false;
            }

            result = true;
        }

        return result;
    }
}