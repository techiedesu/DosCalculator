using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DosCalculator.Extensions;
using MathNet.Symbolics;
using WpfMath;

namespace DosCalculator.FormControls
{
    public partial class ProbabilitiesUserControl : UserControl
    {
        private Expression[] _probabilities;

        public ProbabilitiesUserControl()
        {
            InitializeComponent();
        }

        private void ProbabilitiesListBox_AnyChange(object sender, EventArgs e)
        {
            Calculate();
        }

        public void ApplyCoefficients(Expression[] probabilities)
        {
            _probabilities = probabilities;

            for (var i = probabilitiesListBox.Items.Count - 1; i >= 0; i--)
            {
                probabilitiesListBox.Items.RemoveAt(i);
            }

            for (var i = 0; i < _probabilities.Length; i++)
            {
                probabilitiesListBox.Items.Add($"π{i + 1} = {Infix.Format(probabilities[i])}");
            }
        }

        public void Calculate()
        {
            var goodProbabilities = new List<Expression>();

            for (var i = 0; i < probabilitiesListBox.CheckedItems.Count; i++)
            {
                goodProbabilities.Add(_probabilities[i]);
            }

            var sumOfProbabilities = _probabilities.Aggregate((sumOfP, p) => sumOfP + p);
            var availabilityCoefficient = goodProbabilities.Any() ? goodProbabilities.Aggregate((sumOfP, p) => sumOfP + p) / sumOfProbabilities : 0;
            var unavailabilityCoefficient = 1 - availabilityCoefficient;

            var parser = new TexFormulaParser();

            var readyFormula = parser.Parse(@"\text{К}_{\text{Г}} = " + Algebraic.Expand(availabilityCoefficient).AsLatex());
            ApplyTexFormulaToPictureBox(readyFormula, readyPictureBox);
            var notReadyFormula = parser.Parse(@"\text{К}_{\text{Н}} = " + Algebraic.Expand(unavailabilityCoefficient).AsLatex());
            ApplyTexFormulaToPictureBox(notReadyFormula, notReadyPictureBox);
            var checkFormula = parser.Parse(@"\text{К}_{\text{Г}} + \text{К}_{\text{Н}} = " + Algebraic.Expand(availabilityCoefficient + unavailabilityCoefficient).AsLatex());
            ApplyTexFormulaToPictureBox(checkFormula, checkPictureBox);
        }

        private static void ApplyTexFormulaToPictureBox(TexFormula texFormula, PictureBox pictureBox)
        {
            using var checkFormulaStream = new MemoryStream(texFormula.RenderToPng(200.0, 0.0, 0.0, "Arial"));
            pictureBox.Image = Image.FromStream(checkFormulaStream);
        }
    }
}