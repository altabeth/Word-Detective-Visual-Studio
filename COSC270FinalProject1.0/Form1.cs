using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Speech.Synthesis;
using System.IO;



namespace COSC270FinalProject1._0
{

    public partial class Form1 : Form
    {
        SpeechSynthesizer reader;
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(Sscreen));
            t.Start();
            Thread.Sleep(2500);
            Form2 titleScreen = new Form2();
            titleScreen.ShowDialog();
            titleScreen.TopMost = true;
            player = titleScreen.textBox1.Text;

            InitializeComponent();
            t.Abort();
            loadStudent();

            reader = new SpeechSynthesizer { Volume = vol, Rate = rate };
            listView1.LargeImageList = imageList1;

            reader.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(readerProgress);
            reader.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(readerDone);
            toolStripMenuItem1.Click += new EventHandler(clickClear);
            toolStripMenuItem2.Click += new EventHandler(clickAll);
            toolStripMenuItem3.Click += new EventHandler(clickMax);
            toolStripMenuItem4.Click += new EventHandler(clickClearText);
            toolStripMenuItem5.Click += new EventHandler(clickOpen);
            toolStripMenuItem6.Click += new EventHandler(clickGut);

            paperColors.SelectedIndex = 0;
            inkColors.SelectedIndex = 0;
            timer1.Enabled = true;
        }

        public void Sscreen()
        {
            Application.Run(new Form3());
        }

        //**************************************************************************************
        //variables

        char[] sepChars = { ' ', '\n',};
        string player="No-one";
        string filename;
        string badgeFileName;

        List<string> wordList;
        List<string> scoreList;
        List<string> badges;
        Dictionary<string,int> wordScores;


        List<string> theTextArray;
        List<int> wStarts=new List<int>();
        List<int> wLengths = new List<int>();
        int wNum = 0;
        int wInd = 0;
        int hPos = 0;

        int vol = 70, rate = 0;

        Color inkColor = Color.Black;
        Color paperColor = Color.White;
        Color selectColor=Color.Gray;

        Point picPoint;

        int score;
        bool past10 = false;
        bool past20 = false;
        bool past30 = false;
        bool past50 = false;
        

        int wCount = 0;

        Random rnd = new Random();
        int rand;

        int correct;
        string currentWord;

        //*********************************************************************************
        //functions
        private void loadWordList()
        {
            var wordFile = File.ReadAllLines("wordList.txt");
            wordList = new List<string>(wordFile);
            
        }

        private void loadStudent()
        {
           wordScores=new Dictionary<string,int>();
           filename=player+".txt";
            if (File.Exists(filename))
            {

                var scoreFile = File.ReadAllLines(filename);
                scoreList = new List<string>(scoreFile);

                score = int.Parse(scoreList[0]);
                bool str= true;
                bool first = true;
                string temp="oops";
                foreach (string item in scoreList)
                {
                    if (first)
                    {
                        first = false;
                    }
                    else if (str) 
                    {
                        temp = item;
                        str = false;
                    }
                    else
                    {
                        str = true; 
                        wordScores.Add(temp, int.Parse(item));
                    }

                }
            }
            else
            {
                var scoreFile = File.Create(filename);
                scoreFile.Close();
            }
            badgeFileName = player + "badges.txt";
            if (File.Exists(badgeFileName))
            {
                var badgeFile = File.ReadAllLines(badgeFileName);
                badges = new List<string>(badgeFile);

                foreach (string item in badges)
                {
                    var listviewitem = listView1.Items.Add(item.ToUpper());
                    listviewitem.ImageKey = (item + ".png");
                }
            }
            else
            {
                var badgeFile = File.Create(badgeFileName);
                badgeFile.Close();
            }
            if (score >= 50)
            {
                past50 = past30 = past20 = past10 = true;
            }
            else if (score >= 30)
            {
                past30 = past20 = past10 = true;
            }
            else if (score >= 20)
            {
                past20 = past10 = true;
            }
            else if (score >= 10)
            {
                past10 = true;
            }
        }
        private void saveStudent()
        {
            StreamWriter save = new StreamWriter(filename);
            save.WriteLine(score.ToString());
            foreach (var item in wordScores)
            {
                save.WriteLine(item.Key);
                save.WriteLine(item.Value);
            }
            save.Close();

            StreamWriter save2 = new StreamWriter(badgeFileName);
            if (badges != null)
            {
                foreach (var item in badges)
                {
                    save2.WriteLine(item);
                }
                save2.Close();
            }
        }
        //****************************************************************************************************
        //Reader stuff
        private void readerProgress(object sender, SpeakProgressEventArgs e)
        {
            pausing();
            theText.SelectionColor = selectColor;
            if (wInd == 0)
            {
                    theText.Select(0, (wStarts[hPos]+wLengths[hPos]+1));
                    //theText.Select(0, (wLengths[hPos] + 1));
                wInd++;
            }
            else if ((wInd + hPos+1) >= theTextArray.Count)
            {
                theText.Select(0, (wStarts[wInd+hPos] + wLengths[wInd+hPos] + 1));
                //theText.Select(0, (wStarts[wInd + hPos+1]));
                theText.DeselectAll();
            }
            else
            {
                theText.Select(wStarts[wInd+hPos], (wLengths[wInd+hPos] + 1));
                //theText.Select(wStarts[wInd + hPos], (wStarts[wInd + hPos+1]-wStarts[wInd + hPos]));
                wInd++;
            }

        }

        private void readerDone(object sender, SpeakCompletedEventArgs e)
        {
            saveStudent();
            paperColors.Enabled = true;
            inkColors.Enabled = true;
            groupBox1.Enabled = true;
            go.Enabled = true;
            theText.SelectAll();
            theText.SelectionColor = inkColor;
            wInd = 0;
            //MessageBox.Show("Done!");
        }
        //********************************************************************************************
        //More functions
        private void pausing()
        {
            wCount++;
            //timer1.Enabled = false;
            string temp = theTextArray[wInd].ToString().ToLower();

            foreach (string word in wordList)
            {
                //MessageBox.Show(temp+", "+word);
                if (temp == word)
                {
                    if (wCount >= 3)
                    {
                        currentWord = word;
                        reader.Pause();
                        //timer1.Enabled = false;
                        wCount = 0;
                        rand = rnd.Next(1, 4);
                        correct = rand;
                        string tempnamePic = word + ".png";
                        if (correct == 1)
                        {
                            button1.BackgroundImage = Image.FromFile(tempnamePic);
                            rand = rnd.Next(1, wordList.Count);
                            string tempname2 = wordList[rand] + ".png";
                            button2.BackgroundImage = Image.FromFile(tempname2);
                            while (tempnamePic == tempname2)
                            {
                                rand = rnd.Next(0, wordList.Count);
                                tempname2 = wordList[rand] + ".png";
                                button2.BackgroundImage = Image.FromFile(tempname2);
                            }

                            rand = rnd.Next(1, wordList.Count);
                            string tempname3 = wordList[rand] + ".png";
                            button3.BackgroundImage = Image.FromFile(tempname3);
                            while (tempnamePic == tempname3||tempname3==tempname2)
                                {
                                    rand = rnd.Next(0, wordList.Count);
                                    tempname3 = wordList[rand] + ".png";
                                    button3.BackgroundImage = Image.FromFile(tempname3);
                                }
               
                            
                        }
                        else if(correct == 2)
                        {
                            button2.BackgroundImage = Image.FromFile(tempnamePic);
                            rand = rnd.Next(1, wordList.Count);
                            string tempname2 = wordList[rand] + ".png";
                            button1.BackgroundImage = Image.FromFile(tempname2);
                            while (tempnamePic == tempname2)
                            {
                                rand = rnd.Next(0, wordList.Count);
                                tempname2 = wordList[rand] + ".png";
                                button1.BackgroundImage = Image.FromFile(tempname2);
                            }

                            rand = rnd.Next(1, wordList.Count);
                            string tempname3 = wordList[rand] + ".png";
                            button3.BackgroundImage = Image.FromFile(tempname3);
                            while (tempnamePic == tempname3 || tempname3 == tempname2)
                            {
                                rand = rnd.Next(0, wordList.Count);
                                tempname3 = wordList[rand] + ".png";
                                button3.BackgroundImage = Image.FromFile(tempname3);
                            }
                        }
                        else if (correct == 3)
                        {
                            button3.BackgroundImage = Image.FromFile(tempnamePic);
                            rand = rnd.Next(1, wordList.Count);
                            string tempname2 = wordList[rand] + ".png";
                            button2.BackgroundImage = Image.FromFile(tempname2);
                            while (tempnamePic == tempname2)
                            {
                                rand = rnd.Next(0, wordList.Count);
                                tempname2 = wordList[rand] + ".png";
                                button2.BackgroundImage = Image.FromFile(tempname2);
                                //MessageBox.Show("button3 should have " + tempname2);
                            }

                            rand = rnd.Next(1, wordList.Count);
                            string tempname3 = wordList[rand] + ".png";
                            button1.BackgroundImage = Image.FromFile(tempname3);
                            //MessageBox.Show("button3 should have " + tempname3);
                            while (tempnamePic == tempname3 || tempname3 == tempname2)
                            {
                                rand = rnd.Next(1, wordList.Count);
                                tempname3 = wordList[rand] + ".png";
                                button1.BackgroundImage = Image.FromFile(tempname3);
                                //MessageBox.Show("button1 should have " + tempname3);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Oh noes!  Bad randomness!");
                        }

                        break;
                    }
                    break;
                }
            }

        }

        private void resuming(int ans)
        {
            button1.BackgroundImage = null;
            button2.BackgroundImage = null;
            button3.BackgroundImage = null;
            timer1.Enabled = true;
            if (highBox.Checked == true)
            {
                theText.Focus();
            }
            if (ans == correct)
            {
                axWindowsMediaPlayer1.settings.volume = 15;
                axWindowsMediaPlayer1.URL = "ding.mp3";
                
                if (highBox.Checked == true || fadePast.Checked == true)
                {
                    score++;
                }
                else if (cat.Checked == true)
                {
                    score+=2;
                }
                else if (disappear.Checked == true)
                {
                    score += 4;
                }
                else
                {
                    score += 3;
                }

                try
                {
                    wordScores[currentWord] += 1;
                    if (wordScores[currentWord] == 15)
                    {

                        var listviewitem=listView1.Items.Add(currentWord.ToUpper());
                        listviewitem.ImageKey = (currentWord + ".png");
                        badges.Add(currentWord);

                        MessageBox.Show("New Badge! \nYou have achieved Level 1 for " + currentWord.ToUpper());
                    }
                }
                catch (KeyNotFoundException)
                {
                    wordScores.Add(currentWord, 1);
                }
            }
            else
            {
                axWindowsMediaPlayer2.settings.volume = 15;
                axWindowsMediaPlayer2.URL = "zip.wav";
                if (wordScores[currentWord] > 0)
                {
                    wordScores[currentWord]--;
                }
            }
            if (!past10&&score >= 10)
            {
                past10 = true;
                //MessageBox.Show("You have earned " + score + " points!");
            }
            else if (!past20&&score>=20)
            {
                past20 = true;
                //MessageBox.Show("You have earned " + score + " points!");
            }
            else if(!past30&&score>=30)
            {
                past30 = true;
                //MessageBox.Show("You have earned " + score + " points!");
            }
            else if (!past50 && score >= 50)
            {
                past50 = true;
                //MessageBox.Show("You have earned " + score + " points!");
            }
            //MessageBox.Show("calling resume!");
            reader.Resume();
            timer1.Enabled = true;
        }
        private void setPaper()
        {
            if (paperColors.SelectedIndex==0)
            {
                paperColor = Color.White;
            }
            else if (paperColors.SelectedIndex==1)
            {
                paperColor = Color.LightBlue;
            }
            else if (paperColors.SelectedIndex == 2)
            {
                paperColor = Color.Wheat;
            }
            else if (paperColors.SelectedIndex == 3)
            {
                paperColor = Color.LightGreen;
            }
            else if (paperColors.SelectedIndex == 4)
            {
                paperColor = Color.Black;
            }

            theText.BackColor = paperColor;
        }

        private void setInk()
        {
            if (inkColors.SelectedIndex == 0)
            {
                inkColor = Color.Black;
            }
            else if (inkColors.SelectedIndex == 1)
            {
                inkColor = Color.Brown;
            }
            else if (inkColors.SelectedIndex == 2)
            {
                inkColor = Color.Blue;
            }
            else if (inkColors.SelectedIndex == 3)
            {
                inkColor = Color.Green;
            }
            else if (inkColors.SelectedIndex == 4)
            {
                inkColor = Color.White;
            }

            theText.ForeColor = inkColor;
        }

        //***********************************************************************************************
        //events
        private void go_Click(object sender, EventArgs e)
        {
            picPoint.X = (theText.Location.X + theText.Width);
            picPoint.Y = (theText.Location.Y);
            pictureBox1.Location= picPoint;
            
            if (highBox.Checked==true)
            {
                theText.Focus();
            }
            if (fadePast.Checked == true)
            {
                theText.DeselectAll();
                selectColor = Color.Gray;
                hPos = 0;
            }
            if (cat.Checked == true)
            {

            }
            if (disappear.Checked == true)
            {
                theText.DeselectAll();
                selectColor = paperColor;
                hPos = 2;
            }
            if (fadePast.Checked == false && disappear.Checked == false)
            {
                selectColor = inkColor;
            }
            paperColors.Enabled = false;
            inkColors.Enabled = false;
            groupBox1.Enabled = false;
            go.Enabled = false;
            //generate lists of word starting positions and lengths from text
            //theTextArray = theText.Text.Split(sepChars, StringSplitOptions.RemoveEmptyEntries).ToList();
            theTextArray.Clear();
            wStarts.Clear();
            wLengths.Clear();
            theTextArray = theText.Text.Split(sepChars, StringSplitOptions.RemoveEmptyEntries).ToList();
            wNum = theTextArray.Count;
            foreach(string word in theTextArray)
            {
                    wLengths.Add(word.Length);
                    wStarts.Add(wInd);
                    wInd += word.Length + 1;
            }

            wInd = 0;

            //make sure the text spacing matches the lists
            theText.Text = null;
            foreach(string word in theTextArray)
            {
                theText.Text += word;
                theText.Text += " ";
            }

            timer1.Enabled = true;
            reader.SpeakAsync(theText.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //vol = hScrollBar1.Value;
            //reader.Volume = hScrollBar1.Value;
            scoreLabel.Text = score.ToString();
            setPaper();
            setInk();
            if (cat.Checked == true)
            {
                if (wStarts != null)
                {

                    if (pictureBox1.Location.Y < (theText.GetPositionFromCharIndex(wStarts[wInd+hPos]).Y))
                    {
                        picPoint.Y += 4;
                    }

                }
                pictureBox1.Location = picPoint;
            }
            //pausing();

        }

        private void disappear_CheckedChanged(object sender, EventArgs e)
        {
            if (disappear.Checked == true)
            {
                highBox.Checked = false;
                cat.Checked = false;
                fadePast.Checked = false;
            }
        }

        private void highBox_CheckedChanged(object sender, EventArgs e)
        {
            disappear.Checked = false;
        }

        private void fadePast_CheckedChanged(object sender, EventArgs e)
        {
            disappear.Checked = false;
        }

        private void cat_CheckedChanged(object sender, EventArgs e)
        {
            picPoint.X = (theText.Location.X + theText.Width);
            picPoint.Y = (theText.Location.Y);
            pictureBox1.Location = picPoint;
            
            disappear.Checked = false;
            if (cat.Checked == true)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            reader.SpeakAsyncCancelAll();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            highBox.Checked = false;
            fadePast.Checked = false;
            cat.Checked = false;
            disappear.Checked = false;
            read.Checked = false;

        }

        private void paperColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pictureBox1.BackColor = paperColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            theTextArray = theText.Text.Split(sepChars, StringSplitOptions.RemoveEmptyEntries).ToList();
            wNum = theTextArray.Count;

            foreach (string word in theTextArray)
            {
                wLengths.Add(word.Length);
                wStarts.Add(wInd);
                wInd += word.Length + 1;
            }
            wInd = 0;
            
            loadWordList();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            reader.Pause();
        }

        private void resume_Click(object sender, EventArgs e)
        {
            reader.Resume();
        }

        private void ansPic1_Click_1(object sender, EventArgs e)
        {

        }

        private void ansPic3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resuming(1);
            //MessageBox.Show("I clicked!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resuming(2);
            //MessageBox.Show("I clicked!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resuming(3);
            //MessageBox.Show("I clicked!");
        }

        private void optionsMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ansPic2_Click_1(object sender, EventArgs e)
        {
            
        }
        private void clickClear(object sender, EventArgs e)
        {
            highBox.Checked = false;
            fadePast.Checked = false;
            cat.Checked = false;
            disappear.Checked = false;
            read.Checked = false;
        }
        private void clickAll(object sender, EventArgs e)
        {
            highBox.Checked = true;
            fadePast.Checked = true;
            cat.Checked = true;
            disappear.Checked = false;
        }
        private void clickMax(object sender, EventArgs e)
        {
            highBox.Checked = false;
            fadePast.Checked = false;
            cat.Checked = false;
            disappear.Checked = true;
        }
        private void clickClearText(object sender, EventArgs e)
        {
            theText.Text = "";
        }
        private void clickOpen(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                theText.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void track_CheckedChanged(object sender, EventArgs e)
        {
            if (track.Checked == true)
            {
                read.Checked = false;
            }
            else
            {
                read.Checked = true;
            }
        }

        private void read_CheckedChanged(object sender, EventArgs e)
        {
            if (read.Checked == true)
            {
                track.Checked = false;
            }
            else
            {
                track.Checked = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        bool musicOn = false;
        private void music_Click(object sender, EventArgs e)
        {
            if (musicOn == false)
            {
                musicOn = true;
                axWindowsMediaPlayer3.URL = "VariationII.wav";
                axWindowsMediaPlayer3.settings.setMode("loop", true);
            }
            else
            {
                musicOn = false;
                axWindowsMediaPlayer3.Ctlcontrols.stop();
            }
        }

        private void clickGut(object sender, EventArgs e)
        {
            Form4 browse = new Form4();
            browse.ShowDialog();
        }
    }
}
