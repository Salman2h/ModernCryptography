namespace Rana_Aujeszky_Gregory_Decrypt
{
    partial class UserInput
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
            this.readDictionaryButton = new System.Windows.Forms.Button();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.cipherLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plainTextBox = new System.Windows.Forms.TextBox();
            this.plainTextLabel = new System.Windows.Forms.Label();
            this.checkExistanceLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.decryptButton = new System.Windows.Forms.Button();
            this.maxLengthWordButton = new System.Windows.Forms.Button();
            this.minLengthWordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readDictionaryButton
            // 
            this.readDictionaryButton.Location = new System.Drawing.Point(256, 552);
            this.readDictionaryButton.Name = "readDictionaryButton";
            this.readDictionaryButton.Size = new System.Drawing.Size(155, 23);
            this.readDictionaryButton.TabIndex = 0;
            this.readDictionaryButton.Text = "IsExists";
            this.readDictionaryButton.UseVisualStyleBackColor = true;
            this.readDictionaryButton.Click += new System.EventHandler(this.ReadDictionaryButton_Click);
            // 
            // inputTextbox
            // 
            this.inputTextbox.Location = new System.Drawing.Point(256, 436);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(208, 20);
            this.inputTextbox.TabIndex = 1;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(256, 503);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(208, 20);
            this.outputTextBox.TabIndex = 2;
            // 
            // cipherLabel
            // 
            this.cipherLabel.AutoSize = true;
            this.cipherLabel.Location = new System.Drawing.Point(171, 68);
            this.cipherLabel.Name = "cipherLabel";
            this.cipherLabel.Size = new System.Drawing.Size(65, 13);
            this.cipherLabel.TabIndex = 3;
            this.cipherLabel.Text = "Enter Cipher";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 128);
            this.textBox1.TabIndex = 4;
            // 
            // plainTextBox
            // 
            this.plainTextBox.Location = new System.Drawing.Point(265, 237);
            this.plainTextBox.Multiline = true;
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(375, 128);
            this.plainTextBox.TabIndex = 6;
            // 
            // plainTextLabel
            // 
            this.plainTextLabel.AutoSize = true;
            this.plainTextLabel.Location = new System.Drawing.Point(171, 237);
            this.plainTextLabel.Name = "plainTextLabel";
            this.plainTextLabel.Size = new System.Drawing.Size(54, 13);
            this.plainTextLabel.TabIndex = 5;
            this.plainTextLabel.Text = "Plain Text";
            // 
            // checkExistanceLabel
            // 
            this.checkExistanceLabel.AutoSize = true;
            this.checkExistanceLabel.Location = new System.Drawing.Point(88, 436);
            this.checkExistanceLabel.Name = "checkExistanceLabel";
            this.checkExistanceLabel.Size = new System.Drawing.Size(148, 13);
            this.checkExistanceLabel.TabIndex = 7;
            this.checkExistanceLabel.Text = "Check Existance in Dictionary";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(171, 503);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "Found";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(347, 389);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(155, 23);
            this.decryptButton.TabIndex = 9;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // maxLengthWordButton
            // 
            this.maxLengthWordButton.Location = new System.Drawing.Point(438, 552);
            this.maxLengthWordButton.Name = "maxLengthWordButton";
            this.maxLengthWordButton.Size = new System.Drawing.Size(187, 23);
            this.maxLengthWordButton.TabIndex = 10;
            this.maxLengthWordButton.Text = "Max Length Plain Text";
            this.maxLengthWordButton.UseVisualStyleBackColor = true;
            this.maxLengthWordButton.Click += new System.EventHandler(this.MaxLengthWordButton_Click);
            // 
            // minLengthWordButton
            // 
            this.minLengthWordButton.Location = new System.Drawing.Point(643, 552);
            this.minLengthWordButton.Name = "minLengthWordButton";
            this.minLengthWordButton.Size = new System.Drawing.Size(187, 23);
            this.minLengthWordButton.TabIndex = 11;
            this.minLengthWordButton.Text = "Min Length Plain Text";
            this.minLengthWordButton.UseVisualStyleBackColor = true;
            this.minLengthWordButton.Click += new System.EventHandler(this.minLengthWordButton_Click);
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 625);
            this.Controls.Add(this.minLengthWordButton);
            this.Controls.Add(this.maxLengthWordButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.checkExistanceLabel);
            this.Controls.Add(this.plainTextBox);
            this.Controls.Add(this.plainTextLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cipherLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.readDictionaryButton);
            this.Name = "UserInput";
            this.Text = "Rana-Aujeszky-Gregory-Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readDictionaryButton;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label cipherLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox plainTextBox;
        private System.Windows.Forms.Label plainTextLabel;
        private System.Windows.Forms.Label checkExistanceLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button maxLengthWordButton;
        private System.Windows.Forms.Button minLengthWordButton;
    }
}

