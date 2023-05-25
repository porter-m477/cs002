using Galileo.Space;

Classes();
// Structs();
// Records();


static void Classes()
{
    Console.WriteLine("=========== Classes = reference types ===========");
    //Create an employee
    Employee me = new Employee
    {
        FirstName = "Matt",
        LastName = "Porter",
        Age = new Age { BirthDate = new DateTime(1971, 9, 1), YearsOld = 50 },
        Id = 1
    };

    //otras referencias
    IPerson other = me;
    other.FirstName = "Sr. Matt";
    other.Age = new Age { BirthDate = new DateTime(1980, 9, 1), YearsOld = 39 };

    //resultados del objeto original
    Console.WriteLine($"{me.FirstName} es {me.Age.YearsOld} pero {other.FirstName} es {other.Age.YearsOld}");
    Console.WriteLine();

    ChangeName(other);
    Console.WriteLine($"{other.FirstName} {other.LastName} sigue siendo {other.Age.YearsOld}");

    Console.WriteLine();
}

static void ChangeName(IPerson person)
{
    person.LastName = "Desconocido";
    Console.WriteLine($"Persona es: {person.FirstName} {person.LastName}");

    person = new Manager("Asistente", "Porter")
    {
        Id = 2,
        Age =
        new Age { BirthDate = new DateTime(1990, 1, 1), YearsOld = 31 }
    };

    Console.WriteLine($"Persona despues del cambio de metodo es: {person.FirstName}");
}
static void Structs()
{
    Console.WriteLine("=========== Structs = value types ===========");

    Age myAge = new Age { BirthDate = new DateTime(1971, 9, 1), YearsOld = 50 };
    Age anotherAge = myAge;

    anotherAge.YearsOld = 39;

    Console.WriteLine($"Mi edad es: {myAge.YearsOld}, pero la cambiaria por: {anotherAge.YearsOld}");

    AgeBackwords(ref anotherAge, 5);

    Console.WriteLine($"Ahora tengo {anotherAge.YearsOld} años de edad");
    Console.WriteLine();
}

static void Records()
{
    Console.WriteLine("=========== Records = reference or value types ===========");

    PremiereCustomer pc = new PremiereCustomer
    {
        FirstName = "Cliente",
        LastName = "Garcia",
        Id = 7,
        Age = new Age { BirthDate = DateTime.Now, YearsOld = 1 },
        CustomerLevel = 1
    };

    PremiereCustomer pc2 = pc with { CustomerLevel = 2, LastName = "Morales" };

    Console.WriteLine($"{pc.FirstName} {pc.LastName} tiene el nivel {pc.CustomerLevel}");
    Console.WriteLine($"{pc2.FirstName} {pc2.LastName} tiene el nivel {pc2.CustomerLevel}");
    ChangeName((IPerson)pc);
    Console.WriteLine($"{pc.FirstName} {pc.LastName} tiene {pc.Age.YearsOld} años de edad");

}

static void AgeBackwords(ref Age startingAge, int numberOfYearsToAge)
{
    startingAge.YearsOld = startingAge.YearsOld - numberOfYearsToAge;
    Console.WriteLine($"Metodo de edad modificado: {startingAge.YearsOld}");
}




