abstract partial class F
{
    int i;
}

abstract partial class F
{
    int j;
    protected abstract void methodF();
}

class G : F
{
    protected override void methodF()
    {
        throw new NotImplementedException();
    }
}