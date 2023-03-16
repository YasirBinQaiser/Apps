namespace ChatGPT
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
            this.components = new System.ComponentModel.Container();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_Prompt = new System.Windows.Forms.TextBox();
            this.btn_Ask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Answer
            // 
            this.txt_Answer.Location = new System.Drawing.Point(12, 12);
            this.txt_Answer.Multiline = true;
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(529, 257);
            this.txt_Answer.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_Prompt
            // 
            this.txt_Prompt.Location = new System.Drawing.Point(12, 275);
            this.txt_Prompt.Name = "txt_Prompt";
            this.txt_Prompt.Size = new System.Drawing.Size(484, 20);
            this.txt_Prompt.TabIndex = 2;
            // 
            // btn_Ask
            // 
            this.btn_Ask.Location = new System.Drawing.Point(502, 275);
            this.btn_Ask.Name = "btn_Ask";
            this.btn_Ask.Size = new System.Drawing.Size(39, 20);
            this.btn_Ask.TabIndex = 3;
            this.btn_Ask.Text = ">";
            this.btn_Ask.UseVisualStyleBackColor = true;
            this.btn_Ask.Click += new System.EventHandler(this.btn_Ask_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Ask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 308);
            this.Controls.Add(this.btn_Ask);
            this.Controls.Add(this.txt_Prompt);
            this.Controls.Add(this.txt_Answer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_Prompt;
        private System.Windows.Forms.Button btn_Ask;
    }
}

