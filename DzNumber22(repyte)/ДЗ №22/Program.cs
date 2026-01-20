using ДЗ__22;

public class Program
{
    public static void Main(string[] args)
    {
        EmployeeManager manager = new EmployeeManager();

        manager.AddEmployee(new Employee("Иван Иванов", Department.IT, 60000));
        manager.AddEmployee(new Employee("Петр Петров", Department.HR, 50000));
        manager.AddEmployee(new Employee("Светлана Светлова", Department.Finance, 70000));
        manager.AddEmployee(new Employee("Алексей Алексеев", Department.Marketing, 55000));
        manager.AddEmployee(new Employee("Мария Мариева", Department.IT, 65000));

        manager.GenerateReport();
    }
}