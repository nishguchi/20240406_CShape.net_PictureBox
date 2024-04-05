using System.IO;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp2
{
    public partial class PictureBoxMain : Form
    {
        public PictureBoxMain()
        {
            InitializeComponent();


        }

        private void buttonShow_Click(object sender, EventArgs e)
        {


            if (folderBrowserDialogImage.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialogImage.SelectedPath;



                //�e�L�X�g�{�b�N�X�ɉ摜�w��
                textBoxFile.Text = path;
                //listBoxFile�Ɋ܂܂��JPEG�t�@�C����n��
                listBoxFile.DataSource = System.IO.Directory.GetFiles(path, "*.jpg");

                timerImage.Enabled = true;
            }



        }

        private void listBoxFile_SelectedIndexChanged(object sender, EventArgs e)
        {

            pictureBox.ImageLocation = (string)listBoxFile.SelectedItem;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void timerImage_Tick(object sender, EventArgs e)
        {


            if (listBoxFile.SelectedIndex == listBoxFile.Items.Count - 1)
            {
                //�I��l �C���f�b�N�X0�w��
                listBoxFile.SelectedIndex = 0;
            }
            else
            {
                //�I��l �C���N�������g
                listBoxFile.SelectedIndex++;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            int interval;

            if (int.TryParse(num, out interval))
            {
                timerImage.Interval = int.Parse(textBox1.Text);
            }else
            {
                timerImage.Interval = 1000;
            }
        }
    }
}
