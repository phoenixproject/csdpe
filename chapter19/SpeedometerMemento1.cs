﻿/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter19
{
    public class SpeedometerMemento1
    {
        private Speedometer1 speedometer;

        private int copyOfCurrentSpeed;
        private int copyOfPreviousSpeed;

        public SpeedometerMemento1(Speedometer1 speedometer)
        {
            this.speedometer = speedometer;
            copyOfCurrentSpeed = speedometer.CurrentSpeed;
            copyOfPreviousSpeed = speedometer.previousSpeed;
        }

        public virtual void RestoreState()
        {
            speedometer.CurrentSpeed = copyOfCurrentSpeed;
            speedometer.previousSpeed = copyOfPreviousSpeed;
        }
    }
}