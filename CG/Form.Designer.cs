namespace CG
{
    partial class Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.score_p2 = new System.Windows.Forms.Label();
            this.score_p1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "P1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(698, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "P2:";
            // 
            // score_p2
            // 
            this.score_p2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.score_p2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.score_p2.BackColor = System.Drawing.Color.Black;
            this.score_p2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_p2.ForeColor = System.Drawing.SystemColors.Control;
            this.score_p2.Location = new System.Drawing.Point(737, 9);
            this.score_p2.Name = "score_p2";
            this.score_p2.Size = new System.Drawing.Size(51, 34);
            this.score_p2.TabIndex = 3;
            this.score_p2.Text = "0";
            this.score_p2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.score_p2.Click += new System.EventHandler(this.label4_Click);
            // 
            // score_p1
            // 
            this.score_p1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.score_p1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.score_p1.BackColor = System.Drawing.Color.Black;
            this.score_p1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_p1.ForeColor = System.Drawing.SystemColors.Control;
            this.score_p1.Location = new System.Drawing.Point(82, 9);
            this.score_p1.Name = "score_p1";
            this.score_p1.Size = new System.Drawing.Size(51, 34);
            this.score_p1.TabIndex = 4;
            this.score_p1.Text = "0";
            this.score_p1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.score_p1);
            this.Controls.Add(this.score_p2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label score_p2;
        public System.Windows.Forms.Label score_p1;
    }
}

