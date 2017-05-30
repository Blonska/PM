using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace CourseProjectWinForms
{
    public partial class MainForm : Form
    {
        BinaryTree binTree = new BinaryTree();
        public MainForm()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;       
        }
        #region old
        /*    private void toolStripMenuItemLevel1_Click(object sender, EventArgs e)
           {
               DrawLevel1Tree();

               pictureBox1.BringToFront();
               pictureBox1.BringToFront();
               DrawLevel1Tree();
           }
           private void toolStripMenuItem3Level2_Click(object sender, EventArgs e)
           {
               DrawLevel2Tree();
               pictureBox2.BringToFront();
               pictureBox2.BringToFront();
               DrawLevel2Tree();

           }

           public void DrawLevel1Tree()
           {

               Graphics g = pictureBox1.CreateGraphics();
               int xCenter =  pictureBox1.Width / 2;
               int yCenter = pictureBox1.Height / 2;
               Pen pen = new Pen(Color.Black, 2);
                   g.DrawEllipse(pen, xCenter, 20, 50, 70);
                   g.DrawEllipse(pen, xCenter - 80, yCenter - 160, 50, 70);
                   g.DrawEllipse(pen, xCenter + 80, yCenter - 160, 50, 70);

           }

           public void DrawLevel2Tree()
           {
               Graphics g2 = pictureBox2.CreateGraphics();
               int xCenter = pictureBox2.Width / 2;
               int yCenter = pictureBox2.Height / 2;
               Pen pen = new Pen(Color.Black, 2);
               g2.DrawEllipse(pen, xCenter, 20, 50, 70);
               g2.DrawEllipse(pen, xCenter - 80, yCenter - 160, 50, 70);
               g2.DrawEllipse(pen, xCenter + 80, yCenter - 160, 50, 70);
               g2.DrawEllipse(pen, xCenter - 160, yCenter - 80, 50, 70);
               g2.DrawEllipse(pen, xCenter + 160, yCenter - 80, 50, 70);
               g2.DrawEllipse(pen, xCenter - 40, yCenter - 80, 50, 70);
               g2.DrawEllipse(pen, xCenter + 40, yCenter - 80, 50, 70);

           }   */

        #endregion
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileForm form = new OpenFileForm();
            form.Show();
            LoadPicture(form.pictureBox1);
        }
        private void treeLevel1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTreeInImage(panel1);
        }
        private void treeLevel2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTreeInImage(panel2);
        }
        private void treeLevel3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTreeInImage(panel3);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void toolStripMenuItemLevel1_Click(object sender, EventArgs e)
        {
            binTree.Level = 1;
            binTree.BuildTree();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            
        }
        private void toolStripMenuItem3Level2_Click(object sender, EventArgs e)
        {
            binTree.Level = 2;
            binTree.BuildTree();
            panel2.Visible = true;       
            panel1.Visible = false;         
            panel3.Visible = false;
        }
        private void toolStripMenuItemLevel3_Click(object sender, EventArgs e)
        {
            binTree.Level = 3;
            binTree.BuildTree();
            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
        }
        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm f = new AboutForm();
            f.Show();
        }
        private void LoadPicture(PictureBox pictureBox)
        {
            Bitmap image;
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(open_dialog.FileName);
                pictureBox.Size = image.Size;
                pictureBox.Image = image;
                pictureBox.Invalidate();
            }
        }
        public Bitmap getControlScreenshot(Control c)
        {
            Bitmap res = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(res, new Rectangle(Point.Empty, c.Size));
            return res;
        }
        private void SaveTreeInImage(Panel panel)
        {
            Bitmap scr = getControlScreenshot(panel);
            //     scr.Save("screen.bmp");
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveDialog.Title = "Save an Image File";
            saveDialog.ShowDialog();
            if (saveDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveDialog.OpenFile();
                scr.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                fs.Close();
            }
        }



        //pictures
        #region level1

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox1);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox2);
        }
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            LoadPicture(pictureBox3);
        }

        #endregion
        #region level2
       
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox10);
        }
        #endregion
        #region level3
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox11);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox12);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox14);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox15);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox16);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox17);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox18);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox19);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox20);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox21);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox22);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox23);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox24);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            LoadPicture(pictureBox25);
        }
        #endregion



        //data
        static bool flagButton1 = false;
        static bool flagButton2 = false;
        static bool flagButton3 = false;
        static bool flagButton4 = false;
        static bool flagButton5 = false;
        static bool flagButton6 = false;
        static bool flagButton7 = false;
        static bool flagButton8 = false;
        static bool flagButton9 = false;
        static bool flagButton10 = false;
        static bool flagButton11 = false;
        static bool flagButton12 = false;
        static bool flagButton13 = false;
        static bool flagButton14 = false;
        static bool flagButton15 = false;
        static bool flagButton16 = false;
        static bool flagButton17 = false;
        static bool flagButton18 = false;
        static bool flagButton19 = false;
        static bool flagButton20 = false;
        static bool flagButton21 = false;
        static bool flagButton22 = false;
        static bool flagButton23 = false;
        static bool flagButton24 = false;
        static bool flagButton25 = false;

        private void Insert(TextBox textboxName, TextBox textboxAge, TextBox textboxlastName, TextBox textboxPlaceOfBthday, TextBox textboxYearBthday, TextBox textboxIsDead, TextBox textboxPlaceDEad, TextBox textboxYearDeath, int indexTree)
        {
            binTree[indexTree].Name = textboxName.Text;
            binTree[indexTree].Age = int.Parse(textboxAge.Text);
            binTree[indexTree].LastName = textboxlastName.Text;
            binTree[indexTree].PlaceOfBirthday = textboxPlaceOfBthday.Text;
            binTree[indexTree].YearOfBirthday = int.Parse(textboxYearBthday.Text);
            binTree[indexTree].IsDead = bool.Parse(textboxIsDead.Text);
            binTree[indexTree].PlaceOfDeath = textboxPlaceDEad.Text;
            binTree[indexTree].YearOfDeath = int.Parse(textboxYearDeath.Text);
        }

        private void InsertIntoPanel(TextBox textboxName, TextBox textboxAge, TextBox textboxlastName, TextBox textboxPlaceOfBthday, TextBox textboxYearBthday, TextBox textboxIsDead, TextBox textboxPlaceDEad, TextBox textboxYearDeath,int index )
        {
            textboxName.Text = binTree[index].Name;
            textboxlastName.Text = binTree[index].LastName;
            textboxAge.Text = Convert.ToString(binTree[index].Age);
            textboxYearBthday.Text = Convert.ToString(binTree[index].YearOfBirthday);
            textboxPlaceOfBthday.Text = binTree[index].PlaceOfBirthday;
            textboxIsDead.Text = Convert.ToString(binTree[index].IsDead);
            textboxPlaceDEad.Text = binTree[index].PlaceOfDeath;
            textboxYearDeath.Text = Convert.ToString(binTree[index].YearOfDeath);
        }
      

        private void buttonOK_Click(object sender, EventArgs e)
        {
           
            //lev1
            if (flagButton1)
            {
                Insert(textBoxName, textBoxAge,textBoxLastName,textBoxPlaceBthday,textBoxYearOfBthaday,textBoxIsDead,textBoxPlaceDeath,textBoxYearDEath, 0);
                flagButton1 = false;
                textBox1.Text = binTree[0].Name;
            }
            else if (flagButton2)
            {
                Insert(textBoxName, textBoxAge, textBoxLastName, textBoxPlaceBthday, textBoxYearOfBthaday, textBoxIsDead, textBoxPlaceDeath, textBoxYearDEath, 1);
                flagButton2 = false;
                textBox2.Text = binTree[1].Name;
            }
            else if (flagButton3)
            {
                Insert(textBoxName, textBoxAge, textBoxLastName, textBoxPlaceBthday, textBoxYearOfBthaday, textBoxIsDead, textBoxPlaceDeath, textBoxYearDEath, 2);
                flagButton3 = false;
                textBox3.Text = binTree[2].Name;
            }
            //lev2
            else if (flagButton4)
            {
                Insert(textBoxNamelevel2, textBoxAgeLevel2, textBoxLastNamelevel2, textBoxPlaceBthdLevel2, textBoxYearBthdLevel2, textBoxIsdeadLevel2, textBoxPlaceDeathLevel2, textBoxYearDeathLevel2, 0);
                flagButton4 = false;
                textBox4.Text = binTree[0].Name;
            }
            else if (flagButton5)
            {
                Insert(textBoxNamelevel2, textBoxAgeLevel2, textBoxLastNamelevel2, textBoxPlaceBthdLevel2, textBoxYearBthdLevel2, textBoxIsdeadLevel2, textBoxPlaceDeathLevel2, textBoxYearDeathLevel2, 1);
                flagButton5 = false;
                textBox5.Text = binTree[1].Name;
            }
            else if (flagButton6)
            {
                Insert(textBoxNamelevel2, textBoxAgeLevel2, textBoxLastNamelevel2, textBoxPlaceBthdLevel2, textBoxYearBthdLevel2, textBoxIsdeadLevel2, textBoxPlaceDeathLevel2, textBoxYearDeathLevel2, 2);
                flagButton6 = false;
                textBox6.Text = binTree[2].Name;
            }
            else if (flagButton7)
            {
                Insert(textBoxNamelevel2, textBoxAgeLevel2, textBoxLastNamelevel2, textBoxPlaceBthdLevel2, textBoxYearBthdLevel2, textBoxIsdeadLevel2, textBoxPlaceDeathLevel2, textBoxYearDeathLevel2, 3);
                flagButton7 = false;
                textBox7.Text = binTree[3].Name;
            }
            else if (flagButton8)
            {
                Insert(textBoxNamelevel2, textBoxAgeLevel2, textBoxLastNamelevel2, textBoxPlaceBthdLevel2, textBoxYearBthdLevel2, textBoxIsdeadLevel2, textBoxPlaceDeathLevel2, textBoxYearDeathLevel2, 4);
                flagButton8 = false;
                textBox8.Text = binTree[4].Name;
            }
            else if (flagButton9)
            {
                Insert(textBoxNamelevel2, textBoxAgeLevel2, textBoxLastNamelevel2, textBoxPlaceBthdLevel2, textBoxYearBthdLevel2, textBoxIsdeadLevel2, textBoxPlaceDeathLevel2, textBoxYearDeathLevel2, 5);
                flagButton9 = false;
                textBox9.Text = binTree[5].Name;
            }
            else if (flagButton10)
            {
                Insert(textBoxNamelevel2, textBoxAgeLevel2, textBoxLastNamelevel2, textBoxPlaceBthdLevel2, textBoxYearBthdLevel2, textBoxIsdeadLevel2, textBoxPlaceDeathLevel2, textBoxYearDeathLevel2, 6);
                flagButton10 = false;
                textBox10.Text = binTree[6].Name;
            }

            //lev3
            else if (flagButton11)
            {
                Insert(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 0);
                flagButton11 = false;
                textBox11.Text = binTree[0].Name;
            }
            else if (flagButton12)
            {
                Insert(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 1);
                flagButton12 = false;
                textBox12.Text = binTree[1].Name;
            }
            else if (flagButton13)
            {
                Insert(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3,2);
                flagButton13 = false;
                textBox13.Text = binTree[2].Name;
            }
            else if (flagButton14)
            {
                Insert(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 3);
                flagButton14 = false;
                textBox14.Text = binTree[3].Name;
            }
            else if (flagButton15)
            {
                Insert(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 4);
                flagButton15 = false;
                textBox15.Text = binTree[4].Name;
            }
            else if (flagButton16)
            {
                Insert(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 5);
                flagButton16 = false;
                textBox16.Text = binTree[5].Name;
            }
            else if (flagButton17)
            {
                Insert(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 6);
                flagButton17 = false;
                textBox17.Text = binTree[6].Name;
            }
            else if (flagButton18)
            {
                Insert(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 7);
                flagButton18 = false;
                textBox18.Text = binTree[7].Name;
            }
            else if (flagButton19)
            {
                Insert(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 8);
                flagButton19 = false;
                textBox19.Text = binTree[8].Name;
            }
            else if (flagButton20)
            {
                Insert(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 9);
                flagButton20 = false;
                textBox20.Text = binTree[9].Name;
            }
            else if (flagButton21)
            {
                Insert(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 10);
                flagButton21 = false;
                textBox21.Text = binTree[10].Name;
            }
            else if (flagButton22)
            {
                Insert(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 11);
                flagButton22 = false;
                textBox22.Text = binTree[11].Name;
            }
            else if (flagButton23)
            {
                Insert(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 12);
                flagButton23 = false;
                textBox23.Text = binTree[12].Name;
            }
            else if (flagButton24)
            {
                Insert(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 13);
                flagButton24 = false;
                textBox24.Text = binTree[13].Name;
            }
            else if (flagButton25)
            {
                Insert(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 14);
                flagButton25 = false;
                textBox25.Text = binTree[14].Name;
            }
       
            
            textBoxName.Text = "";
            textBoxAge.Text = "";
            textBoxLastName.Text = "";
            textBoxPlaceBthday.Text = "";
            textBoxYearOfBthaday.Text = "";
            textBoxIsDead.Text = "";
            textBoxPlaceDeath.Text = "";
            textBoxYearDEath.Text = "";

            textBoxNamelevel2.Text = "";
            textBoxAgeLevel2.Text = "";
            textBoxLastNamelevel2.Text = "";
            textBoxPlaceBthdLevel2.Text = "";
            textBoxYearBthdLevel2.Text = "";
            textBoxIsdeadLevel2.Text = "";
            textBoxPlaceDeathLevel2.Text = "";
            textBoxYearDeathLevel2.Text = "";

            textBoxNameLevel3.Text = "";
            textBoxAgeLevel3.Text = "";
            textBoxLastNameLevel3.Text = "";
            textBoxPlaceBthdLevel3.Text = "";
            textBoxYearBthdLevel3.Text = "";
            textBoxIsDeadLevel3.Text = "";
            textBoxPlaceDeathLevel3.Text = "";
            textBoxYearDeathLevel3.Text = "";

            panelInfoLevel1.Visible = false;
            panelInfoLeve2.Visible = false;
            panelInfoLevel3.Visible = false;

        }



        //level1
        private void button1_Click(object sender, EventArgs e)
        {
            panelInfoLevel1.Visible = true;
            flagButton1 = true;
            InsertIntoPanel(textBoxName, textBoxAge, textBoxLastName, textBoxPlaceBthday, textBoxYearOfBthaday, textBoxIsDead, textBoxPlaceDeath, textBoxYearDEath, 0);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panelInfoLevel1.Visible = true;
            flagButton2 = true;
            InsertIntoPanel(textBoxName, textBoxAge, textBoxLastName, textBoxPlaceBthday, textBoxYearOfBthaday, textBoxIsDead, textBoxPlaceDeath, textBoxYearDEath, 1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panelInfoLevel1.Visible = true;
            flagButton3 = true;
            InsertIntoPanel(textBoxName, textBoxAge, textBoxLastName, textBoxPlaceBthday, textBoxYearOfBthaday, textBoxIsDead, textBoxPlaceDeath, textBoxYearDEath, 2);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[0].ToString(), pictureBox1);
        }
       
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[1].ToString(), pictureBox2);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[2].ToString(), pictureBox3);
        }

        //level2

        private void button4_Click(object sender, EventArgs e)
        {
            panelInfoLeve2.Visible = true;
            flagButton4 = true;
            InsertIntoPanel(textBoxNamelevel2, textBoxAgeLevel2, textBoxLastNamelevel2, textBoxPlaceBthdLevel2, textBoxYearBthdLevel2, textBoxIsdeadLevel2, textBoxPlaceDeathLevel2, textBoxYearDeathLevel2, 0);

        }
        private void button5_Click(object sender, EventArgs e)
        {
            panelInfoLeve2.Visible = true;
            flagButton5 = true;
            InsertIntoPanel(textBoxNamelevel2, textBoxAgeLevel2, textBoxLastNamelevel2, textBoxPlaceBthdLevel2, textBoxYearBthdLevel2, textBoxIsdeadLevel2, textBoxPlaceDeathLevel2, textBoxYearDeathLevel2, 1);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelInfoLeve2.Visible = true;
            flagButton6 = true;
            InsertIntoPanel(textBoxNamelevel2, textBoxAgeLevel2, textBoxLastNamelevel2, textBoxPlaceBthdLevel2, textBoxYearBthdLevel2, textBoxIsdeadLevel2, textBoxPlaceDeathLevel2, textBoxYearDeathLevel2, 2);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelInfoLeve2.Visible = true;
            flagButton7 = true;
            InsertIntoPanel(textBoxNamelevel2, textBoxAgeLevel2, textBoxLastNamelevel2, textBoxPlaceBthdLevel2, textBoxYearBthdLevel2, textBoxIsdeadLevel2, textBoxPlaceDeathLevel2, textBoxYearDeathLevel2, 3);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelInfoLeve2.Visible = true;
            flagButton8 = true;
            InsertIntoPanel(textBoxNamelevel2, textBoxAgeLevel2, textBoxLastNamelevel2, textBoxPlaceBthdLevel2, textBoxYearBthdLevel2, textBoxIsdeadLevel2, textBoxPlaceDeathLevel2, textBoxYearDeathLevel2, 4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelInfoLeve2.Visible = true;
            flagButton9 = true;
            InsertIntoPanel(textBoxNamelevel2, textBoxAgeLevel2, textBoxLastNamelevel2, textBoxPlaceBthdLevel2, textBoxYearBthdLevel2, textBoxIsdeadLevel2, textBoxPlaceDeathLevel2, textBoxYearDeathLevel2, 5);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panelInfoLeve2.Visible = true;
            flagButton10 = true;
            InsertIntoPanel(textBoxNamelevel2, textBoxAgeLevel2, textBoxLastNamelevel2, textBoxPlaceBthdLevel2, textBoxYearBthdLevel2, textBoxIsdeadLevel2, textBoxPlaceDeathLevel2, textBoxYearDeathLevel2, 6);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[0].ToString(), pictureBox4);
            toolTip.Hide(pictureBox4);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[1].ToString(), pictureBox5);
            toolTip.Hide(pictureBox5);

        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[2].ToString(), pictureBox6);
            toolTip.Hide(pictureBox6);

        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[3].ToString(), pictureBox7);
            toolTip.Hide(pictureBox7);

        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[4].ToString(), pictureBox8);
            toolTip.Hide(pictureBox8);

        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[5].ToString(), pictureBox9);
            toolTip.Hide(pictureBox9);

        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[6].ToString(), pictureBox10);
            toolTip.Hide(pictureBox10);

        }



        //level3

        private void button11_Click(object sender, EventArgs e)
        {
            panelInfoLevel3.Visible = true;
            flagButton11 = true;
            InsertIntoPanel(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 0);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            panelInfoLevel3.Visible = true;
            flagButton12 = true;
            InsertIntoPanel(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 1);


        }
        private void button13_Click(object sender, EventArgs e)
        {
            panelInfoLevel3.Visible = true;
            flagButton13 = true;
            InsertIntoPanel(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 2);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            panelInfoLevel3.Visible = true;
            flagButton14 = true;
            InsertIntoPanel(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 3);

        }

        private void button15_Click(object sender, EventArgs e)
   
        {
            panelInfoLevel3.Visible = true;
            flagButton15 = true;
            InsertIntoPanel(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 4);
        
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panelInfoLevel3.Visible = true;
            flagButton16 = true;
            InsertIntoPanel(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 5);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            panelInfoLevel3.Visible = true;
            flagButton17 = true;
            InsertIntoPanel(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 6);
        }

      private void button18_Click(object sender, EventArgs e)
        {
            panelInfoLevel3.Visible = true;
            flagButton18 = true;
            InsertIntoPanel(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 7);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            panelInfoLevel3.Visible = true;
            flagButton19 = true;
            InsertIntoPanel(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 8);

        }
        private void button20_Click(object sender, EventArgs e)
        {
            panelInfoLevel3.Visible = true;
            flagButton20 = true;
            InsertIntoPanel(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 9);

        }
        private void button21_Click(object sender, EventArgs e)
        {
            panelInfoLevel3.Visible = true;
            flagButton21 = true;
            InsertIntoPanel(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 10);

        }

        private void button22_Click(object sender, EventArgs e)
        {
            panelInfoLevel3.Visible = true;
            flagButton22 = true;
            InsertIntoPanel(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 11);

        }

        private void button23_Click(object sender, EventArgs e)
        {
            panelInfoLevel3.Visible = true;
            flagButton23 = true;
            InsertIntoPanel(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 12);

        }
        private void button24_Click(object sender, EventArgs e)
        {
            panelInfoLevel3.Visible = true;
            flagButton24 = true;
            InsertIntoPanel(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 13);

        }
        private void button25_Click(object sender, EventArgs e)
        {
            panelInfoLevel3.Visible = true;
            flagButton25 = true;
            InsertIntoPanel(textBoxNameLevel3, textBoxAgeLevel3, textBoxLastNameLevel3, textBoxPlaceBthdLevel3, textBoxYearBthdLevel3, textBoxIsDeadLevel3, textBoxPlaceDeathLevel3, textBoxYearDeathLevel3, 14);

        }


        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[0].ToString(), pictureBox11);
            toolTip.Hide(pictureBox11);

        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[1].ToString(), pictureBox12);
            toolTip.Hide(pictureBox12);

        }

        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[2].ToString(), pictureBox13);
            toolTip.Hide(pictureBox13);

        }

        private void pictureBox14_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[3].ToString(), pictureBox14);
            toolTip.Hide(pictureBox14);

        }

        private void pictureBox15_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[4].ToString(), pictureBox15);
            toolTip.Hide(pictureBox15);

        }

        private void pictureBox16_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[5].ToString(), pictureBox16);
            toolTip.Hide(pictureBox16);

        }

        private void pictureBox17_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[6].ToString(), pictureBox17);
            toolTip.Hide(pictureBox17);

        }

        private void pictureBox18_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[7].ToString(), pictureBox18);
            toolTip.Hide(pictureBox18);

        }

        private void pictureBox19_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[8].ToString(), pictureBox19);
            toolTip.Hide(pictureBox19);

        }

        private void pictureBox20_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[9].ToString(), pictureBox20);
            toolTip.Hide(pictureBox20);

        }

        private void pictureBox21_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[10].ToString(), pictureBox21);
            toolTip.Hide(pictureBox21);


        }
  
        private void pictureBox22_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[11].ToString(), pictureBox22);
            toolTip.Hide(pictureBox22);


        }



        private void pictureBox23_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[12].ToString(), pictureBox23);
            toolTip.Hide(pictureBox23);


        }

        private void pictureBox24_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[13].ToString(), pictureBox24);
            toolTip.Hide(pictureBox24);

        }

        private void pictureBox25_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show(binTree[14].ToString(), pictureBox25);
            toolTip.Hide(pictureBox25);

        }

        private void SaveInFile(int level)
        {
            if (binTree.Level == level)
            {
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    sfd.FilterIndex = 2;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, binTree.ToString());
                    }
                }
            }
        }
        private void treeLevel1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveInFile(1);
        }

        private void treeLevel2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveInFile(2);
        }

        private void treeLevel3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveInFile(3);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
