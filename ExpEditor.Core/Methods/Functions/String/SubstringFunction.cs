namespace ExpEditor.Core
{
    public class SubstringFunction : Function<StringExpression>
    {
        public override string Template { get { return "Substring(@String, @From, @To)"; } }

        private readonly StringExpression text = new StringExpression(name: "String");
        private readonly IntegerExpression from = new IntegerExpression(name: "From");
        private readonly IntegerExpression to = new IntegerExpression(name: "To");

        public SubstringFunction() => SetExpressions(text, from, to);

        public override IExpression Evaluate() =>
            new StringExpression(((string)text).Substring(from, to - from));
    }
}
