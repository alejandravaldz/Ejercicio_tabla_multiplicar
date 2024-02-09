namespace Ejercicio_tabla_multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
         
            if (int.TryParse(txt_Numero.Text, out int numero))
            {
                
                lst_Multiplicar.Items.Clear();

              
                for (int i = 1; i <= 12; i++)
                {
                    int resultado = numero * i;
                    lst_Multiplicar.Items.Add($"{numero} x {i} = {resultado}");
                }
            }
          
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            lst_Multiplicar.Items.Clear();
            txt_Numero.Text = "";
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}