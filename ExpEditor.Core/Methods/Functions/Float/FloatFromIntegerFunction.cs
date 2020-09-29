namespace ExpEditor.Core
{
    public class FloatFromIntegerFunction : Function<FloatExpression>
    {
        public override string Template { get { return "Float(@Value)"; } }

        private readonly IntegerExpression value = new IntegerExpression(name: "Value");

        public FloatFromIntegerFunction() => SetExpressions(value);

        public override IExpression Evaluate() =>
            new FloatExpression(value);
    }
}
