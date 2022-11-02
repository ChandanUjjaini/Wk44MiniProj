using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wk44MiniProjP1;

namespace Wk44MiniProj
{
    internal class Datainput
    {
        public void Input(List<Product> prodList)
        {
            String Category; // Declaring variables for passing arguments
            String ProdName;
            String ProdPrice;
            string exit;
            //Do while loop to update product details to list
            do
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter P to update product details | Enter Q to quit: ");
                exit = Console.ReadLine().ToLower();
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------------");


                if (exit == "q")
                {
                    break;
                }
                else if (exit == "p")
                {
                    Console.Write("Please Enter Product Category:");
                    Category = Console.ReadLine(); //Product details input
                    Console.Write("Please Enter Product Name:");//Product details input
                    ProdName = Console.ReadLine();
                repeat:
                    Console.Write("Please Enter Product Price:");//Product details input
                    ProdPrice = Console.ReadLine();
                    bool chk = int.TryParse(ProdPrice, out int num);
                    if (!chk)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter numerical value");
                        Console.ResetColor();
                        goto repeat;
                    }

                    Console.WriteLine("-------------------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Product Added sucessfully");//Product details update message
                    Console.ResetColor();
                    prodList.Add(new Product(Category, ProdName, ProdPrice));//Adding product details to list using class

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter valid selection");
                    Console.ResetColor();
                    continue;
                }







            } while ((exit != "q") || (exit != "Q")); // Verifying condition to quit

            Console.Clear();
        }
    }
}
