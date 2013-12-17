﻿using System.Web.Optimization;

namespace Web.App_Start
{
	public class BootstrapBundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/js").Include(
				"~/Scripts/jquery-{version}.js",
				"~/Scripts/jquery-migrate-{version}.js",
				"~/Scripts/bootstrap.js",
				"~/Scripts/jquery.validate.js",
				"~/scripts/jquery.validate.unobtrusive.js",
				"~/Scripts/jquery.validate.unobtrusive-custom-for-bootstrap.js",
				"~/Scripts/datatables.js",
				"~/Scripts/DT_bootstrap.js",
				"~/Scripts/index.js"));

			bundles.Add(new StyleBundle("~/content/css").Include(
				"~/Content/bootstrap.css",
				"~/Content/body.css",
				"~/Content/bootstrap-responsive.css",
				"~/Content/bootstrap-mvc-validation.css",
				"~/Content/DT_bootstrap.css"));
		}
	}
}