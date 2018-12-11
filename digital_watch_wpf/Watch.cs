using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace digital_watch_wpf
{
    class Watch
    {
        string currentTime;
        int currentH = 23;
        int currentM = 59;
        int currentS = 40;
        List<Num> numInBoard = new List<Num>();

        public Watch ()
        {
            numInBoard.Add(new Num());
            numInBoard.Add(new Num());
            numInBoard.Add(new Num());
            numInBoard.Add(new Num());
            numInBoard.Add(new Num());
            numInBoard.Add(new Num());
        }

        string ReturnTime()
        {
            string returnString = "";

            currentS++;
            if (currentS == 60)
            {
                currentS = 0;
                currentM++;
                if (currentM == 60)
                {
                    currentM = 0;
                    currentH++;
                    if (currentH == 24)
                    {
                        currentH = 0;
                    }
                }
            }

            if (currentH.ToString().Length == 1) returnString += "0" + currentH.ToString();
            else returnString += currentH.ToString();
            if (currentM.ToString().Length == 1) returnString += "0" + currentM.ToString();
            else returnString += currentM.ToString();
            if (currentS.ToString().Length == 1) returnString += "0" + currentS.ToString();
            else returnString += currentS.ToString();

            return returnString;
        }

        public List<Num> CheckTime()
        {
            currentTime = this.ReturnTime();

            for (int numPlace = 0; numPlace < numInBoard.Count; numPlace++)
            {
                numInBoard[numPlace].CurrentNum = currentTime[numPlace] - '0';
            }

            return numInBoard;
        }
    }
}
