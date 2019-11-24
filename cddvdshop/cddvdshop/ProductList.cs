using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cddvdshop
{
    [Serializable()]
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
        //checks upc
        public bool Check(int upc)
        {
            foreach(Product p in pList)
            {
                if(p.ProductUPC == upc)
                {
                    MessageBox.Show("UPC MUST BE UNIQUE");
                    return false;
                }
            }
            return true;
        }
        //checks left and right isbn to be unique

        public bool checkISBN(int isbnleft, int isbnright)
        {
            foreach(Book b in pList)
            {
                if(b.getISBNL() == isbnleft && b.getISBNR() == isbnright)
                {
                    MessageBox.Show("ISBN ALREADY USED");
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
        public void delete(int upc)
        {
            for(int x =0; x< pList.Count; x++)
            {
                if (pList[x].ProductUPC == upc)
                {
                    pList.RemoveAt(x);
                }

            }
        }
        //gets type
        public String getPType(int upc)
        {

            foreach (Product p in pList)
            {
               if(p.ProductUPC == upc)
                {
                    return p.GetType().ToString();
                }
               
            }
            return "error";
        }
    }
}
