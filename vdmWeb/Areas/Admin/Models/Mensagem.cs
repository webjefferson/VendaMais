using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vdmNegocio;
using System.Web.Mvc;

namespace vdmWeb.Areas.Admin.Models
{
    public class Mensagem
    {
        public String Titulo { get; set; }
        public String Conteudo { get; set; }
        public String botaoEsquerdoLink { get; set; }
        public String botaoEsquerdoTitulo { get; set; }
        public String botaoDireitoLink { get; set; }
        public String botaoDireitoTitulo { get; set; }
    }
}