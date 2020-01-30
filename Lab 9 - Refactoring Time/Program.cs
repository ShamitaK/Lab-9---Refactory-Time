using System;
using System.Collections.Generic;

namespace Lab_9___Refactoring_Time
{
    class Program
    {
        static void Main(string[] args)
        {


            while (Continue())
            {
                Console.WriteLine("Which student would you like to inquire about? Please enter a number 1 - 4: ");
                DisplayNames(students);
                //The list of items used in this lab
                List<string> students = new List<string> { "Scott", "Shamita", "Sabrina" };
                List<string> food = new List<string> { "Drunken Noodles", "Cajun Pasta", "Ramen" };
                List<string> color = new List<string> { "Green", "Blue", "Black" };

                bool keepAdding = true;
                do
                {
                    AddUserInputToList(students, "What student did you want to learn about?");
                    keepAdding = KeepGoing("Another student?  y/n");
                }
                while (keepAdding);
            }

            // try to convert the words into numbers instead of choosing what word (student/favorite food/favorite color.
            string choiceFood;
            int userStudentChoice = int.Parse(Console.ReadLine());
            if (userStudentChoice == food)
            {
                GetUserInput($"{student[index] favorit food is food[index]");

            }
            else (userStudentChoice != "food");
            {
                GetUserInput("student[index] favorite color is color[index]");
            }
            else if (userStudentChoice == color)
            {
                GetUserInput($"{student[index] favorit food is food[index]");
            }
            else
            {
                Console.WriteLine("invalid entry");
            }
        }
        public static bool KeepGoing(string message, string food, string color)
       {
             string keepGoing = GetUserInput(message);
            if (keepGoing == food)
        {
            return false;
        }
            else if (keepGoing == color)
        {
            return true;
        }
        else
        {
            return KeepGoing("Not valid! " + message, food, color);
           }
        }
        public static void DisplayNames(List<string> student)
        {
            for (int i = 0; i < student.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {student[i]}");
            }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static void AddUserInputTolist(List<string> listOfStrings, string message) 
        {
            string input = GetUserInput(message);
            listOfStrings.Add(input);
            
        }

        public static bool Continue()
        {
            Console.WriteLine("Did you still want to continue? Press 'y' to continue OR 'n' to learn about another student ");
            string userContinue = Console.ReadLine().ToLower();

            if (userContinue == "y" || userContinue == "yes")
            {
                return true;
            }
            else if (userContinue == "n" || userContinue == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Uh Oh, Invalid Entry. Press 'y' to continue or 'n' to learn about another student");
                return Continue();
            }
            Console.WriteLine("Thanks for you inquiry!");
        }

    }
    class StudentInfo
    {
        public static void Main(string[] argd)
        {
            DisplayNames(students);
        }
    }
}

