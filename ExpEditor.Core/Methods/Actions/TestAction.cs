namespace ExpEditor.Core
{
    public class TestAction : Action
    {
        public override string Template { get { return "Test action (@Boolean, @Integer, @Float, @String)"; } }

        private readonly BooleanExpression boolean = new BooleanExpression(name: "Boolean");
        private readonly IntegerExpression integer = new IntegerExpression(name: "Integer");
        private readonly FloatExpression real = new FloatExpression(name: "Float");
        private readonly StringExpression text = new StringExpression(name: "String");

        public TestAction() => SetExpressions(boolean, integer, real, text);

        public override void Execute()
        {
            bool a = boolean;
            int b = integer;
            float c = real;
            string d = text;
        }
    }
}
