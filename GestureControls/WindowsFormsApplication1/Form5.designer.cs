namespace WindowsFormsApplication1
{
    partial class Form5
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userControl11 = new WindowsFormsApplication1.UserControl2();
            this.button1 = new System.Windows.Forms.Button();
            this.userControl12 = new WindowsFormsApplication1.UserControl2();
            this.label1 = new System.Windows.Forms.Label();
            this.userControl13 = new WindowsFormsApplication1.UserControl2();
            this.userControl14 = new WindowsFormsApplication1.UserControl2();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel1.Controls.Add(this.userControl11);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.userControl12);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.userControl13);
            this.flowLayoutPanel1.Controls.Add(this.userControl14);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(384, 361);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.Control;
            this.userControl11.Location = new System.Drawing.Point(3, 3);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(254, 123);
            this.userControl11.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.SystemColors.Control;
            this.userControl12.Location = new System.Drawing.Point(3, 132);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(266, 123);
            this.userControl12.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "在容器FlowLayout上侦听";
            // 
            // userControl13
            // 
            this.userControl13.BackColor = System.Drawing.SystemColors.Control;
            this.userControl13.Location = new System.Drawing.Point(3, 273);
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(334, 123);
            this.userControl13.TabIndex = 2;
            // 
            // userControl14
            // 
            this.userControl14.BackColor = System.Drawing.SystemColors.Control;
            this.userControl14.Location = new System.Drawing.Point(3, 402);
            this.userControl14.Name = "userControl14";
            this.userControl14.Size = new System.Drawing.Size(245, 123);
            this.userControl14.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form5";
            this.Text = "Panel+GestureUserControl";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControl2 userControl11;
        private System.Windows.Forms.Button button1;
        private UserControl2 userControl12;
        private System.Windows.Forms.Label label1;
        private UserControl2 userControl13;
        private UserControl2 userControl14;
        private System.Windows.Forms.Button button2;
    }
}