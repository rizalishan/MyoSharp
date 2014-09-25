﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using MyoSharp.Math;

namespace MyoSharp.Device
{
    public class AccelerometerDataEventArgs : MyoEventArgs
    {
        #region Constructors
        public AccelerometerDataEventArgs(Myo myo, DateTime timestamp, Vector3F accelerometer)
            : base(myo, timestamp)
        {
            this.Accelerometer = accelerometer;
        }
        #endregion

        #region Properties
        public Vector3F Accelerometer { get; private set; }
        #endregion
    }
}
