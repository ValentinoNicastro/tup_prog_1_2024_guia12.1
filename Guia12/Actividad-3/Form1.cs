using Actividad_3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Codigo codigo = new Codigo();

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            datoscont datos = new datoscont();

            if (datos.ShowDialog() == DialogResult.OK)
            {
                codigo.AgregarCont(Convert.ToInt32(datos.nmID.Text), Convert.ToDouble(datos.nmPeso.Text), datos.cbPais.Text);
            }

            datos.Dispose();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            formver ver = new formver();

            codigo.Ordenar();

            for (int i = 0; i < codigo.cont; i++) 
            {
                ver.lbResult.Items.Add($"{codigo.ids[i]} - {codigo.origen[i]} - {codigo.peso[i]}");
            }

            ver.ShowDialog();

            ver.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formver formver = new formver();

            int[] listado = new int[100];

            formver.lbResult.Items.Clear();

            int cantidad = 0;
            listado = codigo.BusquedaOrigen(cbOrigen.Text, ref cantidad);

            for (int i = 0; i < cantidad; i++)
            {
                int idx = listado[i];
                int id = codigo.ids[idx];
                string origen = codigo.origen[idx];
                double peso = codigo.peso[idx];
                formver.lbResult.Items.Add($"{id} - {origen} - {peso:f2}");
            }

            formver.ShowDialog();

            formver.Dispose();
        }
    }
}
