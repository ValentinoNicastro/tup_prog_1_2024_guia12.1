using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad.Models;

namespace Actividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Codigo code = new Codigo();

      

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Comp comp = new Comp();

            if (comp.ShowDialog() == DialogResult.OK)
            {
                code.AgregarComp(comp.tbNombre.Text);
            }

        }

        private void btnTiempos_Click(object sender, EventArgs e)
        {

            Tiempos ftiempos = new Tiempos();

            for (int i = 0; i < code.cont; i++)
            {
                ftiempos.label2.Text = i.ToString();

                ftiempos.ShowDialog();

                code.Tiempos(Convert.ToInt32(ftiempos.hh.Text), Convert.ToInt32(ftiempos.mm.Text), i);
            }

            ftiempos.Dispose();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Resultados resultados = new Resultados();

            code.Ordenar();

            for(int i = 0; i < code.cont;i++)
            {
                resultados.lbResultados.Items.Add($"{i.ToString() + " - " + Convert.ToString(code.competidores[i]) + " - " + Convert.ToString(code.tiempos[i])}");

            }

            resultados.ShowDialog();
        }
    }
}
