namespace Аптека
{
    partial class Availability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Availability));
            this.comboBoxPharmacy = new System.Windows.Forms.ComboBox();
            this.comboBoxMedicine = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewAvailability = new System.Windows.Forms.ListView();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPharmacy
            // 
            this.comboBoxPharmacy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPharmacy.FormattingEnabled = true;
            this.comboBoxPharmacy.Location = new System.Drawing.Point(12, 104);
            this.comboBoxPharmacy.Name = "comboBoxPharmacy";
            this.comboBoxPharmacy.Size = new System.Drawing.Size(121, 27);
            this.comboBoxPharmacy.TabIndex = 0;
            // 
            // comboBoxMedicine
            // 
            this.comboBoxMedicine.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMedicine.FormattingEnabled = true;
            this.comboBoxMedicine.Location = new System.Drawing.Point(12, 176);
            this.comboBoxMedicine.Name = "comboBoxMedicine";
            this.comboBoxMedicine.Size = new System.Drawing.Size(121, 27);
            this.comboBoxMedicine.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Аптека";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Лекарство";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Цена";
            // 
            // listViewAvailability
            // 
            this.listViewAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(214)))));
            this.listViewAvailability.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewAvailability.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewAvailability.FullRowSelect = true;
            this.listViewAvailability.GridLines = true;
            this.listViewAvailability.HideSelection = false;
            this.listViewAvailability.Location = new System.Drawing.Point(139, 82);
            this.listViewAvailability.MultiSelect = false;
            this.listViewAvailability.Name = "listViewAvailability";
            this.listViewAvailability.Size = new System.Drawing.Size(516, 256);
            this.listViewAvailability.TabIndex = 6;
            this.listViewAvailability.UseCompatibleStateImageBehavior = false;
            this.listViewAvailability.View = System.Windows.Forms.View.Details;
            this.listViewAvailability.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAmount.Location = new System.Drawing.Point(12, 242);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(121, 27);
            this.textBoxAmount.TabIndex = 7;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBoxAmount_TextChanged);
            this.textBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmount_KeyPress);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(12, 311);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 27);
            this.textBoxPrice.TabIndex = 8;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Аптека.Properties.Resources._119_1192900_pharmacy_icon_svg_png_icon_free_download_healthcare_innovation_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Location = new System.Drawing.Point(580, 344);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 17;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(499, 344);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(418, 344);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Аптека";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 138;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Лекарство";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Количество";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 93;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Цена";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 85;
            // 
            // Availability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(667, 375);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.listViewAvailability);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMedicine);
            this.Controls.Add(this.comboBoxPharmacy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Availability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Наличие";
            this.Load += new System.EventHandler(this.Availability_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPharmacy;
        private System.Windows.Forms.ComboBox comboBoxMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewAvailability;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}