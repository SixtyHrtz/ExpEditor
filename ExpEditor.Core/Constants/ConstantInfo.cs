using System;

namespace ExpEditor.Core
{
    public class ConstantInfo<T> : IConstantInfo where T : IConstant, new()
    {
        public string Name { get; }
        public Type Type { get; }
        public Type ReturnType { get; }

        public ConstantInfo(string name)
        {
            Name = name;
            Type = typeof(T);
            ReturnType = typeof(T).BaseType.GetGenericArguments()[0];
        }

        public IConstant GetConstant() => new T();

        public override string ToString() => Name;
    }
}
