using cddvdshop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Quinn Mallon
 Abu Syed
cdOrchestra class
     */
namespace cddvdshop
{
    [Serializable()]
    class CDOrchestra:CDClassical
    {
        private string hiddenConductor;
        public CDOrchestra()
        {

        }
        public CDOrchestra(int UPC, decimal price, string title, int quantity,
            string label, string artists, string conductor):base (UPC,price,title,quantity,label,artists)
        {

            hiddenConductor = conductor;
        }
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenConductor = f.txtCDOrchestraConductor.Text;
        } // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtCDOrchestraConductor.Text = hiddenConductor;
        }  // end Display


        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Conductor :" + hiddenConductor;
            return s;
        }  // end ToString
    }
}
