using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Commands;


namespace Doy.Modules
{
    public class VM_ModuleB:IVM_ModuleB
    {
        public DelegateCommand RemoveModuleBCommand{get;set;}
    
        private readonly IModuleBController moduleBController; 


        public VM_ModuleB(IModuleBController controller)
        {
            this.moduleBController = controller;
            this.RemoveModuleBCommand = new DelegateCommand(this.RemoveModuleB);
        }

        private void RemoveModuleB()
        {
            this.moduleBController.RemoveModuleB();
        }


    }
}
