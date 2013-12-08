using System;
using System.Diagnostics;

class nGewinnt {

	static char checkWinner(char[,]  board, int n) {
		int numRows = board.GetLength(0);
		int numCols = board.GetLength(1);

		if ((n > numRows) || (n > numCols)) {
			Console.WriteLine("Nicht möglich: Board ist zu klein.");
			return ' ';
		}

		if (n <= 0) {
			Console.WriteLine("Es muss n > 1 sein !!!");
			return ' ';
		}
		char a;

		a = nSame(board, n, numRows, numCols, true, 0, 0, numRows-1, numCols-n, 0, 1);  //rows
		if (a != 'N') return a;

		a = nSame(board, n, numRows, numCols, true, 0,  0, numRows-n, numCols-1, 1, 0); // cols
		if (a != 'N') return a;

		a = nSame(board, n, numRows, numCols, true, 0, 0, numRows-n, numCols-n, 1, 1); // first diagonal (left top - right bottom)
		if (a != 'N') return a;

		a = nSame(board, n, numRows, numCols, false, numRows-1, 0, n-1, numCols-n, -1, 1); // second diagonal (left bottom - right top)
		if (a != 'N') return a;

		return 'N';
	}

	static char nSame(
		char[,] board, 
		int n,  
		int numRows,  //how many rows in the board
		int numCols,  //how many cols in the board
		bool up,  //flag if the startRow variable of the outer loop goes up or down
		int initialStartRow, //where to start the search for identical stones
		int initialStartCol, 
		int lastStartRow, // where to stop the search for identical stones
		int lastStartCol, 
		int actRowChange,  //in which direction to search
		int actColChange
	) {

		int startRowChange = 1;
		if (!up) startRowChange = -1;

		for (int startRow = initialStartRow; condition(startRow, lastStartRow, up); startRow = startRow + startRowChange) {
			for (int startCol = initialStartCol; startCol <= lastStartCol; startCol++) {
				int actCol = startCol;
				int actRow = startRow;
				char firstChar = board[actRow,actCol];
				if (firstChar != ' ') {
					int same = 0;
					while ((actRow < numRows) && (actCol < numCols) && (board[actRow,actCol] == firstChar)) {
						same++;
						if (same == n) return firstChar;
						actRow = actRow + actRowChange;
						actCol = actCol + actColChange;
					}
				}
			}
		}
		return 'N';
	}


	static bool condition(int startRow, int lastStartRow, bool up) {
		if (up) return startRow <= lastStartRow;
		else return startRow >= lastStartRow;
	}

	static void Main() {
		char[,] board0 = {{'X', 'X', 'X'},
			{'X', 'O', ' '},
			{'X', 'O', 'O'}
		};


		char[,] board1 = {{'X', ' ', 'O'},
			{'O', 'O', ' '},
			{'X', ' ', 'X'}
		};


		char[,] board2 = {{' ', ' ', 'O', 'X'},
			{'X', 'O', ' ', ' '},
			{' ', 'O', 'O', 'O'}
		};


		char[,] board3 = {{'X', 'X', 'O', 'X'},
			{'O', 'O', ' ', ' '},
			{'X', ' ', 'X', 'O'},
			{' ', ' ', 'O', 'O'}
		};

		char[,] board4 = {{' ', 'X', 'O', 'X'},
			{'X', ' ', ' ', ' '},
			{' ', 'O', 'X', 'O'},
			{' ', 'O', 'O', ' '}
		};

		char[,] board5 = {{' ', 'X', 'O', 'O'},
			{'X', 'O', ' ', 'X'},
			{' ', ' ', 'X', 'X'},
			{'X', 'O', 'O', 'X'},
			{'X', 'O', 'O', 'X'}
		};
		char[,] board6 = {{' ', 'X', ' ', 'O'},
			{'X', 'O', 'O', 'X'},
			{' ', ' ', 'O', ' '},
			{'X', 'O', 'O', 'X'},
			{'X', 'O', ' ', 'X'}
		};

		char[,] board7 = {{' ', ' ', ' ', ' '},
			{'X', 'O', ' ', 'X'},
			{' ', ' ', ' ', ' '},
			{' ', ' ', ' ', ' '},
			{'X', 'O', ' ', 'X'}
		};

		char[,] board8 = {{'O', ' ', ' ', ' ', 'X'},
			{'O', 'O', ' ', 'X', 'O'},
			{' ', 'X', ' ', ' ', 'X'},
			{'O', ' ', 'X', ' ', 'O'},
			{'X', 'O', ' ', 'X', 'X'}
		};		

		char[,] board9 = {{'O', ' ', ' ', ' ', 'X'},
			{'O', 'O', 'O', 'X', 'O'},
			{' ', 'X', ' ', 'O', 'X'},
			{'O', ' ', ' ', ' ', 'O'},
			{'X', 'O', ' ', 'X', 'X'}
		};	

		char[,] board10 = {{'O', 'O', ' ', ' ', 'X'},
			{'O', 'O', 'O', 'X', 'O'},
			{' ', 'X', ' ', 'O', 'X'},
			{'O', ' ', ' ', ' ', 'O'},
			{'X', 'O', ' ', 'X', 'X'}
		};	

		char[,] board11 = {{'O', 'O', ' ', 'X', 'X'},
			{'O', 'O', 'X', 'X', 'O'},
			{' ', 'X', ' ', 'O', 'X'},
			{'O', ' ', ' ', ' ', 'O'},
			{'X', 'O', ' ', 'X', 'X'}
		};	
		char[,] board12 = {{'O', 'O', ' ', 'X', 'X'},
			{'O', 'O', ' ', 'X', ' '},
			{' ', 'X', ' ', 'O', 'X'},
			{'O', ' ', 'O', ' ', 'O'},
			{'X', 'O', ' ', 'X', 'X'}
		};	

		char[,] board13 = {{'O', 'O', ' ', 'X', 'X'},
			{'O', 'O', ' ', 'O', ' '},
			{' ', 'X', 'O', 'O', 'X'},
			{'O', 'O', 'O', ' ', 'O'},
			{'X', ' ', ' ', 'X', 'X'}
		};	

		char[,] board14 = {{'O', 'O', ' ', 'X', 'X'},
			{'O', 'O', ' ', 'O', ' '},
			{' ', 'X', 'X', 'O', 'X'},
			{'O', ' ', 'O', 'X', 'O'},
			{'X', ' ', 'X', 'X', ' '}
		};	

		char[,] board15 = {{'O', 'O', ' ', 'X', 'O'},
			{'O', ' ', ' ', 'O', ' '},
			{' ', 'X', 'O', 'O', 'X'},
			{'O', 'X', 'O', ' ', 'O'},
			{'X', ' ', 'X', 'X', ' '}
		};

		Console.WriteLine(checkWinner(board0, 3) == 'X');
		Console.WriteLine(checkWinner(board1, 3) == 'N');
		Console.WriteLine(checkWinner(board1, 2) == 'O');
		Console.WriteLine(checkWinner(board2, 3) == 'O');
		Console.WriteLine(checkWinner(board3, 3) == 'N');
		Console.WriteLine(checkWinner(board4, 2) == 'O');
		Console.WriteLine(checkWinner(board5, 4) == 'X');
		Console.WriteLine(checkWinner(board6, 3) == 'O');
		Console.WriteLine(checkWinner(board7, 3) == 'N');
		Console.WriteLine(checkWinner(board8, 4) == 'N');
		Console.WriteLine(checkWinner(board9, 3) == 'O');
		Console.WriteLine(checkWinner(board10, 4) == 'O');
		Console.WriteLine(checkWinner(board11, 3) == 'X');
		Console.WriteLine(checkWinner(board12, 3) == 'O');
		Console.WriteLine(checkWinner(board13, 3) == 'O');
		Console.WriteLine(checkWinner(board14, 3) == 'X');
		Console.WriteLine(checkWinner(board15, 3) == 'O');

	}

}