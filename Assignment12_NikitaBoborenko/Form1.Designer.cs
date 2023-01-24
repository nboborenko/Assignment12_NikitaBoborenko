namespace Assignment12_NikitaBoborenko
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelScreen = new System.Windows.Forms.Panel();
            this.input_button = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.payRateTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shiftNumberComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelScreen
            // 
            this.panelScreen.Location = new System.Drawing.Point(9, 118);
            this.panelScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Size = new System.Drawing.Size(582, 245);
            this.panelScreen.TabIndex = 0;
            // 
            // input_button
            // 
            this.input_button.Location = new System.Drawing.Point(200, 80);
            this.input_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input_button.Name = "input_button";
            this.input_button.Size = new System.Drawing.Size(56, 19);
            this.input_button.TabIndex = 1;
            this.input_button.Text = "Add";
            this.input_button.UseVisualStyleBackColor = true;
            this.input_button.Click += new System.EventHandler(this.input_button_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(14, 26);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(76, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // payRateTextBox
            // 
            this.payRateTextBox.Location = new System.Drawing.Point(120, 79);
            this.payRateTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.payRateTextBox.Name = "payRateTextBox";
            this.payRateTextBox.Size = new System.Drawing.Size(76, 20);
            this.payRateTextBox.TabIndex = 3;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(120, 24);
            this.numberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(76, 20);
            this.numberTextBox.TabIndex = 4;
            this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number";
            // 
            // shiftNumberComboBox
            // 
            this.shiftNumberComboBox.FormattingEnabled = true;
            this.shiftNumberComboBox.Items.AddRange(new object[] {
            "Shift 1",
            "Shift 2"});
            this.shiftNumberComboBox.Location = new System.Drawing.Point(14, 78);
            this.shiftNumberComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shiftNumberComboBox.Name = "shiftNumberComboBox";
            this.shiftNumberComboBox.Size = new System.Drawing.Size(76, 21);
            this.shiftNumberComboBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Shift";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pay rate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shiftNumberComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.payRateTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.input_button);
            this.Controls.Add(this.panelScreen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelScreen;
        private System.Windows.Forms.Button input_button;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox payRateTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox shiftNumberComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

