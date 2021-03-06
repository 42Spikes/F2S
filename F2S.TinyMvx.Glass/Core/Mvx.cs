using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using TinyIoC;

namespace F2S.TinyMvx
{
    public static class Mvx
    {
        private static TinyIoCContainer _container;
        private static MvxApplication _app;
        public static MvxApplication App
        {
            get { return _app; }
            set
            {
                if (_app != null) throw new Exception("App already set");
                _app = value;
                _container = MvxApplication.Container;
                if (_container == null) _container = new TinyIoCContainer();
            }
        }

        public static T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }

        public static T SafeResolve<T>() where T : class
        {
            if (_container == null) return default(T);
            if (!_container.CanResolve<T>()) return default(T);
            return _container.Resolve<T>();
        }

        public static void Register<T>(T instance) where T : class
        {
            _container.Register<T>(instance);
        }

        public static void Resolve<T>(this Action<T> action) where T : class
        {
            var o = SafeResolve<T>();
            if (o != null) action(o);
        }
    }
}