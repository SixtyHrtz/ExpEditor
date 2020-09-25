namespace ExpEditor.Core
{
    public class IntegerToStringFunction : Function<StringExpression>
    {
        public override string Template { get { return "String (@Value)"; } }

        private readonly IntegerExpression value = new IntegerExpression(name: "Value");

        public IntegerToStringFunction() => SetExpressions(value);

        public override IExpression Evaluate() => new StringExpression(value.ToString());
    }
}
