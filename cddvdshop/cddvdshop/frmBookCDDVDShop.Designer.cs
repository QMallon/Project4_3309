namespace cddvdshop
{
    partial class frmBookCDDVDShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.btnSaveEditUpdate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEnterUPC = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreateBookCIS = new System.Windows.Forms.Button();
            this.btnCreateDVD = new System.Windows.Forms.Button();
            this.btnCreateCDOrchestra = new System.Windows.Forms.Button();
            this.btnCreateCDChamber = new System.Windows.Forms.Button();
            this.txtProductUPC = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductTitle = new System.Windows.Forms.TextBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtBookISBNLeft = new System.Windows.Forms.TextBox();
            this.txtBookISBNRight = new System.Windows.Forms.TextBox();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookPages = new System.Windows.Forms.TextBox();
            this.txtBookCISCISArea = new System.Windows.Forms.TextBox();
            this.txtDVDLeadActor = new System.Windows.Forms.TextBox();
            this.txtDVDReleaseDate = new System.Windows.Forms.TextBox();
            this.txtDVDRunTime = new System.Windows.Forms.TextBox();
            this.txtCDOrchestraConductor = new System.Windows.Forms.TextBox();
            this.grpProduct = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblUPC = new System.Windows.Forms.Label();
            this.grpBook = new System.Windows.Forms.Panel();
            this.grpDVD = new System.Windows.Forms.Panel();
            this.grpBookCIS = new System.Windows.Forms.Panel();
            this.grpCDOrchestra = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grpCDChamber = new System.Windows.Forms.Panel();
            this.txtCDChamberInstrumentList = new System.Windows.Forms.TextBox();
            this.grpCDClassical = new System.Windows.Forms.Panel();
            this.txtCDClassicalArtists = new System.Windows.Forms.TextBox();
            this.txtCDClassicalLabel = new System.Windows.Forms.TextBox();
            this.grpProdu = new System.Windows.Forms.Panel();
            this.grpProduct.SuspendLayout();
            this.grpBook.SuspendLayout();
            this.grpDVD.SuspendLayout();
            this.grpBookCIS.SuspendLayout();
            this.grpCDOrchestra.SuspendLayout();
            this.panel6.SuspendLayout();
            this.grpCDChamber.SuspendLayout();
            this.grpCDClassical.SuspendLayout();
            this.grpProdu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(89, 74);
            this.btnCreateBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(141, 23);
            this.btnCreateBook.TabIndex = 0;
            this.btnCreateBook.Text = "Create Book";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // btnSaveEditUpdate
            // 
            this.btnSaveEditUpdate.Location = new System.Drawing.Point(677, 34);
            this.btnSaveEditUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveEditUpdate.Name = "btnSaveEditUpdate";
            this.btnSaveEditUpdate.Size = new System.Drawing.Size(97, 23);
            this.btnSaveEditUpdate.TabIndex = 1;
            this.btnSaveEditUpdate.Text = "SAVE UPDATES";
            this.btnSaveEditUpdate.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(473, 34);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "EDIT/UPDATE";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(267, 34);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(121, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "FIND/DISPLAY";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnEnterUPC
            // 
            this.btnEnterUPC.Location = new System.Drawing.Point(71, 34);
            this.btnEnterUPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnterUPC.Name = "btnEnterUPC";
            this.btnEnterUPC.Size = new System.Drawing.Size(107, 23);
            this.btnEnterUPC.TabIndex = 4;
            this.btnEnterUPC.Text = "ENTER UPC";
            this.btnEnterUPC.UseVisualStyleBackColor = true;
            this.btnEnterUPC.Click += new System.EventHandler(this.btnEnterUPC_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(864, 34);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1188, 171);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 71);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1188, 361);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 70);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreateBookCIS
            // 
            this.btnCreateBookCIS.Location = new System.Drawing.Point(285, 74);
            this.btnCreateBookCIS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateBookCIS.Name = "btnCreateBookCIS";
            this.btnCreateBookCIS.Size = new System.Drawing.Size(141, 23);
            this.btnCreateBookCIS.TabIndex = 8;
            this.btnCreateBookCIS.Text = "Create CIS Book";
            this.btnCreateBookCIS.UseVisualStyleBackColor = true;
            this.btnCreateBookCIS.Click += new System.EventHandler(this.btnCreateBookCIS_Click);
            // 
            // btnCreateDVD
            // 
            this.btnCreateDVD.Location = new System.Drawing.Point(479, 74);
            this.btnCreateDVD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateDVD.Name = "btnCreateDVD";
            this.btnCreateDVD.Size = new System.Drawing.Size(141, 23);
            this.btnCreateDVD.TabIndex = 9;
            this.btnCreateDVD.Text = "Create DVD";
            this.btnCreateDVD.UseVisualStyleBackColor = true;
            this.btnCreateDVD.Click += new System.EventHandler(this.btnCreateDVD_Click);
            // 
            // btnCreateCDOrchestra
            // 
            this.btnCreateCDOrchestra.Location = new System.Drawing.Point(696, 74);
            this.btnCreateCDOrchestra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateCDOrchestra.Name = "btnCreateCDOrchestra";
            this.btnCreateCDOrchestra.Size = new System.Drawing.Size(163, 23);
            this.btnCreateCDOrchestra.TabIndex = 10;
            this.btnCreateCDOrchestra.Text = "Create CD Orchestra";
            this.btnCreateCDOrchestra.UseVisualStyleBackColor = true;
            this.btnCreateCDOrchestra.Click += new System.EventHandler(this.btnCreateCDOrchestra_Click);
            // 
            // btnCreateCDChamber
            // 
            this.btnCreateCDChamber.Location = new System.Drawing.Point(903, 74);
            this.btnCreateCDChamber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateCDChamber.Name = "btnCreateCDChamber";
            this.btnCreateCDChamber.Size = new System.Drawing.Size(168, 23);
            this.btnCreateCDChamber.TabIndex = 11;
            this.btnCreateCDChamber.Text = "Create CD Chamber";
            this.btnCreateCDChamber.UseVisualStyleBackColor = true;
            // 
            // txtProductUPC
            // 
            this.txtProductUPC.Location = new System.Drawing.Point(100, 39);
            this.txtProductUPC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductUPC.Name = "txtProductUPC";
            this.txtProductUPC.Size = new System.Drawing.Size(100, 22);
            this.txtProductUPC.TabIndex = 12;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(341, 39);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 22);
            this.txtProductPrice.TabIndex = 13;
            // 
            // txtProductTitle
            // 
            this.txtProductTitle.Location = new System.Drawing.Point(577, 39);
            this.txtProductTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductTitle.Name = "txtProductTitle";
            this.txtProductTitle.Size = new System.Drawing.Size(100, 22);
            this.txtProductTitle.TabIndex = 14;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(839, 39);
            this.txtProductQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtProductQuantity.TabIndex = 15;
            // 
            // txtBookISBNLeft
            // 
            this.txtBookISBNLeft.Location = new System.Drawing.Point(45, 23);
            this.txtBookISBNLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookISBNLeft.Name = "txtBookISBNLeft";
            this.txtBookISBNLeft.Size = new System.Drawing.Size(100, 22);
            this.txtBookISBNLeft.TabIndex = 16;
            // 
            // txtBookISBNRight
            // 
            this.txtBookISBNRight.Location = new System.Drawing.Point(279, 23);
            this.txtBookISBNRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookISBNRight.Name = "txtBookISBNRight";
            this.txtBookISBNRight.Size = new System.Drawing.Size(100, 22);
            this.txtBookISBNRight.TabIndex = 17;
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(512, 23);
            this.txtBookAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(191, 22);
            this.txtBookAuthor.TabIndex = 18;
            // 
            // txtBookPages
            // 
            this.txtBookPages.Location = new System.Drawing.Point(836, 23);
            this.txtBookPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookPages.Name = "txtBookPages";
            this.txtBookPages.Size = new System.Drawing.Size(100, 22);
            this.txtBookPages.TabIndex = 19;
            // 
            // txtBookCISCISArea
            // 
            this.txtBookCISCISArea.Location = new System.Drawing.Point(341, 33);
            this.txtBookCISCISArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookCISCISArea.Name = "txtBookCISCISArea";
            this.txtBookCISCISArea.Size = new System.Drawing.Size(244, 22);
            this.txtBookCISCISArea.TabIndex = 20;
            this.txtBookCISCISArea.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtDVDLeadActor
            // 
            this.txtDVDLeadActor.Location = new System.Drawing.Point(61, 34);
            this.txtDVDLeadActor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDVDLeadActor.Name = "txtDVDLeadActor";
            this.txtDVDLeadActor.Size = new System.Drawing.Size(196, 22);
            this.txtDVDLeadActor.TabIndex = 21;
            // 
            // txtDVDReleaseDate
            // 
            this.txtDVDReleaseDate.Location = new System.Drawing.Point(500, 34);
            this.txtDVDReleaseDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDVDReleaseDate.Name = "txtDVDReleaseDate";
            this.txtDVDReleaseDate.Size = new System.Drawing.Size(100, 22);
            this.txtDVDReleaseDate.TabIndex = 22;
            // 
            // txtDVDRunTime
            // 
            this.txtDVDRunTime.Location = new System.Drawing.Point(843, 34);
            this.txtDVDRunTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDVDRunTime.Name = "txtDVDRunTime";
            this.txtDVDRunTime.Size = new System.Drawing.Size(100, 22);
            this.txtDVDRunTime.TabIndex = 23;
            // 
            // txtCDOrchestraConductor
            // 
            this.txtCDOrchestraConductor.Location = new System.Drawing.Point(109, 26);
            this.txtCDOrchestraConductor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCDOrchestraConductor.Name = "txtCDOrchestraConductor";
            this.txtCDOrchestraConductor.Size = new System.Drawing.Size(209, 22);
            this.txtCDOrchestraConductor.TabIndex = 24;
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.lblQuantity);
            this.grpProduct.Controls.Add(this.lblTitle);
            this.grpProduct.Controls.Add(this.lblPrice);
            this.grpProduct.Controls.Add(this.lblUPC);
            this.grpProduct.Controls.Add(this.txtProductTitle);
            this.grpProduct.Controls.Add(this.txtProductUPC);
            this.grpProduct.Controls.Add(this.txtProductPrice);
            this.grpProduct.Controls.Add(this.txtProductQuantity);
            this.grpProduct.Location = new System.Drawing.Point(45, 18);
            this.grpProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(984, 84);
            this.grpProduct.TabIndex = 25;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(728, 39);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(492, 39);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Title";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(251, 39);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price";
            // 
            // lblUPC
            // 
            this.lblUPC.AutoSize = true;
            this.lblUPC.Location = new System.Drawing.Point(12, 39);
            this.lblUPC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUPC.Name = "lblUPC";
            this.lblUPC.Size = new System.Drawing.Size(36, 17);
            this.lblUPC.TabIndex = 16;
            this.lblUPC.Text = "UPC";
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.txtBookISBNLeft);
            this.grpBook.Controls.Add(this.txtBookISBNRight);
            this.grpBook.Controls.Add(this.txtBookAuthor);
            this.grpBook.Controls.Add(this.txtBookPages);
            this.grpBook.Location = new System.Drawing.Point(45, 118);
            this.grpBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(984, 74);
            this.grpBook.TabIndex = 16;
            // 
            // grpDVD
            // 
            this.grpDVD.Controls.Add(this.txtDVDLeadActor);
            this.grpDVD.Controls.Add(this.txtDVDReleaseDate);
            this.grpDVD.Controls.Add(this.txtDVDRunTime);
            this.grpDVD.Location = new System.Drawing.Point(45, 290);
            this.grpDVD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDVD.Name = "grpDVD";
            this.grpDVD.Size = new System.Drawing.Size(984, 100);
            this.grpDVD.TabIndex = 20;
            // 
            // grpBookCIS
            // 
            this.grpBookCIS.Controls.Add(this.txtBookCISCISArea);
            this.grpBookCIS.Location = new System.Drawing.Point(45, 204);
            this.grpBookCIS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBookCIS.Name = "grpBookCIS";
            this.grpBookCIS.Size = new System.Drawing.Size(984, 82);
            this.grpBookCIS.TabIndex = 0;
            // 
            // grpCDOrchestra
            // 
            this.grpCDOrchestra.Controls.Add(this.txtCDOrchestraConductor);
            this.grpCDOrchestra.Location = new System.Drawing.Point(45, 459);
            this.grpCDOrchestra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCDOrchestra.Name = "grpCDOrchestra";
            this.grpCDOrchestra.Size = new System.Drawing.Size(359, 76);
            this.grpCDOrchestra.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnEnterUPC);
            this.panel6.Controls.Add(this.btnSaveEditUpdate);
            this.panel6.Controls.Add(this.btnEdit);
            this.panel6.Controls.Add(this.btnFind);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Location = new System.Drawing.Point(39, 672);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1043, 73);
            this.panel6.TabIndex = 27;
            // 
            // grpCDChamber
            // 
            this.grpCDChamber.Controls.Add(this.txtCDChamberInstrumentList);
            this.grpCDChamber.Location = new System.Drawing.Point(637, 459);
            this.grpCDChamber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCDChamber.Name = "grpCDChamber";
            this.grpCDChamber.Size = new System.Drawing.Size(392, 76);
            this.grpCDChamber.TabIndex = 27;
            // 
            // txtCDChamberInstrumentList
            // 
            this.txtCDChamberInstrumentList.Location = new System.Drawing.Point(109, 26);
            this.txtCDChamberInstrumentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCDChamberInstrumentList.Name = "txtCDChamberInstrumentList";
            this.txtCDChamberInstrumentList.Size = new System.Drawing.Size(209, 22);
            this.txtCDChamberInstrumentList.TabIndex = 24;
            // 
            // grpCDClassical
            // 
            this.grpCDClassical.Controls.Add(this.txtCDClassicalArtists);
            this.grpCDClassical.Controls.Add(this.txtCDClassicalLabel);
            this.grpCDClassical.Location = new System.Drawing.Point(45, 396);
            this.grpCDClassical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCDClassical.Name = "grpCDClassical";
            this.grpCDClassical.Size = new System.Drawing.Size(984, 53);
            this.grpCDClassical.TabIndex = 28;
            // 
            // txtCDClassicalArtists
            // 
            this.txtCDClassicalArtists.Location = new System.Drawing.Point(744, 14);
            this.txtCDClassicalArtists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCDClassicalArtists.Name = "txtCDClassicalArtists";
            this.txtCDClassicalArtists.Size = new System.Drawing.Size(209, 22);
            this.txtCDClassicalArtists.TabIndex = 26;
            // 
            // txtCDClassicalLabel
            // 
            this.txtCDClassicalLabel.Location = new System.Drawing.Point(148, 14);
            this.txtCDClassicalLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCDClassicalLabel.Name = "txtCDClassicalLabel";
            this.txtCDClassicalLabel.Size = new System.Drawing.Size(209, 22);
            this.txtCDClassicalLabel.TabIndex = 25;
            // 
            // grpProdu
            // 
            this.grpProdu.Controls.Add(this.grpProduct);
            this.grpProdu.Controls.Add(this.grpCDClassical);
            this.grpProdu.Controls.Add(this.grpBook);
            this.grpProdu.Controls.Add(this.grpCDChamber);
            this.grpProdu.Controls.Add(this.grpBookCIS);
            this.grpProdu.Controls.Add(this.grpDVD);
            this.grpProdu.Controls.Add(this.grpCDOrchestra);
            this.grpProdu.Location = new System.Drawing.Point(39, 112);
            this.grpProdu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProdu.Name = "grpProdu";
            this.grpProdu.Size = new System.Drawing.Size(1043, 554);
            this.grpProdu.TabIndex = 26;
            // 
            // frmBookCDDVDShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 757);
            this.Controls.Add(this.grpProdu);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnCreateCDChamber);
            this.Controls.Add(this.btnCreateCDOrchestra);
            this.Controls.Add(this.btnCreateDVD);
            this.Controls.Add(this.btnCreateBookCIS);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreateBook);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBookCDDVDShop";
            this.Text = "frmBookCDDVDShop";
            this.Load += new System.EventHandler(this.frmBookCDDVDShop_Load);
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpDVD.ResumeLayout(false);
            this.grpDVD.PerformLayout();
            this.grpBookCIS.ResumeLayout(false);
            this.grpBookCIS.PerformLayout();
            this.grpCDOrchestra.ResumeLayout(false);
            this.grpCDOrchestra.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.grpCDChamber.ResumeLayout(false);
            this.grpCDChamber.PerformLayout();
            this.grpCDClassical.ResumeLayout(false);
            this.grpCDClassical.PerformLayout();
            this.grpProdu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel grpProdu;
        internal System.Windows.Forms.Button btnCreateBook;
        internal System.Windows.Forms.Button btnSaveEditUpdate;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnFind;
        internal System.Windows.Forms.Button btnEnterUPC;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnCreateBookCIS;
        internal System.Windows.Forms.Button btnCreateDVD;
        internal System.Windows.Forms.Button btnCreateCDOrchestra;
        internal System.Windows.Forms.Button btnCreateCDChamber;
        internal System.Windows.Forms.TextBox txtProductQuantity;
        internal System.Windows.Forms.Panel grpProduct;
        internal System.Windows.Forms.Panel grpBook;
        internal System.Windows.Forms.Panel grpDVD;
        internal System.Windows.Forms.Panel grpBookCIS;
        internal System.Windows.Forms.Panel grpCDOrchestra;
        internal System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Panel grpCDChamber;
        internal System.Windows.Forms.Panel grpCDClassical;
        internal System.Windows.Forms.TextBox txtProductUPC;
        internal System.Windows.Forms.TextBox txtProductPrice;
        internal System.Windows.Forms.TextBox txtProductTitle;
        internal System.Windows.Forms.TextBox txtBookISBNLeft;
        internal System.Windows.Forms.TextBox txtBookISBNRight;
        internal System.Windows.Forms.TextBox txtBookAuthor;
        internal System.Windows.Forms.TextBox txtBookPages;
        internal System.Windows.Forms.TextBox txtBookCISCISArea;
        internal System.Windows.Forms.TextBox txtDVDLeadActor;
        internal System.Windows.Forms.TextBox txtDVDReleaseDate;
        internal System.Windows.Forms.TextBox txtDVDRunTime;
        internal System.Windows.Forms.TextBox txtCDOrchestraConductor;
        internal System.Windows.Forms.TextBox txtCDChamberInstrumentList;
        internal System.Windows.Forms.TextBox txtCDClassicalArtists;
        internal System.Windows.Forms.TextBox txtCDClassicalLabel;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblUPC;
    }
}