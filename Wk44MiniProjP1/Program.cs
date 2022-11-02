// See Weekly Mini Project Phase 1

using Wk44MiniProj;
using Wk44MiniProjP1;

int Tprice = 0;
string exit;
Datainput data = new Datainput();

List<Product> ProdList = new List<Product> (); //Creating list for product details



do
{
    Console.WriteLine("------------------------------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Enter P to update product details | Enter S for search product | Enter Q to quit: ");
    exit = Console.ReadLine().ToLower();
    Console.ResetColor();
    Console.WriteLine("------------------------------------------------------------------------------------");

    if (exit == "q")
    {
        break;
    }
    else if (exit == "p")
    {
        data.Input(ProdList); //Calling method to enter product data
    }
    else if (exit == "s")
    {
        data.Search(ProdList); //Calling method to search product 
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please enter valid selection");
        Console.ResetColor();

    }  
  


} while (exit != "q");


Console.ReadLine();


