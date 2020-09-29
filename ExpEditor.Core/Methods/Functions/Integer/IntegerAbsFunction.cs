using System;

namespace ExpEditor.Core
{
    public class IntegerAbsFunction : Function<IntegerExpression>
    {
        public override string Template { get { return "Abs(@Value)"; } }

        private readonly IntegerExpression value = new IntegerExpression(name: "Value");

        public IntegerAbsFunction() => SetExpressions(value);

        public override IExpression Evaluate() =>
            new IntegerExpression(Math.Abs(value));
    }
}
