using System;
using System.Collections.Generic;
using System.Linq;

namespace F2S.TinyMvx
{
    public interface IMvxViewLocator
    {
        Type LocateViewTypeForViewModelType(Type viewModelType);
        Type LocateViewModelTypeForViewType(Type viewModelType);
    }

    public class MvxViewLocator : IMvxViewLocator
    {
        private readonly char[] _seps = { '.' };

        protected Dictionary<Type, Type> _model2view = new Dictionary<Type, Type>();
        protected Dictionary<Type, Type> _view2model = new Dictionary<Type, Type>();

        public virtual Type LocateViewTypeForViewModelType(Type viewModelType)
        {
            if (_model2view.ContainsKey(viewModelType)) return _model2view[viewModelType];
            return locateViewTypeForViewModelType(viewModelType);
        }
        public virtual Type LocateViewModelTypeForViewType(Type viewModelType)
        {
            if (_model2view.ContainsKey(viewModelType)) return _model2view[viewModelType];
            return locateViewModelTypeForViewType(viewModelType);
        }

        protected Type locateViewTypeForViewModelType(Type viewModelType)
        {
            var fullname = viewModelType.FullName;
            var name = viewModelType.Name;
            if (!name.EndsWith("ViewModel")) throw new Exception("Could not find view type for view model type: " + fullname);
            var parts = fullname.Split(_seps);
            if (parts[parts.Length-2] != "Views") throw new Exception("View is not in a 'Views' namespace");
            parts[parts.Length - 2] = "ViewModels";
            parts[parts.Length - 1] = name.Substring(0, name.Length - 6);
            var viewTypeName = string.Join(".", parts);
            var viewType = viewModelType.Assembly.GetType(viewTypeName);
            _model2view[viewModelType] = viewType;
            return viewType;
        }

        protected Type locateViewModelTypeForViewType(Type viewType)
        {
            var fullname = viewType.FullName;
            var name = viewType.Name;
            if (!name.EndsWith("View")) throw new Exception("Could not find view model type for view type: " + fullname);
            var parts = fullname.Split(_seps);
            if (parts[parts.Length - 2] != "Views") throw new Exception("View model is not in a 'ViewModels' namespace");
            parts[parts.Length - 2] = "ViewModels";
            
            var viewModelTypeName = string.Join(".", parts.Take(parts.Length - 1)) + "." + parts[parts.Length - 1] + "Model";
            var viewModelType = viewType.Assembly.GetType(viewModelTypeName);
            _view2model[viewType] = viewModelType;
            return viewModelType;
        }
    }
}