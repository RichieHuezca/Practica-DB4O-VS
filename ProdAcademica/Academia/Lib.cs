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
using Bd;

namespace Academia
{
    public partial class Lib : Form
    {
        public Lib()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);
            try
            {
                IList<Libro> consulta = BD.Query<Libro>();
                if (consulta.Count > 0)
                {
                    foreach (Libro al in consulta)
                    {
                        dataGridView1.Rows.Add(al.Titulo, al.Autor.Nombre, al.ISBN);
                    }
                }
            }
            finally
            {
                BD.Close();
            }
        }

        private void Lib_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);
            try
            {
                IList<Libro> consulta = BD.Query<Libro>();
                if (consulta.Count > 0)
                {
                    foreach (Libro al in consulta)
                    {
                        dataGridView1.Rows.Add(al.Titulo, al.Autor.Nombre, al.ISBN);
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

            if (TxtTitulo.Text != string.Empty && TxtTitulo.Text != string.Empty && TxtISBN.Text != string.Empty)
            {
                IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);
                Autor a = new Autor("");
                Libro L = new Libro("");

                L.Titulo = TxtTitulo.Text;
                a.Nombre = TxtAutor.Text;
                L.Autor = a;
                L.ISBN = int.Parse(TxtISBN.Text);


                try
                {
                    BD.Store(L);
                    BD.Commit();
                }
                finally
                {
                    BD.Close();
                }
                MessageBox.Show("EXITO!!! Se Guardo");
                TxtTitulo.Clear();
                TxtISBN.Clear();
                TxtAutor.Clear();

            }
            else
                MessageBox.Show("Hay campos Vacios");

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtTitulo.Text != string.Empty)
            {
                IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);
                string nom = TxtTitulo.Text;
                try
                {
                    IList<Libro> consulta = BD.Query<Libro>(z => z.Titulo == nom);
                    foreach (Libro item in consulta)
                    {
                        BD.Delete(item);
                        MessageBox.Show("Registro eliminado");
                        TxtTitulo.Clear();
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

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (TxtTitulo.Text != string.Empty)
            {
                IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);
                string Num = TxtTitulo.Text;
                Libro p = new Libro("");
                Autor at = new Autor("");
                p.Titulo = TxtTitulo.Text;
                IList<Libro> resultados = BD.Query<Libro>(a => a.Titulo == Num);
                // IList<Autor> resultado = BD.Query<Autor>(b => b.Nombre == Num);
                if (resultados.Count > 0)
                {
                    foreach (Libro l in resultados)
                    {
                        TxtTitulo.Text = p.Titulo;
                        //  p.Autor = TxtAutor.Text;
                        TxtAutor.Text = l.Autor.Nombre;
                        // TxtAutor.Text = at.Nombre;

                        //  TxtISBN.Text = int.Parse( a.ISBN);
                        TxtISBN.Text = l.ISBN.ToString();

                        /*  Autor a = new Autor("");
                          Libro L = new Libro("");

                          L.Titulo = TxtTitulo.Text;
                          a.Nombre = TxtAutor.Text;
                          L.Autor = a;
                          L.ISBN = int.Parse(TxtISBN.Text); */

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
            Libro pel = new Libro("");
            pel.Titulo = TxtTitulo.Text;
            IList<Libro> resultados = BD.Query<Libro>(x => x.Titulo == TxtTitulo.Text);
            if (resultados.Count > 0)
            {
                Libro v = new Libro("");
                v = resultados.First<Libro>();

                //Estudiante v = new Estudiante("","");
                // v.NoControl = TxtNumcontrol.Text;
                v.Autor.Nombre = TxtAutor.Text;
                v.ISBN = int.Parse(TxtISBN.Text);


                BD.Store(v);
                BD.Commit();
                MessageBox.Show("Exito!!! Se Modifico");
                TxtAutor.Clear();
                TxtISBN.Clear();
                TxtTitulo.Clear();


            }
            else
                MessageBox.Show("Error!!!  No se Modifico");
            TxtAutor.Clear();
            TxtISBN.Clear();
            TxtTitulo.Clear();

            btnGuardar.Visible = false;
            BD.Close();
            
                }
    }
}

