using System;
using Position = global::Com.Mapbox.Services.Commons.Models.Position;
using PositionList = global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position>;
using PositionListList = global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position>>;
using PositionListListList = global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position>>>;
using JPositionList = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Commons.Models.Position>;
using JPositionListList = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position>>;
using JPositionListListList = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position>>>;
namespace Com.Mapbox.Services.Commons.Geojson
{
	public partial class LineString
	{
		public Java.Lang.Object Coordinates
		{
			get
			{
				var native_value = JPositionList.ToLocalJniHandle(Positions);

				return Java.Lang.Object.GetObject<JPositionList>(native_value, Android.Runtime.JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				Positions = (PositionList)value;
			}
		}
	}

	public partial class MultiLineString
	{
		public Java.Lang.Object Coordinates
		{
			get
			{
				var native_value = JPositionListList.ToLocalJniHandle(Positions);

				return Java.Lang.Object.GetObject<JPositionListList>(native_value, Android.Runtime.JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				Positions = (PositionListList)value;
			}
		}
	}

	public partial class Point
	{
		public Java.Lang.Object Coordinates
		{
			get
			{
				return Positions;
			}
			set
			{
				Positions = (Position)value;
			}
		}
	}

	public partial class MultiPoint
	{
		public Java.Lang.Object Coordinates
		{
			get
			{
				var native_value = JPositionList.ToLocalJniHandle(Positions);

				return Java.Lang.Object.GetObject<JPositionList>(native_value, Android.Runtime.JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				Positions = (PositionList)value;
			}
		}
	}

	public partial class Polygon
	{
		public Java.Lang.Object Coordinates
		{
			get
			{
				var native_value = JPositionListList.ToLocalJniHandle(Positions);

				return Java.Lang.Object.GetObject<JPositionListList>(native_value, Android.Runtime.JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				Positions = (PositionListList)value;
			}
		}
	}

	public partial class MultiPolygon
	{
		public Java.Lang.Object Coordinates
		{
			get
			{
				var native_value = JPositionListListList.ToLocalJniHandle(Positions);

				return Java.Lang.Object.GetObject<JPositionListListList>(native_value, Android.Runtime.JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				Positions = (PositionListListList)value;
			}
		}
	}
}
