using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_HiramTodd
{
	class DeskQuote
	{
		#region
		//Quote information
		public string CustomerName;
		public DateTime QuoteDate;
		public Desk Desk = new Desk();
		public int QuoteTotal;
		public int RushDays;
		#endregion

		#region
		private const int BASE_PRICE = 200;
		private const int THRESHOLD_SIZE = 1000;
		private const int THRESHOLD_RUSH = 2000;
		private const int PER_DRAWER_PRICE = 50;
		private const int PER_AREA_PRICE = 1;
		#endregion

		public DeskQuote(string customterName, DateTime quoteDate, int width, int depth, int drawers, Desk.Material material, int rushODays)
		{
			CustomerName = customterName;
			QuoteDate = quoteDate;
			Desk.Width = width;
			Desk.Depth = depth;
			Desk.Drawers = drawers;
			Desk.DeskMaterial = material;
			RushDays = rushODays;

			//Store and calculate area
			Desk.Area = Desk.Width * Desk.Depth;

		}

		// Get quote for desk
		public int quoteCalc()
		{
			QuoteTotal = BASE_PRICE + AreaCost() + DrawerCost() + (int)Desk.DeskMaterial + RushCost();
			return QuoteTotal;
		}

		// Get the area cost of desk
		private int AreaCost()
		{
			if (Desk.Area > THRESHOLD_SIZE)
			{
				return (Desk.Area - THRESHOLD_RUSH) * PER_DRAWER_PRICE;
			}
			else
			{
				return 0;
			}
		}

		// Get the cost of drawers
		private int DrawerCost()
		{
			int DrawerCost = Desk.Drawers * PER_AREA_PRICE;
			return DrawerCost;
		}

		//// Get cost of rush option
		//private int RushDays()
		//{
		//	int rushCost = 0;
		//}
	}

}
