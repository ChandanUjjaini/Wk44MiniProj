// See Weekly Mini Project Phase 1

using Wk44MiniProj;
using Wk44MiniProjP1;

int Tprice = 0;
Datainput data = new Datainput();

List<Product> ProdList = new List<Product> (); //Creating list for product details
data.Input(ProdList); //Calling method to enter product data

List<Product> sortedProd = ProdList.OrderBy(ProdList => ProdList.PPrice).ToList();

//Creating product menu header
Console.WriteLine("-----------------------------------------------");

Console.WriteLine("Product Type".PadRight(20) + "Product Name".PadRight(20) + "Price");
Console.WriteLine("-----------------------------------------------");

//Reading and printing product details in console

Console.WriteLine("-----------------------------------------------");

foreach (Product product in sortedProd)
{
    Console.WriteLine(product.Cat.PadRight(20) + product.PName.PadRight(20) + product.PPrice);
    int buffer = int.Parse(product.PPrice);

    Tprice += buffer;
}

Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Total Amount:".PadLeft(40) + Tprice);
Console.WriteLine("-----------------------------------------------");
Console.ReadLine();


