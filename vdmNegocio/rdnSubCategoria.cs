using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vdmNegocio
{
    public class rdnSubCategoria
    {
        public String adicionar(SubCategoria subcategoria)
        {
            dcDadosDataContext contexto = new dcDadosDataContext();

            try
            {
                contexto.SubCategoria.InsertOnSubmit(subcategoria);
                contexto.SubmitChanges();
                return "ok";
            }
            catch (Exception e)
            {
                return "Erro ao inserir detalhes:" + e;
            }
        }

        public List<SubCategoria> listarTodos()
        {
            dcDadosDataContext contexto = new dcDadosDataContext();

            List<SubCategoria> lista = new List<SubCategoria>();

            lista = contexto.SubCategoria.ToList();
                
            return lista;
            
        }
    }
}
