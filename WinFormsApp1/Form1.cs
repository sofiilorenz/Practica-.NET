namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
        }
    }
}
