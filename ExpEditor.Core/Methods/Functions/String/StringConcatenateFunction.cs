namespace ExpEditor.Core
{
    public class StringConcatenateFunction : Function<StringExpression>
    {
        public override string Template { get { return "(@String1 + @String2)"; } }

        private readonly StringExpression text1 = new StringExpression("string1", "String1");
        private readonly StringExpression text2 = new StringExpression("string2", "String2");

        public StringConcatenateFunction() => SetExpressions(text1, text2);

        public override IExpression Evaluate() =>
            new StringExpression(text1 + text2);
    }
}
