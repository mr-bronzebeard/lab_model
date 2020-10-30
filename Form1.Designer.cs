namespace RegressionAnalysis
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.gridA = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFCrit = new System.Windows.Forms.TextBox();
            this.txtAvErr = new System.Windows.Forms.TextBox();
            this.txtDispertion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTable = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(8, 346);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(429, 36);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Открыть и рассчитать входные данные";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // gridA
            // 
            this.gridA.AllowUserToAddRows = false;
            this.gridA.AllowUserToDeleteRows = false;
            this.gridA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridA.Location = new System.Drawing.Point(4, 25);
            this.gridA.Name = "gridA";
            this.gridA.ReadOnly = true;
            this.gridA.Size = new System.Drawing.Size(438, 97);
            this.gridA.TabIndex = 1;
            this.gridA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridA_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFCrit);
            this.groupBox1.Controls.Add(this.txtAvErr);
            this.groupBox1.Controls.Add(this.txtDispertion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оценка качества модели";
            // 
            // txtFCrit
            // 
            this.txtFCrit.Location = new System.Drawing.Point(176, 74);
            this.txtFCrit.Name = "txtFCrit";
            this.txtFCrit.ReadOnly = true;
            this.txtFCrit.Size = new System.Drawing.Size(253, 20);
            this.txtFCrit.TabIndex = 5;
            // 
            // txtAvErr
            // 
            this.txtAvErr.Location = new System.Drawing.Point(176, 46);
            this.txtAvErr.Name = "txtAvErr";
            this.txtAvErr.ReadOnly = true;
            this.txtAvErr.Size = new System.Drawing.Size(253, 20);
            this.txtAvErr.TabIndex = 4;
            // 
            // txtDispertion
            // 
            this.txtDispertion.Location = new System.Drawing.Point(176, 20);
            this.txtDispertion.Name = "txtDispertion";
            this.txtDispertion.ReadOnly = true;
            this.txtDispertion.Size = new System.Drawing.Size(253, 20);
            this.txtDispertion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Критерий Фишера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Средняя относительная ошибка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дисперсия среднего";
            // 
            // gbTable
            // 
            this.gbTable.Controls.Add(this.gridA);
            this.gbTable.Location = new System.Drawing.Point(8, 106);
            this.gbTable.Name = "gbTable";
            this.gbTable.Size = new System.Drawing.Size(435, 122);
            this.gbTable.TabIndex = 4;
            this.gbTable.TabStop = false;
            this.gbTable.Text = "Искомые коэффициенты";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RegressionAnalysis.Properties.Resources.Безымянный;
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOpen);
            this.MaximumSize = new System.Drawing.Size(471, 431);
            this.MinimumSize = new System.Drawing.Size(471, 431);
            this.Name = "Form1";
            this.Text = "Лабораторная работа № 1";
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.DataGridView gridA;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtFCrit;
		private System.Windows.Forms.TextBox txtAvErr;
		private System.Windows.Forms.TextBox txtDispertion;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTable;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

