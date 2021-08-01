using System;
using MyTask2;

using Week10Task2;


namespace Week10Task2
{
    public class HospitaQueueUserInterface
    {
        // public static HospitalQueueLogic<string> users = new HospitalQueueLogic<string>();

        /// <summary>
        /// Method responsible for displaying the user interface
        /// </summary>
        public static void Display()
        {
            bool runApp = true;
            while (runApp)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("welcome to my user mangement app");

                Console.WriteLine("Enter: ");
                Console.WriteLine("1 to Add User");
                Console.WriteLine("2 to Save changes");
                Console.WriteLine("3 to Remove User");
                Console.WriteLine("4 to Display all Users accordingly");
                Console.WriteLine("5 to clear the screen");
                Console.WriteLine("0 to exit");

                var consoleInput = Users.IsValidInput(Console.ReadLine());
                if (consoleInput == -1)
                {
                    Console.WriteLine("Please enter a valid input");
                    Console.Clear();
                }
                else
                {
                    switch (consoleInput)

                    {
                        case 1:
                            //All errors are caught in the UI for accurate stack trace.
                            try
                            {
                                Console.WriteLine("Enter Firstname");
                                string firstname = Console.ReadLine();
                                Console.WriteLine("Enter Lastname");
                                string lastname = Console.ReadLine();
                                Console.WriteLine("Enter Your mail");
                                string email = Console.ReadLine();
                                Console.WriteLine("Enter BestFood");
                                string Bestfood = Console.ReadLine();

                                HospitalQueueLogic<string>.Enqueue(firstname, lastname, email, Bestfood);
                                Console.WriteLine($"User {firstname} saved sucessfully");
                                Console.ReadKey();
                                Console.Clear();
                            }

                            catch (Exception e)  //Catches all unforseen errors
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;
                        case 2:
                            //All errors are caught in the UI for accurate stack trace.
                            try
                            {
                                Console.WriteLine("Please enter the first name");
                                //first = Console.ReadLine();
                                Console.WriteLine("Please enter the last name");
                                //lastInput = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Blue;
                                // Console.WriteLine(Users.UserInput(firstInput, lastInput));
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (ArithmeticException ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadKey();
                                Console.Clear();
                            }
                            break;

                        case 3:
                            // Users.Dequeue();
                            break;
                        case 4:

                            break;
                        case 5:
                            Console.Clear();
                            break;
                        case 0:
                            runApp = false;
                            break;
                        default:
                            Console.Clear();
                            break;


                    }
                }

            }
        }



    }
}