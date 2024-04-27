using System.Windows.Forms;

namespace RSM_Desktop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cubesGB = new System.Windows.Forms.GroupBox();
            this.contractButton = new System.Windows.Forms.Button();
            this.stateCB = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BlueTB = new System.Windows.Forms.TextBox();
            this.redTB = new System.Windows.Forms.TextBox();
            this.yellowTB = new System.Windows.Forms.TextBox();
            this.contractGB = new System.Windows.Forms.GroupBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.carriagesLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cargoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.leaderPob1 = new System.Windows.Forms.CheckBox();
            this.leaderVag1 = new System.Windows.Forms.CheckBox();
            this.compCost1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calculate1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.leaderPob2 = new System.Windows.Forms.CheckBox();
            this.leaderVag2 = new System.Windows.Forms.CheckBox();
            this.compCost2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.calculate2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.leaderPob3 = new System.Windows.Forms.CheckBox();
            this.leaderVag3 = new System.Windows.Forms.CheckBox();
            this.compCost3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.calculate3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.leaderPob4 = new System.Windows.Forms.CheckBox();
            this.leaderVag4 = new System.Windows.Forms.CheckBox();
            this.compCost4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.calculate4 = new System.Windows.Forms.Button();
            this.VagL1 = new System.Windows.Forms.Label();
            this.PvL1 = new System.Windows.Forms.Label();
            this.CisL1 = new System.Windows.Forms.Label();
            this.KrL1 = new System.Windows.Forms.Label();
            this.PlL1 = new System.Windows.Forms.Label();
            this.CostL1 = new System.Windows.Forms.Label();
            this.PvRTB1 = new System.Windows.Forms.RichTextBox();
            this.CisRTB1 = new System.Windows.Forms.RichTextBox();
            this.KrRTB1 = new System.Windows.Forms.RichTextBox();
            this.PlRTB1 = new System.Windows.Forms.RichTextBox();
            this.CostRTB1 = new System.Windows.Forms.RichTextBox();
            this.cubesGB.SuspendLayout();
            this.contractGB.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // cubesGB
            // 
            this.cubesGB.Controls.Add(this.contractButton);
            this.cubesGB.Controls.Add(this.stateCB);
            this.cubesGB.Controls.Add(this.label3);
            this.cubesGB.Controls.Add(this.label2);
            this.cubesGB.Controls.Add(this.label1);
            this.cubesGB.Controls.Add(this.BlueTB);
            this.cubesGB.Controls.Add(this.redTB);
            this.cubesGB.Controls.Add(this.yellowTB);
            this.cubesGB.Location = new System.Drawing.Point(12, 12);
            this.cubesGB.Name = "cubesGB";
            this.cubesGB.Size = new System.Drawing.Size(330, 157);
            this.cubesGB.TabIndex = 0;
            this.cubesGB.TabStop = false;
            this.cubesGB.Text = "Кубики";
            // 
            // contractButton
            // 
            this.contractButton.Location = new System.Drawing.Point(224, 110);
            this.contractButton.Name = "contractButton";
            this.contractButton.Size = new System.Drawing.Size(100, 34);
            this.contractButton.TabIndex = 7;
            this.contractButton.Text = "Контракт";
            this.contractButton.UseVisualStyleBackColor = true;
            this.contractButton.Click += new System.EventHandler(this.contractButton_Click);
            // 
            // stateCB
            // 
            this.stateCB.AutoSize = true;
            this.stateCB.Location = new System.Drawing.Point(9, 118);
            this.stateCB.Name = "stateCB";
            this.stateCB.Size = new System.Drawing.Size(109, 17);
            this.stateCB.TabIndex = 6;
            this.stateCB.Text = "Начальный этап";
            this.stateCB.UseVisualStyleBackColor = true;
            this.stateCB.CheckedChanged += new System.EventHandler(this.stateCB_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 39);
            this.label3.MinimumSize = new System.Drawing.Size(100, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Красный";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 39);
            this.label2.MinimumSize = new System.Drawing.Size(100, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Синие";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.MinimumSize = new System.Drawing.Size(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Жёлтые";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BlueTB
            // 
            this.BlueTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BlueTB.Location = new System.Drawing.Point(115, 74);
            this.BlueTB.MaxLength = 2;
            this.BlueTB.Name = "BlueTB";
            this.BlueTB.Size = new System.Drawing.Size(100, 20);
            this.BlueTB.TabIndex = 2;
            // 
            // redTB
            // 
            this.redTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.redTB.Location = new System.Drawing.Point(224, 74);
            this.redTB.MaxLength = 1;
            this.redTB.Name = "redTB";
            this.redTB.Size = new System.Drawing.Size(100, 20);
            this.redTB.TabIndex = 1;
            // 
            // yellowTB
            // 
            this.yellowTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yellowTB.Location = new System.Drawing.Point(6, 74);
            this.yellowTB.MaxLength = 2;
            this.yellowTB.Name = "yellowTB";
            this.yellowTB.Size = new System.Drawing.Size(100, 20);
            this.yellowTB.TabIndex = 0;
            // 
            // contractGB
            // 
            this.contractGB.AutoSize = true;
            this.contractGB.Controls.Add(this.toLabel);
            this.contractGB.Controls.Add(this.label7);
            this.contractGB.Controls.Add(this.costLabel);
            this.contractGB.Controls.Add(this.carriagesLabel);
            this.contractGB.Controls.Add(this.label6);
            this.contractGB.Controls.Add(this.label5);
            this.contractGB.Controls.Add(this.cargoLabel);
            this.contractGB.Controls.Add(this.label4);
            this.contractGB.Location = new System.Drawing.Point(12, 175);
            this.contractGB.Name = "contractGB";
            this.contractGB.Size = new System.Drawing.Size(330, 115);
            this.contractGB.TabIndex = 1;
            this.contractGB.TabStop = false;
            this.contractGB.Text = "Контракт";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(92, 86);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(37, 13);
            this.toLabel.TabIndex = 7;
            this.toLabel.Text = "_____";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Направление";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(57, 63);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(37, 13);
            this.costLabel.TabIndex = 5;
            this.costLabel.Text = "_____";
            // 
            // carriagesLabel
            // 
            this.carriagesLabel.AutoSize = true;
            this.carriagesLabel.Location = new System.Drawing.Point(57, 37);
            this.carriagesLabel.Name = "carriagesLabel";
            this.carriagesLabel.Size = new System.Drawing.Size(37, 13);
            this.carriagesLabel.TabIndex = 4;
            this.carriagesLabel.Text = "_____";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Тариф:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Вагоны:";
            // 
            // cargoLabel
            // 
            this.cargoLabel.AutoSize = true;
            this.cargoLabel.Location = new System.Drawing.Point(47, 20);
            this.cargoLabel.Name = "cargoLabel";
            this.cargoLabel.Size = new System.Drawing.Size(37, 13);
            this.cargoLabel.TabIndex = 1;
            this.cargoLabel.Text = "_____";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Груз:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(348, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 358);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.leaderPob1);
            this.tabPage1.Controls.Add(this.leaderVag1);
            this.tabPage1.Controls.Add(this.compCost1);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.calculate1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(440, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Команда 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.Controls.Add(this.CostRTB1, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.PlRTB1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.KrRTB1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.CisRTB1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CostL1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.PlL1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.KrL1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CisL1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.VagL1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PvL1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PvRTB1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 256);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 72);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // leaderPob1
            // 
            this.leaderPob1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.leaderPob1.AutoSize = true;
            this.leaderPob1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.leaderPob1.Location = new System.Drawing.Point(275, 118);
            this.leaderPob1.Name = "leaderPob1";
            this.leaderPob1.Size = new System.Drawing.Size(162, 17);
            this.leaderPob1.TabIndex = 10;
            this.leaderPob1.Text = "Лидер по победным очкам";
            this.leaderPob1.UseVisualStyleBackColor = true;
            // 
            // leaderVag1
            // 
            this.leaderVag1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.leaderVag1.AutoSize = true;
            this.leaderVag1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.leaderVag1.Location = new System.Drawing.Point(275, 88);
            this.leaderVag1.Name = "leaderVag1";
            this.leaderVag1.Size = new System.Drawing.Size(119, 17);
            this.leaderVag1.TabIndex = 9;
            this.leaderVag1.Text = "Лидер по вагонам";
            this.leaderVag1.UseVisualStyleBackColor = true;
            // 
            // compCost1
            // 
            this.compCost1.AutoSize = true;
            this.compCost1.Location = new System.Drawing.Point(270, 52);
            this.compCost1.MinimumSize = new System.Drawing.Size(147, 0);
            this.compCost1.Name = "compCost1";
            this.compCost1.Size = new System.Drawing.Size(147, 13);
            this.compCost1.TabIndex = 8;
            this.compCost1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(284, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Стоимость компании:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(273, 250);
            this.dataGridView1.TabIndex = 2;
            // 
            // calculate1
            // 
            this.calculate1.Location = new System.Drawing.Point(336, 217);
            this.calculate1.Name = "calculate1";
            this.calculate1.Size = new System.Drawing.Size(75, 23);
            this.calculate1.TabIndex = 1;
            this.calculate1.Text = "Стоимость";
            this.calculate1.UseVisualStyleBackColor = true;
            this.calculate1.Click += new System.EventHandler(this.calculate1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.leaderPob2);
            this.tabPage2.Controls.Add(this.leaderVag2);
            this.tabPage2.Controls.Add(this.compCost2);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.calculate2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(440, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Команда 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // leaderPob2
            // 
            this.leaderPob2.AutoSize = true;
            this.leaderPob2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.leaderPob2.Location = new System.Drawing.Point(275, 118);
            this.leaderPob2.Name = "leaderPob2";
            this.leaderPob2.Size = new System.Drawing.Size(162, 17);
            this.leaderPob2.TabIndex = 12;
            this.leaderPob2.Text = "Лидер по победным очкам";
            this.leaderPob2.UseVisualStyleBackColor = true;
            // 
            // leaderVag2
            // 
            this.leaderVag2.AutoSize = true;
            this.leaderVag2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.leaderVag2.Location = new System.Drawing.Point(275, 88);
            this.leaderVag2.Name = "leaderVag2";
            this.leaderVag2.Size = new System.Drawing.Size(119, 17);
            this.leaderVag2.TabIndex = 11;
            this.leaderVag2.Text = "Лидер по вагонам";
            this.leaderVag2.UseVisualStyleBackColor = true;
            // 
            // compCost2
            // 
            this.compCost2.AutoSize = true;
            this.compCost2.Location = new System.Drawing.Point(270, 52);
            this.compCost2.MinimumSize = new System.Drawing.Size(147, 0);
            this.compCost2.Name = "compCost2";
            this.compCost2.Size = new System.Drawing.Size(147, 13);
            this.compCost2.TabIndex = 8;
            this.compCost2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(284, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Стоимость компании:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(273, 250);
            this.dataGridView2.TabIndex = 4;
            // 
            // calculate2
            // 
            this.calculate2.Location = new System.Drawing.Point(336, 217);
            this.calculate2.Name = "calculate2";
            this.calculate2.Size = new System.Drawing.Size(75, 23);
            this.calculate2.TabIndex = 3;
            this.calculate2.Text = "Стоимость";
            this.calculate2.UseVisualStyleBackColor = true;
            this.calculate2.Click += new System.EventHandler(this.calculate2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.leaderPob3);
            this.tabPage3.Controls.Add(this.leaderVag3);
            this.tabPage3.Controls.Add(this.compCost3);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.calculate3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(440, 332);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Команда 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // leaderPob3
            // 
            this.leaderPob3.AutoSize = true;
            this.leaderPob3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.leaderPob3.Location = new System.Drawing.Point(275, 118);
            this.leaderPob3.Name = "leaderPob3";
            this.leaderPob3.Size = new System.Drawing.Size(162, 17);
            this.leaderPob3.TabIndex = 12;
            this.leaderPob3.Text = "Лидер по победным очкам";
            this.leaderPob3.UseVisualStyleBackColor = true;
            // 
            // leaderVag3
            // 
            this.leaderVag3.AutoSize = true;
            this.leaderVag3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.leaderVag3.Location = new System.Drawing.Point(275, 88);
            this.leaderVag3.Name = "leaderVag3";
            this.leaderVag3.Size = new System.Drawing.Size(119, 17);
            this.leaderVag3.TabIndex = 11;
            this.leaderVag3.Text = "Лидер по вагонам";
            this.leaderVag3.UseVisualStyleBackColor = true;
            // 
            // compCost3
            // 
            this.compCost3.AutoSize = true;
            this.compCost3.Location = new System.Drawing.Point(270, 52);
            this.compCost3.MinimumSize = new System.Drawing.Size(147, 0);
            this.compCost3.Name = "compCost3";
            this.compCost3.Size = new System.Drawing.Size(147, 13);
            this.compCost3.TabIndex = 8;
            this.compCost3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Стоимость компании:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(273, 250);
            this.dataGridView3.TabIndex = 4;
            // 
            // calculate3
            // 
            this.calculate3.Location = new System.Drawing.Point(336, 217);
            this.calculate3.Name = "calculate3";
            this.calculate3.Size = new System.Drawing.Size(75, 23);
            this.calculate3.TabIndex = 3;
            this.calculate3.Text = "Стоимость";
            this.calculate3.UseVisualStyleBackColor = true;
            this.calculate3.Click += new System.EventHandler(this.calculate3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.leaderPob4);
            this.tabPage4.Controls.Add(this.leaderVag4);
            this.tabPage4.Controls.Add(this.compCost4);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.calculate4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(440, 332);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Команда 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // leaderPob4
            // 
            this.leaderPob4.AutoSize = true;
            this.leaderPob4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.leaderPob4.Location = new System.Drawing.Point(275, 118);
            this.leaderPob4.Name = "leaderPob4";
            this.leaderPob4.Size = new System.Drawing.Size(162, 17);
            this.leaderPob4.TabIndex = 12;
            this.leaderPob4.Text = "Лидер по победным очкам";
            this.leaderPob4.UseVisualStyleBackColor = true;
            // 
            // leaderVag4
            // 
            this.leaderVag4.AutoSize = true;
            this.leaderVag4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.leaderVag4.Location = new System.Drawing.Point(275, 88);
            this.leaderVag4.Name = "leaderVag4";
            this.leaderVag4.Size = new System.Drawing.Size(119, 17);
            this.leaderVag4.TabIndex = 11;
            this.leaderVag4.Text = "Лидер по вагонам";
            this.leaderVag4.UseVisualStyleBackColor = true;
            // 
            // compCost4
            // 
            this.compCost4.AutoSize = true;
            this.compCost4.Location = new System.Drawing.Point(270, 52);
            this.compCost4.MinimumSize = new System.Drawing.Size(147, 0);
            this.compCost4.Name = "compCost4";
            this.compCost4.Size = new System.Drawing.Size(147, 13);
            this.compCost4.TabIndex = 6;
            this.compCost4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Стоимость компании:";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.Size = new System.Drawing.Size(273, 250);
            this.dataGridView4.TabIndex = 4;
            // 
            // calculate4
            // 
            this.calculate4.Location = new System.Drawing.Point(336, 217);
            this.calculate4.Name = "calculate4";
            this.calculate4.Size = new System.Drawing.Size(75, 23);
            this.calculate4.TabIndex = 3;
            this.calculate4.Text = "Стоимость";
            this.calculate4.UseVisualStyleBackColor = true;
            this.calculate4.Click += new System.EventHandler(this.calculate4_Click);
            // 
            // VagL1
            // 
            this.VagL1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VagL1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.VagL1, 4);
            this.VagL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VagL1.Location = new System.Drawing.Point(3, 0);
            this.VagL1.Name = "VagL1";
            this.VagL1.Size = new System.Drawing.Size(318, 20);
            this.VagL1.TabIndex = 0;
            this.VagL1.Text = "Вагоны в компании";
            this.VagL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PvL1
            // 
            this.PvL1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PvL1.AutoSize = true;
            this.PvL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PvL1.Location = new System.Drawing.Point(3, 21);
            this.PvL1.Name = "PvL1";
            this.PvL1.Size = new System.Drawing.Size(75, 20);
            this.PvL1.TabIndex = 1;
            this.PvL1.Text = "ПВ";
            this.PvL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CisL1
            // 
            this.CisL1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CisL1.AutoSize = true;
            this.CisL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CisL1.Location = new System.Drawing.Point(84, 21);
            this.CisL1.Name = "CisL1";
            this.CisL1.Size = new System.Drawing.Size(75, 20);
            this.CisL1.TabIndex = 2;
            this.CisL1.Text = "ЦС";
            this.CisL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KrL1
            // 
            this.KrL1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.KrL1.AutoSize = true;
            this.KrL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.KrL1.Location = new System.Drawing.Point(165, 21);
            this.KrL1.Name = "KrL1";
            this.KrL1.Size = new System.Drawing.Size(75, 20);
            this.KrL1.TabIndex = 3;
            this.KrL1.Text = "КР";
            this.KrL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlL1
            // 
            this.PlL1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PlL1.AutoSize = true;
            this.PlL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PlL1.Location = new System.Drawing.Point(246, 21);
            this.PlL1.Name = "PlL1";
            this.PlL1.Size = new System.Drawing.Size(75, 20);
            this.PlL1.TabIndex = 4;
            this.PlL1.Text = "ПЛ";
            this.PlL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CostL1
            // 
            this.CostL1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CostL1.AutoSize = true;
            this.CostL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CostL1.Location = new System.Drawing.Point(327, 0);
            this.CostL1.Name = "CostL1";
            this.tableLayoutPanel1.SetRowSpan(this.CostL1, 2);
            this.CostL1.Size = new System.Drawing.Size(100, 42);
            this.CostL1.TabIndex = 5;
            this.CostL1.Text = "Текущее содержание";
            this.CostL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PvRTB1
            // 
            this.PvRTB1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PvRTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PvRTB1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PvRTB1.Location = new System.Drawing.Point(3, 45);
            this.PvRTB1.Multiline = false;
            this.PvRTB1.Name = "PvRTB1";
            this.PvRTB1.Size = new System.Drawing.Size(75, 24);
            this.PvRTB1.TabIndex = 6;
            this.PvRTB1.Text = "";
            // 
            // CisRTB1
            // 
            this.CisRTB1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CisRTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CisRTB1.Location = new System.Drawing.Point(84, 45);
            this.CisRTB1.Multiline = false;
            this.CisRTB1.Name = "CisRTB1";
            this.CisRTB1.Size = new System.Drawing.Size(75, 24);
            this.CisRTB1.TabIndex = 7;
            this.CisRTB1.Text = "";
            // 
            // KrRTB1
            // 
            this.KrRTB1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.KrRTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.KrRTB1.Location = new System.Drawing.Point(165, 45);
            this.KrRTB1.Multiline = false;
            this.KrRTB1.Name = "KrRTB1";
            this.KrRTB1.Size = new System.Drawing.Size(75, 24);
            this.KrRTB1.TabIndex = 8;
            this.KrRTB1.Text = "";
            // 
            // PlRTB1
            // 
            this.PlRTB1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PlRTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PlRTB1.Location = new System.Drawing.Point(246, 45);
            this.PlRTB1.Multiline = false;
            this.PlRTB1.Name = "PlRTB1";
            this.PlRTB1.Size = new System.Drawing.Size(75, 24);
            this.PlRTB1.TabIndex = 9;
            this.PlRTB1.Text = "";
            // 
            // CostRTB1
            // 
            this.CostRTB1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CostRTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CostRTB1.Location = new System.Drawing.Point(327, 45);
            this.CostRTB1.Multiline = false;
            this.CostRTB1.Name = "CostRTB1";
            this.CostRTB1.ReadOnly = true;
            this.CostRTB1.Size = new System.Drawing.Size(100, 24);
            this.CostRTB1.TabIndex = 10;
            this.CostRTB1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.contractGB);
            this.Controls.Add(this.cubesGB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cubesGB.ResumeLayout(false);
            this.cubesGB.PerformLayout();
            this.contractGB.ResumeLayout(false);
            this.contractGB.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cubesGB;
        private System.Windows.Forms.TextBox yellowTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BlueTB;
        private System.Windows.Forms.TextBox redTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox contractGB;
        private System.Windows.Forms.Label cargoLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label carriagesLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.CheckBox stateCB;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button contractButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button calculate1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button calculate2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button calculate3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button calculate4;
        private System.Windows.Forms.Label compCost4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label compCost1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label compCost2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label compCost3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox leaderPob1;
        private System.Windows.Forms.CheckBox leaderVag1;
        private System.Windows.Forms.CheckBox leaderPob2;
        private System.Windows.Forms.CheckBox leaderVag2;
        private System.Windows.Forms.CheckBox leaderPob3;
        private System.Windows.Forms.CheckBox leaderVag3;
        private System.Windows.Forms.CheckBox leaderPob4;
        private System.Windows.Forms.CheckBox leaderVag4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label VagL1;
        private System.Windows.Forms.Label PvL1;
        private System.Windows.Forms.Label PlL1;
        private System.Windows.Forms.Label KrL1;
        private System.Windows.Forms.Label CisL1;
        private System.Windows.Forms.Label CostL1;
        private System.Windows.Forms.RichTextBox PvRTB1;
        private System.Windows.Forms.RichTextBox CostRTB1;
        private System.Windows.Forms.RichTextBox PlRTB1;
        private System.Windows.Forms.RichTextBox KrRTB1;
        private System.Windows.Forms.RichTextBox CisRTB1;
    }
}

