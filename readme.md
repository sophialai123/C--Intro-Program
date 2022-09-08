## how to check dotnet version 

run : 
`sudo ln -s /usr/local/share/dotnet/x64/dotnet /usr/local/bin/`


`dotnet --version`


## create a new console in the terminal 
`dotnet new console `



## run c # in the terminal
`dotnet run`


## how to code runner without dotnet

Extension:
`Code Runner`

Settings:
![](run%20in%20termianl.png)


add keys:
``` "code-runner.runInTerminal": true,
"code-runner.executorMap":{
"csharp": "cd $dir && dotnet run $fileName", //find this csharp
}

```

---
### Hello World Review

- The command `Console.WriteLine()` prints text to the console
- The command `Console.ReadLine()` captures user input in the console
- Comments are lines of code that are ignored by your computer; they’re intended to be read by developers instead. Make them with // or /* and */

---
## Introduction to Data Types and Variables in C#
C# is strongly-typed, so it requires us to specify the data types that we’re using. It is also statically-typed, which means it will check that we used the correct types before the program even runs. Both language features are important because they help write scalable code with fewer bugs.

## C# Data Types
- int - whole numbers, like: 1, -56, 948
- double - decimal numbers, like: 239.43909, -660.01
- char - single characters, like: “a”, “&”, “£”
- string - string of characters, like: “dog”, “hello world”
- bool - boolean values, like: true or false
  
![](C#_DataTypes_v4-01.svg)


---
## Creating Variables with Types
In C#, data types and variables are closely intertwined. Remember how C# is strongly-typed? Every time we declare a variable, we have to specify what kind of data type that variable is going to hold.

There are two ways we can assign variables. We can do it on two lines:

```
// Declare an integer
int myAge;
myAge = 32;
```

Or, we can be more concise and just do it on one:

```
// Declare a string
string countryName = "Netherlands";
```

In each case, we first write the data type, then the variable name, then use the equals sign = to assign the variable a value.

Once we’ve defined a variable, we can use them throughout our program. For example, here’s a short program that prints a few math equations to the console:

```
int evenNumber = 22;
int oddNumber = 45;
Console.WriteLine(evenNumber + oddNumber); // Prints 67
Console.WriteLine(oddNumber - evenNumber); // Prints 23
```

---
## Handling Errors

When you program, you’ll come across a lot of errors. And that’s ok! And when you’re first starting to learn a strongly-typed language, errors can be pretty common.

here are also a few words that you can’t use. These are known as reserved keywords. [Reserved keywords](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/) are words that the language uses, so they already have specific definitions that shouldn’t be re-written.

Lastly, it’s important to double-check spelling and punctuation! Don’t forget to end each statement with a semicolon `;`.


---
## Converting Data Types
Because variables have to be strictly typed, there may be some circumstances where we want to change the type of data a variable is storing. This strategy is known as data type conversion.

For example, let’s try converting a double to an integer:

```
double myDouble = 3.2;
 
// Round myDouble to the nearest whole number
int myInt = myDouble;
// return Errors
```

However, if you did the reverse and turned an int into a double:

```
int myInt = 3;
// Turn it into a decimal
double myDouble = myInt; // this code works

```

C# checks to make sure that when we convert data types from one to another that we’re not losing any data, because that could cause problems in our code.

Because of that, there are a couple different ways to do data type conversion:

- implicit conversion: happens automatically if no data will be lost in the conversion. That’s why it’s possible to convert an int (which can hold less data) to a double (which can hold more), but not the other way around.
  
- explicit conversion: requires a cast operator to convert a data type into another one. So if we do want to convert a double to an int, we could use the operator (int).


So, if we’re to fix the error in our previous code, we’d rewrite it as follows:

```
double myDouble = 3.2;
 
// Round myDouble to the nearest whole number
int myInt = (int)myDouble;
```


It’s also possible to convert data types using built-in methods. For most data types, there is a Convert.ToX() method, like Convert.ToString() and Convert.ToDouble(). For a full list of Convert class built-in methods, check out the [Microsoft Documentation](https://docs.microsoft.com/en-us/dotnet/api/system.convert?view=netframework-4.7.2).



One example of when we have to use conversions is when we ask a user to input a numerical value. Even if that value is an integer or a decimal, `Console.ReadLine() will always return a string.`

[How to convert a string to a number (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number)