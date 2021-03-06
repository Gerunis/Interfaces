﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Interfaces
{
    public class BackButton
    {
        public PictureBox Button { get; private set; }

        public BackButton(Action<object, EventArgs> backAction)
        {
            Button = new PictureBox
            {
                Image = Properties.Resources.back,
                BackColor = Color.White,
                Height = 35,
                Width = 35,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(13, 13)
            };
            Button.Click += new EventHandler(backAction);
        }
    }
}
