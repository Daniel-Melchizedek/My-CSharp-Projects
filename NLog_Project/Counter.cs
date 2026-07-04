namespace NLog_Project;
public class Counter
{
    private Counter(){ }
    public static int currentCount;
    public static int IncrementCount()
    {
        return ++currentCount;
    }
}