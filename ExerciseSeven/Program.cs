namespace ExerciseSeven;

internal static class Program
{
    private static void Main(string[] args)
    {
        var users = new List<User>
        {
            new User { FName = "bradley", LName = "cooper" },
            new User { FName = "margot", LName = "robbie" },
            new User { FName = "tobey", LName = "maguire" },
            new User { FName = "jennifer", LName = "lawrence" },
            new User { FName = "leonardo", LName = "dicaprio" }
        };
        var bannedUsers = new List<User>
        {
            new User { FName = "jack", LName = "nicholson" },
            new User { FName = "steven", LName = "spielberg" },
            new User { FName = "matthew", LName = "mcconaughey" }
        };

        var objEve = new Eve();

        Console.WriteLine("enter first name & last name:");
        var name = Console.ReadLine()!.Split(" ");
        var firstName = name[0];
        var lastName = name[1];

        var isValid = users.Any(o => o.FName == firstName || o.LName == lastName);
        var isBanned = bannedUsers.Any(o => o.FName == firstName || o.LName == lastName);
        //users.Where(o => o.fName == firstName && o.lName == lastName).ToList().ForEach(c => Console.WriteLine($"welcome {firstName} {lastName}"));
        if (isValid)
        {
            Console.WriteLine($"Welcome {firstName} {lastName}");
        }
        else if (isBanned)
        {
            objEve.Fire();
        }
        else
        {
            Console.WriteLine("user not found");
        }
    }

    private class User
    {
        public string? FName { get; set; }
        public string? LName { get; set; }
    }

    public class Eve
    {
        public event EventHandler? EventFire;

        private void FuncForAlert(object? sender, EventArgs e)
        {
            Console.WriteLine("You was banned by Admin");
        }

        private void FuncForFire(object? sender, EventArgs e)
        {
            Console.Beep(1100, 350);
        }

        public void Fire()
        {
            EventFire += FuncForFire;
            EventFire += FuncForAlert;
            EventFire?.Invoke(this, EventArgs.Empty);
        }
    }
}