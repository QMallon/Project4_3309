using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cddvdshop
{
    public class ProductList
    {
        public List<Product> pList;
        public ProductList()
        {
            pList = new List<Product>();
        }
        public Product Search(int upc)
        {
            return pList[upc];
        }
        //adds product to list
        public void add(Product addProduct)
        {
            pList.Add(addProduct);
        }
        //gets count of products in list
        public int Count()
        {
            return pList.Count;
        }
        //gets a product of a 
        public Product getAnItem(int i)
        {
            return pList[i];
        }
    }
}
