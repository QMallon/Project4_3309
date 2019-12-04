using cddvdshop.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cddvdshop
{

    public partial class frmBookCDDVDShop : Form
    {
        //FormController FormController;
        public frmBookCDDVDShop()
        {

            InitializeComponent();
            //FormController = new FormController(this);

        }

        
        ProductList thisProductList = new ProductList();

        // This index keeps track of the current Owl
        int currentIndex = -1;

        int recordsProcessedCount = 0;
        // File to read or write to
        string FileName = "PersistentObject.bin";

        // Database methods and attributes stored here
        ProductDB dbFunctions = new ProductDB();// Parameterless Constructor for fmrEmpMan
      

        // Tooltip messages
        string ttCreateCDChamber = "Click to enter Make CDChamber mode to add a CDChamber to the List of Products.";
        string ttCreateCDOrchestra = "Click to enter Make CDOrchestra mode to add a CDOrchestra to the List of Products.";
        string ttCreateBook = "Click to enter Make Book mode to add a Book to the List of Products.";
        string ttCreateBookCIS = "Click to enter Make BookCIS mode to add a BookCIS to the List of Products.";
        string ttCreateDVD = "Click to enter Make DVD mode to add a DVD to the List of Products.";
        string ttSaveCDChamber = "Click to Save a CDChamber object to the List of Products.";
        string ttSaveCDOrchestra = "Click to Save a CDOrchestra object to the List of Products.";
        string ttSaveBookCIS = "Click to Save a BookCIS object to the list of Products.";
        string ttSaveBook = "Click to Save the Book object to the List of Products.";
        string ttSaveDVD = "Click to Save the DVD to the List of Products.";
        string ttClear = "Click to Clear Form.";
        string ttFind = "Click to Find a Product in the List of Products.";
        string ttDelete = "Click to Delete Product from the List of Products.";
        string ttEdit = "Click to Edit a Product's data.";
        string ttExit = "Click to exit application.";

        // ?????????? Fix The Specs (in red) for Each Item ??????????

        string ttProductUPC = "Enter a 5 digit integer - no leading zeros";
        string ttProductPrice = "Enter dollars and cents >= 0.0. NO $. Exactly two decimal digits";
        string ttProductTitle = "Enter a string of words (all letters) separated by blanks for any item in the shop";
        string ttProductQuantity = "Enter any integer greater than or equal to 0";
        string ttBookISBN = "Enter Book ISBN in format nnn-nnn)";
        string ttBookAuthor = "Enter Book Author first and last names (all letters) separated by a blank";
        string ttBookPages = "Enter Book page count as an integer greater than 0.";
        string ttDVDLeadActor = "Enter DVD Lead Actor with first and last names (all letters) separated by a blank.";
        string ttDVDReleaseDate = "Enter DVD Release Date in form mm/dd/yyyy between Jan 1 1980 and Dec 31 2019. Use date picker.";
        string ttDVDRunTime = "Enter DVD run time in minutes. Must be a positive integer.";
        string ttBookCISCISArea = "Enter valid CIS area of study using a drop-down menu.";
        string ttCDClassicalLabel = "Enter any sequence of words (all letters) separated by blanks.";
        string ttCDClassicalArtists = "Enter soloists last names separated by a blank";
        string ttCDChamberInstrumentList = "Enter Instrument names separated by a blank";
        string ttCDOrchestraConductor = "Enter Conductor last name with all letters and one blank or one hyphen";

        //*****This section has the forms load and closing events

        // This sub is called when the form is loaded
        private void frmBookCDDVDShop_Load(System.Object sender, System.EventArgs e)
        {
            // Read serialized binary data file
            SFManager.ReadFromFile(ref thisProductList, FileName);
            FormController.clear(this);
            ToolTip toolTip1 = new ToolTip();
            // Set initial Tooltips
            toolTip1.SetToolTip(btnCreateBookCIS, ttCreateBookCIS);
            toolTip1.SetToolTip(btnCreateBook, ttCreateBook);
            toolTip1.SetToolTip(btnCreateCDChamber, ttCreateCDOrchestra);
            toolTip1.SetToolTip(btnCreateCDOrchestra, ttCreateDVD);
            toolTip1.SetToolTip(btnCreateDVD, ttCreateCDChamber);

            toolTip1.SetToolTip(btnClear, ttClear);
            toolTip1.SetToolTip(btnDelete, ttDelete);
            toolTip1.SetToolTip(btnEdit, ttEdit);
            toolTip1.SetToolTip(btnFind, ttFind);
            toolTip1.SetToolTip(btnExit, ttExit);

            toolTip1.SetToolTip(txtProductUPC, ttProductUPC);
            toolTip1.SetToolTip(txtProductPrice, ttProductPrice);
            toolTip1.SetToolTip(txtProductQuantity, ttProductQuantity);
            toolTip1.SetToolTip(txtProductTitle, ttProductTitle);
            toolTip1.SetToolTip(txtCDOrchestraConductor, ttCDOrchestraConductor);
            toolTip1.SetToolTip(txtBookISBNLeft, ttBookISBN);
            toolTip1.SetToolTip(txtBookAuthor, ttBookAuthor);
            toolTip1.SetToolTip(txtBookPages, ttBookPages);
            toolTip1.SetToolTip(txtDVDLeadActor, ttDVDLeadActor);
            toolTip1.SetToolTip(txtDVDReleaseDate, ttDVDReleaseDate);
            toolTip1.SetToolTip(txtDVDRunTime, ttDVDRunTime);
            toolTip1.SetToolTip(txtCDClassicalLabel, ttCDClassicalLabel);
            toolTip1.SetToolTip(txtCDClassicalArtists, ttCDClassicalArtists);
            toolTip1.SetToolTip(txtCDOrchestraConductor, ttCDOrchestraConductor);
            toolTip1.SetToolTip(txtCDChamberInstrumentList, ttCDChamberInstrumentList);
            toolTip1.SetToolTip(txtBookCISCISArea, ttBookCISCISArea);
            toolTip1.SetToolTip(btnCreateBookCIS, ttCreateBookCIS);
        } // end frmEBookCDDVDShop_Load


        // Clear textboxes
        private void btnClear_Click(System.Object sender, System.EventArgs e)
        {
            FormController.clear(this);
        }  // end btnClear_Click


        // Checks if Product List is empty and, if not, copies the data for the
        // ith Product to the appropriate group textboxes using the display sub.
        // Also checks to determine if the next button should be enabled.
        private void getItem(int i)
        {
            if (thisProductList.Count() == 0)
            {
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                // btnToString.Enabled = false;
                //lblUserMessage.Text = "Please select an operation";
            }
            else if (i < 0 || i >= thisProductList.Count())
            {
                MessageBox.Show("getItem error: index out of range");
                return;
            }
            else
            {
                currentIndex = i;
                //thisProductList.getAnItem(i).Display(this);     // *****************
                // thisOwlList.RemoveAt(i);
                //lblUserMessage.Text = "Object Type: " + thisProductList.getAnItem(i).GetType().ToString() +
                       // " List Index: " + i.ToString();
                btnFind.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }  // end else
        } // end getItem



















        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateBook_Click(System.Object sender, System.EventArgs e)
        {
            if (txtBookISBNLeft.Enabled == false) {
                FormController.activateBook(this);
                FormController.deactivateAllButBook(this);
                    }
            else
            {
                validate(1);
            }
            
        }
        //lets user input a upc
        private void btnEnterUPC_Click(System.Object sender, System.EventArgs e)
        {
            if (txtProductUPC.Enabled == false)
            {
                FormController.activateProduct(this);
                FormController.listmode(this);
            }
            
        }

        private void btnExit_Click(System.Object sender, System.EventArgs e)
        {
            SFManager.writeToFile( thisProductList, FileName);
            Application.Exit();
        }
        //Validate data
        private void validate(int x)
        {
            int tempISBNL;
            int tempISBNR;
            int tempPages;
            int tempUPC;
            decimal tempPrice;
            int tempQuant;
            String templeadActor;
            DateTime tempreleaseDate;
            int tempRunTime;
            String CisArea = txtBookCISCISArea.Text;
            string tempConductor;
            string tempCDArtist;
            String tempCDLabel;
            string tempinstrumentList;




            try
            {
                 tempUPC = Convert.ToInt32(txtProductUPC.Text);
                 tempPrice = Convert.ToDecimal(txtProductPrice.Text);
                 tempQuant = Convert.ToInt32(txtProductQuantity.Text);

                if(x ==1)
                {
                    tempISBNL = Convert.ToInt32(txtBookISBNLeft.Text);
                    tempISBNR = Convert.ToInt32(txtBookISBNRight.Text);
                    tempPages = Convert.ToInt32(txtBookPages.Text);


                    if (txtBookISBNLeft.Text.Length ==3 && txtBookISBNRight.Text.Length == 3 && thisProductList.checkISBN(tempISBNL, tempISBNR) && tempPages > 0)
                    {
                        thisProductList.add(new Book(tempUPC, tempPrice, txtProductTitle.Text, tempQuant, tempISBNL, tempISBNR, txtBookAuthor.Text, tempPages));
                        MessageBox.Show("NEW BOOK ADDED");
                    }
                    else
                    {
                        MessageBox.Show("invalid data");
                    }
                }
                if (x == 2)
                {
                    tempISBNL = Convert.ToInt32(txtBookISBNLeft.Text);
                    tempISBNR = Convert.ToInt32(txtBookISBNRight.Text);
                    tempPages = Convert.ToInt32(txtBookPages.Text);
                    if (txtBookISBNLeft.Text.Length == 3 && txtBookISBNRight.Text.Length == 3 && thisProductList.checkISBN(tempISBNL, tempISBNR) && tempPages > 0)
                    {
                        thisProductList.add(new BookCIS(tempUPC, tempPrice, txtProductTitle.Text, tempQuant, tempISBNL, tempISBNR, txtBookAuthor.Text, tempPages, CisArea));
                        MessageBox.Show("NEW CIS BOOK ADDED");
                    }
                    else
                    {
                        MessageBox.Show("invalid data");
                    }
                    
                }
                if( x == 3)
                {
                    DateTime min = new DateTime(1980,01,01);
                    DateTime max = new DateTime(2019,12,31);
                    templeadActor = txtDVDLeadActor.Text;
                    tempreleaseDate = Convert.ToDateTime(txtDVDReleaseDate.Text);
                    tempRunTime = Convert.ToInt32(txtDVDRunTime.Text);
                    if (tempRunTime > 0 && tempreleaseDate > min && tempreleaseDate < max)
                    {
                        thisProductList.add(new DVD(tempUPC, tempPrice, txtProductTitle.Text, tempQuant,templeadActor, tempreleaseDate, tempRunTime));
                        MessageBox.Show("NEW DVD ADDED");
                    }
                    else
                    {
                        MessageBox.Show("invalid data");
                    }



                }
                if(x == 4)
                {
                    tempCDArtist =  txtCDClassicalArtists.Text;
                    tempCDLabel = txtCDClassicalLabel.Text;
                    tempConductor = txtCDOrchestraConductor.Text;
                        
                    
                    
                        thisProductList.add(new CDOrchestra(tempUPC, tempPrice, txtProductTitle.Text, tempQuant, tempCDArtist, tempCDLabel, tempConductor));
                        MessageBox.Show("NEW CD Orchestra ADDED");
                    
                    
                }
                if (x == 5)
                {
                    tempCDArtist = txtCDClassicalArtists.Text;
                    tempCDLabel = txtCDClassicalLabel.Text;
                    tempinstrumentList = txtCDChamberInstrumentList.Text;



                    thisProductList.add(new CDChamber(tempUPC, tempPrice, txtProductTitle.Text, tempQuant, tempCDArtist, tempCDLabel, tempinstrumentList));
                    MessageBox.Show("NEW CD Chamber ADDED");
                }

            }
            catch
            {
                MessageBox.Show("invalid data");
            }

        }
        //validate for edits checks 
        private bool validateEdit(int x)
        {
            int tempISBNL;
            int tempISBNR;
            int tempPages;
            int tempUPC;
            decimal tempPrice;
            int tempQuant;
            String templeadActor;
            DateTime tempreleaseDate;
            int tempRunTime;
            String CisArea = txtBookCISCISArea.Text;
            string tempConductor;
            string tempCDArtist;
            String tempCDLabel;
            string tempinstrumentList;




            try
            {
                tempUPC = Convert.ToInt32(txtProductUPC.Text);
                tempPrice = Convert.ToDecimal(txtProductPrice.Text);
                tempQuant = Convert.ToInt32(txtProductQuantity.Text);

                if (x == 1)
                {
                    tempISBNL = Convert.ToInt32(txtBookISBNLeft.Text);
                    tempISBNR = Convert.ToInt32(txtBookISBNRight.Text);
                    tempPages = Convert.ToInt32(txtBookPages.Text);


                    if(tempISBNL.ToString().Length == 3 && tempISBNR.ToString().Length == 3 && thisProductList.checkISBN(tempISBNL, tempISBNR) && tempPages > 0)
                    {
                        thisProductList.add(new Book(tempUPC, tempPrice, txtProductTitle.Text, tempQuant, tempISBNL, tempISBNR, txtBookAuthor.Text, tempPages));
                        MessageBox.Show(" BOOK Edited");
                    }
                    else
                    {
                        MessageBox.Show("invalid data");
                    }
                }
                if (x == 2)
                {
                    tempISBNL = Convert.ToInt32(txtBookISBNLeft.Text);
                    tempISBNR = Convert.ToInt32(txtBookISBNRight.Text);
                    tempPages = Convert.ToInt32(txtBookPages.Text);
                    if (tempISBNL.ToString().Length == 3 && tempISBNR.ToString().Length == 3 && thisProductList.checkISBN(tempISBNL, tempISBNR) && tempPages > 0)
                    {
                        thisProductList.add(new BookCIS(tempUPC, tempPrice, txtProductTitle.Text, tempQuant, tempISBNL, tempISBNR, txtBookAuthor.Text, tempPages, CisArea));
                        MessageBox.Show(" CIS BOOK Edited");
                    }
                    else
                    {
                        MessageBox.Show("invalid data");
                    }

                }
                if (x == 3)
                {
                    DateTime min = new DateTime(1980, 01, 01);
                    DateTime max = new DateTime(2019, 12, 31);
                    templeadActor = txtDVDLeadActor.Text;
                    tempreleaseDate = Convert.ToDateTime(txtDVDReleaseDate.Text);
                    tempRunTime = Convert.ToInt32(txtDVDRunTime.Text);
                    if (tempRunTime > 0 && tempreleaseDate > min && tempreleaseDate < max)
                    {
                        thisProductList.add(new DVD(tempUPC, tempPrice, txtProductTitle.Text, tempQuant, templeadActor, tempreleaseDate, tempRunTime));
                        MessageBox.Show("DVD Edited");
                    }
                    else
                    {
                        MessageBox.Show("invalid Run Time");
                    }



                }
                if (x == 4)
                {
                    tempCDArtist = txtCDClassicalArtists.Text;
                    tempCDLabel = txtCDClassicalLabel.Text;
                    tempConductor = txtCDOrchestraConductor.Text;



                    thisProductList.add(new CDOrchestra(tempUPC, tempPrice, txtProductTitle.Text, tempQuant, tempCDArtist, tempCDLabel, tempConductor));
                    MessageBox.Show("CD Orchestra Edited");


                }
                if (x == 5)
                {
                    tempCDArtist = txtCDClassicalArtists.Text;
                    tempCDLabel = txtCDClassicalLabel.Text;
                    tempinstrumentList = txtCDChamberInstrumentList.Text;



                    thisProductList.add(new CDChamber(tempUPC, tempPrice, txtProductTitle.Text, tempQuant, tempCDArtist, tempCDLabel, tempinstrumentList));
                    MessageBox.Show("CD Chamber Edited");
                }
                return true;

            }
            catch
            {
                MessageBox.Show("invalid data");
                return false;
            }

        }
        //button click events
        private void btnFind_Click(System.Object sender, System.EventArgs e)
        {
            
                try
                {
                    int tempUPC = Convert.ToInt32(txtProductUPC.Text);
                    {
                    bool ok = false;
                    string record = "";
                    dbFunctions.SelectProductFromProduct(tempUPC, out ok, out record);
                    //thisProductList.Search(tempUPC).Display(this);
                    display(record);
                        FormController.activateAddButtons(this);
                        //thisProductList.Search(Convert.ToInt32(txtProductUPC.Text)).Display(this);


                }



                }
                catch
                {
                    MessageBox.Show("invalid UPC or non existant UPC");
                }
            
            
        }

        private void btnCreateBookCIS_Click(System.Object sender, System.EventArgs e)
        {
            if (txtBookCISCISArea.Enabled == false)
            {
//FormController.
                FormController.activateBookCIS(this);
                FormController.deactivateAllButBookCIS(this);
                
            }
            else
            {
                validate(2);
            }
        }

        private void btnCreateDVD_Click(System.Object sender, System.EventArgs e)
        {
            if (txtDVDLeadActor.Enabled == false)
            {
                FormController.activateDVD(this);
                FormController.deactivateAllButDVD(this);

            }
            else
            {
                validate(3);
            }
        }

        private void btnCreateCDOrchestra_Click(System.Object sender, System.EventArgs e)
        {
            if (txtCDOrchestraConductor.Enabled == false)
            {
                FormController.activateCDClassical(this);
                FormController.activateCDOrchestra(this);
                FormController.deactivateAllButCDOrchestra(this);

            }
            else
            {
                validate(4);
            }
        }

        private void btnCreateCDChamber_Click(System.Object sender, System.EventArgs e)
        {
            if (txtCDChamberInstrumentList.Enabled == false)
            {
                FormController.activateCDClassical(this);
                FormController.activateCDChamber(this);
                FormController.deactivateAllButCDChamber(this);

            }
            else
            {
                validate(5);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Deleted");
            thisProductList.delete(Convert.ToInt32(txtProductUPC.Text));
            SFManager.writeToFile(thisProductList, FileName);
            
        }
        //edit determines what shows based on the type
        private void btnEdit_Click(System.Object sender, System.EventArgs e)
        {
            MessageBox.Show(thisProductList.getPType(Convert.ToInt32(txtProductUPC.Text)));
            if(thisProductList.getPType(Convert.ToInt32(txtProductUPC.Text)) == "cddvdshop.Book")
            {
                FormController.activateBook(this);
                FormController.deactivateAllButBook(this);
                btnCreateBook.Enabled = false;
            }
            if (thisProductList.getPType(Convert.ToInt32(txtProductUPC.Text)) == "cddvdshop.BookCIS")
            {
                FormController.activateBookCIS(this);
                FormController.deactivateAllButBookCIS(this);
                btnCreateBookCIS.Enabled = false;
            }
            if (thisProductList.getPType(Convert.ToInt32(txtProductUPC.Text)) == "cddvdshop.DVD")
            {
                FormController.activateDVD(this);
                FormController.deactivateAllButDVD(this);
                btnCreateDVD.Enabled = false;
            }
            if (thisProductList.getPType(Convert.ToInt32(txtProductUPC.Text)) == "cddvdshop.CDOrchestra")
            {
                FormController.activateCDOrchestra(this);
                FormController.deactivateAllButCDOrchestra(this);
                btnCreateCDOrchestra.Enabled = false;
            }
            if (thisProductList.getPType(Convert.ToInt32(txtProductUPC.Text)) == "cddvdshop.CDChamber")
            {
                FormController.activateCDChamber(this);
                FormController.deactivateAllButCDChamber(this);
                btnCreateCDChamber.Enabled = false;
            }
        }

        private void btnSaveEditUpdate_Click(System.Object sender, System.EventArgs e)
        {
            if (thisProductList.getPType(Convert.ToInt32(txtProductUPC.Text)) == "cddvdshop.Book")
            {
                if (validateEdit(1)){
                    SFManager.writeToFile(thisProductList, FileName);
                    MessageBox.Show("Changes saved");
                    thisProductList.delete(Convert.ToInt32(txtProductUPC.Text));
                }
                else
                {
                    MessageBox.Show("invalid data");
                }



            }
            if (thisProductList.getPType(Convert.ToInt32(txtProductUPC.Text)) == "cddvdshop.BookCIS")
            {
                if (validateEdit(2)){
                    SFManager.writeToFile(thisProductList, FileName);
                    MessageBox.Show("Changes saved");
                    thisProductList.delete(Convert.ToInt32(txtProductUPC.Text));
                }
                else
                {
                    MessageBox.Show("invalid data");
                }





            }
            if (thisProductList.getPType(Convert.ToInt32(txtProductUPC.Text)) == "cddvdshop.DVD")
            {
                if (validateEdit(3)){
                    SFManager.writeToFile(thisProductList, FileName);
                    MessageBox.Show("Changes saved");
                    thisProductList.delete(Convert.ToInt32(txtProductUPC.Text));
                }
                else
                {
                    MessageBox.Show("invalid data");
                }


            }
            if (thisProductList.getPType(Convert.ToInt32(txtProductUPC.Text)) == "cddvdshop.CDOrchestra")
            {
                if (validateEdit(4)){
                    SFManager.writeToFile(thisProductList, FileName);
                    MessageBox.Show("Changes saved");
                    thisProductList.delete(Convert.ToInt32(txtProductUPC.Text));
                }
                else
                {
                    MessageBox.Show("invalid data");
                }


            }
            if (thisProductList.getPType(Convert.ToInt32(txtProductUPC.Text)) == "cddvdshop.CDChamber")
            {
                if (validateEdit(5))
                {
                    SFManager.writeToFile(thisProductList, FileName);
                    MessageBox.Show("Changes saved");
                    thisProductList.delete(Convert.ToInt32(txtProductUPC.Text));
                }
                else
                {
                    MessageBox.Show("invalid data");
                }
                


            }

            
        }
        public void display(string record)
        {
            string [] tempRecordArray = record.Split();
            List<string> recordList = new List<string>();
            foreach(string p in tempRecordArray)
            {
                
                if(p != "")
                {

                    recordList.Add(p);
                }

            }
            int y = 3;
            

            txtProductUPC.Text = recordList[0];
            txtProductPrice.Text = recordList[1];
            while(recordList[y] !="JUST MAKE THE TITLES WORK")
            txtProductTitle.Text += recordList[y];
            

            
            
        }
    }
}
