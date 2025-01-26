using System;

namespace OopsConcept
{
    class Person2
    {   public string Name { get; set; }
        public int Age { get; set; }

        public void DisplayPerson()
        {
            Console.WriteLine("Name and age of person is: " + Name + " " + Age);
        }
    }
    class Teacher : Person2
    {
        public string Subject { get; set; }

        public void Teach()
        {
            Console.WriteLine("Teacher Name and Subject is: " + Name + " " + Subject);
        }
    }
    class Principal : Teacher
    {
        public string CollegeName { get; set; }

        public void ManageCollege()
        {
            Console.WriteLine("Principal is managing the : " + CollegeName);
        }

        public void DisplayPrincipalInfo()
        {
            Console.WriteLine($"Principal: {Name}, Age: {Age}, College: {CollegeName}");
        }
    }
    internal class MultilevelInheritance
    {
        public static void Main()
        {
            Principal principal = new Principal();
            principal.Name = "ABC";
            principal.Age = 50;
            principal.Subject = "Math";
            principal.CollegeName = "Sveri College";
            principal.DisplayPerson();
            principal.Teach();
            principal.ManageCollege();
            principal.DisplayPrincipalInfo();
        }
    }
}
