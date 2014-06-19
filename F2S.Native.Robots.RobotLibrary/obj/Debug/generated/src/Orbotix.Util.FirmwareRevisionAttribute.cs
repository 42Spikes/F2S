using System;

namespace Orbotix.Util {

	[global::Android.Runtime.Annotation ("orbotix.util.FirmwareRevision")]
	public partial class FirmwareRevisionAttribute : Attribute
	{
		[global::Android.Runtime.Register ("max")]
		public double Max { get; set; }

		[global::Android.Runtime.Register ("min")]
		public double Min { get; set; }

	}
}
