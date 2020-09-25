namespace ExpEditor.Core
{
    public class StringExpression : Expression<string>
    {
        public override ExpressionType AllowedExpressionTypes =>
            ExpressionType.Constant
            | ExpressionType.Function
            | ExpressionType.Value;

        public override string BaseValue
        {
            get { return Value; }
            set { Value = value; }
        }

        public StringExpression(string value = "text", string name = "") : base(value, name) { }

        public static implicit operator StringExpression(string value) =>
            new StringExpression(value);

        public static implicit operator string(StringExpression value) =>
            ((StringExpression)value.Evaluate()).Value;
    }
}
