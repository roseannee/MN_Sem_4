using System.Windows.Forms;

namespace Newton_s_Interpolation
{
    internal class Validation
    {
        public static void IntValidation(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != ',' && e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
