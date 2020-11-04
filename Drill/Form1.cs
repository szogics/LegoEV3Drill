using System.Windows.Forms;
using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System;

namespace Drill
{
    using System.ComponentModel;

    public partial class btnStartBelt : Form
    {
        private Brick brick;
        private short previousSensedColor = 0;
        private int previousDrillDownTouched;

        public btnStartBelt()
        {
            InitializeComponent();
        }

        private void Brick_BrickChanged(object sender, BrickChangedEventArgs e)
        {
            if (e.Buttons.Down)
            {
                brick.DirectCommand.TurnMotorAtSpeedAsync(OutputPort.C, 10);
            }
            else if (e.Buttons.Up)
            {
                brick.DirectCommand.StopMotorAsync(OutputPort.C, true);
            }
            else if(e.Ports[InputPort.Two].SIValue == 1)
            {
                brick.DirectCommand.StopMotorAsync(OutputPort.A, false);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            brick = new Brick(new BluetoothCommunication("COM4"));
            brick.BrickChanged += Brick_BrickChanged;
            await brick.ConnectAsync();
            await brick.DirectCommand.ClearAllDevices();
            // Set color sensor
            brick.Ports[InputPort.Three].SetMode(ColorMode.Color);
            //brick.Ports[InputPort.Three].PropertyChanged += ColorSensorChanged;
            // Set touch sensor of drill (down)
            brick.Ports[InputPort.Two].SetMode(TouchMode.Touch);
            brick.Ports[InputPort.Two].PropertyChanged += TouchSensorDrillDownChanged;

            // Set touch sensor of drill (up)
            brick.Ports[InputPort.One].SetMode(TouchMode.Touch);
            brick.Ports[InputPort.One].PropertyChanged += TouchSensorDrillDownChanged;

        }

        private void TouchSensorDrillDownChanged(object sender, PropertyChangedEventArgs e)
        {
            Port touchSensor = (Port)sender;
            int drillDownTouched = touchSensor.RawValue;
            if (drillDownTouched != previousDrillDownTouched)
            {
                if (drillDownTouched == 1)
                {
                    brick.DirectCommand.StopMotorAsync(OutputPort.A, false);
                }
            }

            previousDrillDownTouched = drillDownTouched;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            brick.Disconnect();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await brick.SystemCommand.CopyFileAsync("face.rgf", "../prjs/Drill/face.rgf");
            await brick.DirectCommand.CleanUIAsync();
            await brick.DirectCommand.DrawImageAsync(Color.Foreground, 0, 0, "../prjs/Drill/face");
            await brick.DirectCommand.UpdateUIAsync();
        }

        private async void btnStopMotors_Click(object sender, EventArgs e)
        {
            await brick.DirectCommand.StopMotorAsync(OutputPort.All, false);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MoveDrillToStartingPosition();
        }

        private void ColorSensorChanged(object sender, PropertyChangedEventArgs e)
        {
            Port colorSensor = (Port)sender;
            short sensedColorInt = Convert.ToInt16(colorSensor.SIValue);
            if (sensedColorInt != previousSensedColor)
            {
                switch (sensedColorInt)
                {
                    case 3: DoDrillingProcess(1); break;
                    case 4: DoDrillingProcess(2); break;
                    case 2: DoDrillingProcess(3); break;
                    case 5: DoDrillingProcess(4); break;
                }
            }

            previousSensedColor = sensedColorInt;
        }

        private void DoDrillingProcess(int hardnessOfMaterial)
        {
            LowerDrill();
        }

        private void MoveDrillToStartingPosition()
        {
            brick.DirectCommand.TurnMotorAtSpeedAsync(OutputPort.A, -10);
        }

        private void LowerDrill()
        {
            brick.DirectCommand.TurnMotorAtSpeedAsync(OutputPort.A, 1);
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                await brick.DirectCommand.StepMotorAtSpeedAsync(OutputPort.C, 50, 36, false);
            }
        }

        private void btnStopBelt_Click(object sender, EventArgs e)
        {

        }
    }
}
