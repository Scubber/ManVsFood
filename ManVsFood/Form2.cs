using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManVsFood
{
    public partial class Form_ChallengeInfo : Form
    {
        public Form_ChallengeInfo()
        {
            InitializeComponent();
        }

        private void btn2_Browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.ShowDialog();
                /* if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                 { 
                 File.Copy(ofd.FileName, "..\\..\\Resources\\");
                 }
                 */
                //File.Copy(ofd.FileName.ToString(), txt_imgPath.Text = ofd.FileName);

            }
        }
    }
}
