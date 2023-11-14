using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entity;
using Capa_Commerce;

namespace Capa_Presentacion
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        E_Agenda e_agenda = new E_Agenda();
        C_Agenda c_Agenda = new C_Agenda();


        private void button2_Click_1(object sender, EventArgs e)
        {
            string[] name = textBox1.Text.Split(' ');


            if (name.Count() > 1)
            {
                List<E_Agenda> agendas = c_Agenda.AgendaList(name[0], name[1]);

                Contact contact = new Contact();
                if (agendas.Count() > 0)
                {
                    contact.dataContacto(agendas[0]);
                    contact.Show();
                }
                else
                {
                    MessageBox.Show("Contacto no encontrado");



                }
            }
            else
            {
                MessageBox.Show("Contacto no encontrado");

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.Show();
        }
    }
}
