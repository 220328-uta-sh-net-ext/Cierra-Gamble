/* In this module, you'll learn how data is stored and processed by the computer. You'll learn that there are two kinds of data types that correspond with the two ways that data is processed by the computer. You'll write code that identifies the maximum and minimum values that can be stored in a particular numeric data type, and will learn the criteria you should use when choosing between several numeric data types for your application.
By the end of this module, you'll be confident when working with different data types in C# and will be able to choose the right data type for your particular application.
Learning objectives
In this module, you will:
Learn the fundamental differences between value types and reference types.
Describe the properties of many new numeric data types, including new integral types and floating point types.
Write code that returns the maximum and minimum values that numeric data types can store.
Use the new keyword to create new instances of a reference type.
Determine which data type you should choose for a given application.
*/

		VALUE TYPES AND REFERENCE TYPES

/*
With so many different data types available in C#, choosing the right one to use means that you'll need to understand what each one does and when you might choose one data type over another.
But before we can discuss why you might choose one type over another, first you need to understand how data and data types work in C# and .NET, and learn about more data types, including key differentiations between similar data types.
			`WHAT IS A DATA TYPE?
A data type is a programming language construct that defines how much memory to reserve for a value. This is why we have so many data types -- because the designers of the programming language understand that it will be used for many different applications and sizes of data.
Given the type of applications you'll build in your career, you'll come to realize you settle on a small subset of all the available data types. However, it's still vital to know others exist and why.
		
		VALUE VS. REFERENCE TYPES
There are two basic categories of data types: value types and reference types. The fundamental difference between value and reference types concerns where those values are temporarily stored in memory as your application executes. Where the value is stored affects how the .NET runtime manages the life of the value including its declaration (birth), assignment and retrieval (life), and finalization (death). 
	This, in turn, impacts the syntax you use when working with either a value type or a reference type.
This module will focus on simple value and reference types. As you learn more about C#, new details will emerge related to the fundamental difference between value and reference types.
			Simple value types

Simple value types are a set of predefined types provided by C# as keywords. These keywords are merely aliases for predefined types defined in the .NET Class Library. For example, the C# keyword int is an alias of a value type defined in the .NET Class Library as System.Int32.
Simple value types include many of the data types that you may have used already like char and bool. 

	There are also many integral and floating-point value types to represent a wide range of whole and fractional numbers.
*/
/*

					WHAT IS DATA?
Answering the question "what is data" depends on who you ask, and in what context you're asking it.
In software development, data is essentially a value that is stored in the computer's memory as a series of bits. A bit is a simple binary switch represented as a 0 or 1, or rather, "off" and "on", respectively. A single bit doesn't seem useful, however when you combine 8 bits together in a sequence, they form a byte. When used in a byte, each bit takes on a meaning in the sequence. In fact, you can represent 256 different combinations with just 8 bits if you use a binary (or rather, base-2) numeral system.
	For example, in a binary numeral system, you can represent the number 195 as 11000011. The following table will help you visualize how this works. The first row has 8 columns that correspond to a position in a byte. Each position represents a different numeric value. The second row can store the value of an individual bit, either 0 or 1.
*/

/*
			WHAT ABOUT TEXTUAL DATA?

If a computer only understands 0s and 1s, then how does it allow us to work with text? Using a system like ASCII, you can use a single byte to represent upper and lowercase letters, numbers, tab, backspace, newline and many mathematical symbols, blocks, lines, and so on.
	For example, if I wanted to store a lower-case letter a as a value in my application, the computer would only understand the binary form of that value. If I wanted to better understand how it's handled by the computer, I would first need to locate an ASCII table that provides a lookup of ASCII values and their decimal equivalents. You can search for the terms "ASCII lookup decimal" to locate such a resource online.
In this case, the lower-case letter a is equivalent to the decimal value 97. Then, I would use the same binary numeral system in reverse to find how an ASCII letter a is stored by the computer.
Or, rather, 64 + 32 + 1 = 97.
*/

/* It's likely that you'll never need to perform these types of conversions on your own, but understanding the computer's perspective of data is a foundational concept, especially as we're considering data types.
			

					// RECAP
/*
Values are stored as bits, which are simple on / off switches. Combining enough of these switches allows you to store just about any possible value.
There are two basic categories of data types: value and reference types. The difference is in how and where the values are stored by the computer as your program executes.
Simple value types include signed and unsigned integral numeric types and floating-point numeric types.
*/

Exercise - Integral types

/*
In this exercise, you'll work with integral types. An integral type is a simple value type that represents whole numbers (non-fractional). The most popular in this category is the int data type.
There are two subcategories of integral types: signed and unsigned integral types.

				Signed integral Types
A signed type uses its bytes to represent an equal number of positive and negative numbers. The following exercise will give you exposure to the signed integral types in C#.
*/

// Step 1 - Use the MinValue and MaxValue properties for each signed integral type

// To see the value ranges for the various data types, type the following code into the .NET Editor.
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// STEP 2 - RUN THE CODE TO INSPECT EACH DATA TYPE'S RANGE OF VALUES

		// You should see the following output.
Signed integral types:
sbyte  : -128 to 127
short  : -32768 to 32767
int    : -2147483648 to 2147483647
long   : -9223372036854775808 to 9223372036854775807

/* For most non-scientific applications, you will likely only need to work with int. Most of the time, you will not need more than a positive to negative 2.14 billion whole numbers.

			Unsigned integral types
An unsigned type uses its bytes to represent only positive numbers. The remainder of the exercise introduces the unsigned integral types in C#.
*/

// STEP 3 - USE THE MINVALUE AND MAXVALUE PROPERTIES FOR EACH UNSIGNED INTEGRAL TYPE

	// Below the previous code passage, add the following code.
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// STEP 4 - RUN THE CODE TO INSPECT EACH DATA TYPE'S RANGE OF VALUES

	// If you run the code, you'll see the following output.
Output

Copy
Signed integral types:
sbyte  : -128 to 127
short  : -32768 to 32767
int    : -2147483648 to 2147483647
long   : -9223372036854775808 to 9223372036854775807

Unsigned integral types:
byte   : 0 to 255
ushort : 0 to 65535
uint   : 0 to 4294967295
ulong  : 0 to 18446744073709551615

/* While a given data type can be used for any purpose, given the fact that the byte data type can represent a value from 0 to 255, it's obvious that this is intended to hold a value that represents a byte of data. Data stored in files or data transferred across the internet is often in a binary format. When working with data from these external sources, you will need to receive data as an array of bytes, then convert them into strings. Many of the methods in the .NET Class Library that deal with encoding and decoding data require you handle byte arrays.

					Recap
An integral type is a simple value data type that can hold whole numbers.
There are signed and unsigned data types. Signed integral types use one bit to store whether the value is positive or negative.
You can use the MaxValue and MinValue properties of numeric data types to evaluate whether a number can fit in a given data type.
*/

	// EXERCISE - FLOATING-POINT TYPES

/*
In this exercise, you'll work with floating-point data to learn about the nuanced differences between each data type.
A floating point is a simple value type that represents fractional numbers. Unlike integral numbers, there are other considerations beyond the maximum and minimum values you can store in a given floating-point type.

			Evaluate floating-point types
First, you must also consider the digits of precision each allow. Precision is the number of values that can be stored after the decimal point.
Second, you must consider the manner in which the values are stored and the impact that has on the accuracy of the value. In other words, float and double values are stored internally in a binary (base 2) format while decimal is stored in a decimal (base 10) format. Why does this matter?
Performing math on binary floating-point values can produce results that may surprise you if you're used to decimal (base 10) math. Often, binary floating-point math is an approximation of the real value. Therefore, float and double are useful because large numbers can be stored using a small memory footprint; however, should only be used when an approximation is useful. For example, being a few thousandths off when calculating the blast zone of a weapon in a video game is close enough.
When you need more a more precise answer, you should use decimal. Each value of type decimal has a relatively large memory footprint, however performing math operations gives you a more precise result. So, you should use decimal when working with financial data or any scenario where you need an accurate result from a calculation.
*/

// Step 1 - Use the MinValue and MaxValue properties for each signed float type

// To see the value ranges for the various data types, enter the following code into the .NET Editor.

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// STEP 3 - RUN THE CODE TO INSPECT EACH DATA TYPE'S RANGE OF VALUES

// If you run the code, you'll see the following output.

Floating point types:
float  : -3.402823E+38 to 3.402823E+38 (with ~6-9 digits of precision)
double : -1.79769313486232E+308 to 1.79769313486232E+308 (with ~15-17 digits of precision)
decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precision)

/* 
As you can see, float and double use a different notation than decimal to represent its largest and smallest possible values. But what does this notation mean?
Deciphering large floating-point values

Because floating-point types can hold large numbers with a lot of precision, their values can be represented using "E notation", which is a form of scientific notation that means "times ten raised to the power of." So, a value like 5E+2 would be the value 500 because it's the equivalent of 5 * 10^2, or 5 * 10 * 10.
					Recap
A floating-point type is a simple value data type that can hold fractional numbers.
Choosing the right floating-point type for your application requires you to consider more than just the maximum and minimum values that it can hold. You must also consider how many values can be preserved after the decimal, how the numbers are stored, and how their internal storage affects the outcome of math operations.
Floating-point values can sometimes be represented using "E notation" when the numbers grow especially large.
There's a fundamental difference in how the compiler and runtime handle decimal as opposed to float or double, especially when determining how much accuracy is necessary from math operations.
*/

// EXERCISE - REFERENCE TYPES

/*
Reference types include arrays, classes, and strings. Reference types are treated differently from value types with regards to the way values are stored when the application is executing.
In this exercise, we'll learn how reference types are different from value types, and how to use the new operator to associate a variable with a value in the computer's memory.
How reference types are different from value types
A value type variable will store its values directly in an area of storage called the stack. The stack is memory allocated to the code that is currently running on the CPU (also known as the stack frame, or activation frame). When the stack frame has finished executing, the values in the stack are removed.
A reference type variable will store its values in a separate memory region called the heap. The heap is a memory area that is shared across many applications running on the operating system at the same time. The .NET Runtime communicates with the operating system to determine what memory addresses are available, and requests an address where it can store the value. The .NET Runtime stores the value, and then returns the memory address to the variable. When your code uses the variable, the .NET Runtime seamlessly looks up the address stored in the variable, and retrieves the value that's stored there.
Let's write some code that illustrates these ideas more clearly.
*/

// Step 1- Define a reference type variable

	// The following code defines a variable that can hold a value of type int array.

int[] data;
// At this point, data is merely a variable that could hold a reference, or rather, a memory address of a value in the heap. Because it's not pointing to a memory address, it's called a null reference.

// STEP 2 - CREATE AN INSTANCE OF INT ARRAY USING THE NEW KEYWORD

// Modify the code from step 2 to create and assign a new instance of int array using the following code.

int[] data;
data = new int[3];
// The new keyword informs .NET Runtime to create an instance of int array, and then coordinate with the operating system to store it in memory. The .NET Runtime complies, and returns a memory address of the new int array. Finally, the memory address is stored in the variable data. The int array's elements default to the value 0, because that is the default value of an int.

// STEP 3 - MODIFY THE CODE EXAMPLE TO PERFORM BOTH OPERATIONS IN A SINGLE LINE OF CODE

// The two lines of code in step 3 are typically shortened to a single line of code to both declare the variable, and create a new instance of the int array. Modify the code from step 3 to the following.

int[] data = new int[3];
// While there is no output to observe, hopefully this exercise added clarity to how the C# syntax relates to the steps of the process for working with reference types.

// WHY IS THE C# STRING DATA TYPE DIFFERENT?

	// The string data type is also a reference type. You might be wondering why we do not use the new operator when declaring a string. This is purely a convenience afforded by the designers of C#. Because the string data type is used so frequently, we can use this format:

string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);
// Behind the scenes, however, a new instance of System.String is created and initialized to "Hello World!".
 					// Note
/*
When the language designers create a simplified shortcut, it is sometimes known as "syntactic sugar." You will likely see this phrase used in articles, videos, and in presentations.
Recap
Value types can hold smaller values and are stored in the stack. Reference types can hold large values, and a new instance of a reference type is created using the new operator. Reference type variables hold a reference (the memory address) to the actual value stored in the heap.
Reference types include arrays, strings, and classes.
*/

// CHOOSE THE RIGHT DATA TYPE


/*

You've been introduced to the difference between value types and reference types, as well as integral and floating point types.
	Suppose your job is to build a new application that retrieves, manipulates, and stores different types of data. Which data types will you choose.
	In some cases, it will be an easy choice. For example, when you need to work with text, then you'll likely default to using the string data type unless you need to perform a significant amount of concatenation.
But what about working with numeric data? There are 11 different options. How do you choose the right data type?
	HOW DO YOU CHOOSE THE RIGHT DATA TYPE?
With so many data types to choose from, what criteria should you use to choose the right data type for the particular situation?
	When evaluating your options, you must weigh several important considerations. Often there's no one single correct answer, but some answers are more correct than others.
	Choose the data type that has the desired value range as a built-in constraint in your application. Your choice of a data type can help to set the boundaries for the size of the data you might store in that particular variable. 
	
For example, if you know a particular variable should only store a number between 1 and 10,000 otherwise it's outside of the boundaries of what would be expected, you would likely avoid byte, sbyte since their ranges are too low. Furthermore, you would likely not need int, long, uint, and ulong because they can store much more data than is necessary. Likewise, you would probably skip float, double, and decimal if you didn't need fractional values. 
	You might narrow it down to short and ushort, both of which may be viable given the circumstances. If you're confident that a negative value would have no meaning in your application, you might choose ushort. Now, any value assigned to a variable of type ushort outside of the boundary of 0 to 65535 would throw an exception, thereby subtly helping you enforce a degree of sanity checking in your application.

	Don't choose the data type based on what you perceive will be the impact to performance (at least, not at first). You may be tempted to choose the data type that uses the fewest bits to store data thinking it will improve your application's performance. However, some of the best advice related to application performance (that is, how fast your application runs) is to not "prematurely optimize". In other words, you should resist the temptation to guess at the parts of your code, including the selection of data types, that may impact your application's performance. 
	
	Many assume that because a given data type stores less information it must use less of the computer's processor and memory than a data type that stores more information. Instead, you should choose the right fit for your data, then later you can empirically measure the performance of your application using special software that provides factual insights to the parts of your application that negatively impact performance.

Choose the data type based on the interaction with library functions and the data types of their inputs and outputs. Suppose you want to work with a span of years between two dates.

 Given that this is a business application, you might determine that you only need a range from about 1960 to 2200. This might lead you to work with byte since it can represent numbers between 0 and 255. 
 	However, when you look at the built-in methods on the System.TimeSpan and System.DateTime classes, you realize they mostly accept values of type double and int. 
 
 If you choose sbyte, you'll constantly be casting back and forth between sbyte and double or int. In this case, it might make more sense to choose int if you don't need subsecond precision, and double if you do need subsecond precision.

Choose the data type based on the impact to other systems such as long-term storage in a database. Sometimes, you must consider how the information will be consumed by other applications or other systems like a database. 
	For example, SQL Server's type system is different from C#'s type system. As a result, some mapping between the two must happen before you can save data into that database. If your application's purpose is to interface with a database, then you would likely need to consider how the data will be stored, how much data will be stored, and how choosing a larger data type might impact the amount (and cost) of the physical storage required to store all the data your application will generate.
WHEN IN DOUBT, STICK WITH THE BASICS. While we have looked at several considerations, which often lead you to consider many different data types, as you're getting started, for simplicity's sake you should prefer a subset of basic data types, including:
	int for most whole numbers
	decimal for numbers representing money
	bool for true or false values
	string for alphanumeric value
CHOOSE SPECIALTY COMPLEX TYPES FOR SPECIAL SITUATIONS. DON'T REINVENT DATA TYPES IF ONES ALREADY EXIST FOR A GIVEN PURPOSE.
	byte for working with encoded data that comes from other computer systems or using different character sets.
	double for working with geometric or scientific purposes. double is used frequently when building games involving motion.
	System.StringBuilder to build a single string from lots of literals or other variables. We'll cover this in more detail in the module "Modify content of strings using built-in string data type methods in C#".
	System.DateTime for a specific date and time value. We'll cover this in more detail in the module "Manipulate date and time data using the DateTime and TimeSpan classes in C#".
	System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds. We'll cover this in more detail in the module "Manipulate date and time data using the DateTime and TimeSpan classes in C#".

						Recap
There's several considerations when choosing data types for your code. However, while you should be careful and think through your choices, if you stick with some of the basic types like int, decimal, string, and bool, you'll likely be fine.
*/