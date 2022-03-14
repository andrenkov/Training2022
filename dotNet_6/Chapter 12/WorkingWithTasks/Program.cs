using System.Diagnostics;
using static System.Console;

OutpuitThreadInfo();
Stopwatch timer = Stopwatch.StartNew();

/*
MethodA();
MethodB();
MethodC();
*/

//Task is a wrapper aroud a Thread (introdused in 2010)
#region asynch on One tread
/*
 WriteLine("Running  methods asynch on One tread");
*/
/*
Task taskA = new Task(MethodA);
taskA.Start();

Task taskB = Task.Factory.StartNew(MethodB);

Task taskC = Task.Run(MethodC);


//use Wait() or WaitAny() or WaitAll() to synch Tasks
WriteLine("Running  methods asynch on Multiple tread");
Task[] tasks = { taskA , taskB , taskC };
Task.WaitAll(tasks);
*/
#endregion

#region Continuation tasks
/*
//Continuation tasks: StartNew() then ContinueWith() ...
WriteLine("Passing the result of one task as an inoput to another");

Task<string> taskSrvThenProc = Task.Factory
    .StartNew(CallWebSrv)//returns Task<decimal>
    .ContinueWith(previousTask => //returns Task<string>
    CallStoredProc(previousTask.Result));

WriteLine($"Result : {taskSrvThenProc.Result}");


static decimal CallWebSrv()
{
    WriteLine("Starting call to the web srv ...");
    OutpuitThreadInfo();
    Thread.Sleep(new Random().Next(2000, 4000));
    WriteLine("Finished call to the web srv ...");
    return 3.62M;
}

static string CallStoredProc(decimal amount)
{
    WriteLine("Starting call to the SP ...");
    OutpuitThreadInfo();
    Thread.Sleep(new Random().Next(2000, 4000));
    WriteLine("Finished call to the SP ...");
    return $"12 products cost more than {amount:C}";
}
*/
#endregion



WriteLine($"{timer.ElapsedMilliseconds:#.##0}ms elapsed");

static void OutpuitThreadInfo()//about the currrent thread
{
    Thread t = Thread.CurrentThread;
    WriteLine("Thread Id : {0}, Priority: {1}, Backgroud: {2}, Name: {3}",
              t.ManagedThreadId, t.Priority, t.IsBackground, t.Name ?? null);
}

static void MethodA()
{
    WriteLine("Starting Method A ...");

    OutpuitThreadInfo();
    Thread.Sleep(3000);

    WriteLine("Finished Method A ...");
}

static void MethodB()
{
    WriteLine("Starting Method B ...");

    OutpuitThreadInfo();
    Thread.Sleep(2000);

    WriteLine("Finished Method B ...");
}

static void MethodC()
{
    WriteLine("Starting Method C ...");

    OutpuitThreadInfo();
    Thread.Sleep(1000);

    WriteLine("Finished Method C ...");
}