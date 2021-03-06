﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VRage.Library.Utils;
using VRageMath;

namespace VRageRender
{
    public class MyRenderMessageSetCameraViewMatrix : IMyRenderMessage
    {
        public MatrixD ViewMatrix;
        public Matrix ProjectionMatrix;
        public Matrix NearProjectionMatrix;
        public float FOV;
        public float NearFOV;
        public float SafeNear;
        public float NearPlane;
        public float FarPlane;
        public float NearObjectsNearPlane;
        public float NearObjectsFarPlane;
        public Vector3D CameraPosition;

        public MyTimeSpan UpdateTime;

        MyRenderMessageType IMyRenderMessage.MessageClass { get { return MyRenderMessageType.StateChangeEvery; } }
        MyRenderMessageEnum IMyRenderMessage.MessageType { get { return MyRenderMessageEnum.SetCameraViewMatrix; } }
    }
}
