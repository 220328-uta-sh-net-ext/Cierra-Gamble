/* 
				FIRST CHALLENGE

Code challenges throughout these modules will reinforce what you've learned and help you gain some confidence before continuing.
First challenge
This module will feature two code challenges. This first challenge forces you to split up the data depending on its type and either concatenate or add the data accordingly.  
*/
// STEP 1: DELETE ALL OF THE CODE IN THE .NET EDITOR FROM THE EARLIER EXERCISE.

// Select all of the code in the .NET Editor then select the del or backspace key to delete it.
// STEP 2: WRITE CODE IN THE .NET EDITOR TO IMPLEMENT THE BUSINESS RULES.

// Iterate through each value in a string of values.
Start with the following line of code.

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// Add all the code necessary to implement the following business rules:
	// 		Business Rules:
	// Rule 1: If the value is alphanumeric, concatenate it to form a message
	// Rule 2: If the value is numeric, add it to the total
	// Rule 3: Make sure the result matches the following output:
				Output


Message: ABCDEF
Total: 68.3
// Whether you get stuck and need to peek at the solution or you finish successfully, continue to view a solution to this challenge.

// 				HOW TO WRITE THE CODE

string[] values = { "12.3", "45", "ABC", "11", "DEF" }; //string method of values inside bracketes

decimal total = 0m; //primitive decimal type
string message = ""; //to be quoted below using foreach statements

foreach (var value in values) //for each variable value in the string of values
{
    decimal number;
    if (decimal.TryParse(value, out number)) //parse method will break down alpha from numeric characters
    {
        total += number; //if total equls number, sum them
    } else
    {
        message += value; //if total equals value of alpha characters, cantanate to form messages 
    }
}

Console.WriteLine($"Message: {message}"); //write output of 
Console.WriteLine($"Total: {total}");

                    // Second challenge
// Here's a second chance to use what you've learned about casting and conversion to solve a coding challenge.

/* The following challenge will force you to understand the implications of casting values considering the impact of narrowing and widening conversions.
Step 1: Delete all of the code in the .NET Editor from the earlier exercise

Select all of the code in the .NET Editor then select the del or backspace key to delete it.

Step 2: Write code in the .NET Editor to produce the desired output

Start with the following code. */

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
// Replace the code comments with your own code to solve the challenge.
// When you run your code, you should see the following output:
                        Output


Divide value1 by value2, display the result as an int: 2
Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
Divide value3 by value1, display the result as a float: 0.3583333
// Whether you get stuck and need to peek at the solution or you finish successfully, continue on to view a solution to this challenge.

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// This code is merely "one possible solution" because there's likely several ways to solve this challenge. This solution relies mostly on casting (and a call to convert); however, it's possible you have another approach that works equally well. Just make sure your result matches the following output.