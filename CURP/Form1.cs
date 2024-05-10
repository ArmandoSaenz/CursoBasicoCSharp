using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURP
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> Estados = new Dictionary<string, string>()
        {
            { "Aguascalientes", "AS" },
            { "Baja California", "BC" },
            { "Baja California Sur", "BS" },
            { "Campeche", "CC" },
            { "Coahuila de Zaragoza", "CL" }
        };
        public Form1()
        {
            InitializeComponent();
            string[] estados = Estados.Keys.ToArray();
            //estados = ["Aguscalientes", "Baja California", "Baja California Sur", "Campeche", "Coahuila de Zaragosa"]
            foreach(string estado in estados)
            {
                cbEstados.Items.Add(estado);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string curp;
            char[] vocales = { 'A', 'E', 'I', 'O', 'U' };
            curp = tbApellidoPaterno.Text.Substring(0, 1);
            curp += tbApellidoPaterno.Text.Substring(1).First(letra => vocales.Contains(letra)).ToString();
            curp += tbApellidoMaterno.Text.Substring(0, 1);
            curp += tbPrimerNombre.Text.Substring(0, 1);
            curp += dtpNacimiento.Value.ToString("yyMMdd");
            curp += rbHombre.Checked ? "H" : "M";
            curp += Estados[cbEstados.Text];
            lCURP.Text = curp;
        }
    }
}
