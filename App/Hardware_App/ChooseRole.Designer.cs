namespace Hardware_App
{
    partial class ChooseRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseRole));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmin = new XanderUI.XUIButton();
            this.btnSalesRep = new XanderUI.XUIButton();
            this.btnDepotWorker = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your role";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnAdmin.ButtonImage = null;
            this.btnAdmin.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnAdmin.ButtonText = "Administrator";
            this.btnAdmin.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnAdmin.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmin.CornerRadius = 5;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdmin.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnAdmin.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmin.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnAdmin.Location = new System.Drawing.Point(12, 67);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(129, 57);
            this.btnAdmin.TabIndex = 27;
            this.btnAdmin.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdmin.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // btnSalesRep
            // 
            this.btnSalesRep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnSalesRep.ButtonImage = null;
            this.btnSalesRep.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSalesRep.ButtonText = "Sales Representative";
            this.btnSalesRep.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnSalesRep.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalesRep.CornerRadius = 5;
            this.btnSalesRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesRep.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesRep.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSalesRep.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnSalesRep.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalesRep.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSalesRep.Location = new System.Drawing.Point(164, 67);
            this.btnSalesRep.Name = "btnSalesRep";
            this.btnSalesRep.Size = new System.Drawing.Size(129, 57);
            this.btnSalesRep.TabIndex = 28;
            this.btnSalesRep.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalesRep.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSalesRep.Click += new System.EventHandler(this.BtnSalesRep_Click);
            // 
            // btnDepotWorker
            // 
            this.btnDepotWorker.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnDepotWorker.ButtonImage = null;
            this.btnDepotWorker.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnDepotWorker.ButtonText = "Depot Worker";
            this.btnDepotWorker.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnDepotWorker.ClickTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDepotWorker.CornerRadius = 5;
            this.btnDepotWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepotWorker.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepotWorker.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDepotWorker.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(32)))), ((int)(((byte)(102)))));
            this.btnDepotWorker.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDepotWorker.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnDepotWorker.Location = new System.Drawing.Point(313, 67);
            this.btnDepotWorker.Name = "btnDepotWorker";
            this.btnDepotWorker.Size = new System.Drawing.Size(129, 57);
            this.btnDepotWorker.TabIndex = 29;
            this.btnDepotWorker.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btnDepotWorker.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnDepotWorker.Click += new System.EventHandler(this.BtnDepotWorker_Click);
            // 
            // ChooseRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 152);
            this.Controls.Add(this.btnDepotWorker);
            this.Controls.Add(this.btnSalesRep);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChooseRole";
            this.Text = "ChooseRole";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseRole_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btnAdmin;
        private XanderUI.XUIButton btnSalesRep;
        private XanderUI.XUIButton btnDepotWorker;
    }
}