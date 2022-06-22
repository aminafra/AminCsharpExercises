class Program
{
    static void Main(string[] args)
    {
        Movies.GetAllParts().Join(Movies.Movieslst(), l => l.ID, q => q.ID, (part, movies) => new
        {
            moviesName = movies.Name,
            partName = part.Name,
            yearRelease = part.yearRelease,
        }).ToList().ForEach(x => Console.WriteLine($"{x.moviesName}=>\t{x.partName}\t{x.yearRelease}"));
        Console.ReadLine();
    }
}
public class Movies
{
    public int yearRelease { get; set; }
    public int ID { get; set; }
    public string Name { get; set; }
    public static List<Movies> Movieslst()
    {
        return new List<Movies>(){
         new Movies { ID = 1, Name = "Star Wars"},
         new Movies { ID = 2, Name = "Harry Potter"}
        };
    }
    public static List<Movies> GetAllParts()
    {
        return new List<Movies>(){
            new Movies { yearRelease = 1977, Name = "A New Hope ", ID = 1 },
            new Movies { yearRelease = 1980, Name = "The Empire Strikes Back ", ID = 1 },
            new Movies { yearRelease = 1983, Name = "Return of the Jedi", ID = 1 },
            new Movies { yearRelease = 1999, Name = "The Phantom Menace", ID = 1 },
            new Movies { yearRelease = 2002, Name = "Attack of the Clones ", ID = 1 },
            new Movies { yearRelease = 2005, Name = "Revenge of the Sith ", ID = 1 },
            new Movies { yearRelease = 2015, Name = "The Force Awakens ", ID = 1 },
            new Movies { yearRelease = 2017, Name = "The Last Jedi ", ID = 1 },
            new Movies { yearRelease = 2019, Name = "The Rise of Skywalker ", ID = 1 },
            new Movies { yearRelease = 2001, Name = "Harry Potter and the Sorcerer's Stone ", ID = 2 },
            new Movies { yearRelease = 2002, Name = "Harry Potter and the Chamber of Secrets ", ID = 2 },
            new Movies { yearRelease = 2004, Name = "Harry Potter and the Prisoner of Azkaban ", ID = 2 },
            new Movies { yearRelease = 2005, Name = "Harry Potter and the Goblet of Fire ", ID = 2 },
            new Movies { yearRelease = 2007, Name = "Harry Potter and the Order of the Phoenix ", ID = 2 },
            new Movies { yearRelease = 2009, Name = "Harry Potter and the Half-Blood Prince ", ID = 2 },
            new Movies { yearRelease = 2010, Name = "Harry Potter and the Deathly Hallows: Part I ", ID = 2 },
            new Movies { yearRelease = 2011, Name = "Harry Potter and the Deathly Hallows: Part II ", ID = 2 },
        };
    }
}