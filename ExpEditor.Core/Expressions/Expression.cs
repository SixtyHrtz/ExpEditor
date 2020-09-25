namespace ExpEditor.Core
{
    public abstract class Expression<T> : IExpression
    {
        public string Name { get; }
        public abstract string BaseValue { get; set; }
        public T Value { get; protected set; }
        public IConstant Constant { get; set; }
        public IFunction Function { get; set; }

        public abstract ExpressionType AllowedExpressionTypes { get; }
        public ExpressionType ExpressionType { get; set; }

        public Expression(T value, string name)
        {
            Name = name;
            BaseValue = value.ToString();

            SetDefaultExpressionType();
        }

        private void SetDefaultExpressionType()
        {
            if (AllowedExpressionTypes.HasFlag(ExpressionType.Value))
                ExpressionType = ExpressionType.Value;
            else if (AllowedExpressionTypes.HasFlag(ExpressionType.Constant))
                ExpressionType = ExpressionType.Constant;
            else if (AllowedExpressionTypes == ExpressionType.Function)
                ExpressionType = ExpressionType.Function;
        }

        public IExpression Evaluate()
        {
            switch (ExpressionType)
            {
                case ExpressionType.Constant:
                    return Constant.Expression;
                case ExpressionType.Value:
                    return this;
                case ExpressionType.Function:
                    return Function.Evaluate();
                default:
                    return null;
            }
        }

        public override string ToString()
        {
            switch (ExpressionType)
            {
                case ExpressionType.Constant:
                    return Constant.ToString();
                case ExpressionType.Value:
                    return BaseValue;
                case ExpressionType.Function:
                    return Function.Inspect();
            }

            return "null";
        }
    }
}
