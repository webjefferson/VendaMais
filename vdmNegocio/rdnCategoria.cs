using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vdmNegocio
{
    public class rdnCategoria
    {
        GenericDAO dao = new GenericDAO();

        public String adicionar(Categoria categoria)
        {
           return dao.adicionar(categoria);
        }

        public List<Categoria> listarTodos()
        {
            dcDadosDataContext contexto = new dcDadosDataContext();

            List<Categoria> lista = new List<Categoria>();

            lista = contexto.Categoria.ToList();
                
            return lista;
            
        }
    }
}
