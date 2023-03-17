namespace MaturitniZadaniProtokol
{
    partial class DeviceForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.TxtBox_Manufacturer = new System.Windows.Forms.TextBox();
            this.TxtBox_Model = new System.Windows.Forms.TextBox();
            this.TxtBox_SerialCode = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Výrobce:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sériové číslo:";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(237, 113);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 3;
            this.Btn_Cancel.Text = "Zrušit";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Location = new System.Drawing.Point(156, 113);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.Btn_Confirm.TabIndex = 4;
            this.Btn_Confirm.Text = "Potvrdit";
            this.Btn_Confirm.UseVisualStyleBackColor = true;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // TxtBox_Manufacturer
            // 
            this.TxtBox_Manufacturer.Location = new System.Drawing.Point(114, 9);
            this.TxtBox_Manufacturer.Name = "TxtBox_Manufacturer";
            this.TxtBox_Manufacturer.Size = new System.Drawing.Size(198, 23);
            this.TxtBox_Manufacturer.TabIndex = 5;
            this.TxtBox_Manufacturer.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBox_EmptyValidating);
            // 
            // TxtBox_Model
            // 
            this.TxtBox_Model.Location = new System.Drawing.Point(114, 36);
            this.TxtBox_Model.Name = "TxtBox_Model";
            this.TxtBox_Model.Size = new System.Drawing.Size(198, 23);
            this.TxtBox_Model.TabIndex = 6;
            this.TxtBox_Model.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBox_EmptyValidating);
            // 
            // TxtBox_SerialCode
            // 
            this.TxtBox_SerialCode.Location = new System.Drawing.Point(114, 63);
            this.TxtBox_SerialCode.Name = "TxtBox_SerialCode";
            this.TxtBox_SerialCode.Size = new System.Drawing.Size(198, 23);
            this.TxtBox_SerialCode.TabIndex = 7;
            this.TxtBox_SerialCode.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBox_EmptyValidating);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(324, 148);
            this.Controls.Add(this.TxtBox_SerialCode);
            this.Controls.Add(this.TxtBox_Model);
            this.Controls.Add(this.TxtBox_Manufacturer);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeviceForm";
            this.Text = "Zařízení";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button Btn_Cancel;
        private Button Btn_Confirm;
        private TextBox TxtBox_Manufacturer;
        private TextBox TxtBox_Model;
        private TextBox TxtBox_SerialCode;
        private ErrorProvider ErrorProvider;
    }
}