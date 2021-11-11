
namespace Muhammed_ali_is_the_better_fighter
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
            this.Jokebutton = new System.Windows.Forms.Button();
            this.jokeText = new System.Windows.Forms.Label();
            this.Box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Jokebutton
            // 
            this.Jokebutton.Location = new System.Drawing.Point(331, 288);
            this.Jokebutton.Name = "Jokebutton";
            this.Jokebutton.Size = new System.Drawing.Size(121, 30);
            this.Jokebutton.TabIndex = 0;
            this.Jokebutton.Text = "Make me laugh";
            this.Jokebutton.UseVisualStyleBackColor = true;
            this.Jokebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // jokeText
            // 
            this.jokeText.AutoSize = true;
            this.jokeText.Location = new System.Drawing.Point(12, 9);
            this.jokeText.Name = "jokeText";
            this.jokeText.Size = new System.Drawing.Size(36, 13);
            this.jokeText.TabIndex = 1;
            this.jokeText.Text = "Funny";
            // 
            // Box
            // 
            this.Box.FormattingEnabled = true;
            this.Box.Location = new System.Drawing.Point(331, 325);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(121, 21);
            this.Box.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.jokeText);
            this.Controls.Add(this.Jokebutton);
            this.Name = "Form1";
            this.Text = "Funny gen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Jokebutton;
        private System.Windows.Forms.Label jokeText;
        private System.Windows.Forms.ComboBox Box;
    }
}

