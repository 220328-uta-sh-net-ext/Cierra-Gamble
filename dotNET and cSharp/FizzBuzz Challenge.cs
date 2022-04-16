
// Code challenges throughout these modules will reinforce what you've learned and help you gain some confidence before continuing on.
// FIZZBUZZ CHALLENGE
// FizzBuzz is a popular coding challenge and interview question. It exercises your understanding of the for, the if, the % remainder operator, and your command of basic logic.

// STEP 1 - IMPLEMENT THE FIZZBUZZ CHALLENGE RULES.

// Using the .NET Editor, implement each rule.
/* FizzBuzz rules:
Output values from 1 to 100, one number per line.
When the current value is divisible by 3, print the term Fizz next to the number.
When the current value is divisible by 5, print the term Buzz next to the number.
When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
 Important
You will need to understand how to use the % remainder operator to determine if a number is divisible by another number evenly. We covered this in the module "Perform basic operations on numbers in C#".
No matter how you do it, your code should produce the following output. We'll only show the first 22 values. Your output should continue to 100. \
*/


// 				SOLUTION

for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
} 

// This code is merely "one possible solution".
	// The for statement is important because it allows you to iterate through the code block 100 times.
	// The if-elseif-else allows you to check for the divisors of 3 and 5.
	// The %, the mod operator, allows you to determine if 3 or 5 divide into another number without a remainder.
	// And the && operator ensures that a number can be divided into both 3 and 5 for the FizzBuzz condition.
	// The code should produce the following output from 1 to 100.