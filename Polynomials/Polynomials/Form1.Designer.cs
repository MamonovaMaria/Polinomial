namespace Polynomials
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
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.firstPolinomial = new System.Windows.Forms.TextBox();
			this.secondPolinomial = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.buttonForSecomdtPolimom = new System.Windows.Forms.Button();
			this.buttonForFirstPolimom = new System.Windows.Forms.Button();
			this.buttonForSummation = new System.Windows.Forms.Button();
			this.buttonForSubtraction = new System.Windows.Forms.Button();
			this.textBoxForResult = new System.Windows.Forms.TextBox();
			this.buttonForSave = new System.Windows.Forms.Button();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
			this.buttonForStart = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// firstPolinomial
			// 
			this.firstPolinomial.Location = new System.Drawing.Point(12, 52);
			this.firstPolinomial.Multiline = true;
			this.firstPolinomial.Name = "firstPolinomial";
			this.firstPolinomial.Size = new System.Drawing.Size(329, 94);
			this.firstPolinomial.TabIndex = 2;
			this.firstPolinomial.TextChanged += new System.EventHandler(this.firstPolinomial_TextChanged);
			// 
			// secondPolinomial
			// 
			this.secondPolinomial.Location = new System.Drawing.Point(375, 52);
			this.secondPolinomial.Multiline = true;
			this.secondPolinomial.Name = "secondPolinomial";
			this.secondPolinomial.Size = new System.Drawing.Size(337, 94);
			this.secondPolinomial.TabIndex = 3;
			this.secondPolinomial.TextChanged += new System.EventHandler(this.secondPolinomial_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(169, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(385, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Введите коэффициенты многочленов";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialogForLoad";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// buttonForSecomdtPolimom
			// 
			this.buttonForSecomdtPolimom.Location = new System.Drawing.Point(375, 152);
			this.buttonForSecomdtPolimom.Name = "buttonForSecomdtPolimom";
			this.buttonForSecomdtPolimom.Size = new System.Drawing.Size(75, 23);
			this.buttonForSecomdtPolimom.TabIndex = 5;
			this.buttonForSecomdtPolimom.Text = "Загрузить";
			this.buttonForSecomdtPolimom.UseVisualStyleBackColor = true;
			this.buttonForSecomdtPolimom.Click += new System.EventHandler(this.buttonForSecomdtPolimom_Click);
			// 
			// buttonForFirstPolimom
			// 
			this.buttonForFirstPolimom.Location = new System.Drawing.Point(12, 152);
			this.buttonForFirstPolimom.Name = "buttonForFirstPolimom";
			this.buttonForFirstPolimom.Size = new System.Drawing.Size(75, 23);
			this.buttonForFirstPolimom.TabIndex = 6;
			this.buttonForFirstPolimom.Text = "Загрузить";
			this.buttonForFirstPolimom.UseVisualStyleBackColor = true;
			this.buttonForFirstPolimom.Click += new System.EventHandler(this.buttonForFirstPolimom_Click);
			// 
			// buttonForSummation
			// 
			this.buttonForSummation.Enabled = false;
			this.buttonForSummation.Location = new System.Drawing.Point(114, 242);
			this.buttonForSummation.Name = "buttonForSummation";
			this.buttonForSummation.Size = new System.Drawing.Size(218, 22);
			this.buttonForSummation.TabIndex = 7;
			this.buttonForSummation.Text = "Сложить";
			this.buttonForSummation.UseVisualStyleBackColor = true;
			this.buttonForSummation.Click += new System.EventHandler(this.buttonForSummation_Click);
			// 
			// buttonForSubtraction
			// 
			this.buttonForSubtraction.Enabled = false;
			this.buttonForSubtraction.Location = new System.Drawing.Point(387, 242);
			this.buttonForSubtraction.Name = "buttonForSubtraction";
			this.buttonForSubtraction.Size = new System.Drawing.Size(210, 22);
			this.buttonForSubtraction.TabIndex = 8;
			this.buttonForSubtraction.Text = "Вычесть";
			this.buttonForSubtraction.UseVisualStyleBackColor = true;
			this.buttonForSubtraction.Click += new System.EventHandler(this.buttonForSubtraction_Click);
			// 
			// textBoxForResult
			// 
			this.textBoxForResult.Enabled = false;
			this.textBoxForResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxForResult.Location = new System.Drawing.Point(54, 287);
			this.textBoxForResult.Multiline = true;
			this.textBoxForResult.Name = "textBoxForResult";
			this.textBoxForResult.Size = new System.Drawing.Size(621, 136);
			this.textBoxForResult.TabIndex = 9;
			// 
			// buttonForSave
			// 
			this.buttonForSave.Enabled = false;
			this.buttonForSave.Location = new System.Drawing.Point(323, 429);
			this.buttonForSave.Name = "buttonForSave";
			this.buttonForSave.Size = new System.Drawing.Size(75, 23);
			this.buttonForSave.TabIndex = 10;
			this.buttonForSave.Text = "Сохранить";
			this.buttonForSave.UseVisualStyleBackColor = true;
			this.buttonForSave.Click += new System.EventHandler(this.buttonForSave_Click);
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.FileName = "openFileDialogForLoad";
			this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
			// 
			// openFileDialog3
			// 
			this.openFileDialog3.FileName = "openFileDialogForLoad";
			this.openFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog3_FileOk);
			// 
			// buttonForStart
			// 
			this.buttonForStart.Location = new System.Drawing.Point(12, 194);
			this.buttonForStart.Name = "buttonForStart";
			this.buttonForStart.Size = new System.Drawing.Size(708, 22);
			this.buttonForStart.TabIndex = 11;
			this.buttonForStart.Text = "Начать";
			this.buttonForStart.UseVisualStyleBackColor = true;
			this.buttonForStart.Click += new System.EventHandler(this.buttonForStart_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 464);
			this.Controls.Add(this.buttonForStart);
			this.Controls.Add(this.buttonForSave);
			this.Controls.Add(this.textBoxForResult);
			this.Controls.Add(this.buttonForSubtraction);
			this.Controls.Add(this.buttonForSummation);
			this.Controls.Add(this.buttonForFirstPolimom);
			this.Controls.Add(this.buttonForSecomdtPolimom);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.secondPolinomial);
			this.Controls.Add(this.firstPolinomial);
			this.Name = "Form1";
			this.Text = "Polynomials";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox firstPolinomial;
        private System.Windows.Forms.TextBox secondPolinomial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonForSecomdtPolimom;
        private System.Windows.Forms.Button buttonForFirstPolimom;
        private System.Windows.Forms.Button buttonForSummation;
        private System.Windows.Forms.Button buttonForSubtraction;
        private System.Windows.Forms.TextBox textBoxForResult;
        private System.Windows.Forms.Button buttonForSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
		private System.Windows.Forms.Button buttonForStart;
	}
}

