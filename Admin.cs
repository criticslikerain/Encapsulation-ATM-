using System;
using System.Speech.Synthesis;

namespace ATM_NI_INOCANDO{



  class AdminOwner{


     private static Data regUser = new Data();

      public static double Userbalance(){
     
      Console.ForegroundColor = ConsoleColor.Magenta;
                
                SpeechSynthesizer run = new SpeechSynthesizer();
                run.SelectVoiceByHints(VoiceGender.Female);
                run.Rate = 10;

                regUser.Balance = Math.Round(regUser.Money,2);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your Balance is: {0}$",regUser.Money );
                run.Speak($"Your Balance is {regUser.Money}$");
                Console.ResetColor();
                return regUser.Money;
                

          }


          public static double Withdrawal() {
                       
      Console.ForegroundColor = ConsoleColor.Magenta;

                SpeechSynthesizer run = new SpeechSynthesizer();
                run.SelectVoiceByHints(VoiceGender.Female); 
                run.Rate = 10;
                

                if(regUser.Money == 0){
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can't withdraw an amount right now since your balance is unsuffice!");
                    run.Speak("You can't withdraw an amount right now since your balance is unsuffice.. Returning you to Atm Menu interface.");
                    Console.ResetColor();
                    Console.WriteLine("\n\nReturning...");
                    Thread.Sleep(2000);
                    ATM run1 = new ATM();
                    run1.Dev();
                }
            
            do{
                
                Console.Write("Enter amount you want to withdraw: ");   
                string amount = Console.ReadLine();
                double input;


                while(!double.TryParse(amount, out input) || input < 0 ){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Invalid, Input a correct value: ");
                run.Speak("Invalid, input a correct value");
                amount = Console.ReadLine();
                Console.ResetColor();

                }

                if(input <= regUser.Money){

                    regUser.Balance -= input;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("The remaining amount of balance you now have is: {0}", regUser.Balance);
                    run.Speak($"The remaining amount of balance you now have is {regUser.Money}$");
                    Console.ResetColor();

                }
               

                if(input > regUser.Money){
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Insufficient amount of balance, you only have {0}$", regUser.Money);
                    Console.ResetColor();
                    run.Speak($"Insufficient Amount of balance, you only have {regUser.Money}$");
                    
                }

                return input;

            }while(false);
          }


          public static double Deposit(){
     
      Console.ForegroundColor = ConsoleColor.Magenta;
                SpeechSynthesizer run = new SpeechSynthesizer();
                run.SelectVoiceByHints(VoiceGender.Female);
                run.Rate = 10;
                do{
                Console.Write("\nEnter amount you want to deposit: ");
                string amount = Console.ReadLine();
                double input;

                while(!double.TryParse(amount, out input) || input < 1){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Invalid, Input a correct value: ");
                run.Speak("Invalid, input a correct value");
                amount = Console.ReadLine();
                Console.ResetColor();
                }

                regUser.Money += input;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The amount of balance you now have is: {0}$", regUser.Money);
                run.Speak($"The amount of balance you now have is {regUser.Money}$");
                Console.ResetColor();
                return input;


                }while(false);
          } 
     }
}

    
  
