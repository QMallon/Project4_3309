using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cddvdshop
{
    [Serializable()]
    class DVD: Product
    {
        private string hiddenLeadActor;
        private DateTime hiddenReleaseDate;
        private int hiddenRunTime;
        public DVD()
        {

        }
        //constructor
        public DVD(int UPC, decimal price, string title, int quantity, string leadActor, DateTime releaseDate, int runTime) : base(UPC, price, title, quantity)
        {
            hiddenLeadActor = leadActor;
            hiddenReleaseDate = releaseDate.Date;
            hiddenRunTime = runTime;
        }
        //save
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenLeadActor = f.txtDVDLeadActor.Text;
            hiddenReleaseDate = Convert.ToDateTime(f.txtDVDReleaseDate.Text);
            hiddenRunTime = Convert.ToInt32(f.txtDVDRunTime.Text);
        }  // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtDVDLeadActor.Text = hiddenLeadActor;
            f.txtDVDReleaseDate.Text = hiddenReleaseDate.ToString();
            f.txtDVDRunTime.Text = hiddenRunTime.ToString();
        }  // end Display


        // This toString function overrides the Object toString
        // function.  The base refers to Object because this class
        // inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Lead Actor : " + hiddenLeadActor + "\n";
            s += "Release Date : " + hiddenReleaseDate + "\n";
            s += "Run Time : " + hiddenRunTime + "\n";
            return s;
        }  // end ToString

    }
}
