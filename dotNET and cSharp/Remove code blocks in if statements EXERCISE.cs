// REMOVE CODE BLOCKS IN IF STATEMENTS

/*
Software developers love when they can write code that saves keystrokes and visual space without sacrificing readability. In some cases, less is more -- as long as it makes the code more readable and understandable.
You may not need an entire code block
If the code block needs only one line of code, chances are you don't need to define a formal code block using curly braces, nor do you need to separate your code into multiple lines.
Making these changes is merely stylistic and shouldn't affect the functionality at all although it might impact how readable the code is. You may try to remove the curly braces and white space, then decide to revert if you find that the code is less readable.
Step 1 - Create an example of an if statement that uses a code block
*/

// Add the following code to the code window.
bool flag = true;
if (flag)
{
    Console.WriteLine(flag);
}
// RUN THE CODE

/*
Since we're merely executing a single line of code if the flag is true, we can remove the curly braces.
Modify the code from the previous step to match the following code example.
*/

bool flag = true;
if (flag)
    Console.WriteLine(flag);

/* 
If you run the code, the output will be the same. However, there's two fewer lines of code.
Step 3 - Remove the line feed

Since both the if statement and the method call to Console.WriteLine() are short, we could choose to combine them to a single line.
*/

bool flag = true;
if (flag) Console.WriteLine(flag);

// If you run the code, the output will be the same. However, there's now three fewer lines of code than when we started.

// Step 4 - Write else if and else statements without code blocks

// Just to illustrate how to use else if and else statements without code blocks, add the following code to the .NET Editor.
string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");
// When you run the code, it should produce the following output.
	Found Steve

//These lines of code look dense and hard to read. You may want to reformat the code to include a line break after the if, else if, and else statements.

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");


//  However, when you need to perform a comparison around a single value with multiple possible options, you may want to consider using the switch statement instead. We cover the switch statement in the module "Branch the flow of code using the switch-case construct in C#".

			// Recap
/* Here are a few important things to remember about code blocks:
If you realize you only have one line of code in a code block, you can remove the curly braces and white space.
Only remove code blocks when it makes the code more readable.
Only remove the line feed if it makes the code more readable. */
