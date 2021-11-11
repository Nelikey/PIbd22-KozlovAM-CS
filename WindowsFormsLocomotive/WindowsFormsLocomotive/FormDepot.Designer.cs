namespace WindowsFormsLocomotive
{
	partial class FormDepot
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
            this.pictureBoxDepot = new System.Windows.Forms.PictureBox();
            this.buttonTakeLoco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.listBoxDepots = new System.Windows.Forms.ListBox();
            this.buttonDelParking = new System.Windows.Forms.Button();
            this.buttonSetLoco = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDepot
            // 
            this.pictureBoxDepot.Location = new System.Drawing.Point(-1, 25);
            this.pictureBoxDepot.Name = "pictureBoxDepot";
            this.pictureBoxDepot.Size = new System.Drawing.Size(666, 422);
            this.pictureBoxDepot.TabIndex = 1;
            this.pictureBoxDepot.TabStop = false;
            // 
            // buttonTakeLoco
            // 
            this.buttonTakeLoco.Location = new System.Drawing.Point(678, 423);
            this.buttonTakeLoco.Name = "buttonTakeLoco";
            this.buttonTakeLoco.Size = new System.Drawing.Size(110, 23);
            this.buttonTakeLoco.TabIndex = 4;
            this.buttonTakeLoco.Text = "Забрать";
            this.buttonTakeLoco.UseVisualStyleBackColor = true;
            this.buttonTakeLoco.Click += new System.EventHandler(this.buttonTakeLoco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Забрать локомотив";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(723, 397);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(65, 20);
            this.maskedTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Депо:";
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(678, 26);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(110, 20);
            this.textBoxNewLevelName.TabIndex = 9;
            this.textBoxNewLevelName.TextChanged += new System.EventHandler(this.textBoxNewLevelName_TextChanged);
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(678, 51);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(110, 23);
            this.buttonAddParking.TabIndex = 10;
            this.buttonAddParking.Text = "Добавить депо";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // listBoxDepots
            // 
            this.listBoxDepots.FormattingEnabled = true;
            this.listBoxDepots.Location = new System.Drawing.Point(678, 80);
            this.listBoxDepots.Name = "listBoxDepots";
            this.listBoxDepots.Size = new System.Drawing.Size(110, 95);
            this.listBoxDepots.TabIndex = 11;
            this.listBoxDepots.SelectedIndexChanged += new System.EventHandler(this.listBoxDepots_SelectedIndexChanged);
            // 
            // buttonDelParking
            // 
            this.buttonDelParking.Location = new System.Drawing.Point(678, 181);
            this.buttonDelParking.Name = "buttonDelParking";
            this.buttonDelParking.Size = new System.Drawing.Size(110, 23);
            this.buttonDelParking.TabIndex = 12;
            this.buttonDelParking.Text = "Удалить депо";
            this.buttonDelParking.UseVisualStyleBackColor = true;
            this.buttonDelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // buttonSetLoco
            // 
            this.buttonSetLoco.Location = new System.Drawing.Point(678, 305);
            this.buttonSetLoco.Name = "buttonSetLoco";
            this.buttonSetLoco.Size = new System.Drawing.Size(110, 48);
            this.buttonSetLoco.TabIndex = 13;
            this.buttonSetLoco.Text = "Добавить локомотив";
            this.buttonSetLoco.UseVisualStyleBackColor = true;
            this.buttonSetLoco.Click += new System.EventHandler(this.buttonSetLoco_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // FormDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSetLoco);
            this.Controls.Add(this.buttonDelParking);
            this.Controls.Add(this.listBoxDepots);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTakeLoco);
            this.Controls.Add(this.pictureBoxDepot);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormDepot";
            this.Text = "Депо";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxDepot;
		private System.Windows.Forms.Button buttonTakeLoco;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.ListBox listBoxDepots;
        private System.Windows.Forms.Button buttonDelParking;
        private System.Windows.Forms.Button buttonSetLoco;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}