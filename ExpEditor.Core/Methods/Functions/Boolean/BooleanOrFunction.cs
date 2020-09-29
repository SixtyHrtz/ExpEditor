namespace ExpEditor.Core
{
    public class BooleanOrFunction : Function<BooleanExpression>
    {
        public override string Template { get { return "(@Value1 Or @Value2)"; } }

        private readonly BooleanExpression value1 = new BooleanExpression(name: "Value1");
        private readonly BooleanExpression value2 = new BooleanExpression(name: "Value2");

        public BooleanOrFunction() => SetExpressions(value1, value2);

        public override IExpression Evaluate() =>
            new BooleanExpression(value1 || value2);
    }
}
