// See Weekly Mini Project Phase 1

using Wk44MiniProjP1;

String Category; // Declaring variables for passing arguments
String ProdName;
String ProdPrice;
int Tprice = 0;

//Console.WriteLine("-------------------------------------------------------------------------------");
//Console.WriteLine("To enter new product details please continue the process | Enter q or Q to quit");
//Console.WriteLine("-------------------------------------------------------------------------------");
List<Product> ProdList = new List<Product> (); //Creating list for product details
Console.WriteLine("Product Type".PadRight(10) + "Product Name".PadRight(10) + "Price");
//Do while loop to update product details to list
do
{
    Console.WriteLine("-------------------------------------------------------------------------------");
    Console.WriteLine("To enter new product details please continue the process | Enter q or Q to quit");
    Console.WriteLine("-------------------------------------------------------------------------------");
    Console.Write("Please Enter Product Category:");
        Category = Console.ReadLine(); //Product details input
    string exit = Category.ToLower();
    
    if (exit == "q") //Verifying the input data to quit the data input loop
    {
        break;
    }
    else
    {

        Console.Write("Please Enter Product Name:");//Product details input
        ProdName = Console.ReadLine();
        Console.Write("Please Enter Product Price:");//Product details input
        ProdPrice = Console.ReadLine();
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Product Added sucessfully");//Product details update message
        Console.ResetColor();

        ProdList.Add(new Product(Category, ProdName, ProdPrice));//Adding product details to list using class

    }
        
    

    
} while ((Category != "q") ||(Category != "Q")); // Verifying condition to quit

Console.Clear();

List<Product> sortedProd = ProdList.OrderBy(ProdList => ProdList.PPrice).ToList();

//Creating product menu header
Console.WriteLine("------------------------------------------------------------------");

Console.WriteLine("Product Type".PadRight(10) + "Product Name".PadRight(10) + "Price");
Console.WriteLine("------------------------------------------------------------------");

//Reading and printing product details in console

Console.WriteLine("--------------------------");

foreach (Product product in sortedProd)
{
    Console.WriteLine(product.Cat.PadRight(10) + product.PName.PadRight(10) + product.PPrice);
    int buffer = int.Parse(product.PPrice);

    Tprice = Tprice + buffer;
}

Console.WriteLine("--------------------------");
Console.WriteLine("Total Amount:".PadLeft(20) + Tprice);
Console.WriteLine("--------------------------");
Console.ReadLine();


