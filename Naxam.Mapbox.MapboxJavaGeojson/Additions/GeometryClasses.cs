using System;
using Position = global::Com.Mapbox.Services.Commons.Models.Position;
using PositionList = global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position>;
using PositionListList = global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position>>;
using PositionListListList = global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position>>>;
using JPositionList = global::Android.Runtime.JavaList<global::Com.Mapbox.Services.Commons.Models.Position>;
using JPositionListList = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position>>;
using JPositionListListList = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Com.Mapbox.Services.Commons.Models.Position>>>;
using System.ComponentModel;

namespace Com.Mapbox.Services.Commons.Geojson
{
    public partial class LineString
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Java.Lang.Object JCoordinates
        {
            get
            {
                var native_value = JPositionList.ToLocalJniHandle(Coordinates);

                return Java.Lang.Object.GetObject<JPositionList>(native_value, Android.Runtime.JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                Coordinates = (PositionList)value;
            }
        }
    }

    public partial class MultiLineString
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Java.Lang.Object JCoordinates
        {
            get
            {
                var native_value = JPositionListList.ToLocalJniHandle(Coordinates);

                return Java.Lang.Object.GetObject<JPositionListList>(native_value, Android.Runtime.JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                Coordinates = (PositionListList)value;
            }
        }
    }

    public partial class Point
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Java.Lang.Object JCoordinates
        {
            get
            {
                return Coordinates;
            }
            set
            {
                Coordinates = (Position)value;
            }
        }
    }

    public partial class MultiPoint
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Java.Lang.Object JCoordinates
        {
            get
            {
                var native_value = JPositionList.ToLocalJniHandle(Coordinates);

                return Java.Lang.Object.GetObject<JPositionList>(native_value, Android.Runtime.JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                Coordinates = (PositionList)value;
            }
        }
    }

    public partial class Polygon
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Java.Lang.Object JCoordinates
        {
            get
            {
                var native_value = JPositionListList.ToLocalJniHandle(Coordinates);

                return Java.Lang.Object.GetObject<JPositionListList>(native_value, Android.Runtime.JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                Coordinates = (PositionListList)value;
            }
        }
    }

    public partial class MultiPolygon
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Java.Lang.Object JCoordinates
        {
            get
            {
                var native_value = JPositionListListList.ToLocalJniHandle(Coordinates);

                return Java.Lang.Object.GetObject<JPositionListListList>(native_value, Android.Runtime.JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                Coordinates = (PositionListListList)value;
            }
        }
    }
}
