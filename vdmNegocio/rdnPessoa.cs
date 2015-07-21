using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vdmNegocio
{
    public class rdnPessoa
    {
        public String adicionarPF(PessoaFisica pf)
        {
            dcDadosDataContext contexto = new dcDadosDataContext();

            Pessoa p = new Pessoa();

            try
            {
                contexto.Pessoa.InsertOnSubmit(p);

                pf.idPessoa = p.idPessoa;
                contexto.PessoaFisica.InsertOnSubmit(pf);
                contexto.SubmitChanges();
                return pf.idPessoa.ToString();
            }
            catch (Exception e)
            {
                return "Erro ao inserir detalhes:" + e;
            }
        }
    }
}
