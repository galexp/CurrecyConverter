namespace CurrencyApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnconvert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblcur = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Image = global::CurrencyApp.Properties.Resources.logo;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(93, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 79);
            this.label1.TabIndex = 2;
            this.label1.Text = "CURRENCY CONVERTER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(556, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Currency To";
            // 
            // cbTo
            // 
            this.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "USD: United States Dollar",
            "EUR: Euro",
            "GBP: British Pound Sterling"});
            this.cbTo.Location = new System.Drawing.Point(494, 328);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(271, 33);
            this.cbTo.TabIndex = 4;
           // this.cbTo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbFrom
            // 
            this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "AED: United Arab Emirates Dirham",
            "AFN: Afghan Afghani",
            "ALL: Albanian Lek",
            "AMD: Armenian Dram",
            "ANG: Netherlands Antillean Guilder",
            "AOA: Angolan Kwanza",
            "ARS: Argentine Peso",
            "AUD: Australian Dollar",
            "AWG: Aruban Florin",
            "AZN: Azerbaijani Manat",
            "BAM: Bosnia-Herzegovina Convertible Mark",
            "BBD: Barbadian Dollar",
            "BDT: Bangladeshi Taka",
            "BGN: Bulgarian Lev",
            "BHD: Bahraini Dinar",
            "BIF: Burundian Franc",
            "BMD: Bermudan Dollar",
            "BND: Brunei Dollar",
            "BOB: Bolivian Boliviano",
            "BRL: Brazilian Real",
            "BSD: Bahamian Dollar",
            "BTC: Bitcoin",
            "BTN: Bhutanese Ngultrum",
            "BWP: Botswanan Pula",
            "BYN: New Belarusian Ruble",
            "BYR: Belarusian Ruble",
            "BZD: Belize Dollar",
            "CAD: Canadian Dollar",
            "CDF: Congolese Franc",
            "CHF: Swiss Franc",
            "CLF: Chilean Unit of Account (UF)",
            "CLP: Chilean Peso",
            "CNY: Chinese Yuan",
            "COP: Colombian Peso",
            "CRC: Costa Rican Col\\u00f3n",
            "CUC: Cuban Convertible Peso",
            "CUP: Cuban Peso",
            "CVE: Cape Verdean Escudo",
            "CZK: Czech Republic Koruna",
            "DJF: Djiboutian Franc",
            "DKK: Danish Krone",
            "DOP: Dominican Peso",
            "DZD: Algerian Dinar",
            "EGP: Egyptian Pound",
            "ERN: Eritrean Nakfa",
            "ETB: Ethiopian Birr",
            "FJD: Fijian Dollar",
            "FKP: Falkland Islands Pound",
            "GEL: Georgian Lari",
            "GGP: Guernsey Pound",
            "GHS: Ghanaian Cedi",
            "GIP: Gibraltar Pound",
            "GMD: Gambian Dalasi",
            "GNF: Guinean Franc",
            "GTQ: Guatemalan Quetzal",
            "GYD: Guyanaese Dollar",
            "HKD: Hong Kong Dollar",
            "HNL: Honduran Lempira",
            "HRK: Croatian Kuna",
            "HTG: Haitian Gourde",
            "HUF: Hungarian Forint",
            "IDR: Indonesian Rupiah",
            "ILS: Israeli New Sheqel",
            "IMP: Manx pound",
            "INR: Indian Rupee",
            "IQD: Iraqi Dinar",
            "IRR: Iranian Rial",
            "ISK: Icelandic Kr\\u00f3na",
            "JEP: Jersey Pound",
            "JMD: Jamaican Dollar",
            "JOD: Jordanian Dinar",
            "JPY: Japanese Yen",
            "KES: Kenyan Shilling",
            "KGS: Kyrgystani Som",
            "KHR: Cambodian Riel",
            "KMF: Comorian Franc",
            "KPW: North Korean Won",
            "KRW: South Korean Won",
            "KWD: Kuwaiti Dinar",
            "KYD: Cayman Islands Dollar",
            "KZT: Kazakhstani Tenge",
            "LAK: Laotian Kip",
            "LBP: Lebanese Pound",
            "LKR: Sri Lankan Rupee",
            "LRD: Liberian Dollar",
            "LSL: Lesotho Loti",
            "LTL: Lithuanian Litas",
            "LVL: Latvian Lats",
            "LYD: Libyan Dinar",
            "MAD: Moroccan Dirham",
            "MDL: Moldovan Leu",
            "MGA: Malagasy Ariary",
            "MKD: Macedonian Denar",
            "MMK: Myanma Kyat",
            "MNT: Mongolian Tugrik",
            "MOP: Macanese Pataca",
            "MRO: Mauritanian Ouguiya",
            "MUR: Mauritian Rupee",
            "MVR: Maldivian Rufiyaa",
            "MWK: Malawian Kwacha",
            "MXN: Mexican Peso",
            "MYR: Malaysian Ringgit",
            "MZN: Mozambican Metical",
            "NAD: Namibian Dollar",
            "NGN: Nigerian Naira",
            "NIO: Nicaraguan C\\u00f3rdoba",
            "NOK: Norwegian Krone",
            "NPR: Nepalese Rupee",
            "NZD: New Zealand Dollar",
            "OMR: Omani Rial",
            "PAB: Panamanian Balboa",
            "PEN: Peruvian Nuevo Sol",
            "PGK: Papua New Guinean Kina",
            "PHP: Philippine Peso",
            "PKR: Pakistani Rupee",
            "PLN: Polish Zloty",
            "PYG: Paraguayan Guarani",
            "QAR: Qatari Rial",
            "RON: Romanian Leu",
            "RSD: Serbian Dinar",
            "RUB: Russian Ruble",
            "RWF: Rwandan Franc",
            "SAR: Saudi Riyal",
            "SBD: Solomon Islands Dollar",
            "SCR: Seychellois Rupee",
            "SDG: Sudanese Pound",
            "SEK: Swedish Krona",
            "SGD: Singapore Dollar",
            "SHP: Saint Helena Pound",
            "SLL: Sierra Leonean Leone",
            "SOS: Somali Shilling",
            "SRD: Surinamese Dollar",
            "STD: S\\u00e3o Tom\\u00e9 and Pr\\u00edncipe Dobra",
            "SVC: Salvadoran Col\\u00f3n",
            "SYP: Syrian Pound",
            "SZL: Swazi Lilangeni",
            "THB: Thai Baht",
            "TJS: Tajikistani Somoni",
            "TMT: Turkmenistani Manat",
            "TND: Tunisian Dinar",
            "TOP: Tongan Pa\\u02bbanga",
            "TRY: Turkish Lira",
            "TTD: Trinidad and Tobago Dollar",
            "TWD: New Taiwan Dollar",
            "TZS: Tanzanian Shilling",
            "UAH: Ukrainian Hryvnia",
            "UGX: Ugandan Shilling",
            "UYU: Uruguayan Peso",
            "UZS: Uzbekistan Som",
            "VEF: Venezuelan Bol\\u00edvar Fuerte",
            "VND: Vietnamese Dong",
            "VUV: Vanuatu Vatu",
            "WST: Samoan Tala",
            "XAF: CFA Franc BEAC",
            "XAG: Silver (troy ounce)",
            "XAU: Gold (troy ounce)",
            "XCD: East Caribbean Dollar",
            "XDR: Special Drawing Rights",
            "XOF: CFA Franc BCEAO",
            "XPF: CFP Franc",
            "YER: Yemeni Rial",
            "ZAR: South African Rand",
            "ZMK: Zambian Kwacha (pre-2013)",
            "ZMW: Zambian Kwacha",
            "ZWL: Zimbabwean Dollar"});
            this.cbFrom.Location = new System.Drawing.Point(57, 328);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(271, 33);
            this.cbFrom.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(102, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Currency From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(370, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount";
            // 
            // btnconvert
            // 
            this.btnconvert.Location = new System.Drawing.Point(287, 414);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(271, 65);
            this.btnconvert.TabIndex = 9;
            this.btnconvert.Text = "Convert";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblcur);
            this.groupBox1.Controls.Add(this.lblresult);
            this.groupBox1.Location = new System.Drawing.Point(173, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 128);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // lblcur
            // 
            this.lblcur.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcur.Location = new System.Drawing.Point(28, 26);
            this.lblcur.Name = "lblcur";
            this.lblcur.Size = new System.Drawing.Size(462, 39);
            this.lblcur.TabIndex = 1;
            this.lblcur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblresult
            // 
            this.lblresult.Font = new System.Drawing.Font("Montserrat ExtraBold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblresult.Location = new System.Drawing.Point(27, 74);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(462, 39);
            this.lblresult.TabIndex = 0;
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmount.Location = new System.Drawing.Point(287, 193);
            this.txtAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(271, 34);
            this.txtAmount.TabIndex = 12;
            this.txtAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 658);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnconvert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "App Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbTo;
        private ComboBox cbFrom;
        private Label label3;
        private Label label4;
        private Button btnconvert;
        private GroupBox groupBox1;
        private Label lblresult;
        private Label lblcur;
        private NumericUpDown txtAmount;
    }
}