// Format alphanumeric data for presentation in C#

/*
Learning objectives
In this module, you will:
	Use character escape sequences to add tabs, new lines, and Unicode characters to our strings
	Create verbatim string literals, and escape common characters like backslash and double-quotes
	Merge templates with variables using composite formatting and string interpolation
	Include various format specifiers for percentages, currency, and numbers

*/
/*
From a high-level perspective, software developers are concerned with:
	data input, including data typed in by a user from a keyboard, using their mouse, a device, or by another software system via a network request
	data processing, including decision logic, manipulating data, performing calculations, and so on
	data output, including presentation to an end user via a command-line message, a window, a web page, or saving the processed data into a file, sending it to a network service, and so on
In this module, we'll focus on that last concern. We'll work with string data formatting it with alignment and spacing. We'll format data for presentation as currency and other numbers. By the end of this module, we'll have new tools we can use to output data to our users that conveys and clarifies its meaning.
Suppose we work for a marketing department that will send thousands of personalized letters to our company's existing clients who are institutional investors. Our team's job is to promote new financial products to the customer. Each letter we send will merge personalized information about the customer. It will compare the returns of their current portfolios with projected returns using our newest products. How will we merge and format the data correctly?
In this module, you'll learn how to work with string and numeric data to solve real-world business problems in C#. You'll create a mockup of a receipt issued for products sold. And you'll merge data to send a personalized marketing message to customers.
*/

// In this module, you will:
	// Merge string templates with variables using composite formatting.
	// Use various format specifiers to properly display percentages, currency, and numbers.
	// Use padding methods to properly align string values to the right and left.
			
			STRING FORMATTING BASICS

// In this unit, we'll learn how to format strings to display this information accurately and more succinctly than string concatenation.
		// What is Composite Formatting?

/* Composite formatting uses numbered placeholders within a string. At run time, everything inside the braces will be resolved to a value that is also passed in based on their position.
Here's an example of composite formatting using a built-in method Format() on the string data type key word.
*/

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
// If you run this code, you'll see the following output.

// We'll talk about the different kinds of built-in methods that are available on the stringdata type and on variables of type string.
Output

Hello World!
/* There are a few important things to notice about this code.
Data types and variables of a given data type have built-in "helper methods" to make certain tasks easy.
The literal string "{0} {1}!" forms a template, parts of which will be replaced at run time.
The token {0} is replaced by the first argument after the string template, in other words, the value of the variable first.
The token {1} is replaced by the second argument after the string template, in other words, the value of the variable second.
 Note
You may think its odd to start with the number 0. Actually this is very common in software development. Whenever there's a sequence of items that can be identified using a number, the numbering will usually start at 0.
To exercise this idea a bit more, consider the following code. 
*/

string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);
// If you run this you should see the following output.
Output

World Hello!
Hello Hello Hello!
A few observations about these examples:
/* In the case of the first Console.WriteLine() statement, you can see that the tokens can be arranged in any order. Here, we have {1} before {0}.
In the case of the second Console.WriteLine() statement, you can see that the tokens can be reused and even omit the variable arguments that are passed in.
		WHAT IS STRING INTERPOLATION?

String interpolation is a newer technique that simplifies composite formatting. If you look at code examples in books and online, you're likely to see both techniques used, but generally you should prefer string interpolation.
Instead of using a numbered token and including the literal value or variable name in a list of arguments to String.Format() or Console.WriteLine(), you can just use the variable name inside of the curly braces.
In order for a string to be interpolated, you must prefix it with the $ directive. Here's the same examples from earlier using string interpolation instead of composite formatting.
*/

string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
// If you run the code, you'll see the following output.
Output
y
Hello World!
World Hello!
Hello Hello Hello!
Formatting currency

/* Composite formatting and string interpolation can be used to format values for display given a specific language and culture. In the following example, the :C currency format specifier is used to present the price and discount variables as currency.
*/

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
// When you run the code in the .NET Editor, you'll see the following output.
Output

Price: ¤123.45 (Save ¤50.00)
// The symbol ¤ used instead of the symbol for your country's money. This is a generic symbol used to denote "currency" regardless of the type of currency. You see this symbol in the .NET Editor because it ignores your current location.
	// However, if you executed this code on a computer in the USA that has its Windows Display Language set to English, you'll see the following output.
Output

Price: $123.45 (Save $50.00)
// Notice how adding the :C to the tokens inside of the curly braces formats the number as currency regardless of whether you use int or decimal.
// How the user's country and language impact string formatting
	// What if you execute the code (above) on a computer in France that has its Windows Display Language set to French? In that case you would see the following output.
Output

Price: 123,45 € (Save 50,00 €)

// The reason this happens is that using these string formatting features are dependent on the computing culture. In this context, the term "culture" refers to the country and language of the end user. The culture code is a five character string that computers use to identify the location and language of the end user to ensure certain information like dates and currency can be presented properly.
				For example:
the culture code of an English speaker in the USA is en-US.
the culture code of a French speaker in France is fr-FR.
the culture code of a French speaker in Canada is fr-CA.
// The culture affects the writing system, the calendar that's used, the sort order of strings, and formatting for dates and numbers (like formatting currency).
// Unfortunately, making sure your code works correctly on all computers regardless of the country or the end user's language is challenging. This process is known as localization (or globalization). Localization depends on many factors that we can't discuss in this module. For now, just be aware that the string formatting syntax may use a different format depending on the user's culture.
			// Formatting numbers

// When working with numeric data, you may want to format the number for readability by including commas to delineate thousands, millions, billions, and so on.
// The N numeric format specifier will do this.

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
// If you are viewing this from the en-US culture, you will see the following output.
Output

Measurement: 123,456.79 units
/* By default, the N numeric format specifier displays only two digits after the decimal point.
If you want to display more precision, you can do that by adding a number after the specifier. The following code will display four digits after the decimal point using the N4 specifier.
*/

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");
// If you are viewing this from the en-US culture, you will see the following output.
Output

Measurement: 123,456.7891 units
Formatting percentages

// Use the P format specifier to format percentages. Add a number afterwards to control the number of values displayed after the decimal point.

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
Output


Tax rate: 36.79 %
				// Recap
/* Here are most important takeaways from this unit about string formatting:
	You can use composite formatting or string interpolation to format strings.
	With composite formatting, you use a string template containing one or more replacement tokens in the form {0}. You also supply a list of arguments that are matched with the replacement tokens based on their order. Composite formatting works when using string.Format() or Console.WriteLine().
	With string interpolation, you use a string template containing the variable names you want replaced surrounded by curly braces. Use the $ directive before the string template to indicate you want the string to be interpolated.
	Format currency using a :C specifier.
	Format numbers using a :N specifier. Control the precision (number of values after the decimal point) using a number after the :N like {myNumber:N3}.
	Formatting currency and numbers depends on the end user's culture, a five character code that includes the user's country and language (per the settings on their computer).
*/

