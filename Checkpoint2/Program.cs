using Checkpoint2;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

Console.WriteLine("Hello and welcome!");
Console.WriteLine("Please input your products. Press 'q' to show list.");


ProductList productList = new ProductList();
bool addMoreProducts = true;
while (addMoreProducts)
{
    bool anotherProduct = true;
    while (anotherProduct)
    {
        Console.Write("Category: ");
        string category = Console.ReadLine();
        if (category.ToLower().Trim() == "q")
        {
            break;
        }
        Console.Write("Item: ");
        string item = Console.ReadLine();
        if (item.ToLower().Trim() == "q")
        {
            break;
        }
        int price = 0;

        while (true)
        {
            Console.Write("Price: ");
            string priceInput = Console.ReadLine();

            if (priceInput.ToLower().Trim() == "q")
            {
                break;
            }
            try
            {

                price = int.Parse(priceInput);
                break;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Wrong format, input numbers.");


            }
        }


        Product product = new Product(category, item, price);
        productList.addProduct(product);

        Console.WriteLine("Do you want to add another product (type Y for yes)?");
        string nextProduct = Console.ReadLine();
        anotherProduct = (nextProduct.ToUpper().Trim() == "Y");
    }

    Console.WriteLine("Here are your products, sorted by price, low to high: ");
    List<Product> sortedList = productList.getSorted();
    foreach (Product product in sortedList)
    {
        Console.WriteLine("Category: " + product.category);
        Console.WriteLine("Item: " + product.item);
        Console.WriteLine("Price: " + product.price);
    }



    Console.WriteLine("Here is the sum: " + productList.priceSum());
    Console.WriteLine("Would you like to add more products? Type 'Y' if yes, otherwise press any key.");
    string moreProducts = Console.ReadLine();
    addMoreProducts = (moreProducts.ToUpper().Trim() == "Y");
}

