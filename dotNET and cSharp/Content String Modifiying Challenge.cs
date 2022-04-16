// Code challenges throughout these modules will reinforce what you've learned and help you gain some confidence before continuing on.

// In this challenge, you'll work with a string that contains a fragment of HTML. You'll extract data from the HTML fragment, replace some of its content, and remove other parts of its content to achieve the desired output.
	STEP 1: DELETE ALL OF THE CODE IN THE .NET EDITOR FROM THE EARLIER EXERCISE.

//	Select all of the code in the .NET Editor then select the del or backspace key to delete it.

// STEP 2: WRITE CODE IN THE .NET EDITOR TO EXTRACT DATA, REPLACE DATA, AND REMOVE DATA FROM AN INPUT STRING.

// Given the starting point in the following code listing, you'll add code to extract, replace, and remove portions of the input's value to produce the desired output.

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

Console.WriteLine(quantity);
Console.WriteLine(output);
The following listing is the desired output once you've modified the code in the starting point.
Output


Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
/* You may only add code to the starting point code listing. You must not change the variable declarations. All of your work should go under the comment // Your work here.
You'll perform three operations on the input using the tools and techniques you learned in this module.
Set the quantity variable to the value you extract from between the <span> and </span> tags.
Set the output variable to the value of input, then remove the <div> and </div> tags.
Replace the HTML character &trade; with &reg; in the output variable.
Whether you get stuck and need to peek at the solution or you finish successfully, continue on to view a solution to this challenge.
*/
			// Quick HTML primer

/* In case you're not familiar with HTML, it's the markup language that is used to create all web pages. This section can be skipped if you're already well versed in HTML. It's not designed to be a comprehensive tutorial, but provides enough information to complete this challenge.
In HTML, you define the structure of a document using tags. A tag is comprised of:
	an opening angle bracket <
	a closing angle bracket >
	a word describing the type of tag, so for example: <div>, <span>, <h2> etc.
Each tag has a corresponding closing tag that is indicated by a forward slash character /. So, if you see <div> there should be a corresponding </div> tag.
The content between the opening and closing tag is the content of that tag. The content can include text and other tags.
A set of tags can be embedded inside another set of tags. In fact, that is what gives an HTML document its hierarchical structure.
*/

// 				SOLUTION

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

const string spanTag = "<span>";

// Extract the quantity
int quantityStart = input.IndexOf(spanTag);
int quantityEnd = input.IndexOf("</span>");
quantityStart += spanTag.Length;
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);

// Set output to input, replacing the trademark symbol with the registered trademark symbol
output = input.Replace("&trade;", "&reg;");

// Remove the opening <div> tag
int divStart = input.IndexOf("<div");
int divEnd = input.IndexOf(">");
int divLength = divEnd - divStart;
divLength += 1;
output = output.Remove(divStart, divLength);

// Remove the closing <div> tag
int divCloseStart = output.IndexOf("</div");
int divCloseEnd = output.IndexOf(">", divCloseStart);
int divCloseLength = divCloseEnd - divCloseStart;
divCloseLength += 1;
output = output.Remove(divCloseStart, divCloseLength);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");