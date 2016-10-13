using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using moduloInventario.Entities;
using MySql.Data.MySqlClient;

namespace moduloInventario
{
    public partial class Form1 : Form
    {
        private MySqlConnection conexion;
        private MySqlCommand cmd;
        private MySqlDataReader read;
        public static string dat = "server=localhost; database=restaurante; Uid=root; pwd=;";
        public static string nombre = "";
        public static MySqlDataAdapter combo;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actComboBox();
            inventario();
            cargarInsumos();
        }

        private MySqlConnection ObtenerConexion()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = dat;
            conexion.Open();
            return conexion;
        }

        private int validarId(string id, string tabla)
        {
            int cont = 0;

            try
            {
                cmd = new MySqlCommand("Select COUNT("+id+") from "+tabla+"", ObtenerConexion());
                read = cmd.ExecuteReader();

                if (read.Read() == true)
                {
                    cont = read.GetInt32(0);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return cont + 1;
        }

        private bool yaExisteInsumo(string nombre)
        {
            try
            {
                string existente = "";
                cmd = new MySqlCommand("select Nombre from insumo", ObtenerConexion());
                read = cmd.ExecuteReader();

                if (read.Read() == true)
                {
                    existente = read.GetString(0);
                }

                if (nombre == existente)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        private void ventanaEmergente()
        {
            vEmergente v = new vEmergente();
            v.ShowDialog(this);
        }

        private void actComboBox()
        {
            try
            {
                cmd = new MySqlCommand("select idCategoria,Nombre from categoria", ObtenerConexion());
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                cmbCategoria.ValueMember = "idCategoria";
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.DataSource = dt;

                MySqlCommand cmd1 = new MySqlCommand("select idMedida,Nombre from medida", ObtenerConexion());
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da2.Fill(dt1);

                cmbMedida.ValueMember = "idMedida";
                cmbMedida.DisplayMember = "Nombre";
                cmbMedida.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inventario()
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter myda = new MySqlDataAdapter("select i.idProducto, i.Nombre, c.Nombre, m.Nombre from insumo i inner join categoria c on c.idCategoria = i.idCategoria inner join medida m on m.idMedida = i.idMedida", ObtenerConexion());
                myda.Fill(dt);
                dgvInvenario.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insCompra(string fechaI, string fechaV, int cantidad, double precio, int idP)
        {
            try
            {
                cmd = new MySqlCommand("insert into lote (fechaIngreso,fechaVencimiento,cantidad,precio,Producto_idProducto) values ('" + fechaI + "','" + fechaV + "'," + cantidad + "," + precio + "," + idP + ");", ObtenerConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Compra Realizada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public int busIdInsumo(string nombre)
        {
            int cont = 0;

            try
            {
                cmd = new MySqlCommand("Select idProducto from insumo where Nombre = '" + nombre + "';", ObtenerConexion());
                read = cmd.ExecuteReader();

                if (read.Read() == true)
                {
                    cont = read.GetInt32(0);
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cont;
        }

        public void cargarInsumos()
        {

            try
            {
                cmd = new MySqlCommand("Select* from insumo ;", ObtenerConexion());
                combo = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                combo.Fill(dt);

                cBoxSelecInsumo.DisplayMember = "Nombre";
                cBoxSelecInsumo.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_crearInsumo_Click(object sender, EventArgs e)
        {
            int id = validarId("idProducto", "insumo");
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            int idCategoria = Convert.ToInt32(((System.Data.DataRowView)cmbCategoria.SelectedItem).Row.ItemArray[0].ToString());
            int idMedida = Convert.ToInt32(((System.Data.DataRowView)cmbMedida.SelectedItem).Row.ItemArray[0].ToString());

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Hay campos vacíos", "Adevertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    cmd = new MySqlCommand("insert into insumo values (" + id + ",'" + nombre + "','" + descripcion + "'," + idCategoria + "," + idMedida + ");", ObtenerConexion());
                    cmd.ExecuteNonQuery();
                    cargarInsumos();
                    MessageBox.Show("Insumo creado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            ventanaEmergente();
            int id = validarId("idCategoria", "categoria");

            try
            {
                cmd = new MySqlCommand("insert into categoria values ("+id+",'"+nombre+"')", ObtenerConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Categoría creada");
                actComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAgregarMedida_Click(object sender, EventArgs e)
        {
            ventanaEmergente();
            int id = validarId("idMedida", "medida");

            try
            {
                cmd = new MySqlCommand("insert into medida values (" + id + ",'" + nombre + "')", ObtenerConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medida creada");
                actComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (char.IsPunctuation(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnCompraInsumo_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            int idP;

            if ((txtCantInsumo.Text == "") || (txtPrecioInsumo.Text == ""))
            {
                MessageBox.Show("Ingrese Datos");
            }
            else
            {
                double precio = Convert.ToDouble(txtPrecioInsumo.Text);
                int cantidad = Convert.ToInt32(txtCantInsumo.Text);

                string insumo = cBoxSelecInsumo.Text;
                idP = busIdInsumo(insumo);

                string fechaVencimiento = Convert.ToString(dateTimePicker_fecCadInsumo.Value.Year + "-" + dateTimePicker_fecCadInsumo.Value.Month + "-" + dateTimePicker_fecCadInsumo.Value.Day);

                string fechaIngreso = Convert.ToString(thisDay.Year + "-" + thisDay.Month + "-" + thisDay.Day);

                //MessageBox.Show(idP + ";" + fechaVencimiento + ";" + fechaIngreso);

                insCompra(fechaIngreso, fechaVencimiento, cantidad, precio, idP);
            }
        }

    }
}
