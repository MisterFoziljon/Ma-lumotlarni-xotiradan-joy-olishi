﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_project
{
    public class DoubleClickButton:Button
    {
        public DoubleClickButton()
        {
            SetStyle(ControlStyles.StandardClick|ControlStyles.StandardDoubleClick,true);
        }
    }
}
