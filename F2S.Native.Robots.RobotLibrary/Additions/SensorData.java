package orbotix.robot.sensor;

import orbotix.robot.internal.DeviceMessageEncoder;
import orbotix.robot.internal.DeviceMessageSerializable;

abstract class SensorData
  implements DeviceMessageSerializable
{
  private long mTimeStamp;

  public SensorData()
  {
    this.mTimeStamp = System.currentTimeMillis();
  }

  public long getTimeStamp() {
    return this.mTimeStamp;
  }

  public void encode(DeviceMessageEncoder encoder) {
    encoder.encodeValue("timeStamp", this.mTimeStamp);
  }
}