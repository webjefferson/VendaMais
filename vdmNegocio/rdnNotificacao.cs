using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vdmNegocio
{
    public class rdnNotificacao
    {
        dcDadosDataContext contexto = new dcDadosDataContext();

        public List<Notificacao> listarTodos()
        {

            List<Notificacao> lista = contexto.Notificacao.ToList();

            return lista;

        }
        public Tipo listarTipoID(Notificacao n)
        {
            var qry = from t in contexto.Tipo where t.idTipo == n.Tipo select t;
            return qry.Single();
        }
    }
}
