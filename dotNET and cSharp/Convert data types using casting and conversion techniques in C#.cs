//Convert data types using casting and conversion techniques in C#

/*
Learning objectives
In this module, you will:
Use the casting operator to cast a value into a different data type.
Use conversion methods to convert a value into a different data type.
Guard against the loss of data when performing a cast or conversion operation.
Use the TryParse() method to safely convert a string into a numeric data type.
*/

/*
Frequently, when working with data, you'll need to change a value from one data type into another. There's many reasons why you might need to do this.
	A simple example is any mathematical operation you want to perform with string data. You would first need to change the value into a numeric data type, like int, and then you could manipulate the operation. Alternatively, you may want to format and output a numeric value using string interpolation. Whether we're explicitly instructing the runtime to perform this change, or are relying on the runtime to implicitly change a value's data type, it's important to understand what is happening and why.
	In this module, you'll use different techniques to change a data type when necessary. You'll learn when to use one technique over another, and when a given technique might risk the loss of data.
	By the end of this module, you'll be able to take control of the data in your applications, knowing when to apply the correct technique to change data types as needed.
				Learning objectives
In this module, you'll:
Use the casting operator to cast a value into a different data type.
Use conversion methods to convert a value into a different data type.
Guard against the loss of data when performing a cast or conversion operation.
Use the TryParse() method to safely convert a string into a numeric data type.
*/

/*Exercise - data type casting and conversion
Completed
100 XP
10 minutes
There are multiple techniques to perform a data type conversion or cast. Which technique you choose depends on your answer to two important questions:
Question 1: Is it possible, depending on the value, that attempting to change the value's data type would throw an exception at run time?
Question 2: Is it possible, depending on the value, that attempting to change the value's data type would result in a loss of information?
In this exercise, we'll work our way through these questions, the implications of their answers, and which technique you should use when you need to change the data type.
Question 1: Is it possible, depending on the value, that attempting to change the value's data type would throw an exception at run time?
The C# compiler will try to accommodate your code, but will always avoid an operation that could result in an exception. When you understand the C# compiler's primary concern, understanding why it functions a certain way will be easier.
*/
// STEP 1 - WRITE CODE THAT ATTEMPTS TO ADD AN INT AND A STRING AND SAVE THE RESULT IN AN INT

// Add the following code to the .NET Editor:

int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);

// Here, we're attempting to add the values 2 and 4. The value 4 is of type string. Will this work?
// Run the code and you should see the following output.
Output

(3,14): error CS0029: Cannot implicitly convert type 'string' to 'int'

// The error message tells us the problem is with our use of the string data type. But why can't the C# Compiler just handle this? After all, we can do the opposite to concatenate a number to a string and save it in a string variable. Here', we'll merely change the data type of the result variable from int to string.

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);
And this will produce the following output:
Output

24
// Let's return to our first code example where the result variable is of type int. Why can't the C# compiler figure out that we want to treat the variable second containing 4 as a number, not a string?
// The C# compiler sees a potential problem in the making. The variable second is of type string, so it might be set to a different value like "hello". If the C# compiler attempted to convert "hello" to a number that would cause an exception at runtime. To avoid this possibility, the C# compiler will not implicitly perform the conversion from string to int for you.
	// From the C# compiler's perspective, the safer operation would be to convert int into a string and perform concatenation instead.
// If you intend to perform addition using a string, the C# compiler requires you to take more explicit control of the process of data conversion. In other words, it forces you to be more involved so that you can put the proper precautions in place to handle the possibility that the conversion could throw an exception.
	// If you need to change a value from the original data type to a new data type and the change could produce an exception at run time, you must perform a data conversion.
// To perform data conversion, you can use one of several techniques:
	// Use a helper method on the data type
	// Use a helper method on the variable
	// Use the Convert class' methods
// We'll look at a few examples of these techniques for data conversion later in this unit.
/* Question 2: Is it possible, depending on the value, that attempting to change the value's data type would result in a loss of information?
The term widening conversion means that you are attempting to convert a value from a data type that could hold less information to a data type that can hold more information. In this case, you'll lose no information. So, an example of this would be converting a value stored in a variable of type int and now converting that value into a variable of type decimal.
If you were to print out the two values, you would likely notice no difference.
When you know you'll be performing a widening conversion, you can rely on implicit conversion. Implicit conversion is handled by the compiler.
*/

// Step 2 - Modify the code in the .NET Editor to perform an implicit conversion

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
// When you run the code, you should see the following output:

Output

int: 3
decimal: 3
// The key to this example is this line of code:

decimal myDecimal = myInt;
/* Since any int value can easily fit inside of a decimal, the compiler performs the conversion.
The term narrowing conversion means that you're attempting to convert a value from a data type that can hold more information to a data type that can hold less information. In this case, you may lose information such as precision (that is, the number of values after the decimal point). An example of this would be converting value stored in a variable of type decimal and now convert that value into a variable of type int. If you were to print out the two values, you would possibly notice the loss of information.
When you know you'll be performing a narrowing conversion, you'll need to perform a cast. Casting is an instruction to the C# compiler that you know precision may be lost, but you're willing to accept it.
*/

// STEP 3 - MODIFY THE CODE IN THE .NET EDITOR TO PERFORM A CAST

// To perform a cast, you use the casting operator () to surround a data type, then place it next to the variable you want to convert.


decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
// If you run the code example, you would see the following output.
Output

decimal: 3.14
int: 3
The key to this example is this line of code:

int myInt = (int)myDecimal;
/*
The variable myDecimal holds a value that has two places of precision. By adding the casting instruction (int), we're telling the C# compiler that we understand it's possible we'll lose that precision, and in this situation, it's fine.
How do I know if a conversion is a "widening conversion" or a "narrowing conversion"?
If you're not sure whether you'll lose data or not, you can do one of two things.
The definitive resource is the following article on Docs:
Type Conversion Tables in .NET
This Docs article uses the .NET Class Library name for types, not the C# keyword for the data types, so it might be a bit confusing at first. Use the following article to map between the C# keyword and the .NET Class Library type:
*/
			Built-in types table
/* However, you can also write some code to perform a conversion in two different ways and observe the changes. Developers frequently write small tests to better understand the propensities of two similar techniques. For example, you might do something like this: 
*/

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float: {myFloat}");
This code produces the following output:
Output


Decimal: 1.23456789
Float: 1.234568

// From this, I can see that casting a decimal into a float is a narrowing conversion because I'm losing precision.



			// PERFORMING DATA CONVERSIONS
/* Earlier, we said that when you need to change a value from one data type into another, and that change could cause a runtime exception, you should perform data conversion, and there are three techniques you can use:
	Use a helper method on the variable
	Use a helper method on the data type
	Use the Convert class' methods
	Use ToString() to convert a number to a string

Every data type variable has a ToString() method. What the ToString() method does depends on how it's implemented on a given type. However, on most primitives, it performs a widening conversion. While this isn't strictly necessary (since we can rely on implicit conversion in most cases) it can communicate to other developers that you understand what you're doing and it's intentional.

STEP 4 - MODIFY THE CODE IN THE .NET EDITOR TO CONVERT A NUMBER TO A STRING USING THE TOSTRING() HELPER METHOD

Here's a quick example of using the ToString() method to explicitly convert int values into strings.
*/

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

// If you run the command, you'll see the following output -- a concatenation of the two values.
Output

57

/*
Explicitly converting a string to a number
Most of the numeric data types have a Parse() method, which will convert a string into the given data type. In this case, we'll use the Parse() method to convert two strings into int values, then add them together.

STEP 5 - MODIFY THE CODE IN THE .NET EDITOR TO CONVERT A STRING TO AN INT USING THE PARSE() HELPER METHOD

Delete or comment out the code from the previous exercise step and add the following code in the .NET Editor:
*/

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

// If you run the code example, you should see the following output.

Output

Copy
12

/* Can you spot the potential problem with the code example above? What if either of the variables first or second are set to values that can't be converted to an int? An exception will be thrown at runtime. This is exactly what the C# compiler and runtime expects us to plan for ahead of time. Fortunately, we can mitigate this in several ways.
The easiest way to mitigate this situation is through the use of TryParse(), which is a better version of the Parse() method. We'll discover that in the next unit.
Data Conversion using the Convert class
The Convert class has many helper methods to convert a value from one type into another. In the following code example, we'll convert a couple of strings into values of type int.
Step 6 - Modify the code in the .NET Editor to convert a string to a number using the Convert class
Delete or comment out the code from the previous exercise step and add the following code in the .

NET Editor:
*/

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);
 Note

/* 
Why is the method name ToInt32()? Why not ToInt()? System.Int32 is the name of the underlying data type in the .NET Class Library that the C# programming language maps to the keyword int. Because the Convert class is also part of the .NET Class Library, it is called by its full name, not its C# name. By defining data types as part of the .NET Class Library, multiple .NET languages like Visual Basic, F#, IronPython, and others can share the same data types and the same classes in the .NET Class Library. At the end of this module, we'll post some links so you can learn more about .NET's Common Type System.
The ToInt32() method has 19 overloaded versions allowing it to accept virtually every data type as we'll see in a moment.
We used the Convert.ToInt32() method with a string here, but you should probably use TryParse() when possible.
So, when should we use the Convert class? The Convert class is best for converting fractional numbers into whole numbers (int) because it rounds up the way you would expect.
Casting versus Conversion

The following example demonstrates what happens when you attempt to cast a decimal into an int (a narrowing conversion) versus using the Convert.ToInt32() method to convert the same decimal into an int.
STEP 7 - MODIFY THE CODE IN THE .NET EDITOR TO COMPARE CASTING AND CONVERTING A DECIMAL INTO AN INT
Delete or comment out the code from the previous exercise step and add the following code in the .NET Editor:
*/
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);
When you run the code, you'll see the following output.

Output

1
2

/* When casting, the value of the float is truncated, meaning the value after the decimal is ignored completely. We could change the literal float to 1.999m and the result of casting would be the same.
When converting using Convert.ToInt32(), the literal float value is properly rounded up to 2. If we changed the literal value to 1.499m, it would be rounded down to 1.
Recap
We covered several important concepts of data conversion and casting:
Perform a data conversion when it's possible that doing so could cause a runtime error.
Perform an explicit cast to tell the compiler you understand the risk of losing data.
Rely on the compiler to perform an implicit cast when performing an expanding conversion.
Use the () cast operator and the data type to perform a cast (for example, (int)myDecimal).
Use the Convert class when you want to perform a narrowing conversion, but want to perform rounding, not a truncation of information.
*/