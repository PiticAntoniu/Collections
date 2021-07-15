
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
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(498, 794);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(176, 86);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // colletionsTestButton
            // 
            this.colletionsTestButton.Location = new System.Drawing.Point(739, 794);
            this.colletionsTestButton.Name = "colletionsTestButton";
            this.colletionsTestButton.Size = new System.Drawing.Size(150, 86);
            this.colletionsTestButton.TabIndex = 1;
            this.colletionsTestButton.Text = "Collections";
            this.colletionsTestButton.UseVisualStyleBackColor = true;
            this.colletionsTestButton.Click += new System.EventHandler(this.colletionsTestButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 999);
            this.Controls.Add(this.colletionsTestButton);
            this.Controls.Add(this.testButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button colletionsTestButton;
    }
}

