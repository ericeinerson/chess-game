using ChessBoardModel;

namespace ChessBoardConsoleApp
{
    class Program
    {
        static Board myBoard = new Board(8,8);

        static void Main(string[] args)
        {
            
            PrintBoard(myBoard);

            Cell currentCell = SetCurrentCell();
            currentCell.CurrentlyOccupied = true;

            myBoard.MakingNextLegalMoves(currentCell, "king");

            PrintBoard(myBoard);

            Console.ReadLine();
        }

        private static Cell SetCurrentCell()
        {
            Console.WriteLine("Enter the current row number");
            int currentRow = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Enter the current column number");
            int currentColumn = int.Parse(Console.ReadLine()) - 1;

            myBoard.Grid[currentRow, currentColumn].CurrentlyOccupied = true;
            return myBoard.Grid[currentRow, currentColumn];

        }
        //show the empty chess board
        private static void PrintBoard(Board myBoard)
        {
            string fill = " "; 
            string minusesFragment = "---";
            string pipesFragment = string.Format(" {0} |", fill);

            //print the chess board to the console. Use X for the piece location
            for (int j = 0; j < myBoard.Columns; j++)
            {
                Console.Write("+");
                Console.Write(minusesFragment);
            }
            Console.Write("+");
            Console.WriteLine();
            for (int i = 0; i < myBoard.Rows; i++)
            {
                Console.Write("|");
                for (int j = 0; j < myBoard.Columns; j++)
                {
                    Cell c = myBoard.Grid[i, j];

                    if (c.CurrentlyOccupied == true)
                    {
                        fill = "X";
                    }
                    else if (c.LegalNextMove == true)
                    {
                        fill = "+";
                    }
                    
                    Console.Write(string.Format(" {0} |", fill));
                    fill = " ";
                }

                Console.WriteLine();

                for (int j = 0; j < myBoard.Columns; j++)
                {
                    Console.Write("+");
                    Console.Write(minusesFragment);
                }
                Console.Write("+");
                Console.WriteLine();
            }
            Console.WriteLine("==================");
        }
        //ask the user for an x and y coordinate where we will place a piece

        //calculate all legal moves for that piece

        //print the chess board. Use an X for occupancy

        //wait for another enter key press before closing the program

    }
}