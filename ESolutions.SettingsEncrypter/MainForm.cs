using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESolutions;
using ESolutions.Security.Cryptography;

namespace ESolutions.SettingsEncrypter
{
	public partial class MainForm : Form
	{
		//Constructors
		#region MainForm
		public MainForm()
		{
			InitializeComponent();
		}
		#endregion

		//Methods
		#region EncryptButton_Click
		private void EncryptButton_Click(object sender, EventArgs e)
		{
			try
			{
				Rijndael crypter = new Rijndael
				{
					EncryptionSecret = this.secretTextBox.Text,
					EncryptionIV = this.ivTextBox.Text
				};
				this.encryptedTextBox.Text = crypter.Encrypt(this.clearTextTextBox.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
		}
		#endregion

		#region SecretGuidButton_Click
		private void SecretGuidButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.secretTextBox.Text = Guid.NewGuid().ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
		}
		#endregion

		#region IvGuidButton_Click
		private void IvGuidButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.ivTextBox.Text = Guid.NewGuid().ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
		}
		#endregion

		#region DecryptButton_Click
		private void DecryptButton_Click(object sender, EventArgs e)
		{
			try
			{
				Rijndael crypter = new Rijndael
				{
					EncryptionSecret = this.secretTextBox.Text,
					EncryptionIV = this.ivTextBox.Text
				};
				this.decryptedTextBox.Text = crypter.Decrypt(this.encryptedTextBox.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
		}
		#endregion

		#region CopyEncryptedButton_Click
		private void CopyEncryptedButton_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(this.encryptedTextBox.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
		}
		#endregion

		#region CopyDecryptedButton_Click
		private void CopyDecryptedButton_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(this.decryptedTextBox.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
		}
		#endregion
	}
}
