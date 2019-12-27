namespace WindowsFormsShip
{
    partial class FormPort
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
            this.pictureBoxPort = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            this.buttonGetShip = new System.Windows.Forms.Button();
            this.maskedTextBoxSpot = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxlevels = new System.Windows.Forms.ListBox();
            this.buttonSetShip = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFilePort = new System.Windows.Forms.OpenFileDialog();
            this.saveFilePort = new System.Windows.Forms.SaveFileDialog();
            this.buttonForSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPort
            // 
            this.pictureBoxPort.Location = new System.Drawing.Point(0, 70);
            this.pictureBoxPort.Name = "pictureBoxPort";
            this.pictureBoxPort.Size = new System.Drawing.Size(958, 522);
            this.pictureBoxPort.TabIndex = 0;
            this.pictureBoxPort.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBoxTake);
            this.groupBox1.Controls.Add(this.buttonGetShip);
            this.groupBox1.Controls.Add(this.maskedTextBoxSpot);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(964, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Забрать судно с";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // pictureBoxTake
            // 
            this.pictureBoxTake.Location = new System.Drawing.Point(6, 107);
            this.pictureBoxTake.Name = "pictureBoxTake";
            this.pictureBoxTake.Size = new System.Drawing.Size(228, 144);
            this.pictureBoxTake.TabIndex = 3;
            this.pictureBoxTake.TabStop = false;
            // 
            // buttonGetShip
            // 
            this.buttonGetShip.Location = new System.Drawing.Point(54, 68);
            this.buttonGetShip.Name = "buttonGetShip";
            this.buttonGetShip.Size = new System.Drawing.Size(75, 33);
            this.buttonGetShip.TabIndex = 2;
            this.buttonGetShip.Text = "Забрать";
            this.buttonGetShip.UseVisualStyleBackColor = true;
            this.buttonGetShip.Click += new System.EventHandler(this.buttonGetShip_Click);
            // 
            // maskedTextBoxSpot
            // 
            this.maskedTextBoxSpot.Location = new System.Drawing.Point(135, 46);
            this.maskedTextBoxSpot.Name = "maskedTextBoxSpot";
            this.maskedTextBoxSpot.Size = new System.Drawing.Size(50, 22);
            this.maskedTextBoxSpot.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место:";
            // 
            // listBoxlevels
            // 
            this.listBoxlevels.FormattingEnabled = true;
            this.listBoxlevels.ItemHeight = 16;
            this.listBoxlevels.Location = new System.Drawing.Point(1051, 39);
            this.listBoxlevels.Name = "listBoxlevels";
            this.listBoxlevels.Size = new System.Drawing.Size(120, 84);
            this.listBoxlevels.TabIndex = 4;
            this.listBoxlevels.SelectedIndexChanged += new System.EventHandler(this.listBox1levels_SelectedIndexChanged);
            // 
            // buttonSetShip
            // 
            this.buttonSetShip.Location = new System.Drawing.Point(1029, 129);
            this.buttonSetShip.Name = "buttonSetShip";
            this.buttonSetShip.Size = new System.Drawing.Size(142, 38);
            this.buttonSetShip.TabIndex = 5;
            this.buttonSetShip.Text = "Заказать судно";
            this.buttonSetShip.UseVisualStyleBackColor = true;
            this.buttonSetShip.Click += new System.EventHandler(this.buttonSetShip_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Checked = true;
            this.файлToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFilePort
            // 
            this.openFilePort.FileName = "openFileDialog1";
            this.openFilePort.Filter = "txt file | *.txt";
            // 
            // saveFilePort
            // 
            this.saveFilePort.Filter = "txt file | *.txt";
            // 
            // buttonForSort
            // 
            this.buttonForSort.Location = new System.Drawing.Point(1029, 182);
            this.buttonForSort.Name = "buttonForSort";
            this.buttonForSort.Size = new System.Drawing.Size(142, 30);
            this.buttonForSort.TabIndex = 7;
            this.buttonForSort.Text = "Сортировка";
            this.buttonForSort.UseVisualStyleBackColor = true;
            this.buttonForSort.Click += new System.EventHandler(this.buttonForSort_Click);
            // 
            // FormPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 604);
            this.Controls.Add(this.buttonForSort);
            this.Controls.Add(this.buttonSetShip);
            this.Controls.Add(this.listBoxlevels);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxPort);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPort";
            this.Text = "FormPort";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxTake;
        private System.Windows.Forms.Button buttonGetShip;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSpot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxlevels;
        private System.Windows.Forms.Button buttonSetShip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFilePort;
        private System.Windows.Forms.SaveFileDialog saveFilePort;
        private System.Windows.Forms.Button buttonForSort;
    }
}