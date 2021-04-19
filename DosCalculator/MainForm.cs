using System;
using System.Linq;
using System.Windows.Forms;
using DosCalculator.Events;
using DosCalculator.Extensions;

namespace DosCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            FormClosing += MainForm_FormClosing;
            matrixUserControl.MatrixValidationStateHandler += MatrixUserControl_MatrixValidationStateHandler;
        }

        private void MatrixUserControl_MatrixValidationStateHandler(object sender, MatrixValidationStateChanged e)
        {
            this.calculateButton.Enabled = e.Valid;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ShouldFormClose())
                e.Cancel = true;
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            matrixUserControl.AddVertical();
            matrixUserControl.AddHorizontal();
            Validate();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            matrixUserControl.RemoveVertical();
            matrixUserControl.RemoveHorizontal();
            Validate();
        }

        private bool ShouldFormClose()
        {
            if (matrixUserControl.HasAnyChanges)
            {
                if (MessageBox.Show(@"Действительно выйти?", @"Внимание", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return false;
            }

            return true;
        }

        private void greeceReplacementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            matrixUserControl.ReplaceToGreece = sender.AsCheckBox().Checked;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var matrix = new ExpressionMatrix(matrixUserControl.VerticalElementCount, matrixUserControl.HorizontalElementCount);
            var userMatrix = matrixUserControl.GetMatrix();
            var matrixSingleSideLength = userMatrix.GetLength(0);

            for (var i = 0; i < matrixSingleSideLength; i++)
            {
                for (var j = 0; j < matrixSingleSideLength; j++)
                {
                    var x = userMatrix[i, j];
                    matrix.Set(i, j, x);
                }
            }

            var pies = Enumerable.Range(0, matrix.M).Select(i => matrix.CalculateSubmatrixDeterminant(i)).ToArray();
            probabilitiesUserControl1.ApplyCoefficients(pies);
        }
    }
}