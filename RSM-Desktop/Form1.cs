using System;
using System.Drawing;
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
            "Полувагоны (ПВ)",
            "Цистерны (Ц)",
            "Крытые вагоны (КР)",
            "Платформы (ПЛ)"
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
            this.MinimumSize = new Size(820, 540);
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

        private void leaderVag_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                CheckBox[] checkBoxes = { leaderVag1, leaderVag2, leaderVag3, leaderVag4 };
                int i = 0;
                foreach (CheckBox cb in checkBoxes)
                {
                    if (cb != sender) cb.Checked = false;
                }
            }
        }

        private void leaderPob_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                CheckBox[] checkBoxes = { leaderPob1, leaderPob2, leaderPob3, leaderPob4 };
                int i = 0;
                foreach (CheckBox cb in checkBoxes)
                {
                    if (cb != sender) cb.Checked = false;
                    i++;
                }
                i = i;
            }
        }

        private void calculate1_Click(object sender, EventArgs e)
        {
            CalculateClick(dataGridView1, command1, leaderVag1, leaderPob1, compCost1);
        }

        private void calculate2_Click(object sender, EventArgs e)
        {
            CalculateClick(dataGridView2, command2, leaderVag2, leaderPob2, compCost2);
        }

        private void calculate3_Click(object sender, EventArgs e)
        {
            CalculateClick(dataGridView3, command3, leaderVag3, leaderPob3, compCost3);
        }

        private void calculate4_Click(object sender, EventArgs e)
        {
            CalculateClick(dataGridView4, command4, leaderVag4, leaderPob4, compCost4);
        }

        private void CalculateCarrCost1(object sender, EventArgs e)
        {
            CalculateCarrCost(PvRTB1, CisRTB1, KrRTB1, PlRTB1, CostRTB1);
        }

        private void CalculateCarrCost2(object sender, EventArgs e)
        {
            CalculateCarrCost(PvRTB2, CisRTB2, KrRTB2, PlRTB2, CostRTB2);
        }

        private void CalculateCarrCost3(object sender, EventArgs e)
        {
            CalculateCarrCost(PvRTB3, CisRTB3, KrRTB3, PlRTB3, CostRTB3);
        }

        private void CalculateCarrCost4(object sender, EventArgs e)
        {
            CalculateCarrCost(PvRTB4, CisRTB4, KrRTB4, PlRTB4, CostRTB4);
        }

        private void FallValBT_Click(object sender, EventArgs e)
        {
            for (int i = tabControl1.SelectedIndex; i < 4; i++) tabControl1.SelectTab(i);
            for (int i = 3; i >= 0; i--) tabControl1.SelectTab(i);

            PvC1RTB.Text = PvRTB1.Text;
            PvC2RTB.Text = PvRTB2.Text;
            PvC3RTB.Text = PvRTB3.Text;
            PvC4RTB.Text = PvRTB4.Text;
            CisC1RTB.Text = CisRTB1.Text;
            CisC2RTB.Text = CisRTB2.Text;
            CisC3RTB.Text = CisRTB3.Text;
            CisC4RTB.Text = CisRTB4.Text;
            KrC1RTB.Text = KrRTB1.Text;
            KrC2RTB.Text = KrRTB2.Text;
            KrC3RTB.Text = KrRTB3.Text;
            KrC4RTB.Text = KrRTB4.Text;
            PlC1RTB.Text = PlRTB1.Text;
            PlC2RTB.Text = PlRTB2.Text;
            PlC3RTB.Text = PlRTB3.Text;
            PlC4RTB.Text = PlRTB4.Text;

            calculate1_Click(sender, e);
            calculate2_Click(sender, e);
            calculate3_Click(sender, e);
            calculate4_Click(sender, e);
        }


        private void tableSett(DataGridView dataGridView, Command command)
        {
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ColumnCount = 2;
            dataGridView.RowCount = _resList.Length;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;

            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[0].Width = Convert.ToInt32((dataGridView.Width - 20) * 0.7);
            dataGridView.Columns[1].Width = Convert.ToInt32((dataGridView.Width - 20) * 0.3);

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView[0, i].Value = _resList[i];
                dataGridView[0, i].ReadOnly = true;

                dataGridView[1, i].Value = command.getResByName(_resList[i]).get_value();
                if (command.getResByName(_resList[i]).getIsCarriage())
                {
                    dataGridView[1, i].Style.BackColor = Color.LightGray;
                    if (command.get_name() == "Первая")
                        if (_resList[i] == "Полувагоны (ПВ)")
                        {
                            PvRTB1.DataBindings.Clear();
                            PvRTB1.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }
                        else if (_resList[i] == "Цистерны (Ц)")
                        {
                            CisRTB1.DataBindings.Clear();
                            CisRTB1.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }
                        else if (_resList[i] == "Платформы (ПЛ)")
                        {
                            PlRTB1.DataBindings.Clear();
                            PlRTB1.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }
                        else if (_resList[i] == "Крытые вагоны (КР)")
                        {
                            KrRTB1.DataBindings.Clear();
                            KrRTB1.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }

                    if (command.get_name() == "Вторая")
                        if (_resList[i] == "Полувагоны (ПВ)")
                        {
                            PvRTB2.DataBindings.Clear();
                            PvRTB2.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }
                        else if (_resList[i] == "Цистерны (Ц)")
                        {
                            CisRTB2.DataBindings.Clear();
                            CisRTB2.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }
                        else if (_resList[i] == "Платформы (ПЛ)")
                        {
                            PlRTB2.DataBindings.Clear();
                            PlRTB2.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }
                        else if (_resList[i] == "Крытые вагоны (КР)")
                        {
                            KrRTB2.DataBindings.Clear();
                            KrRTB2.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }

                    if (command.get_name() == "Третья")
                        if (_resList[i] == "Полувагоны (ПВ)")
                        {
                            PvRTB3.DataBindings.Clear();
                            PvRTB3.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }
                        else if (_resList[i] == "Цистерны (Ц)")
                        {
                            CisRTB3.DataBindings.Clear();
                            CisRTB3.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }
                        else if (_resList[i] == "Платформы (ПЛ)")
                        {
                            PlRTB3.DataBindings.Clear();
                            PlRTB3.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }
                        else if (_resList[i] == "Крытые вагоны (КР)")
                        {
                            KrRTB3.DataBindings.Clear();
                            KrRTB3.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }

                    if (command.get_name() == "Четвёртая")
                        if (_resList[i] == "Полувагоны (ПВ)")
                        {
                            PvRTB4.DataBindings.Clear();
                            PvRTB4.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }
                        else if (_resList[i] == "Цистерны (Ц)")
                        {
                            CisRTB4.DataBindings.Clear();
                            CisRTB4.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }
                        else if (_resList[i] == "Платформы (ПЛ)")
                        {
                            PlRTB4.DataBindings.Clear();
                            PlRTB4.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }
                        else if (_resList[i] == "Крытые вагоны (КР)")
                        {
                            KrRTB4.DataBindings.Clear();
                            KrRTB4.DataBindings.Add(new Binding("Text", dataGridView[1, i], "Value"));
                            dataGridView[1, i].ReadOnly = true;
                        }
                }
            }
        }

        private void CalculateClick(DataGridView dataGridView, Command command, CheckBox leaderVag, CheckBox leaderPob, Label compCost)
        {
            toValue(dataGridView, command);
            command.set_is_maxCarriage(leaderVag.Checked);
            command.set_is_maxPoints(leaderPob.Checked);
            compCost.Text = CostCalculator.Calculate(command).ToString();
        }

        private void CalculateCarrCost(RichTextBox PvRTB, RichTextBox CisRTB, RichTextBox KrRTB, RichTextBox PlRTB, RichTextBox CostRTB)
        {
            try
            {
                int pv = Convert.ToInt32(PvRTB.Text),
                    cis = Convert.ToInt32(CisRTB.Text),
                    kr = Convert.ToInt32(KrRTB.Text),
                    pl = Convert.ToInt32(PlRTB.Text);
                if ((pv % 10 == 0 && pv >= 0) &&
                        (cis % 10 == 0 && cis >= 0) &&
                        (kr % 10 == 0 && kr >= 0) &&
                        (pl % 10 == 0 && pl >= 0))
                {
                    CostRTB.Text = (pv * 400_000 + cis * 600_000 + kr * 300_000 + pl * 500_000).ToString();
                }
                else
                {
                    throw new ArithmeticException("Введённое число не является допустимым значением для типа: вагоны.");
                }
            }
            catch (Exception err)
            {
                CostRTB.Text = "Некорректный ввод";
            }
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
    }
}
