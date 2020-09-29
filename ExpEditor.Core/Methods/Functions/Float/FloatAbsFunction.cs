using System;

namespace ExpEditor.Core
{
    public class FloatAbsFunction : Function<FloatExpression>
    {
        public override string Template { get { return "Abs(@Value)"; } }

        private readonly FloatExpression value = new FloatExpression(name: "Value");

        public FloatAbsFunction() => SetExpressions(value);

        public override IExpression Evaluate() =>
            new FloatExpression(Math.Abs(value));
    }
}
