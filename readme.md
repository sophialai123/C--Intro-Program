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

---
## Numerical Data Types

Let’s look at two data types that we can use to represent different numerical values:

- To define a variable with the type int, you would write it as follows:

`int variableName = 7;`

- Double and Decimal

If we need to use a decimal value, we have a few options: float, double, and decimal. These values are useful for anything that requires more precision than a whole number, like measuring the precise location of an object in 3D space.

A double is usually the best choice of the three because it is more precise than a float, but faster to process than a decimal. However, make sure to use a decimal for financial applications, since it is the most precise.

- To define a variable with the type double, you would write it as follows:

`double variableName = 39.76876;`


- To define a variable with the type decimal, you would write it as follows: Don’t forget the m character after the number! This character tells C# that we’re defining a decimal and not a double.
  
`decimal variableName = 489872.76m;`

---
## Arithmetic Operators
Arithmetic operators include:
addition `+`
subtraction `-`
multiplication `*`
division `/`

We can use these symbols to perform operations on numbers and create new values.

```
int answer = 4 + 19;
Console.Write(answer);
 
// prints 23
```
---
## Modulos 

Modulos  are useful because they let us know if a number “fits” into a larger number, or if there will be a remainder. For example, how many eggs will be left over if I try and fit 56 eggs into crates of a dozen eggs?

```
int eggs = 56;
int crateAmount = 12;
 
int eggsLeftOver = eggs % crateAmount; 
Console.Write(eggsLeftOver); // prints 8
```


It can also be used to check if a number is odd or even. If a number is even, taking its modulo with 2 it will return a 0 and if it is odd it will return a 1:

```
int myNum = 85939824;
Console.Write(myNum % 2); // prints 0, so number is even
```
---
### Built-In Methods
There are several built-in methods that we can use to manipulate numerical data and perform more complex mathematical calculations. Here are a few:

- `Math.Abs()`—will find the absolute value of a number. Example: `Math.Abs(-5)` returns 5.
- `Math.Sqrt()`—will find the square root of a number. Example: `Math.Sqrt(16)` returns 4.
- `Math.Floor()`—will round the given double or decimal down to the nearest whole number. Example: `Math.Floor(8.65)` returns 8.
- `Math.Min()`—returns the smaller of two numbers. Example: `Math.Min(39, 12)` returns 12.


---
## Introduction to Working with Text

A string is a group of characters surrounded by quotation marks, like "https://codecademy.com" or "To be or not to be." A string is just a collection of a smaller data type, char, which is a single character like “a” or “?”.

To define a variable as a string, you write the data type, then the variable name. Then set it equal to the value, which is inside of quotation marks :
`string variableName = "puppy";`

#### [Escape Character Sequences](https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=msvc-170&viewFallbackFrom=vs-2017)
An escape sequence places a backslash (\) before the inner quotation marks, so the program doesn’t read them accidentally as the end of sequence.

```
string withoutSlash = "Ifemelu said, "Hello!"";
 
string withSlash = "Ifemelu said, \"Hello!\"";

string newLine = "Ifemelu walked \n to the park.";
```

---
## String Concatenation
A common way to do is by using string concatenation. String concatenation is when we combine strings using the addition symbol `(+)`, literally adding one string to another.

```
string yourFaveMusician = "David Bowie";
string myFaveMusician = "Solange";
 
Console.WriteLine("Your favorite musician is " + yourFaveMusician + " and mine is " + myFaveMusician + ".");
```
---
## [String Interpolation](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated)
 String interpolation was introduced in C# 6 and it enables us to insert our variable values and expressions in the middle of a string, without having to worry about spaces and punctuation.

```
string yourFaveMusician = "David Bowie";
string myFaveMusician = "Solange";
 
Console.WriteLine($"Your favorite musician is {yourFaveMusician} and mine is {myFaveMusician}.")
```

---
## Get Info About Strings
- Length
  - Since strings are composed of a set of characters, we can find out how many characters exist in a string with the `.Length` method.

```
string userTweet = Console.ReadLine();
 
userTweet.Length; // returns the length of the tweet
```

- IndexOf

We can also find the position of a specific character or substring using .`IndexOf()`. This method is useful for searching to see if something exists in a string.

```
string word = "radio";
 
word.IndexOf("a"); // returns 1
```
Since positioning starts at 0, the second thing in the string will return a 1. If it doesn’t exist in the string the method will return a -1. If we pass it an empty string, it will return 0. If it occurs more than once, it will return the first instance.

---
## Get Parts of Strings
We can also use built-in .NET methods to grab parts of strings or specific characters in a string.

#### Substring
`.Substring()` grabs part of a string using the specified character position, continues until the end of the string, and returns a new string. `.IndexOf()` is usually used first to get the specific character position.

```
string plantName = "Cactaceae, Cactus"; 
int charPosition = plantName.IndexOf("Cactus"); // returns 11
string commonName = plantName.Substring(charPosition); // returns Cactus
```

`.Substring()` is useful if we only want to use part of a string but keep the original data intact. So in this instance, we want to keep the string plantName, but just grab the `"Cactus"` portion of the string. We use `.IndexOf()` to find where `"Cactus"` starts, then use .`Substring()` with the position information to save "Cactus" to the new variable commonName.


We can also pass `.Substring() `a second argument, which will determine the number of characters in the resulting substring. For example, the following code shows how we can use `.Substring()` with two arguments to **specify the length of our substring**:

```
string name = "Codecademy"; 
int start = 2;
int length = 6;
string substringName = name.Substring(start, length); // returns 'decade'
```

#### Bracket Notation
Bracket notation is a style of syntax that uses brackets `[]` and an integer value to identify a particular value in a collection. In this case, we can use it to find a specific character in a string.

```
string plantName = "Cactaceae, Cactus";
int charPosition = plantName.IndexOf("u"); // returns 15
char u = plantName[charPosition]; // returns u
```

Similar to the example above, we first use `.IndexOf()` to grab the character position, which in this case is 15. We then take the string value and append it with a set of brackets `[]` and place the `charPosition` value inside the brackets.

---
## Manipulate Strings
There are also built-in .NET methods that we can use to manipulate text data. Using these methods on a string doesn’t change the string itself, but creates an entirely new one.

We can quickly change the case of our strings using the methods `.ToUpper()` and `.ToLower()`. These methods are useful if we want to make our text look like an e.e. cumming’s poem or make it appear like we forgot to turn off our caps lock key.

```
string shouting = "I'm not shouting, you're shouting".ToUpper();
Console.WriteLine(shouting);
// prints I'M NOT SHOUTING, YOU'RE SHOUTING.
```