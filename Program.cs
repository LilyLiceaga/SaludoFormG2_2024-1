using System;
using System.Windows.Forms;

namespace SaludoFormG2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //SaludoForm saludoForm = new SaludoForm();
            Application.Run(new SaludoForm()); //objeto anonimo como parametro dentro de app.run

        }
    }
}