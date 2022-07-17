using Newtonsoft.Json;

namespace JsonExercise;

internal class Program : object
{
  public Program() : base()
  {
  }

  public static void Main()
  {
    string json = File.ReadAllText(@"C:\Users\Aminsystem\source\repos\JsonExercise\Employee.json");

    var ojbEmployee = JsonConvert.DeserializeObject<List<Employee>>(json);

    var filtered = from employee in ojbEmployee
      where employee.Age > 20 && employee.gender == "Male"
      select employee;

    Console.WriteLine($"total: {filtered.Count()} ");

    filtered.ToList().ForEach(c=> Console.WriteLine($"ID: {c.id}, Full name: {c.first_name} {c.last_name}, Gender: {c.gender}\n"));
  }
}
