using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;

namespace pryIEFI
{
    internal class clsSocio
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private DataTable Lista = new DataTable(); 

        private string CadenaConexion = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=BD_Clientes.mdb";
        private string Tabla = "Socio";

        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source = BD_Clientes.mdb

        private Int32 idSocio;
        private String Nombre;
        private String Direccion;
        private Int32 idBarrio;
        private Int32 idActividad;
        private Decimal Deuda;

        ////////////////////////////////////////////////////////////////

        private Decimal saldos;
        private Int32 cantidad;
        private Decimal may;
        private Decimal men;
        private decimal saldo;
        private decimal acumulador;
        private decimal varmayor;
        private decimal varmenor = 1000000;

        public Int32 Actividad
        {
            get { return idActividad; }
            set { idActividad = value; }
        }

        public String nom
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public Decimal Deu
        {
            get { return Deuda; }
            set { Deuda = value; }
        }

        public Int32 DNI
        {
            get { return idSocio; }
            set { idSocio = value; }
        }

        public String direc
        {
            get { return Direccion; }
            set { Direccion = value; }
        }

        public Int32 Barrio
        {
            get { return idBarrio; }
            set { idBarrio = value; }
        }

        //////////////////////////////////////////////////////////////////////////////

        public Decimal Mayor
        {
            get { return may; }
            set { may = value; }
        }
        public Decimal Menor
        {
            get { return men; }
            set { men = value; }
        }
        public Decimal TotalSaldos
        {
            get { return saldos; }
            set { saldos = value; }
        }
        public Int32 CantidadSocios
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public Decimal PromedioSaldo
        {
            get
            {
                Decimal promedio = 0;
                if (cantidad != 0) promedio = saldos / cantidad;
                return promedio;
            }

        }


        public void Agregar()
        {
            try
            {
                String sql = "";
                sql = "INSERT INTO Socio (IdSocio,Nombre,Direccion,idBarrio,idActividad,Deuda)";
                sql = sql + "VALUES (" + idSocio + ",'" + Nombre + "', '" + Direccion + "'," + idBarrio + "," + idActividad + "," + Deuda + ")";
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }//funcionando

        public void Buscar(Int32 IdSocio)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();

                idSocio = 0;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == IdSocio)
                        {
                            idSocio = DR.GetInt32(0);
                            Nombre = DR.GetString(1);
                            Direccion = DR.GetString(2);
                            idBarrio = DR.GetInt32(3);
                            idActividad = DR.GetInt32(4);
                            Deuda = DR.GetDecimal(5);

                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void Eliminar(Int32 IdSocio)
        {
            try
            {
                String sql = "DELETE * FROM " + Tabla + " WHERE idSocio = " + IdSocio.ToString();
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }//funcionando

        public void Modificar(Int32 IdSocio)
        {
            try
            {
                String sql = "";
                sql = "UPDATE Socio SET Nombre = '" + Nombre + "', Direccion = '" + Direccion + "', idBarrio = " + idBarrio + ", idActividad = " + idActividad + ", Deuda = " + Deuda + " WHERE IdSocio = " + IdSocio;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void Consultar(String Nombre)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if ((DR.GetString(1) == Nombre))
                        {
                            idSocio = DR.GetInt32(0);
                            direc = DR.GetString(2);
                            idBarrio = DR.GetInt32(3);
                            idActividad = DR.GetInt32(4);
                            Deu = DR.GetDecimal(5);
                        }
                        
                    }
                }
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }//funcionando

        public void ListarSocios(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "select IdSocio, Nombre, Deuda from Socio order by IdSocio" ;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                Grilla.DataSource = DB.Tables[Tabla];
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void Reporte()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                StreamWriter AD = new StreamWriter("ReporteSocios.csv", false, Encoding.UTF8);
                AD.WriteLine("Listado de Socios\n");
                AD.WriteLine("DNI;Nombre;Saldo");
                int cantidad = 0;
                decimal saldo = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetDecimal(5) > 0)
                        {
                            AD.Write(DR.GetInt32(0));
                            AD.Write(";");
                            AD.Write(DR.GetString(1));
                            AD.Write(";");
                            AD.WriteLine(DR.GetDecimal(5));
                            cantidad++;
                            saldo += DR.GetDecimal(5);
                        }
                    }
                }
                AD.Write("Cantidad de socios:;");
                AD.WriteLine(cantidad);
                AD.Write("Total de Saldos:;");
                AD.WriteLine(saldo);
                conexion.Close();
                AD.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void LlenarComboNombres(ComboBox cboNombre)
        {
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = Tabla;
            adaptador = new OleDbDataAdapter(comando);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, Tabla);
            cboNombre.DataSource = ds.Tables[Tabla];
            cboNombre.ValueMember = "IdSocio";
            cboNombre.DisplayMember = "Nombre";
            conexion.Close();
        }//funcionando

        public void ImprimirTodosLosSocios(PrintPageEventArgs reporteA)
        {
            try
            {
                Font font = new Font("Arial", 12, FontStyle.Bold);
                Int32 f = 200;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando); //Adaptador de datos
                DataSet ds = new DataSet();
                adaptador.Fill(ds, Tabla);
                reporteA.Graphics.DrawString("Listado de todos los socios", font, Brushes.Black, 200, 100);
                foreach (DataRow fila in ds.Tables[Tabla].Rows)
                { 
                   reporteA.Graphics.DrawString(fila["IdSocio"].ToString(), font, Brushes.Black, 100, f);
                   reporteA.Graphics.DrawString(fila["Nombre"].ToString(), font, Brushes.Black, 200, f);
                   reporteA.Graphics.DrawString(fila["Deuda"].ToString(), font, Brushes.Black, 400, f);
                   f += 50;
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Error al imprimir el listado: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void ListarSociosActividad(DataGridView Grilla, Int32 idActividad)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = String.Format("select IdSocio, Nombre, Deuda from Socio WHERE idActividad = {0} order by IdSocio", idActividad);
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                Grilla.DataSource = DB.Tables[Tabla];
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void ListarSociosDeudores(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = String.Format("select IdSocio, Nombre, Deuda from Socio WHERE Deuda > 0 order by IdSocio");
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                Grilla.DataSource = DB.Tables[Tabla];
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void ListarSociosBarrio(DataGridView Grilla, Int32 idBarrio)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = String.Format("select IdSocio, Nombre, Deuda from Socio WHERE idBarrio = {0} order by IdSocio", idBarrio);
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                Grilla.DataSource = DB.Tables[Tabla];
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void ReporteSociosActividad(Int32 IdActividad)
        {
            try
            {
                Int32 cantidad = 0;

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                StreamWriter archivo = new StreamWriter("ReporteSociosActividad.csv", false, Encoding.UTF8);
                archivo.WriteLine("Listado de socios de una actividad");
                archivo.WriteLine();
                archivo.WriteLine("IdSocio;;Nombre;;Deuda");
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["idActividad"]) == IdActividad)
                        {
                            archivo.Write(fila["IdSocio"]);
                            archivo.Write(";;");
                            archivo.Write(fila["Nombre"]);
                            archivo.Write(";;");
                            archivo.WriteLine(fila["Deuda"]);
                            cantidad++;

                        }
                    }
                }
                archivo.WriteLine();
                archivo.Write("Cantidad:;");
                archivo.WriteLine(cantidad);
                archivo.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }//funcionando

        public void ReporteBarrio(Int32 Barrio)//funcionando
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet Ds = new DataSet();
                adaptador.Fill(Ds, Tabla);
                StreamWriter archivo = new StreamWriter("ReporteSociosBarrio.csv", false, Encoding.UTF8);
                archivo.WriteLine("Listado de socios por barrio");
                archivo.WriteLine();
                archivo.WriteLine("IdSocio;;Nombre;;Deuda");
                if (Ds.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in Ds.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["idBarrio"]) == Barrio)
                        {
                            archivo.Write(fila["IdSocio"]);
                            archivo.Write(";;");
                            archivo.Write(fila["Nombre"]);
                            archivo.Write(";;");
                            archivo.WriteLine(fila["Deuda"]);
                            cantidad++;
                            acumulador = acumulador + (decimal)fila["Deuda"];
                            saldo = Convert.ToDecimal(fila["Deuda"]);
                            if (varmayor <= saldo)
                            {
                                varmayor = saldo;
                            }
                            if (varmenor >= saldo)
                            {
                                varmenor = saldo;
                            }
                        }
                    }
                }
                archivo.WriteLine();
                archivo.Write("Cantidad:;");
                archivo.WriteLine(cantidad);
                archivo.Write("Total de saldos:;");
                archivo.WriteLine(acumulador);
                archivo.Write("Promedio de saldos:;");
                archivo.WriteLine(acumulador / cantidad);
                archivo.Write("Mayor saldo:;");
                archivo.WriteLine(varmayor);
                archivo.Write("Menor saldo:");
                archivo.WriteLine(varmenor);
                archivo.Close();
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public void MayorDeudaTodos(Label lblMayor2)//funcionando
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "select max (Deuda) from Socio";
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                lblMayor2.Text = DB.Tables[Tabla].Rows[0].ItemArray[0].ToString();
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public void MenorDeudaTodos(Label lblMenor2)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "select min (Deuda) from Socio ";
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                lblMenor2.Text = DB.Tables[Tabla].Rows[0].ItemArray[0].ToString();
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void PromedioTodos(Label lblPromedio2)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "select sum (Deuda) / count (Deuda) from Socio ";
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                lblPromedio2.Text = DB.Tables[Tabla].Rows[0].ItemArray[0].ToString();
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void MayorDeudaDeudores(Label lblMayor2)//funcionando
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "select max (Deuda) from Socio WHERE Deuda > 0";
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                lblMayor2.Text = DB.Tables[Tabla].Rows[0].ItemArray[0].ToString();
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public void MenorDeudaDeudores(Label lblMenor2)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "select min (Deuda) from Socio WHERE Deuda > 0";
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                lblMenor2.Text = DB.Tables[Tabla].Rows[0].ItemArray[0].ToString();
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void PromedioDeudores(Label lblPromedio2)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "select sum (Deuda) / count (Deuda) from Socio  WHERE Deuda > 0";
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                lblPromedio2.Text = DB.Tables[Tabla].Rows[0].ItemArray[0].ToString();
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void MayorDeudaActividad(Label lblMayor2, Int32 Filtrar)//funcionando
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = String.Format ("select max (Deuda) from Socio WHERE idActividad = " + Filtrar);
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                lblMayor2.Text = DB.Tables[Tabla].Rows[0].ItemArray[0].ToString();
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public void MenorDeudaActividad(Label lblMenor2, Int32 Filtrar)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "select min (Deuda) from Socio WHERE idActividad = " + Filtrar;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                lblMenor2.Text = DB.Tables[Tabla].Rows[0].ItemArray[0].ToString();
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void PromedioActividad(Label lblPromedio2, Int32 Filtrar)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "select sum (Deuda) / count (Deuda) from Socio WHERE idActividad = " + Filtrar;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                lblPromedio2.Text = DB.Tables[Tabla].Rows[0].ItemArray[0].ToString();
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void MayorDeudaBarrio(Label lblMayor2, Int32 Filtrar)//funcionando
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = String.Format("select max (Deuda) from Socio WHERE idBarrio = " + Filtrar);
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                lblMayor2.Text = DB.Tables[Tabla].Rows[0].ItemArray[0].ToString();
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public void MenorDeudaBarrio(Label lblMenor2, Int32 Filtrar)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "select min (Deuda) from Socio WHERE idBarrio = " + Filtrar;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                lblMenor2.Text = DB.Tables[Tabla].Rows[0].ItemArray[0].ToString();
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void PromedioBarrio(Label lblPromedio2, Int32 Filtrar)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "select sum (Deuda) / count (Deuda) from Socio WHERE idBarrio = " + Filtrar;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DB = new DataSet();
                adaptador.Fill(DB, Tabla);
                lblPromedio2.Text = DB.Tables[Tabla].Rows[0].ItemArray[0].ToString();
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        public void ImprimirActividad(PrintPageEventArgs ReporteAct)//funcionando
        {
            try
            {
                Font FuenteRepor = new Font("Arial", 10,
                FontStyle.Regular);
                Font H1 = new Font("Arial", 12, FontStyle.Bold);
                Font H2 = new Font("Arial", 11, FontStyle.Italic);
                Int32 y = 200;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                ReporteAct.Graphics.DrawString("Listado de socios por actividad", H1, Brushes.Black, 300, 50);
                ReporteAct.Graphics.DrawString("Codigo y Nombre", H2,
                Brushes.Black, 55, 150);
                if (DS.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["idActividad"]) == Actividad)
                        {
                            ReporteAct.Graphics.DrawString(fila["IdSocio"].ToString(), FuenteRepor, Brushes.Black, 100, y);
                            ReporteAct.Graphics.DrawString(fila["Nombre"].ToString(), FuenteRepor, Brushes.Black, 150, y);
                            ReporteAct.Graphics.DrawString(fila["Deuda"].ToString(), FuenteRepor, Brushes.Black, 300, y); y += 18;
                            cantidad++;
                            acumulador = acumulador + (decimal)fila
                            ["Deuda"];
                        }
                    }
                }
                ReporteAct.Graphics.DrawString("Cantidad de socios:" +
                cantidad, FuenteRepor, Brushes.Black, 100, 800);
                ReporteAct.Graphics.DrawString("Saldo total:" +
                acumulador, FuenteRepor, Brushes.Black, 100, 850);
                conexion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public void ImprimirBarrio(PrintPageEventArgs reporteA)
        {
            try
            {
                Font font = new Font("Arial", 12, FontStyle.Bold);
                Int32 f = 200;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds, Tabla);
                reporteA.Graphics.DrawString("Listado de socios por barrio", font, Brushes.Black, 200, 100);
                foreach (DataRow fila in ds.Tables[Tabla].Rows)
                {
                    if (fila["idBarrio"].ToString() == idBarrio.ToString())
                    {
                        reporteA.Graphics.DrawString(fila["IdSocio"].ToString(), font, Brushes.Black, 100, f);
                        reporteA.Graphics.DrawString(fila["Nombre"].ToString(), font, Brushes.Black, 200, f);
                        reporteA.Graphics.DrawString(fila["Deuda"].ToString(), font, Brushes.Black, 400, f);
                        f += 50;
                    }
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Error al imprimir el listado: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }//funcionando

        


    }
}
