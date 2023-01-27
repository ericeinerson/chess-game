using System;
namespace ChessBoardModel
{
	public class Cell
	{
		public Cell(int x, int y)
		{
			RowNumber = x;
			ColumnNumber = y;
		}
		public int RowNumber { get; set; }
		public int ColumnNumber { get; set; }
		public bool CurrentlyOccupied { get; set; }
		public bool LegalNextMove { get; set; }
	}
}

