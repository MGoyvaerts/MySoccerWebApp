using System.Web;
using System.Web.Optimization;

namespace MySoccerWebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval")
                .Include("~/Scripts/jquery.validate.min.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            RegisterLayoutCssBundle(bundles);
            RegisterLayoutJsBundle(bundles);

            BundleTable.EnableOptimizations = true;
        }

        private static void RegisterLayoutCssBundle(BundleCollection bundles)
        {
            var bundle = new ScriptBundle("~/bundles/layoutCss")
                .Include("~/Templates/public/assets/css/styles.min.css");
            bundles.Add(bundle);
        }
        private static void RegisterLayoutJsBundle(BundleCollection bundles)
        {
            var bundle = new ScriptBundle("~/bundles/layoutJs")
                .Include("~/Templates/public/assets/js/scripts.min.js");
            bundles.Add(bundle);
        }
    }
}
