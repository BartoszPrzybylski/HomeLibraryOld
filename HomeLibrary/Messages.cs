using System;
using System.Collections.Generic;
using System.Text;


namespace HomeLibrary
{
    class Messages
    {

        public void AddLibraryItem(string Text)
        {

        Console.WriteLine("Please write " + Text);

        }


        public static int checkIfInt(string param)
        {

            int YearOfPublication = 0;
            bool IsInt;
            do
            {

                try
                {
                    YearOfPublication = int.Parse(Console.ReadLine());
                    IsInt = true;
                }
                catch (Exception)
                {
                    Console.WriteLine(
                    "Please put correct year! eg. 1999");
                    IsInt = false;
                }
            }

            while (!IsInt);
            return YearOfPublication;
        }


        public static string PressAnyKey(string readLine)
        {
        Console.WriteLine("\nPress any key...");
        readLine = Console.ReadLine();
        Console.Clear();
        return readLine;



        }


        public static string Exit(string confirmExit)
        {
            

        Console.Clear();
        Console.WriteLine("Do you really want to exit?\n" +
                        "- Yes (Press Y)\n" +
                        "- No (Press N)");

            confirmExit = Console.ReadLine();
            
        if (confirmExit == "Y" | confirmExit == "y")
            {
                Environment.Exit(0);
               

        }
        else if (confirmExit == "N" | confirmExit == "n")     
        {
            Console.Clear();
                
        }
        else
        {
            Messages.Exit("confirmExit");
        }

        return confirmExit;

        }

        public static string AboutInfo(string AboutInfo)
        {
        Console.Clear();
        Console.WriteLine("HomeLibrary is an aplication that can be use \nto create your own home library.\n" +
            "You can store information about books, music CDs, etc.");

        return AboutInfo;

        }

        public static string WelcomeScreen(string WelcomeScreen)
        {
        Console.Clear();
        Console.WriteLine("Welcome in the HomeLibrary!\n");
        Console.WriteLine("Please select what do you want to do:");
        Console.WriteLine(
            "- Search for a record (Press S)\n" +
            "- Create a new record (Press C)\n" +
            "- About (Press A)\n" +
            "- Exit (Press E)\n");
        WelcomeScreen = Console.ReadLine();
        
        return WelcomeScreen;

        }


      

        public static string NewLibraryItem(string NewLibraryItem)
        {
        Console.Clear();
        Console.WriteLine("Please select what do you want to do:");
        Console.WriteLine(
            "- Add new  item: Book (Press B)\n" +
            "- Add new  item: Music (Press M)\n" +
            "- Return to the main menu (Press R)\n");
        NewLibraryItem = Console.ReadLine();
           
        return NewLibraryItem;

        }

        public static string SearchLibraryItemQuestion(string NewLibraryItem)
        {
            Console.Clear();
            Console.WriteLine("Please select what do you want to do:");
            Console.WriteLine(
                "- Search by the Author (Press A)\n" +
                "- Search by the Title (Press T)\n" +
                "- Return to the main menu (Press R)\n");
            NewLibraryItem = Console.ReadLine();

            return NewLibraryItem;

        }



    }
}
