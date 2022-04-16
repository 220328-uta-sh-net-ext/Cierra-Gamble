// Challenge

/* Code challenges throughout these modules will reinforce what you've learned and help you gain some confidence before continuing on.
Fix this code
Use what you've learned in this module to fix this poorly written code. There are many improvements that you can make. Good luck!


// Rewrite and fix the problematic code in the .NET Editor

Retype the following code, or use the Run button, or the copy button to add the code to the .NET Editor.
*/

int[] numbers = { 4, 8, 15, 16, 23, 42 };
foreach (int number in numbers)
{
    int total;
    total += number;
    if (number == 42)
    {
       bool found = true;
    }
}
if (found) 
{
    Console.WriteLine("Set contains 42");
}
Console.WriteLine($"Total: {total}");

// 			SOLUTION

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42) found = true;
}

if (found) Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");

//  		OR
 int[] numbers = 
 { 4, 8, 15, 16, 23, 42 };
 int total = 0;
 bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42) found = true;
    if (found) Console.WriteLine("Set contains 42");
    }


Console.WriteLine($"Total: {total}");

/*
This code is merely "one possible solution" because you may have added line feeds in different spots, and you may have formatted the code differently.

The biggest changes to the problematic code included:
	moving the total and found variables outside of the foreach statement
	initializing both the total and found variables with sensible default values
	removing the code blocks and extra line feeds from the if statements
No matter how you formatted the code, when you run the code, you should see the following output.
*/