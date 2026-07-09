using System.ComponentModel.DataAnnotations;

namespace Task6_Problem_Solving
{
    internal class Program
    {
        // Shared data storage - declared at class level (static) so that
        // EVERY function below can read and modify the same three lists
        // without needing them passed in as parameters.
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();
   

        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. Find the Richest Custome");
                Console.WriteLine("7. <your 2nd custom service - choose a name>");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }
                switch (choice)
                {
                    case 1:               
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        // TODO: call your first custom service function here
                        RichestCustomer();
                        break;
                    case 7:
                        // TODO: call your second custom service function here
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }
        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for
        // whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results
        // for these services - it only shows the menu and calls them.
        static void AddAccount()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Enter your Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter your Account Number: ");
            string accountNumber = Console.ReadLine();

            if (accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine("Account number already exists. Please try again.");
            }
            else
            {
                Console.Write("Enter your Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine());

                if (initialBalance < 0)
                {
                    Console.WriteLine("Initial balance cannot be negative. Please try again.");
                }
                else
                {
                    customerNames.Add(customerName);
                    accountNumbers.Add(accountNumber);
                    balances.Add(initialBalance);
                    Console.WriteLine("Your account is successfully added");
                    Console.WriteLine("### Account Details ###");
                    Console.WriteLine("Name: " + customerName);
                    Console.WriteLine("Account Number: " + accountNumber);
                    Console.WriteLine("Balance: " + initialBalance);
                }
            }

        }
        static void DepositMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Enter your Account Number: ");
            string accountNumber = Console.ReadLine();
            int accountIndex = accountNumbers.IndexOf(accountNumber);
            if(accountIndex >= 0)
            {
                Console.Write("Enter the amount to deposit: ");
                double deposit = double.Parse(Console.ReadLine());
                if (deposit < 0)
                {
                    Console.WriteLine("Deposit amount cannot be negative. Please try again.");
                }
                else
                {
                    balances[accountIndex] += deposit;
                    Console.WriteLine("Deposit successful. New balance: " + balances[accountIndex]);
                    Console.WriteLine("### Account Details ###");
                    Console.WriteLine("Name: " + customerNames[accountIndex]);
                    Console.WriteLine("Account Number: " + accountNumbers[accountIndex]);
                    Console.WriteLine("Balance: " + balances[accountIndex]);
                }
            }
            else
            {
                Console.WriteLine("Account number does not exist. Please try again.");
            }

        }
        static void WithdrawMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Enter your Account Number: ");
            string accountNumber = Console.ReadLine();
            int accountIndex = accountNumbers.IndexOf(accountNumber);
            if (accountIndex >= 0)
            {
                Console.Write("Enter the amount to withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());

                if(withdraw > 0)
                {
                    if(withdraw <= balances[accountIndex])
                    {
                        balances[accountIndex] -= withdraw;
                        Console.WriteLine("Withdrawal successful. \nNew balance: " + balances[accountIndex]);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Withdraw amount cannot be negative. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Account number does not exist. Please try again.");
            }

        }
        static void ShowBalance()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Enter your Account Number: ");
            string accountNumber = Console.ReadLine();
            int accountIndex = accountNumbers.IndexOf(accountNumber);
            if (accountIndex >= 0)
            {
                Console.WriteLine("### Account Details ###");
                Console.WriteLine("Name: " + customerNames[accountIndex]);
                Console.WriteLine("Account Number: " + accountNumbers[accountIndex]);
                Console.WriteLine("Balance: " + balances[accountIndex]);
            }
            else
            {
                Console.WriteLine("Account number does not exist. Please try again.");
            }
        }
        static void TransferAmount()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Enter your Account Number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter the recipient's Account Number: ");
            string recipientAccountNumber = Console.ReadLine();

            int senderIndex = accountNumbers.IndexOf(accountNumber);
            int recipientIndex = accountNumbers.IndexOf(recipientAccountNumber);

            if( senderIndex >= 0)
            {
                if (recipientIndex >= 0) 
                { 
                    Console.Write("Enter the amount to transfer: ");
                    double transferAmount = double.Parse(Console.ReadLine());
                    if(transferAmount > 0) 
                    {
                        if (transferAmount <= balances[senderIndex])
                        {
                            balances[senderIndex] -= transferAmount;
                            balances[recipientIndex] += transferAmount;
                            Console.WriteLine("Transfer successful. \nYour new balance: " + balances[senderIndex]);
                            Console.WriteLine("Recipient's new balance: " + balances[recipientIndex]);
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance. Please try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Transfer amount cannot be negative. Please try again.");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Recipient account number does not exist. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Account number does not exist. Please try again.");
            }
        }
        // TODO: write two more void, no-parameter functions here for
        // your own custom services (option 6 and option 7)
        static void RichestCustomer()
        {
            if(balances.Count == 0)
            {
                Console.WriteLine("No Account exists. Please add an account first.");
            }
            else
            {
                double maxBalance = balances.Max();
                int richestIndex = balances.IndexOf(maxBalance);
                Console.WriteLine("### Richest Customer Details ###");
                Console.WriteLine("Name: " + customerNames[richestIndex]);
                Console.WriteLine("Account Number: " + accountNumbers[richestIndex]);
                Console.WriteLine("Balance: " + balances[richestIndex]);
            }
        }
    }
}
