using Prism.Mvvm;
using Prism.Navigation;

namespace EES.Core.Mvvm
{
    public class ViewModelBase : BindableBase, IDestructible
    {
        protected ViewModelBase()
        {

        }

        public virtual void Destroy()
        {

        }
    }
}
