namespace taşkağıtmakas
{
    public partial class taşkağıtmakas : Form
    {
        public taşkağıtmakas()
        {
            InitializeComponent();
        }

        string bilgisayaryaptığı = "";
         int insanpuan = 0;
         int bilgisayarpuan = 0;



        public void bilgisayar()
        {
            Random r = new Random();
            int secbilgisayar = r.Next(1, 4);
            switch (secbilgisayar)
            {
                case 1:
                    bilgisayaryaptığı = "taş";
                    break;
                case 2:
                    bilgisayaryaptığı = "kağıt";
                    break;
                case 3:
                    bilgisayaryaptığı = "makas";
                    break;
            }

        }
        public void resetmakas()
        {

            bilgisayarmakas.BackColor = Color.White;
            insanmakas.BackColor = Color.White;
            sonuç.Visible = false;
        }
        public void resettaş()
        {

            bilgisayartaş.BackColor = Color.White;
            insantaş.BackColor = Color.White;
            sonuç.Visible = false;
        }
        public void resetkağıt()
        {

            bilgisayarkağıt.BackColor = Color.White;
            insankağıt.BackColor = Color.White;
            sonuç.Visible = false;
        }
      
        public void skor()
        {
            bilgisayarskor.Text = Convert.ToString(bilgisayarpuan);
            insanskor.Text= Convert.ToString(insanpuan);
            

        }



        private void button6_Click(object sender, EventArgs e)
        {
            bilgisayar();
            if (bilgisayaryaptığı == "makas")
            {
                bilgisayarmakas.BackColor = Color.Blue;
                insanmakas.BackColor = Color.Blue;
                sonuç.Visible = true;
                sonuç.Text = "BERBERE";
                insanpuan++;
               
                

            }
            if (bilgisayaryaptığı == "kağıt")
            {

                bilgisayarkağıt.BackColor = Color.Red;
                insanmakas.BackColor = Color.Green;
                sonuç.Visible = true;
                sonuç.Text = "KAZANDINIZ";
                insanpuan++;
                
            }
            if (bilgisayaryaptığı == "taş")
            {

                bilgisayartaş.BackColor = Color.Green;
                insanmakas.BackColor = Color.Red;
                sonuç.Visible = true;
                sonuç.Text = "KAYBETTİNİZ";
                bilgisayarpuan++;

            }
            skor();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void insankağıt_Click(object sender, EventArgs e)
        {
            bilgisayar();
            if (bilgisayaryaptığı == "makas")
            {
                bilgisayarmakas.BackColor = Color.Green;
                insankağıt.BackColor = Color.Red;
                sonuç.Visible = true;
                sonuç.Text = "KAYBETTİNİZ";
                bilgisayarpuan++;
            }
            if (bilgisayaryaptığı == "kağıt")
            {

                bilgisayarkağıt.BackColor = Color.Blue;
                insankağıt.BackColor = Color.Blue;
                sonuç.Visible = true;
                sonuç.Text = "BERABERE";
                insanpuan++;
                bilgisayarpuan++;
            }
            if (bilgisayaryaptığı == "taş")
            {

                bilgisayartaş.BackColor = Color.Red;
                insankağıt.BackColor = Color.Green;
                sonuç.Visible = true;
                sonuç.Text = "KAZANDINIZ";
                insanpuan++;
            }
            skor();
        }

        private void insantaş_Click(object sender, EventArgs e)
        {
            bilgisayar();
            if (bilgisayaryaptığı == "makas")
            {
                bilgisayarmakas.BackColor = Color.Red;
                insantaş.BackColor = Color.Green;
                sonuç.Visible = true;
                sonuç.Text = "KAZANDINIZ";
                insanpuan++;
            }
            if (bilgisayaryaptığı == "kağıt")
            {

                bilgisayarkağıt.BackColor = Color.Green;
                insantaş.BackColor = Color.Red;
                sonuç.Visible = true;
                sonuç.Text = "KAYBETTİNİZ";
                bilgisayarpuan++;
            }
            if (bilgisayaryaptığı == "taş")
            {

                bilgisayartaş.BackColor = Color.Blue;
                insantaş.BackColor = Color.Blue;
                sonuç.Visible = true;
                sonuç.Text = "BERABERE";
                insanpuan++;
                bilgisayarpuan++;

            }
            skor();
        }

        private void reseetbuton_Click(object sender, EventArgs e)
        {
            resetkağıt();
            resetmakas();
            resettaş();
        }
    }
}
