namespace ExpEditor.Core
{
    public class StringLengthFunction : Function<IntegerExpression>
    {
        public override string Template { get { return "Length of (@String)"; } }

        private readonly StringExpression text = new StringExpression(name: "String");

        public StringLengthFunction() => SetExpressions(text);

        public override IExpression Evaluate() =>
            new IntegerExpression(((string)text).Length);
    }
}
