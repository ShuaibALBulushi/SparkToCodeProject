using System.Runtime.InteropServices;

namespace Task7_Problem_Solving
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }

        public void Withdraw(double amount) 
        { 
            if(Balance >= amount)
            {
                Balance -= amount;
                SendEmail();
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }

        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine("Holder Name: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }

        private void SendEmail()
        {
            Console.WriteLine("Email sent to " + HolderName + " regarding account activity.");
        }
    }


    class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string email;
        int age;

        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("Email sent to " + email + " regarding registration.");
        }
    }

    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public void Sell(int quantity)
        {
            if(StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
                LogTransaction();
            }
            else
            {
                Console.WriteLine("Insufficient stock for sale.");
                LogTransaction();
            }
        }

        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            Console.WriteLine(quantity + " units of " + ProductName + " restocked.");
            LogTransaction();
        }

        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }

        private void PrintDetails()
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Stock Quantity: " + StockQuantity);
        }

        private void LogTransaction()
        {
            Console.WriteLine("Transaction logged for " + ProductName + ".");
        }
    }


    public class Program
    {
        //Bank Account objects
        static BankAccount B1 = new BankAccount() {AccountNumber = 1163, HolderName = "Karim", Balance = 120 };
        static BankAccount B2 = new BankAccount() { AccountNumber = 15203, HolderName = "Ali", Balance = 63 };

        //Student objects
        static Student S1 = new Student() { Name = "Ali", Address = "Muscat", Grade = 65 };
        static Student S2 = new Student() { Name = "Ahmed", Address = "Muscat", Grade = 70 };

        //Product objects
        static Product P1 = new Product() { ProductName = "Wireless Mouse", Price = 5.5, StockQuantity = 50 };
        static Product P2 = new Product() { ProductName = "Mechanical Keyboard", Price = 15.75, StockQuantity = 20 };

        static void Main(string[] args)
        {
            bool exitApp = false;

                while (exitApp == false)
                {
                    Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                    Console.WriteLine(" 1. View Account Details");
                    Console.WriteLine(" 2. Update Student Address");
                    Console.WriteLine(" 3. Make a Deposit");
                    Console.WriteLine(" 4. Make a Withdrawal");
                    Console.WriteLine(" 5. View Product Details");
                    Console.WriteLine(" 6. Register a Student");
                    Console.WriteLine(" 7. Compare Two Account Balances");
                    Console.WriteLine(" 8. Restock Product & Stock Level Check");
                    Console.WriteLine(" 9. Transfer Between Accounts");
                    Console.WriteLine("10. Update Student Grade (Validated)");
                    Console.WriteLine("11. Student Report Card");
                    Console.WriteLine("12. Account Health Status");
                    Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                    Console.WriteLine("14. Scholarship Eligibility Check");
                    Console.WriteLine("15. Full Balance Top-Up Flow");
                    Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                    Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                    Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                    Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                    Console.WriteLine("20. Exit");
                    Console.Write("Choose an option: ");

                    int choice;
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1: ViewAccountDetails(); break;
                        case 2: UpdateStudentAddress(); break;
                        case 3: MakeDeposit(); break;
                        case 4: MakeWithdrawal(); break;
                        case 5: ViewProductDetails(); break;
                        case 6: RegisterStudent(); break;
                        case 7: CompareAccountBalances(); break;
                        case 8: RestockProduct(); break;
                        case 9: TransferBetweenAccounts(); break;
                        case 10: UpdateStudentGrade(); break;
                        case 11: StudentReportCard(); break;
                        case 12: AccountHealthStatus(); break;
                        case 13: BulkSaleWithRevenue(); break;
                        case 14: ScholarshipEligibilityCheck(); break;
                        case 15: FullBalanceTopUpFlow(); break;
                        case 16: QuickAccountOpening(); break;
                        case 17: TotalStudentsCounter(); break;
                        case 18: OverdrawnAccountCheck(); break;
                        case 19: SetStudentSecurityPin(); break;
                        case 20:
                            exitApp = true;
                            Console.WriteLine("Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Invalid option, please choose between 1 and 20.");
                            break;
                    }
                }
        }


        // method to chose between the objects of BankAccount
        static BankAccount ChooseAccount()
        {
            Console.WriteLine("Choose the Account (1 or 2): ");
            string choice = Console.ReadLine();
            if(choice == "2")
            {
                return B2;
            }
            return B1;
        }

        // method to chose between the objects of Student
        static Student ChooseStudent()
        {
            Console.WriteLine("Choose the Student (1 or 2): ");
            string choice = Console.ReadLine();
            if (choice == "2")
            {
                return S2;
            }
            return S1;
        }

        // method to chose between the objects of Product
        static Product ChooseProduct()
        {
            Console.WriteLine("Choose the Product (1 or 2): ");
            string choice = Console.ReadLine();
            if (choice == "2")
            {
                return P2;
            }
            return P1;
        }


        // Case 1
        static void ViewAccountDetails()
        {
            BankAccount account = ChooseAccount();
            account.CheckBalance();
        }

        // Case 2
        static void UpdateStudentAddress()
        {
            Student student = ChooseStudent();
            Console.WriteLine("Enter new Address: ");
            student.Address = Console.ReadLine();
            Console.WriteLine("Address is successfully updated to " + student.Address);
        }

        // Case 3
        static void MakeDeposit()
        {
            BankAccount account = ChooseAccount();
            Console.WriteLine("Enter the amount that you want to deposit: ");
            double amount = double.Parse(Console.ReadLine());
            account.Deposit(amount);
            Console.WriteLine("Card holder's name: " + account.HolderName);
            Console.WriteLine("Updated Balance after the deposit: " + account.Balance);
        }

        // Case 4
        static void MakeWithdrawal()
        {
            BankAccount account = ChooseAccount();
            Console.WriteLine("Enter the amount that you want to deposit: ");
            double amount = double.Parse(Console.ReadLine());
            account.Withdraw(amount);
            Console.WriteLine("Updated Balance after the Withdrawal: " + account.Balance);
        }

        // Case 5
        static void ViewProductDetails()
        {
            Product product = ChooseProduct();
            Console.WriteLine("Total Inventory Value: " + product.GetInventoryValue());
        }

        // Case 6
        static void RegisterStudent()
        {
            Student student = ChooseStudent();
            Console.WriteLine("Enter your Email: ");
            string email = Console.ReadLine();
            student.Register(email);
            Console.WriteLine("you have registered successfully. your email will not be revealed anywhere");
        }

        // Case 7
        static void CompareAccountBalances()
        {
            double B1_balance = B1.Balance;
            double B2_balance = B2.Balance;
            if(B1_balance > B2_balance)
            {
                Console.WriteLine("Bank account 1 holds more money than Bank account 2");
            }
            else if (B2_balance > B1_balance)
            {
                Console.WriteLine("Bank account 2 holds more money than Bank account 1");
            }
            else
            {
                Console.WriteLine("Bank account 1 and 2 hold equal amount of money");
            }
        }

        // Case 8
        static void RestockProduct()
        {
            Product product = ChooseProduct();
            Console.WriteLine("Enter the quantity of product you want to restock: ");
            int quantity = int.Parse(Console.ReadLine());
            product.Restock(quantity);

            int stockQuantity = product.StockQuantity;
            if(stockQuantity < 10 && stockQuantity >= 0)
            {
                Console.WriteLine("Stock level is low");
            }
            else if(stockQuantity >= 10 && stockQuantity <= 49)
            {
                Console.WriteLine("Stock level is moderate");
            }
            else
            {
                Console.WriteLine("Stock level is well stocked");
            }
        }

        // Case 9
        static void TransferBetweenAccounts()
        {   
            Console.WriteLine("### you will choose your source and destination account ###");

            Console.WriteLine("Source =>");
            BankAccount source = ChooseAccount();

            Console.WriteLine("destination =>");
            BankAccount destination = ChooseAccount();

            Console.WriteLine("Enter the amount you want to transfer: ");
            double amount = double.Parse(Console.ReadLine());

            if (source.Balance >= amount)
            {
                source.Withdraw(amount);
                destination.Deposit(amount);
            }
            else
            {
                Console.WriteLine("insufficient balance");
            }
        }

        // Case 10
        static void UpdateStudentGrade()
        {
            try
            {
                Student student = ChooseStudent();

                Console.WriteLine("Enter the new Grade: ");
                int grade = int.Parse(Console.ReadLine());

                if(grade >= 0 && grade <= 100)
                {
                    student.Grade = grade;
                }
                else
                {
                    Console.WriteLine("the number you entered is out of the range of (0-100)");
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("input must be a whole number");
            }
           
        }
    }
}
