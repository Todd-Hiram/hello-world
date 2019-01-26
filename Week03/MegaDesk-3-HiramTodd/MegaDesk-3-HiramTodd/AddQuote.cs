using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_HiramTodd
{
	public partial class AddQuote : Form
	{
		#region
		public string CustomerName = String.Empty;
		Desk.Material Material;
		private int DeskWidth = 0;
		private int DeskDepth = 0;
		private int NumDrawers = 0;
		private int RushDays = 0;
		private int TotalQuote;
		#endregion

/*************************************** Control Validating ***************************************************************************/
		
/*************************************************************************************************************************/
		public AddQuote()
		{
			InitializeComponent();
		}

		private void AddQuote_Load(object sender, EventArgs e)
		{

		}

		private void cancelQuote_Click(object sender, EventArgs e)
		{
			var mainMenu = (MainMenu)Tag;
			mainMenu.Show();
			Close();
		}

		private void DateQuoteLabel_Click(object sender, EventArgs e)
		{

		}

		private void rushOrderLabel_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

		private void rushdateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

		private void rushDateLabel_Click(object sender, EventArgs e)
		{

		}

		private void rushOcomboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void submitButton_Click(object sender, EventArgs e)
		{

		}
	}
}
