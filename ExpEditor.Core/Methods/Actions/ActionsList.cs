using System.Collections.Generic;
using System.Linq;

namespace ExpEditor.Core
{
    public static class ActionsList
    {
        public static List<IActionInfo> Actions;

        static ActionsList()
        {
            Actions = new List<IActionInfo>()
            {
                new ActionInfo<DoNothingAction>("Do Nothing"),
                //new ActionInfo<IfAction>("If"),
                new ActionInfo<TestAction>("Test"),
                new ActionInfo<WaitAction>("Wait")
            };

            Sort();
        }

        public static void Add(IActionInfo actionInfo)
        {
            Actions.Add(actionInfo);
            Sort();
        }

        private static void Sort()
        {
            Actions = Actions
                .OrderBy(x => x.Name)
                .ToList();
        }
    }
}
