namespace Assignment07
{
    internal class Program
    {
       static void Main(string[] args)
        {
           Person person = new Person();
            person.AcceptData();
            Console.WriteLine("*****************************************************************************");
            person.PrintData();
            Console.WriteLine("*****************************************************************************");
            person.AgeOfPerson();
            Console.ReadLine();
        }

        public class Person 
        {
            private string _Name;
            private bool _Gender;
            private Date _Birth;
            private string _Address;

            public Person() {
                this._Birth = new Date();
            }

            public Person(string Name, bool Gender, Date Birth, string Address)
            {
                this._Name = Name;
                this._Gender = Gender;
                this._Birth = Birth;
                this._Address = Address;
            }

            public string Address
            {
                get { return _Address; }
            }
            public Date Birth
            {
                get { return _Birth; }
            }
            public bool Gender
            {
                get { return _Gender; }
            }
            public string Name
            {
                get { return _Name; }
            }

            public void AcceptData()
            {
                Console.WriteLine("Enter the Name");
                this._Name = Console.ReadLine();
                Console.WriteLine("Enter the Gender (Male = true, Female=false)");
                this._Gender = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Enter the Date-Of-Birth");
                this._Birth.AcceptDate();
                Console.WriteLine("Enter the Address");
                this._Address = Console.ReadLine();
            }

            public void PrintData()
            {
                Console.Write("Name " + this._Name + ", Gender(M=true,F=false): " + this._Gender + ", Address: "+ this._Address + ", Date Of Birth: ");
                this._Birth.PrintDate();
                Console.WriteLine();
            }

            public void AgeOfPerson()
            {
                int year = DateTime.Now.Year-this._Birth.Year;
                Console.WriteLine("Persons Age is " + year);
            }

        }

        public class Date
        {
            private int _Day;
            private int _Month;
            private int _Year;

            public int Year
            {
                get { return _Year; }
                set { _Year = value; }
            }

            public int Month
            {
                get { return _Month; }
                set { _Month = value; }
            }

            public int Day
            {
                get { return _Day; }
                set { _Day = value; }
            }

            public Date() { }

            public Date(int Day, int Month, int Year)
            {
                this._Day = Day;
                this._Month = Month;
                this._Year = Year;
            }

            public void AcceptDate()
            {
                Console.WriteLine("Enter the Day");
                this._Day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Month");
                this._Month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Year");
                this._Year = Convert.ToInt32(Console.ReadLine());
            }

            public void PrintDate()
            {
                Console.WriteLine("Day: " + this._Day + ", Month: " + this._Month + ", Year: " + this._Year);
            }

            public bool isValid()
            {
                if (this._Day < 32 && this._Day > 0)
                {
                    if (this._Month < 13 && this._Month > 0)
                        if (this._Year > 0)
                            return true;
                }
                return false;
            }
            public string ToString()
            {
                return "Day: " + this._Day + ", Month: " + this._Month + ", Year: " + this._Year;
            }

            public static int operator -(Date d1, Date d2)
            {
                return d1.Year - d2.Year;
            }

        }
    }
}
