﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimRaceX.Telemetry.Comparer.Model
{
    public class CarTrackTelemetry : BaseModel
    {
        #region Fields
        private string _GameName;
        private string _CarName;
        private string _TrackName;
        private List<TelemetryData> _TelemetryDatas;
        private TimeSpan _LapTime;
        private string _PlayerName;
        private string _TrackCode;
        private string _Type;
        private DateTime? _Created;
        private bool _IsFixedSetup;
        private string _PluginVersion;
        //private bool _UseAsReferenceLap;
        #endregion

        override public string ToString() {
            return  $"{TrackCode} - {PlayerName} - {CarName} - {LapTime.ToString(@"mm\:ss\.fff")} - {SetupType}"; ;
        }

        #region Properties
        public string GameName
        {
            get { return _GameName; }
            set { _GameName = value; OnPropertyChanged(nameof(GameName)); }
        }
        public string CarName
        {
            get { return _CarName; }
            set { _CarName = value; OnPropertyChanged(nameof(CarName)); }
        }
        public string TrackName
        {
            get { return _TrackName; }
            set { _TrackName = value; OnPropertyChanged(nameof(TrackName)); }
        }
        public List<TelemetryData> TelemetryDatas
        {
            get { return _TelemetryDatas; }
            set { _TelemetryDatas = value; OnPropertyChanged(nameof(TelemetryDatas)); }
        }
        public TimeSpan LapTime
        {
            get { return _LapTime; }
            set { _LapTime = value; OnPropertyChanged(nameof(LapTime)); }
        }
        public string PlayerName
        {
            get { return _PlayerName; }
            set { _PlayerName = value; OnPropertyChanged(nameof(PlayerName)); }
        }

        public string TrackCode
        {
            get { return _TrackCode; }
            set { _TrackCode = value; OnPropertyChanged(nameof(TrackCode)); }
        }
        //public bool UseAsReferenceLap
        //{
        //    get { return _UseAsReferenceLap; }
        //    set { _UseAsReferenceLap = value; OnPropertyChanged(nameof(UseAsReferenceLap));}
        //}

        // here 1
        public string FormattedPlayerNameLapTime
        {
            get { return $"{PlayerName} - {LapTime.ToString(@"mm\:ss\.fff")} - {SetupType}"; }
        }
        public string FormattedPlayerNameCarLapTime
        {
            get { return $"{PlayerName} - {CarName} - {LapTime.ToString(@"mm\:ss\.fff")} - {SetupType}"; }
        }
        public string Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged(nameof(Type)); }
        }
        public DateTime? Created
        {
            get { return _Created; }
            set { _Created = value; OnPropertyChanged(nameof(Created)); }
        }
        public bool IsFixedSetup
        {
            get { return _IsFixedSetup; }
            set { _IsFixedSetup = value; OnPropertyChanged(nameof(IsFixedSetup)); }
        }
        public string SetupType
        {
            get { return IsFixedSetup ? "Fixed" : "Open"; }
        }
        public string PluginVersion
        {
            get { return _PluginVersion; }
            set { _PluginVersion = value; OnPropertyChanged(nameof(PluginVersion)); }
        }
        #endregion

        #region Cosntructor
        public CarTrackTelemetry()
        {
            _TelemetryDatas = new List<TelemetryData>();
        }
        #endregion
    }
}
