using System;

namespace ExpEditor.Core
{
    public interface IFunctionInfo
    {
        string Name { get; }
        Type Type { get; }
        Type ReturnType { get; }

        IFunction GetFunction();
    }
}
