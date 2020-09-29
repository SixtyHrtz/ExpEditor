namespace ExpEditor.Core
{
    public class FloatRandomFunction : Function<FloatExpression>
    {
        public override string Template { get { return "Random float between @Value1 and @Value2"; } }

        private readonly FloatExpression value1 = new FloatExpression(name: "Value1");
        private readonly FloatExpression value2 = new FloatExpression(name: "Value2");

        public FloatRandomFunction() => SetExpressions(value1, value2);

        public override IExpression Evaluate() =>
            new FloatExpression(Helper.Random(value1, value2));
    }
}
