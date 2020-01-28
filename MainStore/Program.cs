using System;

namespace MainStore
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreManager storeManager = new StoreManager();
            storeManager.addStorage(new PersistentStore());
            while (true)
            {
                Console.WriteLine("(1) Add product");
                Console.WriteLine("(2) List products");
                Console.WriteLine("(0) Exit");

                String userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Write("Enter the type of the product (CD/Book): ");
                        string type=Console.ReadLine();
                        Console.Write("Enter the name of the product: ");
                        string name=Console.ReadLine();
                        Console.Write("Enter the price of the product: ");

                        int price=0;
                        int.TryParse(Console.ReadLine(), out price);

                        int size=0;

                        if (type.ToUpper().Equals("CD"))
                        {
                            Console.WriteLine("Enter the number of tracks: ");
                            int.TryParse(Console.ReadLine(), out size);
                        }
                        else if (type.ToUpper().Equals("BOOK"))
                        {
                            Console.Write("Enter the number of pages: ");
                            int.TryParse(Console.ReadLine(), out size);
                        }
                        else
                        {
                            Console.WriteLine("invalid input.");
                        }

                        if (type.ToUpper().Equals("CD"))
                        {
                            storeManager.addCDProduct(name, price, size);
                        }
                        else if (type.ToUpper().Equals("BOOK"))
                        {
                            storeManager.addBookProduct(name, price, size);
                        }
                        else
                        {
                            throw new Exception();
                        }
                        
                        break;
                    case "2":
                        Console.WriteLine(storeManager.listProducts());
                        break;
                    case "0":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not a valid choice.");
                        break;
                }


            }

        }
        
    }
}
