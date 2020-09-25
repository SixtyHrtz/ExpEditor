namespace ExpEditor.Core
{
    public abstract class Function<T> : Method, IFunction
    {
        public abstract IExpression Evaluate();
    }
}
