using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAdv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 편지ㅂToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 글껄ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 상태줄표시ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 도움말보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.microsoft.com/ko-kr/windows/windows%EC%97%90%EC%84%9C-%EB%8F%84%EC%9B%80%EB%A7%90%EC%9D%84-%EB%B3%B4%EB%8A%94-%EB%B0%A9%EB%B2%95-711b6492-0435-0038-8706-7c6b0feb200a#:~:text=Windows%EC%97%90%EC%84%9C%20%EB%8F%84%EC%9B%80%EB%A7%90%EC%9D%84%20%EB%B3%B4%EB%8A%94%20%EB%B0%A9%EB%B2%95%201%20%EB%8F%84%EC%9B%80%EB%A7%90%20%EA%B2%80%EC%83%89%20-,%EC%A7%80%EC%9B%90%20%EC%BD%98%ED%85%90%EC%B8%A0%EB%A5%BC%20%EA%B2%80%EC%83%89%ED%95%98%EA%B3%A0%2C%20%EA%B3%A0%EA%B0%9D%20%EC%A7%80%EC%9B%90%EC%97%90%20%EB%AC%B8%EC%9D%98%ED%95%98%EC%84%B8%EC%9A%94.%20%EA%B8%B0%ED%83%80%20%ED%95%AD%EB%AA%A9");

        }

        private void 확대하기축소하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 50;

        }

        private void 확대ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Maximum < toolStripProgressBar1.Value + toolStripProgressBar1.Step)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
            }
            else
            {
                toolStripProgressBar1.Value += toolStripProgressBar1.Step;
            }
        }

        private void 축소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Minimum > toolStripProgressBar1.Value - toolStripProgressBar1.Step)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Minimum;
            }
            else
            {
                toolStripProgressBar1.Value -= toolStripProgressBar1.Step;
            }
        }
    }
}
