using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks; 
using GLFW;
 

namespace GamepadNameSpace
{

    internal class Gamepad
    {
        #region 1
        public Gamepad(int controllername)
        {

            Connected = Glfw.JoystickPresent((Joystick)controllername);

            Disconnected = "Connect a controller";

            JoystickName = controllername + " " + Glfw.GetJoystickName((Joystick)controllername) + " " +
            Glfw.GetGamepadName(controllername);

            button = Glfw.GetJoystickButtons((Joystick)controllername);
            Axes = Glfw.GetJoystickAxes((Joystick)controllername);

        }
        public string JoystickName
        {
            get; set;
        }
        public InputState[] button
        {
            get;
        }
        public float[] Axes
        {
            get;
        }
        public bool Connected
        {
            get; set;
        }

        public string Disconnected
        {
            get; set;
        }


        #endregion

     


    }









}
    
    

