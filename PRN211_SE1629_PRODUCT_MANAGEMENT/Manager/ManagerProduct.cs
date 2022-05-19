namespace PRN.SE1629;
public class ProductManagement:IProduct
{
    private Product[] listProduct;
    private int size; //So luong phan tu that trong mang 1 chieu listProduct
    public ProductManagement()
    {
        this.size = 0;
        this.listProduct = new Product[Utils.InitLengProduct];
    }
    
    public ProductManagement(Product[] listProduct)
    {
        this.listProduct = listProduct;
        foreach(Product p in listProduct)
        {
            if (p != null) this.size++;
        }
    }

    public Product[] ListProduct { get => listProduct; set => listProduct = value; }

    public void Add(Product p)
    {
        //Viet giai thuat de thuc thi chen 1 phan tu vao mang 1 chieu tinh
        //1. Check de xem mang con trong khong ?
        if(this.size >= this.listProduct.Length)
        {
            //Thuc hien noi mang
            Product[] tmp = new Product[this.size*2];

            //Hot du lieu tu mang cu sang mang moi
            for(int i = 0; i < this.size; i++)
            {
                tmp[i] = this.listProduct[i];
            }

            this.listProduct = tmp;
        }

        //2. Neu ma con cho trong, thi chi add product
        this.listProduct[this.size++] = p;
    }

    public bool Delete(Product p)
    {
        return true;
    }

    public void Display()
    {
        foreach(Product p in this.listProduct)
        {
            Console.WriteLine(p);
        }
    }

    public Product GetProduct(int productID)
    {
        throw new NotImplementedException();
    }

    public bool Update(Product p)
    {
        throw new NotImplementedException();
    }
}

