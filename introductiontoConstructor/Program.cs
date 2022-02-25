using System;
public class Employee
{
    public int id;
    public String name;
    public float salary;
    public int age;
    public Employee(int id, String name, float salary)
    {
        this.id = id;
        this.name = name;
        this.salary = salary;
       
    }
    public void display()
    {
        Console.WriteLine(id  + " " + name + " " + salary +  age);
    }
}
public class TestConExample
{

    public TestConExample()
    {
        Console.WriteLine("Default Constructor Invoked");
    }
    public static void Main(string[] args)
    {
        TestConExample e1 = new TestConExample();
        Employee emp = new Employee(110, "Azeem Abbas", 20000);

        emp.display();
        Console.ReadLine();


    }
}