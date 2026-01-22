using ДЗ__22;

public class Program
{
    public static void Main(string[] args)
    {
        EmployeeManager manager = new EmployeeManager();

        manager.AddEmployee(new Employee("Ivan vasilevich", Department.IT, 60000));
        manager.AddEmployee(new Employee("streve jobs", Department.HR, 50000));
        manager.AddEmployee(new Employee("kto to", Department.Finance, 70000));
        manager.AddEmployee(new Employee("qwed afeaef", Department.Marketing, 55000));
        manager.AddEmployee(new Employee("dMITRY MENDELEEV  ", Department.IT, 65000));

        manager.GenerateReport();
    }
}