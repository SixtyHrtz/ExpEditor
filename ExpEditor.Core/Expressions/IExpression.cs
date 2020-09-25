namespace ExpEditor.Core
{
    public interface IExpression
    {
        string Name { get; }
        string BaseValue { get; set; }
        IConstant Constant { get; set; }
        IFunction Function { get; set; }

        ExpressionType AllowedExpressionTypes { get; }
        ExpressionType ExpressionType { get; set; }

        IExpression Evaluate();
    }
}
