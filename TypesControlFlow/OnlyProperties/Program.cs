using Galileo.Space;

Employee e = new Employee("Matt", "Porter", 55)
{
    StartDate = new DateOnly(2022, 1, 15)
};

Console.WriteLine($"Nombre {e.FirstName}  id {e.Id}, hello world");
