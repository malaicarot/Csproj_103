// To test out your code , comment the other parts and uncomment the part you want to test.
//To comment a part, select the part and press Ctrl + K + C
//To uncomment a part, select the part and press Ctrl + K + U
//Press Ctrl + F5 to run the code.

//---------------------------------------------------------------------
// Part 1: Mathematical Operators
// Write a C# program to print the sum of two numbers.
// Hint: You can use the + operator to add two numbers.
// Test data: int num1 = 10, int num2 = 5

// int num1 = 10;
// int num2 = 5;
// Console.WriteLine($"Sum: {num1 + num2}");


//---------------------------------------------------------------------
// Part 2: Mathematical Operators
// Write a C# program to print the difference between two numbers.
// Hint: You can use the - operator to subtract two numbers.
// Test data: int num1 = 10, int num2 = 5


// int num1 = 10;
// int num2 = 5;
// Console.WriteLine($"Minus: {num1 - num2}");

//---------------------------------------------------------------------
// Part 3: Mathematical Operators
// Write a C# program to print the product of two numbers.
// Hint: You can use the * operator to multiply two numbers.
// Test data: int num1 = 10, int num2 = 5

// int num1 = 10;
// int num2 = 5;
// Console.WriteLine($"Time: {num1 * num2}");


//---------------------------------------------------------------------
// Part 4: Mathematical Operators
// Write a C# program to print the division of two numbers.
// Hint: You can use the / operator to divide two numbers.
// Test data: int num1 = 10, int num2 = 5

// int num1 = 10;
// int num2 = 5;
// int result = num1 / num2;
// Console.WriteLine($"Divide: {result}");


//---------------------------------------------------------------------
// Part 5: Mathematical Operators
// Write a C# program to print the remainder of two numbers.
// Hint: You can use the % operator to find the remainder of two numbers.
// Test data: int num1 = 10, int num2 = 5

// int num1 = 10;
// int num2 = 5;
// int result = num1 % num2;
// Console.WriteLine($"Modular: {result}");


//---------------------------------------------------------------------
// Part 6: Mathematical Operators
// Write a C# program to calculate the square of a number.
// Hint: You can use the * operator to multiply a number by itself.
// Test data: int num = 5


// int num = 5;
// num *= num;
// Console.WriteLine($"Square: {num}");

//---------------------------------------------------------------------
// Part 7: Mathematical Operators
// Write a C# program to calculate the average of two numbers.
// Hint: You can add the two numbers together and then divide the sum by 2 to find the average.
// Test data: int num1 = 10, int num2 = 20

// int num1 = 10;
// int num2 = 20;
// int average = (num1 + num2) / 2;
// Console.WriteLine($"Average: {average}");


//---------------------------------------------------------------------
// Part 8: Mathematical Operators
// Write a C# program to calculate the average of three numbers.
// Hint: You can add the three numbers together and then divide the sum by 3 to find the average.
// Test data: int num1 = 10, int num2 = 20, int num3 = 30

// int num1 = 10;
// int num2 = 20;
// int num3 = 30;
// int average = (num1 + num2 + num3) / 3;
// Console.WriteLine($"Average: {average}");

//---------------------------------------------------------------------
// Part 9: Mathematical Operators
// Write a C# program to convert temperature from Celsius to Fahrenheit.
// Hint: Use the formula (Celsius * 9/5) + 32.
// Test data: double celsius = 20

// double celsius = 20;
// double convert = (celsius * 9 / 5) + 32;
// Console.WriteLine($"Convert Celsius to Fahrenheit: {convert}");


//---------------------------------------------------------------------
// Part 10: Mathematical Operators
// Write a C# program to calculate the area of a rectangle given its length and width.
// Hint: Use the formula area = length * width.
// Test data: double length = 10, double width = 5

// double length = 10;
// double width = 5;
// double area = length * width;
// Console.WriteLine($"The area of a rectangle: {area}");



//---------------------------------------------------------------------
// Part 11: Mathematical Operators
// Write a C# program to calculate the volume of a sphere given its radius.
// Hint: Use the formula volume = (4/3) * Pi * radius^3.
// Test data: double radius = 5
// const double PI = 3.14159;
// double radius = 5;
// double volume = (4/3) * PI * Math.Pow(radius, 3);
// Console.WriteLine($"The volume of a sphere: {radius}");


//---------------------------------------------------------------------
// Part 12: Mathematical Operators
// Write a C# program to calculate the factorial of a given integer.
// Hint: Use a loop to multiply the numbers from 1 to the given integer.
// Test data: int num = 5
// int num = 5;

// int factorial = 1;

// for(int i = 1; i <= 5; i++){
//     factorial *= i;
// }
// Console.WriteLine($"The factorial of {num} is: {factorial}");


//---------------------------------------------------------------------
// Part 13: Mathematical Operators
// Write a C# program to calculate the compound interest given the principal amount, interest rate, and time period.
// Hint: Use the formula A = P * (1 + r/n)^(nt).
// Test data: double principal = 1000, double rate = 0.05, int time = 5

// double principal = 1000;
// double rate = 0.05;
// int time = 5;
// double  compoundInterest = principal * Math.Pow((1 + rate / time), (time * 12));
// Console.WriteLine($"The compound interest: {compoundInterest}");

//---------------------------------------------------------------------
// Part 14: Mathematical Operators
// Write a C# program to solve a quadratic equation of the form ax^2 + bx + c = 0.
// Hint: Use the quadratic formula.
// Test data: double a = 1, double b = 5, double c = 6

// double a = 1;
// double b = 5;
// double c = 6;
// double delta = b * b - (4 * a * c);

// double x1 = 0.0;
// double x2 = 0.0;

// if (delta < 0)
// {
//     Console.WriteLine($"Impossible equation!");
// }
// else if (delta > 0)
// {
//     x1 = (-b + Math.Sqrt(delta)) / 2 * a;
//     x2 = (-b - Math.Sqrt(delta)) / 2 * a;
//     Console.WriteLine($"Root is: {x1} and {x2}");
// }
// else if (delta == 0)
// {
//     x1 = -b / (2 * a);
//     Console.WriteLine($"Quadratic equation have double root is: {x1}");
// }



//---------------------------------------------------------------------
// Part 15: Mathematical Operators
// Write a C# program to calculate the nth Fibonacci number using recursion.
// Hint: Use a recursive function to calculate Fibonacci numbers.
// Test data: int n = 8

// int num = 18;

// int Fibonacci(int n)
// {
//     if (n < 0)
//     {
//         return -1;
//     }
//     else if (n == 0 || n == 1)
//     {
//         return n;

//     }
//     else
//     {
//         return Fibonacci(n - 1) + Fibonacci(n - 2);

//     }
// }
// Console.WriteLine(Fibonacci(num));


//---------------------------------------------------------------------
// Part 16: Mathematical Operators
// Write a C# program to calculate the nth term of the arithmetic sequence given the first term, common difference, and term number.
// Hint: Use the formula nth term = first term + (n - 1) * common difference.
// Test data: int firstTerm = 3, int commonDifference = 2, int termNumber = 5
// int firstTerm = 3;
// int commonDifference = 2;
// int termNumber = 5;

// int result = firstTerm + (termNumber - 1) * commonDifference;

// Console.WriteLine($"The nth term of the arithmetic sequence: {result}");


//---------------------------------------------------------------------
// Part 17: Relational Operators
// Write a C# program to check if a given number is greater than another number.
// Hint: Use the > operator to check if the first number is greater than the second number.
// Test data: int num1 = 10, int num2 = 5

// int num1 = 10;
// int num2 = 5;

// if (num1 > num2)
// {
//     Console.WriteLine($"Num 1 is greater than num 2: {num1 > num2}");
// }
// else
// {
//     Console.WriteLine($"Num 1 is not greater than num 2: {num1 > num2}");

// }


//---------------------------------------------------------------------
// Part 18: Relational Operators
// Write a C# program to check if a given number is less than or equal to 100.
// Prompt the user to enter a number and check if it is less than or equal to 100.
// Hint: Use the <= operator to check if the number is less than or equal to 100.
// Test data: Enter a number: 88

// int number;
// Console.Write("Enter a number: ");
// number = Convert.ToInt32(Console.ReadLine());

// if (number <= 100)
// {
//     Console.WriteLine("The number is less than or equal to 100");
// }
// else
// {
//     Console.WriteLine("The number is not less than or equal to 100");

// }


//---------------------------------------------------------------------
// Part 19: Logical Operators
// Write a C# program to check if a given number is even and greater than 10.
// Prompt the user to enter a number and check if it satisfies both conditions.
// Hint: Use the % operator to check if the number is even, and the && operator to check both conditions.
// Test data: Enter a number: 16

// int number;
// Console.Write("Enter a number: ");
// number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 0 && number > 10)
// {
//     Console.WriteLine(true);
// }
// else
// {
//     Console.WriteLine(false);
// }

//---------------------------------------------------------------------
// Part 20: Logical Operators
// Write a C# program to check if a given number is divisible by 3 OR 5.
// Prompt the user to enter a number and check if it is divisible by either 3 or 5.
// Hint: Use the % operator to check for divisibility, and the || operator to check either condition.
// Test data: Enter a number: 9
// int number;
// Console.Write("Enter a number: ");
// number = Convert.ToInt32(Console.ReadLine());
// if (number % 3 == 0 || number % 5 == 0)
// {
//     Console.WriteLine(true);
// }
// else
// {
//     Console.WriteLine(false);
// }

//---------------------------------------------------------------------
// Part 21: Initialization and Assignment Operators
// Write a C# program to increment a variable by 5 using the shorthand assignment operator.
// Prompt the user to enter a number and increment it by 5 using the shorthand assignment operator.
// Hint: Use the += operator to increment the variable by 5.
// Test data: Enter a number: 7

// int number;
// Console.Write("Enter a number: ");
// number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{number += 5}");



//---------------------------------------------------------------------
// Part 22: Initialization and Assignment Operators
// Write a C# program to calculate the remainder when dividing a number by 7 and update the number using the %= operator.
// Initialize a variable 'number' with a value of 27, then calculate the remainder when dividing 'number' by 7 and update 'number' with the result.
// Hint: Use the %= operator to update the value of 'number' with the remainder of 'number' divided by 7.
// Test data: int number = 27

// int number = 27;

// Console.WriteLine($"The remainder when dividing {number} by 7: {number %= 7}");



