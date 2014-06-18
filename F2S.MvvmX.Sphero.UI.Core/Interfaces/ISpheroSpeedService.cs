// <copyright file="ISpheroSpeedService.cs" company="Cirrious">
// (c) Copyright Cirrious. http://www.cirrious.com
// This source is subject to the Microsoft Public License (Ms-PL)
// Please see license.txt on http://opensource.org/licenses/ms-pl.html
// All other rights reserved.
// </copyright>
//  
// Project Lead - Stuart Lodge, Cirrious. http://www.cirrious.com - Hire me - I'm worth it!

using System.ComponentModel;

namespace F2S.MvvmX.Sphero.UI.Core.Interfaces
{
    public interface ISpheroSpeedService : INotifyPropertyChanged
    {
        // 0 to 100
        double SpeedPercent { get; set; }
    }
}