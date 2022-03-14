using static System.Console;
using System.Diagnostics;

//safe executing methods in separate threads accessing the same recource "msg" 
WriteLine("Please wait for the taks to complte.");
Stopwatch sw = Stopwatch.StartNew();

Task a = Task.Factory.StartNew(MethodA);
Task b = Task.Factory.StartNew(MethodB);

Task.WaitAll(new Task[] { a, b });

WriteLine();
WriteLine($"Results : {SharedObjects.msg}.");
WriteLine($"{sw.ElapsedMilliseconds:N0} elapsed ms.");


static void MethodA()
{
    #region simpel lock
    //locking the static SharedObjects object, if not in use by other thread
    //simple lock internally is using Monitorr.Enter()...Monitor.Exit()
    //lock (SharedObjects.Conch)
    //{

    //    for (int i = 0; i < 5; i++)
    //    {
    //        Thread.Sleep(SharedObjects.random.Next(2000));
    //        SharedObjects.msg += "A";
    //        Write(".");
    //    }
    //}
    #endregion
    //Monitor with the 15 sec Timeout is preventing a deadlock
    try
    {
        if (Monitor.TryEnter(SharedObjects.Conch, TimeSpan.FromSeconds(15)))
        {

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(SharedObjects.random.Next(2000));
                SharedObjects.msg += "A";
                Write(".");
            }
        }
        else
        {
            WriteLine("Method A timeout");
        }
    }
    finally
    {
        Monitor.Exit(SharedObjects.Conch);
    }
}

static void MethodB()
{
    #region simpel lock
    //locking the static SharedObjects object, if not in use by other thread
    //simple lock internally is using Monitorr.Enter()...Monitor.Exit()
    //lock (SharedObjects.Conch)
    //{

    //    for (int i = 0; i < 5; i++)
    //    {
    //        Thread.Sleep(SharedObjects.random.Next(2000));
    //        SharedObjects.msg += "A";
    //        Write(".");
    //    }
    //}
    #endregion
    //Monitor with the 15 sec Timeout is preventing a deadlock
    try
    {
        if (Monitor.TryEnter(SharedObjects.Conch, TimeSpan.FromSeconds(15)))
        {

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(SharedObjects.random.Next(2000));
                SharedObjects.msg += "B";
                Write(".");
            }
        }
        else
        {
            WriteLine("Method A timeout");
        }
    }
    finally
    {
        Monitor.Exit(SharedObjects.Conch);
    }
}

static class SharedObjects
{
    public static Random random = new();
    public static string? msg;

    //add an object for applying a Lock
    public static object Conch = new();
}