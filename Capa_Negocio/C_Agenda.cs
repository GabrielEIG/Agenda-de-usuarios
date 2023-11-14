using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entity;
using Capa_Datos;

namespace Capa_Commerce
{
    public class C_Agenda
    {
        D_Agenda dataAgenda = new D_Agenda();

        public List<E_Agenda> AgendaList(string firstName, string lastName)
        {
            return dataAgenda.AgendaList(firstName, lastName);
        }

        public void InsertAgenda(E_Agenda agenda)
        {
           dataAgenda.InsertAgenda(agenda);
        }

        public void UpdateAgenda(E_Agenda agenda)
        {
            dataAgenda.UpdateAgenda(agenda);
        }
        public void DeleteAgenda(int id)
        {
            dataAgenda.DeleteAgenda(id);
        }

    }
}
