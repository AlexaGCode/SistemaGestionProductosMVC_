using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionProductosMVC.Data.Repositories;
using SistemaGestionProductosMVC.Entities;
using SistemaGestionProductosMVC.Data.UnitOfWork;

namespace SistemaGestionProductosMVC_.Forms
{
    public partial class FrmGestionProductos : Form
    {
        private readonly IUnitOfWork _uow = new UnitOfWork(); // Aquí usamos Unit of Work
        private int? productoSeleccionadoId = null;
        public FrmGestionProductos()
        {
            InitializeComponent();
        }

        private void FrmGestionProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            dtgProductos.DataSource = _uow.ProductoRepository.ObtenerTodos();
            dtgProductos.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                var producto = new Producto
                {
                    Nombre = txtNombre.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Stock = int.Parse(txtStock.Text)
                };

                _uow.ProductoRepository.Insertar(producto);
                CargarProductos();
                LimpiarCampos();
            }
        }

        private void btnAlctualizar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionadoId.HasValue && ValidarCampos())
            {
                var producto = new Producto
                {
                    IdProducto = productoSeleccionadoId.Value,
                    Nombre = txtNombre.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Stock = int.Parse(txtStock.Text)
                };

                _uow.ProductoRepository.Actualizar(producto);
                CargarProductos();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionadoId.HasValue)
            {
                var confirm = MessageBox.Show("¿Estás seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _uow.ProductoRepository.Eliminar(productoSeleccionadoId.Value);
                    CargarProductos();
                    LimpiarCampos();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            productoSeleccionadoId = null;
            dtgProductos.ClearSelection();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return false;
            }
            if (!decimal.TryParse(txtPrecio.Text, out _) || !int.TryParse(txtStock.Text, out _))
            {
                MessageBox.Show("El precio y el stock deben ser números válidos.");
                return false;
            }
            return true;
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dtgProductos.Rows[e.RowIndex];
                productoSeleccionadoId = Convert.ToInt32(fila.Cells["IdProducto"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtStock.Text = fila.Cells["Stock"].Value.ToString();
            }
        }
    }
}
