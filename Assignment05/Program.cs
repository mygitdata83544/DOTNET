using System.Collections;
using static Assignment05.Program;

namespace Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] student;
            Console.WriteLine("Enter No. of Students");
            int x = Convert.ToInt32(Console.ReadLine());
            student = CreateArray(x);
            AcceptInfo(student);
            PrintInfo(student);
            Console.WriteLine("---------------------------------------");
            ReverseArray(student);
        }

        public static Student[] CreateArray(int i)
        {
            return new Student[i];
            
        }

        public static void AcceptInfo(Student[] students)
        {
            for (int i = 0; i < students.Length; i++) 
            {
                Console.WriteLine("---------------------------------------");
                Student student = new Student();
                Console.WriteLine("Enter Name");
                student.Name = Console.ReadLine();
                Console.WriteLine("Enter Gender");
                char g = Convert.ToChar(Console.ReadLine());
                if ( g == 'M')
                    student.Gender = true;
                else if (g == 'F')
                    student.Gender = false;
                else
                    Console.WriteLine("Enter Valid Gender");
                Console.WriteLine("Enter Age");
                student.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Standard");
                student.Std = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Division");
                student.Div = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter Marks");
                student.Marks = Convert.ToDouble(Console.ReadLine());
                students[i] = student;
            }
        }

        public static void PrintInfo(Student[] students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine("Name: " + student.Name + ", Gender: " + student.Gender + ", Age: " + student.Age + ", Standard: " + student.Std + ", Division: " + student.Div + ", Marks: " + student.Marks);
            }
        }

        public static void ReverseArray(Student[] students)
        {
            for (int i = students.Length-1;i>=0;i--)
            {
                Console.WriteLine("Name: " + students[i].Name + ", Gender: " + students[i].Gender + ", Age: " + students[i].Age + ", Standard: " + students[i].Std + ", Division: " + students[i].Div + ", Marks: " + students[i].Marks);
            }
        }
        public class Student
        {
            private string _Name;
            private bool _Gender;
            private int _Age;
            private int _Std;
            private char _Div;
            private double _Marks;
            public Student() { }
            public Student(string name, bool gender, int age, int std, char div, double marks)
            {
                this._Name = name;
                this._Gender = gender;
                this._Age = age;
                this._Std = std;
                this._Div = div;
                this._Marks = marks;
            }
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }

            public bool Gender
            {
                get { return _Gender; }
                set { _Gender = value; }
            }
            public int Age
            {
                get { return _Age; }
                set { _Age = value; }
            }
            public int Std
            {
                get { return _Std; }
                set { _Std = value; }
            }
            public char Div
            {
                get { return _Div; }
                set { _Div = value; }
            }
            public double Marks
            {
                get { return _Marks; }
                set { _Marks = value; }
            }

            public string PrintDetails()
            {
                return "Name: " + this._Name + ", Gender: " + this._Gender + ", Age: " + this._Age + ", Standard: " + this._Std + ", Division: " + this._Div + ", Marks: " + this._Marks;
            }
        }
    }
}
