using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cddvdshop
{
    [Serializable()]
    class BookCIS:Book
    {
        private string hiddenCISArea;
        public BookCIS()
        {

        }
        public BookCIS(int UPC, decimal price, string title, int quantity, int ISBNleft, int ISBNright, string author, int pages, String CISArea):base(UPC, price, title, quantity, ISBNleft, ISBNright, author, pages) {
            hiddenCISArea = CISArea;
        }
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenCISArea = f.txtBookCISCISArea.Text;
        }  // end Save
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtBookCISCISArea.Text = hiddenCISArea;
        }

        public override string ToString()
        {
            string s = base.ToString();
            s += "CIS Area :" + hiddenCISArea;
            return s;
        }
    }
}
