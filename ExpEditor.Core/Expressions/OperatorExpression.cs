using System;

namespace ExpEditor.Core
{
    public class OperatorExpression : Expression<OperatorExpressionType>
    {
        public override ExpressionType AllowedExpressionTypes =>
            ExpressionType.Constant;

        public override string BaseValue
        {
            get { return Value.ToString(); }
            set { Value = (OperatorExpressionType)Enum.Parse(typeof(OperatorExpressionType), value); }
        }

        public OperatorExpression(OperatorExpressionType value = OperatorExpressionType.Plus, string name = "") : base(value, name)
        {
            switch (value)
            {
                case OperatorExpressionType.Plus: Constant = new PlusConstant(); break;
                case OperatorExpressionType.Minus: Constant = new MinusConstant(); break;
                case OperatorExpressionType.Multiply: Constant = new MultiplyConstant(); break;
                case OperatorExpressionType.Divide: Constant = new DivideConstant(); break;
                case OperatorExpressionType.Modular: Constant = new ModularConstant(); break;
            }
        }
    }
}
