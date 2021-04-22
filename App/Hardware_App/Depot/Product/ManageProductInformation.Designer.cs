namespace Hardware_App
{
    partial class ManageProductInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProductInformation));
            this.checkbMakePAvailable = new XanderUI.XUICheckBox();
            this.btnModifyProduct = new XanderUI.XUIButton();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnCreateProduct = new XanderUI.XUIButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelQtyShelf = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbRegEmployees = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datetimeShipmentDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductId = new Hardware_App.CustomTextbox();
            this.tbModel = new Hardware_App.CustomTextbox();
            this.tbBrand = new Hardware_App.CustomTextbox();
            this.tbPrice = new Hardware_App.CustomTextbox();
            this.tbWeight = new Hardware_App.CustomTextbox();
            this.tbHeight = new Hardware_App.CustomTextbox();
            this.tbWidth = new Hardware_App.CustomTextbox();
            this.tbDepth = new Hardware_App.CustomTextbox();
            this.tbName = new Hardware_App.CustomTextbox();
            this.tbBarcode = new Hardware_App.CustomTextbox();
            this.tbProductQtyShelf = new Hardware_App.CustomTextbox();
            this.numAisle = new System.Windows.Forms.NumericUpDown();
            this.numericShelfQty = new System.Windows.Forms.NumericUpDown();
            this.numericWhQty = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numAisle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericShelfQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWhQty)).BeginInit();
            this.SuspendLayout();
            // 
            // checkbMakePAvailable
            // 
            this.checkbMakePAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkbMakePAvailable.CheckboxCheckColor = System.Drawing.Color.WhiteSmoke;
            this.checkbMakePAvailable.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.checkbMakePAvailable.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.checkbMakePAvailable.CheckboxStyle = XanderUI.XUICheckBox.Style.Material;
            this.checkbMakePAvailable.Checked = false;
            this.checkbMakePAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.checkbMakePAvailable.Location = new System.Drawing.Point(331, 375);
            this.checkbMakePAvailable.Name = "checkbMakePAvailable";
            this.checkbMakePAvailable.Size = new System.Drawing.Size(154, 20);
            this.checkbMakePAvailable.TabIndex = 131;
            this.checkbMakePAvailable.Text = "Make product available";
            this.checkbMakePAvailable.TickThickness = 2;
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnModifyProduct.ButtonImage = null;
            this.btnModifyProduct.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnModifyProduct.ButtonText = "Modify";
            this.btnModifyProduct.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnModifyProduct.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnModifyProduct.CornerRadius = 10;
            this.btnModifyProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyProduct.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyProduct.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnModifyProduct.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnModifyProduct.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnModifyProduct.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnModifyProduct.Location = new System.Drawing.Point(458, 531);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(116, 43);
            this.btnModifyProduct.TabIndex = 130;
            this.btnModifyProduct.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnModifyProduct.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.BackColor = System.Drawing.Color.White;
            this.cbCategory.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(331, 26);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(155, 26);
            this.cbCategory.TabIndex = 129;
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnCreateProduct.ButtonImage = null;
            this.btnCreateProduct.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnCreateProduct.ButtonText = "Create";
            this.btnCreateProduct.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnCreateProduct.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateProduct.CornerRadius = 10;
            this.btnCreateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateProduct.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProduct.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCreateProduct.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnCreateProduct.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateProduct.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnCreateProduct.Location = new System.Drawing.Point(330, 531);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(116, 43);
            this.btnCreateProduct.TabIndex = 128;
            this.btnCreateProduct.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateProduct.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label15.Location = new System.Drawing.Point(328, 97);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 14);
            this.label15.TabIndex = 127;
            this.label15.Text = "Barcode";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label13.Location = new System.Drawing.Point(328, 55);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 14);
            this.label13.TabIndex = 126;
            this.label13.Text = "Name";
            // 
            // labelQtyShelf
            // 
            this.labelQtyShelf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelQtyShelf.AutoSize = true;
            this.labelQtyShelf.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtyShelf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.labelQtyShelf.Location = new System.Drawing.Point(170, 340);
            this.labelQtyShelf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQtyShelf.Name = "labelQtyShelf";
            this.labelQtyShelf.Size = new System.Drawing.Size(102, 14);
            this.labelQtyShelf.TabIndex = 124;
            this.labelQtyShelf.Text = "Quantity Shelf";
            // 
            // labelid
            // 
            this.labelid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.labelid.Location = new System.Drawing.Point(17, 11);
            this.labelid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(21, 14);
            this.labelid.TabIndex = 123;
            this.labelid.Text = "Id";
            this.labelid.Visible = false;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label14.Location = new System.Drawing.Point(17, 340);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 14);
            this.label14.TabIndex = 121;
            this.label14.Text = "Quantity Warehouse";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label12.Location = new System.Drawing.Point(328, 156);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 14);
            this.label12.TabIndex = 120;
            this.label12.Text = "Registering employee";
            // 
            // lbRegEmployees
            // 
            this.lbRegEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRegEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbRegEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRegEmployees.Font = new System.Drawing.Font("Verdana Pro Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lbRegEmployees.FormattingEnabled = true;
            this.lbRegEmployees.Location = new System.Drawing.Point(331, 176);
            this.lbRegEmployees.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbRegEmployees.Name = "lbRegEmployees";
            this.lbRegEmployees.Size = new System.Drawing.Size(244, 117);
            this.lbRegEmployees.TabIndex = 119;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label11.Location = new System.Drawing.Point(170, 394);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 14);
            this.label11.TabIndex = 117;
            this.label11.Text = "Aisle number";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label10.Location = new System.Drawing.Point(328, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 14);
            this.label10.TabIndex = 116;
            this.label10.Text = "Category";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label9.Location = new System.Drawing.Point(18, 531);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 14);
            this.label9.TabIndex = 115;
            this.label9.Text = "Depth";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label8.Location = new System.Drawing.Point(18, 485);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 14);
            this.label8.TabIndex = 114;
            this.label8.Text = "Width";
            // 
            // datetimeShipmentDate
            // 
            this.datetimeShipmentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datetimeShipmentDate.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeShipmentDate.Location = new System.Drawing.Point(331, 333);
            this.datetimeShipmentDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.datetimeShipmentDate.Name = "datetimeShipmentDate";
            this.datetimeShipmentDate.Size = new System.Drawing.Size(244, 27);
            this.datetimeShipmentDate.TabIndex = 113;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label7.Location = new System.Drawing.Point(17, 440);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 107;
            this.label7.Text = "Height";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label6.Location = new System.Drawing.Point(17, 394);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 14);
            this.label6.TabIndex = 108;
            this.label6.Text = "Weight";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label5.Location = new System.Drawing.Point(17, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 14);
            this.label5.TabIndex = 109;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label4.Location = new System.Drawing.Point(328, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 14);
            this.label4.TabIndex = 110;
            this.label4.Text = "Shipment Date";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label3.Location = new System.Drawing.Point(17, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 111;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 14);
            this.label2.TabIndex = 112;
            this.label2.Text = "Brand Name";
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.White;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescription.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(20, 204);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(214, 127);
            this.tbDescription.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 105;
            this.label1.Text = "Model";
            // 
            // tbProductId
            // 
            this.tbProductId.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbProductId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbProductId.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbProductId.FocusedBorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbProductId.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductId.Location = new System.Drawing.Point(20, 27);
            this.tbProductId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.Padding = new System.Windows.Forms.Padding(3);
            this.tbProductId.PasswordChar = '\0';
            this.tbProductId.ReadOnly = false;
            this.tbProductId.Size = new System.Drawing.Size(104, 27);
            this.tbProductId.TabIndex = 132;
            this.tbProductId.TextColor = System.Drawing.SystemColors.WindowText;
            this.tbProductId.Visible = false;
            // 
            // tbModel
            // 
            this.tbModel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbModel.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbModel.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.tbModel.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModel.Location = new System.Drawing.Point(20, 72);
            this.tbModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbModel.Name = "tbModel";
            this.tbModel.Padding = new System.Windows.Forms.Padding(3);
            this.tbModel.PasswordChar = '\0';
            this.tbModel.ReadOnly = false;
            this.tbModel.Size = new System.Drawing.Size(155, 27);
            this.tbModel.TabIndex = 133;
            this.tbModel.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // tbBrand
            // 
            this.tbBrand.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBrand.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbBrand.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.tbBrand.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBrand.Location = new System.Drawing.Point(20, 111);
            this.tbBrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Padding = new System.Windows.Forms.Padding(3);
            this.tbBrand.PasswordChar = '\0';
            this.tbBrand.ReadOnly = false;
            this.tbBrand.Size = new System.Drawing.Size(155, 27);
            this.tbBrand.TabIndex = 134;
            this.tbBrand.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.tbPrice.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(20, 157);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Padding = new System.Windows.Forms.Padding(3);
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.ReadOnly = false;
            this.tbPrice.Size = new System.Drawing.Size(104, 27);
            this.tbPrice.TabIndex = 135;
            this.tbPrice.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // tbWeight
            // 
            this.tbWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbWeight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbWeight.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbWeight.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.tbWeight.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWeight.Location = new System.Drawing.Point(20, 411);
            this.tbWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Padding = new System.Windows.Forms.Padding(3);
            this.tbWeight.PasswordChar = '\0';
            this.tbWeight.ReadOnly = false;
            this.tbWeight.Size = new System.Drawing.Size(104, 27);
            this.tbWeight.TabIndex = 136;
            this.tbWeight.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // tbHeight
            // 
            this.tbHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbHeight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHeight.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbHeight.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.tbHeight.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHeight.Location = new System.Drawing.Point(20, 457);
            this.tbHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Padding = new System.Windows.Forms.Padding(3);
            this.tbHeight.PasswordChar = '\0';
            this.tbHeight.ReadOnly = false;
            this.tbHeight.Size = new System.Drawing.Size(104, 27);
            this.tbHeight.TabIndex = 137;
            this.tbHeight.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // tbWidth
            // 
            this.tbWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbWidth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbWidth.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbWidth.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.tbWidth.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWidth.Location = new System.Drawing.Point(20, 502);
            this.tbWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Padding = new System.Windows.Forms.Padding(3);
            this.tbWidth.PasswordChar = '\0';
            this.tbWidth.ReadOnly = false;
            this.tbWidth.Size = new System.Drawing.Size(104, 27);
            this.tbWidth.TabIndex = 138;
            this.tbWidth.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // tbDepth
            // 
            this.tbDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDepth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbDepth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDepth.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbDepth.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.tbDepth.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDepth.Location = new System.Drawing.Point(20, 548);
            this.tbDepth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Padding = new System.Windows.Forms.Padding(3);
            this.tbDepth.PasswordChar = '\0';
            this.tbDepth.ReadOnly = false;
            this.tbDepth.Size = new System.Drawing.Size(104, 27);
            this.tbDepth.TabIndex = 139;
            this.tbDepth.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.tbName.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(330, 72);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Padding = new System.Windows.Forms.Padding(3);
            this.tbName.PasswordChar = '\0';
            this.tbName.ReadOnly = false;
            this.tbName.Size = new System.Drawing.Size(154, 27);
            this.tbName.TabIndex = 140;
            this.tbName.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // tbBarcode
            // 
            this.tbBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBarcode.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBarcode.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbBarcode.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.tbBarcode.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBarcode.Location = new System.Drawing.Point(330, 114);
            this.tbBarcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Padding = new System.Windows.Forms.Padding(3);
            this.tbBarcode.PasswordChar = '\0';
            this.tbBarcode.ReadOnly = false;
            this.tbBarcode.Size = new System.Drawing.Size(154, 27);
            this.tbBarcode.TabIndex = 141;
            this.tbBarcode.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // tbProductQtyShelf
            // 
            this.tbProductQtyShelf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbProductQtyShelf.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbProductQtyShelf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbProductQtyShelf.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbProductQtyShelf.FocusedBorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbProductQtyShelf.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductQtyShelf.Location = new System.Drawing.Point(188, 360);
            this.tbProductQtyShelf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbProductQtyShelf.Name = "tbProductQtyShelf";
            this.tbProductQtyShelf.Padding = new System.Windows.Forms.Padding(3);
            this.tbProductQtyShelf.PasswordChar = '\0';
            this.tbProductQtyShelf.ReadOnly = false;
            this.tbProductQtyShelf.Size = new System.Drawing.Size(104, 27);
            this.tbProductQtyShelf.TabIndex = 142;
            this.tbProductQtyShelf.TextColor = System.Drawing.SystemColors.WindowText;
            this.tbProductQtyShelf.Visible = false;
            // 
            // numAisle
            // 
            this.numAisle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numAisle.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAisle.Location = new System.Drawing.Point(172, 411);
            this.numAisle.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.numAisle.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numAisle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAisle.Name = "numAisle";
            this.numAisle.Size = new System.Drawing.Size(88, 27);
            this.numAisle.TabIndex = 118;
            this.numAisle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericShelfQty
            // 
            this.numericShelfQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericShelfQty.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericShelfQty.Location = new System.Drawing.Point(172, 360);
            this.numericShelfQty.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.numericShelfQty.Name = "numericShelfQty";
            this.numericShelfQty.Size = new System.Drawing.Size(88, 27);
            this.numericShelfQty.TabIndex = 125;
            // 
            // numericWhQty
            // 
            this.numericWhQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericWhQty.Font = new System.Drawing.Font("Verdana Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericWhQty.Location = new System.Drawing.Point(20, 360);
            this.numericWhQty.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.numericWhQty.Name = "numericWhQty";
            this.numericWhQty.Size = new System.Drawing.Size(88, 27);
            this.numericWhQty.TabIndex = 122;
            // 
            // ManageProductInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 588);
            this.Controls.Add(this.tbProductQtyShelf);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbDepth);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbProductId);
            this.Controls.Add(this.checkbMakePAvailable);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numericShelfQty);
            this.Controls.Add(this.labelQtyShelf);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.numericWhQty);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbRegEmployees);
            this.Controls.Add(this.numAisle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datetimeShipmentDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(623, 507);
            this.Name = "ManageProductInformation";
            this.Text = "ManageProductInformation";
            ((System.ComponentModel.ISupportInitialize)(this.numAisle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericShelfQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWhQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICheckBox checkbMakePAvailable;
        private XanderUI.XUIButton btnModifyProduct;
        private System.Windows.Forms.ComboBox cbCategory;
        private XanderUI.XUIButton btnCreateProduct;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelQtyShelf;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lbRegEmployees;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datetimeShipmentDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label1;
        private CustomTextbox tbProductId;
        private CustomTextbox tbModel;
        private CustomTextbox tbBrand;
        private CustomTextbox tbPrice;
        private CustomTextbox tbWeight;
        private CustomTextbox tbHeight;
        private CustomTextbox tbWidth;
        private CustomTextbox tbDepth;
        private CustomTextbox tbName;
        private CustomTextbox tbBarcode;
        private CustomTextbox tbProductQtyShelf;
        private System.Windows.Forms.NumericUpDown numAisle;
        private System.Windows.Forms.NumericUpDown numericShelfQty;
        private System.Windows.Forms.NumericUpDown numericWhQty;
    }
}