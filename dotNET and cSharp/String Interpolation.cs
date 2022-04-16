// Exercise - string interpolation

/* Suppose we want to print a receipt for the sale of a chemical solvent used in industrial settings. While our scales measure in micrograms, we price each sale in milligrams (a thousandth of a gram). To print the receipt, we would likely need to combine data of different types, including fractional values, currency, and percentages in precise ways.
Step 1 - Display the invoice number using string interpolation
*/


int invoiceNumber = 1201;
decimal productMeasurement = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
// When you run the code, you should see the following output.
Output

Invoice Number: 1201

// STEP 2 - DISPLAY THE PRODUCT MEASUREMENT IN MILLIGRAMS

// Since we bill our customers using milligrams even though our measuring instruments measure to the precision of a microgram, we will only display three digits after the decimal point. Add the following code below the code you typed in step 1.

Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
// When you run the code, you should see the following output.
Output


Invoice Number: 1201
   Measurement: 25.457 mg
// STEP 3 - DISPLAY THE SUBTOTAL THAT WE'LL CHARGE THE CUSTOMER FORMATTED AS CURRENCY

	// Add the following code below the code you typed in steps 1 and 2.

Console.WriteLine($"     Sub Total: {subtotal:C}");
// When you run the code, you should see the following output.
Output

Invoice Number: 1201
   Measurement: 25.457 mg
     Sub Total: ¤2,750.00

// STEP 4 - DISPLAY THE TAX CHARGED ON THE SALE FORMATTED AS A PERCENTAGE

	//Add the following code below the code you typed in steps 1 through 3.

Console.WriteLine($"           Tax: {taxPercentage:P2}");
//When you run the code, you should see the following output.
Output

Invoice Number: 1201
   Measurement: 25.457 mg
     Sub Total: ¤2,750.00
           Tax: 15.83 %

// STEP 5 - FINALIZE THE RECEIPT WITH THE TOTAL AMOUNT DUE FORMATTED AS CURRENCY.

// Add the following code below the code you typed in steps 1 through 4.

Console.WriteLine($"     Total Due: {total:C}");
// The entire code for the exercise should match as follows:

int invoiceNumber = 1201;
decimal productMeasurement = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Due: {total:C}");
// When you run the code, you should see the following output.
Output

Invoice Number: 1201
   Measurement: 25.457 mg
     Sub Total: ¤2,750.00
           Tax: 15.83 %
     Total Due: ¤3,185.19

// 	Exercise - padding and alignment

/* 
Previously, we used the string.Format() method to perform composite formatting. It may have seemed a bit strange that a key word that represents a data type has methods you can call in the same way that you call methods on the Console class. The fact is that there are many similar methods on the string data type as well as any literal string or variable of type string.
Here's a brief list of categories of these built-in methods so you can get an idea of what's possible.
Methods that either add blank spaces for formatting purposes (PadLeft(), PadRight())
Methods that either compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
Methods that help you determine what's inside of a string, or even retrieve just a part of the string (Contains(), StartsWith(), EndsWith(), Substring())
Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
Methods that turn a string into an array of strings or characters (Split(), ToCharArray())
We'll use these methods in other modules as we find a use for their functionality.
Formatting strings by adding whitespace before or after
The PadLeft() method will add blank spaces to the left-hand side of the string so that the total number of characters equals the argument you send it. In this case, we want to total length of the string to be 12 characters.
*/

string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
// When you run the code, you'll see four characters are prefixed to the left of the string so that it is 12 characters long.
Output


    Pad this
// To add space or characters to the right side of your string, use the PadRight() method instead.

Console.WriteLine(input.PadRight(12));

// When you run the code, you won't see any characters added to the end of the string, but they are there.
// What is an overloaded method?

/*
In C#, an overloaded method is another version of a method with different or additional arguments that modify the functionality of the method slightly, as is the case with our overloaded version of the PadLeft() method. We'll learn how to create methods and overloaded methods in other modules.
You can also call a second overloaded version of the method and pass in whatever character you want to use instead of a space. In this case, we'll fill the extra space with the dash character.

Copy
*/

Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

// When you run the code, you'll see four dashes prefixing the left of the string that is 12 characters long.
Output

----Pad this
Pad this----
Let's apply this newfound knowledge to another real world scenario.
// EXERCISE - WORKING WITH PADDED STRINGS
/*
Suppose we work for a payment processing company that still supports legacy mainframe systems. Often, those systems require data to be input in specific columns. For example, the Payment ID should be stored in columns 1 through 6, the payee's name in columns 7 through 30, and the Payment Amount in columns 31 through 40. Also, importantly, the Payment Amount should be right-aligned.
We are asked to build an application that will convert data in our relational database management system to the legacy file format. To ensure that the integration will work correctly, our first step is to confirm the file format by giving the legacy system maintainers a sample of our output. Later, we'll build on this work to send hundreds or thousands of payments to be processed via an ASCII text file.
*/

// Step 1 - Add the OrderId to the output

// To get started, let's just print out the Payment ID in the first six columns. We'll pick some random payment data that should be adequate for our purposes.

string paymentId = "769";

var formattedLine = paymentId.PadRight(6);

Console.WriteLine(formattedLine);
// We'll reuse the formattedLine variable to build our output string. When you run the code, you should see the following output.

769   
// There are three additional blank spaces to the right that not visible. We'll confirm that they exist in the next step.
// STEP 2 - ADD THE PAYEE NAME TO THE OUTPUT

Next, we'll add a fictitious Payee Name, padding it appropriately.
Modify the code from Step 1 in the .NET Editor to match the following code.

string paymentId = "769";
string payeeName = "Mr. Stephen Ortega";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);

Console.WriteLine(formattedLine);
// The += operator performs a string concatenation, taking the previous value of the variable formattedLine and adding the new value to it. It's a shortened equivalent to doing this:

formattedLine = formattedLine + payeeName.PadRight(24);
// When we run the code, we'll see the following output.
Output

769   Mr. Stephen Ortega      
// Again, there are quite a few blank spaces after the Payee's Name. Also, we can see the three blank spaces after the Payment ID from Step 1.

// STEP 3 - ADD THE PAYMENT AMOUNT TO THE OUTPUT

// Next, let's add a fictitious Payment Amount and make sure to use PadLeft() to right-align the output.
// Modify the code from Steps 1 and 2 in the .NET Editor to match the following passage.

string paymentId = "769";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine(formattedLine);
// When we run the code, we'll see the following output.
Output

769   Mr. Stephen Ortega       $5,000.00
// This is pretty close to what we understood the legacy system maintainers were looking for.

// STEP 4 - ADD A LINE OF NUMBERS ABOVE THE OUTPUT TO MORE EASILY CONFIRM THE RESULT

/*
Since it's difficult to count the exact columns where each data element appears, let's add a line directly above our output that helps us count the columns.
*/

Console.WriteLine("1234567890123456789012345678901234567890");
// Modify the code from Steps 1 through 3 in the .NET Editor to match the following.

string paymentId = "769";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

/*When you run the application, we have the following output that we can send off to the maintainers of the legacy system to confirm our new integration will work correctly.
Output
*/

1234567890123456789012345678901234567890
769   Mr. Stephen Ortega       $5,000.00
Success!
				// Recap
There's a few important takeaways from this unit.
	The string data type, literal strings, and variables of type string each implement many helper methods to format, modify, and perform other operations on strings.
	The PadLeft() and PadRight() methods add white space (or optionally, another character) to the total length of a string.
	Use PadLeft() to right-align a string.
	Some methods are overloaded, meaning they have multiple versions of the method with different arguments that affect their functionality.
	The += operator concatenates a new string on the right to the existing string on the left.