// Add looping logic to your code using the do-while and while statements

// In this module, you will:
// Write code that uses the do-while statement to iterate through a code block.
// Write code that uses the while statement to iterate through a code block.
// Use the continue statement to step directly to the Boolean evaluation.
/* The do-while and while statements allow us to control the flow of code execution by looping through a block of code until a condition is met. When working with the foreach statement, we iterate once for each item in sequence, such as an array. The for statement allows us to iterate a pre-determined number of times, and control the process of iteration. The do-while and while statements allow us to iterate through a block of code with the intent that the logic inside of the code block will affect when we can stop iterating.
Suppose you want to accept and process user input. You want to continue accepting and processing input until the user presses the q key for "quit". You can use the do-while and the while statements to keep iterating through the logic to accept user input and process it until the user is ready to stop.
In this module, you'll use the do-while statement and the while statement to iterate through code block. You'll understand when to choose one over the other. You'll use the continue statement to skip processing the remainder of code in the code block and go directly to the Boolean evaluation of the while statement.
By the end of this module, you will be able to confidently use the do-while and while statements to add looping logic to your application.*/

// On the surface, the do-while and while statements are yet another iteration statement that allows you to iterate through a code block and thereby change the flow of execution of your code. However, once we examine how each works, we can better identify the nuances of each iteration statement and when to use them.

//What is the do-while statement?
// The do statement executes a statement or a block of statements while a specified Boolean expression evaluates to true. Because that expression is evaluated after each execution of the loop, a do-while loop executes one or more times.

do
{
    // This code executes at least one time
} while (true)

// The flow of execution starts inside of the curly brace. The code executes at least one time, then the Boolean expression next to the while keyword is evaluated. If the Boolean expression returns true, the code block is executed again.
// By hard coding the Boolean expression to true, we've created an infinite loop -- a loop that will never end, at least, not as it's currently written. We would need a way to break out of the loop inside of the code block. We'll discuss this more in a bit.
// STEP 1 - WRITE A DO-WHILE STATEMENT TO BREAK WHEN A CERTAIN RANDOM NUMBER IS GENERATED

// Let's write code that will keep generating random numbers between 1 and 10 until we generate the number 7. This could take one iteration, or could possibly take dozens of iterations.
Add the following code to the .NET Editor.

Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
// 			RUN THE CODE

// The key idea in this step of the exercise is that the code in the code block will execute at least once.
// It's also important to notice that the code inside of the code block is influencing whether to continue iterating through the code block or not. That is a key distinguishing characteristic of the do-while and while statements. Both the foreach and for rely on external factors to the code block to determine whether the flow of execution should continue executing the code block.
// STEP 2 - WRITE A WHILE STATEMENT THAT ITERATES ONLY WHILE A RANDOM NUMBER IS GREATER THAN SOME VALUE

Update the code in the .NET Editor to match the following code example that uses the while statement without the do keyword.

Random random = new Random();
int current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

// In this case, we position the while keyword and the Boolean expression before the code block. This changes the meaning of the code and acts as a "gate" to only allow the flow of execution to enter if the Boolean expression evaluates to true.
// Run the code. 
	// You'll likely see different results, however if the current variable is initialized to a value less than 3 then the Boolean expression next to the while statement will return false, and the code block will never execute. However, if the current variable is initialized to a value greater or equal to 3, then the flow of execution will enter the code block. 
// Inside the code block, the value of current is updated with a new random value and the Boolean expression will be evaluated repeatedly. Once the Boolean expression returns false, the flow of execution will break from the code block and will print the last value of current.

// STEP 3 - USE THE CONTINUE STATEMENT TO STEP DIRECTLY TO THE BOOLEAN EXPRESSION

// In certain cases, we want to short-circuit the remainder of the code in the code block and continue to the next iteration. We can do that using the continue statement.
Update the code in the .NET Editor with the following code.

Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);


while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

/* The key to this step of the exercise is the following line of code:

if (current >= 8) continue;
If the value of current is set to a random value greater or equal to 8, then we will skip the next line of code, which prints the value to the output window.
Run the code. Again, you'll likely see different results than what is displayed below. However, you will not see any values 8 or greater in the output window before the code's execution ends with the value 7.
*/
5
1
6
7

// As you can see, continue will skips execution of current iteration so that nothing greater than 7 is printed.
// This is in contrast to the break keyword which we learned about earlier. The break keyword stops executing the while loop entirely and the execution path moves on with the remainder of the code logic.
// 					Recap
// There's a few important ideas you should take away from this unit:
// The do-while statement iterates through a code block at least once, and may continue to iterate based on a Boolean expression. The evaluation of the Boolean expression usually depends on some value generated or retrieved inside of the code block.
// The while statement evaluates a Boolean expression first, and continues to iterate through the code block as long as the Boolean expression evaluates to true.
// The continue keyword to step immediately to the Boolean expression.