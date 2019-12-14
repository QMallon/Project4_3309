using cddvdshop.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
/*
 Quinn Mallon
 Abu Syed
form code
     */
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
            //SFManager.ReadFromFile(ref thisProductList, FileName);
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



















        

        private void btnCreateBook_Click(System.Object sender, System.EventArgs e)
        {
            if (txtBookISBNLeft.Enabled == false) {
                FormController.activateBook(this);
                FormController.deactivateAllButBook(this);
                    }
            else
            {
                if (validateBook())
                {
                    int tempISBNL = Convert.ToInt32(txtBookISBNLeft.Text);
                    int tempISBNR = Convert.ToInt32(txtBookISBNRight.Text);
                    int tempPages = Convert.ToInt32(txtBookPages.Text);
                    int tempUPC = Convert.ToInt32(txtProductUPC.Text);
                    decimal tempPrice = Convert.ToDecimal(txtProductPrice.Text);
                    int tempQuant = Convert.ToInt32(txtProductQuantity.Text);



                    dbFunctions.InsertProduct(tempUPC, tempPrice, txtProductTitle.Text, tempQuant, "Book");
                   
                    MessageBox.Show("NEW BOOK ADDED");
                    
                        
                }
                else
                {
                    MessageBox.Show("Invalid data");
                }

            }
            
        }
        //lets user input a upc
        private void btnEnterUPC_Click(System.Object sender, System.EventArgs e)
        {
            if (txtProductUPC.Enabled == false)
            {
                txtProductUPC.Enabled = true;
                FormController.listmode(this);
            }
            
        }

        private void btnExit_Click(System.Object sender, System.EventArgs e)
        {
            //SFManager.writeToFile( thisProductList, FileName);
            Application.Exit();
        }
       
       
        //button click events
        private void btnFind_Click(System.Object sender, System.EventArgs e)
        {
            
                try
                {
                if (Validation.validateUPC(txtProductUPC.Text))
                {

                
                    int tempUPC = Convert.ToInt32(txtProductUPC.Text);
                    
                    bool ok = false;
                    string record = "";
                    dbFunctions.SelectProductFromProduct(tempUPC, out ok, out record);
                    //thisProductList.Search(tempUPC).Display(this);
                    display(record);
                        FormController.activateAddButtons(this);
                        //thisProductList.Search(Convert.ToInt32(txtProductUPC.Text)).Display(this);


                }
                else
                {
                    MessageBox.Show("INVALID UPC ENTERED MUST BE AN Int ");
                }



                }
                catch
                {
                    MessageBox.Show("DB error UPC does not exist");
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
                if (validateBookCis())
                {
                   int tempUPC = Convert.ToInt32(txtProductUPC.Text);
                   decimal tempPrice = Convert.ToDecimal(txtProductPrice.Text);
                   int tempQuant = Convert.ToInt32(txtProductQuantity.Text);
                   int tempISBNL = Convert.ToInt32(txtBookISBNLeft.Text);
                   int tempISBNR = Convert.ToInt32(txtBookISBNRight.Text);
                   int tempPages = Convert.ToInt32(txtBookPages.Text);



                    dbFunctions.InsertProduct(tempUPC, tempPrice, txtProductTitle.Text, tempQuant, "BookCis");
                    dbFunctions.InsertBookCIS(tempUPC, txtBookCISCISArea.Text);
                    MessageBox.Show("NEW CIS BOOK ADDED");

                }
            }
        }
        //creates dvd
        private void btnCreateDVD_Click(System.Object sender, System.EventArgs e)
        {
            if (txtDVDLeadActor.Enabled == false)
            {
                FormController.activateDVD(this);
                FormController.deactivateAllButDVD(this);

            }
            else
            {
                if (validateDVD())
                {
                   string templeadActor = txtDVDLeadActor.Text;
                  DateTime  tempreleaseDate = Convert.ToDateTime(txtDVDReleaseDate.Text);
                   int tempRunTime = Convert.ToInt32(txtDVDRunTime.Text);
                    int tempUPC = Convert.ToInt32(txtProductUPC.Text);
                    decimal tempPrice = Convert.ToDecimal(txtProductPrice.Text);
                    int tempQuant = Convert.ToInt32(txtProductQuantity.Text);

                    dbFunctions.InsertProduct(tempUPC, tempPrice, txtProductTitle.Text, tempQuant, "DVD");
                    dbFunctions.InsertDVD(tempUPC, txtDVDLeadActor.Text, tempreleaseDate, tempRunTime);

                    MessageBox.Show("NEW DVD ADDED");
                }
            }
        }
        //creates cd orchestra
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
                if (validateCDOrchestra())
                {
                    int tempUPC = Convert.ToInt32(txtProductUPC.Text);
                    decimal tempPrice = Convert.ToDecimal(txtProductPrice.Text);
                    int tempQuant = Convert.ToInt32(txtProductQuantity.Text);
                    string  tempCDArtist = txtCDClassicalArtists.Text;
                    string tempCDLabel = txtCDClassicalLabel.Text;
                    string tempConductor = txtCDOrchestraConductor.Text;
                    dbFunctions.InsertProduct(tempUPC, tempPrice, txtProductTitle.Text, tempQuant, "CDOrchestra");
                    dbFunctions.InsertCDClassical(tempUPC, tempCDLabel, tempCDArtist);
                    dbFunctions.InsertCDChamber(tempUPC, tempConductor);

                    MessageBox.Show("CD Orchestra added");

                }
            }
        }
        //creates the cd chamber
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
                if (validateCDChamber())
                {
                    int tempUPC = Convert.ToInt32(txtProductUPC.Text);
                    decimal tempPrice = Convert.ToDecimal(txtProductPrice.Text);
                    int tempQuant = Convert.ToInt32(txtProductQuantity.Text);
                    string tempCDArtist = txtCDClassicalArtists.Text;
                    string tempCDLabel = txtCDClassicalLabel.Text;
                    string tempChamberInstList = txtCDChamberInstrumentList.Text;

                    dbFunctions.InsertProduct(tempUPC, tempPrice, txtProductTitle.Text, tempQuant, "CDChamber");
                    dbFunctions.InsertCDClassical(tempUPC, tempCDLabel, tempCDArtist);
                    dbFunctions.InsertCDChamber(tempUPC, tempChamberInstList);
                    MessageBox.Show("CD CHamber added");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            dbFunctions.Delete(Convert.ToInt32(txtProductUPC.Text));
            
            MessageBox.Show("Product Deleted");

        }
        //edit determines what shows based on the type
        private void btnEdit_Click(System.Object sender, System.EventArgs e)
        {
            bool ok = false;
            string record = "";
            int tempUPC = Convert.ToInt32(txtProductUPC.Text);
            
            if (dbFunctions.getProductType() == "Book")
            {
                FormController.activateBook(this);
                FormController.deactivateAllButBook(this);
                btnCreateBook.Enabled = false;
            }
            if (dbFunctions.getProductType() == "BookCis")
            {
                FormController.activateBookCIS(this);
                FormController.deactivateAllButBookCIS(this);
                btnCreateBookCIS.Enabled = false;
            }
            if (dbFunctions.getProductType() == "DVD")
            {
                FormController.activateDVD(this);
                FormController.deactivateAllButDVD(this);
                btnCreateDVD.Enabled = false;
            }
            if (dbFunctions.getProductType() == "CDChamber")
            {
                FormController.activateCDOrchestra(this);
                FormController.deactivateAllButCDOrchestra(this);
                btnCreateCDOrchestra.Enabled = false;
            }
            if (dbFunctions.getProductType() == "CDOrchestra")
            {
                FormController.activateCDChamber(this);
                FormController.deactivateAllButCDChamber(this);
                btnCreateCDChamber.Enabled = false;
            }
        }
        //finds what type it is then goes to update it using it
        private void btnSaveEditUpdate_Click(System.Object sender, System.EventArgs e)
        {
            if (dbFunctions.getProductType() == "Book")
            {
                if (validateBook())
                {
                    int tempUPC = Convert.ToInt32(txtProductUPC.Text);
                    decimal tempPrice = Convert.ToDecimal(txtProductPrice.Text);
                    int tempQuant = Convert.ToInt32(txtProductQuantity.Text);
                    int tempISBNL = Convert.ToInt32(txtBookISBNLeft.Text);
                    int tempISBNR = Convert.ToInt32(txtBookISBNRight.Text);
                    int tempPages = Convert.ToInt32(txtBookPages.Text);
                    int tempfullISBN = int.Parse(tempISBNL.ToString() + tempISBNR.ToString());
                    dbFunctions.UpdateProduct(tempUPC, tempPrice, txtProductTitle.Text, tempQuant);
                    dbFunctions.UpdateBook(tempUPC, tempfullISBN, txtBookAuthor.Text, tempPages);

                }
            }
            if (dbFunctions.getProductType() == "BookCis")
            {
                if (validateBookCis())
                {
                    int tempUPC = Convert.ToInt32(txtProductUPC.Text);
                    decimal tempPrice = Convert.ToDecimal(txtProductPrice.Text);
                    int tempQuant = Convert.ToInt32(txtProductQuantity.Text);
                    int tempISBNL = Convert.ToInt32(txtBookISBNLeft.Text);
                    int tempISBNR = Convert.ToInt32(txtBookISBNRight.Text);
                    int tempPages = Convert.ToInt32(txtBookPages.Text);
                    int tempfullISBN = int.Parse(tempISBNL.ToString() + tempISBNR.ToString());
                    dbFunctions.UpdateProduct(tempUPC, tempPrice, txtProductTitle.Text, tempQuant);
                    dbFunctions.UpdateBook(tempUPC, tempfullISBN, txtBookAuthor.Text, tempPages);
                    dbFunctions.UpdateBookCIS(tempUPC, txtBookCISCISArea.Text);
                    MessageBox.Show("CIS BOOK updated");

                }
            }
            if (dbFunctions.getProductType() == "DVD")
            {
                int tempUPC = Convert.ToInt32(txtProductUPC.Text);
                decimal tempPrice = Convert.ToDecimal(txtProductPrice.Text);
                int tempQuant = Convert.ToInt32(txtProductQuantity.Text);
                string templeadActor = txtDVDLeadActor.Text;
                DateTime tempreleaseDate = Convert.ToDateTime(txtDVDReleaseDate.Text);
                int tempRunTime = Convert.ToInt32(txtDVDRunTime.Text);
                dbFunctions.UpdateProduct(tempUPC, tempPrice, txtProductTitle.Text, tempQuant);
                dbFunctions.UpdateDVD(tempUPC, txtDVDLeadActor.Text, tempreleaseDate, tempRunTime);

            }
            if (dbFunctions.getProductType() == "CDChamber")
            {
                int tempUPC = Convert.ToInt32(txtProductUPC.Text);
                decimal tempPrice = Convert.ToDecimal(txtProductPrice.Text);
                int tempQuant = Convert.ToInt32(txtProductQuantity.Text);
                string tempCDArtist = txtCDClassicalArtists.Text;
                string tempCDLabel = txtCDClassicalLabel.Text;
                string tempChamberInstList = txtCDChamberInstrumentList.Text;
                
                dbFunctions.UpdateProduct(tempUPC, tempPrice, txtProductTitle.Text, tempQuant);
                dbFunctions.UpdateCDClassical(tempUPC, tempCDLabel, tempCDArtist);
                dbFunctions.UpdateCDChamber(tempUPC, tempChamberInstList);

            }
            if (dbFunctions.getProductType() == "CDOrchestra")
            {
                int tempUPC = Convert.ToInt32(txtProductUPC.Text);
                decimal tempPrice = Convert.ToDecimal(txtProductPrice.Text);
                int tempQuant = Convert.ToInt32(txtProductQuantity.Text);
                string tempCDArtist = txtCDClassicalArtists.Text;
                string tempCDLabel = txtCDClassicalLabel.Text;
                string tempConductor = txtCDOrchestraConductor.Text;

                dbFunctions.UpdateProduct(tempUPC, tempPrice, txtProductTitle.Text, tempQuant);
                dbFunctions.UpdateCDClassical(tempUPC, tempCDLabel, tempCDArtist);
                dbFunctions.UpdateCDOrchestra(tempUPC, tempConductor);
               

            }


        }
        //displays the different buttons for the products
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
            int y = 2;
            

            txtProductUPC.Text = recordList[0];
            txtProductPrice.Text = recordList[1];

            while (!Validation.validateIntNumber(recordList[y]))
            {
                txtProductTitle.Text += recordList[y];
                y++;
            }
            txtProductQuantity.Text = recordList[y];
            y++;
            
            if(recordList[y] == "Book")
            {
                y++;
                string tempISBNl = recordList[y].Substring(0);
                string tempISBNr = recordList[y].Substring(3);
                txtBookISBNLeft.Text = tempISBNl;
                txtBookISBNRight.Text = tempISBNl;
                while (!Validation.validateIntNumber(recordList[y]) && !Validation.validateIntNumber(recordList[y]))
                {
                    txtBookAuthor.Text += " " + recordList[y];
                    y++;
                }

                txtBookPages.Text = recordList[y];
                
                
            }
            if (recordList[y] == "DVD")
            {
                y++;
                while (!Validation.validateIntNumber(recordList[y]) && !Validation.validateIntNumber(recordList[y]))
                {
                    txtDVDLeadActor.Text += " "+ recordList[y];
                    y++;
                }
                
                txtDVDReleaseDate.Text = recordList[y];
                y++;
                txtDVDRunTime.Text = recordList[y];
            }
            if (recordList[y] == "BookCIS")
            {
                y++;
                string tempISBNl = recordList[y].Substring(0);
                string tempISBNr = recordList[y].Substring(3);
                txtBookISBNLeft.Text = tempISBNl;
                txtBookISBNRight.Text = tempISBNl;
                while (!Validation.validateIntNumber(recordList[y]) && !Validation.validateIntNumber(recordList[y]))
                {
                    txtBookAuthor.Text += " " + recordList[y];
                    y++;
                }

                txtBookPages.Text = recordList[y];
                txtBookCISCISArea.Text = recordList[y + 1];
            }
            if (recordList[y] == "CDChamber")
            {

            }
            if (recordList[y] == "CDOrchestra")
            {
                
            }




        }


        //Validation calls to validate class shortcuts
        public bool validateproduct()
        {
            return Validation.validateUPC(txtProductUPC.Text) && Validation.validateTitle(txtProductTitle.Text) && Validation.validatePrice(txtProductPrice.Text) && Validation.validateIntNumber(txtProductQuantity.Text);
        }
        public bool validateBook()
        {
            return validateproduct() && Validation.validateISBN(txtBookISBNLeft.Text) && Validation.validateISBN(txtBookISBNRight.Text) && Validation.validateName(txtBookAuthor.Text) && Validation.validateIntNumber(txtBookPages.Text);
        }
        public bool validateBookCis()
        {
            return validateproduct() && validateBook() && Validation.validateTitle(txtBookCISCISArea.Text);
        }
        public bool validateDVD()
        {
            return validateproduct() && Validation.validateName(txtDVDLeadActor.Text) && Validation.validateReleaseDate(Convert.ToDateTime(txtDVDReleaseDate.Text)) && Validation.validateRunTime(txtDVDRunTime.Text);
        }
        public bool validateCD()
        {
            return validateproduct() && Validation.validateTitle(txtCDClassicalLabel.Text) && Validation.validateArtists(txtCDClassicalArtists.Text);

        }
        public bool validateCDOrchestra()
        {
            return validateproduct() && validateCD() && Validation.validateName(txtCDOrchestraConductor.Text);
        }
        public bool validateCDChamber()
        {
            return validateproduct() && validateCD() && Validation.validateInstruments(txtCDChamberInstrumentList.Text);
        }
    }
}
