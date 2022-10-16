namespace HomeWork_5.UserControls
{
    partial class UC_Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbox_productPicture = new System.Windows.Forms.PictureBox();
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.lbl_product_price = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.cbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_productPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox_productPicture
            // 
            this.pbox_productPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbox_productPicture.Enabled = false;
            this.pbox_productPicture.ErrorImage = global::HomeWork_5.Properties.Resources.external_product_advertising_wanicon_two_tone_wanicon;
            this.pbox_productPicture.Location = new System.Drawing.Point(48, 0);
            this.pbox_productPicture.Name = "pbox_productPicture";
            this.pbox_productPicture.Size = new System.Drawing.Size(40, 40);
            this.pbox_productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_productPicture.TabIndex = 0;
            this.pbox_productPicture.TabStop = false;
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_product_name.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_product_name.Location = new System.Drawing.Point(39, 43);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(56, 22);
            this.lbl_product_name.TabIndex = 1;
            this.lbl_product_name.Text = "Name";
            // 
            // lbl_product_price
            // 
            this.lbl_product_price.AutoSize = true;
            this.lbl_product_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_product_price.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lbl_product_price.Location = new System.Drawing.Point(39, 65);
            this.lbl_product_price.Name = "lbl_product_price";
            this.lbl_product_price.Size = new System.Drawing.Size(59, 23);
            this.lbl_product_price.TabIndex = 1;
            this.lbl_product_price.Text = "Price ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.txt_count);
            this.panel1.Controls.Add(this.cbox);
            this.panel1.Controls.Add(this.pbox_productPicture);
            this.panel1.Controls.Add(this.lbl_product_name);
            this.panel1.Controls.Add(this.lbl_product_price);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 120);
            this.panel1.TabIndex = 3;
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(27, 90);
            this.txt_count.Name = "txt_count";
            this.txt_count.PlaceholderText = "Enter Count";
            this.txt_count.Size = new System.Drawing.Size(82, 27);
            this.txt_count.TabIndex = 4;
            this.txt_count.Visible = false;
            // 
            // cbox
            // 
            this.cbox.AutoSize = true;
            this.cbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbox.Location = new System.Drawing.Point(6, 96);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(18, 17);
            this.cbox.TabIndex = 3;
            this.cbox.UseVisualStyleBackColor = true;
            this.cbox.CheckedChanged += new System.EventHandler(this.cbox_CheckedChanged);
            // 
            // UC_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Product";
            this.Size = new System.Drawing.Size(137, 120);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_productPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public PictureBox pbox_productPicture;
        public Label lbl_product_name;
        public Label lbl_product_price;
        private Panel panel1;
        private CheckBox cbox;
        public TextBox txt_count;
    }
}
