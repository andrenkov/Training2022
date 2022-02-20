using static System.Console;

#region function 1
/*
byte b = 36;

/// <summary>
/// calc factorial of a given number
/// </summary>
static int Factorial(int f)
{
    if (f == 0)
        return 0;
    else if (f == 1)
        return 1;
    else
        checked
        {
            try
            {
                return f * Factorial(f - 1);
            }
            catch (OverflowException)
            {
                WriteLine("OverflowException");
                return -1;
            }
        }
}

WriteLine($"Hello, {Factorial(b)}!");
*/
#endregion

#region lambdas
//static int FibImpertive(int term)
//{
//    if (term == 1)
//        return 0;
//    if (term == 2)
//        return 1;
//    else
//    {
//        return FibImpertive (term-1) + FibImpertive (term-2);
//    }
//}

//static void RunFibImpertive()
//{
//    for (int i = 1; i <= 30; i++)
//    {
//        WriteLine("The {0} term of the Fibonaccii sequence is {1:N0}", arg0 : i, arg1 : FibImpertive(term : i));
//    }
//}

////RunFibImpertive();

//static int FibFunctional(int term) =>
//    term switch
//    {
//        1 => 0,
//        2 => 1,
//        _ => FibImpertive(term - 1) + FibImpertive(term - 2)
//    };

//static void RunFibFunctional()
//{
//    for (int i = 1; i <= 30; i++)
//    {
//        WriteLine("The {0} term of the Fibonaccii sequence is {1:N0}", arg0: i, arg1: FibFunctional(term: i));
//    }
//}

//RunFibFunctional();
#endregion

#region Logging
#endregion