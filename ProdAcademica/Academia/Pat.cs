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
    public partial class Pat : Form
    {
        public Pat()
        {
            InitializeComponent();
        }

        private void BtnAGREGAR_Click(object sender, EventArgs e)
        {
            if (TxtTitulo.Text != string.Empty && TxtNumRegistro.Text != string.Empty)
            {
                IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);

                Patente P = new Patente("");
               // ProduccionAcademica pro = new ProduccionAcademica();

                P.Titulo = TxtTitulo.Text;
                P.NoRegistro = TxtNumRegistro.Text;
                

                try
                {
                    BD.Store(P);
                    BD.Commit();
                }
                finally
                {
                    BD.Close();
                }
                MessageBox.Show("EXITO!!! Se Guardo");
                TxtNumRegistro.Clear();
                TxtTitulo.Clear();

            }
            else
                MessageBox.Show("Hay campos Vacios");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataPat.Rows.Clear();
            // IObjectContainer BD = Db4oFactory.OpenFile("C://Users//Luilly//Documents//DB//DBOO.dboo");
            IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);
             try
            {
                IList<Patente> consulta = BD.Query<Patente>();
                if (consulta.Count > 0)
                {
                    foreach (Patente paten in consulta)
                    {
                        DataPat.Rows.Add(paten.Titulo, paten.NoRegistro);
                    }
                }
            }
            finally
            {
                BD.Close();
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TxtTitulo.Text != string.Empty)
            {
                IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);
                string nom = TxtTitulo.Text;
                try
                {
                    IList<Patente> consulta = BD.Query<Patente>(z => z.Titulo == nom);
                    foreach (Patente item in consulta)
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
                Patente p = new Patente("");
                p.Titulo = TxtTitulo.Text;
                IList<Patente> resultados = BD.Query<Patente>(a => a.Titulo == Num);
                if (resultados.Count > 0)
                {
                    foreach (Patente pa in resultados)
                    {
                        TxtTitulo.Text = pa.Titulo;
                        TxtNumRegistro.Text = pa.NoRegistro;
                        //  TxtISBN.Text = int.Parse( a.ISBN);
                       
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
                MessageBox.Show("Ingrese EL num titulo");

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);
            Patente pt = new Patente("");
            pt.Titulo = TxtTitulo.Text;
            IList<Patente> resultados = BD.Query<Patente>(x => x.Titulo == TxtTitulo.Text);
            if (resultados.Count > 0)
            {
                Patente v = new Patente("");
                v = resultados.First<Patente>();

                //Estudiante v = new Estudiante("","");
                //v.NoControl = TxtNumcontrol.Text;
                
                v.Titulo = TxtTitulo.Text;
                v.NoRegistro = TxtNumRegistro.Text;


                BD.Store(v);
                BD.Commit();
                MessageBox.Show("Exito!!! Se Modifico");
                TxtNumRegistro.Clear();
                TxtTitulo.Clear();


            }
            else
                MessageBox.Show("Error!!!  No se Modifico");
            TxtNumRegistro.Clear();
            TxtTitulo.Clear();


            btnGuardar.Visible = false;
                        
                BD.Close();
            
        }

        private void Pat_Load(object sender, EventArgs e)
        {
            DataPat.Rows.Clear();
            
            IObjectContainer BD = Db4oFactory.OpenFile(Util.NombreArchivo);
            try
            {
                IList<Patente> consulta = BD.Query<Patente>();
                if (consulta.Count > 0)
                {
                    foreach (Patente pate in consulta)
                    {
                        DataPat.Rows.Add(pate.Titulo, pate.NoRegistro);
                    }
                }
            }
            finally
            {
                BD.Close();
            }
        }
    }
}
