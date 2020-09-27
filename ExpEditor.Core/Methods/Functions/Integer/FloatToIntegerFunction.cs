namespace ExpEditor.Core
{
    public class FloatToIntegerFunction : Function<IntegerExpression>
    {
        public override string Template { get { return "Integer(@Value)"; } }

        private readonly FloatExpression value = new FloatExpression(name: "Value");

        public FloatToIntegerFunction() => SetExpressions(value);

        public override IExpression Evaluate() =>
            new IntegerExpression((int)value);
    }
}
