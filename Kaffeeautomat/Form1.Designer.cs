namespace CoffeeMaker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbt_lateM = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.cbx_fairTrade = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trb_zucker = new System.Windows.Forms.TrackBar();
            this.rbt_choco = new System.Windows.Forms.RadioButton();
            this.rbt_tea = new System.Windows.Forms.RadioButton();
            this.rbt_cappuccino = new System.Windows.Forms.RadioButton();
            this.rbt_late = new System.Windows.Forms.RadioButton();
            this.rbt_melange = new System.Windows.Forms.RadioButton();
            this.tab_select = new System.Windows.Forms.TabControl();
            this.tab_product = new System.Windows.Forms.TabPage();
            this.tab_insertCoin = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.tbx_credit = new System.Windows.Forms.TextBox();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_50 = new System.Windows.Forms.Button();
            this.btn_20 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.tab_takeProduct = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_change = new System.Windows.Forms.TextBox();
            this.pcb_becher = new System.Windows.Forms.PictureBox();
            this.btn_takeIt = new System.Windows.Forms.Button();
            this.progressBarCoffee = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBarMilk = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBarChoco = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBarSuguare = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBarWater = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rbt_lateM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_zucker)).BeginInit();
            this.tab_select.SuspendLayout();
            this.tab_product.SuspendLayout();
            this.tab_insertCoin.SuspendLayout();
            this.tab_takeProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_becher)).BeginInit();
            this.SuspendLayout();
            // 
            // rbt_lateM
            // 
            this.rbt_lateM.Controls.Add(this.label16);
            this.rbt_lateM.Controls.Add(this.btn_ok);
            this.rbt_lateM.Controls.Add(this.cbx_fairTrade);
            this.rbt_lateM.Controls.Add(this.label3);
            this.rbt_lateM.Controls.Add(this.label2);
            this.rbt_lateM.Controls.Add(this.label1);
            this.rbt_lateM.Controls.Add(this.trb_zucker);
            this.rbt_lateM.Controls.Add(this.rbt_choco);
            this.rbt_lateM.Controls.Add(this.rbt_tea);
            this.rbt_lateM.Controls.Add(this.rbt_cappuccino);
            this.rbt_lateM.Controls.Add(this.rbt_late);
            this.rbt_lateM.Controls.Add(this.rbt_melange);
            this.rbt_lateM.Location = new System.Drawing.Point(17, 22);
            this.rbt_lateM.Name = "rbt_lateM";
            this.rbt_lateM.Size = new System.Drawing.Size(445, 250);
            this.rbt_lateM.TabIndex = 0;
            this.rbt_lateM.TabStop = false;
            this.rbt_lateM.Text = "Jedes Produkt: 60 Cent";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(185, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "5g";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(338, 195);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 11;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_OK_Clicked);
            // 
            // cbx_fairTrade
            // 
            this.cbx_fairTrade.AutoSize = true;
            this.cbx_fairTrade.Location = new System.Drawing.Point(260, 37);
            this.cbx_fairTrade.Name = "cbx_fairTrade";
            this.cbx_fairTrade.Size = new System.Drawing.Size(169, 17);
            this.cbx_fairTrade.TabIndex = 10;
            this.cbx_fairTrade.Text = "Fair-Trade Spende:   +20 Cent";
            this.cbx_fairTrade.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "+/- Zucker:  0g";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "10g";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "0g";
            // 
            // trb_zucker
            // 
            this.trb_zucker.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.trb_zucker.Location = new System.Drawing.Point(141, 37);
            this.trb_zucker.Maximum = 5;
            this.trb_zucker.Minimum = -5;
            this.trb_zucker.Name = "trb_zucker";
            this.trb_zucker.Size = new System.Drawing.Size(104, 45);
            this.trb_zucker.TabIndex = 6;
            // 
            // rbt_choco
            // 
            this.rbt_choco.AutoSize = true;
            this.rbt_choco.Location = new System.Drawing.Point(31, 195);
            this.rbt_choco.Name = "rbt_choco";
            this.rbt_choco.Size = new System.Drawing.Size(277, 17);
            this.rbt_choco.TabIndex = 5;
            this.rbt_choco.TabStop = true;
            this.rbt_choco.Tag = "4";
            this.rbt_choco.Text = "Chocolate         (8g Kakao, 100ml Wasser 5g Zucker)";
            this.rbt_choco.UseVisualStyleBackColor = true;
            this.rbt_choco.CheckedChanged += new System.EventHandler(this.ProductSelected);
            // 
            // rbt_tea
            // 
            this.rbt_tea.AutoSize = true;
            this.rbt_tea.Location = new System.Drawing.Point(31, 172);
            this.rbt_tea.Name = "rbt_tea";
            this.rbt_tea.Size = new System.Drawing.Size(226, 17);
            this.rbt_tea.TabIndex = 4;
            this.rbt_tea.TabStop = true;
            this.rbt_tea.Tag = "3";
            this.rbt_tea.Text = "Tea                   (100ml Wasser 5g Zucker)";
            this.rbt_tea.UseVisualStyleBackColor = true;
            this.rbt_tea.CheckedChanged += new System.EventHandler(this.ProductSelected);
            // 
            // rbt_cappuccino
            // 
            this.rbt_cappuccino.AutoSize = true;
            this.rbt_cappuccino.Location = new System.Drawing.Point(31, 149);
            this.rbt_cappuccino.Name = "rbt_cappuccino";
            this.rbt_cappuccino.Size = new System.Drawing.Size(399, 17);
            this.rbt_cappuccino.TabIndex = 3;
            this.rbt_cappuccino.TabStop = true;
            this.rbt_cappuccino.Tag = "2";
            this.rbt_cappuccino.Text = "Cappuccino      (8g Fairtrade-Kaffee, 100ml Wasser 10g Milchpulver 5g Zucker)";
            this.rbt_cappuccino.UseVisualStyleBackColor = true;
            this.rbt_cappuccino.CheckedChanged += new System.EventHandler(this.ProductSelected);
            // 
            // rbt_late
            // 
            this.rbt_late.AutoSize = true;
            this.rbt_late.Location = new System.Drawing.Point(31, 126);
            this.rbt_late.Name = "rbt_late";
            this.rbt_late.Size = new System.Drawing.Size(398, 17);
            this.rbt_late.TabIndex = 2;
            this.rbt_late.TabStop = true;
            this.rbt_late.Tag = "1";
            this.rbt_late.Text = "Late Macciato  (8g Fairtrade-Kaffee, 100ml Wasser 15g Milchpulver 5g Zucker)";
            this.rbt_late.UseVisualStyleBackColor = true;
            this.rbt_late.CheckedChanged += new System.EventHandler(this.ProductSelected);
            // 
            // rbt_melange
            // 
            this.rbt_melange.AutoSize = true;
            this.rbt_melange.Location = new System.Drawing.Point(31, 103);
            this.rbt_melange.Name = "rbt_melange";
            this.rbt_melange.Size = new System.Drawing.Size(392, 17);
            this.rbt_melange.TabIndex = 0;
            this.rbt_melange.TabStop = true;
            this.rbt_melange.Tag = "0";
            this.rbt_melange.Text = "Melange           (8g Fairtrade-Kaffee, 100ml Wasser 5g Milchpulver 5g Zucker)";
            this.rbt_melange.UseVisualStyleBackColor = true;
            this.rbt_melange.CheckedChanged += new System.EventHandler(this.ProductSelected);
            // 
            // tab_select
            // 
            this.tab_select.Controls.Add(this.tab_product);
            this.tab_select.Controls.Add(this.tab_insertCoin);
            this.tab_select.Controls.Add(this.tab_takeProduct);
            this.tab_select.Location = new System.Drawing.Point(12, 12);
            this.tab_select.Name = "tab_select";
            this.tab_select.SelectedIndex = 0;
            this.tab_select.Size = new System.Drawing.Size(487, 329);
            this.tab_select.TabIndex = 1;
            this.tab_select.SelectedIndexChanged += new System.EventHandler(this.tab_select_SelectedIndexChanged);
            this.tab_select.Click += new System.EventHandler(this.tab_select_Click);
            // 
            // tab_product
            // 
            this.tab_product.Controls.Add(this.rbt_lateM);
            this.tab_product.Location = new System.Drawing.Point(4, 22);
            this.tab_product.Name = "tab_product";
            this.tab_product.Padding = new System.Windows.Forms.Padding(3);
            this.tab_product.Size = new System.Drawing.Size(479, 303);
            this.tab_product.TabIndex = 0;
            this.tab_product.Text = "Produkt";
            this.tab_product.UseVisualStyleBackColor = true;
            // 
            // tab_insertCoin
            // 
            this.tab_insertCoin.Controls.Add(this.label4);
            this.tab_insertCoin.Controls.Add(this.btn_change);
            this.tab_insertCoin.Controls.Add(this.tbx_credit);
            this.tab_insertCoin.Controls.Add(this.btn_2);
            this.tab_insertCoin.Controls.Add(this.btn_1);
            this.tab_insertCoin.Controls.Add(this.btn_50);
            this.tab_insertCoin.Controls.Add(this.btn_20);
            this.tab_insertCoin.Controls.Add(this.btn_10);
            this.tab_insertCoin.Location = new System.Drawing.Point(4, 22);
            this.tab_insertCoin.Name = "tab_insertCoin";
            this.tab_insertCoin.Padding = new System.Windows.Forms.Padding(3);
            this.tab_insertCoin.Size = new System.Drawing.Size(479, 303);
            this.tab_insertCoin.TabIndex = 1;
            this.tab_insertCoin.Text = "Muenzeinwurf";
            this.tab_insertCoin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "EingeworfenerBetrag";
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(26, 217);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 6;
            this.btn_change.Text = "Rückgabe";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // tbx_credit
            // 
            this.tbx_credit.Location = new System.Drawing.Point(131, 85);
            this.tbx_credit.Name = "tbx_credit";
            this.tbx_credit.Size = new System.Drawing.Size(100, 20);
            this.tbx_credit.TabIndex = 5;
            this.tbx_credit.Tag = "0.1";
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(26, 170);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 23);
            this.btn_2.TabIndex = 4;
            this.btn_2.Tag = "2";
            this.btn_2.Text = "2 Euro";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.coins_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(26, 141);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 23);
            this.btn_1.TabIndex = 3;
            this.btn_1.Tag = "1";
            this.btn_1.Text = "1 Euro";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.coins_Click);
            // 
            // btn_50
            // 
            this.btn_50.Location = new System.Drawing.Point(26, 112);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(75, 23);
            this.btn_50.TabIndex = 2;
            this.btn_50.Tag = "0,5";
            this.btn_50.Text = "50 Cent";
            this.btn_50.UseVisualStyleBackColor = true;
            this.btn_50.Click += new System.EventHandler(this.coins_Click);
            // 
            // btn_20
            // 
            this.btn_20.Location = new System.Drawing.Point(26, 83);
            this.btn_20.Name = "btn_20";
            this.btn_20.Size = new System.Drawing.Size(75, 23);
            this.btn_20.TabIndex = 1;
            this.btn_20.Tag = "0,2";
            this.btn_20.Text = "20 Cent";
            this.btn_20.UseVisualStyleBackColor = true;
            this.btn_20.Click += new System.EventHandler(this.coins_Click);
            // 
            // btn_10
            // 
            this.btn_10.Location = new System.Drawing.Point(26, 54);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(75, 23);
            this.btn_10.TabIndex = 0;
            this.btn_10.Tag = "0,1";
            this.btn_10.Text = "10 Cent";
            this.btn_10.UseVisualStyleBackColor = true;
            this.btn_10.Click += new System.EventHandler(this.coins_Click);
            // 
            // tab_takeProduct
            // 
            this.tab_takeProduct.Controls.Add(this.label5);
            this.tab_takeProduct.Controls.Add(this.tbx_change);
            this.tab_takeProduct.Controls.Add(this.pcb_becher);
            this.tab_takeProduct.Controls.Add(this.btn_takeIt);
            this.tab_takeProduct.Location = new System.Drawing.Point(4, 22);
            this.tab_takeProduct.Name = "tab_takeProduct";
            this.tab_takeProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tab_takeProduct.Size = new System.Drawing.Size(479, 303);
            this.tab_takeProduct.TabIndex = 2;
            this.tab_takeProduct.Text = "Ausgabe";
            this.tab_takeProduct.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ueberzahlung retour:";
            // 
            // tbx_change
            // 
            this.tbx_change.Location = new System.Drawing.Point(174, 271);
            this.tbx_change.Name = "tbx_change";
            this.tbx_change.Size = new System.Drawing.Size(125, 20);
            this.tbx_change.TabIndex = 2;
            // 
            // pcb_becher
            // 
            this.pcb_becher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcb_becher.BackgroundImage")));
            this.pcb_becher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_becher.Location = new System.Drawing.Point(174, 29);
            this.pcb_becher.Name = "pcb_becher";
            this.pcb_becher.Size = new System.Drawing.Size(125, 206);
            this.pcb_becher.TabIndex = 1;
            this.pcb_becher.TabStop = false;
            // 
            // btn_takeIt
            // 
            this.btn_takeIt.Location = new System.Drawing.Point(174, 241);
            this.btn_takeIt.Name = "btn_takeIt";
            this.btn_takeIt.Size = new System.Drawing.Size(125, 23);
            this.btn_takeIt.TabIndex = 0;
            this.btn_takeIt.Text = "Becher entnehmen";
            this.btn_takeIt.UseVisualStyleBackColor = true;
            this.btn_takeIt.Click += new System.EventHandler(this.btn_takeIt_Click);
            // 
            // progressBarCoffee
            // 
            this.progressBarCoffee.Location = new System.Drawing.Point(100, 349);
            this.progressBarCoffee.Maximum = 1000;
            this.progressBarCoffee.Name = "progressBarCoffee";
            this.progressBarCoffee.Size = new System.Drawing.Size(345, 15);
            this.progressBarCoffee.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kaffeepulver:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Milchpulver:";
            // 
            // progressBarMilk
            // 
            this.progressBarMilk.Location = new System.Drawing.Point(100, 370);
            this.progressBarMilk.Maximum = 1000;
            this.progressBarMilk.Name = "progressBarMilk";
            this.progressBarMilk.Size = new System.Drawing.Size(345, 15);
            this.progressBarMilk.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kakaopulver:";
            // 
            // progressBarChoco
            // 
            this.progressBarChoco.Location = new System.Drawing.Point(100, 391);
            this.progressBarChoco.Maximum = 1000;
            this.progressBarChoco.Name = "progressBarChoco";
            this.progressBarChoco.Size = new System.Drawing.Size(345, 15);
            this.progressBarChoco.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Zucker:";
            // 
            // progressBarSuguare
            // 
            this.progressBarSuguare.Location = new System.Drawing.Point(100, 412);
            this.progressBarSuguare.Maximum = 1000;
            this.progressBarSuguare.Name = "progressBarSuguare";
            this.progressBarSuguare.Size = new System.Drawing.Size(345, 15);
            this.progressBarSuguare.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Wasser:";
            // 
            // progressBarWater
            // 
            this.progressBarWater.Location = new System.Drawing.Point(100, 434);
            this.progressBarWater.Maximum = 10000;
            this.progressBarWater.Name = "progressBarWater";
            this.progressBarWater.Size = new System.Drawing.Size(345, 15);
            this.progressBarWater.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(451, 434);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "10000 ml";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(451, 413);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "1000 g";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(451, 391);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "1000 g";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(451, 370);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "1000 g";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(451, 349);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "1000 g";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 464);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressBarWater);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.progressBarSuguare);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progressBarChoco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBarMilk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBarCoffee);
            this.Controls.Add(this.tab_select);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kaffeeautomat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rbt_lateM.ResumeLayout(false);
            this.rbt_lateM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_zucker)).EndInit();
            this.tab_select.ResumeLayout(false);
            this.tab_product.ResumeLayout(false);
            this.tab_insertCoin.ResumeLayout(false);
            this.tab_insertCoin.PerformLayout();
            this.tab_takeProduct.ResumeLayout(false);
            this.tab_takeProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_becher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox rbt_lateM;
        private System.Windows.Forms.RadioButton rbt_late;
        private System.Windows.Forms.RadioButton rbt_melange;
        private System.Windows.Forms.RadioButton rbt_tea;
        private System.Windows.Forms.RadioButton rbt_cappuccino;
        private System.Windows.Forms.RadioButton rbt_choco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trb_zucker;
        private System.Windows.Forms.TabControl tab_select;
        private System.Windows.Forms.TabPage tab_product;
        private System.Windows.Forms.TabPage tab_insertCoin;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.TextBox tbx_credit;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_50;
        private System.Windows.Forms.Button btn_20;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.TabPage tab_takeProduct;
        private System.Windows.Forms.PictureBox pcb_becher;
        private System.Windows.Forms.Button btn_takeIt;
        private System.Windows.Forms.CheckBox cbx_fairTrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_change;
        private System.Windows.Forms.ProgressBar progressBarCoffee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBarMilk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBarChoco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBarSuguare;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBarWater;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label16;
    }
}

