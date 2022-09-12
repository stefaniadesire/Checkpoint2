

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







//Console.WriteLine("Please add your category, items and price. You can quit with 'q' ");
//string category = Console.ReadLine();
//string item = Console.ReadLine();
//int price = int.Parse(Console.ReadLine());

//List<Category> catList = new List<Category>();
//Category category1 = category(Console.ReadLine);

//catList.Add(category1);



//public class Category
//{

//}

//public class Item
//{

//}

//public class Price
//{

//}





//ProductList[category] = new ProductList();
//ProductList category = new ProductList();
//category.Category = Console.ReadLine;
//ProductList item = new ProductList();
//item.Item = Console.ReadLine;


//string category = Console.ReadLine();
//string item = Console.ReadLine();
//int price = int.Parse(Console.ReadLine());

//public class ProductList
//{
//    public ProductList()
//    {
//    }

//    public ProductList(string category, string item, int price)
//    {
//        Category = category;
//        Item = item;
//        Price = price;
//    }

//    public string Category { get; set; }
//    public string Item { get; set; }
//    public int Price { get; set; }

//    List<ProductList> products = new List<ProductList>()
//    {

//    };

//    public string Print()
//    {
//        return this.Category + " " + this.Item + " " + this.Price;


//    }

//    public string Category;
//    public string Item;
//    public int Price;
//}