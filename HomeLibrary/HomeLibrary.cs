using System;

namespace HomeLibrary
{
    class HomeLibrary
    {
        static void Main(string[] args)
        {

            //Start program

            string readLine = "";
            while (readLine != "end" && readLine != null)
            {

                readLine = Messages.WelcomeScreen("WelcomeScreen"); // Screen with the main menu.


                if (readLine == "C" | readLine == "c") // Displays the menu for creating new Items.
                {

                    do
                    {
                        readLine = Messages.NewLibraryItem("NewLibraryItem"); 
                        switch (readLine)
                        {
                            
                            case "B":
                            case "b":
                                SQLPart.NewBookSQL("NewBook"); // Creates new Item: Book.
                                break;
                            case "M":
                            case "m":
                                Console.WriteLine("Under construction"); // Creates new Item: Music (in the future).
                                Messages.PressAnyKey("Key");
                                break;
                            default:
                                Console.Clear();
                               break;
                        }

                    } while (readLine != "R" && readLine != "r"); 
 
                }
                else if (readLine == "A" | readLine == "a")  // Displays the basic information about the aplication.
                {
                    Messages.AboutInfo("AboutInfo");
                    readLine = Messages.PressAnyKey("Key");

                }
                else if (readLine == "E" | readLine == "e") // Displays the exit menu.
                {
                    Messages.Exit("confirmExit");
                }
                else if (readLine == "S" | readLine == "s") // Displays the search menu.
                {
                    do
                    {
                        readLine =  Messages.SearchLibraryItemQuestion("Search");


                        switch (readLine) //to rebuild
                        {
                            case "A":
                            case "a":
                            case "T":
                            case "t":
                                SQLPart.SearchLibraryItemSQL(readLine);
                                break;


                            default:
                                Console.Clear();
                                break;
                        }
                       

                    } while (readLine != "R" && readLine != "r") ;
            }
                



            }



        }
    }
}
