using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace digital_watch_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Image[]> timeOutputElements = new List<Image[]>();
        Watch watch = new Watch();

        public MainWindow()
        {
            InitializeComponent();
            timeOutputElements.Add(new Image[] {watch_part_1_1_on, watch_part_1_2_on, watch_part_1_3_on, watch_part_1_4_on, watch_part_1_5_on, watch_part_1_6_on, watch_part_1_7_on});
            timeOutputElements.Add(new Image[] {watch_part_2_1_on, watch_part_2_2_on, watch_part_2_3_on, watch_part_2_4_on, watch_part_2_5_on, watch_part_2_6_on, watch_part_2_7_on});
            timeOutputElements.Add(new Image[] {watch_part_3_1_on, watch_part_3_2_on, watch_part_3_3_on, watch_part_3_4_on, watch_part_3_5_on, watch_part_3_6_on, watch_part_3_7_on});
            timeOutputElements.Add(new Image[] {watch_part_4_1_on, watch_part_4_2_on, watch_part_4_3_on, watch_part_4_4_on, watch_part_4_5_on, watch_part_4_6_on, watch_part_4_7_on});
            timeOutputElements.Add(new Image[] {watch_part_5_1_on, watch_part_5_2_on, watch_part_5_3_on, watch_part_5_4_on, watch_part_5_5_on, watch_part_5_6_on, watch_part_5_7_on});
            timeOutputElements.Add(new Image[] {watch_part_6_1_on, watch_part_6_2_on, watch_part_6_3_on, watch_part_6_4_on, watch_part_6_5_on, watch_part_6_6_on, watch_part_6_7_on});


            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            WatchReload();
        }

        void WatchReload()
        {
            List<Num> numInBoard = watch.CheckTime();
            for (int outputElementsCount = 0; outputElementsCount < timeOutputElements.Count; outputElementsCount++)
            {
                for (int outputElementPartsCount = 0; outputElementPartsCount < 7; outputElementPartsCount++)
                {
                    timeOutputElements[outputElementsCount][outputElementPartsCount].Visibility = numInBoard[outputElementsCount].currentNum[outputElementPartsCount] ? Visibility.Visible : Visibility.Hidden;
                }
            }
        }
    }
}
