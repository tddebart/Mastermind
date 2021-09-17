﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// ReSharper disable PossibleNullReferenceException

namespace Mastermind
{
    public partial class Form1 : Form
    {
        private readonly Random rnd = new Random();

        private ColorPin[] code;

        private int currentRowIndex;

        private bool end;

        private readonly Color[] mainColors = {Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Orange, Color.Indigo };

        public Form1()
        {   
            InitializeComponent();
            GenerateCode();
        }

        private void GenerateCode()
        {
            List<int> numbers = new List<int>();
            
            const int amountOfColours = 6;

            for (int i = 0; i < 4; i++)
            {
                int number;
                do {
                    number = rnd.Next(0, amountOfColours);
                } while (numbers.Contains(number));
                numbers.Add(number);
            }

            List<Color> colors = new List<Color>();
            foreach (var numb in numbers)
            {
                colors.Add(mainColors[numb]);
            }
            
            code = new[]
            {
                new ColorPin(colors[0], 1),
                new ColorPin(colors[1], 2),
                new ColorPin(colors[2], 3),
                new ColorPin(colors[3],4)
            };
        }

        private void CreateRow()
        {
            foreach (var value in code)
            {
                value.hasBeenChecked = false;
            }
            var pins = new[]
            {
                new ColorPin(label1.BackColor, 1), 
                new ColorPin(label2.BackColor, 2), 
                new ColorPin(label3.BackColor, 3),
                new ColorPin(label4.BackColor, 4)
            };
            
            var row = new Row(pins, code);

            Panel mainRow = new RowPanel();
            var mainRowLocation = mainRow.Location;
            mainRowLocation.Y -= 50*currentRowIndex;
            mainRow.Location = mainRowLocation;
            
            mainRow.Visible = true;
            
            for (int i = 1; i < 5; i++)
            {
                ((Panel) mainRow.Controls.Find("red" + i, true).FirstOrDefault()).BackColor = Color.Gray;
                ((Label) mainRow.Controls.Find("indicator" + i, true).FirstOrDefault()).BackColor = pins[i-1].value;
            }
            for (int i = 0; i < row.rightColor; i++)
            {
                ((Panel) mainRow.Controls.Find("red" + row.indicatorIndex, true).FirstOrDefault()).BackColor = Color.White;
                row.indicatorIndex++;
            }
            for (int i = 0; i < row.rightColorRightPosition; i++)
            {
                ((Panel) mainRow.Controls.Find("red" + row.indicatorIndex, true).FirstOrDefault()).BackColor = Color.Black;
                row.indicatorIndex++;
            }

            #if DEBUG
            resultLabel.Text = String.Empty;
            foreach (var value in code.Select(pin => pin.value.Name))
            {
                resultLabel.Text += value;
                resultLabel.Text += ", ";
            }
            #endif

            mainRow.Visible = true;
            Controls.Add(mainRow);
            currentRowIndex++;

            if (row.rightColorRightPosition == 4)
            {
                end = true;
                winText.Text = "Gefeliciteerd je hebt gewonnen, wil je nog een keer spelen?";
                winButton1.Visible = true;
                winButton2.Visible = true;
            }
            else if (currentRowIndex == 10)
            {
                var text = "";
                foreach (var value in code.Select(pin => pin.value.Name))
                {
                    text += value;
                    text += ", ";
                }

                winText.Text = "Helaas je hebt het niet geraden de code was: " + text + "wil je nog een keer spelen?";
                winButton1.Visible = true;
                winButton2.Visible = true;
                end = true;
            }
        }

        private static void Reset()
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private int currentIndex = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (end) return;
            CreateRow();
            label1.BackColor = Color.Empty;
            label2.BackColor = Color.Empty;
            label3.BackColor = Color.Empty;
            label4.BackColor = Color.Empty;
            currentIndex = 1;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(end) return;
            if (e.KeyCode == Keys.Back && currentIndex != 1)
            {
                currentIndex--;
                ((Label) Controls.Find("label" + currentIndex, true).FirstOrDefault()).BackColor = Color.Empty;
            }
            if (currentIndex== 5) return;
            if (e.KeyCode == Keys.F1)
            {
                ((Label) Controls.Find("label" + currentIndex, true).FirstOrDefault()).BackColor = mainColors[0];
                currentIndex++;
            }
            if (e.KeyCode == Keys.F2)
            {
                ((Label) Controls.Find("label" + currentIndex, true).FirstOrDefault()).BackColor = mainColors[1];
                currentIndex++;
            }
            if (e.KeyCode == Keys.F3)
            {
                ((Label) Controls.Find("label" + currentIndex, true).FirstOrDefault()).BackColor = mainColors[2];
                currentIndex++;
            }
            if (e.KeyCode == Keys.F4)
            {
                ((Label) Controls.Find("label" + currentIndex, true).FirstOrDefault()).BackColor = mainColors[3];
                currentIndex++;
            }
            if (e.KeyCode == Keys.F5)
            {
                ((Label) Controls.Find("label" + currentIndex, true).FirstOrDefault()).BackColor = mainColors[4];
                currentIndex++;
            }
            if (e.KeyCode == Keys.F6)
            {
                ((Label) Controls.Find("label" + currentIndex, true).FirstOrDefault()).BackColor = mainColors[5];
                currentIndex++;
            }
        }
        
        private void winButton1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void winButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public class Row
        {
            public readonly int rightColorRightPosition;
            public readonly int rightColor;

            public ColorPin[] pins;
            public int indicatorIndex=1;

            public Row(ColorPin[] pins, ColorPin[] code)
            {
                this.pins = pins;

                for (var i = 0; i < code.Length; i++)
                {
                    if (code[i].value == pins[i].value && code[i].position == pins[i].position && !code[i].hasBeenChecked)
                    {
                        rightColorRightPosition++;
                        code[i].hasBeenChecked = true;
                    }
                    else
                    {
                        if (pins.Any(val => val.value == code[i].value && !code[i].hasBeenChecked))
                        {
                            rightColor++;
                            code[i].hasBeenChecked = true;
                        }
                    }
                }
            }
        }

        public class ColorPin
        {
            public Color value;
            public int position;
            public bool hasBeenChecked;

            public ColorPin(Color value, int position = 0)
            {
                this.value = value;
                this.position = position;
            }
        }
    }
}