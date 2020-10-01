using System.Windows.Forms;

namespace ExpEditor.Core.WinForms
{
    public class DisplayMessageAction : Action
    {
        public override string Template { get { return "DisplayMessage(@String)"; } }

        private readonly StringExpression text = new StringExpression(name: "String");

        public DisplayMessageAction() => SetExpressions(text);

        public override void Execute() => MessageBox.Show(text);
    }
}
