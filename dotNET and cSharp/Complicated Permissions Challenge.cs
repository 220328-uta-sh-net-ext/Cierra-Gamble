// COMPLICATED PERMISSIONS CHALLENGE
/* 
In this challenge, you'll implement business rules that restrict access to users based on their permissions and their level. You'll display a different message to the user depending on their permissions and level.

Step 1 - Add code as a starting point

To test your Boolean expression logic, use the following code of sample data.
*/

string permission = "Admin|Manager";
int level = 55;
			
// 			Important
/*
To determine whether the permission variable's value contains one of the permission values you'll be checking for in the "business rules", use the Contains() helper method of a string. Example: permission.Contains("Admin") would return true.
*/

// STEP 3 - IMPLEMENT BUSINESS RULES

/* Business Rules
If the user is an Admin with a level greater than 55, output the message:

Output
Welcome, Super Admin user.

If the user is an Admin with a level less than or equal to 55, output the message:

Output
Welcome, Admin user.

If the user is a Manager with a level 20 or greater, output the message:

Output
Contact an Admin for access.

If the user is a Manager with a level less than 20, output the message:

Output
You do not have sufficient privileges.

If the user is not an Admin or a Manager, output the message:
Output

You do not have sufficient privileges.
Step 4 - Make sure you get the output given the sample data

When you run the code, including the sample data from Step 2, you should see the following output:
Output

Copy
Welcome, Admin user.
Whether you get stuck and need to peek at the solution or you finish successfully, continue on 
*/

// 			SOLUTION

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}