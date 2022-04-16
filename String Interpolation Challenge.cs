Challenge

/*
At the beginning of this module, we described the scenario of working for a marketing department of a financial services company. To promote the company's newest investment products, we'll send thousands of personalized letters to our company's existing clients. Our job is to write C# code that will merge personalized information about the customer. The letter will contain information like their existing portfolio and will compare their current returns to projected returns if they were to invest in using our new products.
Our writers have decided on the following example marketing copy. Here's the desired output (using fictitious customer account data).
Output
*/


Dear Mr. Jones,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75 %.

Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75 %   ¤55,000,000.00      
Glorious Future     13.13 %   ¤63,000,000.00  
// Use your new found knowledge of string formatting to build an application that can merge and format the appropriate content given the example output above. Pay particular attention to the white space and make sure you accurately represent this exact format using C#.
	// Here are the rules for the challenge.

// Use the .NET Editor to generate the message given the variables and code. Replace the code comments with your own string formatting code.

string customerName = "Mr. Jones";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here

Console.WriteLine(comparisonMessage);
You may not delete any of the existing code except for the comments.
 					Note
Keep in mind that the ¤ character will likely be emitted in this .NET Editor environment rather than your locale's currency character.

//				SOLUTION

string customerName = "Mr. Jones";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);

