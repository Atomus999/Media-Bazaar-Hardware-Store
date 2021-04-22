using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class Product_Manager
    {
        private List<Product> products;
        private List<DataTableModelProduct> productsTable;
        public DatabaseHelperProduct dataHelperProduct { get; set; } = new DatabaseHelperProduct();
        private Product_Manager()
        {
            products = new List<Product>();
            productsTable = new List<DataTableModelProduct>();
        }

        private static Product_Manager instance;
        public static Product_Manager GetInstance()
        {
            if (instance == null)
                instance = new Product_Manager();
            return instance;
        }

        public void loadProducts(List<Employee> employees)
        {
            RemoveAllProducts();
            products = dataHelperProduct.loadProducts(employees);
        }

        public void AddProduct(Product selectedProduct)
        {
            products.Add(selectedProduct);
            dataHelperProduct.AddProduct(selectedProduct);
        }

        public void RemoveProductById(int id)
        {
            for (int i = products.Count - 1; i >= 0; i--)
            {
                if (products[i].Id == id)
                {
                    dataHelperProduct.RemoveProduct(products[i]);
                    products.Remove(products[i]);
                }
            }
        }

        public void DeactivateProduct(Product p)
        {
            foreach (Product pr in products)
            {
                if (pr == p)
                {
                    pr.State = ProductState.UNAVAILABLE;
                    dataHelperProduct.UpdateProduct(pr);
                }
            }
        }

        public Product GetProductById(int id)
        {
            foreach (Product s in products)
            {
                if (s.Id == id)
                {
                    return s;
                }
            }
            return null;
        }

        public List<Product> GetProductList()
        {
            return products;
        }

        public void SortProductsBy(ProductSortBy productSort)
        {
            Product_Comparer productComparer = new Product_Comparer();
            productComparer.compareByFields = productSort;
            products.Sort(productComparer);
        }

        public void RemoveAllProducts()
        {
            products.Clear();
        }

        public ProductState ConvertStringToState(string s)
        {
            switch (s)
            {
                case "AVAILABLE":
                    return ProductState.AVAILABLE;
                case "UNAVAILABLE":
                    return ProductState.UNAVAILABLE;
                default: return ProductState.UNAVAILABLE;
            }
        }

        public bool ValidateID(int id)
        {
            foreach (Product p in products)
            {
                if (p.Id == id)
                {
                    return true;
                }

            }
            return false;
        }

        public void UpdateProduct(int id, string model, string brandName, float price, string description, double weight, double height, double width, double depth, string category, int aisleNumber, int qtyWh, int qtySh, DateTime shipmentDate, Employee registeredEmp, ProductState state, string name, string barcode)
        {
            foreach (Product p in products)
            {
                if (p.Id == id)
                {
                    p.Id = id;
                    p.Model = model;
                    p.BrandName = brandName;
                    p.Price = price;
                    p.Description = description;
                    p.Weight = weight;
                    p.Height = height;
                    p.Width = width;
                    p.Depth = depth;
                    p.Category = category;
                    p.AisleNumber = aisleNumber;
                    p.ShipmentDate = shipmentDate;
                    p.QuantityWarehouse = qtyWh;
                    p.QuantityShelf = qtySh;
                    p.RegisteredEmployee = registeredEmp;
                    p.State = state;
                    p.Name = name;
                    p.Barcode = barcode;
                    dataHelperProduct.UpdateProduct(p);
                    break;
                }
            }
        }

        public List<DataTableModelProduct> GetProductsDataTable()
        {
            productsTable.Clear();
            foreach(Product p in products)
            {
                DataTableModelProduct pModel = new DataTableModelProduct(p.Id, p.Name, p.QuantityWarehouse, p.State, p.Barcode);
                productsTable.Add(pModel);
            }
            return productsTable;
        }

        public Product GetProductByBarcode(string barcode)
        {
            foreach(Product p in products)
            {
                if (p.Barcode == barcode)
                {
                    return p;
                }
            }
            return null;
        }

        public List<DataTableModelProduct> GetProductsDataTableByName(string name)
        {
            List<DataTableModelProduct> returnedList = new List<DataTableModelProduct>();
            foreach (Product p in products)
            {
                if (p.Name.ToLower().Contains(name.ToLower()))
                {
                    DataTableModelProduct pModel = new DataTableModelProduct(p.Id, p.Name, p.QuantityWarehouse, p.State, p.Barcode);
                    returnedList.Add(pModel);
                }
                
            }
            return returnedList;
        }

        public List<DataTableModelProduct> GetProductsDataTableById(int id)
        {
            List<DataTableModelProduct> returnedList = new List<DataTableModelProduct>();
            foreach (Product p in products)
            {
                if (p.Id == id)
                {
                    DataTableModelProduct pModel = new DataTableModelProduct(p.Id, p.Name, p.QuantityWarehouse, p.State, p.Barcode);
                    returnedList.Add(pModel);
                }

            }
            return returnedList;
        }
    }
}
