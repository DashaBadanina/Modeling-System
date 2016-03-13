using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Model
{
    public partial class Form1 : Form
    {

        int KolDist = 1;
        int KolQueue = 1;
        int KolSysytem = 1;
        int KolReq = 0;
        int KolObrRec = 0;
        public static List<Generator> DistList = new List<Generator>();
        public static List<RequestQueue> QueueList = new List<RequestQueue>();
         public static  List<Device> DeviceList = new List<Device>();
        public static List<string> Log = new List<string>();
        RequestForServ NewRequest;
        int MaxReq=0;
        int MaxTime=0;
        Generator mainG;
        public static UniformDist channeldist;
        public static UniformDist priordist;
        public static double TS = 0;
        int A = 1;
        int B = 3;
        public bool StopGen;
        public Form1()
        {
            InitializeComponent();
            channeldist = new UniformDist(A,B);
            priordist = new UniformDist(A,B);
            StopGen = false;

        }

        private void BTAddDixst_Click(object sender, EventArgs e)
        {
            switch(CBDist.SelectedIndex)
             {
                 case 0:
                     {
                         ListViewItem item = new ListViewItem();
                         item.Text = KolDist.ToString();
                         item.SubItems.Add(CBDist.Text);
                         item.SubItems.Add(TBA.Text);
                         item.SubItems.Add(TBB.Text);
                         LVDist.Items.Add(item);
                         UniformDist a = new UniformDist(Convert.ToInt32(TBA.Text), Convert.ToInt32(TBB.Text));
                         DistList.Add(a);
                         CBDistSyst.Items.Add(KolDist);
                         TBDistG.Items.Add(KolDist);
                         LVlLog.Items.Add("Добавлено распределение: " + a.Name + "; c параметрами П1=" + TBA.Text + ", П2=" + TBB.Text);
                         KolDist++;
                         
                     } break;
                 case 1:
                     {
                         ListViewItem item = new ListViewItem();
                         item.Text = KolDist.ToString();
                         item.SubItems.Add(CBDist.Text);
                         item.SubItems.Add(TBMin.Text);
                         item.SubItems.Add(TBMax.Text);
                         item.SubItems.Add(TBMod.Text);
                         LVDist.Items.Add(item);
                         TriangleDist a = new TriangleDist(Convert.ToInt32(TBMax.Text), Convert.ToInt32(TBMin.Text), Convert.ToInt32(TBMod.Text));
                         DistList.Add(a);
                         CBDistSyst.Items.Add(KolDist);
                         TBDistG.Items.Add(KolDist);
                         LVlLog.Items.Add("Добавлено распределение: " + a.Name + "; c параметрами П1=" + TBMin.Text + ", П2=" + TBMax.Text + ", П3=" + TBMod.Text);
                         KolDist++;
                     }break;
                 case 2:
                     {
                         ListViewItem item = new ListViewItem();
                         item.Text = KolDist.ToString();
                         item.SubItems.Add(CBDist.Text);
                         item.SubItems.Add(TBKol.Text);
                         item.SubItems.Add(TBModEr.Text);
                         LVDist.Items.Add(item);
                         ErlangDist a = new ErlangDist(Convert.ToInt32(TBModEr.Text), Convert.ToInt32(TBKol.Text));
                         DistList.Add(a);
                         CBDistSyst.Items.Add(KolDist);
                         TBDistG.Items.Add(KolDist);
                         LVlLog.Items.Add("Добавлено распределение: " + a.Name + "; c параметрами П1=" + TBKol.Text + ", П2=" + TBModEr.Text);
                         KolDist++;
                     } break;
                 case 3:
                     {
                         ListViewItem item = new ListViewItem();
                         item.Text = KolDist.ToString();
                         item.SubItems.Add(CBDist.Text);
                         item.SubItems.Add(TBLam.Text);
                         LVDist.Items.Add(item);
                         PuassonDist a = new PuassonDist(Convert.ToInt32(TBLam.Text));
                         DistList.Add(a);
                         CBDistSyst.Items.Add(KolDist);
                         TBDistG.Items.Add(KolDist);
                         LVlLog.Items.Add("Добавлено распределение: " + a.Name + "; c параметрами П1=" + TBLam.Text);
                         KolDist++;
                     } break;
                 case 4:
                     {
                         ListViewItem item = new ListViewItem();
                         item.Text = KolDist.ToString();
                         item.SubItems.Add(CBDist.Text);
                         item.SubItems.Add(TBM.Text);
                         item.SubItems.Add(TBD.Text);
                         LVDist.Items.Add(item);
                         NormalDist a = new NormalDist(Convert.ToInt32(TBM.Text), Convert.ToInt32(TBD.Text));
                         DistList.Add(a);
                         CBDistSyst.Items.Add(KolDist);
                         TBDistG.Items.Add(KolDist);
                         LVlLog.Items.Add("Добавлено распределение: " + a.Name + "; c параметрами П1=" + TBM.Text + ", П2=" + TBD.Text);
                         KolDist++;
                     } break;
                 case 5:
                     {
                         ListViewItem item = new ListViewItem();
                         item.Text = KolDist.ToString();
                         item.SubItems.Add(CBDist.Text);
                         item.SubItems.Add(TBMExp.Text);
                         LVDist.Items.Add(item);
                         ExponentialDist a = new ExponentialDist(Convert.ToInt32(TBMExp.Text));
                         DistList.Add(a);
                         CBDistSyst.Items.Add(KolDist);
                         TBDistG.Items.Add(KolDist);
                         KolDist++;
                         LVlLog.Items.Add("Добавлено распределение: " + a.Name + "; c параметрами П1=" + TBMExp.Text);
                     } break;

             }
        }

        private void BTAddQeue_Click(object sender, EventArgs e)
        {
            string d;
            ListViewItem item = new ListViewItem();
            item.Text = KolQueue.ToString();
            item.SubItems.Add(TBNameQ.Text);
            item.SubItems.Add(CBTypeQ.Text);
            item.SubItems.Add(TBSizeQ.Text);
            LVQueue.Items.Add(item);
            if (string.IsNullOrEmpty(TBSizeQ.Text)) d = "-1";
            else d = TBSizeQ.Text;
            RequestQueue a = new RequestQueue(KolQueue, CBTypeQ.Text,TBNameQ.Text,Convert.ToInt32(d));
            QueueList.Add(a);
            CBQueueName.Items.Add(KolQueue);
            LVStatQ.Columns.Add(TBNameQ.Text);
            LVlLog.Items.Add("Создана очередь, Имя = " + TBNameQ.Text + "; Тип=" + CBTypeQ.Text + "; Размер=" + d);
            Console.WriteLine(a.Size);
            KolQueue++;
        }

        private void BTAddSyst_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = KolSysytem.ToString();
            item.SubItems.Add(TBNameSyst.Text);
            item.SubItems.Add(TBChannelKol.Text);
            item.SubItems.Add(CBDistSyst.Text);
            item.SubItems.Add(CBQueueName.Text);
            LVDrive.Items.Add(item);
            Device a = new Device(KolSysytem, QueueList[Convert.ToInt32(CBQueueName.Text)-1],DistList[Convert.ToInt32(CBDistSyst.Text)-1], Convert.ToInt32(TBChannelKol.Text));
            DeviceList.Add(a);
            LVStatD.Columns.Add(TBNameSyst.Text);
            LVlLog.Items.Add("Создано устройство, Имя = " + TBNameSyst.Text + "; Количество каналов=" + TBChannelKol.Text + "; Распределени=" + CBDistSyst.Text + "; Очередь=" + DistList[Convert.ToInt32(CBDistSyst.Text) - 1].Name);
            KolSysytem++;

        }

        private void BTCreateG_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBMaxReq.Text)) MaxReq = Convert.ToInt32(TBMaxReq.Text);
            if (!string.IsNullOrEmpty(TBMaxTime.Text)) MaxTime = Convert.ToInt32(TBMaxTime.Text);
            mainG = DistList[Convert.ToInt32(TBDistG.Text) - 1];
            informlab.Text = "Заявки приходит согласно "+mainG.Name+" закону";
            LVlLog.Items.Add("Создана генератор случайных чисел по закону: " + mainG.Name);
            if (Convert.ToInt32(TBMaxTime.Text)==0) LVlLog.Items.Add("Колличество заявок которые необходимо обработать " + TBMaxReq.Text);
            else LVlLog.Items.Add("Моделирование системы будет происходить " + TBMaxTime.Text);

        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            KolReq++;
            NewRequest = new RequestForServ(KolReq);
            NewRequest.ArrivalTime = mainG.NextDouble();
            EventList.AddEvent(NewRequest.ArrivalTime,NewRequest);
            bool stop = false;
            Event CurReq;

            while(!stop)
            {
                CurReq = EventList.GetClosest();
                Console.WriteLine(CurReq.Request.ID);
                TS = CurReq.time;
                if (CurReq.IsNew)
                {
                    Log.Add("Время: " + TS.ToString() + "; Событие: поступила новая завка с номером: " + CurReq.Request.ID);
                    DeviceList[0].AddReq(GenNewRequest());//получаем новую заявку и записываем ее в список
                    if (KolObrRec == MaxReq) StopGen = true;

                }
                else
                {
                    CurReq.Request.WasInQueue = false;
                    Console.WriteLine(CurReq.Request.ID);
                    Console.WriteLine(CurReq.TekDevice);
                    DeviceList[CurReq.TekDevice-1].LeaveApp(CurReq.Request);//уходим с устройства на котором были
                    if (CurReq.TekDevice == DeviceList.Count)
                    {
                        if (CHBClosedSystem.Checked)
                        {
                            DeviceList[0].AddReq(CurReq.Request);
                        }
                        else
                        {
                            Log.Add("Заявка " + CurReq.Request.ID + " вышла из системы");
                            KolObrRec++;
                        }
                    }
                    else
                    {
                            DeviceList[CurReq.TekDevice].AddReq(CurReq.Request);
                    }
                }
                stop = stop || (KolObrRec >= MaxReq) || (MaxTime > 0) && (MaxTime <= TS);
            }
            MessageBox.Show("Моделирование окончено!");
            ToLog();
            ToStat();
         }

        public  void ToLog ()
        {
            LVlLog.Items.Add("");
            foreach (string s in Log)
            LVlLog.Items.Add(s);
        }

        public void ToStat()
        {
            //Статистика по устройствам
            for(int i=1; i<=DeviceList.Count;i++)
            {
                LVStatD.Items[0].SubItems.Add(Statistic.TC[i].ToString());//Количество обслуженных заявок
                LVStatD.Items[1].SubItems.Add(Statistic.BT[i].ToString());//Суммарное время обслуживания
                LVStatD.Items[2].SubItems.Add((Statistic.BT[i] / Statistic.TC[i]).ToString());//Среднее время занятости
                LVStatD.Items[3].SubItems.Add((Statistic.BT[i] / TS).ToString());//Коэффициент загрузки системы
                LVStatD.Items[4].SubItems.Add(Statistic.PullApps[i].ToString());//Количество вытолкнутых заявок
                LVStatD.Items[5].SubItems.Add(Statistic.QueryCount[i].ToString());//Число запросов на выделение каналов
                LVStatD.Items[6].SubItems.Add( Statistic.GeneralQueryValue[i].ToString());//Сумма величин запросов
                if (Statistic.QueryCount[i] != 0)
                {
                    LVStatD.Items[7].SubItems.Add( (1.0 * Statistic.GeneralQueryValue[i] / Statistic.QueryCount[i]).ToString());//Средняя величина запроса
                }
                LVStatD.Items[8].SubItems.Add( (Statistic.BusyChanCount[i] / TS).ToString());//Среднее количество занятых каналов
            }

            //Статистика по очередям
            for (int i = 1; i <= QueueList.Count; i++)
            {
                LVStatQ.Items[0].SubItems.Add(Statistic.CountQueueApps[i].ToString());//Количество заявок поставленных в очередь
                LVStatQ.Items[1].SubItems.Add(Statistic.QueuePassedApps[i].ToString());//Количество заявок прошедших через очередь
                LVStatQ.Items[2].SubItems.Add(Statistic.NotWaitApps[i].ToString());//Количество заявок с нулевым ожиданием
                LVStatQ.Items[3].SubItems.Add(Statistic.HT[i].ToString());//Суммарное время ожидания
                if (Statistic.QueuePassedApps[i] != 0) LVStatQ.Items[4].SubItems.Add((Statistic.HT[i] / Statistic.QueuePassedApps[i]).ToString());//Среднее время ожидания
                else LVStatQ.Items[4].SubItems.Add("0");
                if (Statistic.QueuePassedApps[i] != 0) LVStatQ.Items[5].SubItems.Add((Math.Sqrt(Statistic.SW2[i] / Statistic.QueuePassedApps[i] - (Statistic.HT[i] / Statistic.QueuePassedApps[i]) * (Statistic.HT[i] / Statistic.QueuePassedApps[i]))).ToString());//Среднеквадратичное отклонение времени ожидания
                else LVStatQ.Items[5].SubItems.Add("0");
                LVStatQ.Items[6].SubItems.Add((Statistic.STL[i] /TS).ToString());//Средняя длина очереди
                LVStatQ.Items[7].SubItems.Add(QueueList[i - 1].MaxLengh.ToString());//Максимальная длина очереди
                LVStatQ.Items[8].SubItems.Add(Statistic.PullApps[i].ToString());//Количество заявок получивших отказ
            }

            //Общая статистика
            double BusyPercent=0, AvrServiceTime=0, WaitTime=0;
            int QueueInApps=0, QueueThroughApps=0, QueueNotWaitApps=0, refAppsCount=0;
            for (int i = 1; i <= DeviceList.Count; i++)
            {
                BusyPercent += Statistic.BT[i] / Statistic.TC[i] / DeviceList[i-1].Channels;
                AvrServiceTime += Statistic.BT[i] / Statistic.TC[i];
                QueueInApps += Statistic.CountQueueApps[i];
                QueueThroughApps += Statistic.QueuePassedApps[i];
                QueueNotWaitApps += Statistic.NotWaitApps[i];
                WaitTime += Statistic.HT[i];
                refAppsCount += Statistic.PullApps[i];
            }
                LVStatC.Items[0].SubItems.Add(Statistic.TC_Common.ToString());//Общее число выполненных запросов
                LVStatC.Items[1].SubItems.Add(Statistic.BT_Common.ToString());//Суммарное время обслуживания
                LVStatC.Items[2].SubItems.Add(AvrServiceTime.ToString());//Среднее время занятости
                LVStatC.Items[3].SubItems.Add(BusyPercent.ToString());//Процент использования
                LVStatC.Items[4].SubItems.Add(QueueInApps.ToString());//Количество заявок поставленных в очередь
                LVStatC.Items[5].SubItems.Add(QueueThroughApps.ToString());//Количество заявок прошедших через очередь
                LVStatC.Items[6].SubItems.Add(QueueNotWaitApps.ToString());//Количество заявок с нулевым ожиданием
                LVStatC.Items[7].SubItems.Add(WaitTime.ToString());//Суммарное время ожидания
                LVStatC.Items[8].SubItems.Add((WaitTime / TS).ToString());//Среднее время ожидания
                LVStatC.Items[9].SubItems.Add(refAppsCount.ToString());//Количество вытолкнутых заявок
            
        }

        private RequestForServ GenNewRequest()
        {
            RequestForServ r = NewRequest;
            if (!StopGen)
            {
                KolReq++;
                NewRequest = new RequestForServ(KolReq);
                NewRequest.ArrivalTime = mainG.NextDouble() + r.ArrivalTime;
                EventList.AddEvent(NewRequest.ArrivalTime,NewRequest);
            }

            return r;
        }

        private void CBDist_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBA.Enabled = false;
            TBB.Enabled = false;
            TBMax.Enabled = false;
            TBMin.Enabled = false;
            TBMod.Enabled = false;
            TBKol.Enabled = false;
            TBModEr.Enabled = false;
            TBLam.Enabled = false;
            TBD.Enabled = false;
            TBM.Enabled = false;
            TBMExp.Enabled = false;
            switch (CBDist.SelectedIndex)
            {
                case 0:
                    {
                        TBA.Enabled = true;
                        TBB.Enabled = true;
                        break;
                    }
                case 1:
                    {
                        TBMax.Enabled = true;
                        TBMin.Enabled = true;
                        TBMod.Enabled = true;
                        break;
                    }
                case 2:
                    {
                        TBKol.Enabled = true;
                        TBModEr.Enabled = true;
                        break;
                    }
                case 3:
                    {
                        TBLam.Enabled = true;
                        break;
                    }
                case 4:
                    {
                        TBD.Enabled = true;
                        TBM.Enabled = true;
                        break;
                    }
                case 5:
                    {
                        TBMExp.Enabled = true;
                        break;
                    }
            }
        }

        private void BTClean_Click(object sender, EventArgs e)
        {
            LVDist.Items.Clear();
            LVQueue.Items.Clear();
            LVDrive.Items.Clear();
            CBDist.Text = "";
            CBTypeQ.Text = "";
            TBA.Text = "";
            TBB.Text = "";
            TBMax.Text = "";
            TBMin.Text = "";
            TBMod.Text = "";
            TBKol.Text = "";
            TBModEr.Text = "";
            TBLam.Text = "";
            TBD.Text = "";
            TBM.Text = "";
            TBMExp.Text = "";
            TBA.Enabled = false;
            TBB.Enabled = false;
            TBMax.Enabled = false;
            TBMin.Enabled = false;
            TBMod.Enabled = false;
            TBKol.Enabled = false;
            TBModEr.Enabled = false;
            TBLam.Enabled = false;
            TBD.Enabled = false;
            TBM.Enabled = false;
            TBMExp.Enabled = false;
            TBDistG.Items.Clear();
            TBDistG.Text = "";
            TBNameQ.Text = "";
            TBSizeQ.Text = "";
            CBDistSyst.Items.Clear();
            CBDistSyst.Text = "";
            CBQueueName.Items.Clear();
            CBQueueName.Text = "";
            TBNameSyst.Text = "";
            TBChannelKol.Text = "";
            LVlLog.Items.Clear();
            DistList.Clear();
            QueueList.Clear();
            DeviceList.Clear();
            Log.Clear();
            KolDist = 1;
            KolQueue = 1;
            KolSysytem = 1;
            KolReq = 0;
            KolObrRec = 0;
            TS = 0;
        }
    }
}
