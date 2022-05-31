
namespace Bicycle_store_system
{
    partial class Bicycles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bicycles));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSpecialOfferID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbSectionID = new System.Windows.Forms.ComboBox();
            this.cbBicycleColor = new System.Windows.Forms.ComboBox();
            this.tbBicyclePrice = new System.Windows.Forms.TextBox();
            this.tbBicycleModel = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBicycle = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDeleteBicycle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbSearchBicycle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbBicycleIDUpdate = new System.Windows.Forms.TextBox();
            this.cbSpecialOfferIDUpdate = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.cbSectionIDUpdate = new System.Windows.Forms.ComboBox();
            this.cbBicycleColorUpdate = new System.Windows.Forms.ComboBox();
            this.tbBicyclePriceUpdate = new System.Windows.Forms.TextBox();
            this.tbBicycleModelUpdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBicycle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bicycle Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bicycle Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bicycle Price:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Section ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSpecialOfferID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbSectionID);
            this.groupBox1.Controls.Add(this.cbBicycleColor);
            this.groupBox1.Controls.Add(this.tbBicyclePrice);
            this.groupBox1.Controls.Add(this.tbBicycleModel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 173);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Bicycle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbSpecialOfferID
            // 
            this.cbSpecialOfferID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecialOfferID.FormattingEnabled = true;
            this.cbSpecialOfferID.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbSpecialOfferID.Location = new System.Drawing.Point(100, 119);
            this.cbSpecialOfferID.Name = "cbSpecialOfferID";
            this.cbSpecialOfferID.Size = new System.Drawing.Size(125, 21);
            this.cbSpecialOfferID.TabIndex = 10;
            this.cbSpecialOfferID.SelectedIndexChanged += new System.EventHandler(this.cbSepcialOfferID_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Special offer ID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(150, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSectionID
            // 
            this.cbSectionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSectionID.FormattingEnabled = true;
            this.cbSectionID.Location = new System.Drawing.Point(100, 92);
            this.cbSectionID.Name = "cbSectionID";
            this.cbSectionID.Size = new System.Drawing.Size(125, 21);
            this.cbSectionID.TabIndex = 7;
            this.cbSectionID.SelectedIndexChanged += new System.EventHandler(this.cbSectionID_SelectedIndexChanged);
            // 
            // cbBicycleColor
            // 
            this.cbBicycleColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBicycleColor.FormattingEnabled = true;
            this.cbBicycleColor.Items.AddRange(new object[] {
            "Black",
            "White",
            "Silver",
            "Blue",
            "Red",
            "Yellow",
            "Green",
            "Orange",
            "Brown",
            "Purple",
            "Grey",
            "Cyan",
            "DarkBlue",
            "LightBlue",
            "Maroon",
            "Lime",
            "Magenta",
            "Olive"});
            this.cbBicycleColor.Location = new System.Drawing.Point(100, 39);
            this.cbBicycleColor.Name = "cbBicycleColor";
            this.cbBicycleColor.Size = new System.Drawing.Size(125, 21);
            this.cbBicycleColor.TabIndex = 6;
            // 
            // tbBicyclePrice
            // 
            this.tbBicyclePrice.Location = new System.Drawing.Point(100, 66);
            this.tbBicyclePrice.Name = "tbBicyclePrice";
            this.tbBicyclePrice.Size = new System.Drawing.Size(125, 20);
            this.tbBicyclePrice.TabIndex = 5;
            // 
            // tbBicycleModel
            // 
            this.tbBicycleModel.Location = new System.Drawing.Point(100, 13);
            this.tbBicycleModel.Name = "tbBicycleModel";
            this.tbBicycleModel.Size = new System.Drawing.Size(125, 20);
            this.tbBicycleModel.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(704, 41);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(248, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Manage Bicycles informaion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgvBicycle
            // 
            this.dgvBicycle.BackgroundColor = System.Drawing.Color.White;
            this.dgvBicycle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBicycle.Location = new System.Drawing.Point(249, 69);
            this.dgvBicycle.Name = "dgvBicycle";
            this.dgvBicycle.Size = new System.Drawing.Size(443, 510);
            this.dgvBicycle.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDeleteBicycle);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 70);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Bicycle";
            // 
            // tbDeleteBicycle
            // 
            this.tbDeleteBicycle.Location = new System.Drawing.Point(100, 13);
            this.tbDeleteBicycle.Name = "tbDeleteBicycle";
            this.tbDeleteBicycle.Size = new System.Drawing.Size(125, 20);
            this.tbDeleteBicycle.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Bicycle ID:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 0;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbSearchBicycle);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(12, 509);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 70);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Bicycle";
            // 
            // tbSearchBicycle
            // 
            this.tbSearchBicycle.Location = new System.Drawing.Point(100, 13);
            this.tbSearchBicycle.Name = "tbSearchBicycle";
            this.tbSearchBicycle.Size = new System.Drawing.Size(125, 20);
            this.tbSearchBicycle.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Bicycle Model:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 0;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbBicycleIDUpdate);
            this.groupBox4.Controls.Add(this.cbSpecialOfferIDUpdate);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.cbSectionIDUpdate);
            this.groupBox4.Controls.Add(this.cbBicycleColorUpdate);
            this.groupBox4.Controls.Add(this.tbBicyclePriceUpdate);
            this.groupBox4.Controls.Add(this.tbBicycleModelUpdate);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(12, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 201);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Bicycle";
            // 
            // tbBicycleIDUpdate
            // 
            this.tbBicycleIDUpdate.Location = new System.Drawing.Point(100, 13);
            this.tbBicycleIDUpdate.Name = "tbBicycleIDUpdate";
            this.tbBicycleIDUpdate.Size = new System.Drawing.Size(125, 20);
            this.tbBicycleIDUpdate.TabIndex = 13;
            // 
            // cbSpecialOfferIDUpdate
            // 
            this.cbSpecialOfferIDUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecialOfferIDUpdate.FormattingEnabled = true;
            this.cbSpecialOfferIDUpdate.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbSpecialOfferIDUpdate.Location = new System.Drawing.Point(100, 145);
            this.cbSpecialOfferIDUpdate.Name = "cbSpecialOfferIDUpdate";
            this.cbSpecialOfferIDUpdate.Size = new System.Drawing.Size(125, 21);
            this.cbSpecialOfferIDUpdate.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Bicycle ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Special offer ID:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(150, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 8;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbSectionIDUpdate
            // 
            this.cbSectionIDUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSectionIDUpdate.FormattingEnabled = true;
            this.cbSectionIDUpdate.Location = new System.Drawing.Point(100, 118);
            this.cbSectionIDUpdate.Name = "cbSectionIDUpdate";
            this.cbSectionIDUpdate.Size = new System.Drawing.Size(125, 21);
            this.cbSectionIDUpdate.TabIndex = 7;
            // 
            // cbBicycleColorUpdate
            // 
            this.cbBicycleColorUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBicycleColorUpdate.FormattingEnabled = true;
            this.cbBicycleColorUpdate.Items.AddRange(new object[] {
            "Black",
            "White",
            "Silver",
            "Blue",
            "Red",
            "Yellow",
            "Green",
            "Orange",
            "Brown",
            "Purple",
            "Grey",
            "Cyan",
            "DarkBlue",
            "LightBlue",
            "Maroon",
            "Lime",
            "Magenta",
            "Olive"});
            this.cbBicycleColorUpdate.Location = new System.Drawing.Point(100, 65);
            this.cbBicycleColorUpdate.Name = "cbBicycleColorUpdate";
            this.cbBicycleColorUpdate.Size = new System.Drawing.Size(125, 21);
            this.cbBicycleColorUpdate.TabIndex = 6;
            // 
            // tbBicyclePriceUpdate
            // 
            this.tbBicyclePriceUpdate.Location = new System.Drawing.Point(100, 92);
            this.tbBicyclePriceUpdate.Name = "tbBicyclePriceUpdate";
            this.tbBicyclePriceUpdate.Size = new System.Drawing.Size(125, 20);
            this.tbBicyclePriceUpdate.TabIndex = 5;
            // 
            // tbBicycleModelUpdate
            // 
            this.tbBicycleModelUpdate.Location = new System.Drawing.Point(100, 39);
            this.tbBicycleModelUpdate.Name = "tbBicycleModelUpdate";
            this.tbBicycleModelUpdate.Size = new System.Drawing.Size(125, 20);
            this.tbBicycleModelUpdate.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Bicycle Model:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Section ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Bicycle Color:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Bicycle Price:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(249, 49);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 11;
            // 
            // Bicycles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 591);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvBicycle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(720, 630);
            this.MinimumSize = new System.Drawing.Size(720, 630);
            this.Name = "Bicycles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bicycles";
            this.Load += new System.EventHandler(this.Bicycles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBicycle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbSectionID;
        private System.Windows.Forms.ComboBox cbBicycleColor;
        private System.Windows.Forms.TextBox tbBicyclePrice;
        private System.Windows.Forms.TextBox tbBicycleModel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSpecialOfferID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvBicycle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbDeleteBicycle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbSearchBicycle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbSpecialOfferIDUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cbSectionIDUpdate;
        private System.Windows.Forms.ComboBox cbBicycleColorUpdate;
        private System.Windows.Forms.TextBox tbBicyclePriceUpdate;
        private System.Windows.Forms.TextBox tbBicycleModelUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox tbBicycleIDUpdate;
        private System.Windows.Forms.Label label14;
    }
}