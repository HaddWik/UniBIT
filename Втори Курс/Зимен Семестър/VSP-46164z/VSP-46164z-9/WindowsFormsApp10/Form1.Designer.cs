namespace WindowsFormsApp10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTasks = new System.Windows.Forms.TabPage();
            this.tabPageNewTasks = new System.Windows.Forms.TabPage();
            this.tabPageDocs = new System.Windows.Forms.TabPage();
            this.tabPageDocsOK = new System.Windows.Forms.TabPage();
            this.tabPageNotes = new System.Windows.Forms.TabPage();
            this.tabPageFolders = new System.Windows.Forms.TabPage();
            this.tabPageBrowsers = new System.Windows.Forms.TabPage();
            this.tabPageQuestions = new System.Windows.Forms.TabPage();
            this.tabPageApplications = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTasks);
            this.tabControl1.Controls.Add(this.tabPageNewTasks);
            this.tabControl1.Controls.Add(this.tabPageDocs);
            this.tabControl1.Controls.Add(this.tabPageDocsOK);
            this.tabControl1.Controls.Add(this.tabPageNotes);
            this.tabControl1.Controls.Add(this.tabPageFolders);
            this.tabControl1.Controls.Add(this.tabPageBrowsers);
            this.tabControl1.Controls.Add(this.tabPageQuestions);
            this.tabControl1.Controls.Add(this.tabPageApplications);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 417);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageTasks
            // 
            this.tabPageTasks.ImageIndex = 7;
            this.tabPageTasks.Location = new System.Drawing.Point(4, 74);
            this.tabPageTasks.Name = "tabPageTasks";
            this.tabPageTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTasks.Size = new System.Drawing.Size(808, 339);
            this.tabPageTasks.TabIndex = 0;
            this.tabPageTasks.Text = "Задачи";
            this.tabPageTasks.UseVisualStyleBackColor = true;
            // 
            // tabPageNewTasks
            // 
            this.tabPageNewTasks.ImageIndex = 5;
            this.tabPageNewTasks.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewTasks.Name = "tabPageNewTasks";
            this.tabPageNewTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewTasks.Size = new System.Drawing.Size(620, 321);
            this.tabPageNewTasks.TabIndex = 1;
            this.tabPageNewTasks.Text = "Нови Задачи";
            this.tabPageNewTasks.UseVisualStyleBackColor = true;
            // 
            // tabPageDocs
            // 
            this.tabPageDocs.ImageIndex = 3;
            this.tabPageDocs.Location = new System.Drawing.Point(4, 22);
            this.tabPageDocs.Name = "tabPageDocs";
            this.tabPageDocs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocs.Size = new System.Drawing.Size(620, 321);
            this.tabPageDocs.TabIndex = 2;
            this.tabPageDocs.Text = "Документи";
            this.tabPageDocs.UseVisualStyleBackColor = true;
            // 
            // tabPageDocsOK
            // 
            this.tabPageDocsOK.ImageIndex = 2;
            this.tabPageDocsOK.Location = new System.Drawing.Point(4, 22);
            this.tabPageDocsOK.Name = "tabPageDocsOK";
            this.tabPageDocsOK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocsOK.Size = new System.Drawing.Size(620, 321);
            this.tabPageDocsOK.TabIndex = 3;
            this.tabPageDocsOK.Text = "Готови Документи";
            this.tabPageDocsOK.UseVisualStyleBackColor = true;
            // 
            // tabPageNotes
            // 
            this.tabPageNotes.ImageIndex = 6;
            this.tabPageNotes.Location = new System.Drawing.Point(4, 22);
            this.tabPageNotes.Name = "tabPageNotes";
            this.tabPageNotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNotes.Size = new System.Drawing.Size(620, 321);
            this.tabPageNotes.TabIndex = 4;
            this.tabPageNotes.Text = "Бележки";
            this.tabPageNotes.UseVisualStyleBackColor = true;
            // 
            // tabPageFolders
            // 
            this.tabPageFolders.ImageIndex = 4;
            this.tabPageFolders.Location = new System.Drawing.Point(4, 22);
            this.tabPageFolders.Name = "tabPageFolders";
            this.tabPageFolders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFolders.Size = new System.Drawing.Size(620, 321);
            this.tabPageFolders.TabIndex = 5;
            this.tabPageFolders.Text = "Папки";
            this.tabPageFolders.UseVisualStyleBackColor = true;
            // 
            // tabPageBrowsers
            // 
            this.tabPageBrowsers.ImageIndex = 0;
            this.tabPageBrowsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageBrowsers.Name = "tabPageBrowsers";
            this.tabPageBrowsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBrowsers.Size = new System.Drawing.Size(620, 321);
            this.tabPageBrowsers.TabIndex = 6;
            this.tabPageBrowsers.Text = "Браузър";
            this.tabPageBrowsers.UseVisualStyleBackColor = true;
            // 
            // tabPageQuestions
            // 
            this.tabPageQuestions.ImageIndex = 1;
            this.tabPageQuestions.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuestions.Name = "tabPageQuestions";
            this.tabPageQuestions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuestions.Size = new System.Drawing.Size(620, 321);
            this.tabPageQuestions.TabIndex = 7;
            this.tabPageQuestions.Text = "Въпроси";
            this.tabPageQuestions.UseVisualStyleBackColor = true;
            // 
            // tabPageApplications
            // 
            this.tabPageApplications.ImageIndex = 8;
            this.tabPageApplications.Location = new System.Drawing.Point(4, 22);
            this.tabPageApplications.Name = "tabPageApplications";
            this.tabPageApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApplications.Size = new System.Drawing.Size(620, 321);
            this.tabPageApplications.TabIndex = 8;
            this.tabPageApplications.Text = "Приложения";
            this.tabPageApplications.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "browser.bmp");
            this.imageList1.Images.SetKeyName(1, "cuestions.bmp");
            this.imageList1.Images.SetKeyName(2, "docs-ok.png");
            this.imageList1.Images.SetKeyName(3, "documents.png");
            this.imageList1.Images.SetKeyName(4, "Folder.bmp");
            this.imageList1.Images.SetKeyName(5, "next-tasks.bmp");
            this.imageList1.Images.SetKeyName(6, "notes.png");
            this.imageList1.Images.SetKeyName(7, "task.png");
            this.imageList1.Images.SetKeyName(8, "applications.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 417);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTasks;
        private System.Windows.Forms.TabPage tabPageNewTasks;
        private System.Windows.Forms.TabPage tabPageDocs;
        private System.Windows.Forms.TabPage tabPageDocsOK;
        private System.Windows.Forms.TabPage tabPageNotes;
        private System.Windows.Forms.TabPage tabPageFolders;
        private System.Windows.Forms.TabPage tabPageBrowsers;
        private System.Windows.Forms.TabPage tabPageQuestions;
        private System.Windows.Forms.TabPage tabPageApplications;
        private System.Windows.Forms.ImageList imageList1;
    }
}

