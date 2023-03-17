namespace MaturitniZadaniProtokol
{
    partial class BasicInformationForm
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
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimePicker_Measure_Date = new System.Windows.Forms.DateTimePicker();
            this.TxtBox_ProtocolNumber = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(277, 92);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 3;
            this.Btn_Cancel.Text = "Zrušit";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Location = new System.Drawing.Point(196, 92);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.Btn_Confirm.TabIndex = 2;
            this.Btn_Confirm.Text = "Potvrdit";
            this.Btn_Confirm.UseVisualStyleBackColor = true;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Číslo protokolu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum měření:";
            // 
            // DateTimePicker_Measure_Date
            // 
            this.DateTimePicker_Measure_Date.Location = new System.Drawing.Point(152, 43);
            this.DateTimePicker_Measure_Date.Name = "DateTimePicker_Measure_Date";
            this.DateTimePicker_Measure_Date.Size = new System.Drawing.Size(200, 23);
            this.DateTimePicker_Measure_Date.TabIndex = 1;
            // 
            // TxtBox_ProtocolNumber
            // 
            this.TxtBox_ProtocolNumber.Location = new System.Drawing.Point(152, 15);
            this.TxtBox_ProtocolNumber.Name = "TxtBox_ProtocolNumber";
            this.TxtBox_ProtocolNumber.Size = new System.Drawing.Size(200, 23);
            this.TxtBox_ProtocolNumber.TabIndex = 0;
            this.TxtBox_ProtocolNumber.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBox_ProtocolNumber_Validating);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // BasicInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(364, 124);
            this.Controls.Add(this.TxtBox_ProtocolNumber);
            this.Controls.Add(this.DateTimePicker_Measure_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Btn_Cancel);
            this.MaximumSize = new System.Drawing.Size(380, 163);
            this.MinimumSize = new System.Drawing.Size(380, 163);
            this.Name = "BasicInformationForm";
            this.Text = "Základní informace";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Cancel;
        private Button Btn_Confirm;
        private Label label1;
        private Label label2;
        private DateTimePicker DateTimePicker_Measure_Date;
        private TextBox TxtBox_ProtocolNumber;
        private ErrorProvider ErrorProvider;
    }
}