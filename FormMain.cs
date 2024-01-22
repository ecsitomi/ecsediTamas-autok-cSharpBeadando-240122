using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //Betöltéskor mit tegyen
        private void FormMain_Load(object sender, EventArgs e)
        {
            listBox_Autok.Items.Clear(); //lista törlése
            selectAuto(); // az adatbázis autóit letöltöm egy listába és a listboxban megjelenítem
        }
        private void selectAuto() //listázza ki az autókat
        {
            List<Auto> autok = Program.db.selectAuto();
            listBox_Autok.DataSource = autok;
            listBox_Autok.DisplayMember = "AutoKiirasa"; //Auto osztályból hivatkozok rá, hogy mi jelenjen meg
        }

        //Listboxban kiválasztás és Groupbox frissítése
        private void listBox_Autok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Auto kivalasztottAuto = (Auto)listBox_Autok.SelectedItem; //kattintott autó adatait behozza
            groupBoxFrissitese(kivalasztottAuto); //itt viszi át a groupboxba
        }
        private void groupBoxFrissitese(Auto kivalasztottAuto)
        {
            textBox_rendszam.Text = kivalasztottAuto.Rendszam; //gyakorlatilag itt fordítás történik
            textBox_marka.Text = kivalasztottAuto.Marka;
            textBox_modell.Text = kivalasztottAuto.Modell;
            textBox_gyartas.Text = kivalasztottAuto.GyartasiEv.ToString();
            textBox_vetelar.Text = kivalasztottAuto.VetelAr.ToString();
            textBox_km.Text = kivalasztottAuto.KmAllas.ToString();
            textBox_henger.Text = kivalasztottAuto.Hengerurtartalom.ToString();
            textBox_tomeg.Text = kivalasztottAuto.Tomeg.ToString();
            textBox_teljesitmeny.Text = kivalasztottAuto.Teljesitmeny.ToString();
            dateTimePicker_forgalmi.Value = kivalasztottAuto.ForgalmiErvenyesseg;     
        }
       
        private void adatokTorlese() //Groupbox kiírt adatainak törlése
        {
            dateTimePicker_forgalmi.Value = DateTime.Now;
            textBox_rendszam.Clear();
            textBox_marka.Clear();
            textBox_modell.Clear();
            textBox_gyartas.Clear();
            textBox_vetelar.Clear();
            textBox_km.Clear();
            textBox_henger.Clear();
            textBox_tomeg.Clear();
            textBox_teljesitmeny.Clear();
        }

        private void button_New_Click(object sender, EventArgs e) //ÚJ gombra mit tegyen
        {
            Auto updateAuto = new Auto(textBox_rendszam.Text, textBox_marka.Text, textBox_modell.Text, int.Parse(textBox_gyartas.Text), dateTimePicker_forgalmi.Value, int.Parse(textBox_vetelar.Text), int.Parse(textBox_km.Text), int.Parse(textBox_henger.Text), int.Parse(textBox_tomeg.Text), int.Parse(textBox_teljesitmeny.Text));
            Program.db.insertAuto(updateAuto); //itt történik a módosítás az adatbázis osztályban
            selectAuto(); //frissíti a listát
            adatokTorlese();
        }

        private void button_Edit_Click(object sender, EventArgs e) //MÓDOSÍT gombra mit tegyen
        {
            Auto updateAuto = new Auto(textBox_rendszam.Text, textBox_marka.Text, textBox_modell.Text,int.Parse(textBox_gyartas.Text),dateTimePicker_forgalmi.Value,int.Parse(textBox_vetelar.Text), int.Parse(textBox_km.Text), int.Parse(textBox_henger.Text), int.Parse(textBox_tomeg.Text), int.Parse(textBox_teljesitmeny.Text));
            Program.db.updateAuto(updateAuto); //itt történik a módosítás az adatbázis osztályban
            selectAuto(); //frissíti a listát
            adatokTorlese();
        }

        private void button_Delete_Click(object sender, EventArgs e) //TÖRLÉS gombra mit tegyen
        {
            Auto kivalasztottAuto = (Auto)listBox_Autok.SelectedItem; //hogy a rendszámot beolvassa
            DialogResult result = MessageBox.Show("Biztos, hogy kitörli az autót?", "Figyelmeztetés!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) //legyen egy figyelmeztető üzenet törlés előtt
            {
                Program.db.deleteAuto(kivalasztottAuto); //törlés az adatbázis osztályon keresztül
                selectAuto(); //lista frissítése
            }
        }
    }
}
