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
                return;
            }
        }


        static void ViewMyOrders()
        {
            if (loggedInUserId != 0)
            {
                var userOrders = context.orders
                    .Include(o => o.ProductOrdered)
                    .ThenInclude(po => po.product)
                    .Where(o => o.UserId == loggedInUserId)
                    .ToList();

                if (userOrders.Count == 0)
                {
                    Console.WriteLine("You have not placed any orders yet.");
                    return;
                }

                foreach (var order in userOrders)
                {
                    Console.WriteLine("=============================");
                    Console.WriteLine($"Order ID: {order.OrderId}");
                    Console.WriteLine($"Order Date: {order.OrderDate}");
                    Console.WriteLine("Products:");

                    foreach (var item in order.ProductOrdered)
                    {
                        Console.WriteLine($"  - {item.product.ProductName} (Quantity: {item.Quantity})");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error: User is not logged in");
                return;
            }
        }

        static void ViewOrderDetails()
        {
            Console.WriteLine("Enter order Id: ");
            int orderid = int.Parse(Console.ReadLine());

            Order order = context.orders
                .Include(op => op.ProductOrdered)
                .ThenInclude(p => p.product)
                .Include(o => o.Review)
                .FirstOrDefault(o => o.OrderId == orderid);

            if (order != null)
            {
                double orderTotal = 0;

                Console.WriteLine("=============================");
                Console.WriteLine($"Order ID: {order.OrderId}");
                Console.WriteLine($"Order Date: {order.OrderDate}");
                Console.WriteLine("Products:");

                foreach (var item in order.ProductOrdered)
                {
                    double itemTotal = item.product.ProductPrice * item.Quantity;
                    orderTotal += itemTotal;
                    Console.WriteLine($"  - {item.product.ProductName} (Quantity: {item.Quantity}) - Price: {item.product.ProductPrice} each");
                }

                Console.WriteLine($"Order Total: {orderTotal}");

                if (order.Review != null)
                {
                    Console.WriteLine($"Review: {order.Review.Comment}");
                }
                else
                {
                    Console.WriteLine("Review: No review exists for this order.");
                }
            }
            else
            {
                Console.WriteLine("Error: no order found");
            }
        }

        static void AddReview()
        {
            if (loggedInUserId != 0)
            {
                Console.WriteLine("Enter Order id: ");
                int id = int.Parse(Console.ReadLine());

                Order order = context.orders.FirstOrDefault(o => o.OrderId == id);

                if (order == null)
                {
                    Console.WriteLine("Error: Order not found");
                    return;
                }

                if (order.UserId != loggedInUserId)
                {
                    Console.WriteLine("Error: This order does not belong to you");
                    return;
                }

                Review review = context.reviews.FirstOrDefault(r => r.OrderId == id);

                if (review == null)
                {
                    Review rev = new Review();

                    Console.WriteLine("Enter your Rating(1 to 5):");
                    rev.Rating = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter your comment:");
                    rev.Comment = Console.ReadLine();

                    rev.OrderId = id;
                    context.reviews.Add(rev);
                    context.SaveChanges();
                    Console.WriteLine("Review added successfully");
                }
                else
                {
                    Console.WriteLine("Error: order already have a review");
                }
            }
            else
            {
                Console.WriteLine("Error: User is not logged in");
                return;
            }
        }

        static void ViewReviewsForProduct()
        {
            Console.WriteLine("Enter product name: ");
            string proName = Console.ReadLine();

            Product product = context.products.FirstOrDefault(p => p.ProductName == proName);

            if (product != null)
            {
                var productOrders = context.orderedProducts
                    .Include(po => po.order)
                    .ThenInclude(o => o.Review)
                    .Where(po => po.ProductId == product.ProductId)
                    .ToList();

                if (productOrders.Count != 0)
                {
                    foreach (var item in productOrders)
                    {
                        Console.WriteLine("=============================");
                        Console.WriteLine($"Order ID: {item.OrderId}");

                        if (item.order.Review != null)
                        {
                            Console.WriteLine($"Rating: {item.order.Review.Rating}");
                            Console.WriteLine($"Comment: {item.order.Review.Comment}");
                        }
                        else
                        {
                            Console.WriteLine("No review for this order");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No orders found for this product");
                }
            }
            else
            {
                Console.WriteLine("Error: Product not found");
            }
        }

        static void Logout()
        {
            if(loggedInUserId != 0)
            {
                loggedInUserId = 0;
                Console.WriteLine("Successfully logged out");
            }
            else
            {
                Console.WriteLine("Already logged out");
            }
        }
    }
}
