using System;
using System.Drawing;
using System.Windows.Forms;

namespace calculator_form
{

    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e) { }

        Create create = new Create();
        Button but_calculate_ans, but_clear_boxes;
        Label first_title, second_title, select_title, result_title;
        TextBox box_first_num, box_second_num, box_ans;
        ComboBox comboBox1;
        public Form1()
        {
            
            InitializeComponent();
            BackColor = Color.DarkGray;

            first_title = create.CreareMyLable(this, "Введите первое число", 50, 100, 150, 20);
            second_title = create.CreareMyLable(this, "Введите второе число", 250, 100, 150, 20);
            select_title = create.CreareMyLable(this, "Выберите действие", 70, 180, 150, 20);
            result_title = create.CreareMyLable(this, "Рузультат", 70, 350, 150, 20);

            but_calculate_ans = create.CreateMyBuutton(this, "Посчитать", 70, 250, 100, 50, Color.Black, Color.Brown);
            but_clear_boxes = create.CreateMyBuutton(this, "Очистить", 250, 250, 100, 50, Color.Black, Color.GreenYellow);

            box_first_num = create.CreareMyTextBox(this, 50, 120, 150, 20);
            box_second_num = create.CreareMyTextBox(this, 250, 120, 150, 20);
            box_ans = create.CreareMyTextBox(this, 70, 370, 300, 40);
            comboBox1 = create.CreareMyComboBox(this, 70, 200, 300, 40, "+", "-", "/", "*");

            but_calculate_ans.Click += Counter_Click;
            but_clear_boxes.Click += Clear_Click;
            
        }

        private void Counter_Click(object sender, EventArgs e)
        {
            double a, b;

            if (box_first_num.Text == String.Empty || box_second_num.Text == String.Empty)
            {
                DialogResult result = MessageBox.Show("Введены не все данные!\n Попробовать снова?", "Ты тупой, введи что - нибудь!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    this.Close();
            }
            
            else if (box_first_num.Text.IndexOf(".") != -1 || box_second_num.Text.IndexOf(".") != -1)
            {
                box_first_num.Text = box_first_num.Text.Replace(".", ",");
                box_second_num.Text = box_second_num.Text.Replace(".", ",");
            }

            else if (!double.TryParse(box_first_num.Text, out a) || !double.TryParse(box_second_num.Text, out b))
            {
                DialogResult result = MessageBox.Show("Введены не корректные данные!\n Попробовать снова?", "Ты дебик, какие нахрен символы?!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    this.Close();
            }            
            
            else
            {
                switch (comboBox1.Text)
                {
                    case "+":
                        box_ans.Text = Convert.ToString(Math.Round(a + b, 8));
                        break;
                    case "-":
                        box_ans.Text = Convert.ToString(Math.Round(a - b, 8));
                        break;
                    case "/":
                        if (b == 0)
                        {
                            DialogResult result = MessageBox.Show("На ноль делить нельзя!\n Попробовать снова?", "Ты конченный, как ты делишь на ноль?!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.No)
                                this.Close();
                        }
                           
                        box_ans.Text = Convert.ToString(Math.Round(a / b, 8));
                        break;
                    case "*":
                        box_ans.Text = Convert.ToString(Math.Round(a * b, 8));
                        break;
                }
            }
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            box_first_num.Text = "";
            box_second_num.Text = "";
            box_ans.Text = "";  
            comboBox1.Text = "";
        }

        
    }
}
