using static System.Console;

Task outerTask = Task.Factory.StartNew(OuterMethod);
outerTask.Wait();
WriteLine("App is stopping");

static void OuterMethod()
{
    WriteLine("Outer method starting ...");
    Task innerTask = Task.Factory.StartNew(innerMethod, TaskCreationOptions.AttachedToParent);//AttachedToParent is to implement Parent-Child schema
    WriteLine("Outer method finished");
}

static void innerMethod()
{
    WriteLine("Inner method starting ...");
    Thread.Sleep(2000);
    WriteLine("Inner method finished");

}