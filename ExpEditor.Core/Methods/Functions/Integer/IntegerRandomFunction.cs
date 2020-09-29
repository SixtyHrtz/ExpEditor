namespace ExpEditor.Core
{
    public class IntegerRandomFunction : Function<IntegerExpression>
    {
        public override string Template { get { return "Random integer between @Value1 and @Value2"; } }

        private readonly IntegerExpression value1 = new IntegerExpression(name: "Value1");
        private readonly IntegerExpression value2 = new IntegerExpression(name: "Value2");

        public IntegerRandomFunction() => SetExpressions(value1, value2);

        public override IExpression Evaluate() =>
            new IntegerExpression(Helper.Random(value1, value2));
    }
}
