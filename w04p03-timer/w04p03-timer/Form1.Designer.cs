namespace w04p03_timer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(105, 36);
            label1.Name = "label1";
            label1.Size = new Size(158, 191);
            label1.TabIndex = 0;
            label1.Text = "0";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(44, 230);
            button1.Name = "button1";
            button1.Size = new Size(282, 55);
            button1.TabIndex = 1;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(44, 302);
            button2.Name = "button2";
            button2.Size = new Size(282, 51);
            button2.TabIndex = 2;
            button2.Text = "PAUZA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(44, 375);
            button3.Name = "button3";
            button3.Size = new Size(282, 47);
            button3.TabIndex = 3;
            button3.Text = "STOP";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // timer2
            // 
            timer2.Interval = 30000;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer2;
    }
}
