using System.Web;
using System.Web.Optimization;

namespace vdmWeb
{
    public class BundleConfig
    {
        // Para mais informações sobre Bundling, visite http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Content/bootstrap/js/bootstrap.js", "~/Content/bootstrap/js/npm.js", "~/Content/bootstrap/js/jquery-2.1.4.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js", "~/Scripts/jquery-2.1.4.js", "~/Scripts/jquery-2.1.4.min.map"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));


            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css",
                "~/Content/metisMenu/dist/metisMenu.css",
                "~/Content/font-awesome/css/font-awesome.css",
                "~/Content/timeline.css",
                "~/Content/sb-admin-2.css",
                "~/Content/morrisjs/morris.css"
                ));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include("~/Content/bootstrap/css/bootstrap-theme.css",
                "~/Content/bootstrap/css/bootstrap-theme.css.map",
                "~/Content/bootstrap/css/bootstrap.css", "~/Content/bootstrap/css/bootstrap.css.map"));
        }
    }
}