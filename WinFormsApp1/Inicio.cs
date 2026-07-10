using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //este evento se produce una unica vez al ejecutar el form

            //esto se puede hacer desde las propiedades del combobox, en items se añaden.
            comboBox_enteraste.Items.Add("TikTok");
            comboBox_enteraste.Items.Add("Twitter");
        }

        private void bttn_enviar_nombre_Click(object sender, EventArgs e)
        {
            if (txt_ingreso_nombre.Text.Trim() != "")
            {

                //al hacer click en el boton enviar, se muestra este mensaje:
                //MessageBox.Show("Bienvenido/a") muestra el mensaje
                //llama al textbox de ingreso para que muestre lo que el usuario ingreso
                MessageBox.Show("Bienvenido/a " + txt_ingreso_nombre.Text.Trim() + " al PRODE de Sofi", "CHAVAL");

                lbNombres.Items.Add(txt_ingreso_nombre.Text.Trim());

                //para que se borre el nombre
                txt_ingreso_nombre.Text = "";
                //otra forma de hacer lo mismo
                txt_ingreso_nombre.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //para que el selected index no arranque en 0 por default.
            int seleccionado = comboBox_enteraste.SelectedIndex + 1;

            //validacion para que el usuario ingrese algo
            if (comboBox_enteraste.SelectedIndex != -1)
            {
                MessageBox.Show("Que bien que te enteraste por " + comboBox_enteraste.SelectedItem + "! orden " + seleccionado);
            }

            else
            {
                MessageBox.Show("Seleccione una opcion!");
            }
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            //para mostrar una sola persona
            //MessageBox.Show("El nombre seleccionado es: " + lbNombres.SelectedItem + "en la posicion: " + (lbNombres.SelectedIndex + 1));

            //para mostrar varias personas

            //recorre todos los elementos de la listbox y cada elemento q veas guardamelo en la variable nombre_persona
            foreach (string nombre_persona in lbNombres.SelectedItems)
            {
                MessageBox.Show("El nombre seleccionado es: " + nombre_persona + " en la posicion: " + (lbNombres.SelectedIndex + 1));
            }

            //SIRVE PARA SEPARAR CADENA DE CARACTERES
            string ejemplo1 = "Joel - Maria - Sofia";
            string p1 = ejemplo1.Split('-')[0]; // devuelve joel
            string p2 = ejemplo1.Split('-')[1]; // devuelve maria
            string p3 = ejemplo1.Split('-')[2]; // devuelve sofia

            MessageBox.Show(p1);
            MessageBox.Show(p2);
            MessageBox.Show(p3);


            //comparar si son el mismo nombre
            string p4 = "ARIEL";
            string p5 = "aRiEl";

            if (p4.ToUpper() == p5.ToUpper())
            {
                MessageBox.Show("Son el mismo nombre");
            }
            else
            {
                MessageBox.Show("Son nombres diferentes");
            }

            //reemplazar en nombre
            string p6 = "ARIEL".Replace('A', 'Y');
            MessageBox.Show(p6);
        }

        private void btn_cambio_video4_Click_1(object sender, EventArgs e)
        {
            Video4 video4 = new Video4();
            video4.Show();
            this.Hide();
        }
    }
}
