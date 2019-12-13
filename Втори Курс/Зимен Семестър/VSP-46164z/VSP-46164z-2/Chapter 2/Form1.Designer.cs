namespace Chapter_2
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonBulgarian = new System.Windows.Forms.Button();
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(171, 96);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(85, 38);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonBulgarian
            // 
            this.buttonBulgarian.Image = global::Chapter_2.Properties.Resources.bg;
            this.buttonBulgarian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBulgarian.Location = new System.Drawing.Point(313, 12);
            this.buttonBulgarian.Name = "buttonBulgarian";
            this.buttonBulgarian.Size = new System.Drawing.Size(113, 47);
            this.buttonBulgarian.TabIndex = 2;
            this.buttonBulgarian.Text = "Bulgarian";
            this.buttonBulgarian.UseVisualStyleBackColor = true;
            this.buttonBulgarian.Click += new System.EventHandler(this.buttonBulgarian_Click);
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.Image = global::Chapter_2.Properties.Resources.uk;
            this.buttonEnglish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnglish.Location = new System.Drawing.Point(12, 12);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(113, 47);
            this.buttonEnglish.TabIndex = 0;
            this.buttonEnglish.Text = "English";
            this.buttonEnglish.UseVisualStyleBackColor = true;
            this.buttonEnglish.Click += new System.EventHandler(this.buttonEnglish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 174);
            this.Controls.Add(this.buttonBulgarian);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonEnglish);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEnglish;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonBulgarian;
    }
}

