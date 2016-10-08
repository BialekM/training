using System.Web;
using System.Web.Optimization;

namespace Toci.Mvcexample
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

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

            //Custom TOCI phoenix template bundles

            bundles.Add(new StyleBundle("~/Content/phoenix").Include(
                "~/Content/phoenix/socialico.css",
                "~/Content/phoenix/colors/color1.css",
                "~/Content/phoenix/colors/color2.css",
                "~/Content/phoenix/_icomoon.css",
                "~/Content/phoenix/animate.css",
                "~/Content/phoenix/calendar.css",
                "~/Content/phoenix/flexslider.css",
                "~/Content/phoenix/font-awesome.css",
                "~/Content/phoenix/icomoon.css",
                "~/Content/phoenix/owl.carousel.css",
                "~/Content/phoenix/shortcodes.css",
                "~/Content/phoenix/style.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/phoenix").Include(
                "~/Scripts/phoenix/datepicker.js",
                "~/Scripts/phoenix/gmap3.min.js",
                "~/Scripts/phoenix/html5shiv.js",
                "~/Scripts/phoenix/imagesloaded.min.js",
                "~/Scripts/phoenix/jquery-countTo.js",
                "~/Scripts/phoenix/jquery-waypoints.js",
                "~/Scripts/phoenix/jquery.bxslider.js",
                "~/Scripts/phoenix/jquery.easing.js",
                "~/Scripts/phoenix/jquery.easypiechart.min.js",
                "~/Scripts/phoenix/jquery.fitvids.js",
                "~/Scripts/phoenix/jquery.flexslider-min.js",
                "~/Scripts/phoenix/jquery.gomap-1.3.2.js",
                "~/Scripts/phoenix/jquery.isotope.min.js",
                "~/Scripts/phoenix/jquery.min.js",
                "~/Scripts/phoenix/jquery.sticky.js",
                "~/Scripts/phoenix/jquery.tweet.min.js",
                "~/Scripts/phoenix/main.js",
                "~/Scripts/phoenix/owl.carousel.js",
                "~/Scripts/phoenix/parallax.js",
                "~/Scripts/phoenix/respond.min.js",
                "~/Scripts/phoenix/select.js",
                "~/Scripts/phoenix/switcher.js"
                ));


        }
    }
}
