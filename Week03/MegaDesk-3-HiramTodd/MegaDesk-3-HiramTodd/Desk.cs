﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_HiramTodd
{
	class Desk
	{
		//Matrials
		public enum Material
		{
			Oak = 200,
			Laminate = 100,
			Pine = 50,
			Rosewood = 300,
			Veneer = 125
		}

		//Desk Constraints
		public const int MINWIDTH = 24;
		public const int MAXWIDTH = 96;
		public const int MINDEPTH = 12;
		public const int MAXDEPTH = 48;

		#region
		// Desk Description
		public Material DeskMaterial { get; set; }
		public int Width { get; set; }
		public int Depth { get; set; }
		public int Drawers { get; set; }
		public int Area { get; set; }
		#endregion
	}
}
