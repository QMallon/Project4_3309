using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cddvdshop
{
    class ProductList
    {
        List<Product> pList = new List<Product>();
        public ProductList()
        {

        }
        public Product Search(int upc)
        {
            return pList[upc];
        }

        public void add(Product addProduct)
        {
            pList.Add(addProduct);
        }
        public int Count()
        {
            return pList.Count;
        }
        public Product getAnItem(int i)
        {
            return pList[i];
        }
    }
}
