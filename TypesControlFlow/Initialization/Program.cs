
using Galileo.Space;

Employee e = new Employee("Matt", "Porter", 35)
{
    EmployeeId = 99,
    StartDate = new DateOnly(2023, 5, 21),
};
Console.WriteLine($"Nombre: {e.FirstName} {e.LastName},id {e.Id} unico, primer dia de trabajo {e.StartDate}. Edad {e.edad}");
