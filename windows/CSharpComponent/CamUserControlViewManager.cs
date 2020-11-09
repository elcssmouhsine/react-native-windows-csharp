using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Controls;

using Microsoft.ReactNative.Managed;
using System.Collections.Generic;
using System;

namespace CSharpComponent
{
    internal class CamUserControlViewManager : AttributedViewManager<CamUserControl>
    {
        [ViewManagerProperty("label")]
        public void SetLabel(CamUserControl view, string value)
        {
            Console.WriteLine($"##### {value}");
            if (null != value)
            {
                view.SetValue(CamUserControl.LabelProperty, value);
            }
            else
            {
                view.ClearValue(CamUserControl.LabelProperty);
            }
        }

        [ViewManagerProperty("color")]
        public void SetColor(CamUserControl view, Brush value)
        {
            Console.WriteLine($"##### {value}");
            if (null != value)
            {
                view.SetValue(Control.ForegroundProperty, value);
            }
            else
            {
                view.ClearValue(Control.ForegroundProperty);
            }
        }

        [ViewManagerProperty("backgroundColor")]
        public void SetBackgroundColor(CamUserControl view, Brush value)
        {
            if (null != value)
            {
                view.SetValue(Control.BackgroundProperty, value);
            }
            else
            {
                view.ClearValue(Control.BackgroundProperty);
            }
        }

        [ViewManagerCommand]
        public void CustomCommand(CamUserControl view, IReadOnlyList<object> commandArgs)
        {
            // Execute command
        }
    }
}
