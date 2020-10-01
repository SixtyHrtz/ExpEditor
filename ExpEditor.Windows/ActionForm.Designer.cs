namespace ExpEditor.Windows
{
    partial class ActionForm
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
            this.flpExpressions = new System.Windows.Forms.FlowLayoutPanel();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.bSave = new System.Windows.Forms.Button();
            this.lAction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpExpressions
            // 
            this.flpExpressions.Location = new System.Drawing.Point(13, 62);
            this.flpExpressions.Margin = new System.Windows.Forms.Padding(4);
            this.flpExpressions.Name = "flpExpressions";
            this.flpExpressions.Size = new System.Drawing.Size(593, 235);
            this.flpExpressions.TabIndex = 1;
            // 
            // cbAction
            // 
            this.cbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Location = new System.Drawing.Point(13, 13);
            this.cbAction.Margin = new System.Windows.Forms.Padding(4);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(593, 24);
            this.cbAction.TabIndex = 3;
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.ActionSelectedIndexChanged);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(506, 305);
            this.bSave.Margin = new System.Windows.Forms.Padding(4);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(100, 28);
            this.bSave.TabIndex = 8;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // lAction
            // 
            this.lAction.AutoSize = true;
            this.lAction.Location = new System.Drawing.Point(12, 41);
            this.lAction.Name = "lAction";
            this.lAction.Size = new System.Drawing.Size(50, 17);
            this.lAction.TabIndex = 9;
            this.lAction.Text = "lAction";
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 346);
            this.Controls.Add(this.lAction);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.flpExpressions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ActionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpExpressions;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lAction;
    }
}