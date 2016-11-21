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
        public string path;
        public bool DialogSave { get; set; }
        public Form_MVF.FoodItem createItem {
            get {
                return new Form_MVF.FoodItem()
                {
                    challengename = txt_ChallengeName.Text,
                    description = txt2_Description.Text,
                    calories = int.Parse(txt2_Calories.Text),
                    duration = int.Parse(cb_Duration.SelectedItem.ToString()),
                    image = txt2_Image.Text
                };
                }
        }  

        public Form_ChallengeInfo()
        {
            InitializeComponent();
        }

        private void btn2_Browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.ShowDialog();string fullPath = ofd.FileName;
                string fileName = ofd.SafeFileName;
                path = fullPath.Replace(fileName, "");
                txt2_Image.Text = path + fileName;
                /* if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                 { 
                 File.Copy(ofd.FileName, "..\\..\\Resources\\");
                 }
                 */
                //File.Copy(ofd.FileName.ToString(), txt_imgPath.Text = ofd.FileName);

            }
        }

        private void btn2_Save_Click(object sender, EventArgs e)
        {

            DialogSave = true;
            this.Close();
            
        }

        private void btn2_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
