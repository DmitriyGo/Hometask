namespace DelegatesAndGenerics;

public delegate void FirstDelegate<T>(T x);
public delegate TOut SecondDelegate<TIn, TOut>(TIn x, TOut y);
public delegate double MathDelegate(double x, double y);

public class Delegate
{
    public void FirstMethod<T>(T argument)
    {
        Console.WriteLine($"{argument} in FirstMethod");
    }

    public TOut SecondMethod<TIn, TOut>(TIn argument1, TOut argument2)
    {
        Console.WriteLine($"{argument1} and {argument2} in FirstMethod");
        return argument2;
    }

    public void Foo()
    {
        FirstDelegate<string> del1 = this.FirstMethod;
        SecondDelegate<string, int> del2 = this.SecondMethod;
        var g = new MyGenericClass<string>(del1);
        g.Execute("asd");

        MathDelegate mathDelegate;
        mathDelegate = (x, y) => (x + y) / ((x + y) / 2);
        mathDelegate.Invoke(5, 5);
    }

    public List<T> FunkMethod<T>(Func<T, bool> operation1, Func<T, T> operation2, List<T> list)
    {
        return list.Where(operation1).Select(operation2).ToList();
    }
}