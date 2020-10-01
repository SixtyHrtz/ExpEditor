using System.Collections.Generic;

namespace ExpEditor.Core
{
    public class Trigger
    {
        public string Name { get; set; }

        public List<IAction> Actions { get; set; }

        public Trigger() => Actions = new List<IAction>();

        public override string ToString() => Name;
    }
}
