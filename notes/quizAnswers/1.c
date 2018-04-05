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