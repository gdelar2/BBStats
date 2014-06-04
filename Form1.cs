using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BBStats
{
    public partial class Form1 : Form
    {

        mySQLHelper db;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //db.insertGame(123456, DateTime.Now.ToString("M/d/yyyy"), "'red Sox'", 5, 8);
        }

        private void Games_Screen_Button_Click(object sender, EventArgs e)
        {
            Games_Screen gameScreen = new Games_Screen();
            gameScreen.Show();
        }

        private void Go_Button_Click(object sender, EventArgs e)
        {//this is for testing purposes. no hardcoding of the credentials
            db = new mySQLHelper(userName_box.Text, password_Box.Text);

          
            db.insertGame(123456, DateTime.Now.ToString("M/d/yyyy"), userName_box.Text, 5, 8);
            
        }

        private void Add_Player_Click(object sender, EventArgs e)
        {
            Add_Player addPlayer = new Add_Player();
            addPlayer.Show();
        }

        
    }
}
