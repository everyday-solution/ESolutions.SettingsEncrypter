namespace ESolutions.SettingsEncrypter
{
	partial class MainForm
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
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label4;
			System.Windows.Forms.Label label5;
			this.encryptButton = new System.Windows.Forms.Button();
			this.secretTextBox = new System.Windows.Forms.TextBox();
			this.ivTextBox = new System.Windows.Forms.TextBox();
			this.clearTextTextBox = new System.Windows.Forms.TextBox();
			this.encryptedTextBox = new System.Windows.Forms.TextBox();
			this.secretGuidButton = new System.Windows.Forms.Button();
			this.ivGuidButton = new System.Windows.Forms.Button();
			this.decryptedTextBox = new System.Windows.Forms.TextBox();
			this.decryptButton = new System.Windows.Forms.Button();
			this.copyDecryptedButton = new System.Windows.Forms.Button();
			this.copyEncryptedButton = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(24, 29);
			label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(74, 25);
			label1.TabIndex = 2;
			label1.Text = "Secret";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(24, 79);
			label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(31, 25);
			label2.TabIndex = 4;
			label2.Text = "IV";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(24, 129);
			label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(112, 25);
			label3.TabIndex = 6;
			label3.Text = "Clear-Text";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(24, 235);
			label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(109, 25);
			label4.TabIndex = 8;
			label4.Text = "Encrypted";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(24, 340);
			label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(110, 25);
			label5.TabIndex = 12;
			label5.Text = "Decrypted";
			// 
			// encryptButton
			// 
			this.encryptButton.Location = new System.Drawing.Point(188, 173);
			this.encryptButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.encryptButton.Name = "encryptButton";
			this.encryptButton.Size = new System.Drawing.Size(150, 44);
			this.encryptButton.TabIndex = 4;
			this.encryptButton.Text = "Encrypt";
			this.encryptButton.UseVisualStyleBackColor = true;
			this.encryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
			// 
			// secretTextBox
			// 
			this.secretTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.secretTextBox.Location = new System.Drawing.Point(188, 23);
			this.secretTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.secretTextBox.Name = "secretTextBox";
			this.secretTextBox.Size = new System.Drawing.Size(1163, 31);
			this.secretTextBox.TabIndex = 1;
			// 
			// ivTextBox
			// 
			this.ivTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ivTextBox.Location = new System.Drawing.Point(188, 73);
			this.ivTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.ivTextBox.Name = "ivTextBox";
			this.ivTextBox.Size = new System.Drawing.Size(1163, 31);
			this.ivTextBox.TabIndex = 2;
			// 
			// clearTextTextBox
			// 
			this.clearTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.clearTextTextBox.Location = new System.Drawing.Point(188, 123);
			this.clearTextTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.clearTextTextBox.Name = "clearTextTextBox";
			this.clearTextTextBox.Size = new System.Drawing.Size(1301, 31);
			this.clearTextTextBox.TabIndex = 3;
			// 
			// encryptedTextBox
			// 
			this.encryptedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.encryptedTextBox.Location = new System.Drawing.Point(188, 229);
			this.encryptedTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.encryptedTextBox.Name = "encryptedTextBox";
			this.encryptedTextBox.Size = new System.Drawing.Size(1163, 31);
			this.encryptedTextBox.TabIndex = 5;
			// 
			// secretGuidButton
			// 
			this.secretGuidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.secretGuidButton.Location = new System.Drawing.Point(1367, 19);
			this.secretGuidButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.secretGuidButton.Name = "secretGuidButton";
			this.secretGuidButton.Size = new System.Drawing.Size(126, 44);
			this.secretGuidButton.TabIndex = 9;
			this.secretGuidButton.Text = "Guid";
			this.secretGuidButton.UseVisualStyleBackColor = true;
			this.secretGuidButton.Click += new System.EventHandler(this.SecretGuidButton_Click);
			// 
			// ivGuidButton
			// 
			this.ivGuidButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ivGuidButton.Location = new System.Drawing.Point(1367, 69);
			this.ivGuidButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.ivGuidButton.Name = "ivGuidButton";
			this.ivGuidButton.Size = new System.Drawing.Size(126, 44);
			this.ivGuidButton.TabIndex = 10;
			this.ivGuidButton.Text = "Guid";
			this.ivGuidButton.UseVisualStyleBackColor = true;
			this.ivGuidButton.Click += new System.EventHandler(this.IvGuidButton_Click);
			// 
			// decryptedTextBox
			// 
			this.decryptedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.decryptedTextBox.Location = new System.Drawing.Point(188, 335);
			this.decryptedTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.decryptedTextBox.Name = "decryptedTextBox";
			this.decryptedTextBox.Size = new System.Drawing.Size(1163, 31);
			this.decryptedTextBox.TabIndex = 11;
			// 
			// decryptButton
			// 
			this.decryptButton.Location = new System.Drawing.Point(188, 279);
			this.decryptButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.decryptButton.Name = "decryptButton";
			this.decryptButton.Size = new System.Drawing.Size(150, 44);
			this.decryptButton.TabIndex = 13;
			this.decryptButton.Text = "Decrypt";
			this.decryptButton.UseVisualStyleBackColor = true;
			this.decryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
			// 
			// copyDecryptedButton
			// 
			this.copyDecryptedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.copyDecryptedButton.Location = new System.Drawing.Point(1367, 331);
			this.copyDecryptedButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.copyDecryptedButton.Name = "copyDecryptedButton";
			this.copyDecryptedButton.Size = new System.Drawing.Size(126, 44);
			this.copyDecryptedButton.TabIndex = 15;
			this.copyDecryptedButton.Text = "Copy";
			this.copyDecryptedButton.UseVisualStyleBackColor = true;
			this.copyDecryptedButton.Click += new System.EventHandler(this.CopyDecryptedButton_Click);
			// 
			// copyEncryptedButton
			// 
			this.copyEncryptedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.copyEncryptedButton.Location = new System.Drawing.Point(1367, 225);
			this.copyEncryptedButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.copyEncryptedButton.Name = "copyEncryptedButton";
			this.copyEncryptedButton.Size = new System.Drawing.Size(126, 44);
			this.copyEncryptedButton.TabIndex = 14;
			this.copyEncryptedButton.Text = "Copy";
			this.copyEncryptedButton.UseVisualStyleBackColor = true;
			this.copyEncryptedButton.Click += new System.EventHandler(this.CopyEncryptedButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1517, 437);
			this.Controls.Add(this.copyDecryptedButton);
			this.Controls.Add(this.copyEncryptedButton);
			this.Controls.Add(this.decryptButton);
			this.Controls.Add(label5);
			this.Controls.Add(this.decryptedTextBox);
			this.Controls.Add(this.ivGuidButton);
			this.Controls.Add(this.secretGuidButton);
			this.Controls.Add(label4);
			this.Controls.Add(this.encryptedTextBox);
			this.Controls.Add(label3);
			this.Controls.Add(this.clearTextTextBox);
			this.Controls.Add(label2);
			this.Controls.Add(this.ivTextBox);
			this.Controls.Add(label1);
			this.Controls.Add(this.secretTextBox);
			this.Controls.Add(this.encryptButton);
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "MainForm";
			this.Text = "Settings-Encrypter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button encryptButton;
		private System.Windows.Forms.TextBox secretTextBox;
		private System.Windows.Forms.TextBox ivTextBox;
		private System.Windows.Forms.TextBox clearTextTextBox;
		private System.Windows.Forms.TextBox encryptedTextBox;
		private System.Windows.Forms.Button secretGuidButton;
		private System.Windows.Forms.Button ivGuidButton;
		private System.Windows.Forms.TextBox decryptedTextBox;
		private System.Windows.Forms.Button decryptButton;
		private System.Windows.Forms.Button copyDecryptedButton;
		private System.Windows.Forms.Button copyEncryptedButton;
	}
}

