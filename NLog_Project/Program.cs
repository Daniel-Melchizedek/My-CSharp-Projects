using NLog_Project;
// Counter aCounter = new Counter(); //Error
Counter.currentCount =100;
Counter.IncrementCount();
Console.WriteLine("New count: {0}",Counter.currentCount);

