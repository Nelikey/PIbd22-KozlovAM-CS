
namespace WindowsFormsLocomotive
{
    partial class FormLocoConfig
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
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxSideLine = new System.Windows.Forms.CheckBox();
            this.checkBoxBackLight = new System.Windows.Forms.CheckBox();
            this.checkBoxFrontLight = new System.Windows.Forms.CheckBox();
            this.checkBoxSmokestack = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxLoco = new System.Windows.Forms.PictureBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.labelLocomotive = new System.Windows.Forms.Label();
            this.labelBaseLocomotive = new System.Windows.Forms.Label();
            this.panelLoco = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelColorRed = new System.Windows.Forms.Panel();
            this.panelColorWhite = new System.Windows.Forms.Panel();
            this.panelColorBlue = new System.Windows.Forms.Panel();
            this.panelColorYellow = new System.Windows.Forms.Panel();
            this.panelColorGreen = new System.Windows.Forms.Panel();
            this.panelColorBlack = new System.Windows.Forms.Panel();
            this.panelColorFuchsia = new System.Windows.Forms.Panel();
            this.panelColorGray = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoco)).BeginInit();
            this.groupBoxType.SuspendLayout();
            this.panelLoco.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.checkBoxSideLine);
            this.groupBoxParameters.Controls.Add(this.checkBoxBackLight);
            this.groupBoxParameters.Controls.Add(this.checkBoxFrontLight);
            this.groupBoxParameters.Controls.Add(this.checkBoxSmokestack);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.labelWeight);
            this.groupBoxParameters.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 135);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(316, 127);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // checkBoxSideLine
            // 
            this.checkBoxSideLine.AutoSize = true;
            this.checkBoxSideLine.Location = new System.Drawing.Point(166, 91);
            this.checkBoxSideLine.Name = "checkBoxSideLine";
            this.checkBoxSideLine.Size = new System.Drawing.Size(108, 17);
            this.checkBoxSideLine.TabIndex = 7;
            this.checkBoxSideLine.Text = "Боковая полоса";
            this.checkBoxSideLine.UseVisualStyleBackColor = true;
            this.checkBoxSideLine.Click += new System.EventHandler(this.checkBoxSideLine_Click);
            // 
            // checkBoxBackLight
            // 
            this.checkBoxBackLight.AutoSize = true;
            this.checkBoxBackLight.Location = new System.Drawing.Point(166, 68);
            this.checkBoxBackLight.Name = "checkBoxBackLight";
            this.checkBoxBackLight.Size = new System.Drawing.Size(104, 17);
            this.checkBoxBackLight.TabIndex = 6;
            this.checkBoxBackLight.Text = "Задний фонарь";
            this.checkBoxBackLight.UseVisualStyleBackColor = true;
            this.checkBoxBackLight.Click += new System.EventHandler(this.checkBoxBackLight_Click);
            // 
            // checkBoxFrontLight
            // 
            this.checkBoxFrontLight.AutoSize = true;
            this.checkBoxFrontLight.Location = new System.Drawing.Point(166, 45);
            this.checkBoxFrontLight.Name = "checkBoxFrontLight";
            this.checkBoxFrontLight.Size = new System.Drawing.Size(117, 17);
            this.checkBoxFrontLight.TabIndex = 5;
            this.checkBoxFrontLight.Text = "Передний фонарь";
            this.checkBoxFrontLight.UseVisualStyleBackColor = true;
            this.checkBoxFrontLight.Click += new System.EventHandler(this.checkBoxFrontLight_Click);
            // 
            // checkBoxSmokestack
            // 
            this.checkBoxSmokestack.AutoSize = true;
            this.checkBoxSmokestack.Location = new System.Drawing.Point(166, 22);
            this.checkBoxSmokestack.Name = "checkBoxSmokestack";
            this.checkBoxSmokestack.Size = new System.Drawing.Size(106, 17);
            this.checkBoxSmokestack.TabIndex = 4;
            this.checkBoxSmokestack.Text = "Дымовая труба";
            this.checkBoxSmokestack.UseVisualStyleBackColor = true;
            this.checkBoxSmokestack.Click += new System.EventHandler(this.checkBoxSmokestack_Click);
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(54, 82);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(54, 38);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(67, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(10, 66);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(55, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес авто:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(10, 22);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(90, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость:";
            // 
            // pictureBoxLoco
            // 
            this.pictureBoxLoco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLoco.Location = new System.Drawing.Point(9, 9);
            this.pictureBoxLoco.Name = "pictureBoxLoco";
            this.pictureBoxLoco.Size = new System.Drawing.Size(145, 98);
            this.pictureBoxLoco.TabIndex = 1;
            this.pictureBoxLoco.TabStop = false;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.labelLocomotive);
            this.groupBoxType.Controls.Add(this.labelBaseLocomotive);
            this.groupBoxType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(114, 108);
            this.groupBoxType.TabIndex = 2;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип локомотива";
            // 
            // labelLocomotive
            // 
            this.labelLocomotive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLocomotive.Location = new System.Drawing.Point(13, 66);
            this.labelLocomotive.Name = "labelLocomotive";
            this.labelLocomotive.Padding = new System.Windows.Forms.Padding(16, 6, 0, 0);
            this.labelLocomotive.Size = new System.Drawing.Size(87, 29);
            this.labelLocomotive.TabIndex = 1;
            this.labelLocomotive.Text = "Тепловоз";
            this.labelLocomotive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLocomotive_MouseDown);
            // 
            // labelBaseLocomotive
            // 
            this.labelBaseLocomotive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseLocomotive.Location = new System.Drawing.Point(13, 25);
            this.labelBaseLocomotive.Name = "labelBaseLocomotive";
            this.labelBaseLocomotive.Padding = new System.Windows.Forms.Padding(16, 6, 0, 0);
            this.labelBaseLocomotive.Size = new System.Drawing.Size(87, 29);
            this.labelBaseLocomotive.TabIndex = 0;
            this.labelBaseLocomotive.Text = "Обычный";
            this.labelBaseLocomotive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBaseLocomotive_MouseDown);
            // 
            // panelLoco
            // 
            this.panelLoco.AllowDrop = true;
            this.panelLoco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoco.Controls.Add(this.pictureBoxLoco);
            this.panelLoco.Location = new System.Drawing.Point(132, 12);
            this.panelLoco.Name = "panelLoco";
            this.panelLoco.Size = new System.Drawing.Size(167, 117);
            this.panelLoco.TabIndex = 3;
            this.panelLoco.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelLoco_DragDrop);
            this.panelLoco.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelLoco_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelColorRed);
            this.groupBoxColors.Controls.Add(this.panelColorWhite);
            this.groupBoxColors.Controls.Add(this.panelColorBlue);
            this.groupBoxColors.Controls.Add(this.panelColorYellow);
            this.groupBoxColors.Controls.Add(this.panelColorGreen);
            this.groupBoxColors.Controls.Add(this.panelColorBlack);
            this.groupBoxColors.Controls.Add(this.panelColorFuchsia);
            this.groupBoxColors.Controls.Add(this.panelColorGray);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Location = new System.Drawing.Point(334, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(217, 141);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelColorRed
            // 
            this.panelColorRed.BackColor = System.Drawing.Color.Red;
            this.panelColorRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorRed.Location = new System.Drawing.Point(15, 68);
            this.panelColorRed.Name = "panelColorRed";
            this.panelColorRed.Size = new System.Drawing.Size(30, 30);
            this.panelColorRed.TabIndex = 7;
            // 
            // panelColorWhite
            // 
            this.panelColorWhite.BackColor = System.Drawing.Color.White;
            this.panelColorWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorWhite.Location = new System.Drawing.Point(165, 68);
            this.panelColorWhite.Name = "panelColorWhite";
            this.panelColorWhite.Size = new System.Drawing.Size(30, 30);
            this.panelColorWhite.TabIndex = 8;
            // 
            // panelColorBlue
            // 
            this.panelColorBlue.BackColor = System.Drawing.Color.Blue;
            this.panelColorBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorBlue.Location = new System.Drawing.Point(165, 104);
            this.panelColorBlue.Name = "panelColorBlue";
            this.panelColorBlue.Size = new System.Drawing.Size(30, 30);
            this.panelColorBlue.TabIndex = 9;
            // 
            // panelColorYellow
            // 
            this.panelColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelColorYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorYellow.Location = new System.Drawing.Point(65, 68);
            this.panelColorYellow.Name = "panelColorYellow";
            this.panelColorYellow.Size = new System.Drawing.Size(30, 30);
            this.panelColorYellow.TabIndex = 12;
            // 
            // panelColorGreen
            // 
            this.panelColorGreen.BackColor = System.Drawing.Color.Green;
            this.panelColorGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorGreen.Location = new System.Drawing.Point(116, 104);
            this.panelColorGreen.Name = "panelColorGreen";
            this.panelColorGreen.Size = new System.Drawing.Size(30, 30);
            this.panelColorGreen.TabIndex = 10;
            // 
            // panelColorBlack
            // 
            this.panelColorBlack.BackColor = System.Drawing.Color.Black;
            this.panelColorBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorBlack.Location = new System.Drawing.Point(116, 68);
            this.panelColorBlack.Name = "panelColorBlack";
            this.panelColorBlack.Size = new System.Drawing.Size(30, 30);
            this.panelColorBlack.TabIndex = 13;
            // 
            // panelColorFuchsia
            // 
            this.panelColorFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelColorFuchsia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorFuchsia.Location = new System.Drawing.Point(65, 104);
            this.panelColorFuchsia.Name = "panelColorFuchsia";
            this.panelColorFuchsia.Size = new System.Drawing.Size(30, 30);
            this.panelColorFuchsia.TabIndex = 11;
            // 
            // panelColorGray
            // 
            this.panelColorGray.BackColor = System.Drawing.Color.Gray;
            this.panelColorGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorGray.Location = new System.Drawing.Point(15, 104);
            this.panelColorGray.Name = "panelColorGray";
            this.panelColorGray.Size = new System.Drawing.Size(30, 30);
            this.panelColorGray.TabIndex = 14;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(111, 22);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Padding = new System.Windows.Forms.Padding(16, 6, 0, 0);
            this.labelDopColor.Size = new System.Drawing.Size(87, 29);
            this.labelDopColor.TabIndex = 6;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(18, 22);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Padding = new System.Windows.Forms.Padding(2, 6, 0, 0);
            this.labelMainColor.Size = new System.Drawing.Size(87, 29);
            this.labelMainColor.TabIndex = 2;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(476, 176);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(475, 213);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormLocoConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 264);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelLoco);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.groupBoxParameters);
            this.Name = "FormLocoConfig";
            this.Text = "Выбор локомотива";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoco)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            this.panelLoco.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.CheckBox checkBoxSideLine;
        private System.Windows.Forms.CheckBox checkBoxBackLight;
        private System.Windows.Forms.CheckBox checkBoxFrontLight;
        private System.Windows.Forms.CheckBox checkBoxSmokestack;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxLoco;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Label labelLocomotive;
        private System.Windows.Forms.Label labelBaseLocomotive;
        private System.Windows.Forms.Panel panelLoco;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelColorRed;
        private System.Windows.Forms.Panel panelColorWhite;
        private System.Windows.Forms.Panel panelColorBlue;
        private System.Windows.Forms.Panel panelColorYellow;
        private System.Windows.Forms.Panel panelColorGreen;
        private System.Windows.Forms.Panel panelColorBlack;
        private System.Windows.Forms.Panel panelColorFuchsia;
        private System.Windows.Forms.Panel panelColorGray;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}