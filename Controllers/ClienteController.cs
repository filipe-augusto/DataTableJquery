using DataTableJquery.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DataTableJquery.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetClientes()
        {
            using (ClientesDbContext _context = new ClientesDbContext())
            {
                var listaClientes = getLista();//_context.Clientes.ToList();
                return Json(new { data = listaClientes }, JsonRequestBehavior.AllowGet);
            }
        }

        private List<Cliente> getLista()
        {
            return  new List<Cliente>()
            {
                new Cliente(){ ID = 1, ClienteNome = "filipe",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                new Cliente(){ ID = 2, ClienteNome = "filipe",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                 new Cliente(){ ID = 3, ClienteNome = "filipe",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                  new Cliente(){ ID = 4, ClienteNome = "augusto",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                new Cliente(){ ID = 5, ClienteNome = "alex",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                new Cliente(){ ID = 6, ClienteNome = "augusto",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                new Cliente(){ ID = 7, ClienteNome = "junir",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                new Cliente(){ ID = 8, ClienteNome = "otavio",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                new Cliente(){ ID = 9, ClienteNome = "maria",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                new Cliente(){ ID = 10, ClienteNome = "isaac",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                new Cliente(){ ID = 11, ClienteNome = "filipe",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                new Cliente(){ ID = 12, ClienteNome = "filipe",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                 new Cliente(){ ID = 13, ClienteNome = "filipe",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                  new Cliente(){ ID = 14, ClienteNome = "augusto",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                new Cliente(){ ID = 15, ClienteNome = "alex",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                new Cliente(){ ID = 16, ClienteNome = "augusto",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                new Cliente(){ ID = 17, ClienteNome = "junir",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                new Cliente(){ ID = 18, ClienteNome = "otavio",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                new Cliente(){ ID = 19, ClienteNome = "maria",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},

                new Cliente(){ ID = 20, ClienteNome = "isaac",ClienteEmail = "filipe@mail.com",
                ClienteEstado = "SP", ClienteFone="(11)5500-9580",
                ClienteImagem="https://app.maisbolao.com.br/arquivos/usuario/2e7db2e3-082f-4b6f-b641-7bf35f4f0231.jpeg"},


            };




        }

    }
}