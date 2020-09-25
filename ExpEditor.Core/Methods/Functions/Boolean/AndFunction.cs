namespace ExpEditor.Core
{
    public class AndFunction : Function<BooleanExpression>
    {
        public override string Template { get { return "(@Value1 and @Value2)"; } }

        private readonly BooleanExpression value1 = new BooleanExpression(name: "Value1");
        private readonly BooleanExpression value2 = new BooleanExpression(name: "Value2");

        public AndFunction() => SetExpressions(value1, value2);

        public override IExpression Evaluate() =>
            new BooleanExpression(value1 && value2);
    }
}
