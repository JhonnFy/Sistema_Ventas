﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using FontAwesome.Sharp;
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        //Variable De Tipo Usuario
        private static Usuario usuarioActual;
        //Variable Tipo Fromulario
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario objUsuario)
        {

            usuarioActual = objUsuario;

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUsuarioLogin.Text = usuarioActual.NombreCompleto;
            
        }

        private void lblUsuarioLogin_Click(object sender, EventArgs e)
        {

        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }


        private void Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsers());
        }

        //Activa El Color De Fondo Para El Item Seleccionado
        private void AbrirFormulario(IconMenuItem menu, Form formUser)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.WhiteSmoke;
            Usuarios.ForeColor = Color.SteelBlue;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formUser;
            formUser.TopLevel = false;
            formUser.FormBorderStyle = FormBorderStyle.None;
            formUser.Dock = DockStyle.Fill;
            formUser.BackColor = Color.WhiteSmoke;


            Contenedor.Controls.Add(formUser);
            formUser.Show();
        }


       

        private void Administrador_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_Click(object sender, EventArgs e)
        {

        }

        private void Compras_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Click(object sender, EventArgs e)
        {

        }

        private void Proveedores_Click(object sender, EventArgs e)
        {

        }

        private void Reportes_Click(object sender, EventArgs e)
        {

        }

        private void MiGitHub_Click(object sender, EventArgs e)
        {
            //Evento Para Abrir La Url
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/JhonnFy",
                UseShellExecute = true
            });           
        }

        private void menuTitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginV2 objLoginV2 = new LoginV2();
            objLoginV2.ShowDialog();
        }
    }
}
