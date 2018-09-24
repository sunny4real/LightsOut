using System;
using System.Drawing;

namespace LightsOutApp
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn00_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{true, true, false, false, false},
                                           {true, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5 ,5]  {{true, true, true, false, false},
                                           {false, true, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5,5]  {{false, true, true, true, false},
                                           {false, false, true, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, true, true, true},
                                           {false, false, false, true, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, true, true},
                                           {false, false, false, false, true},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{true, false, false, false, false},
                                           {true, true, false, false, false},
                                           {true, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, true, false, false, false},
                                           {true, true, true, false, false},
                                           {false, true, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, true, false, false},
                                           {false, true, true, true, false},
                                           {false, false, true, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, true, false},
                                           {false, false, true, true, true},
                                           {false, false, false, true, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, true},
                                           {false, false, false, true, true},
                                           {false, false, false, false, true},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, false},
                                           {true, false, false, false, false},
                                           {true, true, false, false, false},
                                           {true, false, false, false, false},
                                           {false, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, false},
                                           {false, true, false, false, false},
                                           {true, true, true, false, false},
                                           {false, true, false, false, false},
                                           {false, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, false},
                                           {false, false, true, false, false},
                                           {false, true, true, true, false},
                                           {false, false, true, false, false},
                                           {false, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, false},
                                           {false, false, false, true, false},
                                           {false, false, true, true, true},
                                           {false, false, false, true, false},
                                           {false, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, false},
                                           {false, false, false, false, true},
                                           {false, false, false, true, true},
                                           {false, false, false, false, true},
                                           {false, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {true, false, false, false, false},
                                           {true, true, false, false, false},
                                           {true, false, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, true, false, false, false},
                                           {true, true, true, false, false},
                                           {false, true, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, true, false, false},
                                           {false, true, true, true, false},
                                           {false, false, true, false, false}};
            ToggleKeys(esho);
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, true, false},
                                           {false, false, true, true, true},
                                           {false, false, false, true, false}};
            ToggleKeys(esho);
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, true},
                                           {false, false, false, true, true},
                                           {false, false, false, false, true}};
            ToggleKeys(esho);
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {true, false, false, false, false},
                                           {true, true, false, false, false}};
            ToggleKeys(esho);
        }

        private void btn41_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, true, false, false, false},
                                           {true, true, true, false, false}};
            ToggleKeys(esho);
        }

        private void btn42_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, true, false, false},
                                           {false, true, true, true, false}};
            ToggleKeys(esho);
        }

        private void btn43_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, true, false},
                                           {false, false, true, true, true}};
            ToggleKeys(esho);
        }

        private void btn44_Click(object sender, EventArgs e)
        {
            bool[,] esho = new bool[5, 5]  {{false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, false},
                                           {false, false, false, false, true},
                                           {false, false, false, true, true}};
            ToggleKeys(esho);
        }


        bool[,] Keys = new bool[5, 5];
        //setting a method for Toggle Key
        private void ToggleKeys(bool[,] sade)
        {
            for(int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    Keys[a, b] ^= sade[a, b];
                }
            }
            //booleans for switching lights on/off
            if (Keys[0, 0] == true) btn00.BackColor = Color.DarkGreen;
            else btn00.BackColor = Color.LightGreen;

            if (Keys[0, 1] == true) btn01.BackColor = Color.LightGreen;
            else btn01.BackColor = Color.DarkGreen;

            if (Keys[0, 2] == true) btn02.BackColor = Color.LightGreen;
            else btn02.BackColor = Color.DarkGreen;

            if (Keys[0, 3] == true) btn03.BackColor = Color.LightGreen;
            else btn03.BackColor = Color.DarkGreen;

            if (Keys[0, 4] == true) btn04.BackColor = Color.LightGreen;
            else btn04.BackColor = Color.DarkGreen;


            if (Keys[1, 0] == true) btn10.BackColor = Color.LightGreen;
            else btn10.BackColor = Color.DarkGreen;

            if (Keys[1, 1] == true) btn11.BackColor = Color.LightGreen;
            else btn11.BackColor = Color.DarkGreen;

            if (Keys[1, 2] == true) btn12.BackColor = Color.LightGreen;
            else btn12.BackColor = Color.DarkGreen;

            if (Keys[1, 3] == true) btn13.BackColor = Color.LightGreen;
            else btn13.BackColor = Color.DarkGreen;

            if (Keys[1, 4] == true) btn14.BackColor = Color.LightGreen;
            else btn14.BackColor = Color.DarkGreen;


            if (Keys[2, 0] == true) btn20.BackColor = Color.LightGreen;
            else btn20.BackColor = Color.DarkGreen;

            if (Keys[2, 1] == true) btn21.BackColor = Color.LightGreen;
            else btn21.BackColor = Color.DarkGreen;

            if (Keys[2, 2] == true) btn22.BackColor = Color.LightGreen;
            else btn22.BackColor = Color.DarkGreen;

            if (Keys[2, 3] == true) btn23.BackColor = Color.LightGreen;
            else btn23.BackColor = Color.DarkGreen;

            if (Keys[2, 4] == true) btn24.BackColor = Color.LightGreen;
            else btn24.BackColor = Color.DarkGreen;


            if (Keys[3, 0] == true) btn30.BackColor = Color.LightGreen;
            else btn30.BackColor = Color.DarkGreen;

            if (Keys[3, 1] == true) btn31.BackColor = Color.DarkGreen;
            else btn31.BackColor = Color.LightGreen;

            if (Keys[3, 2] == true) btn32.BackColor = Color.LightGreen;
            else btn32.BackColor = Color.DarkGreen;

            if (Keys[3, 3] == true) btn33.BackColor = Color.LightGreen;
            else btn33.BackColor = Color.DarkGreen;

            if (Keys[3, 4] == true) btn34.BackColor = Color.LightGreen;
            else btn34.BackColor = Color.DarkGreen;


            if (Keys[4, 0] == true) btn40.BackColor = Color.LightGreen;
            else btn40.BackColor = Color.DarkGreen;

            if (Keys[4, 1] == true) btn41.BackColor = Color.LightGreen;
            else btn41.BackColor = Color.DarkGreen;

            if (Keys[4, 2] == true) btn42.BackColor = Color.LightGreen;
            else btn42.BackColor = Color.DarkGreen;

            if (Keys[4, 3] == true) btn43.BackColor = Color.LightGreen;
            else btn43.BackColor = Color.DarkGreen;

            if (Keys[4, 4] == true) btn44.BackColor = Color.LightGreen;
            else btn44.BackColor = Color.DarkGreen;
        }
        //method for closing the LightsOut App
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
