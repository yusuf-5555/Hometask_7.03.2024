public class Counter
{
    int _value;

    public Counter(int value)
    {
        _value = value;
    }

    public void Decrement()
    {
        if(_value>0){
        _value = _value-1;
        }
    }
    public void Reset()
    {
        _value = 0;
    }

    public void PrintValue()
    {
        System.Console.WriteLine(_value);
    }
}