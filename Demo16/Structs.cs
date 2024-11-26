﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo16
{
    public struct TrafficLight
    {
        public TrafficLightColor color;

        public void ChangeColor()
        {
            switch (color)
            {
                case TrafficLightColor.Red:
                    color = TrafficLightColor.Green;
                    break;
                case TrafficLightColor.Orange:
                    color = TrafficLightColor.Red;
                    break;
                case TrafficLightColor.Green:
                    color = TrafficLightColor.Orange;
                    break;
                default:
                    color = TrafficLightColor.Red;
                    break;
            }
        }
    }
}
