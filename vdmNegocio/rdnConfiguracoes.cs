using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vdmNegocio
{
    public class rdnConfiguracoes
    {
        dcDadosDataContext contexto = new dcDadosDataContext();

        public String editarConfiguracoes(Configuracoes config)
        {
            GenericDAO gDAO = new GenericDAO();

            return gDAO.editar(config);
        }

        public Configuracoes buscarConfig()
        {
            return contexto.Configuracoes.First();
        }
    }
}
