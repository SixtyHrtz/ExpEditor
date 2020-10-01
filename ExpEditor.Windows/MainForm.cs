using ExpEditor.Core;
using ExpEditor.Core.WinForms;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpEditor.Windows
{
    public partial class MainForm : Form
    {
        private IAction action;

        private readonly List<LinkLabel> actionLinksList;

        public MainForm()
        {
            InitializeComponent();

            actionLinksList = new List<LinkLabel>();
        }

        private void MainFormLoad(object sender, System.EventArgs e)
        {
            action = new DisplayMessageAction();

            foreach (IExpression expression in action.Expressions)
            {
                var link = new LinkLabel()
                {
                    Parent = flpExpressions,
                    Tag = expression
                };

                link.Click += (se, ea) =>
                {
                    ExpressionForm.ShowSubForm(expression);
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
        }

        private async void ExecuteClick(object sender, System.EventArgs e)
        {
            await Task.Run(() =>
            {
                action.Execute();
            });
        }
    }
}
