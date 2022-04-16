// CODE BLOCKS DEFINE METHODS, CLASSES, AND NAMESPACES

/*
Exercise - Code blocks and variable scope
Completed
100 XP
5 minutes
A code block is one or more C# statements that define an execution path. Typically the statements outside of the code block affect when, if and how often that block of code is executed at run time.
Code blocks also affect variable scope, and the following exercise will help you understand how this affects your code.
Code blocks impact the scope of a variable declaration
Variable scope is the visibility of the variable to the other code in your application. A locally scoped variable is only accessible inside of the code block in which it's defined. If you attempt to access the variable outside of the code block, you'll get a compiler error.
*/

// STEP 1 - CREATE A VARIABLE INSIDE OF A CODE BLOCK

// Add the following code into the .NET Editor:

bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
//		RUN THE CODE

// What if we want to access the variable value outside of if statement's code block?

// STEP 2 - ATTEMPT TO ACCESS THE VARIABLE OUTSIDE OF THE CODE BLOCK IN WHICH IT WAS DEFINED

// Below the if statement's code block, add the following line of code:
Console.WriteLine($"Outside of code block: {value}");
// SO ENTIRE CODE SHOULD LOOK LIKE THIS

bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine($"Outside of code block: {value}");

//  ERROR WILL COME UP IF RAN BY ITSELF

/*
The problem is that a variable defined in a code block is only accessible (or rather, visible) within that code block. The variable isn't accessible outside of the code block in which it's defined.
	A local variable is a variable defined in a method code block. We'll talk about method code blocks in the next unit.
*/

// STEP 3 - MOVE THE VARIABLE OUTSIDE

/* To access a variable from both an outer and inner code block (like the if statement's code block), you'll need to move the variable declaration outside of the if statement's code block so that all the code has visibility to that variable.
*/

// Modify your code so that it matches the following code:

bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine("Outside of code block: " + value);

//  ERROR WILL COME UP IF RAN BY ITSELF

/* This is a simple problem to fix, however it gives us another insight into working with code blocks.
	If the line of code value = 10; were outside of the if statement's code block, the compiler would compile our application. However, since that line of code is inside the if statement's code block, there's a possibility that the variable will never be assigned a value, which the compiler won't allow.
*/

// STEP 4 - INITIALIZE THE VARIABLE WITH A VALUE

// To fix the "unassigned local variable" issue, we need to initialize the variable with a value. Update variable declaration to include an initialization.

int value = 0;

//  SO ENTIRE CODE SHOULD LOOK LIKE THIS

 bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine("Outside of code block: " + value);

// RUN THE CODE TO PRODUCE OUTCOME

// Code blocks define methods, classes, and namespaces

/*
Up until now, if you've followed the learning path on Microsoft Learn, we've only used code blocks to define the if-elseif-else and foreach statements. We'll continue to use them as we learn more decision and iteration statements, but code blocks are also critical to defining higher-level structures for our code.
*/

