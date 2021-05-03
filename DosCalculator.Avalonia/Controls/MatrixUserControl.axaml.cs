using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DosCalculator.Avalonia.Controls
{
    public class MatrixUserControl : UserControl
    {
        private readonly Dictionary<int, List<TextBox>> _textBoxes = new();
        private readonly StackPanel _stackPanel;

        public MatrixUserControl()
        {
            InitializeComponent();

            _stackPanel = new StackPanel();
            //Content = _stackPanel;

            //for (var i = 0; i < 10; i++)
            //{
            //    CreateTextBox(0, i);
            //}
        }


        public void ExtendMatrix()
        {

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void CreateTextBox(int verticalPos, int horizontalPos, bool modifyCounter = true)
        {
            const int paddingTopBottom = 15;
            const int paddingLeftRight = 15;

            const int verticalTextBoxSpacing = 70;
            const int horizontalTextBoxSpacing = 35;

            var textBox = new TextBox
            {
                //Location = new Point(verticalPos * verticalTextBoxSpacing + paddingTopBottom, horizontalPos * horizontalTextBoxSpacing + paddingLeftRight),
                //Size = new Size(60, 23),
                //Multiline = false,
                //BorderStyle = BorderStyle.Fixed3D,
                //TabIndex = verticalPos + 100 * horizontalPos,
                //BorderColor = Color.Red,
            };

            if (!_textBoxes.ContainsKey(horizontalPos))
                _textBoxes.Add(horizontalPos, new List<TextBox>());

            _textBoxes[horizontalPos].Add(textBox);
            _stackPanel.Children.Add(textBox);

        }
    }
}
