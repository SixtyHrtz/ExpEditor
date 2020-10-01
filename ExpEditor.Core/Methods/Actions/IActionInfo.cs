using System;

namespace ExpEditor.Core
{
    public interface IActionInfo
    {
        string Name { get; }
        Type Type { get; }

        IAction GetAction();
    }
}
