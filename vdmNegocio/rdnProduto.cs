using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vdmNegocio
{
    public class rdnProduto
    {
        dcDadosDataContext contexto = new dcDadosDataContext();
        GenericDAO dao = new GenericDAO();

        public String adicionar(Produto produto)
        {
            produto.data_inclusao = DateTime.Now;
            return dao.adicionar(produto);
        }
       
        public List<Produto> listarTodos(int cat = 0, int subcat = 0)
        {
            List<Produto> lista = new List<Produto>();

            if (cat != 0 && subcat == 0)
            {
                var qry = from p in contexto.Produto where p.id_categoria == cat select p;
                lista = qry.ToList();
            }

            if (subcat != 0 && cat == 0)
            {
                var qry = from p in contexto.Produto where p.id_categoria == subcat select p;
                lista = qry.ToList();
            }

            if (cat == 0 && subcat == 0)
            {
                lista = contexto.Produto.ToList();
            }

            return lista;

        }

        public Produto buscaPorId(Int32 idProduto)
        {
            var qry = from p in contexto.Produto where p.id_produto == idProduto select p;         
            return qry.Single();               
        }


    }
}
