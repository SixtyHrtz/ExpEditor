namespace ExpEditor.Core
{
    public class FloatExpression : Expression<float>
    {
        public override ExpressionType AllowedExpressionTypes =>
            ExpressionType.Constant
            | ExpressionType.Function
            | ExpressionType.Value;

        public override string BaseValue
        {
            get { return Value.ToString(); }
            set { Value = float.Parse(value); }
        }

        public FloatExpression(float value = 0, string name = "") : base(value, name) { }

        public static implicit operator FloatExpression(float value) =>
            new FloatExpression(value);

        public static implicit operator float(FloatExpression value) =>
            ((FloatExpression)value.Evaluate()).Value;
    }
}
