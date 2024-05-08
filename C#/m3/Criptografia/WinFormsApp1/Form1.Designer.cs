namespace WinFormsApp1
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
            label1 = new Label();
            txt_box = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            lbl_result = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(104, 47);
            label1.Name = "label1";
            label1.Size = new Size(199, 54);
            label1.TabIndex = 0;
            label1.Text = "ENCRYPT";
            label1.Click += label1_Click;
            // 
            // txt_box
            // 
            txt_box.BackColor = Color.FromArgb(255, 192, 255);
            txt_box.Font = new Font("Segoe UI", 15F);
            txt_box.Location = new Point(259, 120);
            txt_box.Name = "txt_box";
            txt_box.Size = new Size(255, 34);
            txt_box.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(104, 190);
            button1.Name = "button1";
            button1.Size = new Size(189, 64);
            button1.TabIndex = 2;
            button1.Text = "ENCRYPT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(470, 190);
            button2.Name = "button2";
            button2.Size = new Size(189, 64);
            button2.TabIndex = 3;
            button2.Text = "DESENCRYPT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(387, 47);
            label2.Name = "label2";
            label2.Size = new Size(272, 54);
            label2.TabIndex = 4;
            label2.Text = "DESENCRYPT";
            // 
            // lbl_result
            // 
            lbl_result.AutoSize = true;
            lbl_result.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbl_result.ForeColor = SystemColors.ButtonHighlight;
            lbl_result.Location = new Point(12, 285);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(112, 37);
            lbl_result.TabIndex = 5;
            lbl_result.Text = "RESULT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 322);
            label3.Name = "label3";
            label3.Size = new Size(112, 37);
            label3.TabIndex = 6;
            label3.Text = "RESULT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lbl_result);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_box);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_box;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label lbl_result;
        private Label label3;
    }
}
