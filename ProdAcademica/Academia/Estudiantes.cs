using Bd;
using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class Estu : Form
    {
        public Estu()
        {
            InitializeComponent();
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);
            try
            {
                IList<Estudiante> consulta = BD.Query<Estudiante>();
                if (consulta.Count > 0)
                {
                    foreach (Estudiante al in consulta)
                    {
                        dataGridView1.Rows.Add(al.NoControl, al.Nombre);
                    }
                }
            }
            finally
            {
                BD.Close();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);
            try
            {
                IList<Estudiante> consulta = BD.Query<Estudiante>();
                if (consulta.Count > 0)
                {
                    foreach (Estudiante al in consulta)
                    {
                        dataGridView1.Rows.Add(al.NoControl, al.Nombre);
                    }
                }
            }
            finally
            {
                BD.Close();
            }
        }

        private void BtnAGREGAR_Click(object sender, EventArgs e)
        {
            if (TxtNumcontrol.Text != string.Empty && TxtNombre.Text != string.Empty)
            {
                IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);

                Estudiante E = new Estudiante("","");

                E.NoControl = TxtNumcontrol.Text;
                E.Nombre = TxtNombre.Text;
               
                try
                {
                    BD.Store(E);
                    BD.Commit();
                }
                finally
                {
                    BD.Close();
                }
                MessageBox.Show("EXITO!!! Se Guardo");
                TxtNumcontrol.Clear();
                TxtNombre.Clear();
                
            }
            else
                MessageBox.Show("Hay campos Vacios");
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtNumcontrol.Text != string.Empty)
            {
                IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);
                string Num = TxtNumcontrol.Text;
                Estudiante p = new Estudiante("","");
                p.NoControl = TxtNumcontrol.Text;
                IList<Estudiante> resultados = BD.Query<Estudiante>(a => a.NoControl == Num);
                if (resultados.Count > 0)
                {
                    foreach (Estudiante a in resultados)
                    {
                        TxtNumcontrol.Text = a.NoControl;
                        TxtNombre.Text = a.Nombre;

                        btnGuardar.Visible = true;
                        //btncancelm.Visible = true;
                    }
                }
                else
                    MessageBox.Show("No Existe");
                //TxtClavep.Clear();
                BD.Close();

            }
            else
                MessageBox.Show("Ingrese EL num CONTROL");

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);
            Estudiante pel = new Estudiante("","");
            pel.NoControl = TxtNumcontrol.Text;
            IList<Estudiante> resultados = BD.Query<Estudiante>(x => x.NoControl == TxtNumcontrol.Text);
            if (resultados.Count > 0)
            {
                // IObjectSet result = BD.QueryByExample(pel);
                Estudiante v = new Estudiante("","");
                v = resultados.First<Estudiante>();
                //Estudiante v = new Estudiante("","");
                v.NoControl = TxtNumcontrol.Text;
                v.Nombre = TxtNombre.Text;
               
                BD.Store(v);
                BD.Commit();
                MessageBox.Show("Exito!!! Se Modifico");
                TxtNumcontrol.Clear();
                TxtNombre.Clear();
                
            }
            else
                MessageBox.Show("Error!!!  No se Modifico");
            BD.Close();
            TxtNumcontrol.Clear();
            TxtNombre.Clear();

            btnGuardar.Visible = false;
            BD.Close();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtNumcontrol.Text != string.Empty)
            {
                IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);
                string nom = TxtNumcontrol.Text;
                try
                {
                    IList<Estudiante> consulta = BD.Query<Estudiante>(z => z.NoControl == nom);
                    foreach (Estudiante item in consulta)
                    {
                        BD.Delete(item);
                        MessageBox.Show("Registro eliminado");
                        TxtNumcontrol.Clear();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    MessageBox.Show("No hay registros que coincidan");
                }
                finally
                {
                    BD.Close();
                }
            }
            else
                MessageBox.Show("Inserta la clave");
        }
    }
}
