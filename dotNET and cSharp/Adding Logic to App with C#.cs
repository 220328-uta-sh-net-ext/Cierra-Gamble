/*
WHAT IS AN EXPRESSION?
An expression is any combination of values (literal or variable), operators, and methods that return a single value. A statement is a complete instruction in C#, and statements are comprised of one or more expressions.

There are many different categories of expressions, but when working with decision statements, we're interested in Boolean expressions. In a Boolean expression, the runtime evaluates the values, operators, and methods to return a single true or false value.

*/

//EVALUATING EQUALITY AND INEQUALITY

/*
Many times, you'll want to check to see if two values are equal or not. You use the equality operator == between two values to evaluate equality. If the two values on either side of the equality operator are equivalent, then the expression will return true. Otherwise, it will return false.
Other times, you may want to check to see if two values aren't equal. You use the inequality operator != between two values evaluate equality.
You may wonder why you need both equality and inequality operators. The reason will become clearer as you learn how to create branching statements and begin to write real world code. Two operators that perform opposite tasks allow you to be more expressive and compact.
*/

// BOOLEAN EXPRESSIONS!!!

/*
STEP 1 - USE THE EQUALITY OPERATOR

Type the following code into the code editor on the right.
*/

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
// RUN THE CODE

/*
STEP 2 - IMPROVE THE CHECK FOR STRING EQUALITY USING THE STRING'S BUILT-IN HELPER METHODS

You may be surprised that the line Console.WriteLine("a" == "A"); outputs false. When comparing strings, case matters.
ALSO, CONSIDER THIS LINE OF CODE:
*/

Console.WriteLine("a" == "a ");

/*
Here we add a blank space at the end of the string. This, too, outputs false.
In some cases, this might be perfectly acceptable. However, if you need to accept a match that is inexact, you can "massage" the data first. "Massaging" the data means that you need to perform some cleanup before you perform a comparison for equality.
*/

// TO MASSAGE TWO STRINGS BEFORE CHECKING FOR EQUALITY, YOU SHOULD:
	/*
	- Make sure both strings are all upper-case or all lower-case using the ToUpper() or ToLower() helper method on any string value.
	- Remove a leading or trailing blank spaces using the Trim() helper method on any string value.
	*/

// Let's improve the previous check for equality by chaining these two methods on both values in the following code listing:

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
// == IS EQUALITY

// When you run the code this time, the output will be true.

/*
STEP 3 - USE THE INEQUALITY OPERATOR

Use the line comment operator // to comment out all of the code from the previous step. Then add the following code below it in the code editor:
*/

// != IS INEQUALITY 

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");
// RUN THE CODE

/*
--*** EVALUATING COMPARISONS
When working with numeric data types, you'll want to determine if one value is larger, smaller, or equal to another value. Use the following operators to perform these types of comparisons.
	Greater than >
	Less than <
	Greater than or equal to >=
	Less than or equal to <=
*/

// STEP 4 - USE THE COMPARISON OPERATORS
/*
Use the line comment operator // to comment out all of the code from the previous step. Then add the following code below it in the code editor:
*/

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);
// RUN THE CODE

/* METHODS THAT RETURN A BOOLEAN VALUE
	Some methods return a Boolean value. You can think of these types of methods as queries. In the following exercise, we'll use a built-in method on the String class to determine whether or not a larger string contains a specific word or phrase that may be interesting to us.
*/

/*
			Note
Some data types have methods that perform helpful utility tasks. The String data type has many of these. Several return a Boolean value including Contains(), StartsWith(), and EndsWith(). You can learn more about them in the Microsoft Learn module "Manipulate alphanumeric data using String class methods in C#".
*/

// STEP 5 - USE A METHOD INVOCATION EXPRESSION

/*
Use the line comment operator // to comment out all of the code from the previous steps. Then add the following code below it in the code editor:
*/
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
//RUN THE CODE

/* WHAT IS LOGICAL NEGATION?
	The term "Logical Negation" refers to the ! operator. Some people simply call this the "not operator". Adding the ! operator before a conditional expression like a method call checks to ensure the expression is false.
	And just to hopefully help you see the connections between these ideas, the following two lines of code do the same thing. The second line is more compact.
*/

// These two lines of code do the same thing:

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

//STEP 6 - USE THE LOGICAL NEGATION OPERATOR

//Update the code from Step 4 to include not operators before the invocation of the method calls.

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
//RUN THE CODE

/*
			Recap
Here's the main takeaways you learned about evaluating Boolean expressions so far:
There are many different kinds of expressions that evaluate to either true or false.
Evaluate equality using the == operator.
Evaluating equality of strings requires you consider the possibility that the strings have different case and leading or trailing spaces. Depending on your situation, use the ToLower() or ToUpper() helper methods, and the Trim() helper method to improve the likelihood that two strings are equal.
	Evaluate inequality using the != operator.
	Evaluate greater than, less than and similar operations using comparison operators like >, <, >=, and <=.
If a method returns a bool, it can be used as a Boolean expression.
Use the logical negation operator ! to evaluate the opposite of a given expression.
*/