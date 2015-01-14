using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace Doy.Modules
{
    public class ModuleB:IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer unityContainer;

        public ModuleB(IRegionManager regionManager, IUnityContainer unityContainer)
        {
            this.regionManager = regionManager;
            this.unityContainer = unityContainer;
        }
        public void Initialize()
        {
            this.unityContainer.RegisterType<ModuleBView>();
            IRegion region = this.regionManager.Regions["RegionB"];
            var view = this.unityContainer.Resolve<ModuleBView>();
            region.Add(view);
        }
    }
}
