using System.ComponentModel.DataAnnotations;

namespace HomeWork_WinForm_N1
{
    //Задание 2
    //Написать функцию, которая "угадывает" задуманное пользователем число от 1 до 2000.
    //Для запроса к пользователю использовать MessageBox.
    //После того, как число отгадано, необходимо вывести количество запросов,
    //потребовавшихся для этого, и предоставить пользователю возможность сыграть ещё раз,
    //не выходя из программы.
    //(MessageBox-ы оформляются кнопками и значками соответственно ситуации)
    public partial class Form1 : Form
    {
        int min = 1;
        int max = 2000;
        int number = 1000;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            labelNumber.Text = Convert.ToString(number);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelNumber.Text = Convert.ToString(number);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            max = number;
            number = (max + min) / 2;
            labelNumber.Text = Convert.ToString((int)number);
            count++;
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            min = number;
            number = (max + min) / 2;
            labelNumber.Text = Convert.ToString((int)number);
            count++;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string answer = "";
            if (count % 10 == 1)
            {
                answer = "попытку";
            }
            else if (count % 10 < 5)
            {
                answer = "попытки";
            }
            else
            {
                answer = "попыток";
            }
            MessageBox.Show($"Загаданное число было отгадано за {count} {answer}.");
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            min = 1;
            max = 2000;
            number = 1000;
            count = 0;
            labelNumber.Text = Convert.ToString((int)number);
        }
    }
}