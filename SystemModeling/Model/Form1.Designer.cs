namespace Model
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Количество выполненных заявок");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Суммарное время обслуживания");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Среднее время обработки заявки");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Коэффициент загрузки системы");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Число вытолкнутых заявок");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Количество запросов на выделение каналов");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Общая сумма величин запросов на выделение каналов");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Средняя величина запроса");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Среднее количество занятых каналов");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Количество заявок поставленных в очередь");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Количество всех заявок прошедших через очередь");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Количество заявок с нулевым ожиданием");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Суммарное время ожидания");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Среднее время ожидания");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Среднеквадратичное отклонение времени ожидания");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Средняя длина очереди");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Максимальная длина очереди");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Количество заявок получивших отказ в постановке в очередь");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("Общее число выполненных запросов");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Суммарное время обслуживания");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("Среднее время занятости");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("Процент испозования системы");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("Количество заявок поставленных в очередь");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("Количество заявок прошедших через очередь");
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("Количество заявок с нулевым ожиданием");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("Суммарное время ожидания");
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem("Среднее время ожидания");
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem("Количество отказных заявок");
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.CBQueueName = new System.Windows.Forms.ComboBox();
            this.LVDrive = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTAddSyst = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.CBDistSyst = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TBChannelKol = new System.Windows.Forms.TextBox();
            this.TBNameSyst = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LVQueue = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTAddQeue = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TBSizeQ = new System.Windows.Forms.TextBox();
            this.TBNameQ = new System.Windows.Forms.TextBox();
            this.CBTypeQ = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CHBClosedSystem = new System.Windows.Forms.CheckBox();
            this.informlab = new System.Windows.Forms.Label();
            this.BTCreateG = new System.Windows.Forms.Button();
            this.TBDistG = new System.Windows.Forms.ComboBox();
            this.TBMaxTime = new System.Windows.Forms.TextBox();
            this.TBMaxReq = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LVDist = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colemn1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label21 = new System.Windows.Forms.Label();
            this.BTAddDixst = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TBMExp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TBM = new System.Windows.Forms.TextBox();
            this.TBD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBLam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBModEr = new System.Windows.Forms.TextBox();
            this.TBKol = new System.Windows.Forms.TextBox();
            this.TBB = new System.Windows.Forms.TextBox();
            this.TBMod = new System.Windows.Forms.TextBox();
            this.TBMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBMin = new System.Windows.Forms.TextBox();
            this.TBA = new System.Windows.Forms.TextBox();
            this.CBDist = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LVlLog = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LVStatD = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LVStatQ = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.LVStatC = new System.Windows.Forms.ListView();
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtStart = new System.Windows.Forms.Button();
            this.BTClean = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 469);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Параметры системы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.CBQueueName);
            this.groupBox3.Controls.Add(this.LVDrive);
            this.groupBox3.Controls.Add(this.BTAddSyst);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.CBDistSyst);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.TBChannelKol);
            this.groupBox3.Controls.Add(this.TBNameSyst);
            this.groupBox3.Location = new System.Drawing.Point(507, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 210);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Устройства";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(277, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 13);
            this.label22.TabIndex = 45;
            this.label22.Text = "ID очереди:";
            // 
            // CBQueueName
            // 
            this.CBQueueName.FormattingEnabled = true;
            this.CBQueueName.Location = new System.Drawing.Point(359, 62);
            this.CBQueueName.Name = "CBQueueName";
            this.CBQueueName.Size = new System.Drawing.Size(119, 21);
            this.CBQueueName.TabIndex = 44;
            // 
            // LVDrive
            // 
            this.LVDrive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.LVDrive.Location = new System.Drawing.Point(3, 18);
            this.LVDrive.Name = "LVDrive";
            this.LVDrive.Size = new System.Drawing.Size(268, 185);
            this.LVDrive.TabIndex = 43;
            this.LVDrive.UseCompatibleStateImageBehavior = false;
            this.LVDrive.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "№";
            this.columnHeader9.Width = 30;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Имя";
            this.columnHeader10.Width = 50;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Количество каналов";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 40;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Распределение";
            this.columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Очередь";
            this.columnHeader13.Width = 40;
            // 
            // BTAddSyst
            // 
            this.BTAddSyst.Location = new System.Drawing.Point(359, 179);
            this.BTAddSyst.Name = "BTAddSyst";
            this.BTAddSyst.Size = new System.Drawing.Size(120, 25);
            this.BTAddSyst.TabIndex = 39;
            this.BTAddSyst.Text = "Добавить";
            this.BTAddSyst.UseVisualStyleBackColor = true;
            this.BTAddSyst.Click += new System.EventHandler(this.BTAddSyst_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(289, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(202, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "ID распределения времени задержки:";
            // 
            // CBDistSyst
            // 
            this.CBDistSyst.FormattingEnabled = true;
            this.CBDistSyst.Location = new System.Drawing.Point(359, 35);
            this.CBDistSyst.Name = "CBDistSyst";
            this.CBDistSyst.Size = new System.Drawing.Size(120, 21);
            this.CBDistSyst.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(289, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Количество каналов:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(347, 94);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "Имя:";
            // 
            // TBChannelKol
            // 
            this.TBChannelKol.Location = new System.Drawing.Point(413, 115);
            this.TBChannelKol.Name = "TBChannelKol";
            this.TBChannelKol.Size = new System.Drawing.Size(65, 20);
            this.TBChannelKol.TabIndex = 40;
            // 
            // TBNameSyst
            // 
            this.TBNameSyst.Location = new System.Drawing.Point(382, 89);
            this.TBNameSyst.Name = "TBNameSyst";
            this.TBNameSyst.Size = new System.Drawing.Size(96, 20);
            this.TBNameSyst.TabIndex = 39;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LVQueue);
            this.groupBox4.Controls.Add(this.BTAddQeue);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.TBSizeQ);
            this.groupBox4.Controls.Add(this.TBNameQ);
            this.groupBox4.Controls.Add(this.CBTypeQ);
            this.groupBox4.Location = new System.Drawing.Point(507, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 214);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Очередь";
            // 
            // LVQueue
            // 
            this.LVQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.LVQueue.Location = new System.Drawing.Point(4, 18);
            this.LVQueue.Name = "LVQueue";
            this.LVQueue.Size = new System.Drawing.Size(287, 190);
            this.LVQueue.TabIndex = 39;
            this.LVQueue.UseCompatibleStateImageBehavior = false;
            this.LVQueue.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "№";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Имя";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Тип";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Размер";
            this.columnHeader8.Width = 65;
            // 
            // BTAddQeue
            // 
            this.BTAddQeue.Location = new System.Drawing.Point(359, 183);
            this.BTAddQeue.Name = "BTAddQeue";
            this.BTAddQeue.Size = new System.Drawing.Size(120, 25);
            this.BTAddQeue.TabIndex = 38;
            this.BTAddQeue.Text = "Добавить";
            this.BTAddQeue.UseVisualStyleBackColor = true;
            this.BTAddQeue.Click += new System.EventHandler(this.BTAddQeue_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Тип:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(300, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Размер:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(317, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Имя:";
            // 
            // TBSizeQ
            // 
            this.TBSizeQ.Location = new System.Drawing.Point(352, 80);
            this.TBSizeQ.Name = "TBSizeQ";
            this.TBSizeQ.Size = new System.Drawing.Size(127, 20);
            this.TBSizeQ.TabIndex = 34;
            // 
            // TBNameQ
            // 
            this.TBNameQ.Location = new System.Drawing.Point(352, 53);
            this.TBNameQ.Name = "TBNameQ";
            this.TBNameQ.Size = new System.Drawing.Size(127, 20);
            this.TBNameQ.TabIndex = 33;
            // 
            // CBTypeQ
            // 
            this.CBTypeQ.FormattingEnabled = true;
            this.CBTypeQ.Items.AddRange(new object[] {
            "FIFO",
            "LIFO",
            "PRIORITET"});
            this.CBTypeQ.Location = new System.Drawing.Point(352, 26);
            this.CBTypeQ.Name = "CBTypeQ";
            this.CBTypeQ.Size = new System.Drawing.Size(127, 21);
            this.CBTypeQ.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CHBClosedSystem);
            this.groupBox2.Controls.Add(this.informlab);
            this.groupBox2.Controls.Add(this.BTCreateG);
            this.groupBox2.Controls.Add(this.TBDistG);
            this.groupBox2.Controls.Add(this.TBMaxTime);
            this.groupBox2.Controls.Add(this.TBMaxReq);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(7, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Генератор заявок";
            // 
            // CHBClosedSystem
            // 
            this.CHBClosedSystem.AutoSize = true;
            this.CHBClosedSystem.Location = new System.Drawing.Point(220, 107);
            this.CHBClosedSystem.Name = "CHBClosedSystem";
            this.CHBClosedSystem.Size = new System.Drawing.Size(127, 17);
            this.CHBClosedSystem.TabIndex = 35;
            this.CHBClosedSystem.Text = "Замкнутая система";
            this.CHBClosedSystem.UseVisualStyleBackColor = true;
            // 
            // informlab
            // 
            this.informlab.AutoSize = true;
            this.informlab.Location = new System.Drawing.Point(6, 129);
            this.informlab.Name = "informlab";
            this.informlab.Size = new System.Drawing.Size(114, 13);
            this.informlab.TabIndex = 34;
            this.informlab.Text = "Генератор не создан";
            // 
            // BTCreateG
            // 
            this.BTCreateG.Location = new System.Drawing.Point(359, 128);
            this.BTCreateG.Name = "BTCreateG";
            this.BTCreateG.Size = new System.Drawing.Size(120, 25);
            this.BTCreateG.TabIndex = 33;
            this.BTCreateG.Text = "Создать";
            this.BTCreateG.UseVisualStyleBackColor = true;
            this.BTCreateG.Click += new System.EventHandler(this.BTCreateG_Click);
            // 
            // TBDistG
            // 
            this.TBDistG.FormattingEnabled = true;
            this.TBDistG.Location = new System.Drawing.Point(221, 80);
            this.TBDistG.Name = "TBDistG";
            this.TBDistG.Size = new System.Drawing.Size(203, 21);
            this.TBDistG.TabIndex = 5;
            // 
            // TBMaxTime
            // 
            this.TBMaxTime.Location = new System.Drawing.Point(221, 50);
            this.TBMaxTime.Name = "TBMaxTime";
            this.TBMaxTime.Size = new System.Drawing.Size(74, 20);
            this.TBMaxTime.TabIndex = 4;
            this.TBMaxTime.Text = "0";
            // 
            // TBMaxReq
            // 
            this.TBMaxReq.Location = new System.Drawing.Point(221, 22);
            this.TBMaxReq.Name = "TBMaxReq";
            this.TBMaxReq.Size = new System.Drawing.Size(74, 20);
            this.TBMaxReq.TabIndex = 3;
            this.TBMaxReq.Text = "10";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(58, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Максимальное время работы";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(216, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Распределение времени прихода заявок";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(190, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Максимальное колличество заявок";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LVDist);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.BTAddDixst);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TBMExp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TBM);
            this.groupBox1.Controls.Add(this.TBD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TBLam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TBModEr);
            this.groupBox1.Controls.Add(this.TBKol);
            this.groupBox1.Controls.Add(this.TBB);
            this.groupBox1.Controls.Add(this.TBMod);
            this.groupBox1.Controls.Add(this.TBMax);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBMin);
            this.groupBox1.Controls.Add(this.TBA);
            this.groupBox1.Controls.Add(this.CBDist);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Распределения";
            // 
            // LVDist
            // 
            this.LVDist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.colemn1,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.LVDist.Location = new System.Drawing.Point(3, 22);
            this.LVDist.Name = "LVDist";
            this.LVDist.Size = new System.Drawing.Size(257, 236);
            this.LVDist.TabIndex = 44;
            this.LVDist.UseCompatibleStateImageBehavior = false;
            this.LVDist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "№";
            this.columnHeader4.Width = 40;
            // 
            // colemn1
            // 
            this.colemn1.Text = "Распределение";
            this.colemn1.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "П1";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "П2";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "П3";
            this.columnHeader3.Width = 40;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(273, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 13);
            this.label21.TabIndex = 43;
            this.label21.Text = "Закон распределения:";
            // 
            // BTAddDixst
            // 
            this.BTAddDixst.Location = new System.Drawing.Point(359, 233);
            this.BTAddDixst.Name = "BTAddDixst";
            this.BTAddDixst.Size = new System.Drawing.Size(120, 25);
            this.BTAddDixst.TabIndex = 32;
            this.BTAddDixst.Text = "Добавить";
            this.BTAddDixst.UseVisualStyleBackColor = true;
            this.BTAddDixst.Click += new System.EventHandler(this.BTAddDixst_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "M";
            // 
            // TBMExp
            // 
            this.TBMExp.Enabled = false;
            this.TBMExp.Location = new System.Drawing.Point(305, 194);
            this.TBMExp.Name = "TBMExp";
            this.TBMExp.Size = new System.Drawing.Size(40, 20);
            this.TBMExp.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "sqrt(D)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "M";
            // 
            // TBM
            // 
            this.TBM.Enabled = false;
            this.TBM.Location = new System.Drawing.Point(376, 168);
            this.TBM.Name = "TBM";
            this.TBM.Size = new System.Drawing.Size(40, 20);
            this.TBM.TabIndex = 27;
            // 
            // TBD
            // 
            this.TBD.Enabled = false;
            this.TBD.Location = new System.Drawing.Point(305, 168);
            this.TBD.Name = "TBD";
            this.TBD.Size = new System.Drawing.Size(40, 20);
            this.TBD.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Lam";
            // 
            // TBLam
            // 
            this.TBLam.Enabled = false;
            this.TBLam.Location = new System.Drawing.Point(305, 144);
            this.TBLam.Name = "TBLam";
            this.TBLam.Size = new System.Drawing.Size(40, 20);
            this.TBLam.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Mod";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kol";
            // 
            // TBModEr
            // 
            this.TBModEr.Enabled = false;
            this.TBModEr.Location = new System.Drawing.Point(376, 118);
            this.TBModEr.Name = "TBModEr";
            this.TBModEr.Size = new System.Drawing.Size(40, 20);
            this.TBModEr.TabIndex = 21;
            // 
            // TBKol
            // 
            this.TBKol.Enabled = false;
            this.TBKol.Location = new System.Drawing.Point(305, 118);
            this.TBKol.Name = "TBKol";
            this.TBKol.Size = new System.Drawing.Size(40, 20);
            this.TBKol.TabIndex = 20;
            // 
            // TBB
            // 
            this.TBB.Enabled = false;
            this.TBB.Location = new System.Drawing.Point(376, 66);
            this.TBB.Name = "TBB";
            this.TBB.Size = new System.Drawing.Size(39, 20);
            this.TBB.TabIndex = 19;
            // 
            // TBMod
            // 
            this.TBMod.Enabled = false;
            this.TBMod.Location = new System.Drawing.Point(443, 92);
            this.TBMod.Name = "TBMod";
            this.TBMod.Size = new System.Drawing.Size(40, 20);
            this.TBMod.TabIndex = 18;
            // 
            // TBMax
            // 
            this.TBMax.Enabled = false;
            this.TBMax.Location = new System.Drawing.Point(375, 92);
            this.TBMax.Name = "TBMax";
            this.TBMax.Size = new System.Drawing.Size(40, 20);
            this.TBMax.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mod";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "A";
            // 
            // TBMin
            // 
            this.TBMin.Enabled = false;
            this.TBMin.Location = new System.Drawing.Point(305, 92);
            this.TBMin.Name = "TBMin";
            this.TBMin.Size = new System.Drawing.Size(40, 20);
            this.TBMin.TabIndex = 4;
            // 
            // TBA
            // 
            this.TBA.Enabled = false;
            this.TBA.Location = new System.Drawing.Point(306, 66);
            this.TBA.Name = "TBA";
            this.TBA.Size = new System.Drawing.Size(39, 20);
            this.TBA.TabIndex = 2;
            // 
            // CBDist
            // 
            this.CBDist.FormattingEnabled = true;
            this.CBDist.Items.AddRange(new object[] {
            "Равномерное",
            "Треугольное",
            "Эрланг",
            "Пуассон",
            "Нормальное",
            "Экспоненциальное"});
            this.CBDist.Location = new System.Drawing.Point(276, 34);
            this.CBDist.Name = "CBDist";
            this.CBDist.Size = new System.Drawing.Size(203, 21);
            this.CBDist.TabIndex = 1;
            this.CBDist.SelectedIndexChanged += new System.EventHandler(this.CBDist_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LVlLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Лог";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LVlLog
            // 
            this.LVlLog.Location = new System.Drawing.Point(0, 0);
            this.LVlLog.Name = "LVlLog";
            this.LVlLog.Size = new System.Drawing.Size(996, 440);
            this.LVlLog.TabIndex = 0;
            this.LVlLog.UseCompatibleStateImageBehavior = false;
            this.LVlLog.View = System.Windows.Forms.View.List;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LVStatD);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(998, 443);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Статистика по устройствам";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LVStatD
            // 
            this.LVStatD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14});
            this.LVStatD.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.LVStatD.Location = new System.Drawing.Point(3, 3);
            this.LVStatD.Name = "LVStatD";
            this.LVStatD.Size = new System.Drawing.Size(992, 437);
            this.LVStatD.TabIndex = 0;
            this.LVStatD.UseCompatibleStateImageBehavior = false;
            this.LVStatD.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Параметры";
            this.columnHeader14.Width = 315;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.LVStatQ);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(998, 443);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Статистика по очередям";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // LVStatQ
            // 
            this.LVStatQ.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16});
            this.LVStatQ.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18});
            this.LVStatQ.Location = new System.Drawing.Point(3, 3);
            this.LVStatQ.Name = "LVStatQ";
            this.LVStatQ.Size = new System.Drawing.Size(995, 437);
            this.LVStatQ.TabIndex = 0;
            this.LVStatQ.UseCompatibleStateImageBehavior = false;
            this.LVStatQ.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Параметры";
            this.columnHeader16.Width = 333;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.LVStatC);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(998, 443);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Общая статистика";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // LVStatC
            // 
            this.LVStatC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader15});
            this.LVStatC.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26,
            listViewItem27,
            listViewItem28});
            this.LVStatC.Location = new System.Drawing.Point(0, 3);
            this.LVStatC.Name = "LVStatC";
            this.LVStatC.Size = new System.Drawing.Size(998, 437);
            this.LVStatC.TabIndex = 0;
            this.LVStatC.UseCompatibleStateImageBehavior = false;
            this.LVStatC.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Параметры";
            this.columnHeader18.Width = 261;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Значение";
            this.columnHeader15.Width = 200;
            // 
            // BtStart
            // 
            this.BtStart.Location = new System.Drawing.Point(871, 471);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(136, 26);
            this.BtStart.TabIndex = 1;
            this.BtStart.Text = "Запуск системы";
            this.BtStart.UseVisualStyleBackColor = true;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // BTClean
            // 
            this.BTClean.Location = new System.Drawing.Point(750, 470);
            this.BTClean.Name = "BTClean";
            this.BTClean.Size = new System.Drawing.Size(119, 28);
            this.BTClean.TabIndex = 2;
            this.BTClean.Text = "Очистить";
            this.BTClean.UseVisualStyleBackColor = true;
            this.BTClean.Click += new System.EventHandler(this.BTClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 497);
            this.Controls.Add(this.BTClean);
            this.Controls.Add(this.BtStart);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Система моделирования";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBMExp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBM;
        private System.Windows.Forms.TextBox TBD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBLam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBModEr;
        private System.Windows.Forms.TextBox TBKol;
        private System.Windows.Forms.TextBox TBB;
        private System.Windows.Forms.TextBox TBMod;
        private System.Windows.Forms.TextBox TBMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBMin;
        private System.Windows.Forms.TextBox TBA;
        private System.Windows.Forms.ComboBox CBDist;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBSizeQ;
        private System.Windows.Forms.TextBox TBNameQ;
        private System.Windows.Forms.ComboBox CBTypeQ;
        private System.Windows.Forms.Button BTAddSyst;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox CBDistSyst;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TBChannelKol;
        private System.Windows.Forms.TextBox TBNameSyst;
        private System.Windows.Forms.Button BTAddQeue;
        private System.Windows.Forms.ComboBox TBDistG;
        private System.Windows.Forms.TextBox TBMaxTime;
        private System.Windows.Forms.TextBox TBMaxReq;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BTAddDixst;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListView LVQueue;
        private System.Windows.Forms.ListView LVDist;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader colemn1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView LVDrive;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox CBQueueName;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button BTCreateG;
        private System.Windows.Forms.Label informlab;
        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.ListView LVlLog;
        private System.Windows.Forms.CheckBox CHBClosedSystem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView LVStatC;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ListView LVStatQ;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ListView LVStatD;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Button BTClean;
    }
}

