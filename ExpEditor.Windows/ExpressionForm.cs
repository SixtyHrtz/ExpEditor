using ExpEditor.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExpEditor.Windows
{
    // TODO : Сброс функции или значения в зависимости от типа при выходе
    // TODO : Фокус на значении по умолчании
    // TODO : Убрать костыль с подгрузкой функций и констант
    // TODO : Boolean как константа
    // TODO : Проверка на некорректно введённые значения
    // TODO : Проверка на выбор пустых контролов

    public partial class ExpressionForm : Form
    {
        private readonly IExpression expression;
        private IConstant constant;
        private IFunction function;

        private readonly List<LinkLabel> functionLinksList;

        public ExpressionForm(IExpression expression)
        {
            InitializeComponent();

            functionLinksList = new List<LinkLabel>();
            this.expression = expression;

            ShowAllowedControls();
            SetExpressionType();
            FillComboBoxItems();
            SetExpressionValues();
        }

        private void ShowAllowedControls()
        {
            if (!expression.AllowedExpressionTypes.HasFlag(ExpressionType.Constant))
            {
                cbConstant.Visible = false;
                rbConstant.Visible = false;
            }
            if (!expression.AllowedExpressionTypes.HasFlag(ExpressionType.Function))
            {
                cbFunction.Visible = false;
                rbFunction.Visible = false;
                lFunction.Visible = false;
                flpFunction.Visible = false;
            }
            if (!expression.AllowedExpressionTypes.HasFlag(ExpressionType.Value))
            {
                rbValue.Visible = false;
                tbValue.Visible = false;
            }
        }

        private void SetExpressionType()
        {
            switch (expression.ExpressionType)
            {
                case ExpressionType.Constant: rbConstant.Checked = true; break;
                case ExpressionType.Function: rbFunction.Checked = true; break;
                case ExpressionType.Value: rbValue.Checked = true; break;
            }
        }

        private void FillComboBoxItems()
        {
            if (expression.AllowedExpressionTypes.HasFlag(ExpressionType.Constant))
            {
                var matchedConstants = ConstantsList.Constants
                    .Where(x => x.ReturnType == expression.GetType())
                    .ToArray();

                cbConstant.Items.AddRange(matchedConstants);
                if (cbConstant.Items.Count != 0)
                    cbConstant.SelectedIndex = 0;
            }

            if (expression.AllowedExpressionTypes.HasFlag(ExpressionType.Function))
            {
                var matchedFunctions = FunctionsList.Functions
                    .Where(x => x.ReturnType == expression.GetType())
                    .ToArray();

                cbFunction.Items.AddRange(matchedFunctions);
                if (cbFunction.Items.Count != 0)
                    cbFunction.SelectedIndex = 0;
            }
        }

        private void SetExpressionValues()
        {
            switch (expression.ExpressionType)
            {
                case ExpressionType.Constant:
                    constant = expression.Constant;
                    cbConstant.SelectedItem = ConstantsList.Constants
                        .First(x => x.Type == constant.GetType());
                    constant = expression.Constant;
                    break;
                case ExpressionType.Function:
                    function = expression.Function;
                    cbFunction.SelectedItem = FunctionsList.Functions
                        .First(x => x.Type == function.GetType());
                    function = expression.Function;
                    CreateFunctionControls();
                    break;
                case ExpressionType.Value:
                    tbValue.Text = expression.BaseValue;
                    break;
            }
        }

        private void CreateFunctionControls()
        {
            foreach (var link in functionLinksList)
                link.Dispose();
            functionLinksList.Clear();

            foreach (var expression in function.Expressions)
            {
                var link = new LinkLabel()
                {
                    Parent = flpFunction,
                    Tag = expression
                };

                link.Click += (se, ea) =>
                {
                    using (var form = new ExpressionForm(expression))
                    {
                        form.ShowDialog();
                        form.Close();
                    }

                    UpdateFunctionInfo();
                };

                functionLinksList.Add(link);
            }

            UpdateFunctionInfo();
        }

        private void UpdateFunctionInfo()
        {
            foreach (var link in functionLinksList)
            {
                link.Text = ((IExpression)link.Tag).ToString();
                link.Width = link.Text.GetTextWidth();
            }

            lFunction.Text = function.Inspect();
            rbFunction.Checked = true;
        }

        private void ConstantSelectedIndexChanged(object sender, EventArgs e)
        {
            constant = ((IConstantInfo)cbConstant.SelectedItem).GetConstant();
            rbConstant.Checked = true;
        }

        private void FunctionSelectedIndexChanged(object sender, EventArgs e)
        {
            function = ((IFunctionInfo)cbFunction.SelectedItem).GetFunction();
            CreateFunctionControls();
        }

        private void ValueTextChanged(object sender, EventArgs e) => rbValue.Checked = true;

        private void SaveClick(object sender, EventArgs e)
        {
            if (rbConstant.Checked)
            {
                expression.Constant = constant;
                expression.ExpressionType = ExpressionType.Constant;
            }
            else if (rbFunction.Checked)
            {
                expression.Function = function;
                expression.ExpressionType = ExpressionType.Function;
            }
            else if (rbValue.Checked)
            {
                expression.BaseValue = tbValue.Text;
                expression.ExpressionType = ExpressionType.Value;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
