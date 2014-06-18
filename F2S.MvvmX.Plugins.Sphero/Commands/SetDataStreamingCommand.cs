using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2S.MvvmX.Plugins.Sphero.Commands
{
    public class SetDataStreamingCommand : BaseSpheroCommand
    {
        public SetDataStreamingCommand() : base(DeviceSphero, CommandSetDataStreaming)
        {
            
        }

        protected override byte[] GetPayloadBytes()
        {
            var data = new byte[13];
            data[0] = 0;
            data[1] = 20;
            data[2] = 0;
            data[3] = 1;
            data[4] = 0x80;
            data[5] = 0;
            data[6] = 0;
            data[7] = 0;
            data[8] = 1;
            data[9] = 0;
            data[10] = 0;
            data[11] = 0;
            data[12] = 0;
            return data;
        }
    }
}
