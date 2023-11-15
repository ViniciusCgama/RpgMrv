using Microsoft.AspNetCore.Mvc;
using RpgMvc.Models;
using System.Net.Http;
using Newtonsoft.Json;


namespace RpgMvc.Controllers
{
    public class UsuariosController : Controller
    {
        public string uriBase = "http://lzsouza.somee.com/RpgApi/Usuarios/"; //endereço do somee do professor

        [HttpGet]
        public ActionResult Index ()
        {
            return View ("CadastrarUsuario");
        }

        [HttpPost]
        public async Task<ActionResult> RegistrarAsync (UsuarioViewModel u)
        {
            try
            {
                //proximo codigo aqui
                HttpClient httpClient = new HttpClient();
                string uriCompletar = "Registrar";

                var content = new StringContent(JsonConvert.SerializeObject(u));
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriCompletar, content); // uri base é o local do somee e o completar é o complemento

                string serialized = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    TempData ["Mensagem"] =
                        string.Format("Usuário {0} Registrado com sucesso! Faça o login para acessar.", u.Username);
                    return View ("AutenticarUsuario");
                }

                else
                {
                    throw new System.Exception(serialized);
                }
            }
            catch (System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message; //antes do = é uma variavel temporaria do c#
                return RedirectToAction("Index");
            }
        }
    }
}