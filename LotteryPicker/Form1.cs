using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryPicker
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();

        int numberOne;
        int numberTwo;
        int numberThree;
        int numberFour;
        int numberFive;
        int numberSix;
        

        const int maxValue = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            numberOne = randGen.Next(1, 100);
            numberTwo = randGen.Next(1, 100);
           while (numberTwo == numberOne)
            {
                Random randGen = new Random();

                numberTwo = randGen.Next(1, 100);
            }
        numberThree = randGen.Next(1, 100);
        while (numberThree == numberTwo)
            {
                Random randGen = new Random();

                numberThree = randGen.Next(1, 100);
            }
            numberFour = randGen.Next(1, 100);
            while(numberFour == numberThree)
            {
                Random randGen = new Random();

                numberFour = randGen.Next(1, 100);
            }
            numberFive = randGen.Next(1, 100);
            while(numberFive == numberFour)
            {
                Random randGen = new Random();

                numberFive = randGen.Next(1, 100);
            }
            numberSix = randGen.Next(1, 100);
            while(numberSix == numberFive)
            {
                Random randGen = new Random();

                numberSix = randGen.Next(1, 100);
            }

            numberLabel.Text = $"{numberOne} {numberTwo} {numberThree} {numberFour} {numberFive} {numberSix}";

            
        }
    }
}
