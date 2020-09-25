namespace ExpEditor.Core
{
    public abstract class Constant<T> : IConstant
    {
        public abstract IExpression Expression { get; }

        public override string ToString() => Expression.ToString();
    }
}
