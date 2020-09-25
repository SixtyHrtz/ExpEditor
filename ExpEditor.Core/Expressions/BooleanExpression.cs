namespace ExpEditor.Core
{
    public class BooleanExpression : Expression<bool>
    {
        public override ExpressionType AllowedExpressionTypes =>
            ExpressionType.Constant
            | ExpressionType.Function
            | ExpressionType.Value;

        public override string BaseValue
        {
            get { return Value.ToString(); }
            set { Value = bool.Parse(value); }
        }

        public BooleanExpression(bool value = false, string name = "") : base(value, name) { }

        public static implicit operator BooleanExpression(bool value) =>
            new BooleanExpression(value);

        public static implicit operator bool(BooleanExpression value) =>
            ((BooleanExpression)value.Evaluate()).Value;
    }
}
