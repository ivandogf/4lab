using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4lab
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime birthday = dateTimePicker1.Value.Date;
            DateTime today = DateTime.Today;

            if (birthday > today)
            {
                labelAge.Text = "Дата рождения не может быть в будущем";
                return;
            }

            int age = today.Year - birthday.Year;

            if (birthday > today.AddYears(-age))
            {
                age--;
            }

            labelAge.Text = $"Возраст: {age}";
        }
    }
}
