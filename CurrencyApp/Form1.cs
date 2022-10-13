using Newtonsoft.Json.Linq;
using RestSharp;
using System.Globalization;
using System.Net;

namespace CurrencyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if(cbTo.Text == "" || cbFrom.Text == "")
            {
                MessageBox.Show("Select a Currency Pair", "Alert", MessageBoxButtons.OK);
            }
            else
            {
                btnconvert.Text = "Processing...";
                btnconvert.Enabled = false;

                char[] seprator = { ':', ' ' };

                string[] toCur = cbTo.Text.Split(seprator, 2, StringSplitOptions.None);

                string[] fromCur = cbFrom.Text.Split(seprator, 2, StringSplitOptions.None);


                if (!CheckForInternetConnection())
                {
                    MessageBox.Show("Check for internet!", "Alert", MessageBoxButtons.OK);
                }
                else
                {
                    var client = new RestClient("https://api.apilayer.com/exchangerates_data/convert?to=" + toCur[0] + "&from=" + fromCur[0] + "&amount=" + txtAmount.Text);


                    var request = new RestRequest();
                    request.AddHeader("apikey", "SHcXpqQps0dqUTZMdwNGrQyvelmcfEzz");


                    RestResponse response = client.Execute(request);



                    var json = JObject.Parse(response.Content);

                    lblcur.Text = txtAmount.Text + " " + cbFrom.Text + " equals to ";
                    lblresult.Text = (string)json["result"] + " " + cbTo.Text;

                }
                

                btnconvert.Text = "Convert";
                btnconvert.Enabled = true;
            }
            



        }


        

        public static bool CheckForInternetConnection(int timeoutMs = 10000, string url = null)
        {
            try
            {
                url ??= CultureInfo.InstalledUICulture switch
                {
                    { Name: var n } when n.StartsWith("fa") => // Iran
                        "http://www.aparat.com",
                    { Name: var n } when n.StartsWith("zh") => // China
                        "http://www.baidu.com",
                    _ =>
                        "http://www.gstatic.com/generate_204",
                };

                var request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.Timeout = timeoutMs;
                using (var response = (HttpWebResponse)request.GetResponse())
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  cbFrom.Text = "Select From Currency...";
          //  cbTo.Text = "Select To Currency...";
        }
    }
}