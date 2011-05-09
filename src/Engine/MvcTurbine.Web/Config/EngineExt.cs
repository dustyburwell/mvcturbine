﻿namespace MvcTurbine.Web.Config
{
    using System.Web.Mvc;
    using Blades;
    using Views;

    public static class EngineBladeExt 
    {
        public static Engine WithCoreBlade<TBlade>(this Engine engine)
            where TBlade : CoreBlade
        {            
            engine.EngineRegistration<TBlade, TBlade>();
            return engine;
        }

        public static Engine RemoveCoreBlade<TBlade>(this Engine engine)
            where TBlade : CoreBlade {
         
            engine.RemoveRegistration<TBlade>();
            return engine;
        }
    }

    /// <summary>
    /// Extension class for <see cref="Engine"/>.
    /// </summary>
    public static class EngineExt {
        /// <summary>
        /// Registers an <see cref="IControllerFactory"/> for the engine to use.
        /// </summary>
        /// <typeparam name="TFactory">Type that implements <see cref="IControllerFactory"/>.</typeparam>
        /// <param name="engine"></param>
        /// <returns></returns>
        public static Engine ControllerFactory<TFactory>(this Engine engine) 
            where TFactory : IControllerFactory {

            engine.EngineRegistration<IControllerFactory, TFactory>();
            return engine;
        }

        /// <summary>
        /// Registers a <see cref="IControllerActivator"/> for the engine to use.
        /// </summary>
        /// <typeparam name="TActivator">Type that implements <see cref="IControllerActivator"/>.</typeparam>
        /// <param name="engine"></param>
        /// <returns></returns>
        public static Engine ControllerActivator<TActivator>(this Engine engine)
            where TActivator : IControllerActivator {

            engine.EngineRegistration<IControllerActivator, TActivator>();
            return engine;
        }

        /// <summary>
        /// Registers a <see cref="IDependencyResolver"/> for the engine to use.
        /// </summary>
        /// <typeparam name="TResolver">Type that implements <see cref="IDependencyResolver"/>.</typeparam>
        /// <param name="engine"></param>
        /// <returns></returns>
        public static Engine DependencyResolver<TResolver>(this Engine engine) 
            where TResolver : IDependencyResolver {

            engine.EngineRegistration<IDependencyResolver, TResolver>();
            return engine;
        }

        /// <summary>
        /// Registers a <see cref="IActionInvoker"/> for the engine to use.
        /// </summary>
        /// <typeparam name="TInvoker">Type that implements <see cref="IActionInvoker"/>.</typeparam>
        /// <param name="engine"></param>
        /// <returns></returns>
        public static Engine ActionInvoker<TInvoker>(this Engine engine)
            where TInvoker : IActionInvoker {

            engine.EngineRegistration<IActionInvoker, TInvoker>();
            return engine;
        }

        /// <summary>
        /// Registers a <see cref="IEmbeddedViewResolver"/> for the engine to use.
        /// </summary>
        /// <typeparam name="TResolver">Type that implements <see cref="IEmbeddedViewResolver"/>.</typeparam>
        /// <param name="engine"></param>
        /// <returns></returns>
        public static Engine EmbeddedViewResolve<TResolver>(this Engine engine)
            where TResolver : IEmbeddedViewResolver {

            engine.EngineRegistration<IEmbeddedViewResolver, TResolver>();
            return engine;
        }
    }
}
