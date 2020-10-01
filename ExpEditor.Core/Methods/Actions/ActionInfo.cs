using System;

namespace ExpEditor.Core
{
    public class ActionInfo<T> : IActionInfo where T : IAction, new()
    {
        public string Name { get; }
        public Type Type { get; }

        public ActionInfo(string name)
        {
            Name = name;
            Type = typeof(T);
        }

        public IAction GetAction() => new T();

        public override string ToString() => Name;
    }
}
