using System;
namespace ChessBoardModel
{
	public class Board
	{
		public int Size { get; set; }
        public int Columns { get; set; }
        public int Rows { get; set; }
		public Cell[,] Grid { get; set; }

		//constructor
		public Board (int r, int c)
		{
			//initial board size is defined by s
            Columns = c;
            Rows = r;
			//create a new 2D array of type cell
			Grid = new Cell[Rows, Columns];
            
			//fill the 2D array with new cells, each with unique x and y coordinates
			for(int i = 0; i < Rows; i++)
			{
				for(int j = 0; j < Columns; j++)
				{
					Grid[i, j] = new Cell(i, j);
				}
			}
		}

        public void MakingNextLegalMoves(Cell currentCell, string chessPiece)
        {
            //step 1 - clear all previous legal moves
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Grid[i, j].LegalNextMove = false;
                    Grid[i, j].CurrentlyOccupied = false;
                }
            }
            //step 2 - find all legal moves and mark the cells as "legal"

            bool FilterOutOfBoundsMoves(int rowModfier, int colModifier)
            {
                try
                {
                    Grid[currentCell.RowNumber + rowModfier, currentCell.ColumnNumber + colModifier].LegalNextMove = true;
                    return true;
                }
                catch
                {
                    return false;
                }

            }

            void DetermineKnightMoves()
            {

                if (FilterOutOfBoundsMoves(2, 1) == true)
                {
                    Grid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(2, -1) == true)
                {
                    Grid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-2, 1) == true)
                {
                    Grid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-2, -1) == true)
                {
                    Grid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(1, 2) == true)
                {
                    Grid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(1, -2) == true)
                {
                    Grid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-1, 2) == true)
                {
                    Grid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-1, -2) == true)
                {
                    Grid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                }

            }

            void DetermineRookMoves()
            {

                if (FilterOutOfBoundsMoves(0, 1) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 1].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, 2) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 2].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, 3) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 3].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, 4) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 4].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, 5) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 5].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, 6) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 6].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, 7) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 7].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, 8) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 8].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(1, 0) == true)
                {
                    Grid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(2, 0) == true)
                {
                    Grid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(3, 0) == true)
                {
                    Grid[currentCell.RowNumber + 3, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(4, 0) == true)
                {
                    Grid[currentCell.RowNumber + 4, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(5, 0) == true)
                {
                    Grid[currentCell.RowNumber + 5, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(6, 0) == true)
                {
                    Grid[currentCell.RowNumber + 6, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(7, 0) == true)
                {
                    Grid[currentCell.RowNumber + 7, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(8, 0) == true)
                {
                    Grid[currentCell.RowNumber + 8, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, -1) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 1].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, -2) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 2].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, -3) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 3].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, -4) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 4].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, -5) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 5].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, -6) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 6].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, -7) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 7].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, -8) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 8].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-1, 0) == true)
                {
                    Grid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-2, 0) == true)
                {
                    Grid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-3, 0) == true)
                {
                    Grid[currentCell.RowNumber - 3, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-4, 0) == true)
                {
                    Grid[currentCell.RowNumber - 4, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-5, 0) == true)
                {
                    Grid[currentCell.RowNumber - 5, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-6, 0) == true)
                {
                    Grid[currentCell.RowNumber - 6, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-7, 0) == true)
                {
                    Grid[currentCell.RowNumber - 7, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-8, 0) == true)
                {
                    Grid[currentCell.RowNumber - 8, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

            }

            void DetermineBishopMoves()
            {

                if (FilterOutOfBoundsMoves(1, 1) == true)
                {
                    Grid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(2, 2) == true)
                {
                    Grid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 2].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(3, 3) == true)
                {
                    Grid[currentCell.RowNumber + 3, currentCell.ColumnNumber + 3].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(4, 4) == true)
                {
                    Grid[currentCell.RowNumber + 4, currentCell.ColumnNumber + 4].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(5, 5) == true)
                {
                    Grid[currentCell.RowNumber + 5, currentCell.ColumnNumber + 5].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(6, 6) == true)
                {
                    Grid[currentCell.RowNumber + 6, currentCell.ColumnNumber + 6].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(7, 7) == true)
                {
                    Grid[currentCell.RowNumber + 7, currentCell.ColumnNumber + 7].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(8, 8) == true)
                {
                    Grid[currentCell.RowNumber + 8, currentCell.ColumnNumber + 8].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-1, 1) == true)
                {
                    Grid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-2, 2) == true)
                {
                    Grid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 2].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-3, 3) == true)
                {
                    Grid[currentCell.RowNumber - 3, currentCell.ColumnNumber + 3].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-4, 4) == true)
                {
                    Grid[currentCell.RowNumber - 4, currentCell.ColumnNumber + 4].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-5, 5) == true)
                {
                    Grid[currentCell.RowNumber - 5, currentCell.ColumnNumber + 5].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-6, 6) == true)
                {
                    Grid[currentCell.RowNumber - 6, currentCell.ColumnNumber + 6].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-7, 7) == true)
                {
                    Grid[currentCell.RowNumber - 7, currentCell.ColumnNumber + 7].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-8, 8) == true)
                {
                    Grid[currentCell.RowNumber - 8, currentCell.ColumnNumber + 8].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(1, -1) == true)
                {
                    Grid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(2, -2) == true)
                {
                    Grid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 2].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(3, -3) == true)
                {
                    Grid[currentCell.RowNumber + 3, currentCell.ColumnNumber - 3].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(4, -4) == true)
                {
                    Grid[currentCell.RowNumber + 4, currentCell.ColumnNumber - 4].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(5, -5) == true)
                {
                    Grid[currentCell.RowNumber + 5, currentCell.ColumnNumber - 5].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(6, -6) == true)
                {
                    Grid[currentCell.RowNumber + 6, currentCell.ColumnNumber - 6].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(7, -7) == true)
                {
                    Grid[currentCell.RowNumber + 7, currentCell.ColumnNumber - 7].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(8, -8) == true)
                {
                    Grid[currentCell.RowNumber + 8, currentCell.ColumnNumber - 8].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-1, -1) == true)
                {
                    Grid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-2, -2) == true)
                {
                    Grid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 2].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-3, -3) == true)
                {
                    Grid[currentCell.RowNumber - 3, currentCell.ColumnNumber - 3].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-4, -4) == true)
                {
                    Grid[currentCell.RowNumber - 4, currentCell.ColumnNumber - 4].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-5, -5) == true)
                {
                    Grid[currentCell.RowNumber - 5, currentCell.ColumnNumber - 5].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-6, -6) == true)
                {
                    Grid[currentCell.RowNumber - 6, currentCell.ColumnNumber - 6].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-7, -7) == true)
                {
                    Grid[currentCell.RowNumber - 7, currentCell.ColumnNumber - 7].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-8, -8) == true)
                {
                    Grid[currentCell.RowNumber - 8, currentCell.ColumnNumber - 8].LegalNextMove = true;
                }
            }

            void DetermineKingMoves()
            {
                if (FilterOutOfBoundsMoves(1, 1) == true)
                {
                    Grid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(1, 0) == true)
                {
                    Grid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(1, -1) == true)
                {
                    Grid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, 1) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 1].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(0, -1) == true)
                {
                    Grid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 1].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-1, 1) == true)
                {
                    Grid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-1, 0) == true)
                {
                    Grid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
                }

                if (FilterOutOfBoundsMoves(-1, -1) == true)
                {
                    Grid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                }

            }



            switch (chessPiece)
			{
				case "Knight":
                    DetermineKnightMoves();
                    break;
                case "king":
                    DetermineKingMoves();
                    break;
                case "rook":
                    DetermineRookMoves();
                    break;
                case "bishop":
                    DetermineBishopMoves();
                    break;
                case "queen":
                    DetermineBishopMoves();
                    DetermineRookMoves();
                    break;
				default:
					break;

            }
            Grid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;
		}
	}
}

