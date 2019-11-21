using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            foreach (Product p in pList) {
                if(p.ProductUPC == upc)
                {
                    return p;
                }
            }
            
                
            
            
            
                MessageBox.Show("Product with that upc does not exist");
               return null;
            
            
        }
        public bool Check(int upc)
        {
            foreach(Product p in pList)
            {
                if(p.ProductUPC == upc)
                {
                    return false;
                }
            }
            return true;
        }
        public bool checkISBN(int isbnleft)
        {
            foreach(Book b in pList)
            {
                if(b.getISBN() == isbnleft)
                {
                    return false;
                }
            }
            return true;
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
