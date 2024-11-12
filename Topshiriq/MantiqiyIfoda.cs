namespace Topshiriq;

public class MantiqiyIfoda
{
    // 
    public bool oprand_and(bool a, bool b)
    {
        return a && b;
    }
    public bool oprand_and(bool a, bool b, bool c)
    {
        return a && b && c;
    }
    //||
    public bool oprand_or(bool a, bool b)
    {
        return a || b;
    }
    //!
    public bool operand_not(bool a)
    {
        return !a;
    }
    
}