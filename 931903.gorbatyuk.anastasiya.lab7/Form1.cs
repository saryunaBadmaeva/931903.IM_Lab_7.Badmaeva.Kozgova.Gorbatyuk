using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _931903.gorbatyuk.anastasiya.lab7
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        bool isStarted = false;

        int time = 0; //количество месяцев
        double Budget; //бюджет аэропорта
        double TicketPrice; //цена билета

        double TicketPriceMax=50; //максимальная цена билета
        double TicketPriceMin = 1 ; //максимальная цена билета

        double inflow, outflow;  //величина прихода и ухода

        
        double EvolutionCoef=0; //коэфициент развития аэропорта
        double EvolutionCoefSum=0; //суммарное развитие аэропорта с момента исследования

        double MaxBudget=0;

        double OutlayStaff=2; //затраты на персонал

        int AvailableDestinations = 3;// доступные направления
        double Infrastructure = 0.3; //уровень развития инфраструктуры
        double DemandTickets; //уровень спроса на билеты
        double TicketSold=10;//выручка от продажи билетов
        int NumberAvia=5;
        int ostN=0;
        double MaxInflow=20;


        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (isStarted)
            {
                time = 0;

                timer1.Stop();
            }
            else
            {
                chart1.Series[0].Points.Clear();


                Budget = (double)edBudget.Value; 
                TicketPrice = (double)edTiсketPrice.Value;
                MaxBudget = Budget;

                chart1.Series[0].Points.AddXY(time, Budget);

                timer1.Start();
            }

            isStarted = !isStarted;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            int ost = (int)(Budget / 100);
            if (ost > ostN)
            {
                ostN = ost;
                EvolutionCoef = rnd.NextDouble(); //коэфициент расширения случайный
                EvolutionCoefSum += EvolutionCoef; //накапливаем коэфициент развития

                OutlayStaff += (EvolutionCoefSum * OutlayStaff); // обновленное количество персонала
                Infrastructure += (EvolutionCoefSum * Infrastructure); //обновленное качество инфраструктуры
                AvailableDestinations += (int)(EvolutionCoefSum * AvailableDestinations); //обновление доступных
                MaxInflow += (EvolutionCoefSum * MaxInflow);
            }
            
            if (ost<ostN-2)
            {
                ostN = ost;
                EvolutionCoef = rnd.NextDouble(); //коэффициент расширения случайный
                EvolutionCoefSum -= EvolutionCoef; //накапливаем коэффициент развития

                OutlayStaff -= (EvolutionCoefSum * OutlayStaff); // обновленное количество персонала
                Infrastructure -= (EvolutionCoefSum * Infrastructure); //обновленное качество инфраструктуры
                AvailableDestinations -= (int)(EvolutionCoefSum * AvailableDestinations); //обновление доступных
                MaxInflow -= (EvolutionCoefSum * MaxInflow);
            }



            //inflow = Math.Min(Budget-TicketSold, (0 + rnd.NextDouble() * (MaxInflow - 0)));
            inflow = TicketSold;
            Budget += inflow;

            DemandTickets = (Infrastructure + (double)AvailableDestinations) /10;//0.33

            int oldNumberAvia = NumberAvia;

           NumberAvia = (int)(DemandTickets*5);  //3
          

            if(oldNumberAvia>NumberAvia)
            {
                TicketPrice = TicketPrice + 0.1 * NumberAvia;
            }
            else { 
                if(oldNumberAvia < NumberAvia)
            {
                TicketPrice = TicketPrice - 0.1 * NumberAvia;
            }
            }
            


            TicketSold = (TicketPrice * rnd.Next(1000, 3000))/1000;

            outflow = Infrastructure * 10 + OutlayStaff;

            Budget -= outflow;

            chart1.Series[0].Points.AddXY(time, Budget);

            lbEvol.Text= Math.Round(EvolutionCoefSum, 3).ToString(); //коэффициент развития
            lbInf.Text = Math.Round(Infrastructure, 3).ToString(); // инфраструктура
            lbOutLS.Text = Math.Round(OutlayStaff, 3).ToString(); //затраты на персонал
            lbAviago.Text= AvailableDestinations.ToString(); //доступные направления  
            lbDemand.Text = Math.Round(DemandTickets, 3).ToString(); //спрос на билеты
            lbAviaCom.Text = NumberAvia.ToString(); //число авиакомпаний
            lbPriceTic.Text = Math.Round(TicketPrice, 3).ToString(); //цена билета
            lbSold.Text= Math.Round(TicketSold, 3).ToString(); //выручка от билетов

        }
    }
}
