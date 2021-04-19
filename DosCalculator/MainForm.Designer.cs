
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.calculateButton = new System.Windows.Forms.Button();
            this.greeceReplacementCheckBox = new System.Windows.Forms.CheckBox();
            this.probabilitiesUserControl1 = new DosCalculator.FormControls.ProbabilitiesUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // matrixUserControl
            // 
            this.matrixUserControl.AutoSize = true;
            this.matrixUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixUserControl.Location = new System.Drawing.Point(0, 0);
            this.matrixUserControl.Name = "matrixUserControl";
            this.matrixUserControl.ReplaceToGreece = false;
            this.matrixUserControl.Size = new System.Drawing.Size(609, 374);
            this.matrixUserControl.TabIndex = 2;
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(12, 12);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(75, 23);
            this.plusButton.TabIndex = 3;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(12, 41);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(75, 23);
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
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.probabilitiesUserControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.matrixUserControl);
            this.splitContainer1.Size = new System.Drawing.Size(1013, 374);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.plusButton);
            this.panel1.Controls.Add(this.minusButton);
            this.panel1.Controls.Add(this.calculateButton);
            this.panel1.Controls.Add(this.greeceReplacementCheckBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 120);
            this.panel1.TabIndex = 11;
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(12, 70);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(312, 35);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Расчёт вероятностей";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // greeceReplacementCheckBox
            // 
            this.greeceReplacementCheckBox.AutoSize = true;
            this.greeceReplacementCheckBox.Location = new System.Drawing.Point(175, 9);
            this.greeceReplacementCheckBox.Name = "greeceReplacementCheckBox";
            this.greeceReplacementCheckBox.Size = new System.Drawing.Size(137, 19);
            this.greeceReplacementCheckBox.TabIndex = 9;
            this.greeceReplacementCheckBox.Text = "Греческие символы";
            this.greeceReplacementCheckBox.UseVisualStyleBackColor = true;
            this.greeceReplacementCheckBox.CheckedChanged += new System.EventHandler(this.greeceReplacementCheckBox_CheckedChanged);
            // 
            // probabilitiesUserControl1
            // 
            this.probabilitiesUserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.probabilitiesUserControl1.Location = new System.Drawing.Point(0, 144);
            this.probabilitiesUserControl1.Name = "probabilitiesUserControl1";
            this.probabilitiesUserControl1.Size = new System.Drawing.Size(400, 230);
            this.probabilitiesUserControl1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 374);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Программное решение расчёта показателей надёжности технических систем на основе м" +
    "арковских моделей";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
    }
}