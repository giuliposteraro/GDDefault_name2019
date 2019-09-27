using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertasPresentacion.Componentes;
using System.Collections;
using System.Collections.ObjectModel;
using Negocio.Base;

namespace FrbaOfertas.Componentes
{
    public partial class GrillaGestionDatos : IGrillaGestionDatosVista
    {

        public ISynchronizeInvoke EventSyncInvoke { get; set; }
        private readonly PresentadorGrillaGestionDatos _presenter;
        public GrillaGestionDatos()
        {
            InitializeComponent();
            _presenter = new PresentadorGrillaGestionDatos(this);

            if (DesignMode)
            {
                return;
            }

            //  Agregue cualquier inicializaci�n despu�s de la llamada a InitializeComponent().
            AutoGenerateColumns = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MultiSelect = false;
            AllowUserToResizeRows = false;
            AllowUserToAddRows = false;
            AllowUserToOrderColumns = false;
            AllowUserToDeleteRows = false;
            this.GenerarColChecks();
            this.DoubleBuffered = true;
        }


        private const DataGridViewAutoSizeColumnsMode DefaultAutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        protected override void OnColumnHeaderMouseDoubleClick(System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            base.OnColumnHeaderMouseDoubleClick(e);
            this.MostarCampos();
        }

        void MostarCampos()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            StringBuilder sb3 = new StringBuilder();
            foreach (DataGridViewColumn col in this.Columns)
            {
                if ((sb.Length > 0))
                {
                    sb.Append(Environment.NewLine);
                    sb2.Append(Environment.NewLine);
                    sb3.Append(Environment.NewLine).Append(Environment.NewLine);
                }

                var campo = col.DataPropertyName;
                if (string.IsNullOrEmpty(campo))
                {
                    continue;
                }

                sb.Append(col.DataPropertyName);
                sb2.AppendFormat("Me._{0} = Me.Entidad.{0}", campo);
                sb3.AppendFormat("Private _{0} As String{1}Public Readonly Property {0}() As String{1}Get{1}Return _{0}{1}End Get{1}End" +
                    " Property", campo, Environment.NewLine);
            }

            sb2.Insert(0, ("Public Overrides Sub TomarDatosDeEntidad()" + Environment.NewLine)).Append((Environment.NewLine + ("End Sub" + Environment.NewLine)));
            sb3.Insert(0, ("#Region \"Campos\"" + Environment.NewLine)).Append((Environment.NewLine + ("#End Region" + Environment.NewLine)));
            Clipboard.SetText((sb2.ToString() + (Environment.NewLine + sb3.ToString())));
            MessageBox.Show(sb.ToString());
        }

        protected override void OnCellDoubleClick(System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex < 0))
            {
                return;
            }

            if ((RowHeadersVisible
                        && (e.RowIndex == 0)))
            {
                return;
            }

            if ((TieneChecks && (e.ColumnIndex == colChecks.Index)))
            {
                return;
            }

            base.OnCellDoubleClick(e);
        }

        protected override void OnCellContentDoubleClick(System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex < 0))
            {
                return;
            }

            if ((RowHeadersVisible
                        && (e.RowIndex == 0)))
            {
                return;
            }

            if ((TieneChecks
                        && (e.ColumnIndex == colChecks.Index)))
            {
                return;
            }

            base.OnCellContentDoubleClick(e);
        }

        private DataGridViewCell _celdaAnteriorAlClick;

        protected override void OnMouseClick(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseClick(e);
            Point p = e.Location;

            if (CanFocus)
            {
                Focus();
            }

            DataGridViewCell celda = null;
            foreach (DataGridViewRow row in Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if ((row.Displayed
                                && (cell.Displayed
                                && ((cell.RowIndex >= 0)
                                && ((cell.ColumnIndex >= 0)
                                && GetCellDisplayRectangle(cell.ColumnIndex, cell.RowIndex, true).Contains(p))))))
                    {
                        celda = cell;
                        break;
                    }

                }

            }

            // busco si se hizo click sobre una columna
            DataGridViewColumn columna = null;
            columna = (from DataGridViewColumn Column1 in Columns
                       where
                           GetCellDisplayRectangle(Column1.HeaderCell.ColumnIndex, Column1.HeaderCell.RowIndex, true).Contains(p)
                       select Column1).FirstOrDefault();

            try
            {
                if (celda != null && ((celda.RowIndex >= 0)
                                && (celda.ColumnIndex >= 0)))
                {
                    _celdaAnteriorAlClick = CurrentCell;
                    if (!(CurrentCell == celda))
                    {
                        CurrentCell = celda;
                    }

                }
            }
            catch (Exception ex)
            {

            }

            // si corresponde abro el men� contextual
            if (((e.Button == System.Windows.Forms.MouseButtons.Right) && (columna == null)))
            {
                // Si usa checks, al hace click derecho en una fila, 
                //lo marca si esta no lo esta, para incluirla entre los items a realizar una operacion.

                if (ContextMenuStrip != null && ContextMenuStrip.Enabled)
                {
                    if (TieneChecks)
                    {
                        // Si hago click derecho y no hay items chequeados lo marco al seleccionado. Si hay uno marcado, reemplazo el marcado
                        if ((CantidadItemsChequeados == 1))
                        {
                            ChequearTodos(false);
                        }

                        if ((CantidadItemsChequeados == 0))
                        {
                            Chequear(ItemSeleccionado, true);
                        }

                    }

                    Control control = (Control)this;
                    //CargarMenuContextual(this, EventArgs.Empty);
                    this.AbrirMenuContextual(control.PointToScreen(p));
                }

            }

        }


        public void AbrirMenuContextual(Point location)
        {
            Point p = location;
            if ((location == null))
            {
                p = this.PointToClient(MousePosition);
            }

            // Me.AgregarOQuitarComandosDelMenu()
            if (this.ContextMenuStrip != null)
            {
                this.AgregarOQuitarComandosDelMenu();
                this.ContextMenuStrip.Show(p.X, p.Y);
            }

        }

        private void AgregarOQuitarComandosDelMenu()
        {
            if (this.DesignMode)
            {
                return;
            }

            if ((this.ContextMenuStrip == null))
            {
                return;
            }

            var itemsDelMenu = this.ContextMenuStrip.Items;
            // La property ComandoExportar setea el item de menu copiar. 
            // Esto se haria en el linq de abajo, si no hay items no entra al where y por ende no se setea
            if ((itemsDelMenu.Count == 0))
            {
                this.CrearMenuCopiarDatos();
            }

            // ----------------------------------------------------------------------------------------------------------------------------------------------------
            // --MENU COPIAR a PORTAPAPELES
            var mnuCopiar = (from ToolStripItem cadaItem in itemsDelMenu
                    where cadaItem.Name == ComandoCopiarDatos.Name select cadaItem).FirstOrDefault();
            var sepCopiar = (from ToolStripItem cadaItem in itemsDelMenu
                    where cadaItem.Name == _separatorCopiarDatos.Name select cadaItem).FirstOrDefault();
            if (TieneCopiarDatos)
            {
                // si tiene, pero es de otra grilla, lo saco
                if (mnuCopiar !=_mnuCopiarDatos)
                {
                    itemsDelMenu.Remove(sepCopiar);
                    itemsDelMenu.Remove(mnuCopiar);
                    mnuCopiar = null;
                }

                // si no tiene, lo agrego
                if ((mnuCopiar == null))
                {
                    if (_ContextMenuStrip != null && _separatorCopiarDatos != null && _mnuCopiarDatos != null)
                    {
                        itemsDelMenu.Add(_separatorCopiarDatos);
                        itemsDelMenu.Add(_mnuCopiarDatos);
                    }

                }

            }
            else
            {
                // no tiene copiar datos
                // si tiene, lo saco
                if (mnuCopiar!= null)
                {
                    itemsDelMenu.Remove(sepCopiar);
                    itemsDelMenu.Remove(mnuCopiar);
                }

            }

            // ----------------------------------------------------------------------------------------------------------------------------------------------------
            // --MENU EXPORTAR A EXCEL
            var mnuExportar = (from ToolStripItem cadaItem in itemsDelMenu where cadaItem.Name == ComandoExportarDatos.Name select cadaItem).FirstOrDefault();
            var sepExportar = (from ToolStripItem cadaItem in itemsDelMenu where cadaItem.Name == _separatorExportarDatos.Name select cadaItem).FirstOrDefault();
            if (TieneExportarDatos)
            {
                // si tiene, pero es de otra grilla, lo saco
                if (mnuExportar!=_mnuExportarDatos)
                {
                    itemsDelMenu.Remove(sepExportar);
                    itemsDelMenu.Remove(mnuExportar);
                    mnuExportar = null;
                }

                // si no tiene, lo agrego
                if ((mnuExportar == null))
                {
                    if (_ContextMenuStrip != null && _separatorExportarDatos != null && _mnuExportarDatos != null)
                    {
                        itemsDelMenu.Add(_separatorExportarDatos);
                        itemsDelMenu.Add(_mnuExportarDatos);
                    }

                }

            }
            else
            {
                // no tiene Exportar datos
                // si tiene, lo saco
                if (mnuExportar != null)
                {
                    itemsDelMenu.Remove(sepExportar);
                    itemsDelMenu.Remove(mnuExportar);
                }

            }

        }

        // esta propiedad est� as� sombreada para que el control base no sepa 
        // que tiene un men� contextual configurado, y pretenda abrirlo autom�ticamente
        // NO CAMBIAR
        private ContextMenuStrip _ContextMenuStrip;

        public new ContextMenuStrip ContextMenuStrip
        {
            get
            {
                if (base.ContextMenuStrip != null) 
                     return base.ContextMenuStrip;
                return _ContextMenuStrip;
            }
            set
            {
                _ContextMenuStrip = value;
            }
        }


        public virtual void _parentForm_Shown(object sender, EventArgs e) 
        {
            if (this._ParentFormIsShown) {
                return;
            }
        
            this._ParentFormIsShown = true;

            if (this._datasourceNoVisible != null) 
                this.DataSource = this._datasourceNoVisible;
            if (this.ItemSeleccionado != null) 
                this.ItemSeleccionado = this._itemSeleccionadoNoVisible;
            if (this._ItemsChequeadosNoVisible != null) 
                this.Chequear(this._ItemsChequeadosNoVisible);
            
            this.Refresh();
        }
                
        protected virtual void OnParentChanged( EventArgs e ){
            this.CambioDeParent(this, e);
            base.OnParentChanged(e);
        }
            
        private Stack<Control> _parents;

         private void  CambioDeParent( object sender ,  EventArgs e )
         {
            var ctrl = sender as Control;
            if ((ctrl == null)) {
                return;
            }
            
            Control current;
            while (_parents.Any()) {
                current = _parents.Pop();
                if ((current == ctrl)) {
                    this._parents.Push(current);
                    break; //Warning!!! Review that break works as 'Exit Do' as it could be in a nested instruction like switch
                }
                else {
                    current.ParentChanged -= this.CambioDeParent;
                }
                
            }
            
            current = ctrl;
            for (
            ; true; 
            ) {
                Control parent = current.Parent;
                if (((parent == null) 
                            || (parent.GetType() is Form))) {
                    break; //Warning!!! Review that break works as 'Exit Do' as it could be in a nested instruction like switch
                }
                
                this._parents.Push(parent);
                parent.ParentChanged += new System.EventHandler(this.CambioDeParent);
                current = parent;
            }
            
            object currentForm = this.FindForm();
            if (currentForm != null) {
                this._parentForm = this.FindForm();
            }
            
            if ((AutoSizeRowsMode == DataGridViewAutoSizeRowsMode.None)) {
                foreach (DataGridViewColumn col in this.Columns) {
                    if ((col.DefaultCellStyle.WrapMode == DataGridViewTriState.NotSet)) {
                        // TODO: Continue For... Warning!!! not translated
                    }
                    
                    if ((col.DefaultCellStyle.WrapMode == DataGridViewTriState.False)) {
                        // TODO: Continue For... Warning!!! not translated
                    }
                    
                    AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    break;
                }
                
            }
            
        }
        
        protected bool _ParentFormIsShown;
        public bool ParentFormIsShown
        {
            get
            {
                //  If Me._parentForm Is Nothing Then Me._parentForm = Me.FindForm()
                if ((this._parentForm == null))
                    return false;

                if (this._parentForm.IsDisposed)
                    return false;

                if (this._parentForm.Visible)
                    return true;

                return this._ParentFormIsShown;
            }
        }

        private IEnumerable _itemsNoVisible;

        private IEnumerable _items;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual IEnumerable Items
        {
            get
            {
                if (!this.ParentFormIsShown)
                {
                    return _itemsNoVisible;
                }

                return _items;
            }
            set
            {
                _items = value;
                if (this.ParentFormIsShown)
                {
                    _itemsNoVisible = null;
                }
                else
                {
                    _itemsNoVisible = value;
                    _ActualizandoItemsDesdeItems = true;
                    DataSource = value;
                    _ActualizandoItemsDesdeItems = false;
                    return;
                }

                object seleccionado = ItemSeleccionado;
                object chequeados = ItemsChequeados;
                if ((value == null))
                {
                    DataSource = null;
                }
                else
                {
                    if (this.TieneChecks && (this.ChecksDataPropertyName == null || this.ChecksDataPropertyName == ""))
                    {
                        this.ChecksDataPropertyName = "EstaSeleccionado";
                    }

                    _ActualizandoItemsDesdeItems = true;
                    DataSource = value;
                    _ActualizandoItemsDesdeItems = false;
                    if (seleccionado != null)
                    {
                        ItemSeleccionado = seleccionado;
                    }

                    Chequear(chequeados);
                    // respeto lo chequeado anterior + lo que tenga EstaSeleccionado=true en el datasource actual
                }

            }
        }

        private bool _ajustarColumnas;

        public bool AjustarColumnas
        {
            get
            {
                return _ajustarColumnas;
            }
            set
            {
                if (value)
                {
                    AutoSizeColumnsMode = DefaultAutoSizeColumnsMode;
                }

                _ajustarColumnas = value;
            }
        }

        [DefaultValue(DataGridViewAutoSizeColumnsMode.None)]
        public new DataGridViewAutoSizeColumnsMode AutoSizeColumnsMode
        {
            get
            {
                return base.AutoSizeColumnsMode;
            }
            set
            {
                base.AutoSizeColumnsMode = value;
            }
        }

        private bool _ActualizandoItemsDesdeDataSource;

        private bool _ActualizandoItemsDesdeItems;

        private bool _mantenerSeleccionAlReordenar;

        public bool MantenerSeleccionAlReordenar
        {
            get
            {
                return _mantenerSeleccionAlReordenar;
            }
            set
            {
                _mantenerSeleccionAlReordenar = value;
            }
        }

        private bool _mostrarWaitWindowOnDataSourceChanged;

        public bool MostrarWaitWindowOnDataSourceChanged
        {
            get
            {
                return _mostrarWaitWindowOnDataSourceChanged;
            }
            set
            {
                _mostrarWaitWindowOnDataSourceChanged = value;
            }
        }

        protected override void OnDataSourceChanged(System.EventArgs e)
        {
            this.ChecksDataPropertyName = this.ChecksDataPropertyName;
            this.ChecksToolTipText = this.ChecksToolTipText;
            try
            {
                base.OnDataSourceChanged(e);
            }
            catch (Exception ex)
            {
            }

            if (this.MostrarWaitWindowOnDataSourceChanged)
            {
                //WaitWindow.Show("Cargando datos...");
            }

            // CargarDiccionario()
            if (TieneChecks)
            {
                _CambioEnColumna = true;
                this.CheckMasivoChequeado = false;
                _CambioEnColumna = false;
                if (Rows!= null && (Rows.Count > 0))
                {
                    foreach (DataGridViewRow r in Rows)
                    {
                        r.Cells[colChecks.Index].ToolTipText = ChecksToolTipText;
                    }

                }

            }

            if (this.MostrarWaitWindowOnDataSourceChanged)
            {
                //WaitWindow.Hide();
            }
        }

        object _datasourceNoVisible;

        public object DataSource
        {
            get
            {
                if (!this.ParentFormIsShown)
                    return _datasourceNoVisible;

                if (base.DataSource == null)
                    return null;
                else if (base.DataSource.GetType() is IEnumerable)
                    return Items;
                else
                    return (IEnumerable)base.DataSource;
            }
            set
            {
                if (value != null && value.GetType() is IEnumerable && !_ActualizandoItemsDesdeDataSource && !_ActualizandoItemsDesdeItems)
                {
                    _ActualizandoItemsDesdeDataSource = true;
                    Items = (IEnumerable)value;
                    _ActualizandoItemsDesdeDataSource = false;
                    return;
                }

                if (this.ParentFormIsShown)
                {
                    _datasourceNoVisible = null;
                }
                else
                {
                    _datasourceNoVisible = value;
                    return;
                }

                bool estabaVacio = (RowCount == 0);         
                _columnaActualAntesDelDatasource = CurrentCell != null ? CurrentCell.ColumnIndex : -1;
               _PrimeraColumnaVisibleAntesDelDatasource = FirstDisplayedScrollingColumnIndex;

                var ordenTipo = this.SortOrder;
                var ordenColumna = this.SortedColumn;
                try
                {
                    base.DataSource = value;
                    // <--- OJO! este tiene que ser el �nico lugar donde se actualiza el MyBase.DataSource!!
                }
                catch (Exception ex)
                {
                    // parche temporal porque daba error si se presionaba muchas veces y r�pido el F5 (refresh).
                }

                switch (ordenTipo)
                {
                    case System.Windows.Forms.SortOrder.Ascending:
                        this.Sort(ordenColumna, ListSortDirection.Ascending);
                        break;
                    case System.Windows.Forms.SortOrder.Descending:
                        this.Sort(ordenColumna, ListSortDirection.Descending);
                        break;
                }
                
                bool estaVacio = RowCount == 0;
                this.RedimensionarColumnas(estaVacio, estabaVacio);
                
                if (!(_PrimeraColumnaVisibleAntesDelDatasource == -1))
                {
                    try
                    {
                        FirstDisplayedScrollingColumnIndex = _PrimeraColumnaVisibleAntesDelDatasource;
                    }
                    catch (Exception ex)
                    {
                    }

                }

            }
        }

        private void RedimensionarColumnas(bool estaVacio, bool estabaVacio)
        {
            if (estaVacio)
            {
                return;
            }

            if (!estabaVacio)
            {
                return;
            }

            if ((AjustarColumnas == false))
            {
                return;
            }

            if ((AutoSizeColumnsMode == DefaultAutoSizeColumnsMode))
            {
                return;
            }

            AutoResizeColumns(DefaultAutoSizeColumnsMode);
        }

        private DataGridViewRow GetRowForItem(object value)
        {
            bool recursiveCall = false;
            if ((value == null))
            {
                return null;
            }

            if ((this.Rows.Count != this._ItemsPorLinea.Count))
            {
                this.CargarDiccionario();
            }

            DataGridViewRow fila = null;
            try
            {
                // If Not _ItemsPorLinea.TryGetValue(value, fila) Then Return Nothing
                _ItemsPorLinea.TryGetValue( value, out fila);
            }
            catch (Exception ex)
            {
            }

            if (fila != null)
            {
                if (!this.Rows.Contains(fila))
                {
                    if (recursiveCall)
                    {
                        fila = null;
                    }
                    else
                    {
                        this.CargarDiccionario();
                        recursiveCall = true;
                        fila = this.GetRowForItem(value);
                        recursiveCall = false;
                    }

                }

            }

            if ((fila == null))
            {
                fila = (from DataGridViewRow row in this.Rows where row.DataBoundItem.Equals(value) select row).FirstOrDefault();
            }

            return fila;
        }

        private Dictionary<object, DataGridViewRow> _ItemsPorLinea = new Dictionary<object, DataGridViewRow>();

        private void CargarDiccionario()
        {
            try
            {
                _ItemsPorLinea.Clear();
                for (var i = 0; i<= (this.RowCount - 1); i++)
                {
                    DataGridViewRow row = this.Rows[i];
                    _ItemsPorLinea.Add(row.DataBoundItem, row);
                }

            }
            catch (Exception ex)
            {
            }

        }

        private object _itemSeleccionadoNoVisible;

        private int _columnaActualAntesDelDatasource;

        private int _PrimeraColumnaVisibleAntesDelDatasource;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual object ItemSeleccionado
        {
            get
            {
                if (!this.ParentFormIsShown)
                {
                    return _itemSeleccionadoNoVisible;
                }

                if ((CurrentRow == null))
                {
                    return null;
                }
                else
                {
                    return CurrentRow.DataBoundItem;
                }

            }
            set
            {
                if ((ItemSeleccionado == value))
                {
                    // TODO: Exit
                }

                if (this.ParentFormIsShown)
                {
                    _itemSeleccionadoNoVisible = null;
                }
                else
                {
                    _itemSeleccionadoNoVisible = value;
                    // TODO: Exit
                }

                if ((value == null))
                {
                    CurrentCell = null;
                    // TODO: Exit
                }

                var fila = this.GetRowForItem(value);
                if ((fila == null))
                {
                    // TODO: Exit
                }

                int firstDisplayedIndex = FirstDisplayedScrollingColumnIndex;
                int index = -1;
                if ((index == -1))
                {
                    index = _columnaActualAntesDelDatasource;
                }

                if ((index == -1))
                {
                    index = firstDisplayedIndex;
                }

                if ((index == -1))
                {
                    if (CurrentCell != null)
                    {
                        index = CurrentCell.ColumnIndex;
                        if ((index == -1))
                        {
                            foreach (DataGridViewColumn acol in Columns)
                            {
                                if (acol != colChecks && acol.Visible)
                                {
                                    index = acol.Index;
                                    break;
                                }

                            }

                        }

                        if ((index == -1))
                        {
                            CurrentCell = null;
                            // TODO: Exit
                        }

                        CurrentCell = fila.Cells[index];
                        if (!(firstDisplayedIndex == -1))
                        {
                            FirstDisplayedScrollingColumnIndex = firstDisplayedIndex;
                        }

                    }

                }

            }
        }

        protected virtual void OnSelectionChanged(EventArgs e)
        {
            base.OnSelectionChanged(e);
        }
        protected virtual void OnCurrentCellChanged(EventArgs e)
        {
            base.OnCurrentCellChanged(e);
        }

        protected override void SetSelectedRowCore(int rowIndex, bool selected)
        {
            base.SetSelectedRowCore(rowIndex, selected);
        }

        protected override void SetSelectedCellCore(int columnIndex, int rowIndex, bool selected)
        {
            base.SetSelectedCellCore(columnIndex, rowIndex, selected);
        }

        private void DataGridView_StandardBase_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void GenerarColChecks()
        {
            colChecks = new DataGridViewCheckBoxColumn();
            colChecks.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colChecks.Width = 20;
            colChecks.HeaderText = "   ";
            colChecks.Name = "colChecks";
            colChecks.Frozen = true;
            colChecks.Visible = false;
            colChecks.MinimumWidth = 20;
            colChecks.Resizable = DataGridViewTriState.False;
        }

        protected DataGridViewCheckBoxColumn colChecks;

        private string _ChecksDataPropertyName;

        public string ChecksDataPropertyName
        {
            get
            {
                return _ChecksDataPropertyName;
            }
            set
            {
                _ChecksDataPropertyName = value;
                if (colChecks != null)
                {
                    if (!(colChecks.DataPropertyName == value))
                    {
                        colChecks.DataPropertyName = value;
                    }
                }

            }
        }

        private string _checksToolTipText  = "";


        public string ChecksToolTipText
        {
            get
            {
                return _checksToolTipText;
            }
            set
            {

                _checksToolTipText = value;
                if( colChecks != null && !(colChecks.ToolTipText == value) )
                    colChecks.ToolTipText = value;
            }
        }

        private bool _TieneChecks;


        [DefaultValue(false)]
        public bool TieneChecks
        {
            get
            {
                return _TieneChecks;
            }
            set
            {
                _TieneChecks = value;
                ActualizarColumnaDeChecks();
            }
        }

        private bool _TieneCheckMasivo;

        public bool TieneCheckMasivo
        {
            get
            {
                return (ColumnHeadersVisible && _TieneCheckMasivo);
            }
            set
            {
                _TieneCheckMasivo = value;
                ActualizarColumnaDeChecks();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool CheckMasivoChequeado
        {
            get
            {
                return chkCheck.Checked;
            }
            set
            {
                chkCheck.Checked = value;
            }
        }

        private void ActualizarColumnaDeChecks()
        {
            if (DesignMode)
            {
                return;
            }

            if (TieneChecks)
            {
                if (!Columns.Contains(colChecks))
                {
                    Columns.Insert(0, colChecks);
                }
            }
            else
            {
                if (Columns.Contains(colChecks))
                {
                    Columns.Remove(colChecks);
                }
            }
            colChecks.Visible = TieneChecks;
            chkCheck.Visible = (TieneChecks && TieneCheckMasivo);
        }

        private bool _CambioEnColumna;
        protected bool _CambioEnCheck;

        public void chkCheck_CheckedChanged( object sender, System.EventArgs e) {
            chkCheckChanged(sender);
        }
        public event EventHandler CambioChequeadosMultiplesItems;
        public event EventHandler CargarMenuContextual;
        

        protected override void OnCellMouseClick(System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            if (PermiteOcultarColumnas)
            {
                if (e.RowIndex == -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    var l = this.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location;
                    Point p = new Point(l.X,l.Y);
                    p.Offset(e.X, e.Y);
                    MostrarSelectorDeColumnas(p);
                    return;
                }

            }

            if (!_CambioEnCheck && TieneChecks && e.RowIndex >= 0)
            {
                bool enColChecks = (e.ColumnIndex == colChecks.Index);
                List<DataGridViewRow> filasAInvertir = new List<DataGridViewRow>();
                List<DataGridViewRow> filasAMarcar = new List<DataGridViewRow>();
                if ((e.Button == System.Windows.Forms.MouseButtons.Left))
                {
                    try
                    {
                        if (Control.ModifierKeys == Keys.Shift)
                        {
                            if ((_celdaAnteriorAlClick == null))
                            {
                                filasAMarcar.Add(this.Rows[e.RowIndex]);
                            }
                            else
                            {
                                for (int i = Math.Min(_celdaAnteriorAlClick.RowIndex, e.RowIndex); i <= Math.Max(_celdaAnteriorAlClick.RowIndex, e.RowIndex); i++)
                                {
                                    filasAMarcar.Add(this.Rows[i]);
                                }

                            }

                        }
                        else if (Control.ModifierKeys == Keys.ControlKey || enColChecks)
                        {
                            filasAInvertir.Add(this.Rows[e.RowIndex]);
                        }

                    }
                    catch (Exception ex)
                    {
                    }

                }

                if (filasAMarcar.Any())
                {
                    foreach (DataGridViewRow fila in filasAMarcar)
                    {
                        DataGridViewCell celda = fila.Cells[colChecks.Index];
                        celda.Value = true;
                    }

                    EndEdit();
                    if ((filasAMarcar.Count == 1))
                    {
                        CambioChequeadosUnItem(this, new DataGridViewCellEventArgs(e.ColumnIndex, e.RowIndex));
                    }
                    else
                    {
                        CambioChequeadosMultiplesItems(this, EventArgs.Empty);
                    }

                }

                if (filasAInvertir.Any())
                {
                    foreach (DataGridViewRow fila in filasAInvertir)
                    {
                        DataGridViewCell celda = fila.Cells[colChecks.Index];
                        if (celda.Value == null) celda.Value = false;
                        celda.Value = !(bool)celda.Value;
                    }

                    EndEdit();
                    if ((filasAInvertir.Count == 1))
                    {
                        CambioChequeadosUnItem(this, new DataGridViewCellEventArgs(e.ColumnIndex, e.RowIndex));
                    }
                    else
                    {
                        CambioChequeadosMultiplesItems(this, EventArgs.Empty);
                    }

                }

            }

            base.OnCellMouseClick(e);
        }

        protected virtual void chkCheckChanged(object sender) {
            if (_CambioEnColumna) {
                return;
            }
        
            if (!TieneCheckMasivo) {
                return;
            }
        
            if (!TieneChecks) {
                return;
            }
        
            if (_CambioEnCheck) {
                return;
            }
        
            _CambioEnCheck = true;
            SuspendLayout();
            var filas = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in this.Rows) {
                filas.Add(row);
            }
        
            var totalFilas = (filas.Count - 1);
            var RequiereWaitWindow = (totalFilas > 100);
            for (var i = 0; (i <= totalFilas); i++) {
                DataGridViewRow row = filas[i];
                if (RequiereWaitWindow) {
                    if ((i % 100) == 0) {
                        Application.DoEvents();
                    }
                
                    row.Cells[colChecks.Index].Value = this.CheckMasivoChequeado;
                }
                else {
                    row.Cells[colChecks.Index].Value = this.CheckMasivoChequeado;
                }
            }
            EndEdit();
            _CambioEnCheck = false;
            ResumeLayout(true);
            CambioChequeadosMultiplesItems(this, EventArgs.Empty);
        }
            
          private bool _checkOnClick = false;
          public bool CheckOnClick
          {
              get{
                  return _checkOnClick;
              }
              set{
                  _checkOnClick = value;
              }
          }
            
            
          protected virtual void OnCellValueChanged(System.Windows.Forms.DataGridViewCellEventArgs e)
          {
                if (!_CambioEnCheck && TieneChecks &&  e.ColumnIndex == colChecks.Index) {
                    _CambioEnColumna = true;
                    this.CheckMasivoChequeado = false;
                    _CambioEnColumna = false;
                }
            
                if (TieneChecks) {
                    if ((e.RowIndex > -1) && (colChecks.Index > -1)) {
                        if ((bool)this.Rows[e.RowIndex].Cells[colChecks.Index].Value) {
                            this.Rows[e.RowIndex].Cells[colChecks.Index].Style.BackColor = Color.FromKnownColor(KnownColor.Highlight);
                        }
                        else {
                            this.Rows[e.RowIndex].Cells[colChecks.Index].Style.BackColor = Color.White;
                        }
                    
                    }
                }
            
                base.OnCellValueChanged(e);
          }

            protected virtual void OnCellEndEdit(System.Windows.Forms.DataGridViewCellEventArgs e)
            {
                base.OnCellEndEdit(e);
                if ((!_CambioEnCheck  && (TieneChecks && (e.ColumnIndex == colChecks.Index)))) 
                    CambioChequeadosUnItem(this, e);
            }
            
            public event EventHandler<DataGridViewCellEventArgs> CambioChequeadosUnItem;

            protected virtual void OnDataError( bool displayErrorDialogIfNoHandler ,  System.Windows.Forms.DataGridViewDataErrorEventArgs e )
            {
                base.OnDataError(false, e);
            }
        
            private IEnumerable _ItemsChequeadosNoVisible;

            public virtual IEnumerable ItemsChequeados
            {
                get{
                    if (!this.ParentFormIsShown) {
                        if ((this._ItemsChequeadosNoVisible == null))
                            return new List<object>();
                        return this._ItemsChequeadosNoVisible;
                    }
            
                    var misItems = (from DataGridViewRow row  in this.Rows select row.DataBoundItem).ToList();
                    var chequeados = (from cadaItem in misItems where EstaChequeado(cadaItem) select cadaItem).ToList();
                    return chequeados;
                }
                set
                {
                    if (this.ParentFormIsShown) {
                        _ItemsChequeadosNoVisible = null;
                    }
                    else {
                        _ItemsChequeadosNoVisible = value;
                        return;
                    }
            
                    ChequearSolo(value);
                }
            }

            public int CantidadItemsChequeados{
                get{
                    IEnumerable chequeados = this.ItemsChequeados;
                    if (chequeados == null)
                     return 0;
                    return (from object item in chequeados select item).Count();
                }
            }

            public bool EstaChequeado(object item)
            {
                if ((item == null)) {
                    return false;
                }
            
                if (!TieneChecks) {
                    return false;
                }
            
                DataGridViewRow fila = this.GetRowForItem(item);
           
                if ((fila == null)) {
                    return false;
                }
            
                object value = fila.Cells[colChecks.Index].Value;
                return System.Convert.ToBoolean(value);
            }
    
            public void Chequear(bool chequeado = true){
                Chequear(ItemSeleccionado, chequeado);
            }

            public void Chequear(object item, bool chequeado = true){
                var enumerable = new [] { item };
                Chequear(enumerable, chequeado);
            }       
            public void Chequear(IEnumerable items,  bool chequeado = true)
            {
                if ((items == null)) {
                    return;
                }
            
                if (!TieneChecks) {
                    return;
                }
            
                foreach (object i in items) {
                    if (i != null) {
                        DataGridViewRow fila = this.GetRowForItem(i);
                 
                        if (fila != null) {
                            fila.Cells[colChecks.Index].Value = chequeado;
                           EndEdit();
                        }
                    
                    }
                }
                
            }
            
            public void ChequearTodos(bool chequeado = true)
            {
                Chequear(Items, chequeado);
            }
            

            //  Esto chequea solo los items que se les pasa y deja los otros en false
            public void ChequearSolo(IEnumerable items)
            {
                if ((items == null)) {
                    // Si no hay ning�n item chequeado, deseleccionamos Todos
                    this.ChequearTodos(false);
                    return;
                }
            
                foreach (DataGridViewRow row in this.Rows) {
                    var i = row.DataBoundItem;
                    bool estaEnLista = false;
                    foreach (object a in items)
                    {
                        if (a.Equals(i))
                        {
                            estaEnLista = true;
                            break;
                        }
                    }

                    if (estaEnLista) {
                        if (!EstaChequeado(i)) {
                            // Si esta en lista y no est� chequeado, entonces lo chequeamos
                            this.Chequear(i, true);
                        }
                    
                    }
                    else if (EstaChequeado(i)) {
                        // Si no esta en lista y est� chequeado, entonces lo deschequeamos
                        this.Chequear(i, false);
                    }
                
                }
            
            }

            private void DataGridView_Standard_KeyDown(object sender , System.Windows.Forms.KeyEventArgs e)
            {
                // si es un espacio chequeo fila. 
                if ((e.KeyData == Keys.Space)) {
                    if (!TieneChecks) {
                        return;
                    }
                
                    // si no tiene checks salgo
                    if (CurrentCell.IsInEditMode) {
                        return;
                    }
                
                    // si la celda esta en edicion salgo sin chequear.
                    if (EstaChequeado(ItemSeleccionado)) {
                        Chequear(ItemSeleccionado, false);
                    }
                    else {
                        Chequear(ItemSeleccionado, true);
                    }
                
                }
            }
            

            private Panel _panSeleccionadorDeColumnas;
            //private CheckedListBox _lstSelectorDeColumnas;
            //private Button _btnMostrarTodas;
            //private Button _btnAjustarAnchos;
            
        private Panel SelectorDeColumnas
        {
            get
            {
                if ((_panSeleccionadorDeColumnas == null)) {
                    Panel pan = new Panel();
                    pan.BorderStyle = BorderStyle.FixedSingle;
                    pan.Visible =  false;
                    Controls.Add(pan);
                
                    var lst = new CheckedListBox();
                    lst.IntegralHeight = false;
                    lst.Dock = DockStyle.Fill;
                    lst.CheckOnClick = true;
                    lst.DisplayMember = "HeaderText";
                    pan.Controls.Add(lst);

                    Label lbl = new Label();
                    lbl.Text = "Mostrar:";
                    lbl.Dock = DockStyle.Top;
                    lbl.Height = 20;
                    lbl.Font = new Font(lbl.Font, FontStyle.Bold);
                    lbl.ForeColor = Color.White;
                    lbl.BackColor = Color.LightSteelBlue;
                    lbl.TextAlign = ContentAlignment.MiddleLeft;
                    pan.Controls.Add(lbl);

                    _btnMostrarTodas = new Button();
                    _btnMostrarTodas.Text = "Mostrar todas";
                    _btnMostrarTodas.Dock = DockStyle.Bottom;
                    _btnMostrarTodas.Height = 20;
                    _btnMostrarTodas.Click += _btnMostrarTodas_Click;
                     pan.Controls.Add(_btnMostrarTodas);

                    _btnAjustarAnchos = new Button();
                    _btnAjustarAnchos.Text = "Ajustar anchos";
                    _btnAjustarAnchos.Dock = DockStyle.Bottom;
                    _btnAjustarAnchos.Height = 20;
                    _btnAjustarAnchos.Click += _btnAjustarAnchos_Click;
                    pan.Controls.Add(_btnAjustarAnchos);

                    _btnCerrar = new Button();
                    _btnCerrar.Text = "Cerrar";
                    _btnCerrar.Dock = DockStyle.Bottom;
                    _btnCerrar.Height = 20;
                    _btnCerrar.Click += _btnCerrar_Click;
                    pan.Controls.Add(_btnCerrar);

                    foreach (DataGridViewColumn columna in ColumnasOcultables) {
                        lst.Items.Add(columna, columna.Visible);
                    }
                
                    _panSeleccionadorDeColumnas = pan;
                    _lstSelectorDeColumnas = lst;
                    _lstSelectorDeColumnas.ItemCheck += _lstSelectorDeColumnas_ItemCheck;
                }
            
            return _panSeleccionadorDeColumnas;
            }
        }

        private void MostrarSelectorDeColumnas(Point p)
        {
            // ubicacion
            p.Offset(-10, -10);
            if ((p.Y < 3)) {
                p.Y = 3;
            }
            
            if ((p.X > (Width - SelectorDeColumnas.Width))) {
                p.X = (Width - (SelectorDeColumnas.Width - 3));
            }
            
            SelectorDeColumnas.Location = p;
            // tama�o
            int altoControles = (from Control ctrl in SelectorDeColumnas.Controls where ctrl != _lstSelectorDeColumnas select ctrl.Height).Sum();
            int ancho = 0;
            int alto = 0;
            foreach (object columna in _lstSelectorDeColumnas.Items) {
                //SizeF nameSize = System.Drawing.Graphics.MeasureString(columna.ToString(), _lstSelectorDeColumnas.Font);
                ancho = Math.Max(ancho, 100);//nameSize.Width);
                alto = (alto + 20);//nameSize.Height);
            }
            
            SelectorDeColumnas.Size = new Size((ancho + 20), Math.Min((alto + (altoControles + 20)), (Height - (20 - p.Y))));
            SelectorDeColumnas.Visible = true;

        }

        private void OcultarSelectorDeColumnas()
        {
        SelectorDeColumnas.Visible = false;
        }
            
        private void _lstSelectorDeColumnas_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            DataGridViewColumn col = (DataGridViewColumn)_lstSelectorDeColumnas.Items[e.Index];
            if (((_lstSelectorDeColumnas.CheckedItems.Count == 1) && (e.NewValue == CheckState.Unchecked))) {
                // Si tiene un solo item y se va a deschequear, no lo dejamos continuar
                MessageBox.Show("Debe mostrarse alguna columna");
                // Volvemos a marcar el item como chequeado
                e.NewValue = CheckState.Checked;
                return;
            }
            
            col.Visible = (e.NewValue == CheckState.Checked);
            MostrarAlertaColumnaOculta();
        }

        private void _btnCerrar_Click(object sender, System.EventArgs e)
        {
            if (SelectorDeColumnas.Visible) {
                OcultarSelectorDeColumnas();
            }
            
        }

        private void  _btnMostrarTodas_Click(object sender, System.EventArgs e)
        {
            for (var i = 0; i <= (_lstSelectorDeColumnas.Items.Count - 1); i++) {
                _lstSelectorDeColumnas.SetItemChecked(i, true);
            }
            
            MostrarAlertaColumnaOculta();
        }

         private void    _btnAjustarAnchos_Click(object sender , System.EventArgs e)
         {
            AutoResizeColumns(DefaultAutoSizeColumnsMode);
         }

        private bool _PermiteOcultarColumnas = true;

        public bool PermiteOcultarColumnas
        {
            get{
                return _PermiteOcultarColumnas;
            }
            set{
            _PermiteOcultarColumnas = value;
            }
        }
            
        private List<DataGridViewColumn> _columnasOcultables;

        public ReadOnlyCollection<DataGridViewColumn> ColumnasOcultables
        {
            get{

            if ((_columnasOcultables == null) || _columnasOcultables.Count() == 0) {
                _columnasOcultables = (from DataGridViewColumn eachColumn in Columns where PermiteOcultarColumnas && eachColumn != colChecks && eachColumn.Visible select eachColumn).ToList();
            }
            
            return _columnasOcultables.ToList().AsReadOnly();
            }
        }

            public List<string> ColumnsOcultas
            {
                get{
                    if (!PermiteOcultarColumnas) {
                        return new List<string>();
                    }
            
                    return ColumnasOcultables.Where(f => !f.Visible).Select(f=> f.Name).ToList();
                }
                set{
                    if (!PermiteOcultarColumnas) {
                        return;
                    }
            
                    OcultarSelectorDeColumnas();
                    for (int i = 0; i <= (_lstSelectorDeColumnas.Items.Count - 1); i++) {
                        DataGridViewColumn col = (DataGridViewColumn)_lstSelectorDeColumnas.Items[i];
                        col.Visible = true;
                        if (value != null && value.Select(f => f.Trim()).Contains(col.Name.Trim())) {
                            col.Visible = false;
                        }
                    }
                         
                    MostrarAlertaColumnaOculta();
                    _lstSelectorDeColumnas.Items.Clear();
                    foreach (DataGridViewColumn columna in ColumnasOcultables) {
                        _lstSelectorDeColumnas.Items.Add(columna, columna.Visible);
                    }
                }
            }
            
            private StatusStrip _StatusTripAMostrarAlerta;
            public StatusStrip StatusTripAMostrarAlerta{
                get{
                    return _StatusTripAMostrarAlerta;
                }
                set{
                    _StatusTripAMostrarAlerta = value;
                }
            }

            private void MostrarAlertaColumnaOculta(){
                if ((StatusTripAMostrarAlerta == null)) {
                    return;
                }
            
                bool mostrarAlerta = ColumnasOcultables.Any(f => !f.Visible);
                foreach (ToolStripItem control in StatusTripAMostrarAlerta.Items) {
                    if (control.Name.Equals("lblAlertaColumnaOculta")) {
                        control.Visible = mostrarAlerta;
                        return;
                    }
                
                }
            
                ToolStripStatusLabel label = new ToolStripStatusLabel();
                label.Image = global::FrbaOfertas.Properties.Resources.hideTableColumn;
                label.Name = "lblAlertaColumnaOculta";
                label.ToolTipText = "Hay Columnas Ocultas en la Grilla";
                label.Visible = mostrarAlerta;
                StatusTripAMostrarAlerta.Items.Insert(0, label);
            }


            public virtual void OnKeyDown( System.Windows.Forms.KeyEventArgs e)
            {

                base.OnKeyDown(e);
                if (!(e.KeyCode == Keys.F2 && e.Shift)) {
                    return;
                }
                MostrarDatosDelItemSeleccionado();
            }
            
            
            private void MostrarDatosDelItemSeleccionado(){

                object seleccionado = ItemSeleccionado;
                if ((seleccionado == null)) {
                    return;
                }
            
                StringBuilder sb = new StringBuilder();
                System.Reflection.PropertyInfo idProp = (from cadaProp in seleccionado.GetType().GetProperties(System.Reflection.BindingFlags.Instance 
                                | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic) where cadaProp.Name == "Id" select cadaProp).LastOrDefault();
                int id = -1;
                if (idProp != null) {
                    id = (int)idProp.GetValue(seleccionado, null);
                }
                else {
                    DataRow dr = null;
                    if ((seleccionado.GetType() is DataRow)) {
                        dr = (DataRow)seleccionado;
                    }
                
                    if (dr != null) {
                        if (dr.Table.Columns.Contains("id")) {
                            if (!dr.IsNull("Id")) {
                                id = (int)dr["Id"];
                            }
                        }                
                    }
                }
                
                if ((id > -1)) {
                    sb.AppendFormat("Id:{0}", id).AppendLine();
                }
                else {
                    sb.AppendFormat("Id: <DESCONOCIDO>").AppendLine();
                }
                
                sb.AppendFormat("ToString: {0}", seleccionado.ToString()).AppendLine();
                sb.AppendLine();

                object entidad = null;
                System.Reflection.PropertyInfo entidadProp = (from cadaProp in seleccionado.GetType().GetProperties(System.Reflection.BindingFlags.Instance 
                                | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)
                                                              where cadaProp.Name == "Entidad"
                                                              select cadaProp).LastOrDefault();
                if (entidadProp!= null) {
                    entidad = entidadProp.GetValue(seleccionado, null);
                }
                    
                if (entidad!= null) {

                    sb.AppendLine(("Entidad: " + entidad.GetType().Name)).AppendLine();
                    foreach (System.Reflection.PropertyInfo prop in (from cadaProp in entidad.GetType().GetProperties(System.Reflection.BindingFlags.Instance 
                                        | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic) where cadaProp.CanRead && cadaProp.GetIndexParameters().Length == 0 orderby cadaProp.Name select cadaProp))
                   {
                        object valor;
                        try {
                            valor = prop.GetValue(entidad, null);
                            if ((valor == null)) {
                                valor = "<NOTHING>";
                            }
                                
                        }
                        catch (Exception ex) {
                            valor = "<ERROR>";
                        }
                            
                        if (valor.GetType() is IEnumerable && !(valor.GetType() is String)) {
                            int cant = -1;
                            if (valor.GetType() is IList) {
                                cant = ((IList)(valor)).Count;
                            }
                                
                            sb.AppendFormat("{0}: {1}", prop.Name, ( (cant == -1) ? "" : cant.ToString() )).AppendLine();
                            /*foreach (object subValor in valor) {
                                if ((subValor == null)) {
                                    // TODO: Continue For... Warning!!! not translated
                                }
                                    
                                if ((subValor.GetType() == IEntity)) {
                                    int idSubValor;
                                    object idProp3 = From;
                                    cadaProp;
                                    subValor.GetType.GetProperties((Reflection.BindingFlags.Instance 
                                                    | (Reflection.BindingFlags.Public | Reflection.BindingFlags.NonPublic)));
                                    Where;
                                    cadaProp.Name = "Id";
                                    LastOrDefault;
                                    if (idProp3) {
                                        IsNot;
                                        null;
                                        idSubValor = idProp3.GetValue(subValor, null);
                                        sb.AppendFormat("     ({0}) {1}", idSubValor, subValor.ToString).AppendLine();
                                    }
                                    else if (subValor.GetType.IsEnum) {
                                        sb.AppendFormat("     ({0}) {1}", int.Parse(subValor), subValor.ToString).AppendLine();
                                    }
                                    else {
                                        sb.AppendFormat("     {0}", subValor.ToString).AppendLine();
                                    }
                                        
                                }
                                else if ((valor.GetType() == IEntity)) {
                                    int idValor;
                                    object idProp2 = From;
                                    cadaProp;
                                    valor.GetType.GetProperties((Reflection.BindingFlags.Instance 
                                                    | (Reflection.BindingFlags.Public | Reflection.BindingFlags.NonPublic)));
                                    Where;
                                    cadaProp.Name = "Id";
                                    LastOrDefault;
                                    if (idProp2) {
                                        IsNot;
                                        null;
                                        idValor = idProp2.GetValue(valor, null);
                                        sb.AppendFormat("{0} = ({1}) {2}", prop.Name, idValor, valor.ToString).AppendLine();
                                    }
                                    else if (valor.GetType.IsEnum) {
                                        sb.AppendFormat("{0} = ({1}) {2}", prop.Name, int.Parse(valor), valor.ToString).AppendLine();
                                    }
                                    else {
                                        sb.AppendFormat("{0} = {1}", prop.Name, valor.ToString).AppendLine();
                                    }
                                        
                                }
                                else {
                                    sb.AppendFormat("Entidad: <DESCONOCIDA>").AppendLine();
                                }*/
                        }
                    }
                }
                _presenter.MostrarMensaje(sb.ToString());
            }
        private bool _tieneExportarXls= true;
        public bool TieneExportarDatos{
            get{
                return _tieneExportarXls;
            }
            set{
                _tieneExportarXls = value;
            }
        }                    
        /*private ToolStripMenuItem _mnuExportarDatos;
        private ToolStripMenuItem _mnuExportarDatosTodoConEncabezados;
        private ToolStripMenuItem _mnuExportarDatosSeleccionadoConEncabezados;
        private ToolStripSeparator _separatorExportarDatos;*/
        protected ToolStripMenuItem ComandoExportarDatos{
            get{
                if ((_mnuExportarDatos == null)) {
                    _mnuExportarDatos = new ToolStripMenuItem("Exportar datos a Excel..."){ Name = "_mnuExportarDatos"};
                    _mnuExportarDatosTodoConEncabezados = new ToolStripMenuItem("Toda la grilla (con encabezados)");
                    _mnuExportarDatosSeleccionadoConEncabezados = new ToolStripMenuItem("Filas seleccionadas (con encabezados)");
                    _mnuExportarDatos.DropDownItems.Add(_mnuExportarDatosTodoConEncabezados);
                    _mnuExportarDatos.DropDownItems.Add(_mnuExportarDatosSeleccionadoConEncabezados);
                    _separatorExportarDatos = new ToolStripSeparator(){Name = "_separatorExportarDatos"};
                }
                return _mnuExportarDatos;
            }
        }             

        
        public DelegadoDeExportacionDeDatos AccionExportarDatos;
        public DelegadoSepararFechaDeHoraEnExportacion AccionSepararFechaDeHoraEnExportacion;

        public delegate void DelegadoDeExportacionDeDatos(bool soloFilasSeleccionados ,  bool incluirEncabezados );
        public delegate void DelegadoSepararFechaDeHoraEnExportacion( DataTable dt );
                                    
        private void _mnuExportarDatosTodoConEncabezados_Click(object sender ,  System.EventArgs e )
        {
            if ((AccionExportarDatos == null)) {
                ExportarDatos(false, true);
            }
            else {
                AccionExportarDatos.Invoke(false, true);
            }
        }
                                    
        private void _mnuExportarDatosSeleccionadoConEncabezados_Click(object sender ,  System.EventArgs e )
        {
            if ((AccionExportarDatos == null)) {
                ExportarDatos(true, true);
            }
            else {
                AccionExportarDatos.Invoke(true, true);
            }
        }
                                    
        public void ExportarDatos(bool soloFilasSeleccionadas =false, bool incluirEncabezados =false, bool crearArchivo =false)
        {
            try {
                var dt = new DataTable();
                DefinirFilas(ref dt, soloFilasSeleccionadas);
                try {
                    if (AccionSepararFechaDeHoraEnExportacion != null) {
                        AccionSepararFechaDeHoraEnExportacion.Invoke(dt);
                    }
                    else {
                        SeparaFechaDelaHoraHoraEnExportacion(dt);
                    }
                                            
                }
                catch (Exception ex) {
                }
                                        
                string nombreArchivo;
 
                SaveFileDialog dialog = new SaveFileDialog();
                // dialog.Filter = DataGridView_StandardRecurso.ExtensionExcel
                dialog.Filter = "Formato Excel(*.xlsx)|*.xlsx";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;
                if ((dialog.ShowDialog(this) == DialogResult.OK)) {
                    /*nombreArchivo = dialog.FileName;
                    object gestor = Tips.Services.GetManager(Of, IGestorDeExportador)[];
                    // Dim resultado As ResultadoDeExportar = gestor.ExportarAXls(dt, nombreArchivo)
                    ResultadoDeExportar resultado = gestor.ExportarAXls(dt, nombreArchivo, true);
                    if (resultado.Exito) {
                        MessageBoxTips.Show(DataGridView_StandardRecurso.DatosSeExportoCorrectamente, "Informaci�n", MessageBoxIcon.Information);
                        // TODO: Labeled Arguments not supported. Argument: 1 := 'mensaje'
                        // TODO: Labeled Arguments not supported. Argument: 2 := 'titulo'
                        // TODO: Labeled Arguments not supported. Argument: 3 := 'icono'
                    }
                    else if ((resultado.TipoDeError != eCodigoDeErrorExportar.Ninguno)) {
                        MessageBoxTips.Show(resultado.MensajeDeError, "Atenci�n", MessageBoxIcon.Error);
                        // TODO: Labeled Arguments not supported. Argument: 1 := 'mensaje'
                        // TODO: Labeled Arguments not supported. Argument: 2 := 'titulo'
                        // TODO: Labeled Arguments not supported. Argument: 3 := 'icono'
                    }
                    else {
                        throw resultado.Excepcion;
                    }*/
                                            
                }
                                        
            }
            catch (Exception ex) {
                MessageBox.Show("Los datos no pudieron exportarse");
            }
        }
                                    
        protected virtual void SeparaFechaDelaHoraHoraEnExportacion( DataTable dataTable) 
        {
            List<DataColumn> listColumACrear = new List<DataColumn>();
            foreach (DataColumn dataColumn in dataTable.Columns) {
                foreach (DataRow dataRow in dataTable.Rows) {
                    object o = dataRow[dataColumn];
                    if (o.GetType() is DateTime){
                        listColumACrear.Add(dataColumn);
                        break;
                    }
                    else if(o.GetType() is String){
                        DateTime fecha;
                        if (DateTime.TryParse(o.ToString(), out fecha)) {
                            listColumACrear.Add(dataColumn);
                            break;
                        }
                        else if (o!= null) {
                            break;
                        }
                    }
                }                      
            }
                                        
            if (listColumACrear.Any()) {
                if ((MessageBox.Show("�Desea ver los campos fecha dividido en dia y hora?") == DialogResult.Yes)) {
                    foreach (DataColumn dataColumn in listColumACrear) {
                        CrearColumna(dataTable, dataColumn);
                    }                     
                }                      
            }
        }
                
        private void CrearColumna(DataTable dataTable ,  DataColumn dataColumn){

                string nombreFecha = DefinirNombreColumna(string.Format("{0} (Fecha)", dataColumn.ColumnName), dataTable);
                dataTable.Columns.Add(new DataColumn(nombreFecha));
                dataTable.Columns[nombreFecha].SetOrdinal((dataTable.Columns[dataColumn.ColumnName].Ordinal + 1));
                foreach (DataRow dataRow in dataTable.Rows) {
                    object o = dataRow[dataColumn];
                    DateTime fecha;
                    if (DateTime.TryParse(o.ToString(), out fecha)) {
                        dataRow[nombreFecha] = fecha.ToString("dd/MM/yyyy");
                    }
                                            
                }
                                        
                string nombreHora = DefinirNombreColumna(string.Format("{0} (Hora)", dataColumn.ColumnName), dataTable);
                dataTable.Columns.Add(new DataColumn(nombreHora));
                dataTable.Columns[nombreHora].SetOrdinal((dataTable.Columns[dataColumn.ColumnName].Ordinal + 2));
                foreach (DataRow dataRow in dataTable.Rows) {
                    object o = dataRow[dataColumn];
                    DateTime fecha;
                    if (DateTime.TryParse(o.ToString(), out fecha)) {
                        dataRow[nombreHora] = fecha.ToString("HH:mm:ss");
                    }
                                            
                }

       
                                        
                                        dataTable.Columns.Remove(dataColumn);
        }
        protected string DefinirNombreColumna(string nombreColumna ,  DataTable dt , int  i =0)
        {
            string nombre;
            if ((i == 0)) {
                nombre = nombreColumna;
            }
            else {
                nombre = (nombreColumna + "_" + i.ToString());
            }
                                        
            if (!dt.Columns.Contains(nombre)) {
                return nombre;
            }
            else {
                i++;
                return DefinirNombreColumna(nombreColumna, dt, i);
            }
        }                  
        
        protected virtual void DefinirFilas(ref DataTable dt ,  bool soloFilasSeleccionadas)
        {
            // exportar datos a un archivo excel
            // DEFINIR LAS COLUMNAS INCLUIDAS
            List<DataGridViewColumn> columnasIncluidas = new List<DataGridViewColumn>();
            foreach (DataGridViewColumn columna in this.Columns) {
                if (!columna.Visible) continue;                                          
                if (columna == colChecks) continue;
                                            
                columnasIncluidas.Add(columna);
            }
                                        
            // DEFINIR LAS FILAS INCLUIDAS
            List<DataGridViewRow> filasIncluidas = new List<DataGridViewRow>();
            if (soloFilasSeleccionadas) {
                if (TieneChecks && CantidadItemsChequeados > 0) {
                    List<object> chequeados = new List<object>();
                    foreach (IEnumerable chequeado in ItemsChequeados) {
                        chequeados.Add(chequeado);
                    }
                                                
                    foreach (DataGridViewRow fila in this.Rows) {
                        if (chequeados.Contains(fila.DataBoundItem)) {
                            filasIncluidas.Add(fila);
                        }                           
                    }                           
                }
                else 
                {
                    if (CurrentRow!= null) filasIncluidas.Add(CurrentRow);
                }                             
            }
            else {
                foreach (DataGridViewRow fila in this.Rows) {
                    filasIncluidas.Add(fila);
                }                              
            }
                                        
            //  Una vez que estan definidas las columnas y filas incluidas, armar un datatable 
            // Dim dt As New DataTable
            // Determino las columnas del datatable
            for (int i = 0; i <= (columnasIncluidas.Count - 1); i++) {
                DataGridViewColumn columna = columnasIncluidas[i];
                string nombreColumna = columna.HeaderText;
                if (!columnasIncluidas.Contains(columna)) continue;
                                            
                if (nombreColumna != "") {
                    // verifico si ya existe una columna con ese nombre
                    nombreColumna = DefinirNombreColumna(nombreColumna, dt);
                    Type tipodatocolumna;
                    if (columna.GetType() is DataGridViewCheckBoxColumn) {
                        // Aunque el tipo de dato sea boolean, se lo toma como String
                        tipodatocolumna = typeof(string);
                        dt.Columns.Add(new DataColumn(nombreColumna, tipodatocolumna));
                    }
                    else if (columna.GetType() is DataGridViewTextBoxColumn) {
                        // sino puedo identificar el tipo de dato por su valor, por defecto lo exporto con tipo de dato "String"
                        tipodatocolumna = typeof(string);
                        if (filasIncluidas.Count > 0) {
                            DataGridViewTextBoxColumn dtextcolum = (DataGridViewTextBoxColumn)columna;
                            tipodatocolumna = dtextcolum.ValueType;
                            if (tipodatocolumna == null) tipodatocolumna = typeof(string);
                        }
                                                        
                        dt.Columns.Add(new DataColumn(nombreColumna, tipodatocolumna));
                    }
                    else {
                            //  en principio, si el tipo de columna no es de Texto o Chekbox, no la incluyo en la exportacion
                    }
                }
                else {
                    //  en principio, si la columna no tiene nombre no la incluyo en la exportacion
                }
            }
                                                
                    // Agrego los registros al datatable
            foreach (DataGridViewRow fila in filasIncluidas) {
                DataRow dr = dt.NewRow();
                int col = 0;
                for (int i = 0; i<= (columnasIncluidas.Count - 1); i++) {
                    DataGridViewColumn columna = columnasIncluidas[i];
                    string nombreColumna = columna.HeaderText;
                    if ((nombreColumna != "")) {
                        var celda = fila.Cells[columna.Index];
                        var valor = celda.Value;
                        if (columna.GetType() is DataGridViewCheckBoxColumn) {
                            if (valor!= null) {
                                dr[col] = (bool)valor ? "Si" : "No";
                            }
                            else {
                                dr[col] = "";
                            }                                             
                            col++;
                        }
                        else if (columna.GetType() is DataGridViewTextBoxColumn) {
                            dr[col] = valor;
                            col++;
                        }                                   
                    }                                  
                }
                                                    
                dt.Rows.Add(dr);
            }
        }
                                                                                 
        private bool _tieneCopiarDatos;
        public bool TieneCopiarDatos{
            get{
                return _tieneCopiarDatos;
                }
            set{
                _tieneCopiarDatos = value;
                }
        }

        private ToolStripMenuItem _mnuCopiarDatos;
        //private ToolStripMenuItem _mnuCopiarDatosTodoSinEncabezado;
        /*private ToolStripMenuItem _mnuCopiarDatosTodoConEncabezados;
        private ToolStripMenuItem _mnuCopiarDatosSeleccionadoSinEncabezado;
        private ToolStripMenuItem _mnuCopiarDatosSeleccionadoConEncabezados;*/
        private ToolStripSeparator _separatorCopiarDatos;
        protected ToolStripMenuItem ComandoCopiarDatos {
            get{
                CrearMenuCopiarDatos();
                return _mnuCopiarDatos;
            }
        }   

        private void CrearMenuCopiarDatos(bool forzarCreacion =false)
        {
            if (_mnuCopiarDatos == null || forzarCreacion) {
                _mnuCopiarDatos = new ToolStripMenuItem("Copiar datos"){ Name = "_mnuCopiarDatos"};
                _mnuCopiarDatosTodoSinEncabezado = new ToolStripMenuItem("Toda la Grilla sin encabezados");
                _mnuCopiarDatosTodoSinEncabezado.Click += new System.EventHandler(_mnuCopiarDatosTodoSinEncabezado_Click);
                _mnuCopiarDatosTodoConEncabezados = new ToolStripMenuItem("Toda la Grilla con encabezados");
                _mnuCopiarDatosTodoConEncabezados.Click += new System.EventHandler(_mnuCopiarDatosTodoConEncabezados_Click);
                _mnuCopiarDatosSeleccionadoSinEncabezado = new ToolStripMenuItem("Copiar datos filas seleccionadas sin encabezados");
                _mnuCopiarDatosSeleccionadoSinEncabezado.Click += new System.EventHandler(_mnuCopiarDatosSeleccionadoSinEncabezado_Click);
                _mnuCopiarDatosSeleccionadoConEncabezados = new ToolStripMenuItem("Copiar datos filas seleccionadas con encabezados");
                _mnuCopiarDatosSeleccionadoConEncabezados.Click += new System.EventHandler(_mnuCopiarDatosSeleccionadoConEncabezados_Click);

                _mnuCopiarDatos.DropDownItems.Add(_mnuCopiarDatosTodoSinEncabezado);
                _mnuCopiarDatos.DropDownItems.Add(_mnuCopiarDatosTodoConEncabezados);
                _mnuCopiarDatos.DropDownItems.Add(_mnuCopiarDatosSeleccionadoSinEncabezado);
                _mnuCopiarDatos.DropDownItems.Add(_mnuCopiarDatosSeleccionadoConEncabezados);

                _separatorCopiarDatos = new ToolStripSeparator(){Name = "_separatorCopiarDatos"};
            }
        }

        private void _mnuCopiarDatosTodoSinEncabezado_Click(object sender, System.EventArgs e)
        { 
            CopiarDatos(false, false);
        }
                                            
        private void _mnuCopiarDatosTodoConEncabezados_Click(object sender, System.EventArgs e)
        { 
        
        CopiarDatos(false, true);
        }
        
        private void _mnuCopiarDatosSeleccionadoSinEncabezado_Click(object sender, System.EventArgs e)
        { 
            CopiarDatos(true, false);
        }

        private void  _mnuCopiarDatosSeleccionadoConEncabezados_Click(object sender, System.EventArgs e)
        { 
                                            
                                            CopiarDatos(true, true);
        }
                                            
        public void CopiarDatos(bool soloFilasSeleccionadas =false, bool incluirEncabezados =false, bool crearArchivo = false)
        {
            try
            {
                // copiar datos de forma que puedan pegarse en excel
                StringBuilder sb = new StringBuilder();
                DataTable dt = new DataTable();
                CargarDataTable(ref dt, soloFilasSeleccionadas);
                try
                {
                    SeparaFechaDelaHoraHoraEnExportacion(dt);
                }
                catch (Exception ex)
                {
                }

                if (incluirEncabezados)
                {
                    for (int i = 0; i <= (dt.Columns.Count - 1); i++)
                    {
                        DataColumn columna = dt.Columns[i];
                        if (!dt.Columns.Contains(columna.ColumnName))
                        {
                            continue;
                        }

                        string columnName;
                        DataGridViewColumn mycolumn = this.Columns[columna.ColumnName];
                        if (mycolumn != null)
                        {
                            columnName = mycolumn.HeaderText;
                        }
                        else
                        {
                            columnName = columna.ColumnName;
                        }

                        object str = columnName.Replace("\r\n", Exportar_FinDeLineaEnCelda.ToString());
                        sb.Append(str);
                        if (i < (dt.Columns.Count - 1))
                        {
                            sb.Append(Exportar_FinDeColumna);
                        }
                    }
                }

                foreach (DataRow fila in dt.Rows)
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(Exportar_FinDeFila);
                    }

                    StringBuilder sbFila = new StringBuilder();
                    for (int i = 0; i <= (dt.Columns.Count - 1); i++)
                    {
                        DataColumn columna = dt.Columns[i];
                        object valor = fila[columna];
                        if (valor != null)
                        {
                            object str = valor.ToString().Replace("\r\n", Exportar_FinDeLineaEnCelda.ToString());
                            sbFila.Append(str);
                        }

                        if (i < (dt.Columns.Count - 1))
                        {
                            sbFila.Append(Exportar_FinDeColumna);
                        }
                    }
                    sb.Append(sbFila.ToString());
                }

                if (crearArchivo)
                {
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "Formato CSV(*.csv)|*.csv|Formato Excel(*.xls)|*.xls";
                    dialog.FilterIndex = 1;
                    dialog.RestoreDirectory = true;
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        System.IO.File.WriteAllText(dialog.FileName, sb.ToString());
                    }

                }

                Clipboard.SetText(sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        protected virtual void CargarDataTable(ref DataTable dt, bool soloFilasSeleccionadas)
        {
            Dictionary<string, int> dicCol = new Dictionary<string, int>();
            foreach (DataGridViewColumn columna in Columns) {
                if (!columna.Visible) continue;
                if (columna == colChecks) continue;
                                                
                // columnasIncluidas.Add(columna)
                dt.Columns.Add(columna.Name);
                dicCol.Add(columna.Name, columna.Index);
            }
                                            
            if (soloFilasSeleccionadas) {
                if (TieneChecks && (CantidadItemsChequeados > 0)) {
                    List<object> chequeados = new List<object>();
                    foreach (object chequeado in ItemsChequeados)
                    {
                        chequeados.Add(chequeado);
                    }
                                                    
                    foreach (DataGridViewRow fila in Rows) {
                        if (chequeados.Contains(fila.DataBoundItem)) {
                            DataRow dr = dt.NewRow();
                            foreach (KeyValuePair<string, int> keyValuePair in dicCol) {
                                if (string.IsNullOrEmpty(keyValuePair.Value.ToString())) continue;                              
                                dr[keyValuePair.Key] = fila.Cells[keyValuePair.Value].Value;
                            }
                                                            
                            dt.Rows.Add(dr);
                        }         
                    }                                  
                }
                else 
                {
                    if (CurrentRow != null)
                    {
                        DataRow dr = dt.NewRow();
                        foreach (KeyValuePair<string, int> keyValuePair in dicCol)
                        {
                            if (string.IsNullOrEmpty(keyValuePair.Value.ToString())) continue;

                            dr[keyValuePair.Key] = CurrentRow.Cells[keyValuePair.Value].Value;
                        }

                        dt.Rows.Add(dr);
                    }
                }                                                
            }
            else {
                foreach (DataGridViewRow fila in Rows) {
                    DataRow dr = dt.NewRow();
                    foreach (KeyValuePair<string, int> keyValuePair in dicCol) {
                        if (string.IsNullOrEmpty(keyValuePair.Value.ToString())) continue;
                                                        
                        dr[keyValuePair.Key] = fila.Cells[keyValuePair.Value].Value;
                    }
                                                    
                    dt.Rows.Add(dr);
                }                                
            }
        }              

        private string _Exportar_FinDeFila  = "\r\n";
        //[DefaultValue(Char.Parse("\r\n"))]
        public string Exportar_FinDeFila
        {
            get{

               return _Exportar_FinDeFila;
            }
            set{
                _Exportar_FinDeFila = value;
            }
        }

        private string _Exportar_FinDeColumna = "\t";
        //[DefaultValue(Char.Parse("\t"))]
        public string Exportar_FinDeColumna
        {
            get{

                    return _Exportar_FinDeColumna;
            }
            set{
                     _Exportar_FinDeColumna = value;
            }
        }         
 
        private string _Exportar_FinDeLineaEnCelda = ",";
        //[DefaultValue(",")]
        public string Exportar_FinDeLineaEnCelda
        {
            get{

                    return _Exportar_FinDeLineaEnCelda;
            }
            set{
                     _Exportar_FinDeLineaEnCelda = value;
            }
        }    
                                           
        public virtual void Sort(System.Windows.Forms.DataGridViewColumn dataGridViewColumn
            , System.ComponentModel.ListSortDirection direction)
        {
            if (dataGridViewColumn == null) return;
                                            
            if (dataGridViewColumn.DataGridView != this) return;
            
            IEnumerable _chequeadosAnteriores = null;
            if (this.TieneChecks && this.MantenerSeleccionAlReordenar) {
                _chequeadosAnteriores = this.ItemsChequeados;
            }
                                                
            object anterior = ItemSeleccionado;
            int colIndex = -1;
            if (CurrentCell != null) colIndex = CurrentCell.ColumnIndex;
            
            try {
                base.Sort(dataGridViewColumn, direction);
            }
            catch (Exception ex) {
            }
                                                    
            ItemSeleccionado = anterior;
            if (CurrentRow != null && (colIndex > -1)) 
                CurrentCell = CurrentRow.Cells[colIndex];
                                                    
            CargarDiccionario();
            if (_chequeadosAnteriores != null) 
                this.Chequear(_chequeadosAnteriores);
        }
                                                    
                                                
        public IEnumerable ItemsOrdenados
        {
            get{
                 return (from DataGridViewRow cadaRow in Rows select cadaRow.DataBoundItem).ToList();
            }
        }
        
        private bool _ResaltarCeldasEditables;
        public bool ResaltarCeldasEditables{
            get{
                return _ResaltarCeldasEditables;
            }
            set{
                _ResaltarCeldasEditables = value;
            }
        }

        protected virtual void OnDataBindingComplete(System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            if (ResaltarCeldasEditables) {
                foreach (DataGridViewColumn col in Columns) {
                    if (TieneChecks && (col == colChecks)) continue;
                                                    
                    if (col.IsDataBound) {
                        if (!col.ReadOnly) {
                            col.DefaultCellStyle.ForeColor = Color.Blue;
                        }
                                                        
                    }
                }
            }
                                            
            base.OnDataBindingComplete(e);
        }
       
        public void AutoAjustarColumnas(int max)
        {
            this.AutoResizeColumns();
            foreach ( DataGridViewColumn c in this.Columns) {
                if (c.Width > max) {
                    c.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    c.Width = max;
                }                                     
            }                         
        }
    }
}
                                        
