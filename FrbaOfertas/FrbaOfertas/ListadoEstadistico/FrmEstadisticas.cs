using FrbaOfertasPresentacion.ListadosEstadisticos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class FrmEstadisticas : Form, IVistaListadoEstadistico
    {

        private readonly PresentadorListadoEstadistico _presenter;

        public PresentadorListadoEstadistico Presentador { get { return _presenter; } }

        public FrmEstadisticas()
        {
            InitializeComponent();
            _presenter = new PresentadorListadoEstadistico(this);
        }

        public bool MensajePregunta(string mensage)
        {
            return (MessageBox.Show(mensage, "Confirmar", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void MostrarMensaje(string message)
        {
            MessageBox.Show(message);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Presentador.generarReporte();
        }

        public List<string> Semestres
        {
            set
            {
                cboSemestre.DataSource = value;
            }
        }

        public List<string> Reportes
        {
            set
            {
                cboReporte.DataSource = value;
            }
        }


        public int Anio
        {
            get
            {
                return (int)nupAnio.Value;
            }
            set
            {
                nupAnio.Value = value;
            }
        }

        public string ReporteSeleccionado
        {
            get
            {
                return cboReporte.SelectedItem.ToString();
            }
            set
            {
                cboReporte.SelectedItem = value;
            }
        }

        public string SemestreSeleccionado
        {
            get
            {
                return cboSemestre.SelectedItem.ToString();
            }
            set
            {
                cboSemestre.SelectedItem = value;
            }
        }

        public DataTable Datos
        {
            get
            {
                return null;
                //throw new NotImplementedException();
            }
            set
            {
                dgvReporte.Columns.Clear();
                dgvReporte.DataSource = value;
            }
        }
    }
}
