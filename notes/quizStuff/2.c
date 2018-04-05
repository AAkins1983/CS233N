/* #2: Assume that you've been asked to create an 5 by 5 TicTacToe application.  The board is 
represented by a 5 by 5 rectangular array of characters.  Write a syntactically correct C# method 
definition called HasMatchingRow that can be used to determine if a player has a win in one of the 
rows on the board.  The method should take a rectangular array of characters, a row number and a 
character value as it's parameters and should return true or false as a result.  For example, calling 
the function with the following array, a row of 1 and O would return true. */

private bool HasMatchingRow(char[,] charArray, int row,  char symbol)
{
	char value = charArray[row, 0];
	for (int col = 1; col <= 5; col++)
	{
		if (value == "" || charArray[row, col] != value)
			return false;
	}
	return true;
}