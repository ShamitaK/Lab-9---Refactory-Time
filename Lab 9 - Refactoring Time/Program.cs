using System;
using System.Collections.Generic;

namespace Lab_9___Refactoring_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\t\tLet's Get to Know Some Cartoon Characters!\t\n");

            List<string> cartoons = new List<string> { "Timmy Turner", "Danny Phantom", "Kim Possible", "Katsumi Jun", "Buttercup", "Add New Character"};
            List<string> food = new List<string> { "pizza", "spaghetti", "nachos from Buenos Nachos", "black bean noodles", "steak", ""};
            List<string> hometown = new List<string> { "Dimmsdale", "Amity Park", "Middleton", "Japan", "Townsville" };
            List<string> color = new List<string> { "purple", "white", "red", "blue", "green",""};
            List<string> activity = new List<string> { "hanging out with his fairy odd parents", " to beat up the evil ghosts", " to fighting the bad guys with her best friend Ron",
                    "fencing", "boxing, so she could fight the bad guys","" };
            List<string> animal = new List<string> { " goldfish", " ghost dog", "naked mole-rat", "cat", "chinchilla","" };

            try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Here are the Cartoon Characters: ");
                    DisplayCharacters(cartoons);
                    int input = GetInput($"\nWhich cartoon character would you like to learn about? \nPlease enter a number: ");

                    //used a second do-while loop so that the user can be asked if they wanted to learn something else about their choice after
                    //they are prompted
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        int input2 = GetInput($"\nNice! What did you want to learn about {cartoons[input - 1]}?\n1. Favorite Food \n2. Hometown \n3. Favorite Color " +
                            $"\n4. Favorite Activity \n5. Favorite Animal \n6. Add New Facts about Character \nPlease Enter a number from 1-6: ");

                        //displays, depending on what the user chooses to learn about their character.
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        if (input2 == 1)
                        {

                            Console.WriteLine($"\n{cartoons[input - 1]}'s favorite food is {food[input - 1]}.\n");
                        }
                        else if (input2 == 2)
                        {
                            Console.WriteLine($"\n{cartoons[input - 1]}'s hometown is in {hometown[input - 1]}.\n");
                        }
                        else if (input2 == 3)
                        {
                            Console.WriteLine($"\n{cartoons[input - 1]}'s favorite color is {color[input - 1]}.\n");
                        }
                        else if (input2 == 4)
                        {
                            Console.WriteLine($"\n{cartoons[input - 1]}'s favorite activity is {activity[input - 1]}.\n");
                        }
                        else if (input2 == 5)
                        {
                            Console.WriteLine($"\n{cartoons[input - 1]}'s favorite animal is a {animal[input - 1]}.\n");
                        }
                        else if (input2 == 6)
                        {
                            //User responses will be added to the lists above.
                            Console.Clear();

                            //Decided to add this here because I thought that the flow here would be better
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            cartoons.Add(GetUserInput("Type in new character: "));
                            food.Add(GetUserInput($"\nWhat is their favorite food: ").ToLower());
                            hometown.Add(GetUserInput($"\nWhere do they live: "));
                            color.Add(GetUserInput($"\nWhat is their favorite color: ").ToLower());
                            activity.Add(GetUserInput($"\nWhat is their favorite activity: ").ToLower());
                            animal.Add(GetUserInput($"\nWhat is their favorite animal: ").ToLower());

                            //Added this part so that the user can see the changes immediatley.
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nAwesome! Your new character has been added to the list. Check them out! \n");
                            DisplayCharacters(cartoons);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Invalid Entry. Please try again, what did you want to learn from the {cartoons[input - 1]}? \n");
                        }
                    }
                    //This is used here because if the user still wants to learn something more about their original character choice. 
                    while (GetMoreInfo());
                }
                //if user says that they don't want to learn anything else about the original character they chose, this will ask
                //if the user wanted to learn a fact from another character on the list.
                while (GetAnotherCartoonInfo());
            }
            catch(IndexOutOfRangeException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Entry! Please Try Again!");
            }
        }
        public static void DisplayCharacters(List<string> character)
        {
            //I used this in my main to display that cartoon characters
            for (int i = 0; i < character.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {character[i]}");
            }
        }

        public static int GetInput(string input)
        {
            //I used when the user needed to input a number response.
            Console.WriteLine(input);
            return int.Parse(Console.ReadLine());   //make sure to take out all the -1 in here
        }

        public static string GetUserInput(string message)
        {
            //I used this when the user needed to input a string response.
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static bool GetAnotherCartoonInfo()
        {
            //In do-while loop in the main, prompts the user to see if they wanted to pick ANOTHER character to learn about.
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            string anotherCharacter = GetUserInput("Would you like to learn about another cartoon character? Please enter y/n: \n").ToLower();
            Console.Clear();

            if (anotherCharacter == "y" || anotherCharacter == "yes")
            {
                return true;
            }
            else if (anotherCharacter == "n" || anotherCharacter == "no")
            {
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Entry, please enter either y or n");
                return GetAnotherCartoonInfo();
            }
        }
        public static bool GetMoreInfo()
        {
            //I created a seperate method because I thought the transition will be smoother 
            //and will directly ask if they would stay with the same character choice but learn something else. 
            string sameCharacter = GetUserInput("\nIf you added a new character previously, please enter 'n' to continue: \n\nIF NOT, would you like to learn another fact from your original choice? \nPlease enter y/n: ").ToLower();
            
            Console.Clear();
            if (sameCharacter == "y" || sameCharacter == "yes")
            {
                return true;
            }
            else if (sameCharacter == "n" || sameCharacter == "no")
            {
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Entry, please enter either y or n");
                return GetMoreInfo();
            }
        }

        //next time, see if you could use more methods so that the main won't look so crowded.

        //public static void AddToList(List<string> addNewInfo)
        //{
        //    string addInfo = GetUserInput("Would you like to add a character").ToLower();
        //    if (addInfo == "y" || addInfo == "yes")
        //    {
        //        string newCartoon = GetUserInput("Please enter the new character's name: ");
        //        addNewInfo.Add(newCartoon);
        //        string newFood = GetUserInput($"Please enter {newCartoon}'s favorite food: ");
        //        addNewInfo.Add(newFood);
        //        string newHometown = GetUserInput($"Please enter {newCartoon}'s hometown: ");
        //        addNewInfo.Add(newHometown);
        //        string newColor = GetUserInput($"Please enter {newCartoon}'s favorite color: ");
        //        addNewInfo.Add(newColor);
        //        string newAnimal = GetUserInput($"Please enter {newCartoon}'s favorite animal: ");
        //        addNewInfo.Add(newAnimal);
        //    }
        //    else if (addInfo == "n" || addInfo == "no")
        //    {
        //        Console.WriteLine("Have a great day!");
        //    } 
        //    else
        //    {
        //        Console.WriteLine("Invalid Entry, please enter either y or n");
        //    }
        //    //return addNewInfo;
        //}
    }
}

