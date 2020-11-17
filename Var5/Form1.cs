using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_5;

namespace Var5
{
    public partial class Form1 : Form
    {
        // описали глобальный объект класса Triangle
        Lib_5.Triangle triangle;
        public Form1()
        {
            InitializeComponent();
        }
        // о программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила Ефимкина Марина. ИСП-31. Вариант 5: Создать класс Triangle (треугольник) с полями-сторонами. Создать необходимые методы и свойства. Определить метод вычисления периметра." +
                " Создать перегруженные методы SetParams, для установки параметров объекта, в том числе увеличения размеров треугольника в 2 раза.");
        }
        // выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        // периметр
        private void периметрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int p;
            // вызываем функцию из класса
            p = triangle.GetPerimetr();
            // выводим на форму
            textBoxPerimetr.Text = Convert.ToString(p);
        }
        // увеличение сторон в 2 раза
        private void увеличениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // вызываем метод увеличения в 2 раза
            triangle.SetParams();
            // обновляем текущие значения
            textBoxStoronaA.Text = triangle.A.ToString();
            textBoxstoronaB.Text = triangle.B.ToString();
            textBoxStaranaC.Text = triangle.C.ToString();
        }
        // сброс
        private void сброситьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // пересоздаем объект со стандартными значениями
            triangle = new Triangle();
            // обновляем текущие значения
            textBoxStoronaA.Text = triangle.A.ToString();
            textBoxstoronaB.Text = triangle.B.ToString();
            textBoxStaranaC.Text = triangle.C.ToString();
            // очищаем поля ввода 
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
        }
        // при загрузке формы создаем объект со стандартными значениями
        private void Form1_Load(object sender, EventArgs e)
        {
            // создаем объект со стандартными значениями
            triangle = new Triangle();
            // выводим текущие значения
            textBoxStoronaA.Text = triangle.A.ToString();
            textBoxstoronaB.Text = triangle.B.ToString();
            textBoxStaranaC.Text = triangle.C.ToString();
        }
        // изменить значения
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBoxA.Text, out int a) && Int32.TryParse(textBoxB.Text, out int b) && Int32.TryParse(textBoxC.Text, out int c))
            {
                // создаем объект с введенными значениями
                triangle = new Triangle(a, b, c);
                // выводим текущие значения
                textBoxStoronaA.Text = triangle.A.ToString();
                textBoxstoronaB.Text = triangle.B.ToString();
                textBoxStaranaC.Text = triangle.C.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка конвертации");
            }
        }
    }
}
