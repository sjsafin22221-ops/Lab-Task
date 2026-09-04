namespace Castomer_Management_System
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
            this.lName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.lGender = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lCatrgory = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbPrimium = new System.Windows.Forms.RadioButton();
            this.rbNew_Customer = new System.Windows.Forms.RadioButton();
            this.bInsert = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(123, 119);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(47, 16);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Management System";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(196, 113);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(317, 22);
            this.tbName.TabIndex = 2;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(123, 150);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(70, 16);
            this.lPassword.TabIndex = 3;
            this.lPassword.Text = "Password:";
            // 
            // lGender
            // 
            this.lGender.AutoSize = true;
            this.lGender.Location = new System.Drawing.Point(123, 182);
            this.lGender.Name = "lGender";
            this.lGender.Size = new System.Drawing.Size(55, 16);
            this.lGender.TabIndex = 4;
            this.lGender.Text = "Gender:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(196, 144);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(317, 22);
            this.tbPassword.TabIndex = 6;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(193, 182);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 20);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lCatrgory
            // 
            this.lCatrgory.AutoSize = true;
            this.lCatrgory.Location = new System.Drawing.Point(123, 216);
            this.lCatrgory.Name = "lCatrgory";
            this.lCatrgory.Size = new System.Drawing.Size(61, 16);
            this.lCatrgory.TabIndex = 8;
            this.lCatrgory.Text = "Catrgory:";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(322, 182);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(74, 20);
            this.rbFemale.TabIndex = 9;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Location = new System.Drawing.Point(193, 216);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(76, 20);
            this.rbRegular.TabIndex = 10;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Regular";
            this.rbRegular.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(453, 182);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(60, 20);
            this.rbOther.TabIndex = 11;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbPrimium
            // 
            this.rbPrimium.AutoSize = true;
            this.rbPrimium.Location = new System.Drawing.Point(322, 216);
            this.rbPrimium.Name = "rbPrimium";
            this.rbPrimium.Size = new System.Drawing.Size(76, 20);
            this.rbPrimium.TabIndex = 12;
            this.rbPrimium.TabStop = true;
            this.rbPrimium.Text = "Primium";
            this.rbPrimium.UseVisualStyleBackColor = true;
            // 
            // rbNew_Customer
            // 
            this.rbNew_Customer.AutoSize = true;
            this.rbNew_Customer.Location = new System.Drawing.Point(453, 216);
            this.rbNew_Customer.Name = "rbNew_Customer";
            this.rbNew_Customer.Size = new System.Drawing.Size(115, 20);
            this.rbNew_Customer.TabIndex = 13;
            this.rbNew_Customer.TabStop = true;
            this.rbNew_Customer.Text = "New Customer";
            this.rbNew_Customer.UseVisualStyleBackColor = true;
            // 
            // bInsert
            // 
            this.bInsert.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bInsert.Location = new System.Drawing.Point(94, 301);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(75, 23);
            this.bInsert.TabIndex = 14;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = false;
            this.bInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bSearch.Location = new System.Drawing.Point(210, 301);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 15;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bUpdate.Location = new System.Drawing.Point(323, 301);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 16;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = false;
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.Red;
            this.bDelete.Location = new System.Drawing.Point(438, 301);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 17;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = false;
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bClear.Location = new System.Drawing.Point(562, 301);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 18;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.rbNew_Customer);
            this.Controls.Add(this.rbPrimium);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbRegular);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.lCatrgory);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lGender);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lGender;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lCatrgory;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbRegular;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbPrimium;
        private System.Windows.Forms.RadioButton rbNew_Customer;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bClear;
    }
}

