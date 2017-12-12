using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_4
{
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private int[] resultWithSwapChoise = { 0, 0 };
        private int[] resultWithoutSwapChoise = { 0, 0 };

        private List<Door> doorsList = new List<Door>();

        private string[] chartSeriesNames = { "Угадал", "Не угадал" };

        private int victoryDoor;
        private int firstChoosenDoor;
        private int choosenDoor;
        private int countDoors = 3;
        private int attemptsCount = 10000;

        // Генерация и заполнение дверей.
        private void GenerateAndFillDoors()
        {
            for (var i = 0; i < countDoors; i++)
                doorsList.Add(new Door());
            victoryDoor = rnd.Next(0, countDoors);
            doorsList[victoryDoor].ItIsCar = true;

        }
        // Открытие двери без машины.
        private void OpenOneDoorWithGoat()
        {
            int value;
            while (true)
            {
                value = rnd.Next(0, countDoors);
                if (doorsList[value].ItIsCar == false && value != firstChoosenDoor)
                    break;
            }
            doorsList[value].IsOpen = true;
        }
        // Выбор - Менять/Не менять.
        private void MakeChoise(bool swap)
        {
            if (swap)
            {
                for (var i = 0; i < countDoors; i++)
                    if ((!doorsList[i].IsOpen) && (i != firstChoosenDoor))
                        choosenDoor = i;
            }
            else
                choosenDoor = firstChoosenDoor;
        }
        // Проверка победил ли игрок.
        private void CheckDoorWithChoice()
        {
            if (doorsList[choosenDoor].ItIsCar)
                resultWithSwapChoise[0]++;
            else
                resultWithSwapChoise[1]++;
        }

        private void CheckDoorWithoutChoice()
        {
            if (doorsList[choosenDoor].ItIsCar)
                resultWithoutSwapChoise[0]++;
            else
                resultWithoutSwapChoise[1]++;
        }
       
        private void ClearDoors()
        {
            doorsList.Clear();
        }
        // Подсчет с изменением двери.
        private void RollWithChoosing()
        {
            for (var i = 0; i < attemptsCount; i++)
            {
                firstChoosenDoor = rnd.Next(0, countDoors);
                GenerateAndFillDoors();
                OpenOneDoorWithGoat();
                MakeChoise(true);
                CheckDoorWithChoice();
                ClearDoors();
            }
        }
        // Подсчет без изменения двери.
        private void RollWithoutChoosing()
        {
            for (var i = 0; i < attemptsCount; i++)
            {
                firstChoosenDoor = rnd.Next(0, countDoors);
                GenerateAndFillDoors();
                OpenOneDoorWithGoat();
                MakeChoise(false);
                CheckDoorWithoutChoice();
                ClearDoors();
            }
        }
        //Генерация графика
        private void GenerateChart(int[] pList, string title, Chart chart)
        {
            chart.Titles.Add(title);
            chart.Palette = ChartColorPalette.Berry;
            for (var i = 0; i < pList.Length; i++)
            {
                var series = chart.Series.Add(chartSeriesNames[i]);
                series.Points.Add(pList[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RollWithChoosing();
            RollWithoutChoosing();
            GenerateChart(resultWithSwapChoise, "Результат с изменением решения", FirstChart);
            GenerateChart(resultWithoutSwapChoise, "Результат без изменением решения", SecondChart);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
