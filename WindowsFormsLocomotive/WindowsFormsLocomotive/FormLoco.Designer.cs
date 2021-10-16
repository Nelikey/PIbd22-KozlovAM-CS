
namespace WindowsFormsLocomotive
{
    partial class FormLoco
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.buttonCreateBaseLoco = new System.Windows.Forms.Button();
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.pictureBoxLocos = new System.Windows.Forms.PictureBox();
			this.buttonCreateLoco = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocos)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonCreateBaseLoco
			// 
			this.buttonCreateBaseLoco.Location = new System.Drawing.Point(12, 12);
			this.buttonCreateBaseLoco.Name = "buttonCreateBaseLoco";
			this.buttonCreateBaseLoco.Size = new System.Drawing.Size(132, 23);
			this.buttonCreateBaseLoco.TabIndex = 1;
			this.buttonCreateBaseLoco.Text = "Создать локомотив";
			this.buttonCreateBaseLoco.UseVisualStyleBackColor = true;
			this.buttonCreateBaseLoco.Click += new System.EventHandler(this.buttonCreateBaseLoco_Click);
			// 
			// buttonRight
			// 
			this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRight.BackgroundImage = global::WindowsFormsLocomotive.Properties.Resources.arrowRight;
			this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonRight.Location = new System.Drawing.Point(819, 368);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(30, 30);
			this.buttonRight.TabIndex = 5;
			this.buttonRight.UseVisualStyleBackColor = true;
			this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDown.BackgroundImage = global::WindowsFormsLocomotive.Properties.Resources.arrowDown;
			this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonDown.Location = new System.Drawing.Point(786, 404);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(30, 30);
			this.buttonDown.TabIndex = 4;
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonLeft
			// 
			this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLeft.BackgroundImage = global::WindowsFormsLocomotive.Properties.Resources.arrowLeft;
			this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonLeft.Location = new System.Drawing.Point(755, 368);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(30, 30);
			this.buttonLeft.TabIndex = 3;
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonUp
			// 
			this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUp.BackgroundImage = global::WindowsFormsLocomotive.Properties.Resources.arrowUp2;
			this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUp.Location = new System.Drawing.Point(786, 332);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(30, 30);
			this.buttonUp.TabIndex = 2;
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// pictureBoxLocos
			// 
			this.pictureBoxLocos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxLocos.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxLocos.Name = "pictureBoxLocos";
			this.pictureBoxLocos.Size = new System.Drawing.Size(884, 461);
			this.pictureBoxLocos.TabIndex = 0;
			this.pictureBoxLocos.TabStop = false;
			// 
			// buttonCreateLoco
			// 
			this.buttonCreateLoco.Location = new System.Drawing.Point(150, 12);
			this.buttonCreateLoco.Name = "buttonCreateLoco";
			this.buttonCreateLoco.Size = new System.Drawing.Size(129, 23);
			this.buttonCreateLoco.TabIndex = 6;
			this.buttonCreateLoco.Text = "Создать тепловоз";
			this.buttonCreateLoco.UseVisualStyleBackColor = true;
			this.buttonCreateLoco.Click += new System.EventHandler(this.buttonCreateLoco_Click);
			// 
			// FormLoco
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 461);
			this.Controls.Add(this.buttonCreateLoco);
			this.Controls.Add(this.buttonRight);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonLeft);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.buttonCreateBaseLoco);
			this.Controls.Add(this.pictureBoxLocos);
			this.Name = "FormLoco";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Тепловоз";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocos)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLocos;
        private System.Windows.Forms.Button buttonCreateBaseLoco;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonCreateLoco;
    }
}

