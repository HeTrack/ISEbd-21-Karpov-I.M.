namespace WindowsFormsShip
{
    partial class FormShipConfig
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
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelShip = new System.Windows.Forms.Label();
            this.labelBoat = new System.Windows.Forms.Label();
            this.panelShip = new System.Windows.Forms.Panel();
            this.labelMotorsType = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelSimpleMotors = new System.Windows.Forms.Label();
            this.labelTrapMotors = new System.Windows.Forms.Label();
            this.labelVentilMotors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelShip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShip.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(241, 112);
            this.pictureBoxShip.TabIndex = 0;
            this.pictureBoxShip.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelShip);
            this.groupBox1.Controls.Add(this.labelBoat);
            this.groupBox1.Location = new System.Drawing.Point(39, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип судна";
            // 
            // labelShip
            // 
            this.labelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShip.Location = new System.Drawing.Point(23, 62);
            this.labelShip.Name = "labelShip";
            this.labelShip.Size = new System.Drawing.Size(62, 23);
            this.labelShip.TabIndex = 1;
            this.labelShip.Text = "Катер";
            this.labelShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelShip_MouseDown);
            // 
            // labelBoat
            // 
            this.labelBoat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBoat.Location = new System.Drawing.Point(23, 28);
            this.labelBoat.Name = "labelBoat";
            this.labelBoat.Size = new System.Drawing.Size(62, 23);
            this.labelBoat.TabIndex = 0;
            this.labelBoat.Text = "Лодка";
            this.labelBoat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBoat_MouseDown);
            // 
            // panelShip
            // 
            this.panelShip.AllowDrop = true;
            this.panelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShip.Controls.Add(this.labelMotorsType);
            this.panelShip.Controls.Add(this.labelDopColor);
            this.panelShip.Controls.Add(this.labelBaseColor);
            this.panelShip.Controls.Add(this.pictureBoxShip);
            this.panelShip.Location = new System.Drawing.Point(283, 42);
            this.panelShip.Name = "panelShip";
            this.panelShip.Size = new System.Drawing.Size(247, 297);
            this.panelShip.TabIndex = 2;
            this.panelShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
            this.panelShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            // 
            // labelMotorsType
            // 
            this.labelMotorsType.AllowDrop = true;
            this.labelMotorsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMotorsType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMotorsType.Location = new System.Drawing.Point(65, 235);
            this.labelMotorsType.Name = "labelMotorsType";
            this.labelMotorsType.Size = new System.Drawing.Size(110, 48);
            this.labelMotorsType.TabIndex = 3;
            this.labelMotorsType.Text = "Тип моторов";
            this.labelMotorsType.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMotorsType_DragDrop);
            this.labelMotorsType.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMotorsType_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(65, 176);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(110, 49);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(65, 118);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(110, 44);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelGold);
            this.groupBox2.Controls.Add(this.panelGray);
            this.groupBox2.Controls.Add(this.panelYellow);
            this.groupBox2.Controls.Add(this.panelRed);
            this.groupBox2.Controls.Add(this.panelBlue);
            this.groupBox2.Controls.Add(this.panelGreen);
            this.groupBox2.Controls.Add(this.panelWhite);
            this.groupBox2.Controls.Add(this.panelBlack);
            this.groupBox2.Location = new System.Drawing.Point(563, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 255);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.Gold;
            this.panelGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGold.Location = new System.Drawing.Point(82, 155);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(36, 38);
            this.panelGold.TabIndex = 2;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Location = new System.Drawing.Point(19, 155);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(36, 38);
            this.panelGray.TabIndex = 2;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(82, 111);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(36, 38);
            this.panelYellow.TabIndex = 2;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(19, 111);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(36, 38);
            this.panelRed.TabIndex = 2;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(82, 67);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(36, 38);
            this.panelBlue.TabIndex = 2;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(19, 67);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(36, 38);
            this.panelGreen.TabIndex = 2;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(82, 23);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(36, 38);
            this.panelWhite.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(19, 22);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(36, 39);
            this.panelBlack.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(39, 358);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 32);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(39, 317);
            this.buttonAdd.Name = "buttonLocate";
            this.buttonAdd.Size = new System.Drawing.Size(89, 35);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelVentilMotors);
            this.groupBox3.Controls.Add(this.labelTrapMotors);
            this.groupBox3.Controls.Add(this.labelSimpleMotors);
            this.groupBox3.Location = new System.Drawing.Point(39, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 129);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тип моторов";
            // 
            // labelSimpleMotors
            // 
            this.labelSimpleMotors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSimpleMotors.Location = new System.Drawing.Point(23, 22);
            this.labelSimpleMotors.Name = "labelSimpleMotors";
            this.labelSimpleMotors.Size = new System.Drawing.Size(126, 23);
            this.labelSimpleMotors.TabIndex = 0;
            this.labelSimpleMotors.Text = "Простые моторы";
            this.labelSimpleMotors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSimpleMotors_MouseDown);
            // 
            // labelTrapMotors
            // 
            this.labelTrapMotors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrapMotors.Location = new System.Drawing.Point(6, 58);
            this.labelTrapMotors.Name = "labelTrapMotors";
            this.labelTrapMotors.Size = new System.Drawing.Size(167, 23);
            this.labelTrapMotors.TabIndex = 1;
            this.labelTrapMotors.Text = "Гоночные трап-моторы";
            this.labelTrapMotors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTrapMotors_MouseDown);
            // 
            // labelVentilMotors
            // 
            this.labelVentilMotors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelVentilMotors.Location = new System.Drawing.Point(27, 92);
            this.labelVentilMotors.Name = "labelVentilMotors";
            this.labelVentilMotors.Size = new System.Drawing.Size(129, 23);
            this.labelVentilMotors.TabIndex = 2;
            this.labelVentilMotors.Text = "Моторы-вентили";
            this.labelVentilMotors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelVentilMotors_MouseDown);
            // 
            // FormShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelShip);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormShipConfig";
            this.Text = "Выбор Судна";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelShip.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelBoat;
        private System.Windows.Forms.Label labelShip;
        private System.Windows.Forms.Panel panelShip;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMotorsType;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelVentilMotors;
        private System.Windows.Forms.Label labelTrapMotors;
        private System.Windows.Forms.Label labelSimpleMotors;
    }
}