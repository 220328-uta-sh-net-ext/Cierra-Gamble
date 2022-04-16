// Challenge

/*
ALSO REMEMBER
APPLICATION > ASSEMBLIES > NAMESPACE > CLASS(ES) WHICH HAVE FUNCTIONS AND ATTRIBUTES/FEATURES/VARIABLES/METHODS
*/

/*
Code challenges throughout these modules will reinforce what you've learned and help you gain some confidence before continuing on.
Heads or tails challenge
In this challenge, you'll flip a coin to display either heads or tails. This is a perfect scenario for the conditional operator.
			 Note
If you've not followed along with these C# learning paths sequentially, take a moment to familiarize yourself with the Random class and its Next() method by reviewing the unit Calling different kinds of methods in the .NET Class Library.
*/

// Write code in the .NET Editor to display the result of a coin flip

/*
Use the Random class to generate a value. Based on the value, use the conditional operator to display either heads or tails. (USE CALLING METHOD NOTES FOR THIS)
	There should be a 50% chance that the result is either heads or tails.
	You should be able to accomplish the desired result in three lines of code or less.
Whether you get stuck and need to peek at the solution or you finish successfully, continue on to view a solution to this challenge.
*/

// IT SHOULD LOOK SOMETHING LIKE THIS

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

// 		OR

Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");