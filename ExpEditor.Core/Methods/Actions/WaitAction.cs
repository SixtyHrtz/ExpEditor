using System.Threading.Tasks;

namespace ExpEditor.Core
{
    public class WaitAction : Action
    {
        public override string Template { get { return "Wait (@Value)"; } }

        private readonly FloatExpression value = new FloatExpression(name: "Value");

        public WaitAction() => SetExpressions(value);

        public override void Execute() =>
            Task.Delay((int)(value * 1000)).Wait();
    }
}
