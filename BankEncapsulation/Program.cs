namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();        
           
            Console.WriteLine("Enter 1 to deposit or 2 to check balance");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                Console.WriteLine($"How much would you like to deposit?");
                int depositAmount = Console.Read();
                bankAccount.Deposit(depositAmount);
            }
            if (userChoice == 2)             
            {
                bankAccount.GetBalance();
               
            }

           
        }
    }
}
