using System;

namespace ExpEditor.Core
{
    public class IntegerMinFunction : Function<IntegerExpression>
    {
        public override string Template { get { return "Min(@Value1, @Value2)"; } }

        private readonly IntegerExpression value1 = new IntegerExpression(name: "Value1");
        private readonly IntegerExpression value2 = new IntegerExpression(name: "Value2");

        public IntegerMinFunction() => SetExpressions(value1, value2);

        public override IExpression Evaluate() =>
            new IntegerExpression(Math.Min(value1, value2));
    }
}
