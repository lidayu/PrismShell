using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;

namespace Doy.Modules
{
    public class ModuleA:IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer unityContainer;

        public ModuleA(IRegionManager regionManager, IUnityContainer unityContainer)
        {
            this.regionManager = regionManager;
            this.unityContainer = unityContainer;

        }



        public void Initialize()
        {
            this.unityContainer.RegisterType<ModuleAView>();
            IRegion region = this.regionManager.Regions["RegionA"];
            var view = this.unityContainer.Resolve<ModuleAView>();
            region.Add(view);            
        }
    }
}
