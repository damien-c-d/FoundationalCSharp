// string firstName; //Declaration
// firstName = "Bob"; //Assignment

// "Bob" = firstName; //Improper Assignment

// int firstName;
// firstName = "Bob"; //Improper assignment of incorrect datatype

// string firstName;
// firstName = "Bob";
// Console.Write(firstName); //Print the value of the variable
// Console.WriteLine(); //Print a new line

//Variable reassignment
// string firstName;
// firstName = "Bob";
// Console.WriteLine(firstName);
// firstName = "Liem";
// Console.WriteLine(firstName);
// firstName = "Isabella";
// Console.WriteLine(firstName);
// firstName = "Yasmin";
// Console.WriteLine(firstName); 

//Access unintialized variable
// string firstName;
// Console.WriteLine(firstName);

// string firstName = "Bob"; //Inline assignment
// Console.WriteLine(firstName);
// HashSet<string> NamesUsed = new HashSet<string>();
// string firstName = "Bob";
// NamesUsed.Add(firstName);
// void SetFirstName(string newFirstName) {
//     Console.WriteLine($"Current First Name: {firstName}");
//     firstName = newFirstName;
//     Console.WriteLine($"New First Name: {firstName}");
//     NamesUsed.Add(firstName);
// }

// SetFirstName("Liem");
// SetFirstName("Isabella");
// SetFirstName("Yasmin");

// var lineSeparator = $"{Environment.NewLine}\t";
// Console.Write("Names Used:");
// Console.Write(lineSeparator);
// Console.WriteLine(string.Join(lineSeparator, NamesUsed));

// var message = "Hello World!";
// message = 10.703m; //Implicitly typed variables cannot change type

// var message; //Implicitly typed variables must be initialized

// dynamic message = "Hello World!";
// Console.WriteLine(message + " " + message.GetType());
// message = 10.703m; //Dynamic variables can change type
// Console.WriteLine(message + " " + message.GetType());
