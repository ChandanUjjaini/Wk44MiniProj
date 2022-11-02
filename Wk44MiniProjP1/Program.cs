// See Weekly Mini Project Phase 1

using Wk44MiniProj;
using Wk44MiniProjP1;

string Select;
Datainput data = new Datainput();

List<Product> ProdList = new List<Product> (); //Creating list for product details



do
{
    Console.WriteLine("------------------------------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Enter P to update product details | Enter S for search product | Enter Q to quit: ");
    Select = Console.ReadLine().ToLower();
    Console.ResetColor();
    Console.WriteLine("------------------------------------------------------------------------------------");

    if (Select == "q")
    {
        break;
    }
    else if (Select == "p")
    {
        Datainput.Input(ProdList); //Calling method to enter product data
    }
    else if (Select == "s")
    {
        data.Search(ProdList); //Calling method to search product 
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Please enter valid selection");
        Console.ResetColor();

    }  
  


} while (Select != "q");


Console.ReadLine();


