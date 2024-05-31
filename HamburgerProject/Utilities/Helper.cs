using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerProject.Utilities
{
    public class Helper
    {
        public static void Temizle(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is ComboBox)
                {
                    ComboBox cmb = (ComboBox)control;
                    cmb.SelectedIndex = 0;
                }
                else if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
                else if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Text == "Küçük")
                        radioButton.Checked = true;
                    else
                        radioButton.Checked = false;
                }
                else if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.Clear();
                }
                else if (control is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)control;
                    nud.Value = 0;
                }
                else if (control is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)control;
                    Temizle(groupBox.Controls);
                }
                else if (control is FlowLayoutPanel)
                {
                    FlowLayoutPanel flowLayoutPanel = control as FlowLayoutPanel;
                    Temizle(flowLayoutPanel.Controls);
                }
            }
        }

    }
}
