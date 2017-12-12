using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class TheMontiHallParadoxForm : Form
    {
        public TheMontiHallParadoxForm()
        {
            InitializeComponent();
            GenerateDoors();
            ClearButton.Enabled = false;
        }

        readonly Random rnd = new Random();

        private List<Door> doorsList = new List<Door>();

        private int doorsCount = 3;
        private int firstChoosenDoor;
        private int choosenDoor;
        private int victoryDoor;

        private Image doorImage = Image.FromFile("Door.png");
        private Image carImage = Image.FromFile("Car.png");
        private Image goatImage = Image.FromFile("Goat.png");

        // Генерация дверей.
        private void GenerateDoors()
        {
            for (var i = 0; i < doorsCount; i++)
            {
                doorsList.Add(new Door());
                doorsList[i].Number = i + 1;
            }
            firstDoorPictureBox.Image = doorImage;
            secondDoorPictureBox.Image = doorImage;
            thirdDoorPictureBox.Image = doorImage;
        }
        
        // Прячем авто.
        private void HideAuto()
        {
            switch (rnd.Next(0, doorsCount))
            {
                case 0:
                    doorsList[0].ItIsCar = true;
                    victoryDoor = 0;
                    break;
                case 1:
                    doorsList[1].ItIsCar = true;
                    victoryDoor = 1;
                    break;
                case 2:
                    doorsList[2].ItIsCar = true;
                    victoryDoor = 2;
                    break;
            }
        }
        // Первая итерация, открываем дверь без машины
        private void OpenOneDoorWithGoat()
        {
            int value;
            while (true)
            {
                value = rnd.Next(0, doorsCount);
                if (doorsList[value].ItIsCar == false && firstChoosenDoor != value)
                    break;
            }
            OpenDoor(doorsList[value], value);
        }
        // Метод открытия двери.
        private void OpenDoor(Door door, int doorNumber)
        {
            Label label;
            PictureBox pcBox;
            switch (doorNumber)
            {
                case 0:
                    label = firstDoorNumberLabel;
                    pcBox = firstDoorPictureBox;
                    break;
                case 1:
                    label = secondDoorNumberLabel;
                    pcBox = secondDoorPictureBox;
                    break;
                default:
                    label = thirdDoorNumberLabel;
                    pcBox = thirdDoorPictureBox;
                    break;
            }
            if (door.IsOpen) return;
            if (door.ItIsCar)
            {
                label.Text = @"Машина";
                pcBox.Image = carImage;
            }
            else
            {
                label.Text = @"Коза";
                pcBox.Image = goatImage;
            }
            door.IsOpen = true;
        }
        // Метод принятия решения менять дверь или нет
        private void MakeChoise()
        {
            if (MessageBox.Show($@"Выбрана дверь №{firstChoosenDoor + 1} Хотите изменить дверь?", @"Последний выбор",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                for (var i = 0; i < doorsCount; i++)
                    if (!doorsList[i].IsOpen && i != firstChoosenDoor)
                        choosenDoor = i;
            }
            else
                choosenDoor = firstChoosenDoor;
        }
        // Проверка выйграл ли игрок
        private void CheckDoor()
        {
            if (doorsList[choosenDoor].ItIsCar)
                MessageBox.Show($@"Поздравляю, вы победили. Машина в комнате № {choosenDoor + 1}");
            else
                MessageBox.Show($@"Вы проиграли, машина была в команте № {victoryDoor + 1}");
            for (var i = 0; i < doorsList.Count; i++)
                OpenDoor(doorsList[i], i);
        }
        //Визуально выделить дверь с авто
        private void highlightCar()
        {
            if (doorsList[0].ItIsCar)
                firstDoorPictureBox.BorderStyle = BorderStyle.FixedSingle;
            else if (doorsList[1].ItIsCar)
                secondDoorPictureBox.BorderStyle = BorderStyle.FixedSingle;
            else thirdDoorPictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void StartGame()
        {
            HideAuto();
            OpenOneDoorWithGoat();
            MakeChoise();
            CheckDoor();
            highlightCar();
            DisableDoors();
        }
        //Очистка дверей для новой игры
        private void DisableDoors()
        {
            firstDoorPictureBox.Enabled = false;
            secondDoorPictureBox.Enabled = false;
            thirdDoorPictureBox.Enabled = false;
        }

        //Очистка.
        private void ClearButton_Click(object sender, EventArgs e)
        {
            firstDoorNumberLabel.Text = @"Дверь № 1";
            secondDoorNumberLabel.Text = @"Дверь № 2";
            thirdDoorNumberLabel.Text = @"Дверь № 3";
            firstDoorPictureBox.Enabled = true;
            secondDoorPictureBox.Enabled = true;
            thirdDoorPictureBox.Enabled = true;
            doorsList.Clear();
            GenerateDoors();
            ClearButton.Enabled = false;
        }

        //События нажатия на дверь, выбор двери
        private void firstDoorPictureBox_Click(object sender, EventArgs e)
        {
            firstChoosenDoor = 0;
            StartGame();
            ClearButton.Enabled = true;
        }

        private void secondDoorPictureBox_Click(object sender, EventArgs e)
        {
            firstChoosenDoor = 1;
            StartGame();
            ClearButton.Enabled = true;
        }

        private void thirdDoorPictureBox_Click(object sender, EventArgs e)
        {
            firstChoosenDoor = 2;
            StartGame();
            ClearButton.Enabled = true;
        }

        private void OpenStatisticFormButton_Click(object sender, EventArgs e)
        {
            var frm = new StatisticForm();
            frm.ShowDialog();
        }
    }
}
