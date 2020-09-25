using System.Collections.Generic;

namespace ExpEditor.Core
{
    public abstract class Method : IMethod
    {
        public abstract string Template { get; }
        public virtual List<IExpression> Expressions { get; }

        public Method() => Expressions = new List<IExpression>();

        protected void SetExpressions(params IExpression[] expressions)
        {
            Expressions.Clear();
            Expressions.AddRange(expressions);
        }

        public string Inspect()
        {
            var output = Template;
            foreach (var expression in Expressions)
                output = output.Replace("@" + expression.Name, expression.ToString());

            return output;
        }

        public override string ToString() => Inspect();
    }
}
