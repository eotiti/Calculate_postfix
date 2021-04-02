
namespace TimeExc
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
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(138, 81);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(194, 22);
            this.txt_input.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(197, 143);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(73, 30);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "button1";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(138, 196);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(194, 22);
            this.txt_output.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Biểu thức hậu tố";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "biểu thức trung tố";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(197, 255);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(73, 30);
            this.btn_calc.TabIndex = 6;
            this.btn_calc.Text = "button1";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 453);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_calc;
    }
}

