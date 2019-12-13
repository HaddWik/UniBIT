namespace Project_Car_Service_History
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            groupBox1 = new System.Windows.Forms.GroupBox();
            buttonAddRecord = new System.Windows.Forms.Button();
            buttonLoadFile = new System.Windows.Forms.Button();
            buttonCreateFile = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            labelVinFill = new System.Windows.Forms.Label();
            labelLicensePlateFill = new System.Windows.Forms.Label();
            labelModelFill = new System.Windows.Forms.Label();
            labelMakeFill = new System.Windows.Forms.Label();
            labelVin = new System.Windows.Forms.Label();
            labelPlate = new System.Windows.Forms.Label();
            labelModel = new System.Windows.Forms.Label();
            labelCarMake = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            listViewServiceData = new System.Windows.Forms.ListView();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAddRecord);
            groupBox1.Controls.Add(buttonLoadFile);
            groupBox1.Controls.Add(buttonCreateFile);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(175, 175);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Меню";
            // 
            // buttonAddRecord
            // 
            buttonAddRecord.Location = new System.Drawing.Point(15, 122);
            buttonAddRecord.Name = "buttonAddRecord";
            buttonAddRecord.Size = new System.Drawing.Size(145, 25);
            buttonAddRecord.TabIndex = 3;
            buttonAddRecord.Text = "Създаване на запис";
            buttonAddRecord.UseVisualStyleBackColor = true;
            buttonAddRecord.Click += new System.EventHandler(buttonAddRecord_Click);
            // 
            // buttonLoadFile
            // 
            buttonLoadFile.Location = new System.Drawing.Point(15, 60);
            buttonLoadFile.Name = "buttonLoadFile";
            buttonLoadFile.Size = new System.Drawing.Size(145, 25);
            buttonLoadFile.TabIndex = 1;
            buttonLoadFile.Text = "Зареждане на Кола";
            buttonLoadFile.UseVisualStyleBackColor = true;
            buttonLoadFile.Click += new System.EventHandler(buttonLoadFile_Click);
            // 
            // buttonCreateFile
            // 
            buttonCreateFile.Location = new System.Drawing.Point(15, 27);
            buttonCreateFile.Name = "buttonCreateFile";
            buttonCreateFile.Size = new System.Drawing.Size(145, 25);
            buttonCreateFile.TabIndex = 0;
            buttonCreateFile.Text = "Добавяне на кола";
            buttonCreateFile.UseVisualStyleBackColor = true;
            buttonCreateFile.Click += new System.EventHandler(buttonCreateFile_Click);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelVinFill);
            groupBox2.Controls.Add(labelLicensePlateFill);
            groupBox2.Controls.Add(labelModelFill);
            groupBox2.Controls.Add(labelMakeFill);
            groupBox2.Controls.Add(labelVin);
            groupBox2.Controls.Add(labelPlate);
            groupBox2.Controls.Add(labelModel);
            groupBox2.Controls.Add(labelCarMake);
            groupBox2.Location = new System.Drawing.Point(231, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(230, 175);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Детайли";
            // 
            // labelVinFill
            // 
            labelVinFill.AutoSize = true;
            labelVinFill.Location = new System.Drawing.Point(88, 112);
            labelVinFill.Name = "labelVinFill";
            labelVinFill.Size = new System.Drawing.Size(0, 13);
            labelVinFill.TabIndex = 14;
            // 
            // labelLicensePlateFill
            // 
            labelLicensePlateFill.AutoSize = true;
            labelLicensePlateFill.Location = new System.Drawing.Point(90, 87);
            labelLicensePlateFill.Name = "labelLicensePlateFill";
            labelLicensePlateFill.Size = new System.Drawing.Size(0, 13);
            labelLicensePlateFill.TabIndex = 13;
            // 
            // labelModelFill
            // 
            labelModelFill.AutoSize = true;
            labelModelFill.Location = new System.Drawing.Point(65, 60);
            labelModelFill.Name = "labelModelFill";
            labelModelFill.Size = new System.Drawing.Size(0, 13);
            labelModelFill.TabIndex = 12;
            // 
            // labelMakeFill
            // 
            labelMakeFill.AutoSize = true;
            labelMakeFill.Location = new System.Drawing.Point(65, 33);
            labelMakeFill.Name = "labelMakeFill";
            labelMakeFill.Size = new System.Drawing.Size(0, 13);
            labelMakeFill.TabIndex = 11;
            // 
            // labelVin
            // 
            labelVin.AutoSize = true;
            labelVin.Location = new System.Drawing.Point(16, 112);
            labelVin.Name = "labelVin";
            labelVin.Size = new System.Drawing.Size(66, 13);
            labelVin.TabIndex = 6;
            labelVin.Text = "Вин Номер:";
            // 
            // labelPlate
            // 
            labelPlate.AutoSize = true;
            labelPlate.Location = new System.Drawing.Point(16, 87);
            labelPlate.Name = "labelPlate";
            labelPlate.Size = new System.Drawing.Size(68, 13);
            labelPlate.TabIndex = 5;
            labelPlate.Text = "Рег. Номер:";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new System.Drawing.Point(16, 60);
            labelModel.Name = "labelModel";
            labelModel.Size = new System.Drawing.Size(43, 13);
            labelModel.TabIndex = 4;
            labelModel.Text = "Модел:";
            // 
            // labelCarMake
            // 
            labelCarMake.AutoSize = true;
            labelCarMake.Location = new System.Drawing.Point(16, 33);
            labelCarMake.Name = "labelCarMake";
            labelCarMake.Size = new System.Drawing.Size(43, 13);
            labelCarMake.TabIndex = 3;
            labelCarMake.Text = "Марка:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 202);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(103, 13);
            label4.TabIndex = 4;
            label4.Text = "Сервизна история:";
            // 
            // listViewServiceData
            // 
            listViewServiceData.HideSelection = false;
            listViewServiceData.Location = new System.Drawing.Point(15, 227);
            listViewServiceData.Name = "listViewServiceData";
            listViewServiceData.Size = new System.Drawing.Size(757, 322);
            listViewServiceData.TabIndex = 10;
            listViewServiceData.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(494, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(278, 175);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDark;
            ClientSize = new System.Drawing.Size(784, 561);
            Controls.Add(listViewServiceData);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximumSize = new System.Drawing.Size(800, 600);
            MinimumSize = new System.Drawing.Size(800, 600);
            Name = "mainForm";
            Text = "Сервизна история";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private static System.Windows.Forms.GroupBox groupBox1;
        private static System.Windows.Forms.Button buttonAddRecord;
        private static System.Windows.Forms.Button buttonLoadFile;
        private static System.Windows.Forms.Button buttonCreateFile;
        private static System.Windows.Forms.GroupBox groupBox2;
        private static System.Windows.Forms.Label labelVin;
        private static System.Windows.Forms.Label labelPlate;
        private static System.Windows.Forms.Label labelModel;
        private static System.Windows.Forms.Label labelCarMake;
        private static System.Windows.Forms.Label label4;
        private static System.Windows.Forms.PictureBox pictureBox1;
        private static System.Windows.Forms.ListView listViewServiceData;
        private static System.Windows.Forms.Label labelMakeFill;
        private static System.Windows.Forms.Label labelModelFill;
        private static System.Windows.Forms.Label labelLicensePlateFill;
        private static System.Windows.Forms.Label labelVinFill;
    }
}

