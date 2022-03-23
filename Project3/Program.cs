using System;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalCredits= 50;
            double totalHealth = 15;
            while(totalCredits >= 0 && totalCredits <= 300)
            {
            MenuMethod(ref totalCredits, ref totalHealth);
            }
            if(totalCredits <=0)
            {
                System.Console.WriteLine("You lost the game, better Luck next time");
            }
            if(totalCredits >= 300)
            {
                System.Console.WriteLine("Congratulations, you have won the game!");
            }
        }



        static void MenuMethod(ref double totalCredits, ref double totalHealth)
        {
            //Console.Clear();
            displayMenu(ref totalCredits);
            int userInput = int.Parse(Console.ReadLine());
        //while(totalCredits < 300 && totalCredits > 0)
        //{
        if(userInput != 4)
        {
            if (userInput == 1)
            {
                TheForceInstructions(ref totalCredits);
            }
            if (userInput == 2)
            {
                BlastersInstructions(ref totalCredits, ref totalHealth);
                // totalCredits = (totalCredits + 15);
                // MenuMethod(ref totalCredits);
            }
            if (userInput == 3)
            {
                Scoreboard();
            }
            if (userInput == 4)
            {
            }
            else
            {
                Console.Clear();
                System.Console.WriteLine("Invalid intiger. Please try again");
                MenuMethod(ref totalCredits, ref totalHealth);

            }
        }
        else
        {

        }
        //}
        // if(totalCredits <= 0)
        // {
        //     System.Console.WriteLine("You lost the game, better Luck next time");
        // }
        // if(totalCredits >= 300)
        // {
        //     System.Console.WriteLine("Congratulations, you have won the game!");
        // }
        }
        


        static void displayMenu(ref double totalCredits)
        {
            System.Console.WriteLine("\t\tWelcome to the Gaming Center \nPlease enter the corresponding intiger to make your selection");
            System.Console.WriteLine($"Credits:{totalCredits}");
            System.Console.WriteLine("1. The Force");
            System.Console.WriteLine("2. Blasters");
            System.Console.WriteLine("3. Exit Gaming Center");
        }



        // static void CheckCreditBalance(ref double totalCredits)
        // {
        //     Console.WriteLine("You need to do better, you only have "+ totalCredits + " credits!");
        //     System.Console.WriteLine("Enter any intiger to return to menu");
        //      int userInput = int.Parse(Console.ReadLine());
        //     if (userInput == 4)
        //     {
        //         MenuMethod(ref totalCredits);
        //     }
        //     else
        //     {
        //         MenuMethod(ref totalCredits);
        //     }
        // }

        




        static void Scoreboard()
        {

        }
        static void TheForceInstructions(ref double totalCredits)
        {
            System.Console.WriteLine($"In this game, 10 random cards will be set in front of you face down. The first card will be revealed \n and you have to decide if the next card will be either higher or lower than the card that is currently face up. \n If you get 5 in a row correct, you will get the amount you bet back. If you get 7 in a row correct, your credits \n bet will double. And if you get all 10 in a row correct, your bet will triple. \n\t\t That being said, would you like to proceed? \n\t\t\t 1. Continue \n\t\t\t 2. Exit to Menu");
            int userInput = int.Parse(Console.ReadLine());
            if(userInput == 1)
            {
             TheForce(ref totalCredits); 
            }
            if(userInput == 2)
            {

            }
        }
        static void TheForce(ref double totalCredits)
        {
            int betCredits = 0;
            int count = 0;
            int suitCount = 4;
            int valCount = 13;
            string[] suits = {"Clubs","Spades","Diamonds","Hearts"};
            string[] values = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
            string[] deck = new string [52];
            int userInput = int.Parse(Console.ReadLine());

            for(int s = 0; s < suitCount; s++)
            {
                for(int v = 0; v < valCount; v++)
                {
                    count++;
                }
            }
                //while(userInput != 2)
                //{
                System.Console.WriteLine("How many credits would you like to bet?");
                betCredits = userInput;
                totalCredits = totalCredits - betCredits;
                //}
                Random r = new Random();
                int number = r.Next(0, 11); 
                



            

        }


        static void BlastersInstructions(ref double totalCredits, ref double totalHealth)
        {
            System.Console.WriteLine("In this game, you are being shot at by Yoda. you can either attempt to dodge or deflect his lasers. \nDodging will grant you 5 points while deflecting will grant 10. But be careful, defecting is an \nadvanced move that is much harder to master. If you fail and get hit, you will lose 5 points. \n\t\t This game costs 20 credits, would you like to begin?\n\t\t\t\t 1. Continue \n\t\t\t\t 2. Exit to Menu");
            int userInput = int.Parse(Console.ReadLine());
            if(userInput == 1)
            {
                Blasters(ref totalCredits, ref totalHealth);
                MenuMethod(ref totalCredits, ref totalHealth);
            }
            if(userInput == 2)
            {
                MenuMethod(ref totalCredits, ref totalHealth);
            }
            //if(userInput != 1 && userInput != 2)
            else
            {
                System.Console.WriteLine("Invalid Intiger, try again");
                BlastersInstructions(ref totalCredits, ref totalHealth);
            }
        }
        static void Blasters(ref double totalCredits, ref double totalHealth)
        {
            //totalHealth = 15;     //resets total health to 15 when initialized between games
            totalCredits = (totalCredits - 20);
            System.Console.WriteLine($"Health: {totalHealth}");
            System.Console.WriteLine("A laser is coming right for you!");
            System.Console.WriteLine("What would you like to do?");
            System.Console.WriteLine("1. Dodge");
            System.Console.WriteLine("2. Deflect");
            int userInput = int.Parse(Console.ReadLine());
            while(totalHealth > 0 && totalHealth < 40)
            {
            if(userInput == 1)    //dodge laser
            {
                Random r = new Random();
                int number = r.Next(0, 2); 
                //while(totalHealth > 0 && totalHealth < 40)
                //{
                if(number == 0)
                {
                    System.Console.WriteLine("Congratulations, you successfully dodged the laser");
                    totalHealth = totalHealth + 5;
                    if(totalHealth < 40 || totalHealth > 0)
                    {
                    Blasters(ref totalCredits, ref totalHealth);
                    }
                    else
                    {

                    }
                }
                else
                {
                    System.Console.WriteLine("Oh no, you were hit with the laser!");
                    totalHealth = totalHealth - 5;
                    if(totalHealth < 40 || totalHealth > 0)
                    {
                    Blasters(ref totalCredits, ref totalHealth);
                    }
                    else
                    {

                    }
                }
                }

                //}


                
            else if(userInput == 2)     //Deflect laser
            {
                Random r = new Random();
                int number = r.Next(0, 3); 
                 //while(totalHealth > 0 && totalHealth < 40)
                //{
                if(number == 0)
                {
                    System.Console.WriteLine("Congratulations, you successfully dodged the laser");
                    totalHealth = totalHealth + 10;
                    if(totalHealth < 40 || totalHealth > 0)
                    {
                    Blasters(ref totalCredits, ref totalHealth);
                    }
                    else
                    {

                    }
                }
                else if(number == 1)
                {
                    System.Console.WriteLine("Oh no, you were hit with the laser!");
                    totalHealth = totalHealth - 10;
                     if(totalHealth < 40 || totalHealth > 0)
                    {
                    Blasters(ref totalCredits, ref totalHealth);
                    }
                    else
                    {

                    }
                }
                }
                else if(userInput != 1 && userInput != 2)
                {
                    System.Console.WriteLine("Invalid Input Try Again");
                    Blasters(ref totalCredits, ref totalHealth);
                }

                // if(totalHealth >= 40)
                // {
                //     totalCredits = totalCredits + 40;
                //     System.Console.WriteLine("Congratulations, you won the game!");
                //     System.Console.WriteLine("1. Play again");
                //     System.Console.WriteLine("2. Main Menu");
                //     if(userInput == 1)
                //     {
                //         Blasters(ref totalCredits, ref totalHealth);
                //     }
                //     else if(userInput == 2)
                //     {
                //         MenuMethod(ref totalCredits, ref totalHealth);
                //     }
                //}
            }
                if(totalHealth >= 40)
                {
                    totalCredits = totalCredits + 40;
                    System.Console.WriteLine("Congratulations, you won the game!");
                    System.Console.WriteLine("1. Play again");
                    System.Console.WriteLine("2. Main Menu");
                    if(userInput == 1)
                    {
                        Blasters(ref totalCredits, ref totalHealth);
                    }
                    else if(userInput == 2)
                    {
                        MenuMethod(ref totalCredits, ref totalHealth);
                    }
                }

                else if (totalHealth <= 0)
                {
                    System.Console.WriteLine("Oh no, you died");
                    System.Console.WriteLine("1. Play again");
                    System.Console.WriteLine("2. Main Menu");
                    if(userInput == 1)
                    {
                        Blasters(ref totalCredits, ref totalHealth);
                    }
                    else if(userInput == 2)
                    {
                        MenuMethod(ref totalCredits, ref totalHealth);
                    }
                
                }
            if(userInput != 1 && userInput != 2)
            {
                System.Console.WriteLine("Invalid Input Try Again");
                Blasters(ref totalCredits, ref totalHealth);
            }
            }
        }










    }
