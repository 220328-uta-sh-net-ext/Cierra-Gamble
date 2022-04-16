

// Beginner's Guide To Console Input In C#

	// ConsoleInput.md
// Beginner's Guide To Console Input In C#

// Note: I recommend reading this gist in order because Examples 1-6 build on each other.

// EXAMPLE 1: GETTING CONSOLE INPUT WITH CONSOLE.READLINE
	// How to get console input.
// EXAMPLE 2: PARSING THE CONSOLE INPUT FROM STRING TO INT32
	// How to convert the console input into a numeric value.
// EXAMPLE 3: VALIDATING CONSOLE INPUT WITH INT32.TRYPARSE
	// How to validate numeric input to prevent bugs in your code.
// EXAMPLE 4: LOOPING UNTIL USER PROVIDES VALID INPUT
	// How to continually ask for input until the user provides valid input.
// EXAMPLE 5: ADDITIONAL VALIDATION (0-100)
	// How to add custom validation logic on the user input.
// EXAMPLE 6: OPTIONAL CODE STYLE CHANGES OVER EXAMPLE 5
	// How to clean up your code a bit.
// EXAMPLE 7: ANOTHER EXAMPLE... ARRAY OF POSSIBLE INPUTS
	// How to allow input from an array of possible inputs.
// EXAMPLE 8: ANOTHER EXAMPLE... MULTIPLE INPUTS AT ONCE
	// How to allow users to input multiple values at once.
// EXAMPLE 9: WATCHING INDIVIDUAL KEY PRESSES WITH CONSOLE.READKEY
	// How to watch each individual key press from the user.
// EXAMPLE 10: FLUSHING THE INPUT BUFFER
	// How to prevent console input.
//EXAMPLE 11: MENU-BASED CONSOLE INPUT
	// How to easily manage menus in the console.
//EXAMPLE 12: GENERIC CONSOLE INPUT METHOD
	// How to write a generic console input method with delegates and optional parameters.
//EXAMPLE 13: USING REFLECTION TO MAKE EXAMPLE 12'S TRYPARSE OPTIONAL
	// How to simplify the usage of generic code using reflection.
// MAKE SURE YOU HAVE A USING SYSTEM; ARE THE TOP OF YOUR FILE. THEN WHENEVER YOU WANT INPUT FROM THE USER JUST USE THE CONSOLE.READLINE() METHOD.

// EXAMPLE 1: GETTING CONSOLE INPUT WITH CONSOLE.READLINE

using System;

class Program
{
	static void Main()
	{
		Console.Write("Provide input: ");
		string input = Console.ReadLine();
		Console.WriteLine($"Your input: {input}");

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}
}
// LEARNED:
	//Console.Write(...)
	// string
	// = Assignment
	// Console.ReadLine()
	// Console.WriteLine(...)
	// $ String Interpolation

// So in EXAMPLE 1, we are successfully getting input from the user. The input is stored in the input variable and is a string data type. The string data type is not a numerical data type, therfore if you wanted to perform math operations on the input such as int doubleInput = 2 * input; it will not work. So the next step is to convert the data type from string to whatever type you need it to be. For this example we will convert the type from string to int.

// EXAMPLE 2: PARSING THE CONSOLE INPUT FROM STRING TO INT32

using System;

class Program
{
	static void Main()
	{
		Console.Write("Please enter an integer: ");
		string input = Console.ReadLine();
		int inputValue = int.Parse(input); // <- This is a bug!
		Console.WriteLine($"Your input: {inputValue}");

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}
}
int
int.Parse(...)

// NOTE: There are numerous C# tutorials that use the Convert.ToInt32(...) method, but you should avoid this method. Convert.ToInt32(...) is an old method from before NET Framework 2.0, and we now have better methods to use isntead.

	// EXAMPLE 2 shows how you can convert a string to an int using the int.Parse(...) method. It works when the user provides valid input such as 123, but it will throw an exception at runtime if the user provides invalid input such as duck. Thus, this is a bad practice and should be avoided or you may run into bugs in your software. The next step would be to validate the input rather than just trying to directly parse it into an int.

// EXAMPLE 3: VALIDATING CONSOLE INPUT WITH INT32.TRYPARSE

using System;

class Program
{
	static void Main()
	{
		Console.Write("Please enter an integer: ");
		string input = Console.ReadLine();
		int inputValue;
		bool success = int.TryParse(input, out inputValue);
		if (success)
		{
			Console.WriteLine($"Your input: {inputValue}");
		}
		else
		{
			Console.WriteLine($"Invalid Input.");
		}

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}
}
int.TryParse(...)
if-else

// An "out" parameter is a way for methods to pass back more than one value. The int.TryParse method is passing back two values to the calling code:

	// The bool return value that indicates if the parse was successful. In Example 3 we are storing this value in the success variable.

	// The int typed out parameter that is the resulting value of the parse. In 

// Example 3 we are storing this value in the inputValue variable.

// Example 3 shows how to validate that the input from the user using the int.TryParse method. We just need use branching (in this case an if statement) to check if the return value of int.TryParse is true (successful) or false (unsuccessful).

// Now we have proper input validation for int data types, but what if you need a valid input in order to continue? The next step is to loop until the user provides valid input.

// EXAMPLE 4: LOOPING UNTIL USER PROVIDES VALID INPUT

using System;

class Program
{
	static void Main()
	{
		Console.Write("Please enter an integer: ");
		string input = Console.ReadLine();
		int inputValue;
		bool success = int.TryParse(input, out inputValue);
		while (!success)
		{
			Console.WriteLine("Invalid Input. Try again...");
			Console.Write("Please enter an integer: ");
			input = Console.ReadLine();
			success = int.TryParse(input, out inputValue);
		}
		Console.WriteLine($"Your input: {inputValue}");

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}
}
while

// Example 4 shows how we can continually request input from the user until valid input is provided. When we get past the while loop, we are guaranteed that the inputValue variable has been populated by a valid user input. However, what if we need to validate that value further? What if we want it to only be condsidered valid input if the value is between 0 and 100? The next step is to add additional validation.

// EXAMPLE 5: ADDITIONAL VALIDATION (0-100)

using System;

class Program
{
	static void Main()
	{
		Console.Write("Please enter an integer (0-100): ");
		string input = Console.ReadLine();
		int inputValue;
		bool success = int.TryParse(input, out inputValue);
		bool valid = success && 0 <= inputValue && inputValue <= 100;
		while (!valid)
		{
			Console.WriteLine("Invalid Input. Try again...");
			Console.Write("Please enter an integer 0 and 100: ");
			input = Console.ReadLine();
			success = int.TryParse(input, out inputValue);
			valid = success && 0 <= inputValue && inputValue <= 100;
		}
		Console.WriteLine($"Your input: {inputValue}");

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}
}
// ! Logical Negation
// <= Less Than Or Equal To
// && Logical AND
// In Example 5 we added additional validation logic. Now when the loop ends we know that inputValue is a valid int value proviided by the user and it is in the 0-100 range. That is pretty much all you need to know to accept proper int input in your console applications.

	// Although Example 5 is fully functional, we can shorten it a bit if we want to, but any changes at this point are code style preferences and are not required. In particular though, it would be nice if we created variables for the min and max ranges of the valid user input and used a variable for the message to provide input from the user to prevent duplicated hard-coded string values.

// EXAMPLE 6: OPTIONAL CODE STYLE CHANGES OVER EXAMPLE 5

using System;

class Program
{
	static void Main()
	{
		int min = 0;
		int max = 100;
		int inputValue;
		string prompt = $"Please enter an integer ({min}-{max}): ";
		Console.Write(prompt);
		while (!int.TryParse(Console.ReadLine(), out inputValue) || inputValue < min || max < inputValue)
		{
			Console.WriteLine("Invalid Input. Try Again...");
			Console.Write(prompt);
		}
		Console.WriteLine($"You input the value: {inputValue}");

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}
}
|| Logical OR
< Less Than
There are ways to simplify the code even further by making your own methods, but these examples should have given you all you need to get started writing your own interactive console applications in C#. :)

Examples 1-6 give you all the fundamentals you need to get console input from the user, but if you are struggling to modify the examples to fit your needs, maybe some more examples will help. Here is an example where the user can select a mathematical operation from a set of values inside an array.

// EXAMPLE 7: ANOTHER EXAMPLE... ARRAY OF POSSIBLE INPUTS

using System;
using System.Linq;

class Program
{
	static void Main()
	{
		string[] operators = new[] { "+", "-", "*", "/" };
		string input;
		string prompt = $"Please enter an operator ({string.Join(", ", operators)}): ";
		Console.Write(prompt);
		while (!operators.Contains(input = Console.ReadLine()))
		{
			Console.WriteLine("Invalid Input. Try Again...");
			Console.Write(prompt);
		}
		Operator inputOperator = input switch
		{
			"+" => Operator.Addition,
			"-" => Operator.Subtraction,
			"*" => Operator.Multiplication,
			"/" => Operator.Division,
			_ => throw new NotImplementedException("unexpected operator"),
		};
		Console.WriteLine($"You selected: {inputOperator}");

		Console.WriteLine("Press [enter] To Exit...");
		Console.ReadLine();
	}
}

public enum Operator
{
	Addition,
	Subtraction,
	Multiplication,
	Division,
}
enum
Arrays
string.Join(...)
Enumerable.Contains(...)
switch (expression)
throw
NotImplementedException

// In Example 7 the user may select one of four operators: 
	// Addition (+), Subtraction (-), Multiplcation (*), and Division (/). 
// The program will loop until the user selects a valid operator. After a valid operator is selected, the program uses a switch expression to convert the input string into an Operator value. Although it is not necessary to convert the string into an enum, it is a good practice that will result in better code.

// You might want to make it easier on the user and let them input multiple values at once. You don't need to, but I would probably recommend making helper methods for this. Lets see an example for handling multiple int inputs at once.

// Example 8: Another Example... Multiple Inputs At Once

using System;

class Program
{}
	static void Main()
	{
		int[] inputValues;
		string prompt = $"Please enter multiple integers (1, 2, 3): ";
		Console.Write(prompt);
		while (!TryParseIntegerList(Console.ReadLine(), out inputValues))
		{
			Console.WriteLine("Invalid Input. Try Again...");
			Console.Write(prompt);
		}
		Console.WriteLine($"You input the values: {string.Join(", ", inputValues)}");

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}

	public static bool TryParseIntegerList(string input, out int[] inputValues)
	{
		inputValues = default;
		string[] splits = input.Split(",");
		int[] result = new int[splits.Length];
		for (int i = 0; i < splits.Length; i++)
		{
			if (!int.TryParse(splits[i].Trim(), out result[i]))
			{
				return false;
			}
		}
		inputValues = result;
		return true;
	}
	}
}
}
string.Split(...)
for
string.Trim()

// In Example 8 we take in a line of input from the user that should contain multiple int values seperated by commas. If any of the values are not valid int values it is considered invalid and the user must try again. Once we have the input from the user, the first step is to divide the string up into each seperate value, which Example 8 does using the string.Split(...) method. There are other ways to parse strings than using the string.Split(...) method, but that is one of the easiest ones for beginners. Once each input is seperated, we just need to int.TryParse each value to make sure they are all valid, and store them in an array. The string.Trim() method just removes any white space on the front or back of a string so the users can add spaces in their input if they want to. All of the following are acceptable inputs for example:

1,2,3,4,5
1, 2, 3, 4, 5
1,2, 3, 4,5

// EXAMPLE 9: WATCHING INDIVIDUAL KEY PRESSES WITH CONSOLE.READKEY

using System;

class Program
{
	static void Main()
	{
		ConsoleKey continueKey = ConsoleKey.C;
		Console.Write($"Press [{continueKey}] to continue...");
		while (Console.ReadKey(true).Key != continueKey)
		{
			// do nothing until they press the correct key
		}
		Console.WriteLine();
		Console.WriteLine($"You pressed {continueKey}.");

		Console.Write("Press [enter] to continue...");
		Console.ReadLine();
	}
}
ConsoleKey
Console.ReadKey
ConsoleKeyInfo.Key
!= Inequality
Example 9 shows how you can watch individual key presses from the user rather than taking in a full string of input. You can do this with the Console.ReadKey(...) method. In this case, Example 9 is requesting that the user press the C key before the program will continue. The Console.ReadKey(...) method also allows you to intercept the input so that the input is accepted but will not be written to the console. Whether or not you want to intercept the input is determined by the parameter on the Console.ReadKey(...) method.

We have discussed most topics regarding getting an handling console input, but what if we want to prevent console input?

Example 10: Flushing The Input Buffer

using System;

class Program
{
	static void Main()
	{
		Console.Write("Press [enter] to start (~10 seconds)...");
		Console.ReadLine();

		// Imagine there is a lot of code in here that takes
		// ~10 seconds to complete. For this example I'm
		// just sleeping the thread to simulate this.
		System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));

		// By flushing the console input buffer after the ~10 seconds
		// of processing, we are effectively disabling all input during
		// during that processing. If we don't flush the buffer, then
		// that input would be rendered to the console and would effect
		// the rest of our code.
		while (Console.KeyAvailable)
		{
			Console.ReadKey(true);
		}

		Console.Write("Press [enter] to exit...");
		Console.ReadLine();
	}
}
Console.KeyAvailable
// Example 10 demonstrates how you can prevent console input. It is flushing the input buffer by continually calling Console.ReadKey until there are no more keys available. Thus, any key presses that occured prior to the flush are ignored.

// Example 11: Menu-Based Console Input

using System;

class Program
{
	static void Main()
	{
		ConsoleHelper.Menu(
			("Option 1", Option1),
			("Option 2", Option2),
			("Option 3", Option3));

		Console.WriteLine();

		// or... if want to customize the output
		ConsoleHelper.Menu(
			title: "This is my menu...",
			prompt: "Please choose an option: ",
			invalidMessage: "Wrong...",
			("Option 1", Option1),
			("Option 2", Option2),
			("Option 3", Option3));

		Console.WriteLine("Press [enter] to continue...");
		Console.ReadLine();
	}

	public static void Option1()
	{
		Console.WriteLine("You chose option 1.");
	}

	public static void Option2()
	{
		Console.WriteLine("You chose option 2.");
	}

	public static void Option3()
	{
		Console.WriteLine("You chose option 3.");
	}
}

public static class ConsoleHelper
{
	public static void Menu(params (string DisplayName, Action Action)[] options) =>
		Menu(null, null, null, options);

	public static void Menu(
		string title = null,
		string prompt = null,
		string invalidMessage = null,
		params (string DisplayName, Action Action)[] options)
	{
		// handling parameters
		if (options is null)
		{
			throw new ArgumentNullException(nameof(options));
		}
		if (options.Length <= 0)
		{
			throw new ArgumentException($"{options} is empty", nameof(options));
		}
		title ??= "Menu...";
		prompt ??= $"Choose an option (1-{options.Length}): ";
		invalidMessage ??= "Invalid Input. Try Again...";

		// render menu
		Console.WriteLine(title);
		for (int i = 0; i < options.Length; i++)
		{
			Console.WriteLine($"{i + 1}. {options[i].DisplayName}");
		}

		// get user input
		int inputValue;
		Console.Write(prompt);
		while (!int.TryParse(Console.ReadLine(), out inputValue) || inputValue < 1 || options.Length < inputValue)
		{
			Console.WriteLine(invalidMessage);
			Console.Write(prompt);
		}

		// invoke the action relative to the user input
		options[inputValue - 1].Action?.Invoke();
	}
}
Action
ArgumentNullException
ArgumentException
paramter = x Optional Arguments
parameter: x Named Arguemnts
is
nameof
?? Null-Coalescing

// There are lots of ways to implement menus in the console, but Example 11 has a helper method that takes an array of string's and Action's as a parameter. The DisplayName string is the string as it will appear to the user in the menu and the Action is what code will be called when the user selects that option. The code for rendering the menu and getting the user input are dynamic based on the size of the array, so all you need to do is add more parmeters and the helper method takes care of the rest for you.

//What if you want to loop the menu and add an "Exit" option to Example 11? Here is another snippet of what that can look like:

bool exit = false;
while (!exit)
{
	ConsoleHelper.Menu(
		("Option 1", Option1),
		("Option 2", Option2),
		("Option 3", Option3),
		("Exit", () => exit = true));
	Console.WriteLine();
}
x => y Lambda Expressions
Console Games Examples

//Are you wanting to learn how to code games? Even if you aren't interested in game development, making console games is a great way to learn how to program in C#. I have a GitHub repo with examples of console games if you want to give it a look. Many of the games use simple console input techniques like the examples in this gist: https://github.com/ZacharyPatten/dotnet-console-games

//Good Luck!

//If you are still relatively new to C# I recommend you stop here. I do not recommend beginners attempt to simplify console input further than the previous examples in this gist. However, the following examples show how we can create helper methods to simplify console input to a single line of code.

Example 12: Generic Console Input Method

using System;

class Program
{
	static void Main()
	{
		var a = ConsoleHelper.GetInput<int>(
			tryParse: int.TryParse);

		var b = ConsoleHelper.GetInput<double>(
			prompt:         "Give me an double (0-100): ",
			invalidMessage: "Invalid...",
			tryParse:       double.TryParse,
			validation:     v => 0 <= v && v <= 100);

		Console.WriteLine("You input the values:");
		Console.WriteLine($"- {a}");
		Console.WriteLine($"- {b}");

		Console.WriteLine("Press [enter] to exit...");
		Console.ReadLine();
	}
}

public delegate bool TryParse<T>(string @string, out T value);

public static class ConsoleHelper
{
	public static T GetInput<T>(
		TryParse<T> tryParse,
		string prompt = null,
		string invalidMessage = null,
		Predicate<T> validation = null)
	{
		_ = tryParse ?? throw new ArgumentNullException(nameof(tryParse));
	GetInput:
		Console.Write(prompt ?? $"Input a {typeof(T).Name} value: ");
		if (!tryParse(Console.ReadLine(), out T value) || !(validation is null || validation(value)))
		{
			Console.WriteLine(invalidMessage ?? $"Invalid input. Try again...");
			goto GetInput;
		}
		else
		{
			return value;
		}
	}
}
typeof
delegate
<T> Generics
Predicate<T>
Type.Name
goto
_ Discards
Example 12 shows how we can make a generic console input method. It uses optional parameters, so you don't need to provide a prompt, invalidMessage, or validation unless you want to customize them, but the tryParse parameter is still a required parameter for the method to work. A delegate is a fuction pointer in C#. In this example we are requesting the calling code to provide the TryParse method for the relative generic type.

Example 13: Using Reflection To Make Example 12's TryParse Optional

Note: This example is dependent on the Towel nuget package. The Towel nuget package must be added as a dependency for the code to build and run.

// Depedent on Towel nuget Package
using System;
using Towel;
using static Towel.Syntax;

class Program
{
	static void Main()
	{
		var a = ConsoleHelper.GetInput<int>();
		var b = ConsoleHelper.GetInput<double>();
		var c = ConsoleHelper.GetInput<string>();
		var d = ConsoleHelper.GetInput<int>(
			prompt: "Insert your favorite integer: ",
			invalidMessage: "Don't be a moron...");
		var e = ConsoleHelper.GetInput<Direction>(
			prompt: "Insert Left or Right: ");
		var f = ConsoleHelper.GetInput<int>(
			prompt: "Insert an integer (0-100): ",
			validation: value => 0 <= value && value <= 100);

		Console.WriteLine("You input the values:");
		Console.WriteLine($"- {a}");
		Console.WriteLine($"- {b}");
		Console.WriteLine($"- {c}");
		Console.WriteLine($"- {d}");
		Console.WriteLine($"- {e}");
		Console.WriteLine($"- {f}");

		Console.WriteLine("Press [enter] to exit...");
		Console.ReadLine();
	}
}
public enum Direction
{
	Left,
	Right
}
public static class ConsoleHelper
{
	public static T GetInput<T>(
		string prompt = null,
		string invalidMessage = null,
		TryParse<T> tryParse = null,
		Predicate<T> validation = null)
	{
		if (tryParse is null && (typeof(T) != typeof(string) && !typeof(T).IsEnum && Meta.GetTryParseMethod<T>() is null))
		{
			throw new InvalidOperationException($"Using {nameof(ConsoleHelper)}.{nameof(GetInput)} without providing a {nameof(tryParse)} delegate for a non-supported type {typeof(T).Name}.");
		}
		tryParse ??= typeof(T) == typeof(string)
			? (string s, out T v) => { v = (T)(object)s; return true; }
			: (TryParse<T>)TryParse;
		validation ??= v => true;
	GetInput:
		Console.Write(prompt ?? $"Input a {typeof(T).Name} value: ");
		if (!tryParse(Console.ReadLine(), out T value) || !validation(value))
		{
			Console.WriteLine(invalidMessage ?? $"Invalid input. Try again...");
			goto GetInput;
		}
		return value;
	}
}
Towel.Syntax.TryParse
Towel.Meta.GetTryParseMethod
?: Conditional Operator
InvalidOperationException
Type.IsEnum

//Example 13 is using a dependency, but what is happening under the hood is we are using reflection to look up the TryParse method for the relative generic type so that the tryParse parameter can be made optional. This will work with any type that has a static TryParse method with the expected signature, enum types, or string. If your type does not fit those requirements you can always provide you own tryParse parameter.

Feel free to leave a comment below! :)

 

