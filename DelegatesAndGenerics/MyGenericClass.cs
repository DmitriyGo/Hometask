namespace DelegatesAndGenerics;

public class MyGenericClass<T>
{
    private FirstDelegate<T> randomMethod;

    public MyGenericClass(FirstDelegate<T> del)
    {
        this.randomMethod = del;
    }

    public void Execute(T arg)
    {
        this.randomMethod(arg);
    }
}