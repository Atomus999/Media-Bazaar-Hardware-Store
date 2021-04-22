using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App.Admin
{
    public class DepotStatisticsManager
    {
        public Ticket_Manager ticketManager { get; set; }
        public double calculateTurnover(Product product)
        {
            double turnoverPrice = 0.00;
            int quantitySold = 0;
            
            foreach(Ticket t in ticketManager.getAllTickets())
            {
                if (t.product.Id == product.Id)
                {
                    if(t.CurrentState == state.Accepted)
                    quantitySold += t.Quantity;
                }
            }
            turnoverPrice = quantitySold * product.Price;
            return turnoverPrice;
            
        }
        public List<Product> selectedCategoryProducts (string category) //If the category matches from CB add matching products in the List
        {
            List<Product> items = new List<Product>() ; 
            foreach (Product product in Product_Manager.GetInstance().GetProductList())
            {
                if (product.Category == category)
                {
                    items.Add(product);

                }
                
            }
            return items;

        }
        

        public Product getPersonById(int id)
        {
            Product product = Product_Manager.GetInstance().GetProductById(id); ;
            if (product != null)
            {
                return product;
            }
            else
            {
                throw new NullReferenceException("Id was not found in get person");
            }
        }

        public int numberOfProducts() //Number of products types
        {
            int productNumber = 0;
            foreach (Product product in Product_Manager.GetInstance().GetProductList())
            {
                if (product != null)
                {
                    productNumber++;
                }
            }
            if (productNumber == 0)
            {
                throw new Exception("There is no products");
            }
            return productNumber;
        }

        public int numberOfUnavailableProducts() //Unavailable products count
        {
            int UnavailableProducts = 0;
            foreach (Product product in Product_Manager.GetInstance().GetProductList())
            {
                if (product.State == ProductState.UNAVAILABLE)
                {
                    UnavailableProducts++;
                }
            }
            return UnavailableProducts;
        }

    }
}

