namespace ExpEditor.Core
{
    public class IntegerBitOrFunction : Function<IntegerExpression>
    {
        public override string Template { get { return "(@Value1 Or @Value2)"; } }

        private readonly IntegerExpression value1 = new IntegerExpression(name: "Value1");
        private readonly IntegerExpression value2 = new IntegerExpression(name: "Value2");

        public IntegerBitOrFunction() => SetExpressions(value1, value2);

        public override IExpression Evaluate() =>
            new IntegerExpression(value1 | value2);
    }
}
