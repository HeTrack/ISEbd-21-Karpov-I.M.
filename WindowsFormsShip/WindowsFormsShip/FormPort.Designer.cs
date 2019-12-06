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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxTake = new System.Windows.Forms.PictureBox();
            this.buttonGetShip = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLocateShip = new System.Windows.Forms.Button();
            this.buttonNewPorting = new System.Windows.Forms.Button();
            this.buttonCleanPort = new System.Windows.Forms.Button();
            this.buttonLocateBoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPort
            // 
            this.pictureBoxPort.Location = new System.Drawing.Point(1, 2);
            this.pictureBoxPort.Name = "pictureBoxPort";
            this.pictureBoxPort.Size = new System.Drawing.Size(723, 447);
            this.pictureBoxPort.TabIndex = 0;
            this.pictureBoxPort.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBoxTake);
            this.groupBox1.Controls.Add(this.buttonGetShip);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(774, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 278);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Забрать судно с";
            // 
            // pictureBoxTake
            // 
            this.pictureBoxTake.Location = new System.Drawing.Point(0, 123);
            this.pictureBoxTake.Name = "pictureBoxTake";
            this.pictureBoxTake.Size = new System.Drawing.Size(228, 144);
            this.pictureBoxTake.TabIndex = 3;
            this.pictureBoxTake.TabStop = false;
            // 
            // buttonGetShip
            // 
            this.buttonGetShip.Location = new System.Drawing.Point(47, 86);
            this.buttonGetShip.Name = "buttonGetShip";
            this.buttonGetShip.Size = new System.Drawing.Size(75, 33);
            this.buttonGetShip.TabIndex = 2;
            this.buttonGetShip.Text = "Забрать";
            this.buttonGetShip.UseVisualStyleBackColor = true;
            this.buttonGetShip.Click += new System.EventHandler(this.buttonGetShip_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(128, 66);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(50, 22);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место:";
            // 
            // buttonLocateShip
            // 
            this.buttonLocateShip.Location = new System.Drawing.Point(796, 56);
            this.buttonLocateShip.Name = "buttonLocateShip";
            this.buttonLocateShip.Size = new System.Drawing.Size(174, 39);
            this.buttonLocateShip.TabIndex = 3;
            this.buttonLocateShip.Text = "Пришвартовать катер";
            this.buttonLocateShip.UseVisualStyleBackColor = true;
            this.buttonLocateShip.Click += new System.EventHandler(this.buttonLocateShip_Click);
            // 
            // buttonNewPorting
            // 
            this.buttonNewPorting.Location = new System.Drawing.Point(796, 101);
            this.buttonNewPorting.Name = "buttonNewPorting";
            this.buttonNewPorting.Size = new System.Drawing.Size(174, 32);
            this.buttonNewPorting.TabIndex = 4;
            this.buttonNewPorting.Text = "Перепарковать";
            this.buttonNewPorting.UseVisualStyleBackColor = true;
            this.buttonNewPorting.Click += new System.EventHandler(this.buttonNewPorting_Click);
            // 
            // buttonCleanPort
            // 
            this.buttonCleanPort.Location = new System.Drawing.Point(796, 139);
            this.buttonCleanPort.Name = "buttonCleanPort";
            this.buttonCleanPort.Size = new System.Drawing.Size(173, 32);
            this.buttonCleanPort.TabIndex = 5;
            this.buttonCleanPort.Text = "Очистить гавань";
            this.buttonCleanPort.UseVisualStyleBackColor = true;
            this.buttonCleanPort.Click += new System.EventHandler(this.buttonCleanPort_Click);
            // 
            // buttonLocateBoat
            // 
            this.buttonLocateBoat.Location = new System.Drawing.Point(796, 12);
            this.buttonLocateBoat.Name = "buttonLocateBoat";
            this.buttonLocateBoat.Size = new System.Drawing.Size(172, 35);
            this.buttonLocateBoat.TabIndex = 6;
            this.buttonLocateBoat.Text = "Пришвартовать лодку";
            this.buttonLocateBoat.UseVisualStyleBackColor = true;
            this.buttonLocateBoat.Click += new System.EventHandler(this.buttonLocateBoat_Click);
            // 
            // FormPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 545);
            this.Controls.Add(this.buttonLocateBoat);
            this.Controls.Add(this.buttonCleanPort);
            this.Controls.Add(this.buttonNewPorting);
            this.Controls.Add(this.buttonLocateShip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxPort);
            this.Name = "FormPort";
            this.Text = "FormPort";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxTake;
        private System.Windows.Forms.Button buttonGetShip;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLocate;
        private System.Windows.Forms.Button buttonLocateShip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNewPorting;
        private System.Windows.Forms.Button buttonCleanPort;
        private System.Windows.Forms.Button buttonLocateBoat;
    }
}