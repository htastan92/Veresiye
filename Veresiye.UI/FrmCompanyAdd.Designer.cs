﻿namespace Veresiye.UI
{
	partial class FrmCompanyAdd
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtCompanyName = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtRegion = new System.Windows.Forms.TextBox();
			this.btnQuit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Firma Adı :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Telefon :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(65, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Şehir :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(62, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Bölge :";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(108, 125);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Kaydet";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// txtCompanyName
			// 
			this.txtCompanyName.Location = new System.Drawing.Point(108, 22);
			this.txtCompanyName.Name = "txtCompanyName";
			this.txtCompanyName.Size = new System.Drawing.Size(163, 20);
			this.txtCompanyName.TabIndex = 5;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(108, 48);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(163, 20);
			this.txtPhone.TabIndex = 6;
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(108, 73);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(163, 20);
			this.txtCity.TabIndex = 7;
			// 
			// txtRegion
			// 
			this.txtRegion.Location = new System.Drawing.Point(108, 99);
			this.txtRegion.Name = "txtRegion";
			this.txtRegion.Size = new System.Drawing.Size(163, 20);
			this.txtRegion.TabIndex = 8;
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(196, 125);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(75, 23);
			this.btnQuit.TabIndex = 9;
			this.btnQuit.Text = "Kapat";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
			// 
			// FrmCompanyAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 196);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.txtRegion);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtCompanyName);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmCompanyAdd";
			this.Text = "FrmCompanyAdd";
			this.Load += new System.EventHandler(this.FrmCompanyAdd_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtCompanyName;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtRegion;
		private System.Windows.Forms.Button btnQuit;
	}
}