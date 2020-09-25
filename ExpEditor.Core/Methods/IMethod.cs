using System.Collections.Generic;

namespace ExpEditor.Core
{
    public interface IMethod
    {
        string Template { get; }
        List<IExpression> Expressions { get; }

        string Inspect();
    }
}
