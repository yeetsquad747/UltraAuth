﻿// For the latest version of the project, you can visit the GitHub Repository: https://github.com/yeetsquad747/UltraAuth
using System;

namespace UltraAuth
{
    class Program
    {
        static void Main ()
        {
            // Software Information
            Console.WriteLine("UltraAuth™ All Rights Reserved 2021.");

            // Password and Username
            String Username = "Username"; // ADD YOUR USERNAME HERE
            String Password = "Password"; // ADD YOUR PASSWORD HERE

            bool signedIn = false;
            
            // Change the appearance of console
            Console.Title = "UltraAuth™";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            
            // Will repeat until you are signed in or close window
            while (signedIn == false)
            {
                // Ask for Username
                Console.WriteLine("Username: \n");

                // Returns 0 when the input and username are the same
                int resultUsername = String.Compare(Username, Convert.ToString(Console.ReadLine()));
            
                // Checks if Username is valid
                if (resultUsername == 0) 
                { 
                    // Ask for Password
                    Console.WriteLine("Password: \n");

                    // Returns 0 when the input and Password are the same
                    int resultPassword = String.Compare(Password, Convert.ToString(Console.ReadLine()));
                
                    // Checks if Password is valid
                    if (resultPassword == 0) 
                    {
                        // Access Granted
                        signedIn = true;

                        Console.ForegroundColor = ConsoleColor.Green;
                    
                        Console.WriteLine("Access Granted \n");

                        Console.ForegroundColor = ConsoleColor.White;
                    
                        // Software Details
                        Console.WriteLine("UltraAuth™ All Rights Reserved 2021." + " You may now close this window.");
                        
                        Console.ReadKey();
                    }
                    // Is run when Password is invalid
                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    
                        Console.WriteLine("Error, That is not a valid Password");

                        Console.ForegroundColor = ConsoleColor.White;
                    }
                } 
                // Is run when Username is invalid
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                
                    Console.WriteLine("Error, That is not a valid Username");

                    Console.ForegroundColor = ConsoleColor.White;
                }
                // Access Denied
                Console.ForegroundColor = ConsoleColor.Red;
            
                Console.WriteLine("Access Denied \n");

                Console.ForegroundColor = ConsoleColor.White;

                // Software Details
                Console.WriteLine("UltraAuth™ All Rights Reserved 2021.");

                Console.ReadKey();
            }
        }
    }
}
