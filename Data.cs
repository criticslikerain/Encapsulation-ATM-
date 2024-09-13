namespace ATM_NI_INOCANDO
{
    class Data
    {
        private string cardNum;
        private string firstName;
        private string lastName;
        private string pin;
        private string newpin = "";
        private double balance = 0;
        private double withdraw = 0.00;
    
        // PANG ADMIN REF. (koa-koa rani) //
        private string admin;
        private string name;
        private double money = 10000000.00;
        /// 
        /// ////////////////////////////
        /// 
        
        public string CardNum
        {
            get { return cardNum = "12345"; }
            set { cardNum = value; }
        }

        public string FirstName
        {
            get { return firstName = "Nathaniel"; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName = "Inocando"; }
            set { lastName = value; }
        }

        public string Pin
        {
            get { return pin = "520"; }
            set { pin = value; }
        }

        public double Balance{

            get {return balance;}
            set {balance = value;}
        }

        public double  Withdraw{
            
            get{return withdraw;}
            set{withdraw = value;}

        }

          public string NewPin

   
        {
            get { return newpin; }
            set { newpin = value; }
        }


/// //////////////////////////////// //// //// //// //// 
///   ADMIN THINGS bara bara bara - bere bere bere    //// 
/// //// //// //// //// //// //// //// //// //// //// 
        public string Admin{

            get{return admin = "abbysus abbysum invocat";}
            set{admin = value;}
        }

        public string Name{

            get{return name  ="Charon 1";}
            set{name = value;}
        }

        public double Money{

            get{return money;}
            set{money = value;}
        }






      
    }
}   
