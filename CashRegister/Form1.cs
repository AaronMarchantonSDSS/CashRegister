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
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        int numOfRifles = 0;
        int numOfRounds = 0;
        int numOfScopes = 0;
        double riflePrice = 2;
        double roundsPrice = 0.3;
        double scopesPrice = 0.8;
        double ammountTendered;
        double changeAmmount;
        double taxPrice = 0.13;
        double taxAmmount;
        double totalAmmount;
        double subtotalAmmount;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                numOfRifles = Convert.ToInt32(rifleInput.Text);
                numOfRounds = Convert.ToInt32(roundsInput.Text);
                numOfScopes = Convert.ToInt32(scopesInput.Text);

                subtotalAmmount = numOfRifles * riflePrice + numOfRounds * roundsPrice + numOfScopes * scopesPrice;
                taxAmmount = taxPrice * subtotalAmmount;
                totalAmmount = taxAmmount + subtotalAmmount;

                subtotalOutputLabel.Text = $"{subtotalAmmount.ToString(".00")} BTC";
                taxOutputLabel.Text = $"{taxAmmount.ToString(".00")} BTC";
                totalOutputLabel.Text = $"{totalAmmount.ToString(".00")} BTC";

                SoundPlayer player = new SoundPlayer(Properties.Resources.laserSound);

                player.Play();
            }
            catch
            {
                subtotalOutputLabel.Text = "Invalid #";
                taxOutputLabel.Text = "Invalid #";
                totalOutputLabel.Text = "Invalid #";
            }
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                    ammountTendered = Convert.ToDouble(tenderedInput.Text);

                changeAmmount = ammountTendered - totalAmmount;

                changeOutputLabel.Text = $"{changeAmmount.ToString("0.00")} BTC";

                SoundPlayer player = new SoundPlayer(Properties.Resources.laserSound);
                player.Play();

                if (ammountTendered < totalAmmount)
                {
                    changeOutputLabel.Text = "No Funds";
                }
            }
            catch
            {
                changeOutputLabel.Text = "ERROR";
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(816, 673); //Resize Form
            receiptOutputLabel.TextAlign = ContentAlignment.TopLeft;

            receiptOutputLabel.Text = "\n                              The Black Market";
            receiptOutputLabel.Text += $"\n\n    Order Number 1076";
            receiptOutputLabel.Text += $"\n    February 22, 2024";

            if (numOfRifles > 0.1) //Only Print if Greater
            {
                receiptOutputLabel.Text += $"\n\n    Rifles                                             x{numOfRifles} @ {riflePrice.ToString("00.00")} BTC";
            }
            else
            {
                receiptOutputLabel.Text += $"\n";
            }

            if (numOfRounds > 0.1) //Only Print if Greater
            {
                receiptOutputLabel.Text += $"\n    Rounds                                          x{numOfRounds} @ {roundsPrice.ToString("00.00")} BTC";
            }
            else
            {
                receiptOutputLabel.Text += "";
            }

            if (numOfScopes > 0.1) //Only Print if Greater
            {
                receiptOutputLabel.Text += $"\n    Scopes                                          x{numOfScopes} @ {scopesPrice.ToString("00.00")} BTC";
            }
            else
            {
                receiptOutputLabel.Text += "";
            }

            receiptOutputLabel.Text += $"\n\n    Subtotal                                               $ {subtotalAmmount.ToString("00.00")} BTC";
            receiptOutputLabel.Text += $"\n    Tax                                                      $ {taxAmmount.ToString("00.00")} BTC";
            receiptOutputLabel.Text += $"\n    Total                                                    $ {totalAmmount.ToString("00.00")} BTC";             receiptOutputLabel.Text += $"\n\n    Tendered                                              $ {ammountTendered.ToString("00.00")} BTC";
            receiptOutputLabel.Text += $"\n    Change                                                $ {changeAmmount.ToString("00.00")} BTC";
            receiptOutputLabel.Text += $"\n\n    Have a Nice Day:)";

            SoundPlayer player2 = new SoundPlayer(Properties.Resources.moneySound);
            player2.Play();
            
            if (ammountTendered < totalAmmount) //Is The Ammount Tendered Enough
            {
                receiptOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
                receiptOutputLabel.Text = "Transaction Failed";

                SoundPlayer player3 = new SoundPlayer(Properties.Resources.oopsSound);
                player3.Play();
            }
            
            if (ammountTendered == 911) //Easter Egg
            {
                receiptOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
                receiptOutputLabel.Text = "The Police Are On The Way!";
                receiptOutputLabel.Text += $"\n\nRUN";

                SoundPlayer player4 = new SoundPlayer(Properties.Resources.sirenSound);
                player4.Play();
            }
        }

        private void newReceiptButton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(366, 673); //Resize Form
            rifleInput.Text = "";
            roundsInput.Text = "";
            scopesInput.Text = "";
            subtotalOutputLabel.Text = "";
            taxOutputLabel.Text = "";
            totalOutputLabel.Text = "";
            tenderedInput.Text = "";
            changeOutputLabel.Text = "";
            receiptOutputLabel.Text = "";
        }
    }
}