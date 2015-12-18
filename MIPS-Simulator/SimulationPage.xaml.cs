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
                MainSb.Begin();
                MainSb.Completed += MainSb_Completed;
                
            }
            if (counter == 1)
            {
                Turn2();
                MainSb.Begin();
               
            }
            if (counter == 2)
            {
                TurnTurn();
                MainSb.Begin();
                
            }
            if (counter == 3)
            {
                Turn3();
                MainSb.Begin();
               
            }
            if (counter == 4)
            {
                Turn4();
                MainSb.Begin();
            }
            if (counter > 4)
            {
                var msg = await new MessageDialog("Execution Ended!", "Completed!").ShowAsync();
             
            }
            counter++;

        }

        private void MainSb_Completed(object sender, object e)
        {
            
        }

        void Turn2()
        {
            adder.ValueOfPacket = "4";
            adder1.ValueOfPacket = "8";
            adder2.ValueOfPacket = "8";
               

        }

        void TurnTurn()
        {

            adder.ValueOfPacket = "4";
            adder1.ValueOfPacket = "12";
            adder2.ValueOfPacket = "12";

        }

        void Turn3()
        {
            adder.ValueOfPacket = "4";
            adder1.ValueOfPacket = "16";
            adder2.ValueOfPacket = "16";



        }

        void Turn4()
        {

            adder.ValueOfPacket = "4";
            adder1.ValueOfPacket = "20";
            adder2.ValueOfPacket = "20";

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
          // string a = Converters.AddTwoBinary(p1.ValueOfPacket, p4.ValueOfPacket);
        }
    }
}
