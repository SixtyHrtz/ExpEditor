namespace ExpEditor.Core
{
    public class ArithmeticFunction : Function<IntegerExpression>
    {
        public override string Template { get { return "(@Value1 @Sign @Value2)"; } }

        private readonly IntegerExpression value1 = new IntegerExpression(name: "Value1");
        private readonly OperatorExpression sign = new OperatorExpression(name: "Sign");
        private readonly IntegerExpression value2 = new IntegerExpression(name: "Value2");

        public ArithmeticFunction() => SetExpressions(value1, sign, value2);

        public override IExpression Evaluate()
        {
            switch (sign.Value)
            {
                case OperatorExpressionType.Plus: return new IntegerExpression(value1 + value2);
                case OperatorExpressionType.Minus: return new IntegerExpression(value1 - value2);
                case OperatorExpressionType.Multiply: return new IntegerExpression(value1 * value2);
                case OperatorExpressionType.Divide: return new IntegerExpression(value1 / value2);
                case OperatorExpressionType.Modulo: return new IntegerExpression(value1 % value2);
                default: return null;
            }
        }
    }
}
