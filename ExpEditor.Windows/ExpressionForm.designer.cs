namespace ExpEditor.Windows
{
    partial class ExpressionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbConstant = new System.Windows.Forms.ComboBox();
            this.rbConstant = new System.Windows.Forms.RadioButton();
            this.cbFunction = new System.Windows.Forms.ComboBox();
            this.rbFunction = new System.Windows.Forms.RadioButton();
            this.lFunction = new System.Windows.Forms.Label();
            this.flpFunction = new System.Windows.Forms.FlowLayoutPanel();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.rbValue = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cbConstant
            // 
            this.cbConstant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConstant.FormattingEnabled = true;
            this.cbConstant.Location = new System.Drawing.Point(128, 15);
            this.cbConstant.Margin = new System.Windows.Forms.Padding(4);
            this.cbConstant.Name = "cbConstant";
            this.cbConstant.Size = new System.Drawing.Size(473, 24);
            this.cbConstant.TabIndex = 0;
            this.cbConstant.SelectedIndexChanged += new System.EventHandler(this.ConstantSelectedIndexChanged);
            // 
            // rbConstant
            // 
            this.rbConstant.AutoSize = true;
            this.rbConstant.Location = new System.Drawing.Point(16, 16);
            this.rbConstant.Margin = new System.Windows.Forms.Padding(4);
            this.rbConstant.Name = "rbConstant";
            this.rbConstant.Size = new System.Drawing.Size(85, 21);
            this.rbConstant.TabIndex = 1;
            this.rbConstant.Text = "Constant";
            this.rbConstant.UseVisualStyleBackColor = true;
            // 
            // cbFunction
            // 
            this.cbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFunction.FormattingEnabled = true;
            this.cbFunction.Location = new System.Drawing.Point(128, 48);
            this.cbFunction.Margin = new System.Windows.Forms.Padding(4);
            this.cbFunction.Name = "cbFunction";
            this.cbFunction.Size = new System.Drawing.Size(473, 24);
            this.cbFunction.TabIndex = 2;
            this.cbFunction.SelectedIndexChanged += new System.EventHandler(this.FunctionSelectedIndexChanged);
            // 
            // rbFunction
            // 
            this.rbFunction.AutoSize = true;
            this.rbFunction.Location = new System.Drawing.Point(16, 49);
            this.rbFunction.Margin = new System.Windows.Forms.Padding(4);
            this.rbFunction.Name = "rbFunction";
            this.rbFunction.Size = new System.Drawing.Size(83, 21);
            this.rbFunction.TabIndex = 3;
            this.rbFunction.Text = "Function";
            this.rbFunction.UseVisualStyleBackColor = true;
            // 
            // lFunction
            // 
            this.lFunction.AutoSize = true;
            this.lFunction.Location = new System.Drawing.Point(125, 76);
            this.lFunction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFunction.Name = "lFunction";
            this.lFunction.Size = new System.Drawing.Size(65, 17);
            this.lFunction.TabIndex = 4;
            this.lFunction.Text = "lFunction";
            // 
            // flpFunction
            // 
            this.flpFunction.Location = new System.Drawing.Point(128, 97);
            this.flpFunction.Margin = new System.Windows.Forms.Padding(4);
            this.flpFunction.Name = "flpFunction";
            this.flpFunction.Size = new System.Drawing.Size(475, 198);
            this.flpFunction.TabIndex = 5;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(128, 305);
            this.tbValue.Margin = new System.Windows.Forms.Padding(4);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(365, 22);
            this.tbValue.TabIndex = 6;
            this.tbValue.TextChanged += new System.EventHandler(this.ValueTextChanged);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(503, 303);
            this.bSave.Margin = new System.Windows.Forms.Padding(4);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(100, 28);
            this.bSave.TabIndex = 7;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // rbValue
            // 
            this.rbValue.AutoSize = true;
            this.rbValue.Checked = true;
            this.rbValue.Location = new System.Drawing.Point(16, 306);
            this.rbValue.Margin = new System.Windows.Forms.Padding(4);
            this.rbValue.Name = "rbValue";
            this.rbValue.Size = new System.Drawing.Size(65, 21);
            this.rbValue.TabIndex = 8;
            this.rbValue.TabStop = true;
            this.rbValue.Text = "Value";
            this.rbValue.UseVisualStyleBackColor = true;
            // 
            // ExpressionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 346);
            this.Controls.Add(this.rbValue);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.flpFunction);
            this.Controls.Add(this.lFunction);
            this.Controls.Add(this.rbFunction);
            this.Controls.Add(this.cbFunction);
            this.Controls.Add(this.rbConstant);
            this.Controls.Add(this.cbConstant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ExpressionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbConstant;
        private System.Windows.Forms.RadioButton rbConstant;
        private System.Windows.Forms.ComboBox cbFunction;
        private System.Windows.Forms.RadioButton rbFunction;
        private System.Windows.Forms.Label lFunction;
        private System.Windows.Forms.FlowLayoutPanel flpFunction;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.RadioButton rbValue;
    }
}