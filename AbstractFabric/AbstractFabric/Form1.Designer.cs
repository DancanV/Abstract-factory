namespace AbstractFabric
{
    partial class Form1
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
            this.BtLevel2 = new System.Windows.Forms.Button();
            this.PbMaps = new System.Windows.Forms.PictureBox();
            this.PbCargo = new System.Windows.Forms.PictureBox();
            this.PbCars = new System.Windows.Forms.PictureBox();
            this.BtLevel3 = new System.Windows.Forms.Button();
            this.BtLevel1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbMaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCars)).BeginInit();
            this.SuspendLayout();
            // 
            // BtLevel2
            // 
            this.BtLevel2.Location = new System.Drawing.Point(519, 210);
            this.BtLevel2.Name = "BtLevel2";
            this.BtLevel2.Size = new System.Drawing.Size(143, 61);
            this.BtLevel2.TabIndex = 4;
            this.BtLevel2.Text = "Level2";
            this.BtLevel2.UseVisualStyleBackColor = true;
            this.BtLevel2.Click += new System.EventHandler(this.BtLevel2_Click);
            // 
            // PbMaps
            // 
            this.PbMaps.Location = new System.Drawing.Point(77, 330);
            this.PbMaps.Name = "PbMaps";
            this.PbMaps.Size = new System.Drawing.Size(165, 108);
            this.PbMaps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMaps.TabIndex = 13;
            this.PbMaps.TabStop = false;
            // 
            // PbCargo
            // 
            this.PbCargo.Location = new System.Drawing.Point(77, 184);
            this.PbCargo.Name = "PbCargo";
            this.PbCargo.Size = new System.Drawing.Size(165, 108);
            this.PbCargo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCargo.TabIndex = 12;
            this.PbCargo.TabStop = false;
            // 
            // PbCars
            // 
            this.PbCars.Location = new System.Drawing.Point(77, 37);
            this.PbCars.Name = "PbCars";
            this.PbCars.Size = new System.Drawing.Size(165, 108);
            this.PbCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCars.TabIndex = 0;
            this.PbCars.TabStop = false;
            // 
            // BtLevel3
            // 
            this.BtLevel3.Location = new System.Drawing.Point(513, 345);
            this.BtLevel3.Name = "BtLevel3";
            this.BtLevel3.Size = new System.Drawing.Size(149, 60);
            this.BtLevel3.TabIndex = 14;
            this.BtLevel3.Text = "Level3";
            this.BtLevel3.UseVisualStyleBackColor = true;
            this.BtLevel3.Click += new System.EventHandler(this.BtLevel3_Click);
            // 
            // BtLevel1
            // 
            this.BtLevel1.Location = new System.Drawing.Point(519, 65);
            this.BtLevel1.Name = "BtLevel1";
            this.BtLevel1.Size = new System.Drawing.Size(143, 61);
            this.BtLevel1.TabIndex = 15;
            this.BtLevel1.Text = "Level1";
            this.BtLevel1.UseVisualStyleBackColor = true;
            this.BtLevel1.Click += new System.EventHandler(this.BtLevel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtLevel1);
            this.Controls.Add(this.BtLevel3);
            this.Controls.Add(this.PbMaps);
            this.Controls.Add(this.PbCargo);
            this.Controls.Add(this.BtLevel2);
            this.Controls.Add(this.PbCars);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbMaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbCars;
        private System.Windows.Forms.Button BtLevel2;
        private System.Windows.Forms.PictureBox PbCargo;
        private System.Windows.Forms.PictureBox PbMaps;
        private System.Windows.Forms.Button BtLevel3;
        private System.Windows.Forms.Button BtLevel1;
    }
}

