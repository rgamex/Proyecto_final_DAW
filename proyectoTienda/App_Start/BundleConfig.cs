using System.Web;
using System.Web.Optimization;

namespace proyectoTienda
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/cssBootstrap").Include(
                      
                      "~/Content/bootstrap.min.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/responsive").Include(

                       "~/Content/responsive.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/fonts").Include(

            
            "~/Content/font-awesome.min.css"
                      ));


            bundles.Add(new StyleBundle("~/Content/estilos").Include(

            "~/Content/style.css"
                      ));


            bundles.Add(new StyleBundle("~/Content/carrusel").Include(
                     "~/Content/owl.carousel.css"));

            bundles.Add(new ScriptBundle("~/Scripts/login").Include(
                "~/Scripts/login.js"
                ));


            bundles.Add(new ScriptBundle("~/Scripts/carruselScript").Include(
                        "~/Scripts/owl.carousel.min.js",
                        "~/Scripts/script.slider.js",
                        "~/Scripts/bxslider.min.js",
                        "~/Scripts/jquery.easing.1.3.min.js",
                        "~/Scripts/jquery.sticky.js",
                        "~/Scripts/main.js"
                        ));
        }
    }
}
