// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

ClockRadio clockRadio = new ClockRadio("5:00 PM", "95.7", true, "5:10AM");
string time = clockRadio.getCurrentTime();
System.Console.WriteLine("The time is: " + time);
time = clockRadio.setCurrentTime("3:46 PM");
System.Console.WriteLine("New time is: " + time);
System.Console.WriteLine("Time " + clockRadio.getCurrentTime());