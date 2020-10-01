using ExpEditor.Core;

namespace ExpEditor.WinForms
{
    public class ButtonCreateAction : Action
    {
        public override string Template { get { return "CreateButton()"; } }

        public ButtonCreateAction() { }

        public override void Execute() { }
    }
}
