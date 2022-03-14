using Pacht.Shared;
using static System.Console;

WriteLine("Processing. Please wait ...");
Recorder.Start();

//simulate the processing requiring much RAM
int[] largeArrayOfInt = Enumerable.Range(start: 1, count: 10_000 ).ToArray();
if (largeArrayOfInt.Length > 0)
{ 
}
Thread.Sleep(new Random().Next(5, 10) * 1000);

Recorder.Stop();
