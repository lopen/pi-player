using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14DRDJUI
{
    public partial class DJInterface : Form
    {
        public DJInterface()
        {
            InitializeComponent();
        }

        private void DJInterface_Load(object sender, EventArgs e)
        {

        }

        private void currentSongHeader_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point screenPoint = queueOfSongsBtn.PointToScreen(new Point(queueOfSongsBtn.Left, queueOfSongsBtn.Bottom));
            if (screenPoint.Y + queueListCMS.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                queueListCMS.Show(queueOfSongsBtn, new Point(0, -queueListCMS.Size.Height));
            } else {
                queueListCMS.Show(queueOfSongsBtn, new Point(0, queueOfSongsBtn.Height));
            }
        }
    }
}
