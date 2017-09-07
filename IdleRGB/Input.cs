using System;
using System.Diagnostics;
using System.Timers;
using System.IO;
using System.Drawing;
using System.Windows.Input;

namespace IdleRGB
{
    class Input
    {
        KeyboardInput keyboard;
        MouseInput mouse;
        LedChanger idle;

        DateTime lastInput;

        // Settings
        TimeSpan idleTime;
        Color idleColor;
        Color capsColor;

        bool inIdle = false;
        bool inCaps = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="Input"/> class.
        /// </summary>
        public Input()
        {
            lastInput = DateTime.Now;
            idleTime = Properties.Settings.Default.idleTime;

            keyboard = new KeyboardInput();
            keyboard.KeyBoardKeyPressed += inputAction;

            mouse = new MouseInput();
            mouse.MouseMoved += inputAction;

            idle = new LedChanger();

            idleColor = Properties.Settings.Default.idleColor;
            capsColor = Properties.Settings.Default.capsColor;

            initTimer();
        }

        /// <summary>
        /// Updates last input and deactivates idle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void inputAction(object sender, EventArgs e)
        {
            bool capsToggled = Keyboard.IsKeyToggled(Key.CapsLock);

            // Checking if in idle
            if (inIdle)
            {
                if (capsToggled)
                {
                    idle.changeLeds(capsColor);
                    inCaps = true;
                }

                else
                {
                    idle.resetLeds();
                }

                inIdle = false;
            }

            else if(!capsToggled && inCaps)
            {
                idle.resetLeds();
                inCaps = false;
            }

            else if(capsToggled && !inCaps)
            {
                idle.changeLeds(capsColor);
                inCaps = true;
            }

            // Updates last input time
            lastInput = DateTime.Now;
        }

        /// <summary>
        /// Checks if enough time without input has passed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer1_Tick(object sender, ElapsedEventArgs e)
        {
            if (!inIdle)
            {
                // Checks if enough time has passed to put in idle
                if (DateTime.Now.Subtract(lastInput) > idleTime)
                {
                    idle.changeLeds(idleColor);
                    inIdle = true;
                }
            }
        }

        /// <summary>
        /// Initiates timer.
        /// </summary>
        void initTimer()
        {
            System.Timers.Timer timer1;
            timer1 = new System.Timers.Timer();
            timer1.Elapsed += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            GC.KeepAlive(timer1);
        }
    }
}
