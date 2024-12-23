using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultasMVC.Views;
using ConsultasMVC.Models.DAO;
using ConsultasMVC.Models.DTO;


namespace ConsultasMVC.Controllers
{
    internal class ClienteController
    {
        ClienteView vista;
        public ClienteController(ClienteView vista)
        {
            this.vista = vista;
            vista.Load += new EventHandler(ClientList);
            vista.tbBuscar.TextChanged += new EventHandler(ClientList);
        }

        private void ClientList(object sender, EventArgs e)
        {
            ClienteDAO db = new ClienteDAO();
            vista.TablaClientes.DataSource = db.VerRegistros(vista.tbBuscar.Text);
        }


    }
}
