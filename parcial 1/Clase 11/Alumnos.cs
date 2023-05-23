using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;

namespace REPASO
{
    class Alumnos
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        private int dni;
        private string nombre;
        private string sexo;
        private string foto;
        private int barrio;

        public int Dni
        {
            get => dni; 
            set => dni = value; 
        }

        public string Nombre
        {
            get =>nombre; 
            set => nombre = value; 
        }

        public string Sexo
        {
            get => sexo; 
            set => sexo = value; 
        }

        public string Foto
        {
            get => foto;
            set => foto = value; 
        }
        public int Barrio
        {
            get => barrio; 
            set => barrio = value; 
        }
        public Alumnos()
        {
            conector = new OleDbConnection(Properties.Settings.Default.CADENA);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Alumnos";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);
        }

        public void grabar()
        {
            DataRow fila = tabla.NewRow();
            fila["dni"] = dni;
            fila["nombre"] = nombre;
            fila["sexo"] = sexo;
            fila["foto"] = foto;
            fila["barrio"] = barrio;
            tabla.Rows.Add(fila);

            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
            adaptador.Update(tabla);

        }
    }
}
