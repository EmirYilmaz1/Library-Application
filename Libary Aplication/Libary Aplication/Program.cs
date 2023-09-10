using System.Diagnostics;

namespace Libary_Aplication
{
    public struct Book
    {
        private string title;
        private int pageNumber;
        private string author;
        public Book(string title, int pageNumber, string author)
        {
            this.title = title;
            this.pageNumber = pageNumber;
            this.author = author;
        }

        public void WriteBookInfo() 
        {
            Console.WriteLine("Title: " +title+ " Page Number: " +pageNumber.ToString()+ " Author: " +author);
        }
    }

    public struct Customer 
    {
        private string name;
        private string gender;
        private int age;

        public Customer(string name, string gender, int age) 
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        public void WriteCustomerInfo() 
        {
            Console.WriteLine("Customer name: " + name + " Customer gender: " + gender + " Customer age: " + age);
        }
    }

    public class Library
    {
        static void Main()
        {
            Console.WriteLine("Select what do you want to do");
            Console.WriteLine("If you want to add a book press 1");
            Console.WriteLine("If you want to sign a customer press 2");
            int selectedIndex = Convert.ToInt32(Console.ReadLine());
            
            if (selectedIndex == 1 ) 
            AddBook();
            if (selectedIndex == 2 )  
            SignCustomer();
        }

        static void AddBook()
        {

            Console.Write("How many book you are adding: ");
            int bookNumber = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Book[] bookInfos = new Book[bookNumber];

             for (int i = 0; i < bookNumber; i++) 
             {
                Console.Write($"Enter {i+1}. book name: ");
                string title = Console.ReadLine();
                Console.Write($"Enter {i+1}. book page number: ");
                int pageNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter {i + 1}. author name: ");
                string author = Console.ReadLine();

                bookInfos[i] = new Book(title, pageNumber, author);
                Console.Clear();
            }

            
             foreach ( Book bookInfo in bookInfos ) 
             {
                bookInfo.WriteBookInfo();
             }

            Console.WriteLine("Going to menu after 2 seconds");
            Thread.Sleep(2000);
            Console.Clear();
            Main();
        }

        static void SignCustomer() 
        {
            Console.Write("How many customer do you signing: ");
            int customerNumber = Convert.ToInt32(Console.ReadLine());
            Customer[] customers = new Customer[customerNumber];
            Console.Clear();
            for (int i = 0;i < customerNumber; i++) 
            {
                Console.Write($"Enter {i+1}. customer name: ");
                string name = Console.ReadLine();
                Console.Write($"Enter {i+1}. customer gender: ");
                string gender = Console.ReadLine();
                Console.Write($"Enter {i + 1}. customer age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                customers[i] = new Customer(name, gender, age);
                Console.Clear();
            }

            foreach( Customer customer in customers) 
            {
                customer.WriteCustomerInfo();
            }

            Console.WriteLine("Going to menu after 2 seconds");
            Thread.Sleep(2000);
            Console.Clear();
            Main();


        }
    }
}