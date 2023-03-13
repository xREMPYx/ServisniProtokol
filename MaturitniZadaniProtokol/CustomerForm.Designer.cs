namespace MaturitniZadaniProtokol
{
    partial class CustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_Name = new System.Windows.Forms.TextBox();
            this.TxtBox_Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBox_TIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBox_PostalCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Název:";
            // 
            // TxtBox_Name
            // 
            this.TxtBox_Name.Location = new System.Drawing.Point(88, 6);
            this.TxtBox_Name.Name = "TxtBox_Name";
            this.TxtBox_Name.Size = new System.Drawing.Size(302, 23);
            this.TxtBox_Name.TabIndex = 1;
            // 
            // TxtBox_Address
            // 
            this.TxtBox_Address.Location = new System.Drawing.Point(88, 35);
            this.TxtBox_Address.Name = "TxtBox_Address";
            this.TxtBox_Address.Size = new System.Drawing.Size(302, 23);
            this.TxtBox_Address.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresa:";
            // 
            // TxtBox_TIN
            // 
            this.TxtBox_TIN.Location = new System.Drawing.Point(88, 93);
            this.TxtBox_TIN.Name = "TxtBox_TIN";
            this.TxtBox_TIN.Size = new System.Drawing.Size(302, 23);
            this.TxtBox_TIN.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "IČ:";
            // 
            // TxtBox_PostalCode
            // 
            this.TxtBox_PostalCode.Location = new System.Drawing.Point(88, 64);
            this.TxtBox_PostalCode.Name = "TxtBox_PostalCode";
            this.TxtBox_PostalCode.Size = new System.Drawing.Size(302, 23);
            this.TxtBox_PostalCode.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "PSČ:";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(315, 149);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "Zrušit";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Location = new System.Drawing.Point(234, 149);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.Btn_Confirm.TabIndex = 9;
            this.Btn_Confirm.Text = "Potvrdit";
            this.Btn_Confirm.UseVisualStyleBackColor = true;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 184);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.TxtBox_TIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBox_PostalCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBox_Address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBox_Name);
            this.Controls.Add(this.label1);
            this.Name = "CustomerForm";
            this.Text = "Zákazník";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtBox_Name;
        private TextBox TxtBox_Address;
        private Label label2;
        private TextBox TxtBox_TIN;
        private Label label3;
        private TextBox TxtBox_PostalCode;
        private Label label4;
        private Button Btn_Cancel;
        private Button Btn_Confirm;
    }
}