namespace ExpEditor.Core
{
    public class FloatArithmeticFunction : Function<FloatExpression>
    {
        public override string Template { get { return "(@Value1 @Sign @Value2)"; } }

        private readonly FloatExpression value1 = new FloatExpression(name: "Value1");
        private readonly OperatorExpression sign = new OperatorExpression(name: "Sign");
        private readonly FloatExpression value2 = new FloatExpression(name: "Value2");

        public FloatArithmeticFunction() => SetExpressions(value1, sign, value2);

        public override IExpression Evaluate()
        {
            switch (sign.Value)
            {
                case OperatorExpressionType.Plus: return new FloatExpression(value1 + value2);
                case OperatorExpressionType.Minus: return new FloatExpression(value1 - value2);
                case OperatorExpressionType.Multiply: return new FloatExpression(value1 * value2);
                case OperatorExpressionType.Divide: return new FloatExpression(value1 / value2);
                case OperatorExpressionType.Modulo: return new FloatExpression(value1 % value2);
                default: return null;
            }
        }
    }
}
