using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TinyMessenger;

namespace F2S.TinyMvx
{
    public class MvxShowViewModelMessage : TinyMessageBase
    {
        public string ViewModelTypeName { get; private set; }
        public object Parameters { get; private set; }

        public MvxShowViewModelMessage(object sender, string viewModelTypeName, object parameters = null)
            :base(sender)
        {
            ViewModelTypeName = viewModelTypeName;
            Parameters = parameters;
        }
    }
}