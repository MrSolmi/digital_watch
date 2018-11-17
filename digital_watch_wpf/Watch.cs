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
        List<Num> numInBoard = new List<Num>();

        public Watch ()
        {
            numInBoard.Add(new Num());
            numInBoard.Add(new Num());
            numInBoard.Add(new Num());
            numInBoard.Add(new Num());
        }

        string ReturnTime()
        {
            return String.Format("{0}{1}", DateTime.Now.ToString().Substring(11, 2), DateTime.Now.ToString().Substring(14, 2));
        }

        public List<Num> CheckTime()
        {
            currentTime = this.ReturnTime();

            for (int numPlace = 0; numPlace < numInBoard.Count; numPlace++)
            {
                numInBoard[numPlace].CurrentNum = ReturnTime()[numPlace] - '0';
            }

            return numInBoard;
        }
    }
}
