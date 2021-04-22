using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class Product_Comparer : IComparer<Product>
    {
        //Default value of compareByFields 
        public ProductSortBy compareByFields = ProductSortBy.Id;
        public int Compare(Product x, Product y)
        {
            switch (compareByFields)
            {
                case ProductSortBy.stockQty:
                    return x.QuantityWarehouse.CompareTo(y.QuantityWarehouse);
                case ProductSortBy.shelfQty:
                    return x.QuantityShelf.CompareTo(y.QuantityShelf);
                case ProductSortBy.Name:
                    return x.Name.CompareTo(y.Name);
                case ProductSortBy.Id:
                    return x.Id.CompareTo(y.Id);
                default: break;

            }
            return x.Id.CompareTo(y.Id);

        }
    }
}
