
namespace DosCalculator
{
    partial class MainForm
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
            this.matrixUserControl = new DosCalculator.FormControls.MatrixUserControl();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.greeceReplacementCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.probabilitiesUserControl1 = new DosCalculator.FormControls.ProbabilitiesUserControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // matrixUserControl
            // 
            this.matrixUserControl.AutoSize = true;
            this.matrixUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixUserControl.Location = new System.Drawing.Point(3, 27);
            this.matrixUserControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.matrixUserControl.Name = "matrixUserControl";
            this.matrixUserControl.ReplaceToGreece = false;
            this.matrixUserControl.Size = new System.Drawing.Size(864, 593);
            this.matrixUserControl.TabIndex = 2;
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(29, 32);
            this.plusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(107, 38);
            this.plusButton.TabIndex = 3;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(144, 32);
            this.minusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(107, 38);
            this.minusButton.TabIndex = 4;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.probabilitiesUserControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1447, 623);
            this.splitContainer1.SplitterDistance = 571;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.plusButton);
            this.groupBox4.Controls.Add(this.minusButton);
            this.groupBox4.Controls.Add(this.greeceReplacementCheckBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(571, 115);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "1. Установите размерность матрицы";
            // 
            // greeceReplacementCheckBox
            // 
            this.greeceReplacementCheckBox.AutoSize = true;
            this.greeceReplacementCheckBox.Location = new System.Drawing.Point(322, 32);
            this.greeceReplacementCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.greeceReplacementCheckBox.Name = "greeceReplacementCheckBox";
            this.greeceReplacementCheckBox.Size = new System.Drawing.Size(200, 29);
            this.greeceReplacementCheckBox.TabIndex = 9;
            this.greeceReplacementCheckBox.Text = "Греческие символы";
            this.greeceReplacementCheckBox.UseVisualStyleBackColor = true;
            this.greeceReplacementCheckBox.CheckedChanged += new System.EventHandler(this.GreeceReplacementCheckBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.calculateButton);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 81);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Выполните расчёт вероятностей";
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(7, 32);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(557, 41);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Расчёт вероятностей";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // probabilitiesUserControl1
            // 
            this.probabilitiesUserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.probabilitiesUserControl1.Location = new System.Drawing.Point(0, 196);
            this.probabilitiesUserControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.probabilitiesUserControl1.Name = "probabilitiesUserControl1";
            this.probabilitiesUserControl1.Size = new System.Drawing.Size(571, 427);
            this.probabilitiesUserControl1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.matrixUserControl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 623);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2. Заполните матрицу вероятности переходов";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 623);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.Text = "Программное решение расчёта показателей надёжности технических систем на основе м" +
    "арковских моделей";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FormControls.MatrixUserControl matrixUserControl;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox greeceReplacementCheckBox;
        private System.Windows.Forms.Button calculateButton;
        private FormControls.ProbabilitiesUserControl probabilitiesUserControl1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}