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
            this.flpExpressions = new System.Windows.Forms.FlowLayoutPanel();
            this.bExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpExpressions
            // 
            this.flpExpressions.Location = new System.Drawing.Point(16, 15);
            this.flpExpressions.Margin = new System.Windows.Forms.Padding(4);
            this.flpExpressions.Name = "flpExpressions";
            this.flpExpressions.Size = new System.Drawing.Size(587, 281);
            this.flpExpressions.TabIndex = 0;
            // 
            // bExecute
            // 
            this.bExecute.Location = new System.Drawing.Point(503, 303);
            this.bExecute.Margin = new System.Windows.Forms.Padding(4);
            this.bExecute.Name = "bExecute";
            this.bExecute.Size = new System.Drawing.Size(100, 28);
            this.bExecute.TabIndex = 2;
            this.bExecute.Text = "Вывести";
            this.bExecute.UseVisualStyleBackColor = true;
            this.bExecute.Click += new System.EventHandler(this.ExecuteClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 346);
            this.Controls.Add(this.bExecute);
            this.Controls.Add(this.flpExpressions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpEditor";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpExpressions;
        private System.Windows.Forms.Button bExecute;
    }
}