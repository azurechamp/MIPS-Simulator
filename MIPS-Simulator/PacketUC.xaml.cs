using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace MIPS_Simulator
{
    public sealed partial class PacketUC : UserControl
    {
        public PacketUC()
        {
            this.InitializeComponent();
        }



        public string ValueOfPacket
        {
            get { return (string)GetValue(ValueOfPacketProperty); }
            set { SetValue(ValueOfPacketProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ValueOfPacket.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueOfPacketProperty =
            DependencyProperty.Register("ValueOfPacket", typeof(string), typeof(PacketUC),null);



        public Brush BrushOfPacket
        {
            get { return (Brush)GetValue(BrushOfPacketProperty); }
            set { SetValue(BrushOfPacketProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BrushOfPacket.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BrushOfPacketProperty =
            DependencyProperty.Register("BrushOfPacket", typeof(Brush), typeof(PacketUC),null );


    }
}
