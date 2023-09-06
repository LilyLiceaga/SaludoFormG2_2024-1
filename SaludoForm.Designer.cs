﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace SaludoFormG2_2024_1
{
    internal class SaludoForm : Form
    {
        private Label lbNombre;
		private TextBox txtbNombre;
		private Button btnAceptar;
		private Button btnLimpiar;


		public void InitializeComponent()
        {
            //Redimensionando y configurando la ventana
            this.Size = new System.Drawing.Size(520,330); //600, 400
            this.Text = "Form Saludo";

            //Label:Ingresa tu nombre
            lbNombre = new Label(); //Instanciamos Objeto
            lbNombre.Text = "Ingresa tu nombre";
            lbNombre.Location = new Point(200, 100); //medidas en pixeles 
            this.Controls.Add(lbNombre);

            //TextBox: Ingresa tu nombre
            txtbNombre = new TextBox();
            txtbNombre.Location = new Point(200, 120);
			this.Controls.Add(txtbNombre);

            //Boton Aceptar
            btnAceptar = new Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new Point(160, 150);
			this.Controls.Add(btnAceptar);

			//Boton Limpiar
			btnLimpiar = new Button();
			btnLimpiar.Text = "Limpiar";
			btnLimpiar.Location = new Point(260, 150);
			this.Controls.Add(btnLimpiar);
		}
	}
}
