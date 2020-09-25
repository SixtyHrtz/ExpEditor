using System;

namespace ExpEditor.Core
{
    public interface IConstantInfo
    {
        string Name { get; }
        Type Type { get; }
        Type ReturnType { get; }

        IConstant GetConstant();
    }
}
