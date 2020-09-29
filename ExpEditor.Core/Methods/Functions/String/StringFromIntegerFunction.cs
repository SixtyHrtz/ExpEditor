namespace ExpEditor.Core
{
    public class StringFromIntegerFunction : Function<StringExpression>
    {
        public override string Template { get { return "String(@Value)"; } }

        private readonly IntegerExpression value = new IntegerExpression(name: "Value");

        public StringFromIntegerFunction() => SetExpressions(value);

        public override IExpression Evaluate() => new StringExpression(value.ToString());
    }
}
