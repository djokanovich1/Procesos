using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enlazar();
        }
        BLL.PROCESO gestor_proceso = new BLL.PROCESO();
       List<BE.PROCESO> procesos = new List<BE.PROCESO>();

        public void enlazar() {
            ltbProcesos.DataSource = null;
            
            foreach (Process p in Process.GetProcesses()) {
                BE.PROCESO pro = new BE.PROCESO();
                BE.PARAMETRO par = new BE.PARAMETRO();
                BE.DETALLE deta = new BE.DETALLE();

                pro.id_proceso = p.Id;
                pro.proceso = p.ProcessName;
                pro.detalle = deta;

                par.nombre_parametro = p.Threads.Count.ToString();
                procesos.Add(pro);
                
                
            }
            ltbProcesos.DisplayMember = "Nombre";
            ltbProcesos.DataSource = procesos;
           
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Process.Start(txtAplicacion.Text, txtParametro.Text);
            enlazar();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (ltbProcesos.SelectedItems.Count > 0) {
                BE.PROCESO p = new BE.PROCESO();
                p = (BE.PROCESO)ltbProcesos.SelectedItem;
                Process.GetProcessById(p.id_proceso).Kill();
                enlazar();
            }
        }

        private void btnExportXML_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gestor_proceso.exportarXML(procesos));
        }
    }
}
