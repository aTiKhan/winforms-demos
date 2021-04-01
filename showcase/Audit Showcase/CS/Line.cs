﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Audit_Showcase_sample
{
    public class Line:Control
    {
        private Color m_LineColor = Color.Black;
        /// <summary>
        /// Gets or sets the color of the divider line
        /// </summary>
        [Category("Appearance")]
        [Description("Gets or sets the color of the divider line")]
        public Color LineColor
        {
            get
            {
                return m_LineColor;
            }
            set
            {
                m_LineColor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            using (SolidBrush brush = new SolidBrush(LineColor))
            {
                pe.Graphics.FillRectangle(brush, pe.ClipRectangle);
            }
        }
    }
}
