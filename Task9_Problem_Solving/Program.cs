using Task9_Problem_Solving.Models;
using Microsoft.EntityFrameworkCore;
namespace Task9_Problem_Solving
{
    internal class Program
    {
        // Shared DbContext - created ONCE, here, so every function below reuses
        // the exact same instance instead of each function opening its own.
        static ProjectContext context = new ProjectContext();

        // Shared login state - 0 means "nobody is logged in".
        // Set by Login(), read by any function that requires a logged-in user,
        // reset back to 0 by Logout().
        static int loggedInUserId = 0;

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\n===== E-Commerce Console App =====");
                Console.WriteLine(" 1. Register New User");
                Console.WriteLine(" 2. Login");
                Console.WriteLine(" 3. Add New Category");
                Console.WriteLine(" 4. Add New Product");
                Console.WriteLine(" 5. View All Products");
                Console.WriteLine(" 6. Place An Order");
                Console.WriteLine(" 7. View My Orders");
                Console.WriteLine(" 8. View Order Details");
                Console.WriteLine(" 9. Add A Review for an Order");
                Console.WriteLine("10. View All Reviews for a Product");
                Console.WriteLine("11. Logout");
                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1: RegisterUser(); break;
                    case 2: Login(); break;
                    case 3: AddCategory(); break;
                    case 4: AddProduct(); break;
                    case 5: ViewAllProducts(); break;
                    case 6: PlaceOrder(); break;
                    case 7: ViewMyOrders(); break;
                    case 8: ViewOrderDetails(); break;
                    case 9: AddReview(); break;
                    case 10: ViewReviewsForProduct(); break;
                    case 11: Logout(); break;
                    case 0:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        // ========================= FUNCTIONS =========================
        // Every function below talks to the console itself AND uses the
        // shared "context" field declared above - never create a new
        // AppDbContext() inside any of these functions.

        static void RegisterUser()
        {
            User user = new User();
            Console.Write("Enter User name: ");
            user.UserName = Console.ReadLine();

            Console.Write("Enter Password: ");
            user.UserPassword = Console.ReadLine();

            Console.Write("Enter Email: ");
            user.UserEmail = Console.ReadLine();

            context.users.Add(user);
            context.SaveChanges();
            Console.WriteLine("user registered successfully");
        }

        static void Login()
        {         
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            User user = context.users.FirstOrDefault(e =>  e.UserEmail == email && e.UserPassword == pass );

            if (user != null)
            {
                loggedInUserId = user.UserId;
            }
            else
            {
                Console.WriteLine("Error: user not found");
            }

        }

        static void AddCategory()
        {
            Category category = new Category();

            Console.Write("Enter Category name: ");
            category.CategoryName = Console.ReadLine();

            context.Categories.Add(category);
            context.SaveChanges();
            Console.WriteLine("Category added successfully");
        }

        static void AddProduct()
        {
            Product product = new Product();

            Console.WriteLine("Enter product name: ");
            product.ProductName = Console.ReadLine();

            Console.WriteLine("Enter product price: ");
            product.ProductPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Category Id: ");
            product.CategoryId = int.Parse(Console.ReadLine());

            context.products.Add(product);
            context.SaveChanges();
            Console.WriteLine("Product added successfully");
        }

        static void ViewAllProducts()
        {
            Console.WriteLine("do you want to filter by category(y,n):");
            string chooser = Console.ReadLine();

            if (chooser.ToLower() == "y")
            {
                Console.WriteLine("Enter the category name:");
                string catName = Console.ReadLine();

                Category category = context.Categories.FirstOrDefault(c => c.CategoryName == catName);

                if (category == null)
                {
                    Console.WriteLine("Error: category not found");
                    return;
                }

                var product = context.products.Where(p => p.CategoryId == category.CategoryId);

                if (product.Any())
                {
                    foreach (var item in product)
                    {
                        Console.WriteLine("=============================");
                        Console.WriteLine($"Product ID: {item.ProductId}");
                        Console.WriteLine($"Product Name: {item.ProductName}");
                        Console.WriteLine($"Product Price: {item.ProductPrice}");
                        Console.WriteLine($"Category Name: {catName}");
                    }
                }
                else
                {
                    Console.WriteLine("Error: no product found");
                }
            }
            else if (chooser.ToLower() == "n")
            {
                var allProducts = context.products.Include(p => p.category);

                foreach (Product p in allProducts)
                {
                    Console.WriteLine("=============================");
                    Console.WriteLine($"Product ID: {p.ProductId}");
                    Console.WriteLine($"Product Name: {p.ProductName}");
                    Console.WriteLine($"Product Price: {p.ProductPrice}");
                    Console.WriteLine($"Category Name: {(p.category != null ? p.category.CategoryName : "None")}");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid choice");
            }
        }

        static void PlaceOrder()
        {
            if (loggedInUserId != 0)
            {
                try
                {
                    Console.WriteLine("How many products you want to order: ");
                    int proNum = int.Parse(Console.ReadLine());

                    Order order = new Order
                    {
                        UserId = loggedInUserId,
                        OrderDate = DateTime.Now,
                        ProductOrdered = new List<ProductOrdered>()
                    };

                    for (int i = 0; i < proNum; i++)
                    {
                        Console.WriteLine("Enter product name: ");
                        string proName = Console.ReadLine();

                        Product product = context.products.FirstOrDefault(p => p.ProductName == proName);

                        if (product != null)
                        {
                            Console.WriteLine("Enter the quantity: ");
                            int quantity = int.Parse(Console.ReadLine());

                            ProductOrdered item = new ProductOrdered
                            {
                                ProductId = product.ProductId,
                                Quantity = quantity
                            };

                            order.ProductOrdered.Add(item);
                        }
                        else
                        {
                            Console.WriteLine("Error: Product not found");
                            return;
                        }
                    }

                    context.orders.Add(order);
                    context.SaveChanges();
                    Console.WriteLine("Order placed successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: system only accepts integer numbers");
                }
            }
            else
            {
                Console.WriteLine("Error: User is not logged in");
            }
        }

        static void ViewMyOrders()
        {
            // TODO: implement - check loggedInUserId != 0 first
        }

        static void ViewOrderDetails()
        {
            // TODO: implement
        }

        static void AddReview()
        {
            // TODO: implement - check loggedInUserId != 0 first
        }

        static void ViewReviewsForProduct()
        {
            // TODO: implement
        }

        static void Logout()
        {
            // TODO: implement - reset loggedInUserId back to 0
        }
    }
}
