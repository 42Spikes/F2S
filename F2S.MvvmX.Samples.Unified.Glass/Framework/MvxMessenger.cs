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

namespace F2S.MvvmX.Samples.Unified.Glass.Framework
{
    internal abstract class MvxMessengerBase
    {
    
    }

    public class MvxMessenger : IMvxMessenger
    {
        private Dictionary<Type, List<Action<IMvxMessage>>> _map = new Dictionary<Type, List<Action<IMvxMessage>>>(); 
        public void Publish<T>(T message) where T : IMvxMessage
        {
            var toremove = new List<Action<IMvxMessage>>();
            var t = message.GetType();
            if (_map.ContainsKey(t))
            {
                var targets = _map[t];
                foreach (var ho in targets)
                {
                    try
                    {
                        var handler = (Action<IMvxMessage>) ho;
                        handler(message);
                    }
                    catch (Exception)
                    {
                        toremove.Add(ho);
                    }
                }
                toremove.ForEach(tr => _map[t].Remove(tr));
            }
        }

        public void Subscribe<T>(Action<T> handler) where T : IMvxMessage
        {
            var t = typeof (T);
            if (!_map.ContainsKey(t))
            {
                _map[t]= new List<Action<IMvxMessage>>();
            }
            _map[t].Add(m => handler((T)m));
        }
    }
}