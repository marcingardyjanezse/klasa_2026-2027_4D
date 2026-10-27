using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1
{
    public class Pumpkin
    {
        const int StatesCount = 5;

        int state;

        public void ChangeState()
        {
            state++;
            if (state >= StatesCount)
                state = 0;
        }

        public string GetFileName()
        {
            return "pumpkin" + state + ".png";
        }
    }
}
