//					Challenge
/*
Code challenges throughout these modules will reinforce what you've learned, and help you gain some confidence before continuing on.
The focus of this challenge is to rewrite the code in the .NET Editor to use a different technique to accomplish essentially the same task. This challenge will help you see the strengths/weaknesses of the switch-case when compared to an if-elseif-else statement.
*/
// LOOK UP PRODUCT BY SKU CHALLENGE

/* Suppose we work for a souvenir shop in a college town that sells t-shirts, sweatshirts, and other gifts with the school's logo and colors. A monthly sales report uses the full description as well as the Stock Keeping Unit (SKU) of the products sold. We've been asked to rewrite certain portions of the code to make it more readable. One of the tasks is to simplify the conversion of a SKU into a description using the switch statement.
*/

// STEP 1: REWRITE THE CODE IN THE .NET EDITOR TO USE THE SWITCH-CASE STATEMENT INSTEAD OF THE IF-ELSEIF-ELSE STATEMENT

// The following code converts a SKU into a long-form description (for example, the sku 01-MN-L is a "large maroon sweat shirt").
// Change the code in the .NET Editor to use a switch-statement. The result should be the same.

// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
// No matter how you do it, your code should produce the following output.

// Product: Large Maroon Sweat shirt
// Whether you get stuck and need to peek at the solution or you finish successfully, continue on to view a solution to this challenge.

// 				SOLUTION

// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");