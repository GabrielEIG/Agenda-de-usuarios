using Capa_Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Commerce;

namespace Capa_Presentacion
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();

        }
        E_Agenda e_agenda = new E_Agenda();
        C_Agenda c_Agenda = new C_Agenda();
        private void button2_Click(object sender, EventArgs e)
        {
            E_Agenda agenda = new E_Agenda();
            agenda.FirstName = nombre.Text.ToLower();
            agenda.LastName = apellido.Text.ToLower();
            agenda.DateOfBirth = fecha.SelectionStart.Date;
            agenda.Address = direccion.Text;
            agenda.MobilePhone = mobilePhone.Text;
            Console.WriteLine(mobilePhone.Text);
            c_Agenda.InsertAgenda(agenda);
            MessageBox.Show("Contacto creado exitosamente!!!");
            this.Close();
        }

        private void mobilePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
