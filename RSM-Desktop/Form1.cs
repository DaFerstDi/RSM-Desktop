using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSM_Desktop.Models;
using RSM_Desktop.Repository;

namespace RSM_Desktop
{
    public partial class Form1 : Form
    {

        Contract contract;
        Label[] labelList;
        private readonly String[] _resList = {"Наличные",
            "Победные очки",
            "Полувагоны (ПВ)",
            "Цистерны (Ц)",
            "Платформы (ПЛ)",
            "Крытые вагоны (КР)",
            "Порты Октябрьской ж.д.",
            "Порты Северо-Кавказской ж.д.",
            "Порты Дальневосточной ж.д.",
            "Каменный уголь",
            "Нефть и нефтепродукты",
            "Кокс",
            "Чёрные металлы",
            "Руда железная",
            "Строительные грузы",
            "Цемент",
            "Лес",
            "Химические грузы",
            "Зерновые",
            "Грузы в контейнерах",
        };

        Command command1;
        Command command2;
        Command command3;
        Command command4;

        public Form1()
        {
            InitializeComponent();
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Form1";
            this.MinimumSize = new Size(820, 400);
            contract = new Contract();
            labelList = new Label[5];
            command1 = new Command("Первая");
            command2 = new Command("Вторая");
            command3 = new Command("Третья");
            command4 = new Command("Четвёртая");
            tableSett(dataGridView1, command1);
            tableSett(dataGridView2, command2);
            tableSett(dataGridView3, command3);
            tableSett(dataGridView4, command4);
        }

        private void tableSett(DataGridView dataGridView, Command command)
        {
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ColumnCount = 2;
            dataGridView.RowCount = _resList.Length;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView[0, i].Value = _resList[i];
                dataGridView[0, i].ReadOnly = true;
                dataGridView[1, i].Value = command.getResByName(_resList[i]).get_value();
            }

            dataGridView.Columns[0].Width = Convert.ToInt32((dataGridView.Width - 20) * 0.75);
            dataGridView.Columns[1].Width = Convert.ToInt32((dataGridView.Width - 20) * 0.25);
        }

        private void toValue(DataGridView dataGridView, Command command)
        {
            bool error = false;
            for (int i = 0; i < dataGridView.RowCount; i++)
            {

                try
                {
                    command.getResByName(_resList[i]).set_value(Convert.ToInt32(dataGridView[1, i].Value));
                }
                catch
                {
                    dataGridView[1, i].Value = "Неверный ввод.";
                    MessageBox.Show("Проверьте правильность введённых данных.", "Неверный ввод", MessageBoxButtons.OK);
                }
            }
        }


        private void contractButton_Click(object sender, EventArgs e)
        {

            try
            {
                bool isMain = stateCB.Checked;
                int yellow = int.Parse(yellowTB.Text);
                int blue = int.Parse(BlueTB.Text);
                int red = int.Parse(redTB.Text);

                if ((yellow > 1 && yellow < 13) && (blue > 1 && blue < 13) && (red > 0 && red < 7))
                {
                    contract = ContractRepo.getContract(yellow, blue, red, isMain);

                    cargoLabel.Text = contract.get_cargo();
                    carriagesLabel.Text = contract.get_carriage().ToString();
                    costLabel.Text = contract.get_cost().ToString();
                    toLabel.Text = contract.get_destination();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введённых данных.", "Неверный ввод", MessageBoxButtons.OK);
            }
        }

        private void stateCB_CheckedChanged(object sender, EventArgs e)
        {
            if (stateCB.Checked)
            {
                stateCB.Text = "Основной этап";
            }
            else
            {
                stateCB.Text = "Начальный этап";
            }
        }



        private void calculate1_Click(object sender, EventArgs e)
        {
            toValue(dataGridView1, command1);
            command1.set_is_maxCarriage(leaderVag1.Checked);
            command1.set_is_maxPoints(leaderPob1.Checked);
            compCost1.Text = CostCalculator.Calculate(command1).ToString();
        }

        private void calculate2_Click(object sender, EventArgs e)
        {
            toValue(dataGridView2, command2);
            command1.set_is_maxCarriage(leaderVag2.Checked);
            command1.set_is_maxPoints(leaderPob2.Checked);
            compCost2.Text = CostCalculator.Calculate(command2).ToString();

        }

        private void calculate3_Click(object sender, EventArgs e)
        {
            toValue(dataGridView3, command3);
            command1.set_is_maxCarriage(leaderVag3.Checked);
            command1.set_is_maxPoints(leaderPob3.Checked);
            compCost3.Text = CostCalculator.Calculate(command3).ToString();

        }

        private void calculate4_Click(object sender, EventArgs e)
        {
            toValue(dataGridView4, command4);
            command1.set_is_maxCarriage(leaderVag4.Checked);
            command1.set_is_maxPoints(leaderPob4.Checked);
            compCost4.Text = CostCalculator.Calculate(command4).ToString();

        }

    }
}
