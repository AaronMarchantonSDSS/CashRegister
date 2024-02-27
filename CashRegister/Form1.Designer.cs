namespace CashRegister
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numOfRifflesLabel = new System.Windows.Forms.Label();
            this.numOfRoundsLabel = new System.Windows.Forms.Label();
            this.numOfScopesLabel = new System.Windows.Forms.Label();
            this.rifleInput = new System.Windows.Forms.TextBox();
            this.roundsInput = new System.Windows.Forms.TextBox();
            this.scopesInput = new System.Windows.Forms.TextBox();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutputLabel = new System.Windows.Forms.Label();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutputLabel = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.seperateLabel = new System.Windows.Forms.Label();
            this.receiptOutputLabel = new System.Windows.Forms.Label();
            this.seperateLabel2 = new System.Windows.Forms.Label();
            this.newReceiptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numOfRifflesLabel
            // 
            this.numOfRifflesLabel.AutoSize = true;
            this.numOfRifflesLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfRifflesLabel.ForeColor = System.Drawing.Color.Green;
            this.numOfRifflesLabel.Location = new System.Drawing.Point(13, 10);
            this.numOfRifflesLabel.Name = "numOfRifflesLabel";
            this.numOfRifflesLabel.Size = new System.Drawing.Size(164, 34);
            this.numOfRifflesLabel.TabIndex = 0;
            this.numOfRifflesLabel.Text = "Number Of Rifles:";
            this.numOfRifflesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOfRoundsLabel
            // 
            this.numOfRoundsLabel.AutoSize = true;
            this.numOfRoundsLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfRoundsLabel.ForeColor = System.Drawing.Color.Green;
            this.numOfRoundsLabel.Location = new System.Drawing.Point(13, 49);
            this.numOfRoundsLabel.Name = "numOfRoundsLabel";
            this.numOfRoundsLabel.Size = new System.Drawing.Size(178, 34);
            this.numOfRoundsLabel.TabIndex = 1;
            this.numOfRoundsLabel.Text = "Number Of Rounds:";
            this.numOfRoundsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOfScopesLabel
            // 
            this.numOfScopesLabel.AutoSize = true;
            this.numOfScopesLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfScopesLabel.ForeColor = System.Drawing.Color.Green;
            this.numOfScopesLabel.Location = new System.Drawing.Point(13, 88);
            this.numOfScopesLabel.Name = "numOfScopesLabel";
            this.numOfScopesLabel.Size = new System.Drawing.Size(178, 34);
            this.numOfScopesLabel.TabIndex = 2;
            this.numOfScopesLabel.Text = "Number Of Scopes:";
            this.numOfScopesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rifleInput
            // 
            this.rifleInput.BackColor = System.Drawing.Color.DarkGray;
            this.rifleInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rifleInput.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rifleInput.ForeColor = System.Drawing.Color.Green;
            this.rifleInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rifleInput.Location = new System.Drawing.Point(213, 10);
            this.rifleInput.Name = "rifleInput";
            this.rifleInput.Size = new System.Drawing.Size(97, 33);
            this.rifleInput.TabIndex = 3;
            // 
            // roundsInput
            // 
            this.roundsInput.BackColor = System.Drawing.Color.DarkGray;
            this.roundsInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roundsInput.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundsInput.ForeColor = System.Drawing.Color.Green;
            this.roundsInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.roundsInput.Location = new System.Drawing.Point(213, 50);
            this.roundsInput.Name = "roundsInput";
            this.roundsInput.Size = new System.Drawing.Size(97, 33);
            this.roundsInput.TabIndex = 4;
            // 
            // scopesInput
            // 
            this.scopesInput.BackColor = System.Drawing.Color.DarkGray;
            this.scopesInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scopesInput.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scopesInput.ForeColor = System.Drawing.Color.Green;
            this.scopesInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.scopesInput.Location = new System.Drawing.Point(213, 89);
            this.scopesInput.Name = "scopesInput";
            this.scopesInput.Size = new System.Drawing.Size(97, 33);
            this.scopesInput.TabIndex = 5;
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.BackColor = System.Drawing.Color.Black;
            this.calculateTotalButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.calculateTotalButton.FlatAppearance.BorderSize = 3;
            this.calculateTotalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateTotalButton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotalButton.ForeColor = System.Drawing.Color.Green;
            this.calculateTotalButton.Location = new System.Drawing.Point(85, 144);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(182, 43);
            this.calculateTotalButton.TabIndex = 6;
            this.calculateTotalButton.Text = "Calculate Totals";
            this.calculateTotalButton.UseVisualStyleBackColor = false;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.Color.Green;
            this.subtotalLabel.Location = new System.Drawing.Point(13, 204);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(98, 34);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Sub Total:";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.Green;
            this.taxLabel.Location = new System.Drawing.Point(13, 243);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(49, 34);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax:";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Green;
            this.totalLabel.Location = new System.Drawing.Point(13, 283);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(60, 34);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtotalOutputLabel
            // 
            this.subtotalOutputLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subtotalOutputLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutputLabel.ForeColor = System.Drawing.Color.Green;
            this.subtotalOutputLabel.Location = new System.Drawing.Point(212, 204);
            this.subtotalOutputLabel.Name = "subtotalOutputLabel";
            this.subtotalOutputLabel.Size = new System.Drawing.Size(98, 33);
            this.subtotalOutputLabel.TabIndex = 10;
            this.subtotalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.taxOutputLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutputLabel.ForeColor = System.Drawing.Color.Green;
            this.taxOutputLabel.Location = new System.Drawing.Point(212, 243);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(98, 34);
            this.taxOutputLabel.TabIndex = 11;
            this.taxOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalOutputLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutputLabel.ForeColor = System.Drawing.Color.Green;
            this.totalOutputLabel.Location = new System.Drawing.Point(212, 283);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(98, 34);
            this.totalOutputLabel.TabIndex = 12;
            this.totalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.Green;
            this.tenderedLabel.Location = new System.Drawing.Point(13, 386);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(98, 34);
            this.tenderedLabel.TabIndex = 13;
            this.tenderedLabel.Text = "Tendered:";
            this.tenderedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenderedInput
            // 
            this.tenderedInput.BackColor = System.Drawing.Color.DarkGray;
            this.tenderedInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tenderedInput.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.ForeColor = System.Drawing.Color.Green;
            this.tenderedInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tenderedInput.Location = new System.Drawing.Point(213, 386);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(97, 33);
            this.tenderedInput.TabIndex = 14;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.BackColor = System.Drawing.Color.Black;
            this.calculateChangeButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.calculateChangeButton.FlatAppearance.BorderSize = 3;
            this.calculateChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateChangeButton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChangeButton.ForeColor = System.Drawing.Color.Green;
            this.calculateChangeButton.Location = new System.Drawing.Point(85, 446);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(182, 43);
            this.calculateChangeButton.TabIndex = 15;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = false;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.Green;
            this.changeLabel.Location = new System.Drawing.Point(13, 525);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(82, 34);
            this.changeLabel.TabIndex = 16;
            this.changeLabel.Text = "Change:";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeOutputLabel
            // 
            this.changeOutputLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeOutputLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutputLabel.ForeColor = System.Drawing.Color.Green;
            this.changeOutputLabel.Location = new System.Drawing.Point(212, 525);
            this.changeOutputLabel.Name = "changeOutputLabel";
            this.changeOutputLabel.Size = new System.Drawing.Size(98, 34);
            this.changeOutputLabel.TabIndex = 17;
            this.changeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.BackColor = System.Drawing.Color.Black;
            this.printReceiptButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.printReceiptButton.FlatAppearance.BorderSize = 3;
            this.printReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceiptButton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptButton.ForeColor = System.Drawing.Color.Green;
            this.printReceiptButton.Location = new System.Drawing.Point(85, 580);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(182, 43);
            this.printReceiptButton.TabIndex = 18;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = false;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // seperateLabel
            // 
            this.seperateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.seperateLabel.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seperateLabel.ForeColor = System.Drawing.Color.Green;
            this.seperateLabel.Location = new System.Drawing.Point(-3, 348);
            this.seperateLabel.Name = "seperateLabel";
            this.seperateLabel.Size = new System.Drawing.Size(374, 21);
            this.seperateLabel.TabIndex = 19;
            this.seperateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receiptOutputLabel
            // 
            this.receiptOutputLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.receiptOutputLabel.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutputLabel.ForeColor = System.Drawing.Color.Green;
            this.receiptOutputLabel.Location = new System.Drawing.Point(428, 25);
            this.receiptOutputLabel.Name = "receiptOutputLabel";
            this.receiptOutputLabel.Size = new System.Drawing.Size(344, 534);
            this.receiptOutputLabel.TabIndex = 20;
            // 
            // seperateLabel2
            // 
            this.seperateLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.seperateLabel2.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seperateLabel2.ForeColor = System.Drawing.Color.Green;
            this.seperateLabel2.Location = new System.Drawing.Point(352, -6);
            this.seperateLabel2.Name = "seperateLabel2";
            this.seperateLabel2.Size = new System.Drawing.Size(19, 668);
            this.seperateLabel2.TabIndex = 21;
            this.seperateLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newReceiptButton
            // 
            this.newReceiptButton.BackColor = System.Drawing.Color.Black;
            this.newReceiptButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.newReceiptButton.FlatAppearance.BorderSize = 3;
            this.newReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newReceiptButton.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newReceiptButton.ForeColor = System.Drawing.Color.Green;
            this.newReceiptButton.Location = new System.Drawing.Point(426, 579);
            this.newReceiptButton.Name = "newReceiptButton";
            this.newReceiptButton.Size = new System.Drawing.Size(346, 43);
            this.newReceiptButton.TabIndex = 22;
            this.newReceiptButton.Text = "Print New Receipt";
            this.newReceiptButton.UseVisualStyleBackColor = false;
            this.newReceiptButton.Click += new System.EventHandler(this.newReceiptButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(350, 634);
            this.Controls.Add(this.newReceiptButton);
            this.Controls.Add(this.seperateLabel2);
            this.Controls.Add(this.receiptOutputLabel);
            this.Controls.Add(this.seperateLabel);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.changeOutputLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.taxOutputLabel);
            this.Controls.Add(this.subtotalOutputLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.scopesInput);
            this.Controls.Add(this.roundsInput);
            this.Controls.Add(this.rifleInput);
            this.Controls.Add(this.numOfScopesLabel);
            this.Controls.Add(this.numOfRoundsLabel);
            this.Controls.Add(this.numOfRifflesLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "The Black Market";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numOfRifflesLabel;
        private System.Windows.Forms.Label numOfRoundsLabel;
        private System.Windows.Forms.Label numOfScopesLabel;
        private System.Windows.Forms.TextBox rifleInput;
        private System.Windows.Forms.TextBox roundsInput;
        private System.Windows.Forms.TextBox scopesInput;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalOutputLabel;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutputLabel;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Label seperateLabel;
        private System.Windows.Forms.Label receiptOutputLabel;
        private System.Windows.Forms.Label seperateLabel2;
        private System.Windows.Forms.Button newReceiptButton;
    }
}

