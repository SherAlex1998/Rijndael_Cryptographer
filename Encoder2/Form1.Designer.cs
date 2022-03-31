
namespace Encoder
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EncodeButton = new System.Windows.Forms.RadioButton();
            this.DecodeButton = new System.Windows.Forms.RadioButton();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.ReferenceTextBox = new System.Windows.Forms.TextBox();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EncodeButton
            // 
            this.EncodeButton.AutoSize = true;
            this.EncodeButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EncodeButton.Location = new System.Drawing.Point(38, 30);
            this.EncodeButton.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(127, 25);
            this.EncodeButton.TabIndex = 0;
            this.EncodeButton.TabStop = true;
            this.EncodeButton.Text = "Зашифровать";
            this.EncodeButton.UseVisualStyleBackColor = true;
            // 
            // DecodeButton
            // 
            this.DecodeButton.AutoSize = true;
            this.DecodeButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DecodeButton.Location = new System.Drawing.Point(38, 68);
            this.DecodeButton.Margin = new System.Windows.Forms.Padding(30, 10, 3, 3);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(134, 25);
            this.DecodeButton.TabIndex = 1;
            this.DecodeButton.TabStop = true;
            this.DecodeButton.Text = "Расшифровать";
            this.DecodeButton.UseVisualStyleBackColor = true;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.KeyLabel.Location = new System.Drawing.Point(39, 106);
            this.KeyLabel.Margin = new System.Windows.Forms.Padding(30, 10, 10, 0);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(49, 21);
            this.KeyLabel.TabIndex = 2;
            this.KeyLabel.Text = "Ключ";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.KeyTextBox.Location = new System.Drawing.Point(39, 137);
            this.KeyTextBox.Margin = new System.Windows.Forms.Padding(30, 10, 30, 3);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(360, 29);
            this.KeyTextBox.TabIndex = 3;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TextLabel.Location = new System.Drawing.Point(39, 179);
            this.TextLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(48, 21);
            this.TextLabel.TabIndex = 4;
            this.TextLabel.Text = "Текст";
            // 
            // ReferenceTextBox
            // 
            this.ReferenceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ReferenceTextBox.Location = new System.Drawing.Point(39, 210);
            this.ReferenceTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ReferenceTextBox.Name = "ReferenceTextBox";
            this.ReferenceTextBox.Size = new System.Drawing.Size(359, 29);
            this.ReferenceTextBox.TabIndex = 5;
            // 
            // ProcessButton
            // 
            this.ProcessButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProcessButton.Location = new System.Drawing.Point(38, 252);
            this.ProcessButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(360, 37);
            this.ProcessButton.TabIndex = 6;
            this.ProcessButton.Text = "ОБРАБОТАТЬ";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ResultTextBox.Location = new System.Drawing.Point(39, 380);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(359, 114);
            this.ResultTextBox.TabIndex = 7;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ResultLabel.Location = new System.Drawing.Point(39, 349);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(80, 21);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "Результат";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ClearButton.Location = new System.Drawing.Point(38, 299);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(360, 37);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "ОЧИСТИТЬ";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(438, 506);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.ReferenceTextBox);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.EncodeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Шифратор 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton EncodeButton;
        private System.Windows.Forms.RadioButton DecodeButton;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.TextBox ReferenceTextBox;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ClearButton;
    }
}

