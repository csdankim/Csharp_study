using System;
using System.Collections.Generic;

namespace Generic
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }

    class ManageEmployee
    {
        List<Employee> empCollection = new List<Employee>();
        public void AddEmployee() 
        {
            empCollection.Add(new Employee() {Id = 1, Name = "Dan", Department = "Father"});
            empCollection.Add(new Employee() {Id = 2, Name = "Jain", Department = "Mother"});
            empCollection.Add(new Employee() {Id = 3, Name = "Claire", Department = "Daughter"});
            empCollection.Add(new Employee() {Id = 4, Name = "Joseph", Department = "Son"});
        }
        public void Print()
        {
            int length = empCollection.Count;
            for (int i = 0; i < length; i++)
            {
                System.Console.WriteLine("Id = " + empCollection[i].Id + "\t" + "Name = " + empCollection[i].Name + "\t" + "Department = " + empCollection[i].Department);
            }
        }
        /* public void Remove(string name)
        {
            int length = empCollection.Count;
            for (int i = 0; i < length; i++)
            {
                if (empCollection[i].Name == name)
                    empCollection.Remove(empCollection[i]);
            }
        }*/ 
    }

    class Student
    {
        List<string> studentCollection = new List<string>();
        public void AddStudent()
        {
            studentCollection.Add("Dan");
            studentCollection.Add("Jain");
            studentCollection.Add("Claire");
            studentCollection.Add("Joseph");
        }
        public void Print()
        {
            int length = studentCollection.Count;
            for (int i = 0; i < length; i++)
            {
                System.Console.WriteLine(studentCollection[i]);
            }
        }
        public void Remove(string name)
        {
            studentCollection.Remove(name);
        }
    }
}
