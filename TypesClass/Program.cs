namespace TypesClass
{
    /// <summary>
    /// Represents an abstract class for animals.
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// Defines an abstract method for running.
        /// </summary>
        public abstract void Run();
    }

    /// <summary>
    /// Represents a Dog that inherits from the Animal class and implements the Run method.
    /// </summary>
    public class Dog : Animal
    {
        /// <summary>
        /// Executes the Run method for the Dog class, printing a message to the console.
        /// </summary>
        public override void Run()
        {
            Console.WriteLine("Run method called from subclass Dog of abstract class Animal");
        }
    }

    /// <summary>
    /// A static class representing a Student with a name and a method to print it.
    /// </summary>
    public static class Student
    {
        public static string StuName { get; set; }

        /// <summary>
        /// Prints the name of the student to the console.
        /// </summary>
        public static void Print()
        {
            Console.WriteLine("Print method called from static class student");
            Console.WriteLine(StuName);
        }
    }

    /// <summary>
    /// Represents a sealed class Employee with an employee name and a method to print it.
    /// </summary>
    public sealed class Employee
    {
        public string EmpName { get; set; }

        /// <summary>
        /// Prints the name of the employee to the console.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Print method called from sealed class Employee");
            Console.WriteLine(EmpName);
        }
    }

    // Cannot inherit sealed class
    // class B : Employee
    // {
    //
    // }

    /// <summary>
    /// Represents a partial class Person with a method to sleep.
    /// </summary>
    public partial class Person
    {
        /// <summary>
        /// Makes the person sleep by printing a message to the console.
        /// </summary>
        public void Sleep()
        {
            Console.WriteLine("Sleep method called from partial class Person.");
        }
    }

    /// <summary>
    /// The main entry point for the program, demonstrating the use of static, abstract, sealed, and partial classes.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method that demonstrates the usage of different types of classes.
        /// </summary>
        /// <param name="args">Command-line arguments</param>
        public static void Main(string[] args)
        {
            // static class
            // Student stu = new Student(); // gives error 
            Student.StuName = "Keyur";
            Student.Print();

            // abstract class
            Dog dog = new Dog();
            dog.Run();

            // sealed class
            Employee emp = new Employee();
            emp.EmpName = "Keyur";
            emp.Print();

            // partial class objects
            Person person = new Person();
            person.Run();
            person.Walk();
            person.Sleep();
        }
    }
}
