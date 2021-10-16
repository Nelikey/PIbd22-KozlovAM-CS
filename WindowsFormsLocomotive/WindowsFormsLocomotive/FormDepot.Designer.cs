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
            this.buttonSetBaseLoco = new System.Windows.Forms.Button();
            this.buttonSetLoco = new System.Windows.Forms.Button();
            this.buttonTakeLoco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDepot
            // 
            this.pictureBoxDepot.Location = new System.Drawing.Point(-1, 2);
            this.pictureBoxDepot.Name = "pictureBoxDepot";
            this.pictureBoxDepot.Size = new System.Drawing.Size(666, 445);
            this.pictureBoxDepot.TabIndex = 1;
            this.pictureBoxDepot.TabStop = false;
            // 
            // buttonSetBaseLoco
            // 
            this.buttonSetBaseLoco.Location = new System.Drawing.Point(678, 22);
            this.buttonSetBaseLoco.Name = "buttonSetBaseLoco";
            this.buttonSetBaseLoco.Size = new System.Drawing.Size(110, 45);
            this.buttonSetBaseLoco.TabIndex = 2;
            this.buttonSetBaseLoco.Text = "Поставить локомотив в депо";
            this.buttonSetBaseLoco.UseVisualStyleBackColor = true;
            this.buttonSetBaseLoco.Click += new System.EventHandler(this.buttonSetBaseLoco_Click);
            // 
            // buttonSetLoco
            // 
            this.buttonSetLoco.Location = new System.Drawing.Point(678, 73);
            this.buttonSetLoco.Name = "buttonSetLoco";
            this.buttonSetLoco.Size = new System.Drawing.Size(110, 43);
            this.buttonSetLoco.TabIndex = 3;
            this.buttonSetLoco.Text = "Поставить тепловоз в депо";
            this.buttonSetLoco.UseVisualStyleBackColor = true;
            this.buttonSetLoco.Click += new System.EventHandler(this.buttonSetLoco_Click);
            // 
            // buttonTakeLoco
            // 
            this.buttonTakeLoco.Location = new System.Drawing.Point(678, 176);
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
            this.label1.Location = new System.Drawing.Point(675, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Забрать локомотив";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(723, 150);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(65, 20);
            this.maskedTextBox.TabIndex = 7;
            // 
            // FormDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTakeLoco);
            this.Controls.Add(this.buttonSetLoco);
            this.Controls.Add(this.buttonSetBaseLoco);
            this.Controls.Add(this.pictureBoxDepot);
            this.Name = "FormDepot";
            this.Text = "Депо";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxDepot;
		private System.Windows.Forms.Button buttonSetBaseLoco;
		private System.Windows.Forms.Button buttonSetLoco;
		private System.Windows.Forms.Button buttonTakeLoco;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox;
	}
}