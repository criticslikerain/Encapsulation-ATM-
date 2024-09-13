using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Speech.Synthesis;
using System.Threading.Tasks.Dataflow;

namespace ATM_NI_INOCANDO
{
    class Register  
    {
         private static Data regUser = new Data();
        
      /*  
        public static void RegisterDinhi()
        {
           SpeechSynthesizer run1 = new SpeechSynthesizer();
            run1.Rate = 1;  
            
            do
            {
                Console.Clear();
                Console.WriteLine("WELCOME TO REGISTRATION OF ACCOUNT!");  


    //////////////////////////////// REGISTRATION SA NAME ////////////////////////////////////////////////////


                Console.Write("\nEnter your name: ");
                run1.Speak("Welcome to registration of account, Kindly Enter your preferred name ");
                string name = Console.ReadLine();
                while(string.IsNullOrEmpty(name) )
                {   
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Name cannot be empty.");
                    run1.Speak("Error Name cannot be empty.");
                    Console.ResetColor();
                    Console.Write("\nEnter your name: ");
                    name = Console.ReadLine();
                }


              
                while (!Char.IsLetter(surname[0]))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Warning! The first character should not be a number");
                  
                    surname = Console.ReadLine();
                }

              

                while(name.Length < 3){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nText inputted too short,  please enter atleast three | (3) characters!");
                    run1.Speak("Text inputted too short, please enter atleast three characters ");
                    Console.ResetColor();
                    Console.Write("\n\nEnter your name: ");
                    name = Console.ReadLine();
                }
                regUser.FirstName = name;


    ////////////////////////////// REGISTRATION SA SURNAME  ////////////////////////////////////////////

                Console.Write("\nEnter your surname: ");
                run1.Speak("Kindly Enter your preferred surname ");
                string surname = Console.ReadLine();
                 while(string.IsNullOrEmpty(surname) )
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Surname cannot be empty.");
                    run1.Speak("Error Surname cannot be empty.");
                    Console.ResetColor();
                    Console.Write("\nEnter surname: ");
                    surname = Console.ReadLine();
                }

                
                while (!Char.IsLetter(surname[0]))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Warning! The first character should not be a number");
                  
                    surname = Console.ReadLine();
                }

               

                while(surname.Length < 3){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nText inputted too short,  please enter atleast three | (3) characters!");
                    run1.Speak("Text inputted too short, please enter atleast three characters ");
                    Console.ResetColor();
                    Console.Write("\n\nEnter your Surname: ");
                    surname = Console.ReadLine();
                }
                regUser.LastName = surname;


/////////////////////////////// REGISTRATION SA CARD NUMBER //////////////////////////////////////////////////////
                string cardNumberInput = "12345";
                int cardNum;
                Console.Write("\nRegister your preferred Card number: ");
                run1.Speak("Kindly Enter your preferred card number ");
                 cardNumberInput =  Console.ReadLine();
                
                while(string.IsNullOrEmpty(cardNumberInput)){

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Card number cannot be empty.");
                    run1.Speak("Error Error Card number cannot be empty.");
                    Console.ResetColor();
                    Console.Write("\nRegister your preferred Card number: ");
                    cardNumberInput = Console.ReadLine();

                }



                while(cardNumberInput.Length < 5){

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Invalid, Card number mininum keys should be atleast five (5) numbers!");
                    run1.Speak("Invalid, Card number minimum keys should be five numbers!");
                    Console.ResetColor();
                    Console.Write("\nRegister your preferred Card number: ");
                    cardNumberInput = Console.ReadLine();

                }

                while (!int.TryParse(cardNumberInput, out cardNum)  || cardNum < 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Invalid input of card number, Use number only: ");
                     run1.Speak("Invalid input of card number, Use number only! ");
                    cardNumberInput = Console.ReadLine();
                    Console.ResetColor();
                }
                regUser.CardNum = cardNum;


//////////////////////////////// REGISTRATION SA PIN CODE ///////////////////////////////////////////////////////////
///
                string cardPinInput = "5207";
                int cardPin;
                Console.Write("\nRegister your preferred Pin code: ");
                run1.Speak("Kindly Enter your preferred pin code");

                 cardPinInput =  MaskInput();
                
                while(cardPinInput.Length < 3){

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid, Pin number  minimum keys should be atleast three(3) numbers!");
                    run1.Speak("Invalid, Pin number minimum keys should be three numbers!");
                    Console.ResetColor();
                    Console.WriteLine("\nRegister your preferred Pin code: ");
                    cardPinInput = Console.ReadLine();

                }


                while(string.IsNullOrEmpty(cardPinInput)){

                         Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Pin number cannot be empty.");
                    run1.Speak("Error! Error Pin number cannot be empty.");
                    Console.ResetColor();
                    Console.Write("\nRegister your preferred Pin number: ");
                    cardPinInput = Console.ReadLine();
                        
                }
                while (!int.TryParse(cardPinInput, out cardPin) || cardPin < 0)
                {   
                    
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                     Console.Write("Invalid input of pin code, Use number only: ");
                       run1.Speak("Invalid input of pin code, Use number only");
                    cardPinInput = Console.ReadLine();
                    Console.ResetColor();
                   
                }
                regUser.Pin = cardPin;
               
                Console.WriteLine("\n\nRegistration Complete!");
                Console.WriteLine("Returning to Menu...");
                 run1.Speak("Registration Complete!, returning to menu");
                ATM run = new ATM();
                run.Display3();


          


            } while (false);
        }
            
*/

 
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
               
               
                         //TIG AUTHENTICATE NANI DINHI DAPITAAA//

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// <summary>
/// 
/// </summary>
          public static void Authenticate(){

                SpeechSynthesizer run = new SpeechSynthesizer();
                run.SelectVoiceByHints(VoiceGender.Female);
                run.Rate = 1;
                int input;
                int input2;
                double input3;
                double limit = 199.99;

                do{

                        Console.Clear();
                        Console.Write("\nEnter your Card number: ");
             run.Speak("Enter your credentials to authenticate your account");
            string userCardNumber = Console.ReadLine();
           

            while(!int.TryParse(userCardNumber, out input) || input < 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please enter a valid number!: ");
                   run.Speak("Please enter a valid number!");
                userCardNumber = Console.ReadLine();
                Console.ResetColor();
             
            
            }

            if(regUser.NewPin.Length <= 2 ){


                // means wala pay gi set nga pin then mo prompt didto sa PIN
                

                        Console.Write("\nEnter your Pin Code: ");
             string userPinNumber = MaskInput();

            while(!int.TryParse(userPinNumber, out input2) || input2 < 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nPlease enter a valid number!: ");
                   run.Speak("Please enter a valid number!");
                userPinNumber = Console.ReadLine();
                Console.ResetColor();

            }

                 if(userPinNumber != regUser.NewPin && userCardNumber != regUser.CardNum && userPinNumber != regUser.Pin || userPinNumber != regUser.Pin || userCardNumber != regUser.CardNum){

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nINVALID PIN CODE OR CARD NUMBER!");
                Console.ResetColor();
                Console.WriteLine("\nGOING TO MENU...");
                run.Speak("Invalid pin code or card number, Please try again!");
                
                Thread.Sleep(1000);
                Console.Clear();

                ATM goingagain = new ATM();
                goingagain.Display();
                
            }
                                                                                                                                                                                                                                                                       
            if(userPinNumber == regUser.NewPin || userCardNumber == regUser.CardNum  && userPinNumber == regUser.Pin  )
             {
                Console.Clear();
               Console.WriteLine("\n\nAuthentication Successful!");
               Console.WriteLine("WELCOME, {0} {1}!",regUser.FirstName, regUser.LastName);
                   run.Speak($"Welcome, {regUser.FirstName} {regUser.LastName}");

                if(regUser.Balance > limit){

                            ATM atmgo = new ATM();
                            atmgo.Displaytwo();
                }

                 balik:
                   Console.Write($"\nMinimum account balance should be 200$ You have {regUser.Balance}$ in your account");
                   Console.Write("\nPay Registration or type 'menu' to go menu: ");
                   run.Speak($"Minimum account balance should be 200$ you have {regUser.Balance}$ in your account");
                   string Pay = Console.ReadLine();


                    if(Pay == "menu" || Pay == "Menu"){

                        ATM goingtomenu = new ATM();
                        goingtomenu.Display();
                    }

                    while(!double.TryParse(Pay, out input3)){
                        

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Invalid input, Please try again: ");
                        run.Speak("Invalid input!, Please try again!");

                        Pay = Console.ReadLine();
                        

                        if(Pay == "menu" ||Pay == "Menu"){
                            Console.ResetColor();
                            goto balik;
                        }

                    }


                    if(input3 <= limit){
                        
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write("Insufficient amount of money to register, Please try again!\n");
                        Console.WriteLine("Minimum amount register deposit money (200$)");
                        run.Speak("Insufficient amount of money to register, Please try again!.. Minimum amount register deposit money 200$");
                        Console.ResetColor();
                            goto balik;
                    }

                    if(input3 > limit){

                        regUser.Balance += input3;
                        Console.ResetColor();
                        Console.WriteLine("Registration fee is now accepted!");
                        run.Speak("Registration fee accepted! , going to Atm interface");

                        Thread.Sleep(500);
                        Console.Clear();
                        ATM atmnow = new ATM();
                        atmnow.Displaytwo();

                    }




            }

             

            }

         
              if(regUser.NewPin.Length >= 3)
              {

                       

                        Console.Write("\nEnter your Pin Code: ");
             string userPinNumber = MaskInput();

            while(!int.TryParse(userPinNumber, out input2) || input2 < 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nPlease enter a valid number!: ");
                   run.Speak("Please enter a valid number!");
                userPinNumber = Console.ReadLine();
                Console.ResetColor();
            }
            
            if(userCardNumber != regUser.CardNum && userPinNumber != regUser.NewPin || userPinNumber != regUser.NewPin || userCardNumber != regUser.CardNum)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nINVALID PIN CODE OR CARD NUMBER!");
                Console.ResetColor();
                Console.WriteLine("\nGOING TO MENU...");
                run.Speak("Invalid pin code or card number, Please try again!");
                
                Thread.Sleep(1000);
                Console.Clear();

                ATM goingagain = new ATM();
                goingagain.Display();

            }

             if(userPinNumber == regUser.NewPin && userCardNumber == regUser.CardNum )
             {
                Console.Clear();
               Console.WriteLine("\n\nAuthentication Successful!");
               Console.WriteLine("WELCOME, {0} {1}!",regUser.FirstName, regUser.LastName);
                   run.Speak($"Welcome, {regUser.FirstName} {regUser.LastName}");

             }

                if(regUser.Balance > limit){

                            ATM atmgo = new ATM();
                            atmgo.Displaytwo();
                }

                balik:
                   Console.Write($"\nMinimum account balance should be 200$ You have {regUser.Balance}$ in your account");
                   Console.Write("\nPay Balance or type 'menu' to go menu: ");
                   run.Speak($"Minimum account balance should be 200$ you have {regUser.Balance}$ in your account");
                   string Pay = Console.ReadLine();


                    if(Pay == "menu" || Pay == "Menu"){

                        ATM goingtomenu = new ATM();
                        goingtomenu.Display();
                    }

                    while(!double.TryParse(Pay, out input3)){
                        

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Invalid input, Please try again: ");
                        run.Speak("Invalid input!, Please try again!");

                        Pay = Console.ReadLine();
                        

                        if(Pay == "menu" ||Pay == "Menu"){
                            Console.ResetColor();
                            goto balik;
                        }

                    }


                    if(input3 <= limit){
                        
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write("Insufficient amount of money to register, Please try again!\n");
                        Console.WriteLine("Minimum amount register deposit money (200$)");
                        run.Speak("Insufficient amount of money to register, Please try again!.. Minimum amount register deposit money 200$");
                        Console.ResetColor();
                            goto balik;
                    }

                    if(input3 > limit){

                        regUser.Balance += input3;
                        Console.ResetColor();
                        Console.WriteLine("Registration fee is now accepted!");
                        run.Speak("Registration fee accepted! , going to Atm interface");

                        Thread.Sleep(500);
                        Console.Clear();
                        ATM atmnow = new ATM();
                        atmnow.Displaytwo();

                    }



              }

                }while(false);



                /*
                 double input3;
                 double limit = 199.99;
                 int input;
                 int input2;
                    

                do{
                
                
                    
            Console.Clear();
           
            Console.Write("\nEnter your Card number: ");
             run.Speak("Enter your credentials to authenticate your account");
            string userCardNumber = Console.ReadLine();
           

            while(!int.TryParse(userCardNumber, out input) || input < 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please enter a valid number!: ");
                   run.Speak("Please enter a valid number!");
                userCardNumber = Console.ReadLine();
                Console.ResetColor();
             
            
            }

              Console.Write("\nEnter your Pin Code: ");
            string userPinNumber = MaskInput();

            while(!int.TryParse(userPinNumber, out input2) || input2 < 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nPlease enter a valid number!: ");
                   run.Speak("Please enter a valid number!");
                userPinNumber = Console.ReadLine();
                Console.ResetColor();
            
            }

            if(userPinNumber != regUser.NewPin && userCardNumber != regUser.CardNum && userPinNumber != regUser.Pin || userPinNumber != regUser.Pin || userCardNumber != regUser.CardNum){

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nINVALID PIN CODE OR CARD NUMBER!");
                Console.ResetColor();
                Console.WriteLine("\nGOING TO MENU...");
                run.Speak("Invalid pin code or card number, Please try again!");
                
                Thread.Sleep(1000);
                Console.Clear();

                ATM goingagain = new ATM();
                goingagain.Display();
                
            }
                                                                                                                                                                                                                                                                       
            if(userPinNumber == regUser.NewPin || userCardNumber == regUser.CardNum  && userPinNumber == regUser.Pin  )
             {
                Console.Clear();
               Console.WriteLine("\n\nAuthentication Successful!");
               Console.WriteLine("WELCOME, {0} {1}!",regUser.FirstName, regUser.LastName);
                   run.Speak($"Welcome, {regUser.FirstName} {regUser.LastName}");

                if(regUser.Balance > limit){

                            ATM atmgo = new ATM();
                            atmgo.Displaytwo();
                }

                 balik:
                   Console.Write($"\nMinimum account balance should be 200$ You have {regUser.Balance}$ in your account");
                   Console.Write("\nPay Balance or type 'menu' to go menu: ");
                   run.Speak($"Minimum account balance should be 200$ you have {regUser.Balance}$ in your account");
                   string Pay = Console.ReadLine();


                    if(Pay == "menu" || Pay == "Menu"){

                        ATM goingtomenu = new ATM();
                        goingtomenu.Display();
                    }

                    while(!double.TryParse(Pay, out input3)){
                        

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Invalid input, Please try again: ");
                        run.Speak("Invalid input!, Please try again!");

                        Pay = Console.ReadLine();
                        

                        if(Pay == "menu" ||Pay == "Menu"){
                            Console.ResetColor();
                            goto balik;
                        }

                    }


                    if(input3 <= limit){
                        
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write("Insufficient amount of money to register, Please try again!\n");
                        Console.WriteLine("Minimum amount register deposit money (200$)");
                        run.Speak("Insufficient amount of money to register, Please try again!.. Minimum amount register deposit money 200$");
                        Console.ResetColor();
                            goto balik;
                    }

                    if(input3 > limit){

                        regUser.Balance += input3;
                        Console.ResetColor();
                        Console.WriteLine("Registration fee is now accepted!");
                        run.Speak("Registration fee accepted! , going to Atm interface");

                        Thread.Sleep(500);
                        Console.Clear();
                        ATM atmnow = new ATM();
                        atmnow.Displaytwo();

                    }




            }

             


                }while(false);     

                */   
          }
          


          public static double Userbalance(){

                
                SpeechSynthesizer run = new SpeechSynthesizer();
                run.SelectVoiceByHints(VoiceGender.Female);
                run.Rate = 1;

                regUser.Balance = Math.Round(regUser.Balance,2);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your Balance is: {0}$",regUser.Balance );
                run.Speak($"Your Balance is {regUser.Balance}$");
                Console.ResetColor();
                return regUser.Balance;
                

          }


          public static double Withdrawal() {
                
                int limit = 200;

                SpeechSynthesizer run = new SpeechSynthesizer();
                run.SelectVoiceByHints(VoiceGender.Female); 
                run.Rate = 1;
                
            
                if(regUser.Balance == 0){
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can't withdraw an amount right now since your balance is unsuffice!");
                    run.Speak("You can't withdraw an amount right now since your balance is unsuffice.. Returning you to Atm Menu interface.");
                    Console.ResetColor();
                    Console.WriteLine("\n\nReturning...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ATM run1 = new ATM();
                    run1.Displaytwo();
                    
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

                if(input <= regUser.Balance){

                    regUser.Balance -= input;
                    regUser.Balance = Math.Round(regUser.Balance,2);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("The remaining amount of balance you now have is: {0}$", regUser.Balance);
                    run.Speak($"The remaining amount of balance you now have is {regUser.Balance}$");
                    Console.Write("Do you want a receipt Y / N ?:  ");
                    string receipt = Console.ReadLine();

                        if(receipt == "Y" || receipt  == "y")
    {   
        Console.ForegroundColor = ConsoleColor.Gray;
         Console.WriteLine("==================================");
        Console.WriteLine("\n--- RECEIPT ---");
        Console.WriteLine("Date: {0}", DateTime.Now.ToString("MM/dd/yyyy"));
        Console.WriteLine("Name: {0} {1}", regUser.FirstName, regUser.LastName);
        Console.WriteLine("Withdrawn Amount: {0}$", input);
        Console.WriteLine("Remaining Balance: {0}$", regUser.Balance);
        Console.WriteLine("Thank you for using our services!");
        Console.WriteLine("==================================");
         Console.WriteLine("");
        Thread.Sleep(3000);
        ATM receipt1 = new ATM();
        receipt1.Displaytwo();
    }

                    

                    
                    Console.ResetColor();

                }
              

                if(input > regUser.Balance){
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Insufficient amount of balance, you have {0}$", regUser.Balance);
                    Console.ResetColor();
                    run.Speak($"Insufficient Amount of balance, you have {regUser.Balance}$");
                    
                }

                   if(regUser.Balance < limit){

                    Console.WriteLine("Since your balance has depleted below 200$, you will need to deposit  money into your account.");
                    run.Speak("Since your balance has depleted below 200$, you will need to deposit  money into your account.. Goint to Menu interface.");


                    ATM depleted = new ATM();
                    depleted.Display();
                }


                return input;

            }while(false);
          }


          public static double Deposit(){

                SpeechSynthesizer run = new SpeechSynthesizer();
                run.SelectVoiceByHints(VoiceGender.Female);
                run.Rate = 1;
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

                regUser.Balance += input;
                regUser.Balance = Math.Round(regUser.Balance,2);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The amount of balance you now have is: {0}$", regUser.Balance);
                run.Speak($"The amount of balance you now have is {regUser.Balance}$");
                Console.ResetColor();
                return input;


                }while(false);
          }

           static string MaskInput()
{
    string input = "";
    ConsoleKeyInfo keyInfo;

    do
    {
        keyInfo = Console.ReadKey(true);

        if (keyInfo.Key == ConsoleKey.Backspace && input.Length > 0)
        {
         
            input = input.Substring(0, input.Length - 1);
            Console.Write("\b \b");
        }
        else if (!char.IsControl(keyInfo.KeyChar))
        {
            Console.Write(keyInfo.KeyChar);
                Thread.Sleep(50); 
                Console.Write("\b*"); 
                input += keyInfo.KeyChar;
        }
       
    } while (keyInfo.Key != ConsoleKey.Enter);

    return input;
}


    public static int ChangePin(){


            SpeechSynthesizer run = new SpeechSynthesizer();
            run.SelectVoiceByHints(VoiceGender.Female);

        int input;

        do{


            if(regUser.NewPin.Length >= 3)
            {

                    ChangePin1:
            Console.Clear();
        Console.Write("Enter your current pin to change it: ");
        string currentpin1 = MaskInput();

         while(string.IsNullOrEmpty(currentpin1) )
                {   
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError! Pin cannot be empty.");
                    run.Speak("Error Name cannot be empty.");
                    Console.ResetColor();
                    Console.Write("\nEnter your Current Pin: ");
                    currentpin1 = MaskInput();
                }


                while(currentpin1.Length < 3){

                         Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nText inputted too short,  please enter atleast three | (3) characters!");
                    run.Speak("Text inputted too short, please enter atleast three characters ");
                    Console.ResetColor();
                    Console.Write("\n\nEnter your Current Pin: ");
                    currentpin1 = MaskInput();
                }
                    
                

        while(!int.TryParse(currentpin1, out input) || input < 0 ){

            Console.Write("\nInvalid input, Please try again: ");
            currentpin1 = MaskInput();

        }

       if(currentpin1 != regUser.NewPin){
        
        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write("\nPin code is incorrect!, Please try again! ");
        run.Speak("Pin code is incorrect!, Please try again!");
        Console.ResetColor();
        Console.Clear();
        
        goto ChangePin1;
       }


        // if correct ang pin 
        if(currentpin1 == regUser.NewPin){

                NewPin();

        }
            }











            ////////////////////////////////////////////////////
            ChangePin:
            Console.Clear();
        Console.Write("Enter your current pin to change it: ");
        string currentpin = MaskInput();

         while(string.IsNullOrEmpty(currentpin) )
                {   
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError! Pin cannot be empty.");
                    run.Speak("Error Name cannot be empty.");
                    Console.ResetColor();
                    Console.Write("\nEnter your Current Pin: ");
                    currentpin = MaskInput();
                }


                while(currentpin.Length < 3){

                         Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nText inputted too short,  please enter atleast three | (3) characters!");
                    run.Speak("Text inputted too short, please enter atleast three characters ");
                    Console.ResetColor();
                    Console.Write("\n\nEnter your Current Pin: ");
                    currentpin = MaskInput();
                }
                    
                

        while(!int.TryParse(currentpin, out input) || input < 0 ){

            Console.Write("\nInvalid input, Please try again: ");
            currentpin = MaskInput();

        }

       if(currentpin != regUser.Pin){
        
        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write("\nPin code is incorrect!, Please try again: ");
        run.Speak("Pin code is incorrect!, Please try again!");
        Console.ResetColor();
        Console.Clear();
        
        goto ChangePin;
       }


        // if correct ang pin 
        if(currentpin == regUser.Pin){

                NewPin();

        }




        }while(false);

        return input;

    }


    public static int NewPin(){

        SpeechSynthesizer run = new SpeechSynthesizer();

        run.SelectVoiceByHints(VoiceGender.Female);


        do{
              int input; 

                

                if(regUser.NewPin.Length >= 3){

                          Console.Write("\nType the new PIN you want to set: ");
                string  newpin1 = MaskInput();

                while(string.IsNullOrEmpty(newpin1))
                {
                      Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Pin cannot be empty.");
                    run.Speak("Error Pin code cannot be empty.");
                    Console.ResetColor();
                    Console.Write("\nEnter your New Pin code: ");
                    newpin1 = MaskInput();
                    
                }


                while(newpin1.Length < 3)
                {

                      Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nText inputted too short,  please enter atleast three | (3) characters!");
                    run.Speak("Text inputted too short, please enter atleast three characters ");
                    Console.ResetColor();
                    Console.Write("\n\nEnter your New Pin: ");
                    newpin1 = MaskInput();


                }

                while (!int.TryParse(newpin1, out input) || input < 0)
                {
                    
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                     Console.Write("Invalid input of pin code, Use number only: ");
                       run.Speak("Invalid input of pin code, Use number only");
                    newpin1 = MaskInput();
                    Console.ResetColor();
                   
                }


                regUser.NewPin = newpin1;

                Console.WriteLine("\nPin code changed!");
                run.Speak("Pin code changed!, Returning to Menu..");

                ATM passwordchangedreturn1 = new ATM();
                passwordchangedreturn1.Display();

                    
                }


//////////////////////////////////////////////////////////////////////////////////

                Console.Write("\nType the new PIN you want to set: ");
                string  newpin = MaskInput();

                while(string.IsNullOrEmpty(newpin))
                {
                      Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Pin cannot be empty.");
                    run.Speak("Error Pin code cannot be empty.");
                    Console.ResetColor();
                    Console.Write("\nEnter your New Pin code: ");
                    newpin = MaskInput();
                    
                }


                while(newpin.Length < 3)
                {

                      Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nText inputted too short,  please enter atleast three | (3) characters!");
                    run.Speak("Text inputted too short, please enter atleast three characters ");
                    Console.ResetColor();
                    Console.Write("\n\nEnter your New Pin: ");
                    newpin = MaskInput();


                }

                while (!int.TryParse(newpin, out input) || input < 0)
                {
                    
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                     Console.Write("Invalid input of pin code, Use number only: ");
                       run.Speak("Invalid input of pin code, Use number only");
                    newpin = MaskInput();
                    Console.ResetColor();
                   
                }


                regUser.NewPin = newpin;

                Console.WriteLine("\nPin code changed!");
                run.Speak("Pin code changed!, Returning to Menu..");

                ATM passwordchangedreturn = new ATM();
                passwordchangedreturn.Display();

                
                return input;

        }while(false);
    }

    
///////////////// tig tago sa password yeyeyeyeye /////////////////////////
        static string MaskText(string input)
    {
        string maskedText = "";
        
        foreach (char c in input)
        {   
            maskedText += "*";
        }
        
        return maskedText;
    }



        
    }

}
    
