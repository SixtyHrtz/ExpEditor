using ExpEditor.Core;
using ExpEditor.Core.WinForms;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpEditor.Windows
{
    public partial class MainForm : Form
    {
        private readonly Trigger testTrigger;

        private readonly TreeNode triggerNode;

        public MainForm()
        {
            InitializeComponent();

            ActionsList.Add(new ActionInfo<DisplayMessageAction>("Display Message"));

            testTrigger = new Trigger
            {
                Name = "Test Trigger"
            };

            triggerNode = tvTrigger.Nodes.Add(testTrigger.ToString());
        }

        private void NewActionClick(object sender, System.EventArgs e) =>
            EditActionNode(-1);

        private void TriggerNodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) =>
            EditActionNode(e.Node.Index);

        private void EditActionNode(int nodeIndex)
        {
            IAction action = null;

            if (nodeIndex != -1)
                action = (IAction)triggerNode.Nodes[nodeIndex]?.Tag;

            using (var form = new ActionForm(action))
            {
                form.ShowDialog();
                form.Close();

                if (form.DialogResult != DialogResult.OK)
                    return;

                if (nodeIndex == -1)
                    AddNode(form.Action);
                else
                    UpdateNode(form.Action, nodeIndex);
            }
        }

        private void AddNode(IAction action)
        {
            var newIndex = tvTrigger.SelectedNode.Index + 1;

            if (newIndex < testTrigger.Actions.Count)
                testTrigger.Actions.Insert(newIndex, action);
            else
                testTrigger.Actions.Add(action);

            var actionNode = new TreeNode(action.ToString()) { Tag = action };
            triggerNode.Nodes.Insert(newIndex, actionNode);
        }

        private void UpdateNode(IAction action, int nodeIndex)
        {
            testTrigger.Actions[nodeIndex] = action;

            var actionNode = new TreeNode(action.ToString()) { Tag = action };
            triggerNode.Nodes.RemoveAt(nodeIndex);
            triggerNode.Nodes.Insert(nodeIndex, actionNode);
        }

        private async void ExecuteClick(object sender, System.EventArgs e)
        {
            await Task.Run(() =>
            {
                foreach (var action in testTrigger.Actions)
                    action.Execute();
            });
        }
    }
}
