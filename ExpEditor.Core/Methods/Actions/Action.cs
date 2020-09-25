namespace ExpEditor.Core
{
    public abstract class Action : Method, IAction
    {
        public abstract void Execute();
    }
}
