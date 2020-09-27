namespace ExpEditor.Core
{
    public class FloatToStringFunction : Function<StringExpression>
    {
        public override string Template { get { return "String(@Value)"; } }

        private readonly FloatExpression value = new FloatExpression(name: "Value");

        public FloatToStringFunction() => SetExpressions(value);

        public override IExpression Evaluate() => new StringExpression(value.ToString());
    }
}
