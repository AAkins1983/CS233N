// Here's the fixed version... Thank you so much!

private bool IsPalindrome(string word)
{
	bool palindrome = false;		
	string rWord = Reverse(word);	
	
	if (word == rWord)
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