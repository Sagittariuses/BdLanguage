
namespace BdLanguage
{
    partial class Visit
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
            this.VisitLb = new System.Windows.Forms.Label();
            this.ClientLb = new System.Windows.Forms.Label();
            this.FullNameLb = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VisitLb
            // 
            this.VisitLb.AutoSize = true;
            this.VisitLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.VisitLb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.VisitLb.Location = new System.Drawing.Point(85, 19);
            this.VisitLb.Name = "VisitLb";
            this.VisitLb.Size = new System.Drawing.Size(111, 24);
            this.VisitLb.TabIndex = 1;
            this.VisitLb.Text = "Посещения";
            // 
            // ClientLb
            // 
            this.ClientLb.AutoSize = true;
            this.ClientLb.Location = new System.Drawing.Point(12, 58);
            this.ClientLb.Name = "ClientLb";
            this.ClientLb.Size = new System.Drawing.Size(46, 13);
            this.ClientLb.TabIndex = 2;
            this.ClientLb.Text = "Клиент:";
            // 
            // FullNameLb
            // 
            this.FullNameLb.AutoSize = true;
            this.FullNameLb.Location = new System.Drawing.Point(72, 58);
            this.FullNameLb.Name = "FullNameLb";
            this.FullNameLb.Size = new System.Drawing.Size(35, 13);
            this.FullNameLb.TabIndex = 3;
            this.FullNameLb.Text = "label3";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 81);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(277, 273);
            this.flowLayoutPanel.TabIndex = 4;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(89, 376);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(121, 23);
            this.CloseBtn.TabIndex = 17;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Visit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 421);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.FullNameLb);
            this.Controls.Add(this.ClientLb);
            this.Controls.Add(this.VisitLb);
            this.Name = "Visit";
            this.Text = "Посещения";
            this.Load += new System.EventHandler(this.Visit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label VisitLb;
        private System.Windows.Forms.Label ClientLb;
        private System.Windows.Forms.Label FullNameLb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button CloseBtn;
    }
}