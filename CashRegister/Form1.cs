//Aaron Marchanton
//March 6, 2024
//Cash Register For The Black Market

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
        int numOfRifles = 0; //Global Variables Created
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

        private void calculateTotalButton_Click(object sender, EventArgs e)
        {

            try //Try-Catch Statement to Catch Errors
            {
                numOfRifles = Convert.ToInt32(rifleInput.Text); //Convert an Entered Value Into an Int and Store it Into the Variable
                numOfRounds = Convert.ToInt32(roundsInput.Text);
                numOfScopes = Convert.ToInt32(scopesInput.Text); 

                subtotalAmmount = numOfRifles * riflePrice + numOfRounds * roundsPrice + numOfScopes * scopesPrice; //All the Math for Other Variables and Store it
                taxAmmount = taxPrice * subtotalAmmount;
                totalAmmount = taxAmmount + subtotalAmmount;

                subtotalOutputLabel.Text = $"{subtotalAmmount.ToString(".00")} BTC"; //Output Several Variables With Proper Dollar Formatting
                taxOutputLabel.Text = $"{taxAmmount.ToString(".00")} BTC";
                totalOutputLabel.Text = $"{totalAmmount.ToString(".00")} BTC";

                SoundPlayer player = new SoundPlayer(Properties.Resources.laserSound); //Play the Laser Sound
                player.Play();
            }
            catch
            {
                subtotalOutputLabel.Text = "Invalid #"; //If there is an Error Display the Error Messages
                taxOutputLabel.Text = "Invalid #";
                totalOutputLabel.Text = "Invalid #";
            }

            calculateChangeButton.Enabled = true; //Enable the Next Button
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                ammountTendered = Convert.ToDouble(tenderedInput.Text); //Convert to a Double and Save the Value in a Variable

                changeAmmount = ammountTendered - totalAmmount; //Do Math and Save Answer in a Variable

                changeOutputLabel.Text = $"{changeAmmount.ToString("0.00")} BTC"; //Output the Answer

                SoundPlayer player = new SoundPlayer(Properties.Resources.laserSound); //Play the Laser Sound
                player.Play();

                if (ammountTendered < totalAmmount) //If There Isn't Enough Payment Display the Error
                {
                    changeOutputLabel.Text = "No Funds";
                }
            }
            catch //If There is an Error Display the Following Message
            {
                changeOutputLabel.Text = "Invalid #";
            }

            printReceiptButton.Enabled = true; //Enable the Next Button
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.moneySound); //Play the Money Sound Before Receipt is Done Printing
            player2.Play();

            this.Size = new Size(816, 673); //Resize Form

            receiptOutputLabel.TextAlign = ContentAlignment.TopLeft; //Reset The Receipt Allignment so it Prints in the Right Spot

            receiptOutputLabel.Text = "\n                              The Black Market";
            Refresh();
            Thread.Sleep(200);
            receiptOutputLabel.Text += $"\n\n    Order Number 1076";
            Refresh();
            Thread.Sleep(200);
            receiptOutputLabel.Text += $"\n    February 22, 2024";
            Refresh();
            Thread.Sleep(200);
            receiptOutputLabel.Text += $"\n";
            Refresh();
            Thread.Sleep(200);
            receiptOutputLabel.Text += "";
            Refresh();
            Thread.Sleep(200);
            receiptOutputLabel.Text += "";
            Refresh();
            Thread.Sleep(200);

            if (numOfRifles > 0.1) //Print Number of Rifles if Any are Bought
            {
                receiptOutputLabel.Text += $"\n\n    Rifles                                             x{numOfRifles} @ {riflePrice.ToString("00.00")} BTC";
                Refresh();
                Thread.Sleep(200);
            }

            if (numOfRounds > 0.1) //Print Number of Rounds if Any are Bought
            {
                receiptOutputLabel.Text += $"\n    Rounds                                          x{numOfRounds} @ {roundsPrice.ToString("00.00")} BTC";
                Refresh();
                Thread.Sleep(200);
            }

            if (numOfScopes > 0.1) //Print Number of Scopes if Any are Bought
            {
                receiptOutputLabel.Text += $"\n    Scopes                                          x{numOfScopes} @ {scopesPrice.ToString("00.00")} BTC";
                Refresh();
                Thread.Sleep(200);
            }

            receiptOutputLabel.Text += $"\n\n    Subtotal                                               $ {subtotalAmmount.ToString("00.00")} BTC"; //Print the Rest of the Receipt
            Refresh();
            Thread.Sleep(200);
            receiptOutputLabel.Text += $"\n    Tax                                                      $ {taxAmmount.ToString("00.00")} BTC";
            Refresh();
            Thread.Sleep(200);
            receiptOutputLabel.Text += $"\n    Total                                                    $ {totalAmmount.ToString("00.00")} BTC";
            Refresh();
            Thread.Sleep(200);
            receiptOutputLabel.Text += $"\n\n    Tendered                                              $ {ammountTendered.ToString("00.00")} BTC";
            Refresh();
            Thread.Sleep(200);
            receiptOutputLabel.Text += $"\n    Change                                                $ {changeAmmount.ToString("00.00")} BTC";
            Refresh();
            Thread.Sleep(200);
            receiptOutputLabel.Text += $"\n\n    Have a Nice Day:)";
                  
            player2.Play(); //Play the Money Sound After Receipt is Done Printing

            if (ammountTendered < totalAmmount) //Is The Ammount Tendered Enough
            {
                receiptOutputLabel.TextAlign = ContentAlignment.MiddleCenter; //Set Properties and Text of Error Message
                receiptOutputLabel.Text = "Transaction Failed";

                SoundPlayer player3 = new SoundPlayer(Properties.Resources.oopsSound); //Play the Error Sound
                player3.Play();
            }
            
            if (ammountTendered == 911) //Easter Egg Activation
            {
                receiptOutputLabel.TextAlign = ContentAlignment.MiddleCenter; //Set Properties and Text of Easter Egg
                receiptOutputLabel.Text = "The Police Are On The Way!";
                receiptOutputLabel.Text += $"\n\nRUN";

                SoundPlayer player4 = new SoundPlayer(Properties.Resources.sirenSound); //Play Siren Sound
                player4.Play();
            }
        }

        private void newReceiptButton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(366, 673); //Resize Form

            rifleInput.Text = ""; //Reset Receipt Text
            roundsInput.Text = "";
            scopesInput.Text = "";
            subtotalOutputLabel.Text = "";
            taxOutputLabel.Text = "";
            totalOutputLabel.Text = "";
            tenderedInput.Text = "";
            changeOutputLabel.Text = "";
            receiptOutputLabel.Text = "";

            numOfRifles = 0; //Reset Inputs
            numOfRounds = 0;
            numOfScopes = 0;
            ammountTendered = 0;

            subtotalAmmount = 0; //Reset Remaining Values
            totalAmmount = 0;
            taxAmmount = 0;
            changeAmmount = 0;

            calculateTotalButton.Enabled = false; //Make Buttons Unpressable Until ReActivated
            printReceiptButton.Enabled = false;
        }
    }
}