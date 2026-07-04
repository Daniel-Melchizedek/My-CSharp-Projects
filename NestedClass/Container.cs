public class Container
{
    public Container()
    {
        Container.Nested nest = new Container.Nested();
        // nest.parent = null;
        nest.NestedMethod();
    }
    private partial class Nested
    {
        private Container? parent;
        public Nested(){}
        public Nested(Container parent)
        {
            this.parent = parent;
        }
        public void NestedMethod()
        {
            
        }
    }
    private partial class Nested
    {
        private void Test2(){}
    }
}