﻿namespace MegaDesk_3_HiramTodd
{
	partial class MainMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
			this.AddNewQuote = new System.Windows.Forms.Button();
			this.ViewQuotes = new System.Windows.Forms.Button();
			this.SearchQuotes = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.MainMenuLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// AddNewQuote
			// 
			this.AddNewQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddNewQuote.Location = new System.Drawing.Point(40, 125);
			this.AddNewQuote.Name = "AddNewQuote";
			this.AddNewQuote.Size = new System.Drawing.Size(200, 50);
			this.AddNewQuote.TabIndex = 0;
			this.AddNewQuote.Text = "Add New Quote";
			this.AddNewQuote.UseVisualStyleBackColor = true;
			this.AddNewQuote.Click += new System.EventHandler(this.AddNewQuote_Click);
			// 
			// ViewQuotes
			// 
			this.ViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ViewQuotes.Location = new System.Drawing.Point(40, 191);
			this.ViewQuotes.Name = "ViewQuotes";
			this.ViewQuotes.Size = new System.Drawing.Size(200, 50);
			this.ViewQuotes.TabIndex = 1;
			this.ViewQuotes.Text = "View Quotes";
			this.ViewQuotes.UseVisualStyleBackColor = true;
			this.ViewQuotes.Click += new System.EventHandler(this.ViewQuotes_Click);
			// 
			// SearchQuotes
			// 
			this.SearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchQuotes.Location = new System.Drawing.Point(40, 259);
			this.SearchQuotes.Name = "SearchQuotes";
			this.SearchQuotes.Size = new System.Drawing.Size(200, 50);
			this.SearchQuotes.TabIndex = 2;
			this.SearchQuotes.Text = "Search Quotes";
			this.SearchQuotes.UseVisualStyleBackColor = true;
			this.SearchQuotes.Click += new System.EventHandler(this.SearchQuotes_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExitButton.Location = new System.Drawing.Point(40, 328);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(200, 50);
			this.ExitButton.TabIndex = 3;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(332, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(302, 389);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// MainMenuLabel
			// 
			this.MainMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuLabel.Location = new System.Drawing.Point(65, 32);
			this.MainMenuLabel.Name = "MainMenuLabel";
			this.MainMenuLabel.Size = new System.Drawing.Size(150, 38);
			this.MainMenuLabel.TabIndex = 5;
			this.MainMenuLabel.Text = "Main Menu";
			this.MainMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 450);
			this.Controls.Add(this.MainMenuLabel);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.SearchQuotes);
			this.Controls.Add(this.ViewQuotes);
			this.Controls.Add(this.AddNewQuote);
			this.Name = "MainMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MegaDesk";
			this.Load += new System.EventHandler(this.MainMenu_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button AddNewQuote;
		private System.Windows.Forms.Button ViewQuotes;
		private System.Windows.Forms.Button SearchQuotes;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label MainMenuLabel;
	}
}

