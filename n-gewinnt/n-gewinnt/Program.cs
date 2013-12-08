using System;
using System.Diagnostics;

class nGewinnt {

	static char checkWinner(char[,]  board, uint n) {
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

		a = nSameInARow(board, n, numRows, numCols);
		if (a != 'N') return a;
		a = nSameInACol(board, n, numRows, numCols);
		if (a != 'N') return a;
		a = nSameInFirstDiagonal(board, n, numRows, numCols);
		if (a != 'N') return a;
		a = nSameInSecondDiagonal(board, n, numRows, numCols);
		if (a != 'N') return a;
		return 'N';
	}

	static char nSameInARow(char[,] board, uint n, int numRows, int numCols) {
		for (int startRow = 0; startRow <= numRows-1; startRow++) {
			for (int startCol = 0; startCol <= numCols-n; startCol++) {
				int actCol = startCol;
				int actRow = startRow;
				char firstChar = board[actRow,actCol];
				if (firstChar != ' ') {
					int same = 0;
					while  ((actRow < numRows) && (actCol < numCols)  && (board[actRow,actCol] == firstChar)) {
						same++;
						if (same == n) return firstChar;
						actCol++;
					}
				}
			}
		}
		return 'N';
	}

	static char nSameInACol(char[,] board, uint n, int numRows, int numCols) {	
		for (int startRow = 0; startRow <= numRows-n; startRow++) {
			for (int startCol = 0; startCol <= numCols-1; startCol++) {
				int actRow = startRow;
				int actCol = startCol;
				char firstChar = board[actRow,actCol];
				if (firstChar != ' ') {
					int same = 0;
					while ((actRow < numRows) && (actCol < numCols)  && (board[actRow,actCol] == firstChar)) {
						same++;
						if (same == n) return firstChar;
						actRow++;
					}
				}
			}
		}
		return 'N';
	}

	static char nSameInFirstDiagonal(char[,] board, uint n, int numRows, int numCols) {
		for (int startRow = 0; startRow <= numRows-n; startRow++) {
			for (int startCol = 0; startCol <= numCols-n; startCol++) {
				int actRow = startRow;
				int actCol = startCol;
				char firstChar = board[actRow,actCol];
				if (firstChar != ' ') {
					int same = 0;
					while ((actRow < numRows) && (actCol < numCols) && (board[actRow,actCol] == firstChar)) {
						same++;
						if (same == n) return firstChar;
						actRow++;
						actCol++;
					}
				}
			}
		}
		return 'N';
	}

	static char nSameInSecondDiagonal(char[,] board, uint n, int numRows, int numCols) {
		for (int startRow = numRows-1; startRow >= n-1; startRow--) {
			for (int startCol = 0; startCol <= numCols-n; startCol++) {
				int actRow = startRow;
				int actCol = startCol;
				char firstChar = board[actRow,actCol];
				if (firstChar != ' ') {
					int same = 0;
					while ((actRow < numRows) && (actCol < numCols) && (board[actRow,actCol] == firstChar)) {
						same++;
						if (same == n) return firstChar;
						actRow--;
						actCol++;
					}
				}
			}
		}
		return 'N';
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