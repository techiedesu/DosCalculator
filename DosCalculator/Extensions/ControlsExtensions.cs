using System.Windows.Forms;

namespace DosCalculator.Extensions
{
    public static class ControlsExtensions
    {
        public static RichTextBox AsRichTextBox(this object self)
        {
            return (RichTextBox) self;
        }

        public static CheckBox AsCheckBox(this object self)
        {
            return (CheckBox) self;
        }
    }
}