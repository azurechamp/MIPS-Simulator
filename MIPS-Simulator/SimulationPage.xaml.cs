using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MIPS_Simulator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SimulationPage : Page
    {
        public SimulationPage()
        {
            this.InitializeComponent();
        }
        public int counter = 0;
        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private async void StartExecution(object sender, RoutedEventArgs e)
        {
            if (counter == 0)
            {
                Step2.Begin();
                
            }
            if (counter == 1)
            {
                Turn2();
                Step2.Begin();
               
            }
            if (counter == 2)
            {
                TurnTurn();
                Step2.Begin();
                
            }
            if (counter == 3)
            {
                Turn3();
                Step2.Begin();
               
            }
            if (counter == 4)
            {
                Turn4();
                Step2.Begin();
            }
            if (counter > 4)
            {
                var msg = await new MessageDialog("Execution Ended!", "Completed!").ShowAsync();
             
            }
            counter++;

        }
        void Turn2()
        {
            p1.ValueOfPacket = "4";
            p2.ValueOfPacket = "add $s4 , $s1 , $s0";
            p3.ValueOfPacket = "1";
            p4.ValueOfPacket = "10001";
            p5.ValueOfPacket = "10000";
            p6.ValueOfPacket = "10100";
            p7.ValueOfPacket = "100000";
            p8.ValueOfPacket = "010";
            p9.ValueOfPacket = "5";
            p10.ValueOfPacket = "3";
            p11.ValueOfPacket = "0";
            p12.ValueOfPacket = "-2";
            f1.ValueOfPacket = "0..100";
            f3.ValueOfPacket = "8";

        }

        void TurnTurn()
        {
            p1.ValueOfPacket = "8";
            p2.ValueOfPacket = "sub $s5 , $s1 , $s2";
            p3.ValueOfPacket = "1";
            p4.ValueOfPacket = "10001";
            p5.ValueOfPacket = "10000";
            p6.ValueOfPacket = "10100";
            p7.ValueOfPacket = "100000";
            p8.ValueOfPacket = "010";
            p9.ValueOfPacket = "5";
            p10.ValueOfPacket = "3";
            p11.ValueOfPacket = "0";
            p12.ValueOfPacket = "2";
            f1.ValueOfPacket = "0..100";
            f3.ValueOfPacket = "12";


        }

        void Turn3()
        {
            p1.ValueOfPacket = "8";
            p2.ValueOfPacket = "sub $s5 , $s1 , $s2";
            p3.ValueOfPacket = "1";
            p4.ValueOfPacket = "10001";
            p5.ValueOfPacket = "10000";
            p6.ValueOfPacket = "10100";
            p7.ValueOfPacket = "100000";
            p8.ValueOfPacket = "010";
            p9.ValueOfPacket = "5";
            p10.ValueOfPacket = "3";
            p11.ValueOfPacket = "0";
            p12.ValueOfPacket = "2";
            f1.ValueOfPacket = "0..100";
            f3.ValueOfPacket = "16";


        }

        void Turn4()
        {
            p1.ValueOfPacket = "16";
            p2.ValueOfPacket = "and $s7 , $s2 , $s1";
            p3.ValueOfPacket = "1";
            p4.ValueOfPacket = "10001";
            p5.ValueOfPacket = "10000";
            p6.ValueOfPacket = "10100";
            p7.ValueOfPacket = "100000";
            p8.ValueOfPacket = "000";
            p9.ValueOfPacket = "5";
            p10.ValueOfPacket = "3";
            p11.ValueOfPacket = "0";
            p12.ValueOfPacket = "1";
            f1.ValueOfPacket = "0..100";
            f3.ValueOfPacket = "20";

        }

        int mainCounter = 0;

        private void Step1_Completed(object sender, object e)
        {
           
            Step2.Begin();
           
            if (mainCounter == 0)
            {
                counter++;
                mainCounter++;
            }
        }

      

        void CheckStep()
        {
            if (counter == 1)
            {
                Turn2();
                Step2.Begin();
                counter++;
            }
            if (counter == 2)
            {
                Turn3();
                Step2.Begin();
                counter++;
            }
            if (counter == 3)
            {
                Turn4();
                Step2.Begin();
                counter++;
            }
        }

        private void StopSimulation(object sender, RoutedEventArgs e)
        {
            Step1.Stop();
            Step2.Stop();
        }

        void Manupulations()
        {
           string a = Converters.AddTwoBinary(p1.ValueOfPacket, p4.ValueOfPacket);
        }
    }
}
