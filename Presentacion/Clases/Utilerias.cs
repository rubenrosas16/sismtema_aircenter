using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Presentacion
{
    public static class Utilerias
    {

        public static void SiguienteControl( System.Windows.Forms.Control control, ref System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                control.Focus();
            }
        }

        public static void SoloEnteros(System.Windows.Forms.TextBox textBox)
        {
            if (textBox.Focused && System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9]"))
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }
        public static bool HayConexionInternet()
        {
            try
            {
                System.Net.NetworkInformation.Ping pruebaPing = new System.Net.NetworkInformation.Ping();
                string host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                System.Net.NetworkInformation.PingOptions pingOptions = new System.Net.NetworkInformation.PingOptions();
                System.Net.NetworkInformation.PingReply reply = pruebaPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == System.Net.NetworkInformation.IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void EsTeclaNumerica(System.Windows.Forms.TextBox textBox, ref System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (textBox.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
