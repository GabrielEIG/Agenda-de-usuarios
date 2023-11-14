using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entity;
using Capa_Commerce;

namespace Capa_Presentacion
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
            DisableBox();
        }

        E_Agenda e_agenda = new E_Agenda();
        C_Agenda c_Agenda = new C_Agenda();
        int idContact;
        public void dataContacto(E_Agenda e_Agenda)
        {


            idContact = e_Agenda.ID;
            nombre.Text = e_Agenda.FirstName;
            apellido.Text = e_Agenda.LastName;
            fecha.SelectionEnd = e_Agenda.DateOfBirth;
            direccion.Text = e_Agenda.Address;
            mobilePhone.Text = e_Agenda.MobilePhone;


        }

        public void EnableBox()
        {
            nombre.Enabled = true;
            apellido.Enabled = true;
            fecha.Enabled = true;
            direccion.Enabled = true;
            mobilePhone.Enabled = true;
            button4.Enabled = true;

        }

        public void DisableBox()
        {
            nombre.Enabled = false;
            apellido.Enabled = false;
            fecha.Enabled = false;
            direccion.Enabled = false;
            mobilePhone.Enabled = false;
            button4.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(nombre.Enabled == true)
            DisableBox();
            else
            EnableBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            E_Agenda agenda = new E_Agenda();

            agenda.FirstName = nombre.Text;
            agenda.LastName = apellido.Text;
            agenda.DateOfBirth = fecha.SelectionStart.Date;
            agenda.Address = direccion.Text;
            agenda.MobilePhone = mobilePhone.Text;
            agenda.ID = idContact;


            c_Agenda.UpdateAgenda(agenda);
            MessageBox.Show("Datos guardados correctamente");
            DisableBox();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este contacto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                c_Agenda.DeleteAgenda(idContact);
                this.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
