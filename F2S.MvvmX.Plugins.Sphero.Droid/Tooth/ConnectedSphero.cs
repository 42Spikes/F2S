// <copyright file="ConnectedSphero.cs" company="Cirrious">
// (c) Copyright Cirrious. http://www.cirrious.com
// This source is subject to the Microsoft Public License (Ms-PL)
// Please see license.txt on http://opensource.org/licenses/ms-pl.html
// All other rights reserved.
// </copyright>
//  
// Project Lead - Stuart Lodge, Cirrious. http://www.cirrious.com - Hire me - I'm worth it!

using System;
using System.Threading.Tasks;
using Android.Bluetooth;
using F2S.MvvmX.Plugins.Sphero.HackFileShare;
using F2S.MvvmX.Plugins.Sphero.Interfaces;

namespace F2S.MvvmX.Plugins.Sphero.Droid.Tooth
{
    public class ConnectedSphero : BaseSphero, IConnectedSphero
    {
        private readonly StreamSocketWrapper _spheroSocketWrapper;
        private readonly NonAwaitingConnectedSpheroRunner _runner;

        public ConnectedSphero(BluetoothDevice bluetoothDevice, BluetoothSocket socket)
            : base(bluetoothDevice)
        {
            _spheroSocketWrapper = new StreamSocketWrapper(socket);
            _runner = new NonAwaitingConnectedSpheroRunner(_spheroSocketWrapper);
            _runner.Disconnected += (sender, args) => RaiseDisconnected();
            _runner.Start();
        }

#warning TODO - Clearly IsConnected could do better....
        public bool IsConnected
        {
            get { return true; }
        }

        public void SendAndReceive(ISpheroCommand command, Action<ISpheroMessage> onSuccess, Action<Exception> onError)
        {
            _runner.SendAndReceive(command, onSuccess, onError);
        }

        public Task<ISpheroMessage> SendAndReceiveAsync(ISpheroCommand command)
        {
            var tcs = new TaskCompletionSource<ISpheroMessage>();

            _runner.SendAndReceive(
                command,
                success => { tcs.SetResult(success);},
                error => { tcs.SetException(error); });

            return tcs.Task;
        }
        
        public void Disconnect()
        {
            _runner.Disconnect();
            _spheroSocketWrapper.Dispose();
        }

        public event EventHandler Disconnected;

        public void RaiseDisconnected()
        {
            var handler = Disconnected;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
    }
}