using System;

namespace ExpEditor.Core
{
    public class FunctionInfo<T> : IFunctionInfo where T : IFunction, new()
    {
        public string Name { get; }
        public Type Type { get; }
        public Type ReturnType { get; }

        public FunctionInfo(string name)
        {
            Name = name;
            Type = typeof(T);
            ReturnType = typeof(T).BaseType.GetGenericArguments()[0];
        }

        public IFunction GetFunction() => new T();

        public override string ToString() => Name;
    }
}
