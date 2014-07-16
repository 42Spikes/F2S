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
using F2S.TinyMvx.Glass.Core;

namespace F2S.TinyMvx.Glass.Platform
{
    public class MvxCardSelectedCommand : MvxCommand
    {
        private Action<MvxViewModel> _action;
        public MvxCardSelectedCommand(Action<MvxViewModel> action)
        {
            _action = action;
        }

        public override void Execute(object originator = null)
        {
            _action((MvxViewModel) originator);
        }
    }
}