using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wk44MiniProjP1;

namespace Wk44MiniProj
{
    internal class Datainput
    {
        int Tprice = 0;

        public static void Input(List<Product> prodList)
        {
            String Category; // Declaring variables for passing arguments
            String ProdName;
            String Price;
            int ProdPrice;
            int Tprice = 0;
            
            
                   {
                    Console.Write("Please Enter Product Category:");
                    Category = Console.ReadLine(); //Product details input
                    Console.Write("Please Enter Product Name:");//Product details input
                    ProdName = Console.ReadLine();
                    repeat:
                    Console.Write("Please Enter Product Price:");//Product details input
                    Price = Console.ReadLine();
                   
                    bool chk = int.TryParse(Price, out int num);
                     
                    if (!chk)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter numerical value");
                        Console.ResetColor();
                        goto repeat;
                    }
                    ProdPrice = Convert.ToInt32(Price);
                    Console.WriteLine("-------------------------------------------------------------------------------");
                    //Adding product details to list using class
                    prodList.Add(new Product(Category, ProdName, ProdPrice));

                    Console.Clear();
                    List<Product> sortedProd = prodList.OrderBy(ProdList => ProdList.PPrice).ToList();

                    //Creating product menu header
                    Console.WriteLine("-----------------------------------------------");

                    Console.WriteLine("Product Type".PadRight(20) + "Product Name".PadRight(20) + "Price");
                    Console.WriteLine("-----------------------------------------------");

                    //Reading and printing product details in console

                    Console.WriteLine("-----------------------------------------------");



                    foreach (Product product in sortedProd)
                    {
                        Console.WriteLine(product.Cat.PadRight(20) + product.PName.PadRight(20) + product.PPrice);
                        //int buffer = int.Parse(product.PPrice);

                        Tprice += product.PPrice;
                    }

                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("Total Amount:".PadLeft(40) + Tprice);
                    Console.WriteLine("-----------------------------------------------");
                    }         
                     
            
        }

        public void Search(List<Product> prodList)
        {
            Console.Write("Please enter Product name:");
            string comp = Console.ReadLine().ToLower();
            List<Product> sortedProd = prodList.OrderBy(ProdList => ProdList.PPrice).ToList(); //Print header
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Product Type".PadRight(20) + "Product Name".PadRight(20) + "Price");
            Console.WriteLine("-----------------------------------------------");

            foreach (Product product in sortedProd) // Loop to search product details
            {
                if (comp == product.PName.ToLower()) // Comparing the entered product in loop
                {
                    Console.ForegroundColor = ConsoleColor.Green;//Highlighting color to searched string
                    Console.WriteLine(product.Cat.PadRight(20) + product.PName.PadRight(20) + product.PPrice);
                    Console.ResetColor();
                    Tprice += product.PPrice; // Summation of prices of products
                }
                else
                {//Printing product details
                    Console.WriteLine(product.Cat.PadRight(20) + product.PName.PadRight(20) + product.PPrice);
                    Tprice += product.PPrice;// Summation of prices of products
                }
                
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Total Amount:".PadLeft(40) + Tprice);
            Console.WriteLine("-----------------------------------------------");

        }
    }
}
