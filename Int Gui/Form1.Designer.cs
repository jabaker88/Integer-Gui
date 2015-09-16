namespace Int_Gui
{
    partial class MathGUI
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
            this.Welcome = new System.Windows.Forms.Label();
            this.InputBox1 = new System.Windows.Forms.TextBox();
            this.CheckForInt = new System.Windows.Forms.Button();
            this.EnterInt = new System.Windows.Forms.Label();
            this.InputBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(34, 9);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(198, 13);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome to McBuilds Studios Math Sim.";
            this.Welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InputBox1
            // 
            this.InputBox1.Location = new System.Drawing.Point(37, 103);
            this.InputBox1.Name = "InputBox1";
            this.InputBox1.Size = new System.Drawing.Size(195, 20);
            this.InputBox1.TabIndex = 1;
            this.InputBox1.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // CheckForInt
            // 
            this.CheckForInt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CheckForInt.Location = new System.Drawing.Point(37, 168);
            this.CheckForInt.Name = "CheckForInt";
            this.CheckForInt.Size = new System.Drawing.Size(195, 59);
            this.CheckForInt.TabIndex = 2;
            this.CheckForInt.Text = "Check for Int";
            this.CheckForInt.UseVisualStyleBackColor = false;
            this.CheckForInt.Click += new System.EventHandler(this.CheckForInt_Click);
            // 
            // EnterInt
            // 
            this.EnterInt.AutoSize = true;
            this.EnterInt.Location = new System.Drawing.Point(75, 47);
            this.EnterInt.Name = "EnterInt";
            this.EnterInt.Size = new System.Drawing.Size(126, 13);
            this.EnterInt.TabIndex = 3;
            this.EnterInt.Text = "Please enter two integers";
            // 
            // InputBox2
            // 
            this.InputBox2.Location = new System.Drawing.Point(37, 129);
            this.InputBox2.Name = "InputBox2";
            this.InputBox2.Size = new System.Drawing.Size(195, 20);
            this.InputBox2.TabIndex = 4;
            this.InputBox2.TextChanged += new System.EventHandler(this.InputBox2_TextChanged);
            // 
            // MathGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.InputBox2);
            this.Controls.Add(this.EnterInt);
            this.Controls.Add(this.CheckForInt);
            this.Controls.Add(this.InputBox1);
            this.Controls.Add(this.Welcome);
            this.Name = "MathGUI";
            this.RightToLeftLayout = true;
            this.Text = "MathGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.TextBox InputBox1;
        private System.Windows.Forms.Button CheckForInt;
        private System.Windows.Forms.Label EnterInt;
        private System.Windows.Forms.TextBox InputBox2;
    }
}

