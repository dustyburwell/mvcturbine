﻿namespace Mvc3Host {
    using Castle.Windsor;
    using Castle.MicroKernel.Registration;
    using MvcTurbine.ComponentModel;
    using MvcTurbine.Web;
    using MvcTurbine.Windsor;

    public class MvcApplication : TurbineApplication {
        static MvcApplication() {
            var locator = new WindsorServiceLocator();
            ServiceLocatorManager.SetLocatorProvider(() => locator);
        }
    }
}