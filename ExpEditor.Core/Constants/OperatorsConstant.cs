namespace ExpEditor.Core
{
    public class PlusConstant : Constant<OperatorExpression>
    {
        public override IExpression Expression => new StringExpression("+", "+");
    }

    public class MinusConstant : Constant<OperatorExpression>
    {
        public override IExpression Expression => new StringExpression("-", "-");
    }

    public class MultiplyConstant : Constant<OperatorExpression>
    {
        public override IExpression Expression => new StringExpression("*", "*");
    }

    public class DivideConstant : Constant<OperatorExpression>
    {
        public override IExpression Expression => new StringExpression("/", "/");
    }

    public class ModuloConstant : Constant<OperatorExpression>
    {
        public override IExpression Expression => new StringExpression("%", "%");
    }
}
