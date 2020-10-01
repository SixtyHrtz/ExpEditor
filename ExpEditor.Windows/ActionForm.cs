using ExpEditor.Core;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExpEditor.Windows
{
    public partial class ActionForm : Form
    {
        private readonly List<LinkLabel> actionLinksList;

        public IAction Action { get; private set; }

        public ActionForm(IAction action)
        {
            InitializeComponent();

            actionLinksList = new List<LinkLabel>();
            Action = action;

            FillComboBoxItems();

            if (action == null)
                return;

            SetActionValue();
        }

        private void FillComboBoxItems()
        {
            var actions = ActionsList.Actions.ToArray();

            cbAction.Items.AddRange(actions);
            if (cbAction.Items.Count != 0)
                cbAction.SelectedIndex = 0;
        }

        private void SetActionValue()
        {
            cbAction.SelectedItem = ActionsList.Actions
                .First(x => x.Type == Action.GetType());
            CreateActionControls();
        }

        private void CreateActionControls()
        {
            foreach (var link in actionLinksList)
                link.Dispose();
            actionLinksList.Clear();

            foreach (var expression in Action.Expressions)
            {
                var link = new LinkLabel()
                {
                    Parent = flpExpressions,
                    Tag = expression
                };

                link.Click += (se, ea) =>
                {
                    using (var form = new ExpressionForm(expression))
                    {
                        form.ShowDialog();
                        form.Close();
                    }

                    UpdateActionInfo();
                };

                actionLinksList.Add(link);
            }

            UpdateActionInfo();
        }

        private void UpdateActionInfo()
        {
            foreach (var link in actionLinksList)
            {
                link.Text = ((IExpression)link.Tag).ToString();
                link.Width = link.Text.GetTextWidth();
            }

            lAction.Text = Action.Inspect();
        }

        private void ActionSelectedIndexChanged(object sender, System.EventArgs e)
        {
            Action = ((IActionInfo)cbAction.SelectedItem).GetAction();
            CreateActionControls();
        }

        private void SaveClick(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
