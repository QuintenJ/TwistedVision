﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RLNET;

namespace TwistedVision.Core
{
    public class Colors
    {
        public static RLColor KoboldColor = Palette.DbBrightWood;
        public static RLColor FloorBackground = RLColor.Black;
        public static RLColor Floor = Palette.AlternateDarkest;
        public static RLColor FloorBackgroundFov = Palette.DbDark;
        public static RLColor FloorFov = Palette.Alternate;

        public static RLColor DoorBackground = Palette.ComplimentDarkest;
        public static RLColor Door = Palette.ComplimentLighter;
        public static RLColor DoorBackgroundFov = Palette.ComplimentDarker;
        public static RLColor DoorFov = Palette.ComplimentLightest;

        public static RLColor WallBackground = Palette.SecondaryDarkest;
        public static RLColor Wall = Palette.Secondary;
        public static RLColor WallBackgroundFov = Palette.SecondaryDarker;
        public static RLColor WallFov = Palette.SecondaryLighter;

        public static RLColor TextHeading = RLColor.White;
        public static RLColor Text = Palette.DbLight;
        public static RLColor Gold = Palette.DbSun;

        public static RLColor Player = Palette.DbLight;
    }
}