/* #1: Write a syntactically correct C# method definition called CountOdd.  The method should take an 
array of integers as it's parameter and should return the number of odd numbers in the array as a 
result.  For example, calling the function with an array containing 1, 3, 5, 4, 5, 2, 10, 7, 5, 7, 5 
should return 8 because there are 8 odd numbers in the array. */

private int CountOdd(int[] oddNumbers)
{
	oddCount = 0;
	
	foreach (int number in oddNumbers)
	{
		if (number % 2 != 0)
			oddCount++	
	}
	return oddCount;
}

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

/* #3: A palindrome is a word (or phrase) that reads the same forward as backward.  Examples of word 
palindromes in english are kayak, racecar, redder, madam, and refer.

Write a syntactically correct C# method definition called IsPalindrome.  The method should take a 
string that represents a word as a parameter and should return true if the word is a palindrome and 
false if it is not.  

For example:
madam is a palindrome
noon is a palindrome
apple is not a palindrome

You may assume that the parameter contains only lowercase characters, no spaces or punctuation.  

HINT:  You wrote a function in lab 2 that "reverses" a string.  It may be useful in the solution of 
this problem. 

FOR EXTRA CREDIT:  
allow both upper and lower case characters but ignore case when determining if a word is a palindrome.
allow punctuation and/or spaces but consider only alpha characters when determining if a word is a 
palindrome. */

private bool IsPalindrome(string word)
{
	bool palindrome = false;		
	
	palindrome = Reverse(word);		//This isn't right... I wanted to reverse the word and check if it's equal to the original word.
	
	if (word == palindrome)
		return true;
	
	return palindrome;
}

private string Reverse(string input)
{
	string output = "";

    for (int i = input.Length-1; i >= 0; i--)
        output += input[i];
    return output;
}

/* #4: Briefly describe the function and the significance of each of the numbered sections of code 
in this C# program. The code is taken from one solution for the click event handler shared by all 
of the cards in the Concentration game you created in lab 3. */

object sender = The first the object that generated the event; in this case a picture box… What
did the user click?

(PictureBox)sender = casting “sender” as a PictureBox, because sender is the most generic object.

(card.Name.Substring(4)) = using the substring method to get the character in index 4; gets the 
value in the index.

Index1 = cardIndex = assignment statement, assigning “cardIndex” to “index1.”

cards[cardIndex] = Going to array of filenames and getting the filename that matches with the 
PictureBox, and creating an image that gets shown in that PictureBox






