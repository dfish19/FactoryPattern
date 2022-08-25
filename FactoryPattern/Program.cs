using FactoryPattern;

Console.WriteLine("Pick a number from 1 -3 and find the vacation country of your choice"); 
string userInput = Console.ReadLine();


var vacation = VacationFactory.GetVacation(userInput);
vacation.Relaxing();


