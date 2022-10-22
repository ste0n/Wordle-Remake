using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordle
{
    public partial class Form1 : Form
    {
        List<char> chars = new List<char>();
        List<string> wordlist = new List<string>();
        List<char> wordlistgui = new List<char>();
        List<char> textlist = new List<char>();
        int foreachint1 = 0;
        Random rndd = new Random();
        int random = 0; 
        bool same = false;
        string rndword;

        public Form1()
        {
            InitializeComponent();
        }
       
           
          

        public void gui()
        {
            int m = 0;
            m = 0;
            foreach (Label g in groupBox1.Controls)
            {
                if (chars[m] == wordlistgui[m])
                {
                    g.BackColor = Color.Green;
                }


                






                m++;
            }
            int foreachint3 = 0;
            foreachint3 = 0;
            foreach (Label j in groupBox1.Controls)
            {
                if(j.BackColor != Color.Green && j.Text != "_")
                {
                    j.BackColor = Color.Gray;

                }
               
                
                same = false;
                foreach (char z in wordlistgui)
                {
                    
                    if (z.ToString() == j.Text)
                    {
                        same=true;
                    }
                }
                if(same == true&&j.BackColor!= Color.Green)
                {
                    j.BackColor = Color.Orange;

                }
               
               
                
                



                foreachint3++;
            }
            
            



        }
        public void win()
        {
            
            if (rndword == textBox1.Text)
            {
                MessageBox.Show($"Congratulations You won the word was: {textBox1.Text} ");
            }
            else
            {
                bool kk = true;
                kk = true;
                foreach (Label j in groupBox1.Controls)
                {
                    if(j.Text == "_")
                    {
                        kk = false;
                    }
                   
                }
                if (kk)
                {
                    MessageBox.Show("Congratulations You LOST(https://www.youtube.com/watch?v=rUzrsxZOLxs&ab_channel=LesleyKennyOsborne)");

                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textlist.Clear();

            foreach(char u in textBox1.Text)
            {
                textlist.Add(u);
            }
            if(textlist.Count == 5)
            {
                foreach (char k in textBox1.Text)
                {

                    chars[foreachint1] = k;
                    foreachint1++;

                }

                int foreachint2 = 0;
                foreachint2 = 0;
                foreach (Label j in groupBox1.Controls)
                {

                    j.Text = chars[foreachint2].ToString();



                    foreachint2++;
                }


                gui();
                win();
                textBox1.Text = "";


            }
            else
            {
                MessageBox.Show("5 Letters not more and not less! ");
            }
           
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wordlist.Add("abuse");
            wordlist.Add("adult");
            wordlist.Add("agent");
            wordlist.Add("apple");


            wordlist.Add("beach");
            wordlist.Add("basis");
            wordlist.Add("block");
            wordlist.Add("blood");
            wordlist.Add("board");
            wordlist.Add("brain");
            wordlist.Add("bread");
            wordlist.Add("chain");
            wordlist.Add("chief");
            wordlist.Add("child");
            wordlist.Add("china");


            wordlist.Add("crime");
            wordlist.Add("dream");

            wordlist.Add("draft");
            wordlist.Add("enemy");
            wordlist.Add("error");
            wordlist.Add("death");
            wordlist.Add("place");
            wordlist.Add("plant");
            wordlist.Add("plane");
            wordlist.Add("river");
            wordlist.Add("scale");
            wordlist.Add("skill");



            wordlist.Add("event");
            int rnd = rndd.Next(0, wordlist.Count);
            random = rnd;
            rndword = wordlist[random];
            foreach (char ss in rndword)
            {
                wordlistgui.Add(ss);
            }
            foreach (char ss in rndword)
            {
                wordlistgui.Add(ss);
            }
            foreach (char ss in rndword)
            {
                wordlistgui.Add(ss);
            }
            foreach (char ss in rndword)
            {
                wordlistgui.Add(ss);
            }
            foreach (char ss in rndword)
            {
                wordlistgui.Add(ss);
            }
            foreach (char ss in rndword)
            {
                wordlistgui.Add(ss);
            }

            for (int i = 0; i < 30; i++)
            {
                char b = '_';
                


                chars.Add(b);


            }
        
           

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            foreach (Label j in groupBox1.Controls)
            {

                j.Text = "_";
                j.BackColor = Color.White;



                
            }
            foreachint1 = 0;

            wordlistgui.Clear();
            textlist.Clear();
            chars.Clear();
            int rnd = rndd.Next(0, wordlist.Count);
            random = rnd;
            rndword = wordlist[random];
            foreach (char ss in rndword)
            {
                wordlistgui.Add(ss);
            }
            foreach (char ss in rndword)
            {
                wordlistgui.Add(ss);
            }
            foreach (char ss in rndword)
            {
                wordlistgui.Add(ss);
            }
            foreach (char ss in rndword)
            {
                wordlistgui.Add(ss);
            }
            foreach (char ss in rndword)
            {
                wordlistgui.Add(ss);
            }
            foreach (char ss in rndword)
            {
                wordlistgui.Add(ss);
            }

            for (int i = 0; i < 30; i++)
            {
                char b = '_';



                chars.Add(b);


            }


        }
    }
}
