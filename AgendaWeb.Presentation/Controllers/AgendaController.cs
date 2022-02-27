using AgendaWeb.Infra.Data.Entities;
using AgendaWeb.Infra.Data.Interfaces;
using AgendaWeb.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaWeb.Presentation.Controllers
{
    public class AgendaController : Controller
    {
        //ATRIBUTO
        private readonly IEventoRepository _eventoRepository;
        
        //CONSTRUTOR P/ INICIALIZAR O ATRIBUTO
        public AgendaController(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }


        //MÉTODO QUE FAZ A  PÁGINA CADASTRO ABRIR
        public IActionResult Cadastro()
        {
            return View();
        }
        //ANNOTATION INDICA Q/ O MÉTODO SERÁ EXECUTADO NO SUBMIT
        [HttpPost]
        public IActionResult Cadastro(EventoCadastroViewModel model) //Controlador recebe dados da View model(da página ) 
        {
            //Verificar se todos sos campos passaram nas regras de validação 
            //Perguntando se todos os campos estão corretos
            if (ModelState.IsValid)
            {
                try
                {
                    //instanciando um evento
                    var evento = new Evento
                    {
                        //GERAR ID E PEGANDO TODOS CAMPOS DA MODEL (pegando da página)     
                        Id = Guid.NewGuid(),
                       Nome = model.Nome,
                       Data = Convert.ToDateTime(model.Data), //data convertida
                       Hora = TimeSpan.Parse(model.Hora), //hora convertida
                       Descricao = model.Descricao,
                       Prioridade = Convert.ToInt32(model.Prioridade),
                       DataInclusao = DateTime.Now,
                       DataAlteracao = DateTime.Now
                    };

                  
                    //Pegando o evento e enviando p/ repository e o repository vai gravar no banco de dados 
                    _eventoRepository.Create(evento);

                    //Jogando mensagem na tela se não tiver erro
                    TempData["Mensagem"] = $"Evento {evento.Nome}, cadastrado com sucesso.";

                    //LIMPANDO PÁGINA(FORMULÁRIO) P/ CADASTRAR PRÓXIMO EVENTO
                    ModelState.Clear();
                }
                catch(Exception e)
                {
                    //Jogando mensagem na tela se tiver erro
                    TempData["Mensagem"] = e.Message;
                }

            }
                return View();
        }
        //MÉTODO QUE FAZ A  PÁGINA CONSULTA ABRIR
        public IActionResult Consulta()
        {
            return View();
        }
        //ANNOTATION INDICA Q/ O MÉTODO SERÁ EXECUTADO NO SUBMIT
        [HttpPost] // Annotation, indica que o método será executado no SUBMIT.
        public IActionResult Consulta(EventoConsultaViewModel model)
        {
            //VERIFICANDO SE TODOS OS CAMPOS PASSARAM NAS REGRAS DE VALIDAÇÃO
            if (ModelState.IsValid)
            {

            }

            return View();
        }

        public IActionResult Edicao()
        {
            return View();
        }

        public IActionResult Relatorio()
        {
            return View();
        }
    }
}

