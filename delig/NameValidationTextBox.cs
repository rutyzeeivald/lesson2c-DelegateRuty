using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace delig
{
    //delegate void InvalidKeyPressedEvent();
    internal class NameValidationTextBox:TextBox
    {
        public EventHandler InvalidKeyPressed;
        //public event InvalidKeyPressedEvent InvalidKeyPressed;
        public NameValidationTextBox()
        {
            KeyPress += NameValidationTextBox_KeyPress;
        }

        private void NameValidationTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            string st = " \\<>\"?*:/";
            if (st.Contains(e.KeyChar))
                InvalidKeyPressed(sender,e);

        }
    }
}
