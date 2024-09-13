using System;
using System.Speech.Synthesis;

namespace ATM_NI_INOCANDO
{
    
    class ATM
    {
               private static Data regUser = new Data();
       
    

        public void Display()
        {
            int input;
            
          SpeechSynthesizer run = new SpeechSynthesizer();
          run.SelectVoiceByHints(VoiceGender.Female);
          run.Rate = 1;
           
            do
            {
                
                Console.Clear();
               
                Console.WriteLine(" ---------------------------------");
                Console.WriteLine("| NathanTechno's |  ATM Main Menu |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("| 1. Insert ATM card              |");
                Console.WriteLine("| 2. Exit                         |");
                Console.WriteLine(" ---------------------------------");
                Console.Write("ENTER YOUR CHOICE OF OPTION: ");
                
                 run.Speak("Welcome!, To NathansTechno's Atm!. Enter your choice of option");
                string choice = Console.ReadLine();



 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
 
                         if(choice == regUser.Admin ){
                        SpeechSynthesizer charonI = new SpeechSynthesizer();
                        charonI.Rate = 10;
                        
//WALA RANI BRADD KUAN MADJIK! (padayon sa ubos)

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("DEVELOPER MODE ACTIVATED! ");
                    charonI.Speak("Developer Mode Activated!");

                    Dev();
                    
                }
                
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



                while (!int.TryParse(choice, out input) || input < 1 || input > 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write("INVALID INPUT, ONLY ENTER NUMBERS IN THE TABLE CORRESPONDS (1-2):");
                    run.Speak("INVALID INPUT, ONLY ENTER NUMBERS IN THE TABLE CORRESPONDS ONE TO TWO");
                    choice = Console.ReadLine();
                    Console.ResetColor();
                }

                switch (input)
                {
                    case 1:
                        Console.Beep();
                        Register.Authenticate();
                        break;
                        /*
                    case 2:
                        Console.Beep();
                        Register.RegisterDinhi();
                        break;
                        */
                    case 2:
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Thank you, comeback again!");
                        run.Speak("Thank you, comback again!");
                        Thread.Sleep (2000);
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                  
                }
                

              

            } while (true);
        }

        public void Displaytwo()
        {
         
            

            int input;
          

                 SpeechSynthesizer run = new SpeechSynthesizer();
                run.SelectVoiceByHints(VoiceGender.Female);

            do
            {
             
                
                Console.WriteLine(" ---------------------------------");
                Console.WriteLine("| NathanTechno's  | ATM Main Menu |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("| 1. Check your Balance           |");
                Console.WriteLine("| 2. Deposit Cash                 |");
                Console.WriteLine("| 3. Withdraw                     |");
                Console.WriteLine("| 4. Change Pin                   |");
                Console.WriteLine("| 5. Return Menu                  |");
                Console.WriteLine("| 6. Exit                         |");
                Console.WriteLine(" ---------------------------------");
                Console.Write("Choose an option: ");
                run.Speak("Choose an option for your transaction");
                

                string userInput = Console.ReadLine();

                while (!int.TryParse(userInput, out input) || input > 5 || input < 1)
                {
                    Console.Write("Please enter a valid number from (1-5): ");
                    run.Speak("Please enter a valid number from one to five!");
                    userInput = Console.ReadLine();
                }

                switch (input)
                {
                    case 1: Console.Beep(); Register. Userbalance(); break;
                    case 2:Console.Beep();  Register.Deposit(); break;
                    case 3: Console.Beep(); Register.Withdrawal(); break;
                    case 4: Console.Beep(); Register.ChangePin(); break;
                    case 5: Console.Beep(); ATM rundidto = new ATM(); rundidto.Display(); break;
                    case 6:
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Thank you, comeback again!");
                        run.Speak("Thank you, comeback again!");
                        Console.Clear();
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                }

            } while (true);
        }

          public void Display3()
        {
            int input;
            
          SpeechSynthesizer run = new SpeechSynthesizer();
          run.SelectVoiceByHints(VoiceGender.Female);

           
            do
            {
                Console.Clear();
                Console.WriteLine(" ---------------------------------");
                Console.WriteLine("| NathanTechno's |  ATM Main Menu |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("| 1. Insert ATM card              |");
                Console.WriteLine("| 2. Exit                         |");
                Console.WriteLine(" ---------------------------------");
                Console.Write("ENTER YOUR CHOICE OF OPTION: ");

                string choice = Console.ReadLine();
                while (!int.TryParse(choice, out input) || input < 1 || input > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write("INVALID INPUT, ONLY ENTER NUMBERS IN THE TABLE CORRESPONDS (1-2):");
                    run.Speak("INVALID INPUT, ONLY ENTER NUMBERS IN THE TABLE CORRESPONDS ONE TO TWO");
                    choice = Console.ReadLine();
                    Console.ResetColor();
                }

                switch (input)
                {
                    case 1:
                        Register.Authenticate();
                        break;
                        /*
                    case 2:
                        Register.RegisterDinhi();
                        break;
                        */
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Thank you, comeback again!");
                        run.Speak("Thank you, come back again!");
                        Thread.Sleep (2000);
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                   
                }

            } while (true);
        }


        public void Dev()
        {
         
            

            int input;
                     
    
                 SpeechSynthesizer run = new SpeechSynthesizer();
                run.SelectVoiceByHints(VoiceGender.Female);
                run.Rate = 10;

            do
            {
                  Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine(" ---------------------------------");
                Console.WriteLine("| NathanTechno's  | ATM Main Menu |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("| 1. Check your Balance           |");
                Console.WriteLine("| 2. Deposit Cash                 |");
                Console.WriteLine("| 3. Withdraw                     |");
                Console.WriteLine("| 4. Return Menu                  |");
                Console.WriteLine("| 5. Exit                         |");
                Console.WriteLine(" ---------------------------------");
                Console.Write("Choose an option: ");
                run.Speak("Choose an option for your transaction");
                

                string userInput = Console.ReadLine();

                while (!int.TryParse(userInput, out input) || input > 5 || input < 1)
                {
                    Console.Write("Please enter a valid number from (1-5): ");
                    run.Speak(" Please enter a valid number from one to five!");
                    userInput = Console.ReadLine();
                }

                switch (input)
                {
                    case 1: AdminOwner.Userbalance(); break;
                    case 2: AdminOwner.Deposit(); break;
                    case 3: AdminOwner.Withdrawal(); break;
                    case 4: ATM rundidto = new ATM(); rundidto.Display(); break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Thank you, comeback again! Master.");
                        run.Speak("Thank you, comeback again! Master.");
                        Console.Clear();
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                }

            } while (true);
        }

    }
}
