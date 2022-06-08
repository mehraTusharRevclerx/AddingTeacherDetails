using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingTeacherDetails
{

    class TeacherMain
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string education;
        public string Education
        {
            get { return education; }
            set { education = value; }
        }

        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        string experience;

        public string Experience
        {
            get { return experience; }
            set { experience = value; }
        }
    }

    class TeacherOne : TeacherMain
    {
        int appoint;
        public int Appoint
        {
            get { return appoint; }
            set { appoint = value; }
        }
    }

    class input : TeacherOne
    {
        input()
        {
            Name = Console.ReadLine();

        }

    }
    class Program : TeacherOne
    {
        public static int age;
        public static int appoint;
        static void Main()
        {
            userInput();


        }
        static void userInput()
        {
            Console.WriteLine("Please Enter Teacher Name: ");
            string nameInput = Console.ReadLine();
            while (!IsValidName(nameInput))
            {
                nameInput = Console.ReadLine();
            };

            Console.WriteLine("Please Enter Teacher Age: ");
            string ageInput = Console.ReadLine();
            //int age;
            //while (!int.TryParse(ageInput, out age))
            while (!ageValid(ageInput))
            {
                //Console.WriteLine("Please Enter Valid Age");
                ageInput = Console.ReadLine();
            }

            Console.WriteLine("Please Enter Teacher Education: ");
            string EduInput = Console.ReadLine();
            while (!strValid(EduInput))
            {
                EduInput = Console.ReadLine();
            };


            Console.WriteLine("Please Enter Teacher Expericence: ");
            string experienceInput = Console.ReadLine();
            while (!strValid(experienceInput))
            {
                experienceInput = Console.ReadLine();
            };


            Console.WriteLine("Which Class Teacher Need To Appoint: ");
            string appointInput = Console.ReadLine();
            while (!appointValid(appointInput))
            {
                appointInput = Console.ReadLine();
            };


            TeacherOne teacher1 = new TeacherOne();
            teacher1.Name = nameInput;
            teacher1.Age = age;
            teacher1.Education = EduInput;
            teacher1.Experience = experienceInput;
            teacher1.Appoint = appoint;


            Console.WriteLine($"Teacher Appointed Successfully\n");
            Console.WriteLine($"TEACHER NAME: {teacher1.Name}");
            Console.WriteLine($"TEACHER Age: {teacher1.Age}");
            Console.WriteLine($"TEACHER Education: {teacher1.Education}");
            Console.WriteLine($"TEACHER Experience: {teacher1.Experience}");
            Console.WriteLine($"TEACHER Appoint: {teacher1.Appoint}");
            Console.ReadKey();
        }


        public static bool IsValidName(string nameInput)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(nameInput))
            {
                Console.WriteLine("Name Input Can't Be Empty!(PLEASE ENTER THE INPUT AGAIN)");
                isValid = false;
            }
            else
            {

                if (nameInput.Length <= 2)
                {
                    Console.WriteLine("Name Input Should Be More Than 2 Character!(PLEASE ENTER THE INPUT AGAIN)");
                    isValid = false;

                }
                else if (nameInput.Length >= 15)
                {
                    Console.WriteLine("Name Input Should Be less Than 15 Character!(PLEASE ENTER THE INPUT AGAIN)");
                    isValid = false;
                }
                else
                {

                    foreach (char c in nameInput)
                    {
                        if (!Char.IsLetter(c) && !Char.IsWhiteSpace(c))
                        {
                            Console.WriteLine("Name Input Should Only Contains Characters No Special Character or Number Allowed (PLEASE ENTER THE INPUT AGAIN)");
                            isValid = false;
                            return false;
                        }
                    }
                }

            }
            return isValid;
        }


        public static bool strValid(string input)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Address Input Should Not be Empty(PLEASE ENTER THE INPUT AGAIN)");
                isValid = false;
            }
            else
            {
                if (input.Length <= 3)
                {
                    Console.WriteLine("Address Input Should Be More than 3 Character(PLEASE ENTER THE INPUT AGAIN)");
                    isValid = false;
                }
                else if (input.Length > 50)
                {
                    Console.WriteLine("Address Input Should Be Less Than 50 Character(PLEASE ENTER THE INPUT AGAIN)");
                    isValid = false;
                }
            }
            return isValid;
        }


        public static bool ageValid(string input)
        {
            bool isValid = true;

            if (!int.TryParse(input, out age))
            {
                Console.WriteLine("Age Input is Wrong");
                isValid = false;
            }
            else
            {
                if (age <= 15)
                {
                    Console.WriteLine("age Input Should Be More than 15 Years");
                    isValid = false;
                }
                else if (age >= 50)
                {
                    Console.WriteLine("age Input Should Be less than 50 Years");
                    isValid = false;
                }
            }
            return isValid;
        }


        public static bool appointValid(string input)
        {
            bool isValid = true;
            if (!int.TryParse(input, out appoint))
            {
                Console.WriteLine("Appoint Input is Wrong");
                isValid = false;
            }
            else
            {
                if (appoint < 1)
                {
                    Console.WriteLine("Appoint Input Should Be More than 1");
                    isValid = false;
                }
                else if (appoint > 10)
                {
                    Console.WriteLine("Appoint Input Should Be less than 10");
                    isValid = false;
                }
            }
            return isValid;
        }

    }
}
