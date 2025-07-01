namespace Assingment11_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            ////1- Write a program that allows the user to enter a number then print it.

            //Console.Write("Enter Your Number : ");
            //int userInput = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Your Number is : {userInput}");

            #endregion

            #region Question02
            ////2- Write C# program that converts a string to an integer, but the string contains non - numeric characters.
            ////And mention what will happen

            //Console.WriteLine("Enter your name");
            //int userString = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Your name is : {userString}");

            //// This will throw a FormatException because the input string cannot be converted to an integer.

            #endregion

            #region Question03
            ////3- Write C# program that Perform a simple arithmetic operation with floating - point numbers
            ////And mention what will happen

            //float num1 = 2.1489f;
            //float num2 = 3.256f;
            //float result = num1 + num2; 
            //Console.WriteLine($"The result is: {result}");

            //// code practise is well.

            #endregion

            #region Question04
            ////4 - Write C# program that Extract a substring from a given string.

            //Console.WriteLine("Enter your full name");
            //string fullName = Console.ReadLine();

            //Console.WriteLine($"The first 5 characters of your name are: {fullName.Substring(0, 6)}");

            //// get first name of the user
            //string[] firstName = fullName.Split(' ');
            //Console.WriteLine($"First name of your full name is: {firstName[0]}");

            #endregion

            #region Question05
            ////5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable
            ////and mention what will happen

            //int x;
            //double y;
            //float r;
            //decimal d;
            //x = y; //no convertion
            //y= x; //ok
            //r = x; //ok
            //d = x; //ok

            //// int can convert to Float & double & decimal.

            //float z;
            //decimal n;
            //double m;
            //z = n; 
            //n = z; 
            //n = m;
            //m = n;
            //z = m; 

            //// This will throw a compile-time error because you cannot convert a double to an int. -->implicit

            #endregion

            #region Question06
            ////6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable
            ////and mention what will happen

            //string FirstName;
            //string SecondName;
            //FirstName = "Mustafa";
            //SecondName = FirstName; 
            //Console.WriteLine($"First Name HashCode: {FirstName.GetHashCode()}");
            //Console.WriteLine($"Second Name HashCode: {SecondName.GetHashCode()}");
            ////Noted: 01 ) thay have the same hashcode.

            //SecondName = "Ahmed";
            //Console.WriteLine($"First Name HashCode: {FirstName.GetHashCode()}");
            //Console.WriteLine($"Second Name HashCode: {SecondName.GetHashCode()}");

            ////Noted: 02 ) thay have different hashcode.


            #endregion

            #region Question07
            ////7 - Write C# program that take two string variables and print them as one variable.

            //Console.WriteLine("Enter your First name: ");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("Enter your Last name: ");
            //string lastName = Console.ReadLine();

            //Console.WriteLine($"Your Full Name is : {firstName} {lastName}");

            #endregion

            #region Question08
            ////8- Write a program that calculates the simple interest given the principal amount, rate of interest,and time.
            ////The formula for simple interest is Interest = (principal * rate * time) / 100.

            //Console.WriteLine("Enter the principal amount: ");
            //double givinMoney = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the rate of interest per year: ");
            //double addedMoney = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the time in years: ");
            //double payedTime = double.Parse(Console.ReadLine());

            //Console.WriteLine($"The interest is: {(givinMoney * addedMoney * payedTime) / 100}");

            #endregion

            #region Question09
            ////9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters.
            ////The formula for BMI is BMI = (Weight) / (Height * Height)

            //Console.WriteLine("Enter your weight in kilograms: ");
            //double userWt = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your height in meters: ");
            //double userHg = double.Parse(Console.ReadLine());

            //Console.WriteLine($"your BMI is: {(userWt) / (userHg * userHg)}");

            #endregion

            #region Question10
            ////10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good.
            ////Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot",
            ////and anything else is "Just Good".

            //Console.WriteLine("Enter the temperature in degrees: ");
            //double tempreture = int.Parse(Console.ReadLine());

            //string state = (tempreture < 10) ? "Just Cold" : (tempreture > 30) ? "Just Hot" : "Just Good";
            //Console.WriteLine(state);

            #endregion

            #region Question11 
            ////11 - Write a program that takes the date from the user and displays it in various formats using string interpolation.
            ////Ex :
            ////Today’s date : 20 , 11 , 2001
            ////Today's date : 20 / 11 / 2001
            ////Today's date : 20 – 11 – 2001


            //Console.WriteLine("Enter the date: ");
            //string userDate = Convert.ToDateTime(Console.ReadLine());

            #endregion

            #region Question12

            ////12 - What is the output of the following C# code?
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            //// outPut is ( 06/14/2024 )

            #endregion

            #region Question13

            ////13- Which of the following statements is correct about the C#.NET code snippet given below?

            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);

            //// when convert from bool to int , int value will be 1 if true and 0 if false

            #endregion

            #region Question 14
            ////14-  Which of the following is the correct output for the C# code given below?

            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            ////when inputs be integer like 13 and 2 , output will be integer too so any desemal number will be neglegt 
            //// so result will be 6  for 13/2 and 1 for 13%2

            #endregion

            #region Question15
            ////15-What will be the output of the C# code given below?

            //int num = 1, z = 5;
            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            //// as condition is true so
            ////01) ++num mean add 1 before use num so will be 2
            ////02) z++ mean use z then add 1 after use so will be 5
            ////03) fisrt part will be 7
            ////04) ++z mean add 1 before use z so will be 7 as z was z++ before so z = 6
            ////05) second part will be 7
            #endregion

        }
    }
}
