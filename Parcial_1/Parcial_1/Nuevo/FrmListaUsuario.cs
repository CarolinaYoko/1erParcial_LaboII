﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PetShop
{
    public partial class FrmListaUsuario : Form
    {
        static Usuario usuarioSeleccion;
        public FrmListaUsuario()
        {
            InitializeComponent();
        }

        public static Usuario UsuarioSeleccion
        {
            get { return FrmListaUsuario.usuarioSeleccion; }           
        }

        private void ActualizarDataGrid()
        {
            List<Usuario> auxLista = new List<Usuario>();

            foreach (Usuario usuario in Petshop.ListaUsuarios)
            {
                if (usuario.UsuarioActivo)
                {
                    auxLista.Add(usuario);
                }
            }

            dgUsuario.DataSource = auxLista;
            dgUsuario.AutoGenerateColumns = true;
                        
        }

        private void btnCerrarListaUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListaUsuario_Load(object sender, EventArgs e)
        {
            this.ActualizarDataGrid();
            this.SeleccionarDato();
        }

        private void FrmListaUsuario_Leave(object sender, EventArgs e)
        {
            this.SeleccionarDato();
        }

        private void SeleccionarDato()
        {
            int indiceFila = dgUsuario.CurrentRow is not null ? dgUsuario.CurrentRow.Index : -1; ;

            if (indiceFila >= 0)
            {
                DataGridViewRow fila = dgUsuario.Rows[indiceFila];
                int auxId = int.Parse(fila.Cells["IDUsuario"].Value.ToString());

                FrmListaUsuario.usuarioSeleccion = Empleado.BuscarEmpleadoPorId(auxId);

            }

        }

    }
}
