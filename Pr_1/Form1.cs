using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            // Получаем данные
            string selectedFlight = cmR.SelectedItem.ToString();
            string selectedData = cmData.SelectedItem.ToString();
            string selectedTime = cmTime.SelectedItem.ToString();
            string selectedWagonType = cmV.SelectedItem.ToString();
            int adultCount = (int)nmA.Value;
            int childCount = (int)nmK.Value;
            bool hasLuggage = chL.Checked;
            bool hasBedding = chU.Checked;
            bool hasFood = chN.Checked;
            // Расчитываем стоимость билета
            double ticketPrice = CalculateTicketPrice(selectedWagonType, adultCount, childCount, hasLuggage, hasBedding, hasFood);
            // Выводим стоимость билета в MessageBox
            MessageBox.Show($"Стоимость билета: {ticketPrice} руб.");
        }

        private double CalculateTicketPrice(string wagonType, int adultCount, int childCount, bool hasLuggage, bool hasBedding, bool hasFood)
        {
            double basePrice = GetBasePrice(wagonType);
            double totalPrice = basePrice * (adultCount + childCount * 0.95);
            if (hasLuggage)
                totalPrice += totalPrice * 0.01;
            if (hasBedding)
                totalPrice += 208;
            if (hasFood)
                totalPrice += 506;
            return totalPrice;
        }

        private double GetBasePrice(string wagonType)
        {
            switch (wagonType)
            {
                case "Купе":
                    return 4733;
                case "СВ":
                    return 14610;
                case "Плацкарт":
                    return 3474;
                case "Для инвалидов":
                    return 4153;
                default:
                    return 0;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
