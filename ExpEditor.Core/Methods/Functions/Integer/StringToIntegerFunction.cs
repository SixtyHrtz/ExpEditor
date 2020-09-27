namespace ExpEditor.Core
{
    public class StringToIntegerFunction : Function<IntegerExpression>
    {
        public override string Template { get { return "Integer(@String)"; } }

        private readonly StringExpression text = new StringExpression(name: "String");

        public StringToIntegerFunction() => SetExpressions(text);

        public override IExpression Evaluate()
        {
            int.TryParse(text, out int result);
            return new IntegerExpression(result);
        }
    }
}
