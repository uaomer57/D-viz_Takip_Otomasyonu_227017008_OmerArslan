using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Döviz_Takip_Otomasyonu_227017008_ÖmerArslan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void USD_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            string TCMB_Kur = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var TCMB_xml = new XmlDocument();
            string USDAlış;
            string USDSatış;
            TCMB_xml.Load(TCMB_Kur);
            USDAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexBuying").InnerXml;
            lblusdalıs.Text = USDAlış;
            USDSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexSelling").InnerXml;
            lblusdsatıs.Text = USDSatış;

            string GBPAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexBuying").InnerXml;
            string GBPSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexSelling").InnerXml;
            lblgbpalıs.Text = GBPAlış;
            lblgbpsatıs.Text = GBPSatış;

            string EURAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexBuying").InnerXml;
            string EURDSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexSelling").InnerXml;
            lbleuralıs.Text = EURAlış;
            lbleursatıs.Text = EURDSatış;
            DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string TCMB_Kur = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var TCMB_xml = new XmlDocument();
            string USDAlış;
            string USDSatış;
            TCMB_xml.Load(TCMB_Kur);
            USDAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexBuying").InnerXml;
            lblusdalıs.Text = USDAlış;
            USDSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexSelling").InnerXml;
            lblusdsatıs.Text = USDSatış;

            string GBPAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexBuying").InnerXml;
            string GBPSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexSelling").InnerXml;
            lblgbpalıs.Text = GBPAlış;
            lblgbpsatıs.Text = GBPSatış;

            string EURAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexBuying").InnerXml;
            string EURDSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexSelling").InnerXml;
            lbleuralıs.Text = EURAlış;
            lbleursatıs.Text = EURDSatış;

            DateTime.Now.ToLongDateString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            string TCMB_Kur = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var TCMB_xml = new XmlDocument();
            DateTime.Now.ToLongDateString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            string TCMB_Kur = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var TCMB_xml = new XmlDocument();
            string USDAlış;
            string USDSatış;
            TCMB_xml.Load(TCMB_Kur);
            USDAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexBuying").InnerXml;
            lblusdalıs.Text = USDAlış;
            USDSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexSelling").InnerXml;
            lblusdsatıs.Text = USDSatış;

            string GBPAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexBuying").InnerXml;
            string GBPSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexSelling").InnerXml;
            lblgbpalıs.Text = GBPAlış;
            lblgbpsatıs.Text = GBPSatış;

            string EURAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexBuying").InnerXml;
            string EURDSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexSelling").InnerXml;
            lbleuralıs.Text = EURAlış;
            lbleursatıs.Text = EURDSatış;

        }
    }
}
