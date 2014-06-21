using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace F2S.Glass.ApiDemo.Callbacks
{
    public interface IItemOnClickListenerCallback
    {
        void OnItemClick(AdapterView parent, View view, int position, long id);
    }

    public class OnItemClickListener : Java.Lang.Object, AdapterView.IOnItemClickListener
    {
        private IItemOnClickListenerCallback _callback;

        public OnItemClickListener(IItemOnClickListenerCallback callback)
        {
            _callback = callback;
        }

        public void OnItemClick(AdapterView parent, View view, int position, long id)
        {
            _callback.OnItemClick(parent, view, position, id);
        }
    }
}