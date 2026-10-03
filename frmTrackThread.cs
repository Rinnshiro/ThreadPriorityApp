using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadPriorityApp
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
			lblStatus.Text = "-Thread Starts-";
			lblStatus.Refresh();
			Console.WriteLine("-Thread Starts-");

			Thread threadA = new Thread(ThreadClass.Thread1);
			Thread threadB = new Thread(ThreadClass.Thread2);
			Thread threadC = new Thread(ThreadClass.Thread1);
			Thread threadD = new Thread(ThreadClass.Thread2);

			threadA.Name = "Thread A Process";
			threadB.Name = "Thread B Process";
			threadC.Name = "Thread C Process";
			threadD.Name = "Thread D Process";

			threadA.Priority = ThreadPriority.Highest;
			threadB.Priority = ThreadPriority.Normal;
			threadC.Priority = ThreadPriority.AboveNormal;
			threadD.Priority = ThreadPriority.BelowNormal;

			threadA.Start();
			threadB.Start();
			threadC.Start();
			threadD.Start();

			threadA.Join();
			threadB.Join();
			threadC.Join();
			threadD.Join();

			Console.WriteLine("-End of Thread-");
			lblStatus.Text = "-End of Thread-";
		}
    }
}
