using SingletonLibrary;


var myPrinter = PrintSpooler.GetPrintSpooler();

myPrinter.Enqueue("ciao");

var myPrinter2 = PrintSpooler.GetPrintSpooler();

myPrinter2.Enqueue("bye");

var myPrinter3 = PrintSpooler.GetPrintSpooler();


myPrinter3.PrintALL();

Console.WriteLine("fine");

