namespace Robiños_Week05_Work04
{
    partial class Form1
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
            this.barcodebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.descriptionbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.markupbox = new System.Windows.Forms.TextBox();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.costbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barcodebox
            // 
            this.barcodebox.Location = new System.Drawing.Point(304, 44);
            this.barcodebox.Name = "barcodebox";
            this.barcodebox.Size = new System.Drawing.Size(363, 22);
            this.barcodebox.TabIndex = 0;
            this.barcodebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.barcodebox_KeyPress);
            this.barcodebox.TextChanged += new System.EventHandler(this.barcodebox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(304, 105);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(363, 22);
            this.namebox.TabIndex = 3;
            // 
            // descriptionbox
            // 
            this.descriptionbox.Location = new System.Drawing.Point(304, 156);
            this.descriptionbox.Multiline = true;
            this.descriptionbox.Name = "descriptionbox";
            this.descriptionbox.Size = new System.Drawing.Size(363, 132);
            this.descriptionbox.TabIndex = 4;
            this.descriptionbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Origin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(304, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manufactured";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Local";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(176, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Abroad";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(164, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Status";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(304, 507);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 22);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(534, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Markup (%)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(164, 565);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(351, 565);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Price";
            // 
            // markupbox
            // 
            this.markupbox.Location = new System.Drawing.Point(537, 594);
            this.markupbox.Name = "markupbox";
            this.markupbox.Size = new System.Drawing.Size(100, 22);
            this.markupbox.TabIndex = 14;
            this.markupbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Money_KeyPress);
            this.markupbox.TextChanged += new System.EventHandler(this.markupbox_TextChanged);
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(354, 594);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(100, 22);
            this.pricebox.TabIndex = 15;
            this.pricebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Money_KeyPress);
            this.pricebox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // costbox
            // 
            this.costbox.Location = new System.Drawing.Point(165, 594);
            this.costbox.Name = "costbox";
            this.costbox.Size = new System.Drawing.Size(100, 22);
            this.costbox.TabIndex = 16;
            this.costbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Money_KeyPress);
            this.costbox.TextChanged += new System.EventHandler(this.costbox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 729);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 17;
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(167, 669);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(83, 32);
            this.cancelbutton.TabIndex = 18;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(354, 669);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(91, 32);
            this.clearbutton.TabIndex = 19;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(537, 669);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(100, 47);
            this.savebutton.TabIndex = 20;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(304, 322);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(363, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.Location = new System.Drawing.Point(311, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Barcode is available.";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 773);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.costbox);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.markupbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barcodebox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barcodebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox descriptionbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox markupbox;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.TextBox costbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
    }
}

