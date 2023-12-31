﻿// ReSharper disable SuggestVarOrType_BuiltInTypes
namespace C_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Variables

            /*
             * Variables and Operations
             * Memory/Storage for data.
             * Variables, they have data types.
             * String (string) (Text) name = Ronaldo.
             * Integer (int) (Integer Number) age = 33.
             * Float (float) (Fractional Numbers/Real Numbers) averageGrade = 91.92842883f 10000000.3949494
             * Boolean (bool) (True/False) isItRaining = False.
             * Long (long) (Long Integer) World Population = 8,000,000,000
             * Double (double) (Long Float) pi = 3.1415914242949239 200000000.797979799696969
             */
            // Variable Declaration.
            /*
             * Declaration assume that a variable exists, person, name?? excuse me, what's your name.
             * Datatype variableName;
             * It gives the variable a default value.
             * Numeric data default: 0
             * Bool data default: false
             * Any other data default: null
             */
            //int age;
            //string name;
            //float degree;
            //bool hasPassed;
            // Variable Initialization.
            /*
             * Assign value/Initialize variable with prespecified value.
             */
            //string name2 = "Ronaldo";
            //int age2 = 33;
            //float degree2 = 91.9283838283f;
            //bool isRaining = true;
            /*
             * Keywords: bool, true, false, string, int, float, object
             * Variable naming:
             * 1. Variable consists of only alphabetical, numerical and underscore
             * 2. Variable CAN NOT start with a number.
             * 3. Variable CAN NOT be a reserved keyword.
             * 4. Variable must have a unique name.
             */
            //int age_2;
            //int age21;
            //int age3;
            //int age54;
            // Variable Assignment.
            /*
             * Initialization: datatype variableName = value;
             * Assignment: variableName = value;
             * VALUE MUST BE OF THE SAME TYPE AS THE VARIABLE.
             */
            //name2 = "Messi";
            //float age9595 = 9.0f;

            #endregion

            #region Operations

            /*
             * Processing data.
             * Some instructions that help us process data in specified ways.
             * string child = "Omar";
             * int age = 13;
             * his birthday is tomorrow:
             * age will increase by 1 tomorrow.
             * age = 14;
             */

            #region Arithmetic Operations

            /* ARITHMETIC OPERATIONS
             * PEMDAS:
             * Parentheses
             * Exponents
             * Multiplication
             * Division
             * Addition
             * Subtraction
             * int x = 45 + 2 = 47
             * int x = 9 * (5 + 2) = 9 * 7 = 63
             * ===================
             * Summation Operation / Addition Operation (+) NUMERICAL DATA ONLY. (Float/Integer)
             * Adds number onto another number.
             * age = 13 + 1 + 5 + 7;
             * age = 14 + (-1)
             * ===================
             * Difference Operation / Subtraction Operation (-) NUMERICAL DATA ONLY. (Float/Integer)
             * age = 14 - 1;
             * age = 14 - (-1)
             * ===================
             * Multiplication Operation / Product Operation (*) NUMERICAL DATA ONLY. (Float/Integer)
             * int money = 1000;
             * Invested in bank for 5 years, money has doubled.
             * money = 2000;
             * money = 1000 * 2;
             * ===================
             * Divison Operation / Quotient Operation (/) NUMERICAL DATA ONLY. (Float/Integer)
             * int stickLength = 10;
             * stickLength = 10 / 2;
             * CAN NOT DIVIDE BY ZERO
             * stickLength = 10 / 0
             *
             * ===================
             * Modulous Operation / Remainder Operation (%) NUMERICAL DATA ONLY. (Float/Integer)
             * int stickLength = 10;
             * ==========
             * 3 sticks
             * Quotient: === === === Remainder: =
             * stickLength = 10 % 3 = 1;
             * int x = 494939393
             * 0 -> 100
             * x % 100
             * int x = 21
             * int y = x % 10;
             * ===================
             * Increment (unary operator, var++, ++var)
             * Increase
             * January, February, March,...,Decemeber.
             * 1,2,3,...,12
             * Every month you increment once.
             * 1 => 2
             * 2 => 3
             * 3 => 4
             * int x = 5;
             * x = x + 1 = 5 + 1 = 6
             * x = x + 1;
             * int y = 9;
             * POST INCREMENT
             * y = 9 + x++; = 9 + 5 = 14      // x = 5
             * PRE INCREMENT
             * y = 9 + ++x;   9 + 6 = 15   // x = 5
             * y = 9 + x++ + ++x; 9 + 5 + 7       // x = 7
             * HAS THE HIGHEST PRIORITY
             * y = 9 * ++x + 9 * x; =9 * 6 + 9 * 6      // x = 5
             * ===================
             * Decrement (unary operator, var--, --var)
             * POST DECREMENT
             * int x = 5;
             * x--   // x = 4
             * PRE DECREMENT
             * --x   // x = 4
             * ===================
             * PRE IS FASTER THAN POST.
             * POST: get current value, then add 1?
             * PRE: get value + 1
             */

            #endregion

            #region Assignment Operators

            /*
             * ===================
             * Adding value onto self (+=)
             * x += 5 is equal to: x = x + 5
             * ===================
             * Subtracting value from self (-=)
             * x -= 5 is equal to: x = x - 5
             * int x = 9;
             * x -= 4; = x = 9 - 4 = 5
             * ===================
             * Multiplying value onto self (*=)
             * x *= 5 is equal to: x = x * 5
             * ===================
             * Dividing self by value (/=)
             * x /= 5 is equal to x = x / 5
             * ===================
             * Assigning remainder between self and value onto self. (%=)
             * x %= 5 is equal to x = x % 5
             * ===================
             */

            #endregion

            #region Logical Operators

            /*
             * ===================
             * Check if all expressions equal true: AND (&&)
             * Statement will only be true IF all expressions were true.
             * Water is only clean if:
             * Has no microbes
             * Filtered
             * Looks pure
             * if (Has no microbes && Filtered && looks pure)
             * ===================
             * Check if atleast one of the expressions equals true: OR (||)
             * Statement will be true IF atleast one of the expressions were true.
             *
             * you can quench your thirst
             * if you drink:
             * water, juice, soda,
             * if (water || juice || soda)
             *
             *
             * ===================
             * Invert statement: NOT (!)
             * if statement is true -> false
             * if statement is false -> true.
             * if i dont have money, i will walk.
             * if (!money)
             * {
             *   i will walk;
             * }
             */

            #endregion

            #region Comparison Operators

            /*
             * ===================
             * GREATER THAN (>)
             * True if value is greater than other value
             * int x = 5;
             * if (x > 4)
             * {
             *    Console.Writeline("hello")
             * }
             * ===================
             * LESS THAN (<)
             * True if value is less than other value
             * int x = 3;
             * if (x < 4)
             * {
             *    Console.Writeline("world")
             * }
             * ===================
             * GREATER THAN OR EQUAL (>=)
             * True if value is greater than other value or equals the other value
             * int x = 3;
             * if (x >= 4)
             * {
             *    Console.Writeline("hello world")
             * }
             * ===================
             * LESS THAN OR EQUAL (<=)
             * True if value is less than other value or equal
             * int x = 3;
             * if (x <= 4)
             * {
             *    Console.Writeline("world hello")
             * }
             * ===================
             * EQUAL (==)
             * True if value is equal other value
             * int x = 4;
             * if (x == 4)
             * {
             *    Console.Writeline("world world")
             * }
             * ===================
             * NOT EQUAL (!=)
             * True if value is not equal other value
             * int x = 3;
             * if (x < 4)
             * {
             *    Console.Writeline("hello hello")
             * }
             * ===================
             */

            #endregion
            #endregion
            #region Conditionals

            /*
             * How to control the flow of the program? Sometimes in life, things can go differently than expected.
             * For example, let's say you went to buy a can of soda that costed 10 pounds and while checking out,
             * you realised you had only 5 pounds.
             *
             * You wont be able to buy the soda, so you will have to buy a bottle of water instead for 5 pounds.
             * Let's say that you had 10 pounds, then you would be able to buy a soda.
             * Same thing in programming, sometimes different algorithms/computations take place depending on certain CONDITIONS
             * To control the flow of the program,
             * We use conditional statements alongside boolean expressions with logical operators and comparison operators.
             * Each process is called a branch.
             * For example:
             * having less than 10 pounds, i only bought a bottle of water,
             * having more than or exactly 10 pounds, i only bought a soda.
             * buying a bottle of water is a branch, as I could have also bought a soda if i had enough money.
             * any sort of computation or process that could happen is called a branch.
             * Branches are contained in conditional blocks,
             * A conditional block is where you define your branch.
             * There are 4 conditional blocks:
             * IF: If the statement is true, then execute this branch.
             * Else: MUST COME AFTER AN IF/ELSE IF, if the statement was false, execute this branch.
             * ELse If: MUST COME AFTER AN IF/ELSE IF, if the statement was false, then check this condition, if it's true then execute this branch.
             * Switch: Allows you to define multiple branches easily while giving better performance too.
             *
             * 1, 2, 3, 4, default
             * Member, Moderator, Admin, Owner, guest
             *
             * IF/ELSE/ELSE IF : ANY BOOLEAN STATEMENT, Ranges, Intervals.
             * Switch: DISCRETE BOOLEAN STATEMENTS
             *
             * IF:
             * if (condition)
             * {
             *      branch statements...
             * }
             * ORR
             * if (condition) branch statement;
             *
             * if (condition)
             * branch statement;
             *
             * KEEP IN MIND, IF YOU DONT USE BRACKETS, IT WILL ONLY BE ASSOCIATED WITH THE FIRST STATEMENT IT ENCOUNTERS.
             *
             * ELSE IF:
             * else if (condition)
             * {
             *      branch statements...
             * }
             * OR
             * else if (condition) branch statement;
             *
             * else if (condition)
             * branch statement;
             *
             * ELSE:
             * else
             * {
             *      branch statements...
             * }
             * OR
             * else branch statement;
             *
             * else
             * branch statement;
             *
             * SWITCH:
             * It's split into different cases, if the value matches any of those cases, it will execute that case,
             * if the value doesnt match any of those cases, it will instead not execute any or execute the default case if found.
             * switch (value)
             * {
             *      case (expected value):
             *          branch statements...
             *          break;
             *      default:
             *          branch statements...
             *          break;
             * }
             * THERE MUST BE ATLEAST ONE CASE/DEFAULT.
             * expected value MUST be the same type as the value.
             * value: string, expected value: string.
             * You can also chain cases as will be demonstrated below.
             *
             */
            // get input from user
            //int x = int.Parse(Console.ReadLine());
            //if (x < 5)
            //{
            //    Console.WriteLine("hello");
            //}
            //else if (x > 9 && x < 15)
            //{
            //    Console.WriteLine("hello world");
            //}
            //else
            //{
            //    Console.WriteLine("world");
            //}
            //int clearanceLevel = 9;
            //switch (clearanceLevel)
            //{
            //    case 1:
            //        Console.WriteLine("Member");
            //        break;
            //    case 2:
            //        Console.WriteLine("Moderator");
            //        break;
            //    case 3:
            //        Console.WriteLine("Admin");
            //        break;
            //    case 4:
            //        Console.WriteLine("Owner");
            //        break;
            //    default:
            //        Console.WriteLine("Guest");
            //        break;
            //}
            //string day = "Friday";
            //switch (day)
            //{
            //    case "Saturday":
            //    case "Friday":
            //        Console.WriteLine("Weekend");
            //        break;
            //    default:
            //        Console.WriteLine("Weekday");
            //        break;
            //}
            #endregion

            #region Scopes

            /*
             * Factory, workers, worker: Can, worker: Car, worker: Pencils
             * A scope is like a room, it's where some parts of your program lives independently of others.
             * But unlike a room, a scope does NOT allow that part of the program to leave.
             * A scope can be composed of nested scopes.
             * Think of it as a flat.
             * A flat ("Scope") is composed of multiple rooms("Scopes").
             * You got a bedroom, a bathroom and a kitchen, and you, a "local" of that flat("Scope").
             * You can go to different rooms and interact with objects INSIDE those rooms
             * BUT those objects can't leave the room to interact with you. Those objects don't know that you exist. They simply wait for anything to interact with them.
             * A scope is similar.
             * Each "room"/"scope" is defined in code blocks (Such as conditional blocks)
             * Anything inside of that scope is considered local to that scope, (Mostly variables)
             * Example on a scope:
             */
            //int x = 5;
            //if (x > 3)
            //{
            //    if (x > 2)
            //    {
            //        int z = 4;
            //    }
            //    int y5 = 4;
            //    y5 = x;
            //    x = 4;
            //    Console.WriteLine(y5);
            //}

            /*
             * X can be used inside of the if scope as x is part of the parent scope. But y can't be used outside if scope.
             * Scope variables are automatically deleted once you exit that scope, so depending on how and where you write your variables, you can save memory.
             * (It's always important to ensure that your variables are as close to the required scope as possible)
             * Scope variables are assigned on the stack (Which is where the scope lives, so every scope variable are next to each other in memory which means that
             * scope/local variables are much faster at reading and writing in their corresponding scope.
             *
             * Example on some of the bad cases on defining scope variables
             */

            // Bad
            //int x = 9;
            //int y = 10;
            //int z = 0;
            //int w = 8;
            //if (x < 10)
            //{
            //    if (y < 10)
            //    {
            //        z = x + y;
            //    }
            //    else if (w < 10)
            //    {
            //        z = x + w;
            //    }
            //}
            //Console.WriteLine(z);


            // Good
            //int x2 = 9;
            //if (x2 < 10)
            //{
            //    int y2 = 10;
            //    int w2 = 8;
            //    if (y2 < 10)
            //    {
            //        int z2 = x2 + y2;
            //        Console.WriteLine(z2);
            //    }
            //    else if (w2 < 10)
            //    {
            //        int z2 = x2 + w2;
            //        Console.WriteLine(z2);
            //    }
            //}
            /*
             * In the good case we ensured the variables stay close to where theyre needed only.
             * You should only bring variables out of their scope IF AND ONLY IF, you intend on using it again.
             */

            #endregion
            #region Arrays

            /*
             * To define a variable, we had to give it a name, a datatype and optionally a value.
             * string name1 = "Mohamed";
             * string name2 = "Ali";
             * string name3 = "Maryam";
             * Document file-> Mohamed, Ali, Maryam
             * Document file-> Records, Name of student, id of student,
             * string studentName1 = "";
             * string studentName2 = "";
             * What if we got multiple data we want to define?
             * It would be really tedious to define every variable for every data.
             * What if you want to use them and operate on them? you will have to keep track of every variable and what they do. It get's really tedious after like 5 variables.
             * An array is just simply a variable that holds all those data together next to each other on memory.
             * name 1 = "Mohamed";
             * name 2 = "Ali";
             * name 3 = "Maryam";
             * ["Mohamed", "Ali", "Maryam"]
             * It's like a book shelf.
             * A book shelf contains books, and they are always ordered. You can immediately grab the 5th book from the bookshelf, you can ask anyone to grab the 5th book without caring
             * what the book's title is.
             * ||||||
             * ______
             *
             * ||||||||||||||
             * ______________
             *
             * Woodworker -> Make shelf of size (8)
             * N people ages:
             * ages -> 9 data, slots, memory, storage.
             * average age:
             * sum / number
             * [2,4,5,7,8,10]
             * An array is similar, it's just a fixed size collection of data all grouped together in memory. It forms a "Data Structure" and an array is often the most useful and first data structure
             * you must learn.
             * How to define an array?
             * It's like a variable, you can declare, intiialize and assign.
             * ARRAY DECLARATION:
             * You are telling the program that there will be an array, but you havent yet told the program the size of your array, this is useful when you don't know the size of your array.
             * datatype[] name;
             *
             * ARRAY INITIALIZATION:
             * You are telling the program to reserve a fixed amount of memory in your program for your array data.
             * datatype[] name = new datatype[size];
             * int[] age = new int[3];
             * This initializes your array where every element is equal to the default value of the datatype.
             * If you want to initialize it with custom values, you have 2 ways:
             * You have to give it all the values it using this method. you cant just give it 5 values when you specified it should have 10 for example, you must fill every single data.
             * datatype[] name = new datatype[size] {1,2,3,...,n};
             * int[] ages = new int[3] {1, 2, 3}
             *
             * Or you can also initialize it like this:
             * you dont have to give it a fixed size, it will automatically determine the size.
             * datatype[] name = new int[] {1, 2, 3, 4, 5};
             * or
             * datatype[] name = {1, 4, 7, 4, 2};
             *
             * ARRAY ASSIGNMENT:
             * You can also change an array completely and assign it to a new array just like how you initialized arrays before or simply assign an array to another array:
             * Examples:
             * array = new int[] {1, 2, 3};
             * array = new int[6] {1, 2, 3, 4, 5, 6};
             * int[] array2 = {1, 4, 6};
             * array = array2;
             * ARRAY IS A REFERENCE TYPE:
             * In C#, datatypes are split into two parts, either a value type (All primitive data types we used like int, float, char, double, bool),
             * and reference types (Any sort of data collections such as arrays and strings).
             * A value type can be copied to another variable. but a reference type is not copied.
             * when we say
             * carton of milk.
             * cup, 250 ml milk.
             * int x = 5;
             * int y = x;
             * here we are saying that we want the VALUE of x which is 5 to be copied and stored in y.
             * but when we forexample do this:
             * carton of milk.
             * int[] x = {2, 5, 6};
             * int[] y = x;
             * we are instead saying that the array y, should hold a reference to the array x.
             * Here is a simple example:
             * A value type is like taking milk from the fridge, pouring it into a cup and then putting the milk back in the fridge.
             * The cup has it's own milk now, it has copied a value from the milk and stored it inside it self. If you spill the cup, it doesnt affect the milk carton.
             * But a reference type is like taking the milk carton itself and using it. if you spill the milk carton, it will affect it too.
             * so if we changed an element value in the array y, it will also change in array x. since y is just a reference to array x, which means that you are actually working on array x instead.
             *
             * READ AND WRITE A SINGLE ELEMENT:
             * In an array, in order to read or write to a single element in an array, we just need to specify the index of the element.
             * Remember how we said if we had a bookshelf of 10 books, you could easily just grab the 5th book from the shelf.
             * Array indexing works the same way too.
             * You just tell the array which element you want, and it gives it back to you.
             * You can also edit that element and assign it another value.
             * INDEXING:
             * An array is 0 Indexed, which means that the first element of the array is always at the index 0,
             * and the second element is at index 1. so the index is always the element position - 1.
             * You must make sure the index lies between 0 and size - 1 or you would get an error, if you had a 5 books bookshelf,
             * you cant get the -1'th book or the 6th book as those don't exist and arent logical.
             * To index in c#:
             * array[index];
             * you can either read it like a variable and use it like this:
             * int x = array[index] + 5;
             * or write to it like this:
             * array[index] = 5;
             * Arrays can help us simplify code and boost performance too. we can perform multiple operations on multiple data together very easily.
             * The power of arrays is mostly related to looping which will be the topic of the next video.
             */
            // int[] arr1 = new int[5];
            // int[] arr = new int[9] { 2, 4, 5, 6, 7, 8, 9, 0, 4 };
            // int[] arr2 = new int[] { 4, 6, 7 };
            // arr = new int[5] { 5, 4, 3, 7, 2 };
            // arr = new int[] { 2, 5, 4};
            //
            // Console.WriteLine(arr2[0]);
            // Console.WriteLine(arr2[1]);
            // Console.WriteLine(arr2[2]);
            // Console.WriteLine(arr2[3]);
            //
            //
            // int[] arr3 = arr;
            // Console.WriteLine(arr[0]);
            // Console.WriteLine(arr3[0]);
            // arr3[0] = 5;
            // Console.WriteLine(arr[0]);
            // Console.WriteLine(arr3[0]);
            // arr[0] = 7;
            // Console.WriteLine(arr[0]);
            // Console.WriteLine(arr3[0]);
            //
            // Console.WriteLine();
            //
            // int x = 6;
            // int y = x;
            //
            // Console.WriteLine(x);
            // Console.WriteLine(y);
            //
            // y = 4;
            // Console.WriteLine(x);
            // Console.WriteLine(y);




            #endregion
            #region Loops and Iterations

            /*
             * Sometimes when we write our programs, we would like them to repeat a certain process.
             * For example, we would like to calculate an arithmetic sequence. Something like the sum of all natural numbers from 1 to n
             * We could just type it out like this:
             * int sum = 1 + 2 + 3 + 4 + 5 +... + n;
             * but this can get really tedious really quickly!
             * This is where loops come to shine.
             * Loops can help us iterate and repeat certain procedures for as long as we need. (Be careful, sometimes you could end up looping forever!)
             * But what exactly is a loop and how can we incorperate it into our program?
             * Let's first write what's known as a pseudo code.
             * int sum = 0
             * int i = 0
             * int max = 10
          -> * LOOP:
             * if i >= max, go to END.
             * sum += i
             * ++i
             * go to LOOP
             * END:
             * print(sum)
             * 
             * So this is our pseudo code, a pseudo code is simply just a way to express our algorithms in a way similar to a programming language.
             * Here as you can see, we want to add the value of i onto x every time, and increment i by 1.
             * if i reaches our max value, we would like to end our loop.
             * Seems easy right?
             * Every loop consists of a start and an end case. if there is no end case, the loop will simply repeat forever.
             * This is a loop that we already know how many iterations it will run and when it will end.
             * So this is a pre determined loop, it will always run a specific number of times!
             * Such loops are mostly referred to as FOR LOOPS
             */
            /*
             * A for loop is a type of loop that has a start condition and an end condition.
             * A for loop is basically a simpler way to write the loop we wrote earlier.
             * for loops in c# are defined as such:
             * Initial statement: A statement that will run only once when the loop is initialized, it can be used to define variables. (the int i we defined earlier)
             * condition statement: A statement that will run at the start of every loop to check for condition (The if statement we had used earlier)
             * per loop statement: A statement that will be run at the end of each loop. (The increment i statement we used earlier (++i))
             * for (initial statement; condition statement; per loop statement)
             * {
             *      body statements...
             * }
             * The body statements is the procedure/program we would like to repeat.
             * For loops are also really useful when it comes to arrays, as it can allow you to access array elements sequentially.
             * You could use them to find the sum of an integer array.
             * where you would increment i by 1 and let i be your index.
             * We could also have nested loops.
             * where we run a loop inside of another loop.
             * Example:
             * We can have a number n, that can be printed n times on it's own line.
             * 1,9
             * 
             */
            #region Pseudo Code
            /*int x = 0
            * int i = 0
            * int max = 10
            * LOOP:
            * if i >= max, go to END.
            * x += i
            * ++i
            * go to LOOP
            *END:
            *print(x)
            */
            #endregion
            //int x = 0;
            //int n = 10;
            //for (int i = 0; i < n; ++i)
            //{
            //    x += i;
            //}
            //Console.WriteLine(x);

            //int arrSum = 0;
            //int[] arr = { 1, 10, 5, 20, 10, 30 };
            //for (int i = 0; i < arr.Length; ++i)
            //{
            //    arrSum += arr[i];
            //}
            //Console.WriteLine(arrSum);

            //int nMax = 10;
            //for (int i = 0; i < nMax; ++i)
            //{
            //    for (int j = 0; j < i; ++j)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}
            /*
             * What if we don't know how many times we should loop for?
             * What if we are just looping till a certain condition is met? (This is very important in game development!)
             * Maybe we would like to loop till the user enters the correct passkey.
             * or maybe we would like to create a game loop that will only end when the user closes the program.
             * These types of loops which have an undetermined execution time are mostly created using while loops.
             * a while loop is simpler than a for loop, but it can be more dangerous as it can lock your program and loop indefinitely.
             * Let's write a pseudocode for a program that will run indefinitely untill the user enters a certain passkey.
             * string password = "password"
             * string userinput = ""
             * LOOP:
             * if userinput == password: go to END
             * userinput = input("Enter password")
             * goto LOOP
             * END:
             * print("Access Granted")
             * Here we will run untill the user enters the correct password.
             * we first store the correct password in a variable.
             * and we will get an input from the user and compare it to the correct password.
             * if it's true, we end the loop, if not we will just repeat the process.
             * We would need to utilize the while loop here.
             * while loop has a simpler syntax:
             * while (condition statement)
             * {
             *      body statements...
             * }
             * Let's implement our while loop.
             */
            //string password = "password";
            //string userInput = "";
            //while (userInput != password)
            //{
            //    Console.Write("Enter password: ");
            //    userInput = Console.ReadLine();
            //}
            //Console.WriteLine("Access Granted");

            /*
             * There is one flaw in our program. What if we would like to tell the user that the password was incorrect? How can we do that? 
             * We can't just print to the user at the very start that the password is incorrect as he wouldn't have inputted a password yet.
             * We can perform the same condition check again after we take the input like this.
             */
            //string password2 = "password";
            //string userinput2 = "";
            //while (userinput2 != password2)
            //{
            //    console.write("enter password: ");
            //    userinput2 = console.readline();
            //    if (userinput2 != password2)
            //    {
            //        console.writeline("incorrect password!");
            //    }
            //} 
            //console.writeline("access granted");
            //string password2 = "password";
            //string userinput2 = "";
            //do
            //{
            //    console.write("enter password: ");
            //    userinput2 = console.readline();
            //    if (userinput2 != password2)
            //    {
            //        console.writeline("incorrect password!");
            //    }
            //}
            //while (userinput2 != password2);
            //console.writeline("access granted");

            /*
             * This fixes it!
             * What if we wanted to take an input from the user of only positive integers, and if he gives wrong input, we should reprompt him.
             * How can we get an input from a user first of all?
             * As you have seen earlier, we used Console.ReadLine() which gives us the input string that the user has entered.
             * But it has one problem. It will always be a string.
             * What if we wanted to take in a float or an int as input?
             * There must be a way to convert from string to int or float.
             * There is!
             * to convert any string to a number (assuming that it can be converted)
             * we use the following method:
             * datatype.Parse(string);
             * for example, if we wanted to turn a string to an int, we would write it as such:
             * int.Parse(string);
             * we can replace string with Console.ReadLine() and we will be able to get numbers as inputs!
             * int input = int.Parse(Console.ReadLine());
             * Let's try to write a program that will reprompt the user if the number was less than 0.
             */
            //int input = -1;
            //while (input < 0)
            //{
            //    Console.WriteLine("Enter a non negative number");
            //    input = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Your number input is = " + input);
            /*
             * There is one really small problem, 
             * It's not really necessary to perform the while check before i take the input from the user as it will always be wrong.
             * It just adds a layer of complexity and an extra comparison for no reason.
             * It would be better if we can instead run that code once without checking for condition first then loop if condition is not met.
             * To fix this, we instead use a do while loop which does exactly that.
             * a do while loop is similar to a while loop except that it will ALWAYS run atleast once.
             * syntax:
             * do 
             * {
             *      body statements...
             * }
             * while (condition);
             */
            //int input2 = 0;
            //do
            //{
            //    Console.WriteLine("Enter a non negative number");
            //    input2 = int.Parse(Console.ReadLine());
            //}
            //while (input2 < 0);
            //Console.WriteLine("Your number input is = " + input2);
            /*
             * And that would be it for loops!
             */
            #endregion
            #region Methods
            /*
             * Sometimes, in our daily lives, certain phrases could mean 
             */
            #endregion

            #region OOP
            #region Class and Object
            #endregion
            #region Pillars of OOP
            #endregion
            #endregion
        }

        int Sum(int x, int y)
        {
            return x + y;
        }

        float Sum(float x, float y)
        {
            return x + y;
        }


    }
    
}