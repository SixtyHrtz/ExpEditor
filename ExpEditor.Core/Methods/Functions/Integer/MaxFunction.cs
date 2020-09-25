using System;

namespace ExpEditor.Core
{
    public class MaxFunction : Function<IntegerExpression>
    {
        public override string Template { get { return "Max (@Value1, @Value2)"; } }

        private readonly IntegerExpression value1 = new IntegerExpression(name: "Value1");
        private readonly IntegerExpression value2 = new IntegerExpression(name: "Value2");

        public MaxFunction() => SetExpressions(value1, value2);

        public override IExpression Evaluate() =>
            new IntegerExpression(Math.Max(value1, value2));
    }
}
