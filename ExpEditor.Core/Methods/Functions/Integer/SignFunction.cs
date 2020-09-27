using System;

namespace ExpEditor.Core
{
    public class SignFunction : Function<IntegerExpression>
    {
        public override string Template { get { return "Sign(@Value)"; } }

        private readonly IntegerExpression value = new IntegerExpression(name: "Value");

        public SignFunction() => SetExpressions(value);

        public override IExpression Evaluate() =>
            new IntegerExpression(Math.Sign(value));
    }
}
