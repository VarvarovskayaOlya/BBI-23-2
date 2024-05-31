using System;
struct Employee
{
    private string Name;
    private int UniqueID;
    private int Age;
    private int YearOfHiring;
    private double Salary;
    private static int employeesHiredAfter2020 = 0;

    public Employee(string name, int age, int yearOfHiring, double salary)
    {
        Name = name;
        UniqueID = ++employeesHiredAfter2020;
        Age = age;
        YearOfHiring = yearOfHiring;
        Salary = salary;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Сотрудник {Name} (Табельный номер: {UniqueID})");
        Console.WriteLine($"Возраст: {Age}, Год приема на работу: {YearOfHiring}, Зарплата: {Salary}");
        Console.WriteLine();
    }
    public static void SortEmployees(Employee[] employees)
    {
        for (int i = 0; i < employees.Length - 1; i++)
        {
            for (int j = i + 1; j < employees.Length; j++)
            {
                if (string.Compare(employees[i].Name, employees[j].Name) > 0)
                {
                    Employee temp = employees[i];
                    employees[i] = employees[j];
                    employees[j] = temp;
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[5];
        employees[0] = new Employee("Недотёпов", 25, 2016, 150000);
        employees[1] = new Employee("Дураков", 41, 2024, 26000);
        employees[2] = new Employee("Простофилин", 21, 2022, 95000);
        employees[3] = new Employee("Идиотов", 28, 2022, 185000);
        employees[4] = new Employee("Болванко", 33, 2017, 340000);

        Employee.SortEmployees(employees);

        foreach (var employee in employees)
        {
            employee.DisplayInfo();
        }
    }
}















