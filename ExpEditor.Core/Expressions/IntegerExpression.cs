namespace ExpEditor.Core
{
    public class IntegerExpression : Expression<int>
    {
        public override ExpressionType AllowedExpressionTypes =>
            ExpressionType.Constant
            | ExpressionType.Function
            | ExpressionType.Value;

        public override string BaseValue
        {
            get { return Value.ToString(); }
            set { Value = int.Parse(value); }
        }

        public IntegerExpression(int value = 0, string name = "") : base(value, name) { }

        public static implicit operator IntegerExpression(int value) =>
            new IntegerExpression(value);

        public static implicit operator int(IntegerExpression value) =>
            ((IntegerExpression)value.Evaluate()).Value;
    }
}
