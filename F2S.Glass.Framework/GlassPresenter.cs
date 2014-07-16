using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Glass.Timeline;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace F2S.Glass.Framework
{
    public class GlassPresenter : IGlassPresenter
    {
        protected List<GlassActivity> _currentActivities = new List<GlassActivity>();
        protected GlassActivity _activeActivity;

        protected List<object> _activeItems = new List<object>();

        public void ActivityCreated(GlassActivity activity)
        {
            _currentActivities.Add(activity);
            _activeItems.Add(activity);

            var menu = activity as MenuActivity;
            if (menu != null)
            {
                menu.OptionsItemSelected += menu_OptionsItemSelected;
            }

            _activeActivity = activity;
        }

        public void ActivityDestroyed(GlassActivity activity)
        {
            if (_currentActivities.Contains(activity))
            {
                _currentActivities.Remove(activity);
            }
            if (_activeItems.Contains(activity))
            {
                _activeItems.Remove(activity);
            }
        }

        bool menu_OptionsItemSelected(object sender, MenuActivityOptionsItemSelectedEventArgs args)
        {
            var menuHandler = _activeService as IOptionMenuItemSelectedHandler;
            if (menuHandler != null)
            {
                if (menuHandler.ItemSelected != null)
                {
                    menuHandler.ItemSelected(sender, args);
                }
            }
            return true;
        }

        protected GlassService _activeService;
        public virtual void ServiceCreated(GlassService service)
        {
            _activeItems.Add(service);
            _activeService = service;
        }

        public virtual void ServiceDestroyed(GlassService service)
        {

        }

        public virtual void Present(GlassService service)
        {
            _activeService = service;
        }

        public virtual void Present(GlassService service, Type type, object parms = null)
        {
        }
    }
}