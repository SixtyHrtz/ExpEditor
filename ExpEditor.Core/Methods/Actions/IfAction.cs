using System.Collections.Generic;

namespace ExpEditor.Core
{
    public class IfAction : Action
    {
        public override string Template { get { return "If (All Conditions are True) then do (Then Actions) else do (Else Actions)"; } }

        private readonly List<BooleanExpression> conditions;
        private readonly List<IAction> thenActions;
        private readonly List<IAction> elseActions;

        public IfAction()
        {
            conditions = new List<BooleanExpression>();
            thenActions = new List<IAction>();
            elseActions = new List<IAction>();
        }

        public override void Execute()
        {
            if (!conditions.Contains(false))
            {
                foreach (var action in thenActions)
                    action.Execute();
            }
            else
            {
                foreach (var action in elseActions)
                    action.Execute();
            }
        }
    }
}
