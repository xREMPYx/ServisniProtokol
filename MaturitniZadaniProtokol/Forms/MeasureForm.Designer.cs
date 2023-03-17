namespace MaturitniZadaniProtokol
{
    partial class MeasureForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBox_Parameter = new System.Windows.Forms.TextBox();
            this.TxtBox_Value = new System.Windows.Forms.TextBox();
            this.TxtBox_Unit = new System.Windows.Forms.TextBox();
            this.CheckBox_Suits = new System.Windows.Forms.CheckBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(300, 123);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "Zrušit";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Location = new System.Drawing.Point(219, 123);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.Btn_Confirm.TabIndex = 4;
            this.Btn_Confirm.Text = "Potvrdit";
            this.Btn_Confirm.UseVisualStyleBackColor = true;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parametr:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naměřená hodnota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jednotka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vyhovuje:";
            // 
            // TxtBox_Parameter
            // 
            this.TxtBox_Parameter.Location = new System.Drawing.Point(145, 6);
            this.TxtBox_Parameter.Name = "TxtBox_Parameter";
            this.TxtBox_Parameter.Size = new System.Drawing.Size(230, 23);
            this.TxtBox_Parameter.TabIndex = 0;
            this.TxtBox_Parameter.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBox_EmptyValidating);
            // 
            // TxtBox_Value
            // 
            this.TxtBox_Value.Location = new System.Drawing.Point(145, 32);
            this.TxtBox_Value.Name = "TxtBox_Value";
            this.TxtBox_Value.Size = new System.Drawing.Size(230, 23);
            this.TxtBox_Value.TabIndex = 1;
            this.TxtBox_Value.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBox_Value_Validating);
            // 
            // TxtBox_Unit
            // 
            this.TxtBox_Unit.Location = new System.Drawing.Point(145, 58);
            this.TxtBox_Unit.Name = "TxtBox_Unit";
            this.TxtBox_Unit.Size = new System.Drawing.Size(230, 23);
            this.TxtBox_Unit.TabIndex = 2;
            this.TxtBox_Unit.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBox_EmptyValidating);
            // 
            // CheckBox_Suits
            // 
            this.CheckBox_Suits.AutoSize = true;
            this.CheckBox_Suits.Location = new System.Drawing.Point(145, 88);
            this.CheckBox_Suits.Name = "CheckBox_Suits";
            this.CheckBox_Suits.Size = new System.Drawing.Size(15, 14);
            this.CheckBox_Suits.TabIndex = 3;
            this.CheckBox_Suits.UseVisualStyleBackColor = true;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // MeasureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(387, 155);
            this.Controls.Add(this.CheckBox_Suits);
            this.Controls.Add(this.TxtBox_Unit);
            this.Controls.Add(this.TxtBox_Value);
            this.Controls.Add(this.TxtBox_Parameter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Btn_Cancel);
            this.MaximumSize = new System.Drawing.Size(403, 194);
            this.MinimumSize = new System.Drawing.Size(403, 194);
            this.Name = "MeasureForm";
            this.Text = "Měření";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Cancel;
        private Button Btn_Confirm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtBox_Parameter;
        private TextBox TxtBox_Value;
        private TextBox TxtBox_Unit;
        private CheckBox CheckBox_Suits;
        private ErrorProvider ErrorProvider;
    }
}