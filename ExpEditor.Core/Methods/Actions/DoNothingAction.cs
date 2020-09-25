namespace ExpEditor.Core
{
    public class DoNothingAction : Action
    {
        public override string Template { get { return "Do nothing"; } }

        public override void Execute()
        {
            // Nothing to do
        }
    }
}
