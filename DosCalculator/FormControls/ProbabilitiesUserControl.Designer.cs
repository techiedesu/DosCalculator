
namespace DosCalculator.FormControls
{
    partial class ProbabilitiesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.probabilitiesListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.readyPictureBox = new System.Windows.Forms.PictureBox();
            this.notReadyPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkPictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notReadyPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // probabilitiesListBox
            // 
            this.probabilitiesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.probabilitiesListBox.FormattingEnabled = true;
            this.probabilitiesListBox.Location = new System.Drawing.Point(3, 19);
            this.probabilitiesListBox.Name = "probabilitiesListBox";
            this.probabilitiesListBox.Size = new System.Drawing.Size(707, 147);
            this.probabilitiesListBox.TabIndex = 0;
            this.probabilitiesListBox.Click += new System.EventHandler(this.ProbabilitiesListBox_AnyChange);
            this.probabilitiesListBox.SelectedValueChanged += new System.EventHandler(this.ProbabilitiesListBox_AnyChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.probabilitiesListBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "4. Выберите предельные вероятности для расчёта Кг";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 414);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "5. Результаты";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 19);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(707, 392);
            this.splitContainer2.SplitterDistance = 270;
            this.splitContainer2.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.readyPictureBox);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.notReadyPictureBox);
            this.splitContainer3.Size = new System.Drawing.Size(707, 270);
            this.splitContainer3.SplitterDistance = 135;
            this.splitContainer3.TabIndex = 3;
            // 
            // readyPictureBox
            // 
            this.readyPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readyPictureBox.Location = new System.Drawing.Point(0, 0);
            this.readyPictureBox.Name = "readyPictureBox";
            this.readyPictureBox.Size = new System.Drawing.Size(707, 135);
            this.readyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.readyPictureBox.TabIndex = 1;
            this.readyPictureBox.TabStop = false;
            // 
            // notReadyPictureBox
            // 
            this.notReadyPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notReadyPictureBox.Location = new System.Drawing.Point(0, 0);
            this.notReadyPictureBox.Name = "notReadyPictureBox";
            this.notReadyPictureBox.Size = new System.Drawing.Size(707, 131);
            this.notReadyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notReadyPictureBox.TabIndex = 2;
            this.notReadyPictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkPictureBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(707, 118);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Проверка результата";
            // 
            // checkPictureBox
            // 
            this.checkPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkPictureBox.Location = new System.Drawing.Point(3, 19);
            this.checkPictureBox.Name = "checkPictureBox";
            this.checkPictureBox.Size = new System.Drawing.Size(701, 96);
            this.checkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.checkPictureBox.TabIndex = 0;
            this.checkPictureBox.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(713, 587);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 3;
            // 
            // ProbabilitiesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ProbabilitiesUserControl";
            this.Size = new System.Drawing.Size(713, 587);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notReadyPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkPictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox probabilitiesListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox readyPictureBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PictureBox notReadyPictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox checkPictureBox;
    }
}
