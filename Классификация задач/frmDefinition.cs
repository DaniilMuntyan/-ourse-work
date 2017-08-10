using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Классификация_задач
{
    public partial class frmDefinition : Form
    {
        frmMenu menu;
        public frmDefinition(frmMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void frmDefinition_Load(object sender, EventArgs e)
        {

        }

        public void frmDefinition_FormClosing(object sender, FormClosingEventArgs e)
        {
                menu.Show();
                this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "";
            s = "f[1] = 1; //Початкові значення\nf[2] = 1; //Початкові значення\n" +
"for(int i = 3; i <= n; i++)\nf[i] = f[i-1] + f[i-2]; // Перерахунок стану i. У даному випадку n задається, f - масив чисел Фібоначі";
            MessageBox.Show(s," Код програми обчислення чисел Фібоначчі");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s =
"f[1] = 1 // Початкові значення\nfor(i = 1; i < n;i++)\n{\n    f[i+1] += f[i]; // Оновлення стану i+1\n    f[i+2] += f[i] // оновлення стану i+2\n}";
             MessageBox.Show(s, "Код програми обчислення чисел Фібоначчі");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s =
"void  get_fib(i)\n{\n    if(i <= 2) // Початкові значення\n        return 1;\n    if(f[i]!=-1)" +
" // Лінивість\n        return f[i];\n    f[i] = get_fib(i-1) + get_fib(i-2) // Перерахунок\n    return f[i];";
            MessageBox.Show(s, "Код програми обчислення чисел Фібоначчі");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            menu.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string s =
"f[1] = 1 // Початкові значення\nfor(i = 1; i < n;i++)\n{\n    f[i+1] += f[i]; // Оновлення стану i+1\n    f[i+2] += f[i] // оновлення стану i+2\n}";
            MessageBox.Show(s, "Код програми обчислення чисел Фібоначчі");
        }
    }
}
