using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DosCalculator.Core;
using DosCalculator.Core.Expressions;
using DosCalculator.Events;
using DosCalculator.Extensions;

namespace DosCalculator.FormControls
{
    public partial class MatrixUserControl : UserControl
    {
        public const int MaximumElementsPerDimension = 12;
        private readonly Dictionary<int, List<ColoredRichTextBox>> _textBoxes = new();
        private bool _isMatrixValid;

        public bool ShowWarningDialog = false;
        public int HorizontalElementCount { get; private set; } = 5;
        public int VerticalElementCount { get; private set; } = 5;
        public bool ReplaceToGreece { get; set; }
        public bool HasAnyChanges => _textBoxes.Any(t => t.Value.Any(tb => !tb.Text.IsEmpty()));

        public MatrixUserControl()
        {
            if (HorizontalElementCount > MaximumElementsPerDimension || VerticalElementCount > MaximumElementsPerDimension)
                throw new ArgumentException("Используйте импорт");

            CreateTextBoxes();
            InitializeComponent();
        }

        public int GetVerticalElementCount()
        {
            return VerticalElementCount;
        }

        public int GetHorizontalElementCount()
        {
            return HorizontalElementCount;
        }

        public string[,] GetMatrix()
        {
            var array = new string[_textBoxes.Count, _textBoxes.First().Value.Count];

            for (var i = 0; i < _textBoxes.Count; i++)
            {
                for (var j = 0; j < _textBoxes[i].Count; j++)
                {
                    var textBox = _textBoxes[i][j];
                    array[i, j] = textBox.Text;
                }
            }

            return array;
        }

        private void CreateTextBoxes()
        {
            for (var horizontalPos = 0; horizontalPos < VerticalElementCount; horizontalPos++)
            {
                for (var verticalPos = 0; verticalPos < HorizontalElementCount; verticalPos++)
                {
                    CreateTextBox(verticalPos, horizontalPos, false);
                }
            }

            GetMatrix();
        }

        public void RemoveVertical()
        {
            var actualVerticalTextBoxCount = GetVerticalTextBoxCount();
            var actualHorizontalTextBoxCount = GetHorizontalTextBoxCount();

            for (var h = 0; h < actualHorizontalTextBoxCount; h++)
            {
                DeleteTextBox(actualVerticalTextBoxCount - 1, h);
            }
        }

        public void RemoveHorizontal()
        {
            var actualVerticalTextBoxCount = GetVerticalTextBoxCount();
            var actualHorizontalTextBoxCount = GetHorizontalTextBoxCount();

            for (var v = actualVerticalTextBoxCount - 1; v >= 0; v--)
            {
                DeleteTextBox(v, actualHorizontalTextBoxCount - 1);
            }
        }

        public void AddVertical()
        {
            var actualVerticalTextBoxCount = GetVerticalTextBoxCount();
            var actualHorizontalTextBoxCount = GetHorizontalTextBoxCount();

            for (var h = 0; h < actualHorizontalTextBoxCount; h++)
            {
                CreateTextBox(actualVerticalTextBoxCount, h);
            }
        }

        public void AddHorizontal()
        {
            var actualVerticalTextBoxCount = GetVerticalTextBoxCount();
            var actualHorizontalTextBoxCount = GetHorizontalTextBoxCount();

            for (var v = 0; v < actualVerticalTextBoxCount; v++)
            {
                CreateTextBox(v, actualHorizontalTextBoxCount);
            }
        }

        private void CreateTextBox(int verticalPos, int horizontalPos, bool modifyCounter = true)
        {
            const int paddingTopBottom = 15;
            const int paddingLeftRight = 15;

            const int verticalTextBoxSpacing = 70;
            const int horizontalTextBoxSpacing = 35;

            var textBox = new ColoredRichTextBox
            {
                Location = new Point(verticalPos * verticalTextBoxSpacing + paddingTopBottom, horizontalPos * horizontalTextBoxSpacing + paddingLeftRight),
                Size = new Size(60, 23),
                Multiline = false,
                BorderStyle = BorderStyle.Fixed3D,
                TabIndex = verticalPos + 100 * horizontalPos,
                BorderColor = Color.Red,
            };

            textBox.KeyPress += TextBox_KeyPress;
            textBox.KeyUp += TextBox_KeyUp;

            if (!_textBoxes.ContainsKey(horizontalPos))
                _textBoxes.Add(horizontalPos, new List<ColoredRichTextBox>());

            _textBoxes[horizontalPos].Add(textBox);
            Controls.Add(textBox);

            if(modifyCounter)
            {
                HorizontalElementCount = GetHorizontalTextBoxCount();
                VerticalElementCount = GetVerticalTextBoxCount();
            }
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateCalculateButton();
        }

        private void DeleteTextBox(int verticalPos, int horizontalPos)
        {
            var horizontalTextBoxes = _textBoxes[horizontalPos];
            var textBox = horizontalTextBoxes[verticalPos];

            horizontalTextBoxes.Remove(textBox);
            Controls.Remove(textBox);

            if (!horizontalTextBoxes.Any())
                _textBoxes.Remove(horizontalPos);

            HorizontalElementCount = GetHorizontalTextBoxCount();
            VerticalElementCount = GetVerticalTextBoxCount();
        }

        private int GetVerticalTextBoxCount()
        {
            return _textBoxes.First().Value.Count;
        }

        private int GetHorizontalTextBoxCount()
        {
            return _textBoxes.Count;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ReplaceToGreece)
            {
                var richTextBox = (ColoredRichTextBox) sender;
                var inputKey = e.KeyChar;

                if (GreekSymbols.SymbolsDictionary.ContainsKey(inputKey))
                {
                    richTextBox.Text += GreekSymbols.SymbolsDictionary[inputKey];
                    richTextBox.SelectionStart = richTextBox.Text.Length;
                    e.Handled = true;
                }
            }
        }

        private void ValidateCalculateButton()
        {
            var isMatrixValid = _textBoxes.All(t => t.Value.All(tt => tt.HasValidExpression()));

            if (_isMatrixValid != isMatrixValid)
            {
                MatrixValidationStateHandler?.Invoke(this, new MatrixValidationStateChanged { Valid = isMatrixValid });
                _isMatrixValid = isMatrixValid;
            }
        }

        public delegate void MatrixValidationStateEventHandler(object sender, MatrixValidationStateChanged e);
        public event MatrixValidationStateEventHandler MatrixValidationStateHandler;

        private void MatrixUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}