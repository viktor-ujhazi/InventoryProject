using System;

namespace MainStore
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreManager storeManager = new StoreManager();
            PersistentStore persistentStore = new PersistentStore();
            storeManager.addStorage(persistentStore);
            while (true)
            {
                Console.WriteLine("(1) Add product");
                Console.WriteLine("(2) List products");
                Console.WriteLine("(0) Exit");

                String userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        string type="";
                        string name="";
                        int price=0;
                        int size=0;

                        persistentStore.storeBookProduct(name,price,size);
                        storeManager.
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
