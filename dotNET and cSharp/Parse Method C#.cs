// Exercise - the TryParse() method

/* When working with data, you'll likely need to convert string data into a numeric data type. As you learned in the previous unit, because the string data type can hold a non-numeric value, it's possible that performing a conversion from a string into a numeric data type will cause a runtime error.
For example, the following code: */

string name = "Bob";
Console.WriteLine(int.Parse(name));
// causes the following exception:
Output

System.FormatException: 'Input string was not in a correct format.'
// To avoid a format exception, use the TryParse() method on the target data type.
Use TryParse()
	// The TryParse() method does several things simultaneously:
	// It attempts to parse (analyze into parts and describe each role of) a string into the given numeric data type.
// If successful, it will store the converted value in an out parameter.
// 	It returns a bool to indicate whether the action succeeded or failed.
//We can use the bool to take action on the value (like performing some calculation), or display a message if the parse operation was unsuccessful.
 Note
//In this exercise, we're using the int data type, but a similar TryParse() method is available on all numeric data types.
			// What is an out parameter?

/* Methods can return a value or return "void", meaning they return no value. Methods can also return values through out parameters, which are defined just like an input parameter, but include the out keyword.
When calling a method with an out parameter, you must also use the keyword out before the variable, which will hold the value. So, you have to define a variable before calling the method that will be used to store an out parameter value. You can then use the value contained in the out parameter throughout the rest of your code.
*/

// Step 1 - TryParse() a string into an int

	//Delete or comment out all of the code in the .NET Editor from previous exercises, and then add the following code.

string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
// Let's focus on this line:


if (int.TryParse(value, out result))
// The int.TryParse() method will return true if it successfully converted our string variable value into an int; otherwise, it will return false. So, surround the statement in an if statement, and then perform the decision logic, accordingly.
	// Note that the converted value will be stored in the int variable result. The int variable result is declared and initialized before this line of code, so it should be accessible both inside the code blocks that belong to the if and else statements, as well as outside of them.
// The out keyword instructs the compiler that the TryParse() method will not only return a value the traditional way (as a return value), but also will communicate an output through this two-way parameter.
// When you run the code, you should see the following output.
			Output

Measurement: 102
// STEP 2 - USE THE PARSED INT LATER IN CODE

// To demonstrate that the result that was declared earlier, then populated by the out parameter, is also usable later in your code, add the following line of code below the code you wrote in Step 1.

// Since it is defined outside of the if statement, 
// it can be accessed later in your code.
Console.WriteLine($"Measurement (w/ offset): {50 + result}");
The entire code passage should match the following code listing:

string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

// Since it is defined outside of the if statement, 
// it can be accessed later in your code.
Console.WriteLine($"Measurement (w/ offset): {50 + result}");
When you run the application, you should see the following result.
Output

Copy
Measurement: 102
Measurement (w/ offset): 152

// STEP 3 - MODIFY THE STRING VARIABLE TO AN UNPARSEABLE VALUE

// Lastly, let's look at the other scenario - where we intentionally give TryParse() a bad value that can't be converted into an int.
// Modify the first line of code reinitializing the variable value to a different value.

string value = "bad";
// Also, modify the last line of code to ensure that the result is greater than 0 before showing the second message.

if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");
// The entire code example should match the following code.

string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

// Since it is defined outside of the if statement, 
// it can be accessed later in your code.
if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");
// When you run the code again, you should get the following result:
Output

Unable to report the measurement.
				// Recap
// The TryParse() method is a valuable tool. Here are few quick ideas to remember.
// Use TryParse() when converting a string into a numeric data type.
	// TryParse() returns true if the conversion is successful, false if it's unsuccessful.
	// An out parameter provides a secondary means of a method returning a value. In this case, the out parameter returns the converted value.
// Use the keyword out when passing in an argument to a method that has defined an out parameter.


				// SECOND EXERCISE
// Here's a second chance to use what you've learned about casting and conversion to solve a coding challenge.
The following challenge will force you to understand the implications of casting values considering the impact of narrowing and widening conversions.
// Step 1: Delete all of the code in the .NET Editor from the earlier exercise

Select all of the code in the .NET Editor then select the del or backspace key to delete it.
Step 2: Write code in the .NET Editor to produce the desired output

Start with the following code.
C#

Copy

Run
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
Replace the code comments with your own code to solve the challenge.
When you run your code, you should see the following output:
Output

Copy
Divide value1 by value2, display the result as an int: 2
Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
Divide value3 by value1, display the result as a float: 0.3583333
Whether you get stuck and need to peek at the solution or you finish successfully, continue on to view a solution to this challenge.
				
				
					// SOLUTION
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");