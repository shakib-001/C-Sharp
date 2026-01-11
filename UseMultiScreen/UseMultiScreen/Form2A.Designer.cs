namespace UseMultiScreen
{
    partial class Form2A
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOutput = new System.Windows.Forms.Label();
            this.blprevious = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblOutput);
            this.panel1.Controls.Add(this.blprevious);
            this.panel1.Location = new System.Drawing.Point(11, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 227);
            this.panel1.TabIndex = 1;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(93, 34);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(70, 25);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "label1";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // blprevious
            // 
            this.blprevious.Location = new System.Drawing.Point(67, 108);
            this.blprevious.Name = "blprevious";
            this.blprevious.Size = new System.Drawing.Size(141, 51);
            this.blprevious.TabIndex = 1;
            this.blprevious.Text = "<<Previous";
            this.blprevious.UseVisualStyleBackColor = true;
            this.blprevious.Click += new System.EventHandler(this.blprevious_Click);
            // 
            // Form2A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.panel1);
            this.Name = "Form2A";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2A";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button blprevious;
        private System.Windows.Forms.Label lblOutput;
    }
}