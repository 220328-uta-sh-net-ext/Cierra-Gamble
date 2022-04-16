// CODE BLOCKS DEFINE METHODS, CLASSES, AND NAMESPACES

/*
In these modules featuring beginner C# units, we use the .NET Editor to compose and run applications. While the .NET Editor is a great feature that eliminates your need to install a development environment like Visual Studio Code or the full Visual Studio IDE, it doesn't allow you to build real applications.

If you were to create a new C# Console Application project in either Visual Studio Code (via the dotnet command-line interface, or CLI) or the full Visual Studio IDE, a name file named Program.cs is generated that contains code from a template. Here's the generated code from an application named MyNewApp:
*/
using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

/* 
Here you see three levels of code blocks, starting from the inner-most code block and working our way outward:
	a method Main()
	a class Program
	a namespace MyNewApp

As you build real applications, you'll write methods, and organize them into classes and namespaces.

A method is a code block that is a unit of execution. In other words, once the method is called by its name, the entire method will execute until:

	the runtime encounters the return keyword, or
	the runtime encounters an exception and can't continue, or
	the runtime successfully executes each line of code in the method
	In the browser-based .NET editor, all the code you write is executed inside of a hidden Main() method, which hopefully has reduced a lot of complexity as you're getting started.
The method's name Main() is special. When the program is executed, by default the .NET Runtime will search for a method named Main() to use as the starting point, or entry point, for the program.

A class is a container for members like methods, properties, events, fields, and so on. In the module "Call methods from the .NET Class Library using C#", you learned that you must create an instance of a class using the new keyword if you want to call a method that requires state (or rather, instance methods). Otherwise, you can call methods that are not stateful without first creating an instance of the class (or rather, static methods).

A namespace disambiguates class names. In the module "Call methods from the .NET Class Library using C#", you learned how there are so many classes in the .NET Class Library that it's possible to have two classes with the same name. The namespace ensures you can instruct the compiler which class and method you want to work with by also specifying a namespace.

When you create a new project using the dotnet CLI or the full Visual Studio IDE, it will automatically create a namespace using the project's name. That's why the default namespace in the code example above is MyNewApp. You can create additional namespaces in your code as needed, and can create a hierarchical series of namespaces by using the dot operator. So, suppose we wanted to create a second level of namespaces for the classes of our application. We could add a child-namespace like so:
*/

namespace MyNewApp.Business
{
  // Classes here    
}

//  	OR PERHAPS ANOTHER CHILD-NAMESPACE LIEK
namespace MyNewApp.Data
{
  // Classes here    
}

/*
In the MyNewApp.Business namespace, we would expect to add classes that implemented the business logic of our application. In the MyNewApp.Data namespace, we would expect to add classes that implemented the data access features of our application. We can add as many namespaces as we want. We can create namespaces as many levels deep as we need. We would just keep appending child-namespace names using the dot operator.

Most importantly for the purposes of this module, code blocks define the boundaries for each of these constructs. Code blocks suggest an ownership, or containment, relationship. So, the rules we just learned about variable scope and access are true at this level as well.
*/

// Calling a method in the same class

// The following code example calls a method named Reverse() that is defined in the same class.

using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }

        static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

// Focus on the line of code that calls the Reverse() method:

string reversedValue = Reverse(value);

// Since the Reverse() method is defined in the same class, the code that calls the method doesn't need to qualify the method's name with the class name.


//What if we move the Reverse() method into its own class? Consider the following code example.

using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }

    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

// FIRST FOCUS ON THESE LINES OF CODE:

class Utility
    {
        public static string Reverse(string message)
        {

/* Here, we define the Utility class and add the Reverse() method. We also add the public keyword. Otherwise, it would be inaccessible to the Program class' Main() method. Without the public keyword, we would see the compilation error: */
	'Utility.Reverse(string)' is inaccessible due to its protection level

	/*
We'll talk about accessibility modifiers like public and private in other modules.

Next, focus on how we needed to use the new Utility class' name when accessing the Reverse() method from the Main() method.
	*/
	string reversedValue = Utility.Reverse(value);
// Since the method no longer "lives" in the same class, to call the Reverse() method, we have to access it via the class it was moved into.

// REFERENCING A CLASS IN A DIFFERENT NAMESPACE

/*
What if we move the Utility class into a different namespace? How will this affect the accessibility of the class and its method? Consider the following code example.
*/

using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = MyNewApp.Utilities.Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }
}

namespace MyNewApp.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

// FIRST, FOCUS ON NEW NAMESPACES ADDED

namespace MyNewApp.Utilities
// Not only did we create a new namespace MyNewApp.Utilities, but we also moved our Utility class and its contents into the new namespace.
// Second, focus on how we called the Reverse() method.

string reversedValue = MyNewApp.Utilities.Utility.Reverse(value);

// Notice that we used the "full name" of the class, including its full namespace.

/* 
Since the child-namespace Utilities and the Program class are both defined in the MyNewApp parent namespace, we could avoid using the namespace in this instance. The following code illustrates this.
*/
string reversedValue = Utilities.Utility.Reverse(value);

/* Even though it's less verbose, many would consider this hard to read because we typically don't separate parent and child namespaces like this. Consider keeping the full namespace together whenever it's needed to promote clarity and readability.
*/

// The using statement helps the compiler resolve namespaces, but requiring fewer keystrokes

/* A better option would be to add a using statement. The using statement is added to the top of a code file. It resolves the class names that are used in the file, instructing the compiler to look at the list of namespaces to find all of the class names.

Here's another version of the application that adds a using statement to simplify the call to the Reverse() method.
*/
using System;
using MyNewApp.Utilities;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }
}

namespace MyNewApp.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}
// Focus on this line of code, added on the second line:

using MyNewApp.Utilities;

/* The using statement tells the compiler to look here when attempting to resolve any class names it needs to find. Now, we can call the Reverse() method using only the class name like so:
*/
string reversedValue = Utility.Reverse(value);
// This is also why the template that generates the Program.cs file includes this line of code at the top:

using System;
// It makes it possible to call Console.WriteLine() instead of System.Console.WriteLine().

// WHAT DOES THIS HAVE TO DO WITH CODE BLOCKS?

/* Code blocks define the boundaries of higher-level structures like namespaces, classes, and methods, just as they define the boundaries of decision and iteration statements. These boundaries require consideration because they affect the visibility of both variables and other larger structures like methods and classes. In some cases, additional keywords like public and using must be used to pass into the boundaries of another block of code. In other cases, structures defined as siblings inside the same code block can reference each other freely.
*/

// 			Recap
	// Code blocks define higher-level structures like namespaces, classes, and methods.

	/* Just as code blocks affect the visibility of variables defined inside of lower-level structures like decision and iteration statements, code blocks also affect the visibility of methods between classes, and classes between namespaces.

	The using statement can be added to code files to instruct the compiler where to look for references to classes.
	*/