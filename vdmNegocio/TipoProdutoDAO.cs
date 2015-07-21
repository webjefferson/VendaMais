using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vdmNegocio
{
    public class TipoProdutoDAO
    {
        public String adicionar(Categoria categoria)
        {
            return "ERRO";
        }

        public List<ProdutoTipoUnidade> listarTodos()
        {
            dcDadosDataContext contexto = new dcDadosDataContext();

            List<ProdutoTipoUnidade> lista = new List<ProdutoTipoUnidade>();

            lista = contexto.ProdutoTipoUnidade.ToList();
                
            return lista;
            
        }
    }
}
