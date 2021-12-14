using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kinoshka
{
    public partial class DrawForm : Form
    {
        AdminForm adminForm;
        string[,] tmp;
        public DrawForm(AdminForm adminForm, string[,] tmp)
        {
            InitializeComponent();
            this.adminForm = adminForm;
            this.tmp = tmp;
        }

        private void DrawForm_Paint(object sender, PaintEventArgs e)
        {
            int chairWidth = ((this.ClientSize.Width-20) / 10) - 4;
            int chairHeight = ((this.ClientSize.Height-20) / 20) - 4;
            int offsetX = 10;
            int offsetY = 10;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (tmp[i,j] == "1")
                    {
                        e.Graphics.FillRectangle(Brushes.Yellow, offsetX, offsetY, chairWidth, chairHeight);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(Brushes.YellowGreen, offsetX, offsetY, chairWidth, chairHeight);
                    }
                    e.Graphics.DrawRectangle(Pens.DarkGray, offsetX, offsetY, chairWidth, chairHeight);
                    offsetX += chairWidth + 4;
                }
                offsetX = 10;
                offsetY += chairHeight + 4; 
            }

        }

        private void DrawForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminForm.Show();
        }
    }
}
