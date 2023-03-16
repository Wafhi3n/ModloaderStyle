using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ModloaderStyle.ModLoaderButton
{
    public abstract class ModLoaderButton
    {
        public static Button ButtonPlay()
        {

            ResourceDictionary  rd = new ResourceDictionary();
           // rd.Source = new Uri("Style/Dictionary/button.xaml");
            rd.Source = new Uri("pack://application:,,,/ModloaderStyle;component/Style/Dictionary/button.xaml");
            

            Button button = new Button();
            button.Style = rd["BoutonPlay"] as Style;

            return button;

            /****
             * 
             * 
             * 
             *<Button x:Name="bJouer"  Click="button_Click"  Style="{StaticResource BoutonJouer}" Margin="0,0,20,20"/>
             * 
             * 
             * 
             * 
             * 
             * */
        }
    }
}
