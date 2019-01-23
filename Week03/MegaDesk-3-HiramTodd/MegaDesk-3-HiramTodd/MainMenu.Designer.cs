namespace MegaDesk_3_HiramTodd
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
			this.addNewQuoteButton = new System.Windows.Forms.Button();
			this.viewQuotesButton = new System.Windows.Forms.Button();
			this.SearchQuotesButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// addNewQuoteButton
			// 
			this.addNewQuoteButton.BackColor = System.Drawing.SystemColors.ControlDark;
			this.addNewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNewQuoteButton.Location = new System.Drawing.Point(12, 12);
			this.addNewQuoteButton.Name = "addNewQuoteButton";
			this.addNewQuoteButton.Size = new System.Drawing.Size(200, 50);
			this.addNewQuoteButton.TabIndex = 0;
			this.addNewQuoteButton.Text = "Add New Quote";
			this.addNewQuoteButton.UseVisualStyleBackColor = false;
			this.addNewQuoteButton.Click += new System.EventHandler(this.addNewQuoteButton_Click);
			// 
			// viewQuotesButton
			// 
			this.viewQuotesButton.BackColor = System.Drawing.SystemColors.ControlDark;
			this.viewQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.viewQuotesButton.Location = new System.Drawing.Point(12, 68);
			this.viewQuotesButton.Name = "viewQuotesButton";
			this.viewQuotesButton.Size = new System.Drawing.Size(200, 50);
			this.viewQuotesButton.TabIndex = 1;
			this.viewQuotesButton.Text = "View Quotes";
			this.viewQuotesButton.UseVisualStyleBackColor = false;
			this.viewQuotesButton.Click += new System.EventHandler(this.viewQuotesButton_Click);
			// 
			// SearchQuotesButton
			// 
			this.SearchQuotesButton.BackColor = System.Drawing.SystemColors.ControlDark;
			this.SearchQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchQuotesButton.Location = new System.Drawing.Point(12, 124);
			this.SearchQuotesButton.Name = "SearchQuotesButton";
			this.SearchQuotesButton.Size = new System.Drawing.Size(200, 50);
			this.SearchQuotesButton.TabIndex = 2;
			this.SearchQuotesButton.Text = "Search Quotes";
			this.SearchQuotesButton.UseVisualStyleBackColor = false;
			this.SearchQuotesButton.Click += new System.EventHandler(this.SearchQuotesButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.BackColor = System.Drawing.SystemColors.ControlDark;
			this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.Location = new System.Drawing.Point(12, 180);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(200, 50);
			this.exitButton.TabIndex = 3;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(245, 68);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(501, 335);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.SearchQuotesButton);
			this.Controls.Add(this.viewQuotesButton);
			this.Controls.Add(this.addNewQuoteButton);
			this.Name = "MainMenu";
			this.Text = "MegaDesk";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addNewQuoteButton;
		private System.Windows.Forms.Button viewQuotesButton;
		private System.Windows.Forms.Button SearchQuotesButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

