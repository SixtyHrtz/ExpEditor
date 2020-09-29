using System;

namespace ExpEditor.Core
{
    public class FloatMaxFunction : Function<FloatExpression>
    {
        public override string Template { get { return "Max(@Value1, @Value2)"; } }

        private readonly FloatExpression value1 = new FloatExpression(name: "Value1");
        private readonly FloatExpression value2 = new FloatExpression(name: "Value2");

        public FloatMaxFunction() => SetExpressions(value1, value2);

        public override IExpression Evaluate() =>
            new FloatExpression(Math.Max(value1, value2));
    }
}
