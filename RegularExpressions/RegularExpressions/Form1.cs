using System;
using System.Text.RegularExpressions; //Regular expressions için gerekli olan kütüphane
using System.Windows.Forms;

namespace RegularExpressions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region ^ Operatörü
            // ^Operatörü: Satır Başına istenilen ifade ile başlanmasını sağlar.

            //^9 ifadesi ne olursa olsun metin 9 la başlamalı. 9'12512,9asabdsad, 923'sjsj hepsi geçerli sayılır.

            //string metin = "90asd,!'âdas9122";
            //Regex regex = new Regex("^91"); //buraya verilecek metin kesinlikle 9 ile başlamalı yoksa onay vermez.
            //Match match = regex.Match(metin); //metini çek eder pattern a uygun mu değil mi diye ve dönüş tipi match dir.

            //MessageBox.Show(match.Success.ToString()); //duruma göre true veya false döner. 
            #endregion

            #region \ Operatörü
            // \ Operatörü :Belirli karakter gruplarını içermesini istiyorsak kullanırız. 
            //\D :Metinsel değerin ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiği belirtilir.
            //\d : Metinsel değerin ilgili yerinde 0-9 arasında tek bir sayı olacağı ifade edilir.

            //\W :Metinsel değerin ilgili yerinde alfanumerik olmayan karakterin olması gerektiği belirtilir.
            //\w : Metinsel değerin ilgili yerinde alfanumerik olan karakterin olacağı ifade edilir. 
            //     Alfanumerik karakterler->a-z A-Z 0-9

            //\S : Metinsel değerin ilgili yerinde boşluk(Tab- space) karakterleri olmayacağını belirtir.
            //\s : Metinsel değerin ilgili yerinde boşluk karakteri olacağını belirtir.

            //NOTT: büyük harfler olumsuzluğu ifade ederken küçük harfler olumlu ifadeler kullanır.

            //Ornek: 9 ile başlayan, ikinci karakteri herhangi bir sayı olan ve sonraki karakteri de boşluk olmayan
            //       bir düzenli ifade oluşturun.
            //       ^9\d\S

            //string text = "91asss";
            //Regex regex2 = new Regex(@"^9\d\S$");
            //Match match2 = regex2.Match(text);

            //MessageBox.Show(match2.Success.ToString()); //duruma göre true veya false döner. 



            #endregion

            #region + Operatörü
            //Belirtilen gruptaki karakterlerden bi ya da daha fazlasının olmasını istiyorsak kullanılan operatör.
            //Ornek: 9 ile başlayan, arada herhangi bir sayısal değerleri olan ve son karakteri de boşluk olmayan
            //       bir düzenli ifade oluşturun.
            //       ^9\d+\S   //\d+ 2.karakter kesin sayı olmalı sonrasında da sayılar olabilir.

            //string text = "95 678klkö";
            //Regex regex2 = new Regex(@"^9\d+\S");
            //Match match2 = regex2.Match(text);

            //MessageBox.Show(match2.Success.ToString()); //duruma göre true veya false döner. 


            #endregion

            #region | Operatörü

            //Birden fazla karakter grubundan bir ya da birkaçının ilgili yerde olabileceğini belirtmek istiyorsak
            //mantıksal veya operatörü kullanılır.

            //Örnek :Baş harfi a ya da b ya da c olan metinsel ifadeyi girelim. (a|b|c)

            //string text = "a5678klkö";
            //Regex regex2 = new Regex(@"^(a|b|c)");
            //Match match2 = regex2.Match(text);
            //MessageBox.Show(match2.Success.ToString());

            #endregion

            #region {n} Operatörü
            // Sabit sayıda karakterin olması isteniyorsa {adet} şeklinde belirtilmeli.


            //507-7514592 
            //\d\d\d-\d\d\d\d\d\d
            //\d{3}-\d{7}


            //string text = "507-7514592";
            //Regex regex2 = new Regex(@"\d{3}-\d{7}");
            //Match match2 = regex2.Match(text);
            //MessageBox.Show(match2.Success.ToString());


            #endregion

            #region ? Operatörü
            //Bu karakterin önüne gelen karakter en fazla bir en az sıfır defa olabilmektedir.

            // \d{3}B?A----->234BA(True) ,543BA(True),543A(True), 123BBA(False)

            //string text = "543BBA";
            //Regex regex2 = new Regex(@"\d{3}B?A");
            //Match match2 = regex2.Match(text);
            //MessageBox.Show(match2.Success.ToString());


            #endregion

            #region . Operatörü

            // Kullanıldığı yerde \n dışında bütün karakterler olabilir.

            //Örnek ->\d{3}.A (3 adet rakam sonra istenilen karakter son olarakda A olmalı.)
            /*
            string text = "123oA";
            Regex regex2 = new Regex(@"\d{3}.A");
            Match match2 = regex2.Match(text);
            MessageBox.Show(match2.Success.ToString());
            */
            #endregion

            #region \b \B Operatörü
            // \B: Bu ifade ile kelimenin başında ya da sonunda olmaması gereken karakterler bildirirlir.(ilk ve son karaktere bakılır)
            // \b: Bu ifade ilgili kelimenin belirtilen karakterler dizisi ile sonlanmasını sağlar.(son karaktere bakılır.)

            // \d{3}dır\B (Başı ve sonu dır ile bitmememli)

            //string text = "123dır";
            //Regex regex2 = new Regex(@"\d{3}dır\B");
            //Match match2 = regex2.Match(text);
            //MessageBox.Show(match2.Success.ToString());

            #endregion

            #region [n] Operatörü

            //karakter aralığı belirtilebilir ya da özel karakterlerin yerinde yazılmasını belirtebilir.


            //Örnek-> \d{3}[A-E]
            //Örnek->  (507) 123 32 23 

            //[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}

            //string text = "(535) 447 98 32";
            //Regex regex2 = new Regex(@"[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}");
            //Match match2 = regex2.Match(text);
            //MessageBox.Show(match2.Success.ToString());
            #endregion

            //Sadece Harf
            //string text = "dEneMe";
            //Regex regex2 = new Regex(@"^[a-zA-Z]*$");
            //Match match2 = regex2.Match(text);
            //MessageBox.Show(match2.Success.ToString());

            //Sadece Rakam(tc)
            //string text = "02662131711";
            //Regex regex2 = new Regex(@"^[1-9][0-9]{10}$");
            //Match match2 = regex2.Match(text);
            //MessageBox.Show(match2.Success.ToString());


            //value,length,Index
            //Match m = Regex.Match("123 Axxxxy", @"A.*y");
            //if (m.Success)
            //{
            //    MessageBox.Show("Value  = " + m.Value);
            //    MessageBox.Show("Length = " + m.Length);
            //    MessageBox.Show("Index  = " + m.Index);
            //}

        }

        private void BtnGec_Click(object sender, EventArgs e)
        {
            FormOrnek f = new FormOrnek();
            f.Show();
        }



    }
}

