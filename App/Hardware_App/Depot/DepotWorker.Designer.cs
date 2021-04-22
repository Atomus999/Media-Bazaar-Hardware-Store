namespace Hardware_App
{
    partial class Depotworker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depotworker));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNavManageProducts = new XanderUI.XUIButton();
            this.btnNavProdRequests = new XanderUI.XUIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRequests = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAcceptTicket = new XanderUI.XUIButton();
            this.btnRejectTicket = new XanderUI.XUIButton();
            this.dataGridViewDepoTicketReq = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRequests = new System.Windows.Forms.ListBox();
            this.tabStockInfo = new System.Windows.Forms.TabPage();
            this.panelShadowSearch = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.tbSearchProduct = new Hardware_App.CustomTextbox();
            this.btnSearchProduct = new XanderUI.XUIButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelEmpAbsControls = new System.Windows.Forms.Panel();
            this.cbSortProd = new System.Windows.Forms.ComboBox();
            this.btnSortProduct = new XanderUI.XUIButton();
            this.btnDeactivateStock = new XanderUI.XUIButton();
            this.btnRemoveStock = new XanderUI.XUIButton();
            this.btnChangeProductData = new XanderUI.XUIButton();
            this.btnAddStock = new XanderUI.XUIButton();
            this.btnInspectProduct = new XanderUI.XUIButton();
            this.btnViewAllProducts = new XanderUI.XUIButton();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.lbAllStock = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabRequests.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepoTicketReq)).BeginInit();
            this.tabStockInfo.SuspendLayout();
            this.panelShadowSearch.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelEmpAbsControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.btnNavManageProducts);
            this.panel1.Controls.Add(this.btnNavProdRequests);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 511);
            this.panel1.TabIndex = 14;
            // 
            // btnNavManageProducts
            // 
            this.btnNavManageProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnNavManageProducts.ButtonImage = global::Hardware_App.Properties.Resources.box_white;
            this.btnNavManageProducts.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnNavManageProducts.ButtonText = "Manage Products";
            this.btnNavManageProducts.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnNavManageProducts.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNavManageProducts.CornerRadius = 5;
            this.btnNavManageProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavManageProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavManageProducts.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavManageProducts.Horizontal_Alignment = System.Drawing.StringAlignment.Far;
            this.btnNavManageProducts.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnNavManageProducts.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNavManageProducts.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnNavManageProducts.Location = new System.Drawing.Point(0, 109);
            this.btnNavManageProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavManageProducts.Name = "btnNavManageProducts";
            this.btnNavManageProducts.Size = new System.Drawing.Size(204, 44);
            this.btnNavManageProducts.TabIndex = 3;
            this.btnNavManageProducts.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNavManageProducts.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNavManageProducts.Click += new System.EventHandler(this.btnNavManageProducts_Click);
            // 
            // btnNavProdRequests
            // 
            this.btnNavProdRequests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnNavProdRequests.ButtonImage = global::Hardware_App.Properties.Resources.package_white;
            this.btnNavProdRequests.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnNavProdRequests.ButtonText = "Requests";
            this.btnNavProdRequests.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnNavProdRequests.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNavProdRequests.CornerRadius = 5;
            this.btnNavProdRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavProdRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavProdRequests.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavProdRequests.Horizontal_Alignment = System.Drawing.StringAlignment.Far;
            this.btnNavProdRequests.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnNavProdRequests.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNavProdRequests.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnNavProdRequests.Location = new System.Drawing.Point(0, 65);
            this.btnNavProdRequests.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavProdRequests.Name = "btnNavProdRequests";
            this.btnNavProdRequests.Size = new System.Drawing.Size(204, 44);
            this.btnNavProdRequests.TabIndex = 2;
            this.btnNavProdRequests.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnNavProdRequests.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNavProdRequests.Click += new System.EventHandler(this.btnNavProdRequests_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 65);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabRequests);
            this.tabControl1.Controls.Add(this.tabStockInfo);
            this.tabControl1.Location = new System.Drawing.Point(183, -4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 515);
            this.tabControl1.TabIndex = 13;
            // 
            // tabRequests
            // 
            this.tabRequests.Controls.Add(this.panel2);
            this.tabRequests.Controls.Add(this.dataGridViewDepoTicketReq);
            this.tabRequests.Controls.Add(this.label1);
            this.tabRequests.Controls.Add(this.lbRequests);
            this.tabRequests.Location = new System.Drawing.Point(23, 4);
            this.tabRequests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRequests.Name = "tabRequests";
            this.tabRequests.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRequests.Size = new System.Drawing.Size(977, 507);
            this.tabRequests.TabIndex = 0;
            this.tabRequests.Text = "Product requests";
            this.tabRequests.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAcceptTicket);
            this.panel2.Controls.Add(this.btnRejectTicket);
            this.panel2.Location = new System.Drawing.Point(371, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 47);
            this.panel2.TabIndex = 29;
            // 
            // btnAcceptTicket
            // 
            this.btnAcceptTicket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnAcceptTicket.ButtonImage = null;
            this.btnAcceptTicket.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAcceptTicket.ButtonText = "Accept";
            this.btnAcceptTicket.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnAcceptTicket.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAcceptTicket.CornerRadius = 10;
            this.btnAcceptTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceptTicket.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptTicket.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAcceptTicket.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnAcceptTicket.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAcceptTicket.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAcceptTicket.Location = new System.Drawing.Point(160, 6);
            this.btnAcceptTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcceptTicket.Name = "btnAcceptTicket";
            this.btnAcceptTicket.Size = new System.Drawing.Size(97, 37);
            this.btnAcceptTicket.TabIndex = 47;
            this.btnAcceptTicket.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAcceptTicket.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAcceptTicket.Click += new System.EventHandler(this.btnAcceptTicket_Click);
            // 
            // btnRejectTicket
            // 
            this.btnRejectTicket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnRejectTicket.ButtonImage = null;
            this.btnRejectTicket.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnRejectTicket.ButtonText = "Reject";
            this.btnRejectTicket.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnRejectTicket.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnRejectTicket.CornerRadius = 10;
            this.btnRejectTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRejectTicket.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejectTicket.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRejectTicket.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnRejectTicket.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnRejectTicket.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnRejectTicket.Location = new System.Drawing.Point(7, 5);
            this.btnRejectTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnRejectTicket.Name = "btnRejectTicket";
            this.btnRejectTicket.Size = new System.Drawing.Size(97, 37);
            this.btnRejectTicket.TabIndex = 46;
            this.btnRejectTicket.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnRejectTicket.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRejectTicket.Click += new System.EventHandler(this.btnRejectTicket_Click);
            // 
            // dataGridViewDepoTicketReq
            // 
            this.dataGridViewDepoTicketReq.AllowUserToAddRows = false;
            this.dataGridViewDepoTicketReq.AllowUserToDeleteRows = false;
            this.dataGridViewDepoTicketReq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDepoTicketReq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDepoTicketReq.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewDepoTicketReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDepoTicketReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepoTicketReq.Location = new System.Drawing.Point(3, 78);
            this.dataGridViewDepoTicketReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDepoTicketReq.Name = "dataGridViewDepoTicketReq";
            this.dataGridViewDepoTicketReq.ReadOnly = true;
            this.dataGridViewDepoTicketReq.RowHeadersWidth = 51;
            this.dataGridViewDepoTicketReq.RowTemplate.Height = 24;
            this.dataGridViewDepoTicketReq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepoTicketReq.Size = new System.Drawing.Size(978, 429);
            this.dataGridViewDepoTicketReq.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(5, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product requests status";
            // 
            // lbRequests
            // 
            this.lbRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRequests.FormattingEnabled = true;
            this.lbRequests.Location = new System.Drawing.Point(19, 274);
            this.lbRequests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbRequests.Name = "lbRequests";
            this.lbRequests.Size = new System.Drawing.Size(888, 17);
            this.lbRequests.TabIndex = 10;
            // 
            // tabStockInfo
            // 
            this.tabStockInfo.Controls.Add(this.panelShadowSearch);
            this.tabStockInfo.Controls.Add(this.panelEmpAbsControls);
            this.tabStockInfo.Controls.Add(this.dataGridViewProducts);
            this.tabStockInfo.Controls.Add(this.lbAllStock);
            this.tabStockInfo.Location = new System.Drawing.Point(23, 4);
            this.tabStockInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStockInfo.Name = "tabStockInfo";
            this.tabStockInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabStockInfo.Size = new System.Drawing.Size(977, 507);
            this.tabStockInfo.TabIndex = 1;
            this.tabStockInfo.Text = "Stock info";
            this.tabStockInfo.UseVisualStyleBackColor = true;
            // 
            // panelShadowSearch
            // 
            this.panelShadowSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelShadowSearch.Controls.Add(this.panelSearch);
            this.panelShadowSearch.Location = new System.Drawing.Point(91, 2);
            this.panelShadowSearch.Margin = new System.Windows.Forms.Padding(4);
            this.panelShadowSearch.Name = "panelShadowSearch";
            this.panelShadowSearch.Size = new System.Drawing.Size(784, 63);
            this.panelShadowSearch.TabIndex = 53;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.panelSearch.Controls.Add(this.tbSearchProduct);
            this.panelSearch.Controls.Add(this.btnSearchProduct);
            this.panelSearch.Controls.Add(this.label4);
            this.panelSearch.Controls.Add(this.label6);
            this.panelSearch.Controls.Add(this.label5);
            this.panelSearch.Location = new System.Drawing.Point(11, 6);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(760, 49);
            this.panelSearch.TabIndex = 45;
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbSearchProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchProduct.DefaultBorderColor = System.Drawing.SystemColors.ControlDark;
            this.tbSearchProduct.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(165)))));
            this.tbSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchProduct.Location = new System.Drawing.Point(205, 10);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tbSearchProduct.PasswordChar = '\0';
            this.tbSearchProduct.ReadOnly = false;
            this.tbSearchProduct.Size = new System.Drawing.Size(398, 26);
            this.tbSearchProduct.TabIndex = 54;
            this.tbSearchProduct.TextColor = System.Drawing.SystemColors.WindowText;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(40)))), ((int)(((byte)(165)))));
            this.btnSearchProduct.ButtonImage = global::Hardware_App.Properties.Resources.loupe2_white;
            this.btnSearchProduct.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSearchProduct.ButtonText = "Search";
            this.btnSearchProduct.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnSearchProduct.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchProduct.CornerRadius = 10;
            this.btnSearchProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchProduct.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.btnSearchProduct.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnSearchProduct.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchProduct.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSearchProduct.Location = new System.Drawing.Point(627, 7);
            this.btnSearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(113, 37);
            this.btnSearchProduct.TabIndex = 53;
            this.btnSearchProduct.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchProduct.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(16, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(116, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(67, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Or";
            // 
            // panelEmpAbsControls
            // 
            this.panelEmpAbsControls.Controls.Add(this.cbSortProd);
            this.panelEmpAbsControls.Controls.Add(this.btnSortProduct);
            this.panelEmpAbsControls.Controls.Add(this.btnDeactivateStock);
            this.panelEmpAbsControls.Controls.Add(this.btnRemoveStock);
            this.panelEmpAbsControls.Controls.Add(this.btnChangeProductData);
            this.panelEmpAbsControls.Controls.Add(this.btnAddStock);
            this.panelEmpAbsControls.Controls.Add(this.btnInspectProduct);
            this.panelEmpAbsControls.Controls.Add(this.btnViewAllProducts);
            this.panelEmpAbsControls.Location = new System.Drawing.Point(5, 70);
            this.panelEmpAbsControls.Margin = new System.Windows.Forms.Padding(4);
            this.panelEmpAbsControls.Name = "panelEmpAbsControls";
            this.panelEmpAbsControls.Size = new System.Drawing.Size(956, 44);
            this.panelEmpAbsControls.TabIndex = 28;
            // 
            // cbSortProd
            // 
            this.cbSortProd.BackColor = System.Drawing.Color.White;
            this.cbSortProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSortProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cbSortProd.FormattingEnabled = true;
            this.cbSortProd.Items.AddRange(new object[] {
            "Id(ASC)",
            "Name(ASC)",
            "Qty Warehouse(ASC)",
            "Qty Shelf(ASC)"});
            this.cbSortProd.Location = new System.Drawing.Point(635, 13);
            this.cbSortProd.Margin = new System.Windows.Forms.Padding(4);
            this.cbSortProd.Name = "cbSortProd";
            this.cbSortProd.Size = new System.Drawing.Size(205, 28);
            this.cbSortProd.TabIndex = 53;
            // 
            // btnSortProduct
            // 
            this.btnSortProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnSortProduct.ButtonImage = null;
            this.btnSortProduct.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSortProduct.ButtonText = "Sort";
            this.btnSortProduct.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnSortProduct.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSortProduct.CornerRadius = 10;
            this.btnSortProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortProduct.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortProduct.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSortProduct.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnSortProduct.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSortProduct.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSortProduct.Location = new System.Drawing.Point(848, 2);
            this.btnSortProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortProduct.Name = "btnSortProduct";
            this.btnSortProduct.Size = new System.Drawing.Size(92, 37);
            this.btnSortProduct.TabIndex = 52;
            this.btnSortProduct.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSortProduct.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSortProduct.Click += new System.EventHandler(this.btnSortProduct_Click);
            // 
            // btnDeactivateStock
            // 
            this.btnDeactivateStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnDeactivateStock.ButtonImage = null;
            this.btnDeactivateStock.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDeactivateStock.ButtonText = "Deactivate";
            this.btnDeactivateStock.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnDeactivateStock.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeactivateStock.CornerRadius = 10;
            this.btnDeactivateStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeactivateStock.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivateStock.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeactivateStock.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnDeactivateStock.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeactivateStock.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDeactivateStock.Location = new System.Drawing.Point(507, 2);
            this.btnDeactivateStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeactivateStock.Name = "btnDeactivateStock";
            this.btnDeactivateStock.Size = new System.Drawing.Size(120, 37);
            this.btnDeactivateStock.TabIndex = 51;
            this.btnDeactivateStock.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeactivateStock.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDeactivateStock.Click += new System.EventHandler(this.btnDeactivateStock_Click);
            // 
            // btnRemoveStock
            // 
            this.btnRemoveStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnRemoveStock.ButtonImage = null;
            this.btnRemoveStock.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnRemoveStock.ButtonText = "Remove";
            this.btnRemoveStock.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnRemoveStock.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveStock.CornerRadius = 10;
            this.btnRemoveStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveStock.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStock.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRemoveStock.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnRemoveStock.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveStock.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnRemoveStock.Location = new System.Drawing.Point(407, 2);
            this.btnRemoveStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(92, 37);
            this.btnRemoveStock.TabIndex = 50;
            this.btnRemoveStock.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveStock.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRemoveStock.Click += new System.EventHandler(this.btnRemoveStock_Click);
            // 
            // btnChangeProductData
            // 
            this.btnChangeProductData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnChangeProductData.ButtonImage = null;
            this.btnChangeProductData.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnChangeProductData.ButtonText = "Change";
            this.btnChangeProductData.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnChangeProductData.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangeProductData.CornerRadius = 10;
            this.btnChangeProductData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeProductData.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeProductData.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChangeProductData.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnChangeProductData.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangeProductData.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnChangeProductData.Location = new System.Drawing.Point(307, 2);
            this.btnChangeProductData.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeProductData.Name = "btnChangeProductData";
            this.btnChangeProductData.Size = new System.Drawing.Size(92, 37);
            this.btnChangeProductData.TabIndex = 49;
            this.btnChangeProductData.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnChangeProductData.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnChangeProductData.Click += new System.EventHandler(this.btnChangeProductData_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnAddStock.ButtonImage = null;
            this.btnAddStock.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAddStock.ButtonText = "Add";
            this.btnAddStock.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnAddStock.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddStock.CornerRadius = 10;
            this.btnAddStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStock.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddStock.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnAddStock.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddStock.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAddStock.Location = new System.Drawing.Point(207, 2);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(92, 37);
            this.btnAddStock.TabIndex = 48;
            this.btnAddStock.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddStock.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnInspectProduct
            // 
            this.btnInspectProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnInspectProduct.ButtonImage = null;
            this.btnInspectProduct.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnInspectProduct.ButtonText = "Inspect";
            this.btnInspectProduct.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnInspectProduct.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnInspectProduct.CornerRadius = 10;
            this.btnInspectProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInspectProduct.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInspectProduct.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInspectProduct.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnInspectProduct.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnInspectProduct.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnInspectProduct.Location = new System.Drawing.Point(107, 2);
            this.btnInspectProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnInspectProduct.Name = "btnInspectProduct";
            this.btnInspectProduct.Size = new System.Drawing.Size(92, 37);
            this.btnInspectProduct.TabIndex = 47;
            this.btnInspectProduct.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnInspectProduct.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInspectProduct.Click += new System.EventHandler(this.btnInspectProduct_Click);
            // 
            // btnViewAllProducts
            // 
            this.btnViewAllProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnViewAllProducts.ButtonImage = null;
            this.btnViewAllProducts.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnViewAllProducts.ButtonText = "Refresh";
            this.btnViewAllProducts.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnViewAllProducts.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewAllProducts.CornerRadius = 10;
            this.btnViewAllProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewAllProducts.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllProducts.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnViewAllProducts.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnViewAllProducts.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewAllProducts.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnViewAllProducts.Location = new System.Drawing.Point(7, 2);
            this.btnViewAllProducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewAllProducts.Name = "btnViewAllProducts";
            this.btnViewAllProducts.Size = new System.Drawing.Size(92, 37);
            this.btnViewAllProducts.TabIndex = 46;
            this.btnViewAllProducts.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewAllProducts.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnViewAllProducts.Click += new System.EventHandler(this.btnViewAllProducts_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 121);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(992, 390);
            this.dataGridViewProducts.TabIndex = 16;
            // 
            // lbAllStock
            // 
            this.lbAllStock.FormattingEnabled = true;
            this.lbAllStock.HorizontalScrollbar = true;
            this.lbAllStock.Location = new System.Drawing.Point(5, 265);
            this.lbAllStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbAllStock.Name = "lbAllStock";
            this.lbAllStock.Size = new System.Drawing.Size(451, 134);
            this.lbAllStock.TabIndex = 8;
            // 
            // Depotworker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1200, 550);
            this.Name = "Depotworker";
            this.Text = "Depotworker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Depotworker_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabRequests.ResumeLayout(false);
            this.tabRequests.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepoTicketReq)).EndInit();
            this.tabStockInfo.ResumeLayout(false);
            this.panelShadowSearch.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelEmpAbsControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton btnNavManageProducts;
        private XanderUI.XUIButton btnNavProdRequests;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRequests;
        private System.Windows.Forms.Panel panel2;
        private XanderUI.XUIButton btnAcceptTicket;
        private XanderUI.XUIButton btnRejectTicket;
        private System.Windows.Forms.DataGridView dataGridViewDepoTicketReq;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lbRequests;
        private System.Windows.Forms.TabPage tabStockInfo;
        private System.Windows.Forms.Panel panelShadowSearch;
        private System.Windows.Forms.Panel panelSearch;
        private CustomTextbox tbSearchProduct;
        private XanderUI.XUIButton btnSearchProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelEmpAbsControls;
        private System.Windows.Forms.ComboBox cbSortProd;
        private XanderUI.XUIButton btnSortProduct;
        private XanderUI.XUIButton btnDeactivateStock;
        private XanderUI.XUIButton btnRemoveStock;
        private XanderUI.XUIButton btnChangeProductData;
        private XanderUI.XUIButton btnAddStock;
        private XanderUI.XUIButton btnInspectProduct;
        private XanderUI.XUIButton btnViewAllProducts;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.ListBox lbAllStock;
    }
}