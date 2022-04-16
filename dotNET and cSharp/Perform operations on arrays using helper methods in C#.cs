// Learning objectives
		// In this module, you will:
		// Sort and reverse the order of array elements.
		// Clear and resize the elements of an array.
		// Split a string into an array of strings or characters (chars).
		// Join array elements into a string
		
// EXERCISE - SORT() AND REVERSE()

/* Use array methods to sort elements in an array
The Array class contains methods that we can use to manipulate the content, arrangement, and size of an array. In this exercise, you'll write code that performs various operations on an array of pallet identifiers, which may be the start of an application to track and optimize the usage of pallets for the company. */

// STEP 1 - CREATE AN ARRAY OF PALLETS, THEN SORT THEM


string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Focus on the line of code Array.Sort(pallets);. Here we're using the Sort() method of the Array class to sort the items in the array alphanumerically.
// Now, run the code and view the following output.

Sorted...
-- A11
-- A13
-- B12
-- B14
// STEP 2 - REVERSE THE ORDER OF THE PALLETS

// Next, add code to reverse the order of the pallets by calling the Array.Reverse() method. Update your code from step 1 to match the following code listing.

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// Focus on the line of code Array.Reverse(pallets);. Here, we're using the Reverse() method of the Array class to reverse the order of items.
// Now, run the code and compare the reversed list against the sorted list.
Output

Sorted...
-- A11
-- A13
-- B12
-- B14

Reversed...
-- B14
-- B12
-- A13
-- A11
// 					Recap
// Here's a few important ideas that we covered in this unit:
	// The Array class has methods that can manipulate the size and contents of an array.
	// Use the Sort() method to manipulate the order based on the given data type of the array.
	// Use the Reverse() method to flip the order of the elements in the array.

// Next unit: Exercise - Clear() and Resize()

/*
As we continue building a pallet tracker for our logistics company, suppose we also need track new pallets and remove old pallets from tracking. How can we accomplish this?
Use array methods to clear and resize an array
The Array.Clear() method allows us to remove the contents of specific elements in our array, and the Array.Resize() method adds or removes elements from our array. 
*/

STEP 1 - CLEAR ITEMS FROM THE ARRAY

// Comment out or delete the code from the previous unit in the .NET Editor. Then add the following code listing.

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// Focus on the line of code Array.Clear(pallets, 0, 2);. Here we're using the Array.Clear() method to clear the values stored in the elements of the pallets array starting at index 0 and clearing 2 elements.
	// When you run the code, you'll see that the values stored in the first two elements of the array have been cleared out. As we can see from the Length property and the foreach statement, the elements still exist, but they're now empty.
Output

Clearing 2 ... count: 4
-- 
-- 
-- B12
-- A13
			// EMPTY STRING VERSUS NULL
// When you use Array.Clear(), the elements that were cleared no longer reference a string in memory. In fact, the element points to nothing at all. This is an important distinction that can be difficult to grasp at first.
// What if we attempt to retrieve the value of an element that was affected by the Array.Clear() method, could we do it?
// STEP 2 - ACCESS THE VALUE OF A CLEARED ELEMENT

// We'll take two passes at accessing the value of a cleared element to see how the C# compiler works with a null value.
	// Add two lines of code before and after calling the Array.Clear() method.


Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");
// Make sure your code matches the following code listing:

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// When you run the code, you should see the following output.
Output

Before: B14
After:
Clearing 2 ... count: 4
--
--
-- B12
-- A13
// If you focus on the line of output After: , you may think that the value stored in pallets[0] is an empty string. However, the C# Compiler implicitly converts the null value to an empty string for presentation.

// STEP 3 - CALL A STRING HELPER METHOD ON A CLEARED ELEMENT

// To prove that the value stored in pallets[0] after being cleared is null, we'll modify the code example to call the ToLower() method on pallets[0]. If it's a string, it should work fine. But if it's null, it should cause the code to throw an exception.
	// Update your code to add the call to the ToLower() method on each time we attempt to write pallets[0] to the console.

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0].ToLower()}");
// Make sure your code matches the following code listing:

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// This time, when you run the code, you'll see a large error message. If you parse through the text, you'll see the following message:
Output


System.NullReferenceException: Object reference not set to an instance of an object.
	// The reason this exception is thrown is because we attempt to call the method on the contents of the pallets[0] element before the C# Compiler has a chance to implicitly convert null to an empty string.
// The moral of the story is that Array.Clear() will remove an array element's reference to a value if one exists. To fix this, we might check for null before attempt to print the value.
	// To accomplish this, we would add an if statement before accessing an array element that is potentially null.

if (pallets[0] != null) //null indicates a variable points to nothing 
    Console.WriteLine($"After: {pallets[0].ToLower()}");
// STEP 4 - RESIZE THE ARRAY TO ADD MORE ELEMENTS

// Next, rework the code listing from Step 1 to include additional code to resize the array. When complete, your code should match the following code listing:

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
/* Focus on the line Array.Resize(ref pallets, 6);. Here, we're calling the Resize() method passing in the pallets array by reference, using the ref keyword. In some cases, methods require you pass arguments by value (the default) or by reference (using the ref keyword). The reasons why this is necessary would require a lot of explanation about of how objects are managed in .NET. Unfortunately, that is beyond the scope of this module. When in doubt, we recommend looking at Intellisense or Microsoft Docs for examples on how to properly call a given method.

In this case, we're resizing the pallets array from four elements to 6. The new elements are added at the end of the current elements. The two new elements will be null until we assign a value to them.

	When you run the code, you should see the following output. */
Output

Clearing 2 ... count: 4
-- 
-- 
-- B12
-- A13

Resizing 6 ... count: 6
-- 
-- 
-- B12
-- A13
-- C01
-- C02

// STEP 5 - RESIZE THE ARRAY TO REMOVE ELEMENTS

// Conversely, we can remove array elements using Array.Resize().

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// When you run the code, you should see the following output.
Output

Clearing 2 ... count: 4
--
--
-- B12
-- A13

Resizing 6 ... count: 6
--
--
-- B12
-- A13
-- C01
-- C02

Resizing 3 ... count: 3
--
--
-- B12
/* Notice that calling Array.Resize() didn't eliminate the first two null elements. Rather, it removed the last three elements -- despite the fact that they contained string values.
	CAN WE REMOVE NULL ELEMENTS FROM AN ARRAY?

If the Array.Resize() method doesn't remove empty elements from an array, is there another helper method that will do this automatically? No. The best way to accomplish this would be to count the number of non-null elements by iterating through each item and increment a variable (a counter). Next, you would create a second array that is the size of the counter variable. Finally, you would loop through each element in the original array and copy non-null values into the new array.
					Recap
Here's a few important ideas that we covered in this unit:
Use the Clear() method to empty the values out of elements in the array.
Use the Resize() method to change the number of elements in the array, removing or adding elements from the end of the array.
New array elements and cleared elements are null, meaning they don't point to a value in memory.
Next unit: Exercise - Split() and Join()
*/


// Suppose you work for a system integrator. You're building a series of small programs that will take data from one partner's system, modify the data, then pass it to an internal system in the format it requires.
	// To perform this transformation on the data, you'll need to accept incoming data as a string, parse it into smaller data elements, then manipulate it to match a different format. But how can you parse the string data into smaller data elements?
	// STRING DATA TYPE'S ARRAY METHODS
// The variables of type string have many built-in methods that convert a single string into either an array of smaller strings, or an array of individual characters.
// When processing data from other computer systems, sometimes it's formatted or encoded in a way that's not useful for your purposes. In those cases, you can use the string data type's Array methods to parse a larger string into an array.
// STEP 1 - USE THE TOCHARARRAY() TO REVERSE A STRING


string value = "abc123";
char[] valueArray = value.ToCharArray();
Here we're using the ToCharArray() method to create an array of char, each element of the array has one character of the original string.

// Step 2 - Reverse, then combine the char array into a new string

// Next, we'll reverse the order of the chars in the array, then use the Write method to combine them back into a single output.

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

// The expression new string(valueArray) creates a new empty instance of the System.String class (which is the same as the string data type in C#) and passes in the char array as a constructor.
					Note
/*
What is the new keyword? How is the System.String class related to the string data type in C#? What is a constructor? All great questions that unfortunately are out of scope for this module. We recommend you keep learning about the .NET Class Library as well as classes and objects in C# to fully understand what is going on behind the scenes with this expression of code. For now, we recommend you use a search engine and Microsoft Docs to find good examples you can use in situations like this where you know you want to perform a conversion but are not sure how to do it using C#.
If you run the code now, you see the following output.
*/
Output

321cba

// STEP 3 - COMBINE ALL OF THE CHARS INTO A NEW COMMA-SEPARATED-VALUE STRING USING JOIN

/* Perhaps we need to separate each element of the char array using a comma, as is common when working with data that is represented as ASCII text. To do that, we'll comment out the line of code we added in Step 2 and use the String class' Join() method, passing in the char we want to delimit each segment (the comma) and the array itself.
*/

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);
// When you run the code, you should see the following output.
Output

3,2,1,c,b,a

// STEP 4 - SPLIT THE NEW COMMA-SEPARATED-VALUE STRING INTO AN ARRAY OF STRINGS
/*
Finally, let's use the Split() method available to variables of type string to create an array of strings. We'll use the comma as the delimiter to split one long string into smaller strings. Finally, we'll loop through each element of the new array of string.
Add the following lines of code in the .NET Editor.
*/

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
// Once you update the code in the .NET Editor, your code should match the following code passage.

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
// When you run the code, you'll see the following output.
Output

Copy
3,2,1,c,b,a
3
2
1
c
b
a
				// Recap
// Here's a few things to remember when working with strings and arrays:
	// There's several methods and techniques that allow you to convert a string to an array, and from an array to a string
	// Use methods like ToCharArray() and Split() to create an array
	// Use methods like Join(), or create a new string passing in an array of char to turn the array back into a single string

