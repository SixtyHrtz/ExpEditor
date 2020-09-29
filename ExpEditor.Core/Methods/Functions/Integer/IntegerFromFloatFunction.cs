namespace ExpEditor.Core
{
    public class IntegerFromFloatFunction : Function<IntegerExpression>
    {
        public override string Template { get { return "Integer(@Value)"; } }

        private readonly FloatExpression value = new FloatExpression(name: "Value");

        public IntegerFromFloatFunction() => SetExpressions(value);

        public override IExpression Evaluate() =>
            new IntegerExpression((int)value);
    }
}
