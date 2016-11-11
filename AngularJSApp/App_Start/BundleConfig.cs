using System.Web;
using System.Web.Optimization;

namespace AngularJSApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                      "~/Scripts/angularjs/angular.js",
                      "~/Scripts/angularjs/angular-route.js"));

            bundles.Add(new ScriptBundle("~/bundles/appjs").Include(
                      "~/Scripts/app/app.js"));

            bundles.Add(new ScriptBundle("~/bundles/appjsconfig").Include(
                      "~/Scripts/app/config/routeConfig.js"));

            bundles.Add(new ScriptBundle("~/bundles/controllers").Include(
                      "~/Scripts/app/controllers/*.js"));

        }
    }
}
