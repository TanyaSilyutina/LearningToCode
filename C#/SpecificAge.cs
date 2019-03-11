using System;

namespace ConsoleApp1
{    
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[2];

            persons[0] = new Person();
            persons[0].SetNameAndAge(Read.ReadName(), Read.ReadAge());
            Print.PrintResult(persons[0]);

            persons[1] = new Person();
            persons[1].SetNameAndAge(Read.ReadName(), Read.ReadAge());
            Print.PrintResult(persons[1]);
        }
    }

    class Person
    {
        public int age;
        public string name;
        private int daysBehind;
        private int hoursBehind;
        private int minutesBehind;
        private int secondsBehind;

        public void SetNameAndAge(string inputName, int inputAge)
        {
            age = inputAge;
            name = inputName;
        }

        public int CalculateDaysAlive()
        {
            const int daysInYear = 365;
            daysBehind = age * daysInYear;
            return daysBehind;
        }

        public int CalculateHoursAlive()
        {
            const int dayHours = 24;
            hoursBehind = daysBehind * dayHours;
            return hoursBehind;
        }

        public int CalculateMinutesAlive()
        {
            const int minutesInHour = 60;
            minutesBehind = hoursBehind * minutesInHour;
            return minutesBehind;
        }

        public int CalculateSecondsAlive()
        {
            const int secondsInMinute = 60;
            secondsBehind = minutesBehind * secondsInMinute;
            return secondsBehind;
        }
    }


    class Read
    {
        public static string ReadName()
        {
            Console.WriteLine("Enter your name:   ");
            return Console.ReadLine();
        }

        public static string ReadFriendName()
        {
            Console.WriteLine("Enter your friend's name:   ");
            return Console.ReadLine();
        }

        public static int ReadAge()
        {
            Console.WriteLine("Enter your age:   ");
            return int.Parse(Console.ReadLine());
        }

        public static int ReadFriendAame()
        {
            Console.WriteLine("Enter your friend's age   ");
            return int.Parse(Console.ReadLine());
        }
    }

    class Print
    {
        private static void PrintHello(Person person)
        {
            Console.WriteLine($"Hello {person.name}");
        }

        private static void PrintDaysAlive(Person person)
        {
            Console.WriteLine($"You are approximately {person.CalculateDaysAlive()} Days old!");
        }

        private static void PrintHoursAlive(Person person)
        {
            Console.WriteLine($"You are approximately {person.CalculateHoursAlive()} Days old!");
        }

        private static void PrintMinutesAlive(Person person)
        {
            Console.WriteLine($"You are approximately {person.CalculateMinutesAlive()} Days old!");
        }

        private static void PrintSecondsAlive(Person person)
        {
            Console.WriteLine($"You are approximately {person.CalculateSecondsAlive()} Days old!");
        }

        public static void PrintResult(Person person)
        {
            Print.PrintHello(person);
            Print.PrintDaysAlive(person);
            Print.PrintHoursAlive(person);
            Print.PrintMinutesAlive(person);
            Print.PrintSecondsAlive(person);
        }
    }
}