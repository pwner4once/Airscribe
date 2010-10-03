﻿using System;
using Microsoft.Dss.Core.Attributes;
using Microsoft.Dss.Core.Transforms;

#if NET_CF20
[assembly: ServiceDeclaration(DssServiceDeclaration.Transform, SourceAssemblyKey = @"cf.wiimote.y2007.m06, version=1.3.0.0, culture=neutral, publickeytoken=4c61577cd0577afe")]
#else
[assembly: ServiceDeclaration(DssServiceDeclaration.Transform, SourceAssemblyKey = @"wiimote.y2007.m06, version=1.3.0.0, culture=neutral, publickeytoken=4c61577cd0577afe")]
#endif
#if !URT_MINCLR
[assembly: System.Security.SecurityTransparent]
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif

namespace Dss.Transforms.TransformWiimote
{

    public class Transforms: TransformBase
    {

        public static object Transform_WiimoteLib_Proxy_WiimoteState_TO_WiimoteLib_WiimoteState(object transformFrom)
        {
            WiimoteLib.WiimoteState target = new WiimoteLib.WiimoteState();
            WiimoteLib.Proxy.WiimoteState from = transformFrom as WiimoteLib.Proxy.WiimoteState;
            target.AccelCalibrationInfo = (WiimoteLib.AccelCalibrationInfo)Transform_WiimoteLib_Proxy_AccelCalibrationInfo_TO_WiimoteLib_AccelCalibrationInfo(from.AccelCalibrationInfo);
            target.AccelState = (WiimoteLib.AccelState)Transform_WiimoteLib_Proxy_AccelState_TO_WiimoteLib_AccelState(from.AccelState);
            target.ButtonState = (WiimoteLib.ButtonState)Transform_WiimoteLib_Proxy_ButtonState_TO_WiimoteLib_ButtonState(from.ButtonState);
            target.IRState = (WiimoteLib.IRState)Transform_WiimoteLib_Proxy_IRState_TO_WiimoteLib_IRState(from.IRState);
            target.Battery = from.Battery;
            target.Rumble = from.Rumble;
            target.Extension = from.Extension;
            target.ExtensionType = (WiimoteLib.ExtensionType)((System.Byte)from.ExtensionType);
            target.NunchukState = (WiimoteLib.NunchukState)Transform_WiimoteLib_Proxy_NunchukState_TO_WiimoteLib_NunchukState(from.NunchukState);
            target.ClassicControllerState = (WiimoteLib.ClassicControllerState)Transform_WiimoteLib_Proxy_ClassicControllerState_TO_WiimoteLib_ClassicControllerState(from.ClassicControllerState);
            target.GuitarState = (WiimoteLib.GuitarState)Transform_WiimoteLib_Proxy_GuitarState_TO_WiimoteLib_GuitarState(from.GuitarState);
            target.LEDState = (WiimoteLib.LEDState)Transform_WiimoteLib_Proxy_LEDState_TO_WiimoteLib_LEDState(from.LEDState);
            return target;
        }


        public static object Transform_WiimoteLib_WiimoteState_TO_WiimoteLib_Proxy_WiimoteState(object transformFrom)
        {
            WiimoteLib.Proxy.WiimoteState target = new WiimoteLib.Proxy.WiimoteState();
            WiimoteLib.WiimoteState from = transformFrom as WiimoteLib.WiimoteState;
            target.AccelCalibrationInfo = (WiimoteLib.Proxy.AccelCalibrationInfo)Transform_WiimoteLib_AccelCalibrationInfo_TO_WiimoteLib_Proxy_AccelCalibrationInfo(from.AccelCalibrationInfo);
            target.AccelState = (WiimoteLib.Proxy.AccelState)Transform_WiimoteLib_AccelState_TO_WiimoteLib_Proxy_AccelState(from.AccelState);
            target.ButtonState = (WiimoteLib.Proxy.ButtonState)Transform_WiimoteLib_ButtonState_TO_WiimoteLib_Proxy_ButtonState(from.ButtonState);
            target.IRState = (WiimoteLib.Proxy.IRState)Transform_WiimoteLib_IRState_TO_WiimoteLib_Proxy_IRState(from.IRState);
            target.Battery = from.Battery;
            target.Rumble = from.Rumble;
            target.Extension = from.Extension;
            target.ExtensionType = (WiimoteLib.Proxy.ExtensionType)((System.Byte)from.ExtensionType);
            target.NunchukState = (WiimoteLib.Proxy.NunchukState)Transform_WiimoteLib_NunchukState_TO_WiimoteLib_Proxy_NunchukState(from.NunchukState);
            target.ClassicControllerState = (WiimoteLib.Proxy.ClassicControllerState)Transform_WiimoteLib_ClassicControllerState_TO_WiimoteLib_Proxy_ClassicControllerState(from.ClassicControllerState);
            target.GuitarState = (WiimoteLib.Proxy.GuitarState)Transform_WiimoteLib_GuitarState_TO_WiimoteLib_Proxy_GuitarState(from.GuitarState);
            target.LEDState = (WiimoteLib.Proxy.LEDState)Transform_WiimoteLib_LEDState_TO_WiimoteLib_Proxy_LEDState(from.LEDState);
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_LEDState_TO_WiimoteLib_LEDState(object transformFrom)
        {
            WiimoteLib.LEDState target = new WiimoteLib.LEDState();
            WiimoteLib.Proxy.LEDState from = (WiimoteLib.Proxy.LEDState)transformFrom;
            target.LED1 = from.LED1;
            target.LED2 = from.LED2;
            target.LED3 = from.LED3;
            target.LED4 = from.LED4;
            return target;
        }


        public static object Transform_WiimoteLib_LEDState_TO_WiimoteLib_Proxy_LEDState(object transformFrom)
        {
            WiimoteLib.Proxy.LEDState target = new WiimoteLib.Proxy.LEDState();
            WiimoteLib.LEDState from = (WiimoteLib.LEDState)transformFrom;
            target.LED1 = from.LED1;
            target.LED2 = from.LED2;
            target.LED3 = from.LED3;
            target.LED4 = from.LED4;
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_RumbleRequest_TO_WiimoteLib_RumbleRequest(object transformFrom)
        {
            WiimoteLib.RumbleRequest target = new WiimoteLib.RumbleRequest();
            WiimoteLib.Proxy.RumbleRequest from = (WiimoteLib.Proxy.RumbleRequest)transformFrom;
            target.Rumble = from.Rumble;
            return target;
        }


        public static object Transform_WiimoteLib_RumbleRequest_TO_WiimoteLib_Proxy_RumbleRequest(object transformFrom)
        {
            WiimoteLib.Proxy.RumbleRequest target = new WiimoteLib.Proxy.RumbleRequest();
            WiimoteLib.RumbleRequest from = (WiimoteLib.RumbleRequest)transformFrom;
            target.Rumble = from.Rumble;
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_ExtensionType_TO_WiimoteLib_ExtensionType(object transformFrom)
        {
            WiimoteLib.ExtensionType target = new WiimoteLib.ExtensionType();
            return target;
        }


        public static object Transform_WiimoteLib_ExtensionType_TO_WiimoteLib_Proxy_ExtensionType(object transformFrom)
        {
            WiimoteLib.Proxy.ExtensionType target = new WiimoteLib.Proxy.ExtensionType();
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_Point3F_TO_WiimoteLib_Point3F(object transformFrom)
        {
            WiimoteLib.Point3F target = new WiimoteLib.Point3F();
            WiimoteLib.Proxy.Point3F from = (WiimoteLib.Proxy.Point3F)transformFrom;
            target.X = from.X;
            target.Y = from.Y;
            target.Z = from.Z;
            return target;
        }


        public static object Transform_WiimoteLib_Point3F_TO_WiimoteLib_Proxy_Point3F(object transformFrom)
        {
            WiimoteLib.Proxy.Point3F target = new WiimoteLib.Proxy.Point3F();
            WiimoteLib.Point3F from = (WiimoteLib.Point3F)transformFrom;
            target.X = from.X;
            target.Y = from.Y;
            target.Z = from.Z;
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_Point3_TO_WiimoteLib_Point3(object transformFrom)
        {
            WiimoteLib.Point3 target = new WiimoteLib.Point3();
            WiimoteLib.Proxy.Point3 from = (WiimoteLib.Proxy.Point3)transformFrom;
            target.X = from.X;
            target.Y = from.Y;
            target.Z = from.Z;
            return target;
        }


        public static object Transform_WiimoteLib_Point3_TO_WiimoteLib_Proxy_Point3(object transformFrom)
        {
            WiimoteLib.Proxy.Point3 target = new WiimoteLib.Proxy.Point3();
            WiimoteLib.Point3 from = (WiimoteLib.Point3)transformFrom;
            target.X = from.X;
            target.Y = from.Y;
            target.Z = from.Z;
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_AccelCalibrationInfo_TO_WiimoteLib_AccelCalibrationInfo(object transformFrom)
        {
            WiimoteLib.AccelCalibrationInfo target = new WiimoteLib.AccelCalibrationInfo();
            WiimoteLib.Proxy.AccelCalibrationInfo from = (WiimoteLib.Proxy.AccelCalibrationInfo)transformFrom;
            target.X0 = from.X0;
            target.Y0 = from.Y0;
            target.Z0 = from.Z0;
            target.XG = from.XG;
            target.YG = from.YG;
            target.ZG = from.ZG;
            return target;
        }


        public static object Transform_WiimoteLib_AccelCalibrationInfo_TO_WiimoteLib_Proxy_AccelCalibrationInfo(object transformFrom)
        {
            WiimoteLib.Proxy.AccelCalibrationInfo target = new WiimoteLib.Proxy.AccelCalibrationInfo();
            WiimoteLib.AccelCalibrationInfo from = (WiimoteLib.AccelCalibrationInfo)transformFrom;
            target.X0 = from.X0;
            target.Y0 = from.Y0;
            target.Z0 = from.Z0;
            target.XG = from.XG;
            target.YG = from.YG;
            target.ZG = from.ZG;
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_AccelState_TO_WiimoteLib_AccelState(object transformFrom)
        {
            WiimoteLib.AccelState target = new WiimoteLib.AccelState();
            WiimoteLib.Proxy.AccelState from = (WiimoteLib.Proxy.AccelState)transformFrom;
            target.RawValues = (WiimoteLib.Point3)Transform_WiimoteLib_Proxy_Point3_TO_WiimoteLib_Point3(from.RawValues);
            target.Values = (WiimoteLib.Point3F)Transform_WiimoteLib_Proxy_Point3F_TO_WiimoteLib_Point3F(from.Values);
            return target;
        }


        public static object Transform_WiimoteLib_AccelState_TO_WiimoteLib_Proxy_AccelState(object transformFrom)
        {
            WiimoteLib.Proxy.AccelState target = new WiimoteLib.Proxy.AccelState();
            WiimoteLib.AccelState from = (WiimoteLib.AccelState)transformFrom;
            target.RawValues = (WiimoteLib.Proxy.Point3)Transform_WiimoteLib_Point3_TO_WiimoteLib_Proxy_Point3(from.RawValues);
            target.Values = (WiimoteLib.Proxy.Point3F)Transform_WiimoteLib_Point3F_TO_WiimoteLib_Proxy_Point3F(from.Values);
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_ButtonState_TO_WiimoteLib_ButtonState(object transformFrom)
        {
            WiimoteLib.ButtonState target = new WiimoteLib.ButtonState();
            WiimoteLib.Proxy.ButtonState from = (WiimoteLib.Proxy.ButtonState)transformFrom;
            target.A = from.A;
            target.B = from.B;
            target.Plus = from.Plus;
            target.Home = from.Home;
            target.Minus = from.Minus;
            target.One = from.One;
            target.Two = from.Two;
            target.Up = from.Up;
            target.Down = from.Down;
            target.Left = from.Left;
            target.Right = from.Right;
            return target;
        }


        public static object Transform_WiimoteLib_ButtonState_TO_WiimoteLib_Proxy_ButtonState(object transformFrom)
        {
            WiimoteLib.Proxy.ButtonState target = new WiimoteLib.Proxy.ButtonState();
            WiimoteLib.ButtonState from = (WiimoteLib.ButtonState)transformFrom;
            target.A = from.A;
            target.B = from.B;
            target.Plus = from.Plus;
            target.Home = from.Home;
            target.Minus = from.Minus;
            target.One = from.One;
            target.Two = from.Two;
            target.Up = from.Up;
            target.Down = from.Down;
            target.Left = from.Left;
            target.Right = from.Right;
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_IRState_TO_WiimoteLib_IRState(object transformFrom)
        {
            WiimoteLib.IRState target = new WiimoteLib.IRState();
            WiimoteLib.Proxy.IRState from = (WiimoteLib.Proxy.IRState)transformFrom;
            target.Mode = (WiimoteLib.IRMode)((System.Byte)from.Mode);

            // copy WiimoteLib.IRSensor[] target.IRSensors = from.IRSensors
            if (from.IRSensors != null)
            {
                target.IRSensors = new WiimoteLib.IRSensor[from.IRSensors.GetLength(0)];

                for (int d0 = 0; d0 < from.IRSensors.GetLength(0); d0++)
                    target.IRSensors[d0] = (WiimoteLib.IRSensor)Transform_WiimoteLib_Proxy_IRSensor_TO_WiimoteLib_IRSensor(from.IRSensors[d0]);
            }
            target.RawMidpoint = from.RawMidpoint;
            target.Midpoint = from.Midpoint;
            return target;
        }


        public static object Transform_WiimoteLib_IRState_TO_WiimoteLib_Proxy_IRState(object transformFrom)
        {
            WiimoteLib.Proxy.IRState target = new WiimoteLib.Proxy.IRState();
            WiimoteLib.IRState from = (WiimoteLib.IRState)transformFrom;
            target.Mode = (WiimoteLib.Proxy.IRMode)((System.Byte)from.Mode);

            // copy WiimoteLib.Proxy.IRSensor[] target.IRSensors = from.IRSensors
            if (from.IRSensors != null)
            {
                target.IRSensors = new WiimoteLib.Proxy.IRSensor[from.IRSensors.GetLength(0)];

                for (int d0 = 0; d0 < from.IRSensors.GetLength(0); d0++)
                    target.IRSensors[d0] = (WiimoteLib.Proxy.IRSensor)Transform_WiimoteLib_IRSensor_TO_WiimoteLib_Proxy_IRSensor(from.IRSensors[d0]);
            }
            target.RawMidpoint = from.RawMidpoint;
            target.Midpoint = from.Midpoint;
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_IRMode_TO_WiimoteLib_IRMode(object transformFrom)
        {
            WiimoteLib.IRMode target = new WiimoteLib.IRMode();
            return target;
        }


        public static object Transform_WiimoteLib_IRMode_TO_WiimoteLib_Proxy_IRMode(object transformFrom)
        {
            WiimoteLib.Proxy.IRMode target = new WiimoteLib.Proxy.IRMode();
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_IRSensor_TO_WiimoteLib_IRSensor(object transformFrom)
        {
            WiimoteLib.IRSensor target = new WiimoteLib.IRSensor();
            return target;
        }


        public static object Transform_WiimoteLib_IRSensor_TO_WiimoteLib_Proxy_IRSensor(object transformFrom)
        {
            WiimoteLib.Proxy.IRSensor target = new WiimoteLib.Proxy.IRSensor();
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_NunchukState_TO_WiimoteLib_NunchukState(object transformFrom)
        {
            WiimoteLib.NunchukState target = new WiimoteLib.NunchukState();
            WiimoteLib.Proxy.NunchukState from = (WiimoteLib.Proxy.NunchukState)transformFrom;
            target.CalibrationInfo = (WiimoteLib.NunchukCalibrationInfo)Transform_WiimoteLib_Proxy_NunchukCalibrationInfo_TO_WiimoteLib_NunchukCalibrationInfo(from.CalibrationInfo);
            target.AccelState = (WiimoteLib.AccelState)Transform_WiimoteLib_Proxy_AccelState_TO_WiimoteLib_AccelState(from.AccelState);
            target.RawJoystick = from.RawJoystick;
            target.Joystick = from.Joystick;
            target.C = from.C;
            target.Z = from.Z;
            return target;
        }


        public static object Transform_WiimoteLib_NunchukState_TO_WiimoteLib_Proxy_NunchukState(object transformFrom)
        {
            WiimoteLib.Proxy.NunchukState target = new WiimoteLib.Proxy.NunchukState();
            WiimoteLib.NunchukState from = (WiimoteLib.NunchukState)transformFrom;
            target.CalibrationInfo = (WiimoteLib.Proxy.NunchukCalibrationInfo)Transform_WiimoteLib_NunchukCalibrationInfo_TO_WiimoteLib_Proxy_NunchukCalibrationInfo(from.CalibrationInfo);
            target.AccelState = (WiimoteLib.Proxy.AccelState)Transform_WiimoteLib_AccelState_TO_WiimoteLib_Proxy_AccelState(from.AccelState);
            target.RawJoystick = from.RawJoystick;
            target.Joystick = from.Joystick;
            target.C = from.C;
            target.Z = from.Z;
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_NunchukCalibrationInfo_TO_WiimoteLib_NunchukCalibrationInfo(object transformFrom)
        {
            WiimoteLib.NunchukCalibrationInfo target = new WiimoteLib.NunchukCalibrationInfo();
            WiimoteLib.Proxy.NunchukCalibrationInfo from = (WiimoteLib.Proxy.NunchukCalibrationInfo)transformFrom;
            target.MinX = from.MinX;
            target.MidX = from.MidX;
            target.MaxX = from.MaxX;
            target.MinY = from.MinY;
            target.MidY = from.MidY;
            target.MaxY = from.MaxY;
            return target;
        }


        public static object Transform_WiimoteLib_NunchukCalibrationInfo_TO_WiimoteLib_Proxy_NunchukCalibrationInfo(object transformFrom)
        {
            WiimoteLib.Proxy.NunchukCalibrationInfo target = new WiimoteLib.Proxy.NunchukCalibrationInfo();
            WiimoteLib.NunchukCalibrationInfo from = (WiimoteLib.NunchukCalibrationInfo)transformFrom;
            target.MinX = from.MinX;
            target.MidX = from.MidX;
            target.MaxX = from.MaxX;
            target.MinY = from.MinY;
            target.MidY = from.MidY;
            target.MaxY = from.MaxY;
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_ClassicControllerState_TO_WiimoteLib_ClassicControllerState(object transformFrom)
        {
            WiimoteLib.ClassicControllerState target = new WiimoteLib.ClassicControllerState();
            WiimoteLib.Proxy.ClassicControllerState from = (WiimoteLib.Proxy.ClassicControllerState)transformFrom;
            target.CalibrationInfo = (WiimoteLib.ClassicControllerCalibrationInfo)Transform_WiimoteLib_Proxy_ClassicControllerCalibrationInfo_TO_WiimoteLib_ClassicControllerCalibrationInfo(from.CalibrationInfo);
            target.ButtonState = (WiimoteLib.ClassicControllerButtonState)Transform_WiimoteLib_Proxy_ClassicControllerButtonState_TO_WiimoteLib_ClassicControllerButtonState(from.ButtonState);
            target.RawJoystickL = from.RawJoystickL;
            target.RawJoystickR = from.RawJoystickR;
            target.JoystickL = from.JoystickL;
            target.JoystickR = from.JoystickR;
            target.RawTriggerL = from.RawTriggerL;
            target.RawTriggerR = from.RawTriggerR;
            target.TriggerL = from.TriggerL;
            target.TriggerR = from.TriggerR;
            return target;
        }


        public static object Transform_WiimoteLib_ClassicControllerState_TO_WiimoteLib_Proxy_ClassicControllerState(object transformFrom)
        {
            WiimoteLib.Proxy.ClassicControllerState target = new WiimoteLib.Proxy.ClassicControllerState();
            WiimoteLib.ClassicControllerState from = (WiimoteLib.ClassicControllerState)transformFrom;
            target.CalibrationInfo = (WiimoteLib.Proxy.ClassicControllerCalibrationInfo)Transform_WiimoteLib_ClassicControllerCalibrationInfo_TO_WiimoteLib_Proxy_ClassicControllerCalibrationInfo(from.CalibrationInfo);
            target.ButtonState = (WiimoteLib.Proxy.ClassicControllerButtonState)Transform_WiimoteLib_ClassicControllerButtonState_TO_WiimoteLib_Proxy_ClassicControllerButtonState(from.ButtonState);
            target.RawJoystickL = from.RawJoystickL;
            target.RawJoystickR = from.RawJoystickR;
            target.JoystickL = from.JoystickL;
            target.JoystickR = from.JoystickR;
            target.RawTriggerL = from.RawTriggerL;
            target.RawTriggerR = from.RawTriggerR;
            target.TriggerL = from.TriggerL;
            target.TriggerR = from.TriggerR;
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_ClassicControllerCalibrationInfo_TO_WiimoteLib_ClassicControllerCalibrationInfo(object transformFrom)
        {
            WiimoteLib.ClassicControllerCalibrationInfo target = new WiimoteLib.ClassicControllerCalibrationInfo();
            WiimoteLib.Proxy.ClassicControllerCalibrationInfo from = (WiimoteLib.Proxy.ClassicControllerCalibrationInfo)transformFrom;
            target.MinXL = from.MinXL;
            target.MidXL = from.MidXL;
            target.MaxXL = from.MaxXL;
            target.MinYL = from.MinYL;
            target.MidYL = from.MidYL;
            target.MaxYL = from.MaxYL;
            target.MinXR = from.MinXR;
            target.MidXR = from.MidXR;
            target.MaxXR = from.MaxXR;
            target.MinYR = from.MinYR;
            target.MidYR = from.MidYR;
            target.MaxYR = from.MaxYR;
            target.MinTriggerL = from.MinTriggerL;
            target.MaxTriggerL = from.MaxTriggerL;
            target.MinTriggerR = from.MinTriggerR;
            target.MaxTriggerR = from.MaxTriggerR;
            return target;
        }


        public static object Transform_WiimoteLib_ClassicControllerCalibrationInfo_TO_WiimoteLib_Proxy_ClassicControllerCalibrationInfo(object transformFrom)
        {
            WiimoteLib.Proxy.ClassicControllerCalibrationInfo target = new WiimoteLib.Proxy.ClassicControllerCalibrationInfo();
            WiimoteLib.ClassicControllerCalibrationInfo from = (WiimoteLib.ClassicControllerCalibrationInfo)transformFrom;
            target.MinXL = from.MinXL;
            target.MidXL = from.MidXL;
            target.MaxXL = from.MaxXL;
            target.MinYL = from.MinYL;
            target.MidYL = from.MidYL;
            target.MaxYL = from.MaxYL;
            target.MinXR = from.MinXR;
            target.MidXR = from.MidXR;
            target.MaxXR = from.MaxXR;
            target.MinYR = from.MinYR;
            target.MidYR = from.MidYR;
            target.MaxYR = from.MaxYR;
            target.MinTriggerL = from.MinTriggerL;
            target.MaxTriggerL = from.MaxTriggerL;
            target.MinTriggerR = from.MinTriggerR;
            target.MaxTriggerR = from.MaxTriggerR;
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_ClassicControllerButtonState_TO_WiimoteLib_ClassicControllerButtonState(object transformFrom)
        {
            WiimoteLib.ClassicControllerButtonState target = new WiimoteLib.ClassicControllerButtonState();
            WiimoteLib.Proxy.ClassicControllerButtonState from = (WiimoteLib.Proxy.ClassicControllerButtonState)transformFrom;
            target.A = from.A;
            target.B = from.B;
            target.Plus = from.Plus;
            target.Home = from.Home;
            target.Minus = from.Minus;
            target.Up = from.Up;
            target.Down = from.Down;
            target.Left = from.Left;
            target.Right = from.Right;
            target.X = from.X;
            target.Y = from.Y;
            target.ZL = from.ZL;
            target.ZR = from.ZR;
            target.TriggerL = from.TriggerL;
            target.TriggerR = from.TriggerR;
            return target;
        }


        public static object Transform_WiimoteLib_ClassicControllerButtonState_TO_WiimoteLib_Proxy_ClassicControllerButtonState(object transformFrom)
        {
            WiimoteLib.Proxy.ClassicControllerButtonState target = new WiimoteLib.Proxy.ClassicControllerButtonState();
            WiimoteLib.ClassicControllerButtonState from = (WiimoteLib.ClassicControllerButtonState)transformFrom;
            target.A = from.A;
            target.B = from.B;
            target.Plus = from.Plus;
            target.Home = from.Home;
            target.Minus = from.Minus;
            target.Up = from.Up;
            target.Down = from.Down;
            target.Left = from.Left;
            target.Right = from.Right;
            target.X = from.X;
            target.Y = from.Y;
            target.ZL = from.ZL;
            target.ZR = from.ZR;
            target.TriggerL = from.TriggerL;
            target.TriggerR = from.TriggerR;
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_GuitarState_TO_WiimoteLib_GuitarState(object transformFrom)
        {
            WiimoteLib.GuitarState target = new WiimoteLib.GuitarState();
            return target;
        }


        public static object Transform_WiimoteLib_GuitarState_TO_WiimoteLib_Proxy_GuitarState(object transformFrom)
        {
            WiimoteLib.Proxy.GuitarState target = new WiimoteLib.Proxy.GuitarState();
            return target;
        }


        public static object Transform_WiimoteLib_Proxy_GuitarButtonState_TO_WiimoteLib_GuitarButtonState(object transformFrom)
        {
            WiimoteLib.GuitarButtonState target = new WiimoteLib.GuitarButtonState();
            return target;
        }


        public static object Transform_WiimoteLib_GuitarButtonState_TO_WiimoteLib_Proxy_GuitarButtonState(object transformFrom)
        {
            WiimoteLib.Proxy.GuitarButtonState target = new WiimoteLib.Proxy.GuitarButtonState();
            return target;
        }

        static Transforms()
        {
            Register();
        }
        public static void Register()
        {
            AddProxyTransform(typeof(WiimoteLib.Proxy.WiimoteState), Transform_WiimoteLib_Proxy_WiimoteState_TO_WiimoteLib_WiimoteState);
            AddSourceTransform(typeof(WiimoteLib.WiimoteState), Transform_WiimoteLib_WiimoteState_TO_WiimoteLib_Proxy_WiimoteState);
            AddProxyTransform(typeof(WiimoteLib.Proxy.LEDState), Transform_WiimoteLib_Proxy_LEDState_TO_WiimoteLib_LEDState);
            AddSourceTransform(typeof(WiimoteLib.LEDState), Transform_WiimoteLib_LEDState_TO_WiimoteLib_Proxy_LEDState);
            AddProxyTransform(typeof(WiimoteLib.Proxy.RumbleRequest), Transform_WiimoteLib_Proxy_RumbleRequest_TO_WiimoteLib_RumbleRequest);
            AddSourceTransform(typeof(WiimoteLib.RumbleRequest), Transform_WiimoteLib_RumbleRequest_TO_WiimoteLib_Proxy_RumbleRequest);
            AddProxyTransform(typeof(WiimoteLib.Proxy.ExtensionType), Transform_WiimoteLib_Proxy_ExtensionType_TO_WiimoteLib_ExtensionType);
            AddSourceTransform(typeof(WiimoteLib.ExtensionType), Transform_WiimoteLib_ExtensionType_TO_WiimoteLib_Proxy_ExtensionType);
            AddProxyTransform(typeof(WiimoteLib.Proxy.Point3F), Transform_WiimoteLib_Proxy_Point3F_TO_WiimoteLib_Point3F);
            AddSourceTransform(typeof(WiimoteLib.Point3F), Transform_WiimoteLib_Point3F_TO_WiimoteLib_Proxy_Point3F);
            AddProxyTransform(typeof(WiimoteLib.Proxy.Point3), Transform_WiimoteLib_Proxy_Point3_TO_WiimoteLib_Point3);
            AddSourceTransform(typeof(WiimoteLib.Point3), Transform_WiimoteLib_Point3_TO_WiimoteLib_Proxy_Point3);
            AddProxyTransform(typeof(WiimoteLib.Proxy.AccelCalibrationInfo), Transform_WiimoteLib_Proxy_AccelCalibrationInfo_TO_WiimoteLib_AccelCalibrationInfo);
            AddSourceTransform(typeof(WiimoteLib.AccelCalibrationInfo), Transform_WiimoteLib_AccelCalibrationInfo_TO_WiimoteLib_Proxy_AccelCalibrationInfo);
            AddProxyTransform(typeof(WiimoteLib.Proxy.AccelState), Transform_WiimoteLib_Proxy_AccelState_TO_WiimoteLib_AccelState);
            AddSourceTransform(typeof(WiimoteLib.AccelState), Transform_WiimoteLib_AccelState_TO_WiimoteLib_Proxy_AccelState);
            AddProxyTransform(typeof(WiimoteLib.Proxy.ButtonState), Transform_WiimoteLib_Proxy_ButtonState_TO_WiimoteLib_ButtonState);
            AddSourceTransform(typeof(WiimoteLib.ButtonState), Transform_WiimoteLib_ButtonState_TO_WiimoteLib_Proxy_ButtonState);
            AddProxyTransform(typeof(WiimoteLib.Proxy.IRState), Transform_WiimoteLib_Proxy_IRState_TO_WiimoteLib_IRState);
            AddSourceTransform(typeof(WiimoteLib.IRState), Transform_WiimoteLib_IRState_TO_WiimoteLib_Proxy_IRState);
            AddProxyTransform(typeof(WiimoteLib.Proxy.IRMode), Transform_WiimoteLib_Proxy_IRMode_TO_WiimoteLib_IRMode);
            AddSourceTransform(typeof(WiimoteLib.IRMode), Transform_WiimoteLib_IRMode_TO_WiimoteLib_Proxy_IRMode);
            AddProxyTransform(typeof(WiimoteLib.Proxy.IRSensor), Transform_WiimoteLib_Proxy_IRSensor_TO_WiimoteLib_IRSensor);
            AddSourceTransform(typeof(WiimoteLib.IRSensor), Transform_WiimoteLib_IRSensor_TO_WiimoteLib_Proxy_IRSensor);
            AddProxyTransform(typeof(WiimoteLib.Proxy.NunchukState), Transform_WiimoteLib_Proxy_NunchukState_TO_WiimoteLib_NunchukState);
            AddSourceTransform(typeof(WiimoteLib.NunchukState), Transform_WiimoteLib_NunchukState_TO_WiimoteLib_Proxy_NunchukState);
            AddProxyTransform(typeof(WiimoteLib.Proxy.NunchukCalibrationInfo), Transform_WiimoteLib_Proxy_NunchukCalibrationInfo_TO_WiimoteLib_NunchukCalibrationInfo);
            AddSourceTransform(typeof(WiimoteLib.NunchukCalibrationInfo), Transform_WiimoteLib_NunchukCalibrationInfo_TO_WiimoteLib_Proxy_NunchukCalibrationInfo);
            AddProxyTransform(typeof(WiimoteLib.Proxy.ClassicControllerState), Transform_WiimoteLib_Proxy_ClassicControllerState_TO_WiimoteLib_ClassicControllerState);
            AddSourceTransform(typeof(WiimoteLib.ClassicControllerState), Transform_WiimoteLib_ClassicControllerState_TO_WiimoteLib_Proxy_ClassicControllerState);
            AddProxyTransform(typeof(WiimoteLib.Proxy.ClassicControllerCalibrationInfo), Transform_WiimoteLib_Proxy_ClassicControllerCalibrationInfo_TO_WiimoteLib_ClassicControllerCalibrationInfo);
            AddSourceTransform(typeof(WiimoteLib.ClassicControllerCalibrationInfo), Transform_WiimoteLib_ClassicControllerCalibrationInfo_TO_WiimoteLib_Proxy_ClassicControllerCalibrationInfo);
            AddProxyTransform(typeof(WiimoteLib.Proxy.ClassicControllerButtonState), Transform_WiimoteLib_Proxy_ClassicControllerButtonState_TO_WiimoteLib_ClassicControllerButtonState);
            AddSourceTransform(typeof(WiimoteLib.ClassicControllerButtonState), Transform_WiimoteLib_ClassicControllerButtonState_TO_WiimoteLib_Proxy_ClassicControllerButtonState);
            AddProxyTransform(typeof(WiimoteLib.Proxy.GuitarState), Transform_WiimoteLib_Proxy_GuitarState_TO_WiimoteLib_GuitarState);
            AddSourceTransform(typeof(WiimoteLib.GuitarState), Transform_WiimoteLib_GuitarState_TO_WiimoteLib_Proxy_GuitarState);
            AddProxyTransform(typeof(WiimoteLib.Proxy.GuitarButtonState), Transform_WiimoteLib_Proxy_GuitarButtonState_TO_WiimoteLib_GuitarButtonState);
            AddSourceTransform(typeof(WiimoteLib.GuitarButtonState), Transform_WiimoteLib_GuitarButtonState_TO_WiimoteLib_Proxy_GuitarButtonState);
        }
    }
}

