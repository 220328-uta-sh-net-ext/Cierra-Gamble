// First challenge

// Code challenges throughout these modules will reinforce what you've learned and help you gain some confidence before continuing on.
		// Word reversal challenge
/* Many times you'll need to combine several of the ideas we covered in this module into a single solution. This challenge will force you to decompose a larger problem into lots of mini-problems, then use the various ideas in this module to solve each mini-problem.
*/
// Step 1: Delete all of the code in the .NET Editor from the earlier exercise

Select all of the code in the .NET Editor then select the del or backspace key to delete it.
// Step 2: Write code in the .NET Editor to reverse each word in a message


string pangram = "The quick brown fox jumps over the lazy dog";
/*
Write the code necessary to reverse the letters of each word in place and display the result. In other words, don't just reverse every letter in the variable pangram. Instead, you'll need to reverse just the letters in each word, but print the reversed word in its original position in the message.
If you're successful, you should see the following output.
*/

		Output

ehT kciuq nworb xof spmuj revo eht yzal god
 Important
/*
This is a particularly difficult challenge. You will need to combine many of the concepts you learned in this exercise, including the use of the Split(), ToCharArray(), Array.Reverse(), and String.Join(). You'll also need to create multiple arrays, and at least one iteration statement.
Good luck! You can do it! Just keep decomposing the problem into baby steps, then solve that particular step before moving to the next.
Whether you get stuck and need to peek at the solution or you finish successfully, continue on to view a solution to this challenge.
*/
// 		SOLUTION SHOULD LOOK LIKE THIS

string pangram = "The quick brown fox jumps over the lazy dog";

string[] message = pangram.Split(' ');
string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result = String.Join(" ", newMessage);
Console.WriteLine(result);