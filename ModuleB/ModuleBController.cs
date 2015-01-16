using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System.Windows;

namespace Doy.Modules
{
    public class ModuleBController:IModuleBController
    {
        private readonly IRegionManager RegionManager;
        private readonly IUnityContainer Container;

        public ModuleBController(IRegionManager regionManager, IUnityContainer container)
        {
            this.RegionManager = regionManager;
            this.Container = container;
        
        }

        public void RemoveModuleB()
        {
            MessageBox.Show("In Controller for Removing ModuleB");
            IRegion region = this.RegionManager.Regions["RegionB"];
            var view = region.GetView("MB");
            region.Remove(view);
            
        }
    }
}
