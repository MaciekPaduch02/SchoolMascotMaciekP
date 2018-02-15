namespace SchoolMascotMaciekP
{
    partial class frmMathFormulae
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadraticFormulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pythagoreanTheoremToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosineLawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniformMotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFormula = new System.Windows.Forms.Label();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formulasToolStripMenuItem
            // 
            this.formulasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quadraticFormulaToolStripMenuItem,
            this.pythagoreanTheoremToolStripMenuItem,
            this.cosineLawToolStripMenuItem,
            this.uniformMotionToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.formulasToolStripMenuItem.Name = "formulasToolStripMenuItem";
            this.formulasToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.formulasToolStripMenuItem.Text = "Formulas";
            // 
            // quadraticFormulaToolStripMenuItem
            // 
            this.quadraticFormulaToolStripMenuItem.Name = "quadraticFormulaToolStripMenuItem";
            this.quadraticFormulaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.quadraticFormulaToolStripMenuItem.Text = "Quadratic formula";
            this.quadraticFormulaToolStripMenuItem.Click += new System.EventHandler(this.quadraticFormulaToolStripMenuItem_Click);
            // 
            // pythagoreanTheoremToolStripMenuItem
            // 
            this.pythagoreanTheoremToolStripMenuItem.Name = "pythagoreanTheoremToolStripMenuItem";
            this.pythagoreanTheoremToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.pythagoreanTheoremToolStripMenuItem.Text = "Pythagorean Theorem";
            this.pythagoreanTheoremToolStripMenuItem.Click += new System.EventHandler(this.pythagoreanTheoremToolStripMenuItem_Click);
            // 
            // cosineLawToolStripMenuItem
            // 
            this.cosineLawToolStripMenuItem.Name = "cosineLawToolStripMenuItem";
            this.cosineLawToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.cosineLawToolStripMenuItem.Text = "Cosine Law";
            this.cosineLawToolStripMenuItem.Click += new System.EventHandler(this.cosineLawToolStripMenuItem_Click);
            // 
            // uniformMotionToolStripMenuItem
            // 
            this.uniformMotionToolStripMenuItem.Name = "uniformMotionToolStripMenuItem";
            this.uniformMotionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.uniformMotionToolStripMenuItem.Text = "Uniform Motion";
            this.uniformMotionToolStripMenuItem.Click += new System.EventHandler(this.uniformMotionToolStripMenuItem_Click);
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula.Location = new System.Drawing.Point(250, 170);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(106, 31);
            this.lblFormula.TabIndex = 1;
            this.lblFormula.Text = "Formula";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // frmMathFormulae
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 378);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMathFormulae";
            this.Text = "Math Formulae";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadraticFormulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pythagoreanTheoremToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosineLawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uniformMotionToolStripMenuItem;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

