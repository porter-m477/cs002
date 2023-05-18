namespace Galileo.Space;

public interface IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
public abstract class Employee : IPerson
{
    //IPerson
    public string LastName { get; set; }
    public string FirstName { get; set; }


    public DateOnly StartDate { get; set; }

    //propiedad virtual
    public virtual DateTime EndDate { get; set; }

    //propiedad abstracta
    public abstract int EmployeeId { get; }

    //
    public abstract bool ProcessPayroll();

    //
    public virtual void Terminate(DateTime terminationEffectiveDate)
    {
        Console.WriteLine("empleado despedido");
        EndDate = terminationEffectiveDate;
    }

    //mostrar o esconder
    public bool IsActive()
    {
        Console.WriteLine("Activo");
        DateOnly current = DateOnly.FromDateTime(DateTime.Now);
        return current > StartDate && DateTime.Now < EndDate;
    }
}

public class ShiftWorker : Employee
{
    public TimeOnly ShiftStartTime { get; set; }
    public override int EmployeeId { get => 1; }

    public override bool ProcessPayroll()
    {
        Console.WriteLine("rol de pago");
        return true;
    }
    public new bool IsActive()
    {
        Console.WriteLine("activo");
        return false;
    }
}
public class Manager : Employee, IPerson
{
    public int NumberOfDirectReports { get; set; }
    public override int EmployeeId { get => new System.Random().Next(1, 100); }

    public override bool ProcessPayroll()
    {
        Console.WriteLine("rol de pago supervisor");
        return true;
    }

    public new void Terminate(DateTime terminationEffectiveDate)
    {
        //pasos especificos
        Console.WriteLine("supervisor despedido");

        //optional
        base.Terminate(terminationEffectiveDate);
    }
}
