using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vdmNegocio;
using System.Web.Mvc;

namespace vdmWeb.Controllers
{
    public class HomeController : Controller
    {
        rdnProduto rdnProduto = new rdnProduto();
        rdnCategoria rdnCategoria = new rdnCategoria();
        rdnSubCategoria rdnSubCategoria = new rdnSubCategoria();

        public ViewResult Index()
        {
            ViewResult vr = new ViewResult();

            vr.ViewBag.Categorias = rdnCategoria.listarTodos();
            vr.ViewBag.SubCategorias = rdnSubCategoria.listarTodos();
            vr.ViewBag.Produtos = rdnProduto.listarTodos();
            
            
            vr.ViewName = "Index";

            return vr;
        }

        [HttpGet]
        public ViewResult Produto(Int32 idProduto)
        {
            ViewResult vr = new ViewResult();

            vr.ViewBag.Categorias = rdnCategoria.listarTodos();
            vr.ViewBag.SubCategorias = rdnSubCategoria.listarTodos();
            vr.ViewBag.Produto = rdnProduto.buscaPorId(idProduto);

            vr.ViewName = "Produto";

            return vr;


        }

        public ViewResult Login(Usuario u)
        {
            rdnLogin rdn = new rdnLogin();

            ViewResult vr = new ViewResult();

            vr.ViewBag.Categorias = rdnCategoria.listarTodos();
            vr.ViewBag.SubCategorias = rdnSubCategoria.listarTodos();
            vr.ViewBag.Produtos = rdnProduto.listarTodos();

            Usuario usuario = rdn.EftuaLogin(u);


            if (usuario != null )
            {
                vr.ViewName = "sucesso";
                Session["usuarioLogado"] = u;
            }
            else
            {
                vr.ViewName = ("index");
                vr.ViewBag.Usuario = u;
                vr.ViewBag.Mensagem = "Login ou senha inválidos.";
            }

            return vr;
        }

        public ViewResult ProdutoListar(int cat = 0, int subcat = 0)
        {
            List<Produto> listaProduto = new List<Produto>();

            ViewResult vr = new ViewResult();

            if (cat != 0)
            {
                listaProduto = rdnProduto.listarTodos(cat);
                vr.ViewBag.listaProduto = listaProduto;
            }

            if (subcat != 0)
            {
                listaProduto = rdnProduto.listarTodos(0, subcat);
                vr.ViewBag.listaProduto = listaProduto;
            }

            if (subcat == 0 && cat == 0)
            {
                listaProduto = rdnProduto.listarTodos();
                vr.ViewBag.listaProduto = listaProduto;
            }

            vr.ViewBag.Categorias = rdnCategoria.listarTodos();
            vr.ViewBag.SubCategorias = rdnSubCategoria.listarTodos();
            vr.ViewName = "ProdutoListar";

            return vr;
        }

    }
}
