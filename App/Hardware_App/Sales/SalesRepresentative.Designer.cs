namespace Hardware_App
{
    partial class SalesRepresentative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesRepresentative));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelShadowRequestProduct = new System.Windows.Forms.Panel();
            this.panelRequestProduct = new System.Windows.Forms.Panel();
            this.btnSubmitTicket = new XanderUI.XUIButton();
            this.cbProductBarcode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panelShadowRequestsControls = new System.Windows.Forms.Panel();
            this.panelRequestsControls = new System.Windows.Forms.Panel();
            this.bt_generateBarcode = new XanderUI.XUIButton();
            this.btnClearTickets = new XanderUI.XUIButton();
            this.btnConfirmDelivery = new XanderUI.XUIButton();
            this.btnReject = new XanderUI.XUIButton();
            this.btnUpdateRequests = new XanderUI.XUIButton();
            this.dataGridViewSalesTicketReq = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTicketStatus = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelShadowTicketLog = new System.Windows.Forms.Panel();
            this.panelTicketLog = new System.Windows.Forms.Panel();
            this.btnViewPastTickets = new XanderUI.XUIButton();
            this.dataGridViewSalesPastTicketReq = new System.Windows.Forms.DataGridView();
            this.lbPastTickets = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNavManageProducts = new XanderUI.XUIButton();
            this.btnNavProdRequests = new XanderUI.XUIButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelShadowRequestProduct.SuspendLayout();
            this.panelRequestProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.panelShadowRequestsControls.SuspendLayout();
            this.panelRequestsControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesTicketReq)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelShadowTicketLog.SuspendLayout();
            this.panelTicketLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesPastTicketReq)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(178, -5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 508);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelShadowRequestProduct);
            this.tabPage1.Controls.Add(this.panelShadowRequestsControls);
            this.tabPage1.Controls.Add(this.dataGridViewSalesTicketReq);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbTicketStatus);
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Size = new System.Drawing.Size(907, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Make a ticket";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelShadowRequestProduct
            // 
            this.panelShadowRequestProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelShadowRequestProduct.Controls.Add(this.panelRequestProduct);
            this.panelShadowRequestProduct.Location = new System.Drawing.Point(3, 70);
            this.panelShadowRequestProduct.Margin = new System.Windows.Forms.Padding(4);
            this.panelShadowRequestProduct.Name = "panelShadowRequestProduct";
            this.panelShadowRequestProduct.Size = new System.Drawing.Size(235, 162);
            this.panelShadowRequestProduct.TabIndex = 55;
            // 
            // panelRequestProduct
            // 
            this.panelRequestProduct.BackColor = System.Drawing.Color.White;
            this.panelRequestProduct.Controls.Add(this.btnSubmitTicket);
            this.panelRequestProduct.Controls.Add(this.cbProductBarcode);
            this.panelRequestProduct.Controls.Add(this.label3);
            this.panelRequestProduct.Controls.Add(this.numQuantity);
            this.panelRequestProduct.Controls.Add(this.label4);
            this.panelRequestProduct.Location = new System.Drawing.Point(8, 7);
            this.panelRequestProduct.Margin = new System.Windows.Forms.Padding(4);
            this.panelRequestProduct.Name = "panelRequestProduct";
            this.panelRequestProduct.Size = new System.Drawing.Size(219, 148);
            this.panelRequestProduct.TabIndex = 45;
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnSubmitTicket.ButtonImage = null;
            this.btnSubmitTicket.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSubmitTicket.ButtonText = "Submit";
            this.btnSubmitTicket.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnSubmitTicket.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitTicket.CornerRadius = 10;
            this.btnSubmitTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitTicket.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitTicket.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSubmitTicket.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnSubmitTicket.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitTicket.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSubmitTicket.Location = new System.Drawing.Point(6, 108);
            this.btnSubmitTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(92, 37);
            this.btnSubmitTicket.TabIndex = 58;
            this.btnSubmitTicket.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitTicket.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSubmitTicket.Click += new System.EventHandler(this.btnSubmitTicket_Click);
            // 
            // cbProductBarcode
            // 
            this.cbProductBarcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProductBarcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProductBarcode.BackColor = System.Drawing.Color.White;
            this.cbProductBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cbProductBarcode.FormattingEnabled = true;
            this.cbProductBarcode.Items.AddRange(new object[] {
            "Id(ASC)",
            "Name(ASC)",
            "Qty Warehouse(ASC)",
            "Qty Shelf(ASC)"});
            this.cbProductBarcode.Location = new System.Drawing.Point(6, 34);
            this.cbProductBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.cbProductBarcode.Name = "cbProductBarcode";
            this.cbProductBarcode.Size = new System.Drawing.Size(205, 28);
            this.cbProductBarcode.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label3.Location = new System.Drawing.Point(4, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "Barcode of product";
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantity.Location = new System.Drawing.Point(6, 79);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(103, 26);
            this.numQuantity.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 24;
            this.label4.Text = "Quantity";
            // 
            // panelShadowRequestsControls
            // 
            this.panelShadowRequestsControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelShadowRequestsControls.Controls.Add(this.panelRequestsControls);
            this.panelShadowRequestsControls.Location = new System.Drawing.Point(58, 2);
            this.panelShadowRequestsControls.Margin = new System.Windows.Forms.Padding(4);
            this.panelShadowRequestsControls.Name = "panelShadowRequestsControls";
            this.panelShadowRequestsControls.Size = new System.Drawing.Size(776, 63);
            this.panelShadowRequestsControls.TabIndex = 54;
            // 
            // panelRequestsControls
            // 
            this.panelRequestsControls.BackColor = System.Drawing.Color.White;
            this.panelRequestsControls.Controls.Add(this.bt_generateBarcode);
            this.panelRequestsControls.Controls.Add(this.btnClearTickets);
            this.panelRequestsControls.Controls.Add(this.btnConfirmDelivery);
            this.panelRequestsControls.Controls.Add(this.btnReject);
            this.panelRequestsControls.Controls.Add(this.btnUpdateRequests);
            this.panelRequestsControls.Location = new System.Drawing.Point(8, 7);
            this.panelRequestsControls.Margin = new System.Windows.Forms.Padding(4);
            this.panelRequestsControls.Name = "panelRequestsControls";
            this.panelRequestsControls.Size = new System.Drawing.Size(760, 49);
            this.panelRequestsControls.TabIndex = 45;
            // 
            // bt_generateBarcode
            // 
            this.bt_generateBarcode.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.bt_generateBarcode.ButtonImage = null;
            this.bt_generateBarcode.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.bt_generateBarcode.ButtonText = "Generate Barcode";
            this.bt_generateBarcode.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.bt_generateBarcode.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.bt_generateBarcode.CornerRadius = 10;
            this.bt_generateBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_generateBarcode.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_generateBarcode.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.bt_generateBarcode.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.bt_generateBarcode.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.bt_generateBarcode.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.bt_generateBarcode.Location = new System.Drawing.Point(540, 8);
            this.bt_generateBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.bt_generateBarcode.Name = "bt_generateBarcode";
            this.bt_generateBarcode.Size = new System.Drawing.Size(92, 37);
            this.bt_generateBarcode.TabIndex = 59;
            this.bt_generateBarcode.TextColor = System.Drawing.Color.WhiteSmoke;
            this.bt_generateBarcode.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.bt_generateBarcode.Click += new System.EventHandler(this.bt_generateBarcode_Click);
            // 
            // btnClearTickets
            // 
            this.btnClearTickets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnClearTickets.ButtonImage = null;
            this.btnClearTickets.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnClearTickets.ButtonText = "Clear all";
            this.btnClearTickets.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnClearTickets.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnClearTickets.CornerRadius = 10;
            this.btnClearTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearTickets.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTickets.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnClearTickets.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnClearTickets.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnClearTickets.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnClearTickets.Location = new System.Drawing.Point(440, 8);
            this.btnClearTickets.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearTickets.Name = "btnClearTickets";
            this.btnClearTickets.Size = new System.Drawing.Size(92, 37);
            this.btnClearTickets.TabIndex = 58;
            this.btnClearTickets.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnClearTickets.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnClearTickets.Click += new System.EventHandler(this.BtnClearTickets_Click);
            // 
            // btnConfirmDelivery
            // 
            this.btnConfirmDelivery.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnConfirmDelivery.ButtonImage = null;
            this.btnConfirmDelivery.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnConfirmDelivery.ButtonText = "Confirm";
            this.btnConfirmDelivery.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnConfirmDelivery.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmDelivery.CornerRadius = 10;
            this.btnConfirmDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmDelivery.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmDelivery.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConfirmDelivery.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnConfirmDelivery.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmDelivery.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnConfirmDelivery.Location = new System.Drawing.Point(340, 8);
            this.btnConfirmDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmDelivery.Name = "btnConfirmDelivery";
            this.btnConfirmDelivery.Size = new System.Drawing.Size(92, 37);
            this.btnConfirmDelivery.TabIndex = 57;
            this.btnConfirmDelivery.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmDelivery.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnConfirmDelivery.Click += new System.EventHandler(this.btnConfirmDelivery_Click);
            // 
            // btnReject
            // 
            this.btnReject.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnReject.ButtonImage = null;
            this.btnReject.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnReject.ButtonText = "Reject";
            this.btnReject.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnReject.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnReject.CornerRadius = 10;
            this.btnReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReject.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReject.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnReject.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnReject.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnReject.Location = new System.Drawing.Point(241, 8);
            this.btnReject.Margin = new System.Windows.Forms.Padding(4);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(92, 37);
            this.btnReject.TabIndex = 56;
            this.btnReject.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnReject.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnUpdateRequests
            // 
            this.btnUpdateRequests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnUpdateRequests.ButtonImage = null;
            this.btnUpdateRequests.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnUpdateRequests.ButtonText = "Refresh";
            this.btnUpdateRequests.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnUpdateRequests.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateRequests.CornerRadius = 10;
            this.btnUpdateRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateRequests.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRequests.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdateRequests.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnUpdateRequests.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateRequests.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnUpdateRequests.Location = new System.Drawing.Point(141, 8);
            this.btnUpdateRequests.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateRequests.Name = "btnUpdateRequests";
            this.btnUpdateRequests.Size = new System.Drawing.Size(92, 37);
            this.btnUpdateRequests.TabIndex = 54;
            this.btnUpdateRequests.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateRequests.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUpdateRequests.Click += new System.EventHandler(this.btnUpdateRequests_Click);
            // 
            // dataGridViewSalesTicketReq
            // 
            this.dataGridViewSalesTicketReq.AllowUserToAddRows = false;
            this.dataGridViewSalesTicketReq.AllowUserToDeleteRows = false;
            this.dataGridViewSalesTicketReq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSalesTicketReq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSalesTicketReq.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSalesTicketReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSalesTicketReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesTicketReq.Location = new System.Drawing.Point(239, 70);
            this.dataGridViewSalesTicketReq.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewSalesTicketReq.Name = "dataGridViewSalesTicketReq";
            this.dataGridViewSalesTicketReq.ReadOnly = true;
            this.dataGridViewSalesTicketReq.RowHeadersWidth = 51;
            this.dataGridViewSalesTicketReq.RowTemplate.Height = 24;
            this.dataGridViewSalesTicketReq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalesTicketReq.Size = new System.Drawing.Size(668, 426);
            this.dataGridViewSalesTicketReq.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, -18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "ticket status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(-38, -34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "make ticket";
            // 
            // lbTicketStatus
            // 
            this.lbTicketStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTicketStatus.FormattingEnabled = true;
            this.lbTicketStatus.Location = new System.Drawing.Point(434, 178);
            this.lbTicketStatus.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbTicketStatus.Name = "lbTicketStatus";
            this.lbTicketStatus.Size = new System.Drawing.Size(140, 108);
            this.lbTicketStatus.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelShadowTicketLog);
            this.tabPage2.Controls.Add(this.dataGridViewSalesPastTicketReq);
            this.tabPage2.Controls.Add(this.lbPastTickets);
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Size = new System.Drawing.Size(907, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View past tickets";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelShadowTicketLog
            // 
            this.panelShadowTicketLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelShadowTicketLog.Controls.Add(this.panelTicketLog);
            this.panelShadowTicketLog.Location = new System.Drawing.Point(328, 2);
            this.panelShadowTicketLog.Margin = new System.Windows.Forms.Padding(4);
            this.panelShadowTicketLog.Name = "panelShadowTicketLog";
            this.panelShadowTicketLog.Size = new System.Drawing.Size(275, 63);
            this.panelShadowTicketLog.TabIndex = 55;
            // 
            // panelTicketLog
            // 
            this.panelTicketLog.BackColor = System.Drawing.Color.White;
            this.panelTicketLog.Controls.Add(this.btnViewPastTickets);
            this.panelTicketLog.Location = new System.Drawing.Point(8, 7);
            this.panelTicketLog.Margin = new System.Windows.Forms.Padding(4);
            this.panelTicketLog.Name = "panelTicketLog";
            this.panelTicketLog.Size = new System.Drawing.Size(257, 49);
            this.panelTicketLog.TabIndex = 45;
            // 
            // btnViewPastTickets
            // 
            this.btnViewPastTickets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnViewPastTickets.ButtonImage = null;
            this.btnViewPastTickets.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnViewPastTickets.ButtonText = "Refresh";
            this.btnViewPastTickets.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnViewPastTickets.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewPastTickets.CornerRadius = 10;
            this.btnViewPastTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewPastTickets.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPastTickets.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnViewPastTickets.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnViewPastTickets.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewPastTickets.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnViewPastTickets.Location = new System.Drawing.Point(81, 7);
            this.btnViewPastTickets.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewPastTickets.Name = "btnViewPastTickets";
            this.btnViewPastTickets.Size = new System.Drawing.Size(92, 37);
            this.btnViewPastTickets.TabIndex = 54;
            this.btnViewPastTickets.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewPastTickets.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnViewPastTickets.Click += new System.EventHandler(this.BtnViewPastTickets_Click);
            // 
            // dataGridViewSalesPastTicketReq
            // 
            this.dataGridViewSalesPastTicketReq.AllowUserToAddRows = false;
            this.dataGridViewSalesPastTicketReq.AllowUserToDeleteRows = false;
            this.dataGridViewSalesPastTicketReq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSalesPastTicketReq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSalesPastTicketReq.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewSalesPastTicketReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSalesPastTicketReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesPastTicketReq.Location = new System.Drawing.Point(0, 66);
            this.dataGridViewSalesPastTicketReq.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewSalesPastTicketReq.Name = "dataGridViewSalesPastTicketReq";
            this.dataGridViewSalesPastTicketReq.ReadOnly = true;
            this.dataGridViewSalesPastTicketReq.RowHeadersWidth = 51;
            this.dataGridViewSalesPastTicketReq.RowTemplate.Height = 24;
            this.dataGridViewSalesPastTicketReq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSalesPastTicketReq.Size = new System.Drawing.Size(907, 430);
            this.dataGridViewSalesPastTicketReq.TabIndex = 33;
            // 
            // lbPastTickets
            // 
            this.lbPastTickets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPastTickets.FormattingEnabled = true;
            this.lbPastTickets.Location = new System.Drawing.Point(428, 131);
            this.lbPastTickets.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.lbPastTickets.Name = "lbPastTickets";
            this.lbPastTickets.Size = new System.Drawing.Size(113, 82);
            this.lbPastTickets.TabIndex = 0;
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
            this.panel1.Size = new System.Drawing.Size(206, 495);
            this.panel1.TabIndex = 15;
            // 
            // btnNavManageProducts
            // 
            this.btnNavManageProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnNavManageProducts.ButtonImage = global::Hardware_App.Properties.Resources.log_file_format_white;
            this.btnNavManageProducts.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnNavManageProducts.ButtonText = "Log Requests";
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
            this.btnNavManageProducts.Size = new System.Drawing.Size(206, 44);
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
            this.btnNavProdRequests.Size = new System.Drawing.Size(206, 44);
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
            this.pictureBox1.Size = new System.Drawing.Size(206, 65);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SalesRepresentative
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1110, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "SalesRepresentative";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesRepresentative";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesRepresentative_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelShadowRequestProduct.ResumeLayout(false);
            this.panelRequestProduct.ResumeLayout(false);
            this.panelRequestProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.panelShadowRequestsControls.ResumeLayout(false);
            this.panelRequestsControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesTicketReq)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panelShadowTicketLog.ResumeLayout(false);
            this.panelTicketLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesPastTicketReq)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbTicketStatus;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbPastTickets;
        private System.Windows.Forms.DataGridView dataGridViewSalesTicketReq;
        private System.Windows.Forms.DataGridView dataGridViewSalesPastTicketReq;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton btnNavManageProducts;
        private XanderUI.XUIButton btnNavProdRequests;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelShadowRequestsControls;
        private System.Windows.Forms.Panel panelRequestsControls;
        private System.Windows.Forms.Panel panelShadowRequestProduct;
        private System.Windows.Forms.Panel panelRequestProduct;
        private XanderUI.XUIButton btnSubmitTicket;
        private System.Windows.Forms.ComboBox cbProductBarcode;
        private XanderUI.XUIButton btnClearTickets;
        private XanderUI.XUIButton btnConfirmDelivery;
        private XanderUI.XUIButton btnReject;
        private XanderUI.XUIButton btnUpdateRequests;
        private System.Windows.Forms.Panel panelShadowTicketLog;
        private System.Windows.Forms.Panel panelTicketLog;
        private XanderUI.XUIButton btnViewPastTickets;
        private XanderUI.XUIButton bt_generateBarcode;
    }
}