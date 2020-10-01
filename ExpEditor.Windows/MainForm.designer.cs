namespace ExpEditor.Windows
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.bExecute = new System.Windows.Forms.Button();
            this.tvTrigger = new System.Windows.Forms.TreeView();
            this.cmsActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNewAction = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // bExecute
            // 
            this.bExecute.Location = new System.Drawing.Point(506, 305);
            this.bExecute.Margin = new System.Windows.Forms.Padding(4);
            this.bExecute.Name = "bExecute";
            this.bExecute.Size = new System.Drawing.Size(100, 28);
            this.bExecute.TabIndex = 2;
            this.bExecute.Text = "Execute";
            this.bExecute.UseVisualStyleBackColor = true;
            this.bExecute.Click += new System.EventHandler(this.ExecuteClick);
            // 
            // tvTrigger
            // 
            this.tvTrigger.ContextMenuStrip = this.cmsActions;
            this.tvTrigger.Location = new System.Drawing.Point(12, 12);
            this.tvTrigger.Name = "tvTrigger";
            this.tvTrigger.Size = new System.Drawing.Size(595, 286);
            this.tvTrigger.TabIndex = 3;
            this.tvTrigger.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TriggerNodeMouseDoubleClick);
            // 
            // cmsActions
            // 
            this.cmsActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewAction});
            this.cmsActions.Name = "cmsActions";
            this.cmsActions.Size = new System.Drawing.Size(156, 28);
            // 
            // tsmiNewAction
            // 
            this.tsmiNewAction.Name = "tsmiNewAction";
            this.tsmiNewAction.Size = new System.Drawing.Size(155, 24);
            this.tsmiNewAction.Text = "New Action";
            this.tsmiNewAction.Click += new System.EventHandler(this.NewActionClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 346);
            this.Controls.Add(this.tvTrigger);
            this.Controls.Add(this.bExecute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpEditor";
            this.cmsActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bExecute;
        private System.Windows.Forms.TreeView tvTrigger;
        private System.Windows.Forms.ContextMenuStrip cmsActions;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewAction;
    }
}