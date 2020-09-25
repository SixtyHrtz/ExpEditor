namespace ExpEditor.Core
{
    public interface IFunction : IMethod
    {
        IExpression Evaluate();
    }
}
