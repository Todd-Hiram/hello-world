using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_HiramTodd
{
	class Desk
	{
		public int Width { get; set; }
		public int Depth { get; set; }
		public int NumberOfDrawers { get; set; }
		public string DesktopMaterals { get; set; }

		// Desk Constraints/Constants
		public const int MINWIDTH = 24;
		public const int MAXWIDTH = 96;
	}
}
