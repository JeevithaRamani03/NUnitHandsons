using System;
using System.Collections.Generic;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public class EmployeeManager
{
    private readonly List<Employee> employees;
    public int HeadCount { get; set; }
    public EmployeeManager()
    {
        employees = new List<Employee>();
        HeadCount = employees.Count;
    }
    public void AddEmployee(Employee empObj)
    {
        if (empObj.Name == null)
            throw new ArgumentNullException("Name cannot be null");
        employees.Add(empObj);
        HeadCount++;
    }
}