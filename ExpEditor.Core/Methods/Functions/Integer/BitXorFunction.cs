namespace ExpEditor.Core
{
    public class BitXorFunction : Function<IntegerExpression>
    {
        public override string Template { get { return "(@Value1 Xor @Value2)"; } }

        private readonly IntegerExpression value1 = new IntegerExpression(name: "Value1");
        private readonly IntegerExpression value2 = new IntegerExpression(name: "Value2");

        public BitXorFunction() => SetExpressions(value1, value2);

        public override IExpression Evaluate() =>
            new IntegerExpression(value1 ^ value2);
    }
}
