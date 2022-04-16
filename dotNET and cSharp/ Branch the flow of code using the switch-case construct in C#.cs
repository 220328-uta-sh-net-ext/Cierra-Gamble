/* 
In this module, you will:
Use the switch-case construct to match a variable or expression against several possible outcomes.
Convert code that uses an if-elseif-else construct into a switch-case construct.
Prerequisites:
Experience using the if-elseif-else construct for adding branching logic
Experience working with variables, string interpolation, and printing output
*/

// Use the switch case statement
/* 
What is the switch statement?
	switch is a selection statement that chooses a single switch section to execute from a list of candidates based on a pattern match with the match expression. 
		A switch statement includes one or more switch sections. Each switch section contains one or more case labels (either a case or default label) followed by one or more statements. 
	The switch statement may include at most one default label placed in any switch section.
*/
	// The switch is best used when:
		// you have a single value you want to match against many possible values
		// but for any given match, you need to execute a couple of lines of code at most
		// It's possible that multiple cases apply, however C# will select the first matching expression.

// STEP 1 - CREATE THE SWITCH STATEMENT
	// Add the following code into the .NET Editor.

int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
//  		RUN THE CODE, FOLLOWING RESPONSE:
John Smith, Senior Associate

/*
The switch keyword defines the purpose of the code block below. Next to the keyword, the match expression in parenthesis (employeeLevel).
	Inside the code block, one or more switch sections. Each switch section has one or more labels. A label begins with the keyword case and a matching pattern. The runtime compares the value of the match expression with each matching pattern until it finds a match.
	Once the runtime finds a matching label, it performs the code in that particular switch section.
Only one switch section can be executed. The break keyword is one of several ways to end a switch section and literally break out of the switch statement. If you forget the break keyword (or, optionally, the return keyword) the compiler will generate an error.
	If there are no matching labels, the optional default label will be matched. 
	If there's no default defined, then the switch statement only executes when one of its cases match.
The optional default label is not required to be defined after the rest of the cases. However, most developers choose to put it last because logically it makes sense as the "default" or "last option".

*/

// Step 2 - Change the level variable value to see how the switch statement evaluates it

// 	To exercise the default case, let's change the employee's level by modifying the following line of code.
int employeeLevel = 201;
// 				RUN THE CODE, OUTCOME
John Smith, Associate
// Since the employeeLevel doesn't match any labels, the default label is matched.

// STEP 3 - MODIFY THE APPLICATION TO USE FALL THROUGH

/*
Our company decided to give all level 100 employees the title "Senior Associate" -- the same title as level 200 employees. As the developer, you decide to implement this by removing the first switch section belonging to the label case 100:, and instead allow both the case 100: and case 200: labels execute the same switch section.
*/

// Modify the code to set the employeeLevel to 100.
int employeeLevel = 100;
// Next, edit the code to
	case 100:
    case 200:
        title = "Senior Associate";
        break;
// 		IT SHOULD LOOK LIKE THIS WHEN YOU'RE DONE
int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
// NOW RUN APPLICATION, BELOW SHOULD BE OUTPUT

John Smith, Senior Associate

// 	Both of the case labels 100 and 200 are now paired with the switch section that sets the title to the string value Senior Associate.

/*
The switch keyword defines the purpose of the code block below. Next to the keyword, the match expression in parenthesis (employeeLevel).

Inside the code block, one or more switch sections. Each switch section has one or more labels. A label begins with the keyword case and a matching pattern. The runtime compares the value of the match expression with each matching pattern until it finds a match.

Once the runtime finds a matching label, it performs the code in that particular switch section.

Only one switch section can be executed. The break keyword is one of several ways to end a switch section and literally break out of the switch statement. 
	If you forget the break keyword (or, optionally, the return keyword) the compiler will generate an error.

	If there are no matching labels, the optional default label will be matched. 
	If there's no default defined, then the switch statement only executes when one of its cases match.

The optional default label is not required to be defined after the rest of the cases. However, most developers choose to put it last because logically it makes sense as the "default" or "last option".
*/

// 					Recap
	// Here's the main takeaways you learned about the switch statement:
	// Use the switch statement when you have one value with many possible matches, each match requiring a branch in your code logic.
	// A single switch section containing code logic can be matched using one or more labels defined by the case keyword.
	// Use the optional default keyword to create a label and a switch section to be used when no other case labels match.
