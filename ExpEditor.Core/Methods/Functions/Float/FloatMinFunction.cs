using System;

namespace ExpEditor.Core
{
    public class FloatMinFunction : Function<FloatExpression>
    {
        public override string Template { get { return "Min(@Value1, @Value2)"; } }

        private readonly FloatExpression value1 = new FloatExpression(name: "Value1");
        private readonly FloatExpression value2 = new FloatExpression(name: "Value2");

        public FloatMinFunction() => SetExpressions(value1, value2);

        public override IExpression Evaluate() =>
            new FloatExpression(Math.Min(value1, value2));
    }
}
