using eShop.UseCases.PluginInterfaces.StateStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.StateStore
{
    public class StateStoreBase : IStateStore
    {
        protected Action listeners;
        public void AddStateChangeListeners(Action listener) => this.listeners += listener;
        public void RemoveStateChangeListeners(Action listener) => this.listeners -= listener;
        public void BroadCastStateChnage()
        {
            if (this.listeners != null) this.listeners.Invoke();
        }

    }
}
