﻿#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using SampleBrowser.Maui.Core;
using System;

namespace SampleBrowser.Maui.SfScheduler
{
    /// <summary>
    /// Interaction logic for SpecialTimeRegion.xaml
    /// </summary>
    public partial class SpecialTimeRegion : SampleView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialTimeRegion" /> class.
        /// </summary>
        public SpecialTimeRegion()
        {
            InitializeComponent();
            Scheduler.SelectableDayPredicate = (date) =>
            {
                if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                {
                    return false;
                }

                return true;
            };
        }

        public override void OnDisappearing()
        {
            base.OnDisappearing();
            Scheduler.Handler?.DisconnectHandler();
        }
    }
}