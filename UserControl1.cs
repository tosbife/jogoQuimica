using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoQuimica
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1(string elem, float qtt, int y, bool isFirst)
        {
            InitializeComponent();

            label1.Text = elem;
            label2.Text = "(" + qtt.ToString("0.00") + ")";
            Location = new Point(Location.X + (isFirst ? 15 : 310), Location.Y + y);
        }

        public void ResizeW(float amount)
        {
            int w = (int)Math.Ceiling(pictureBox1.Size.Width * amount);
            pictureBox1.Size = new Size(w, 14);
        }
    }
}
