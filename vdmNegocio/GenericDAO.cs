using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vdmNegocio
{
    class GenericDAO
    {
        dcDadosDataContext contexto = new dcDadosDataContext();        

        public String adicionar(Object o)
        {
            try
            {
                contexto.GetTable(o.GetType()).InsertOnSubmit(o);
                contexto.SubmitChanges();
                return "ok";
            }
            catch (Exception e)
            {
                //contexto.Transaction.Rollback();
                return "Erro ao inserir detalhes:" + e;
            }
        }

        public String editar(Object o)
        {
            try
            {
                contexto.GetTable(o.GetType()).Attach(o);
                contexto.SubmitChanges();
                return "ok";
            }
            catch (Exception e)
            {
                contexto.Transaction.Rollback();
                return "Erro ao editar detalhes:" + e;
            }
        }

        public String excluir(Object o)
        {


            try
            {
                contexto.GetTable(o.GetType()).Attach(o);
                contexto.GetTable(o.GetType()).DeleteOnSubmit(o);
                contexto.SubmitChanges();
                return "ok";
            }
            catch (Exception e)
            {
                contexto.Transaction.Rollback();
                return "Erro ao excluir detalhes:" + e;
            }
        }

    }
}
