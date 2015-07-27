using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vdmNegocio;
using System.Web.Mvc;
using vdmWeb.Areas.Admin.Models;

namespace vdmWeb.Areas.Admin.Controllers
{
    public class ProdutoController : Controller
    {
        rdnProduto rdnProduto = new rdnProduto();
        rdnCategoria rdnCategoria = new rdnCategoria();
        rdnSubCategoria rdnSubCategoria = new rdnSubCategoria();

        public ActionResult Index()
        {
            Produto p = new Produto();
            return View(p);
        }


        public ViewResult ProdutoCadastrar()
        {
            ViewResult vr = new ViewResult();

            vr.ViewBag.ListaProduto = rdnProduto.listarTodos();
            vr.ViewBag.ListaCategoria = rdnCategoria.listarTodos();
            vr.ViewBag.ListaSubCategoria = rdnSubCategoria.listarTodos();

            vr.ViewName = "ProdutoCadastrar";

            return vr;
        }

        [HttpPost]
        public ViewResult ProdutoCadastrarSave(Produto p)
        {
            ViewResult vr = new ViewResult();

            rdnProduto rdn = new rdnProduto();

            Mensagem msg = new Mensagem();

            String resultado = rdnProduto.adicionar(p);

            try
            {
               int id = Convert.ToInt32(resultado);
               msg.Titulo = "Produto cadastrado com sucesso. Código: " + resultado;
               msg.Conteudo = "Deseja cadastrar imagens para o produto cadasrtado?";
               msg.botaoEsquerdoLink = "ProdutoCadastrarImagem";
               msg.botaoEsquerdoTitulo = "Sim";
            }
            catch (Exception e)
            {
                msg.Titulo = "Erro ao inserir.";
                msg.Conteudo = "Produto cadastrado com sucesso." + resultado + e; 
                
              
            }

            vr.ViewBag.Categorias = rdnCategoria.listarTodos();
            vr.ViewBag.SubCategorias = rdnSubCategoria.listarTodos();

            vr.ViewBag.Resultado = resultado;
            vr.ViewBag.Mensagem = msg;
            vr.ViewName = "ProdutoLista";
            return vr;
        }

        public ViewResult ProdutoLista()
        {
            ViewResult vr = new ViewResult();
            vr.ViewName = "ProdutoLista";

            rdnProduto rdn = new rdnProduto();

            vr.ViewBag.ListaProduto =  rdnProduto.listarTodos();
            vr.ViewBag.ListaCategoria = rdnCategoria.listarTodos();
            vr.ViewBag.ListaSubCategoria = rdnSubCategoria.listarTodos();

            return vr;
        }

        public ActionResult ProdutoCadastrarImagem()
        {
            return View();
        }


    }
}
