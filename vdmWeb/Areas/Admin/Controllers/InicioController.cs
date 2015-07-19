using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vdmNegocio;
using System.Web.Mvc;

namespace  vdmWeb.Areas.Admin.Controllers
{
    public class InicioController : Controller
    {
        //
        // GET: /Admin/Inicio/

        public ViewResult Index()
        {
            ViewResult vr = new ViewResult();

            if (Session["usuarioLogado"] != null)
            {
                vr.ViewName = "index";
            }
            else
            {
                vr.ViewName = "semacesso";
                vr.ViewBag.Notificacoes = "";
            }


            return vr;
        }

        public ActionResult Sair()
        {
            Session.Clear();

            return View("index");
        }
        public ActionResult Configuracoes()
        {
            return View("Configuracoes");
        }

    }
}
