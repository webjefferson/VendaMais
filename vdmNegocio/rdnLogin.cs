using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vdmNegocio
{
    public class rdnLogin
    {
        dcDadosDataContext contexto = new dcDadosDataContext();

        public Usuario EftuaLogin(Usuario usuario)
        {

            var qry = from u in contexto.Usuario where u.Senha == usuario.Senha && u.Login == usuario.Login select u;


            Usuario usuarioLogado = qry.SingleOrDefault();

            if (usuarioLogado != null)
            {
                return usuarioLogado;
            }
            else
            {
                return null;
            }


        }




    }
}
