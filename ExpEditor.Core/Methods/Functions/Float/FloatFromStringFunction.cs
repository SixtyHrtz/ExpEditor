namespace ExpEditor.Core
{
    public class FloatFromStringFunction : Function<FloatExpression>
    {
        public override string Template { get { return "Float(@String)"; } }

        private readonly StringExpression text = new StringExpression(name: "String");

        public FloatFromStringFunction() => SetExpressions(text);

        public override IExpression Evaluate()
        {
            float.TryParse(text, out float result);
            return new FloatExpression(result);
        }
    }
}
