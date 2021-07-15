
namespace Collections
{
    partial class Form1
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
            this.testButton = new System.Windows.Forms.Button();
            this.colletionsTestButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.linqOnArraysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByOnStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersOnStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lInqOnListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaCelorDeAnul2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(249, 413);
            this.testButton.Margin = new System.Windows.Forms.Padding(2);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(88, 45);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // colletionsTestButton
            // 
            this.colletionsTestButton.Location = new System.Drawing.Point(370, 413);
            this.colletionsTestButton.Margin = new System.Windows.Forms.Padding(2);
            this.colletionsTestButton.Name = "colletionsTestButton";
            this.colletionsTestButton.Size = new System.Drawing.Size(75, 45);
            this.colletionsTestButton.TabIndex = 1;
            this.colletionsTestButton.Text = "Collections";
            this.colletionsTestButton.UseVisualStyleBackColor = true;
            this.colletionsTestButton.Click += new System.EventHandler(this.colletionsTestButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linqOnArraysToolStripMenuItem,
            this.lInqOnListsToolStripMenuItem,
            this.agregatesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // linqOnArraysToolStripMenuItem
            // 
            this.linqOnArraysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderByToolStripMenuItem,
            this.orderByOnStudentsToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.filtersOnStudentsToolStripMenuItem});
            this.linqOnArraysToolStripMenuItem.Name = "linqOnArraysToolStripMenuItem";
            this.linqOnArraysToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.linqOnArraysToolStripMenuItem.Text = "Linq on arrays";
            // 
            // orderByToolStripMenuItem
            // 
            this.orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
            this.orderByToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.orderByToolStripMenuItem.Text = "OrderBy";
            this.orderByToolStripMenuItem.Click += new System.EventHandler(this.orderByToolStripMenuItem_Click);
            // 
            // orderByOnStudentsToolStripMenuItem
            // 
            this.orderByOnStudentsToolStripMenuItem.Name = "orderByOnStudentsToolStripMenuItem";
            this.orderByOnStudentsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.orderByOnStudentsToolStripMenuItem.Text = "OrderBy on Students";
            this.orderByOnStudentsToolStripMenuItem.Click += new System.EventHandler(this.orderByOnStudentsToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.filtersToolStripMenuItem.Text = "Filters on int array";
            this.filtersToolStripMenuItem.Click += new System.EventHandler(this.filtersToolStripMenuItem_Click);
            // 
            // filtersOnStudentsToolStripMenuItem
            // 
            this.filtersOnStudentsToolStripMenuItem.Name = "filtersOnStudentsToolStripMenuItem";
            this.filtersOnStudentsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.filtersOnStudentsToolStripMenuItem.Text = "Filters on students";
            this.filtersOnStudentsToolStripMenuItem.Click += new System.EventHandler(this.filtersOnStudentsToolStripMenuItem_Click);
            // 
            // lInqOnListsToolStripMenuItem
            // 
            this.lInqOnListsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ex1ToolStripMenuItem,
            this.ex2ToolStripMenuItem,
            this.ex3ToolStripMenuItem});
            this.lInqOnListsToolStripMenuItem.Name = "lInqOnListsToolStripMenuItem";
            this.lInqOnListsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.lInqOnListsToolStripMenuItem.Text = "LInq on lists";
            // 
            // ex1ToolStripMenuItem
            // 
            this.ex1ToolStripMenuItem.Name = "ex1ToolStripMenuItem";
            this.ex1ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.ex1ToolStripMenuItem.Text = "Ex 1";
            this.ex1ToolStripMenuItem.Click += new System.EventHandler(this.ex1ToolStripMenuItem_Click);
            // 
            // ex2ToolStripMenuItem
            // 
            this.ex2ToolStripMenuItem.Name = "ex2ToolStripMenuItem";
            this.ex2ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.ex2ToolStripMenuItem.Text = "Ex 2";
            this.ex2ToolStripMenuItem.Click += new System.EventHandler(this.ex2ToolStripMenuItem_Click);
            // 
            // ex3ToolStripMenuItem
            // 
            this.ex3ToolStripMenuItem.Name = "ex3ToolStripMenuItem";
            this.ex3ToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.ex3ToolStripMenuItem.Text = "Ex 3";
            this.ex3ToolStripMenuItem.Click += new System.EventHandler(this.ex3ToolStripMenuItem_Click);
            // 
            // agregatesToolStripMenuItem
            // 
            this.agregatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumToolStripMenuItem,
            this.averageToolStripMenuItem,
            this.mediaCelorDeAnul2ToolStripMenuItem});
            this.agregatesToolStripMenuItem.Name = "agregatesToolStripMenuItem";
            this.agregatesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.agregatesToolStripMenuItem.Text = "Agregates";
            // 
            // sumToolStripMenuItem
            // 
            this.sumToolStripMenuItem.Name = "sumToolStripMenuItem";
            this.sumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumToolStripMenuItem.Text = "Sum";
            this.sumToolStripMenuItem.Click += new System.EventHandler(this.sumToolStripMenuItem_Click);
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.averageToolStripMenuItem.Text = "Average";
            this.averageToolStripMenuItem.Click += new System.EventHandler(this.averageToolStripMenuItem_Click);
            // 
            // mediaCelorDeAnul2ToolStripMenuItem
            // 
            this.mediaCelorDeAnul2ToolStripMenuItem.Name = "mediaCelorDeAnul2ToolStripMenuItem";
            this.mediaCelorDeAnul2ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.mediaCelorDeAnul2ToolStripMenuItem.Text = "Media celor de anul 2";
            this.mediaCelorDeAnul2ToolStripMenuItem.Click += new System.EventHandler(this.mediaCelorDeAnul2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 519);
            this.Controls.Add(this.colletionsTestButton);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button colletionsTestButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem linqOnArraysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderByOnStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersOnStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lInqOnListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaCelorDeAnul2ToolStripMenuItem;
    }
}

