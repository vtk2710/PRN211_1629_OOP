namespace PRN.SE1629;
using static System.Console;
public class Program
{
    public static void Main()
    {
        //1. Khai bao doi tuong ManagementProduct
        ProductManagement productManagement = new ProductManagement();

        //2. Them n product
        productManagement.Add(new Product(1, "Laptop Dell 15 inch", "New product with new features 2022", 1500, 100));
        productManagement.Add(new Product(2, "Macbook Pro 2022", "New product with new features 2022", 2000, 200));
        productManagement.Add(new Product(3, "Iphone 14 Pro", "New product with new features 2022", 2500, 300));
        productManagement.Add(new Product(4, "Samsung Galaxy", "New product with new features 2022", 3000, 400));

        productManagement.Display();
    }
}