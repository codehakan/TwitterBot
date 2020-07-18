using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterBot
{
    public partial class Form1 : Form
    {
        IWebDriver driver;
        private static int sayac;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            sayac = 1;
        }

        public async void GirisYap()
        {
            ChromeDriverService cds = ChromeDriverService.CreateDefaultService();
            cds.HideCommandPromptWindow = true;
            driver = new ChromeDriver(cds);
            driver.Navigate().GoToUrl("https://twitter.com/login");
            await Task.Delay(2000);
            IWebElement kullaniciAdi = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-13qz1uu.r-417010 > main > div > div > form > div > div:nth-child(6) > label > div > div.css-1dbjc4n.r-18u37iz.r-16y2uox.r-1wbh5a2.r-1udh08x > div > input"));
            kullaniciAdi.SendKeys(txt_mail.Text);
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='code.harika@gmail.com';", kullaniciAdi);
            await Task.Delay(1000);
            IWebElement kullaniciSifre = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-13qz1uu.r-417010 > main > div > div > form > div > div:nth-child(7) > label > div > div.css-1dbjc4n.r-18u37iz.r-16y2uox.r-1wbh5a2.r-1udh08x > div > input"));
            kullaniciSifre.SendKeys(txt_sifre.Text);
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value='1530740789';", kullaniciSifre);
            await Task.Delay(1000);
            IWebElement girisButton = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-13qz1uu.r-417010 > main > div > div > form > div > div:nth-child(8) > div"));
            girisButton.Click();
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", girisButton);
            await Task.Delay(5000);
            kesfeteTikla();
        }

        private async void kesfeteTikla()
        {
            IWebElement kesfeteTikla = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-18u37iz.r-13qz1uu.r-417010 > header > div > div > div > div.css-1dbjc4n.r-1habvwh > div.css-1dbjc4n.r-d0pm55.r-1bymd8e.r-13qz1uu > nav > a:nth-child(2)"));
            kesfeteTikla.Click();
            await Task.Delay(3000);
            ilkHashTageTikla();
        }

        private async void ilkHashTageTikla()
        {
            IWebElement hashTageTikla = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-18u37iz.r-13qz1uu.r-417010 > main > div > div > div > div.css-1dbjc4n.r-yfoy6g.r-18bvks7.r-1ljd8xs.r-13l2t4g.r-1phboty.r-1jgb5lz.r-11wrixw.r-61z16t.r-1ye8kvj.r-13qz1uu.r-184en5c > div > div.css-1dbjc4n.r-1jgb5lz.r-1ye8kvj.r-13qz1uu > div > div > section > div > div > div:nth-child(5) > div > div"));
            hashTageTikla.Click();
            await Task.Delay(3000);
            ilkTweeteYorumYapTikla();
        }

        private async void ilkTweeteYorumYapTikla()
        {
            IWebElement yorumYapTikla = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-18u37iz.r-13qz1uu.r-417010 > main > div > div > div > div.css-1dbjc4n.r-yfoy6g.r-18bvks7.r-1ljd8xs.r-13l2t4g.r-1phboty.r-1jgb5lz.r-11wrixw.r-61z16t.r-1ye8kvj.r-13qz1uu.r-184en5c > div > div:nth-child(2) > div > div > section > div > div > div:nth-child(1) > div > div > article > div > div > div > div.css-1dbjc4n.r-18u37iz > div.css-1dbjc4n.r-1iusvr4.r-16y2uox.r-1777fci.r-1mi0q7o > div:nth-child(2) > div.css-1dbjc4n.r-18u37iz.r-1wtj0ep.r-156q2ks.r-1mdbhws > div:nth-child(1) > div > div"));
            yorumYapTikla.Click();
            await Task.Delay(2000);
            mesajiYaz();
        }

        private async void ikinciTweeteYorumYapTikla()
        {
            IWebElement yorumYapTikla = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-18u37iz.r-13qz1uu.r-417010 > main > div > div > div > div > div > div:nth-child(2) > div > div > section > div > div > div:nth-child(2) > div > div > article > div > div > div > div.css-1dbjc4n.r-18u37iz > div.css-1dbjc4n.r-1iusvr4.r-16y2uox.r-1777fci.r-1mi0q7o > div:nth-child(2) > div.css-1dbjc4n.r-18u37iz.r-1wtj0ep.r-156q2ks.r-1mdbhws > div:nth-child(1) > div"));
            yorumYapTikla.Click();
            await Task.Delay(3000);
            mesajiYaz();
        }

        private async void ucuncuTweeteYorumYapTikla()
        {
            IWebElement yorumYapTikla = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-18u37iz.r-13qz1uu.r-417010 > main > div > div > div > div.css-1dbjc4n.r-yfoy6g.r-18bvks7.r-1ljd8xs.r-13l2t4g.r-1phboty.r-1jgb5lz.r-11wrixw.r-61z16t.r-1ye8kvj.r-13qz1uu.r-184en5c > div > div:nth-child(2) > div > div > section > div > div > div:nth-child(3) > div > div > article > div > div > div > div.css-1dbjc4n.r-18u37iz > div.css-1dbjc4n.r-1iusvr4.r-16y2uox.r-1777fci.r-1mi0q7o > div:nth-child(2) > div.css-1dbjc4n.r-18u37iz.r-1wtj0ep.r-156q2ks.r-1mdbhws > div:nth-child(1) > div > div"));
            yorumYapTikla.Click();
            await Task.Delay(3000);
            mesajiYaz();
        }

        private async void dorduncuTweeteYorumYapTikla()
        {
            IWebElement yorumYapTikla = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-18u37iz.r-13qz1uu.r-417010 > main > div > div > div > div.css-1dbjc4n.r-yfoy6g.r-18bvks7.r-1ljd8xs.r-13l2t4g.r-1phboty.r-1jgb5lz.r-11wrixw.r-61z16t.r-1ye8kvj.r-13qz1uu.r-184en5c > div > div:nth-child(2) > div > div > section > div > div > div:nth-child(2) > div > div > article > div > div > div > div.css-1dbjc4n.r-18u37iz > div.css-1dbjc4n.r-1iusvr4.r-16y2uox.r-1777fci.r-1mi0q7o > div:nth-child(2) > div.css-1dbjc4n.r-18u37iz.r-1wtj0ep.r-156q2ks.r-1mdbhws > div:nth-child(1) > div > div"));
            yorumYapTikla.Click();
            await Task.Delay(3000);
            mesajiYaz();
        }
        private async void besinciTweeteYorumYapTikla()
        {
            IWebElement yorumYapTikla = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-18u37iz.r-13qz1uu.r-417010 > main > div > div > div > div.css-1dbjc4n.r-yfoy6g.r-18bvks7.r-1ljd8xs.r-13l2t4g.r-1phboty.r-1jgb5lz.r-11wrixw.r-61z16t.r-1ye8kvj.r-13qz1uu.r-184en5c > div > div:nth-child(2) > div > div > section > div > div > div:nth-child(10) > div > div > article > div > div > div > div.css-1dbjc4n.r-18u37iz > div.css-1dbjc4n.r-1iusvr4.r-16y2uox.r-1777fci.r-1mi0q7o > div:nth-child(2) > div.css-1dbjc4n.r-18u37iz.r-1wtj0ep.r-156q2ks.r-1mdbhws > div:nth-child(1) > div > div"));
            yorumYapTikla.Click();
            await Task.Delay(3000);
            mesajiYaz();
        }
        private async void altinciTweeteYorumYapTikla()
        {
            IWebElement yorumYapTikla = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-18u37iz.r-13qz1uu.r-417010 > main > div > div > div > div.css-1dbjc4n.r-yfoy6g.r-18bvks7.r-1ljd8xs.r-13l2t4g.r-1phboty.r-1jgb5lz.r-11wrixw.r-61z16t.r-1ye8kvj.r-13qz1uu.r-184en5c > div > div:nth-child(2) > div > div > section > div > div > div:nth-child(4) > div > div > article > div > div > div > div.css-1dbjc4n.r-18u37iz > div.css-1dbjc4n.r-1iusvr4.r-16y2uox.r-1777fci.r-1mi0q7o > div:nth-child(2) > div.css-1dbjc4n.r-18u37iz.r-1wtj0ep.r-156q2ks.r-1mdbhws > div:nth-child(1) > div > div"));
            yorumYapTikla.Click();
            await Task.Delay(3000);
            mesajiYaz();
        }
        private async void yedinciTweeteYorumYapTikla()
        {
            IWebElement yorumYapTikla = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-18u37iz.r-13qz1uu.r-417010 > main > div > div > div > div.css-1dbjc4n.r-yfoy6g.r-18bvks7.r-1ljd8xs.r-13l2t4g.r-1phboty.r-1jgb5lz.r-11wrixw.r-61z16t.r-1ye8kvj.r-13qz1uu.r-184en5c > div > div:nth-child(2) > div > div > section > div > div > div:nth-child(5) > div > div > article > div > div > div > div.css-1dbjc4n.r-18u37iz > div.css-1dbjc4n.r-1iusvr4.r-16y2uox.r-1777fci.r-1mi0q7o > div:nth-child(2) > div.css-1dbjc4n.r-18u37iz.r-1wtj0ep.r-156q2ks.r-1mdbhws > div:nth-child(1) > div > div"));
            yorumYapTikla.Click();
            await Task.Delay(3000);
            mesajiYaz();
        }
        private async void sekizinciTweeteYorumYapTikla()
        {
            IWebElement yorumYapTikla = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-18u37iz.r-13qz1uu.r-417010 > main > div > div > div > div.css-1dbjc4n.r-yfoy6g.r-18bvks7.r-1ljd8xs.r-13l2t4g.r-1phboty.r-1jgb5lz.r-11wrixw.r-61z16t.r-1ye8kvj.r-13qz1uu.r-184en5c > div > div:nth-child(2) > div > div > section > div > div > div:nth-child(3) > div > div > article > div > div > div > div.css-1dbjc4n.r-18u37iz > div.css-1dbjc4n.r-1iusvr4.r-16y2uox.r-1777fci.r-1mi0q7o > div:nth-child(2) > div.css-1dbjc4n.r-18u37iz.r-1wtj0ep.r-156q2ks.r-1mdbhws > div:nth-child(1) > div > div"));
            yorumYapTikla.Click();
            await Task.Delay(3000);
            mesajiYaz();
        }
        private async void dokuzuncuTweeteYorumYapTikla()
        {
            IWebElement yorumYapTikla = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-18u37iz.r-13qz1uu.r-417010 > main > div > div > div > div.css-1dbjc4n.r-yfoy6g.r-18bvks7.r-1ljd8xs.r-13l2t4g.r-1phboty.r-1jgb5lz.r-11wrixw.r-61z16t.r-1ye8kvj.r-13qz1uu.r-184en5c > div > div:nth-child(2) > div > div > section > div > div > div:nth-child(3) > div > div > article > div > div > div > div.css-1dbjc4n.r-18u37iz > div.css-1dbjc4n.r-1iusvr4.r-16y2uox.r-1777fci.r-1mi0q7o > div:nth-child(2) > div.css-1dbjc4n.r-18u37iz.r-1wtj0ep.r-156q2ks.r-1mdbhws > div:nth-child(1) > div > div"));
            yorumYapTikla.Click();
            await Task.Delay(3000);
            mesajiYaz();
        }
        private async void onuncuTweeteYorumYapTikla()
        {
            IWebElement yorumYapTikla = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-18u37iz.r-13qz1uu.r-417010 > main > div > div > div > div.css-1dbjc4n.r-yfoy6g.r-18bvks7.r-1ljd8xs.r-13l2t4g.r-1phboty.r-1jgb5lz.r-11wrixw.r-61z16t.r-1ye8kvj.r-13qz1uu.r-184en5c > div > div:nth-child(2) > div > div > section > div > div > div:nth-child(4) > div > div > article > div > div > div > div.css-1dbjc4n.r-18u37iz > div.css-1dbjc4n.r-1iusvr4.r-16y2uox.r-1777fci.r-1mi0q7o > div:nth-child(2) > div.css-1dbjc4n.r-18u37iz.r-1wtj0ep.r-156q2ks.r-1mdbhws > div:nth-child(1) > div > div"));
            yorumYapTikla.Click();
            await Task.Delay(3000);
            mesajiYaz();
        }

        private async void mesajiYaz()
        {
            Random rnd = new Random();
            IWebElement mesajiYaz = driver.FindElement(By.CssSelector("#react-root > div > div > div.r-1d2f490.r-u8s1d.r-zchlnj.r-ipm5af.r-184en5c > div:nth-child(2) > div > div > div > div > div > div.css-1dbjc4n.r-1habvwh.r-18u37iz.r-1pi2tsx.r-1777fci.r-1xcajam.r-ipm5af.r-g6jmlv > div.css-1dbjc4n.r-1ylenci.r-1wbh5a2.r-rsyp9y.r-1pjcn9w.r-htvplk.r-1udh08x.r-1potc6q > div > div.css-1dbjc4n.r-16y2uox.r-1wbh5a2.r-1jgb5lz.r-1ye8kvj.r-13qz1uu > div > div > div > div:nth-child(2) > div > div > div > div > div.css-1dbjc4n.r-1iusvr4.r-16y2uox.r-1777fci.r-1bylmt5.r-13tjlyg.r-7qyjyx.r-1ftll1t > div.css-1dbjc4n.r-184en5c > div > div > div > div > div > div > div > div > div > div.css-901oao.r-jwli3a.r-6koalj.r-16y2uox.r-1qd0xha.r-1b6yd1w.r-16dba41.r-ad9z0x.r-bcqeeo.r-qvutc0 > div > div > div > div.DraftEditor-editorContainer > div"));
            mesajiYaz.SendKeys(richTextBox1.Text + rnd.Next(0, 10));
            await Task.Delay(3000);
            mesajiGonder();
        }

        private async void mesajiGonder()
        {
            IWebElement mesajiGonderButton = driver.FindElement(By.CssSelector("#react-root > div > div > div.r-1d2f490.r-u8s1d.r-zchlnj.r-ipm5af.r-184en5c > div:nth-child(2) > div > div > div > div > div > div.css-1dbjc4n.r-1habvwh.r-18u37iz.r-1pi2tsx.r-1777fci.r-1xcajam.r-ipm5af.r-g6jmlv > div.css-1dbjc4n.r-1ylenci.r-1wbh5a2.r-rsyp9y.r-1pjcn9w.r-htvplk.r-1udh08x.r-1potc6q > div > div.css-1dbjc4n.r-16y2uox.r-1wbh5a2.r-1jgb5lz.r-1ye8kvj.r-13qz1uu > div > div > div > div:nth-child(2) > div > div > div > div > div.css-1dbjc4n.r-1iusvr4.r-16y2uox.r-1777fci.r-1bylmt5.r-13tjlyg.r-7qyjyx.r-1ftll1t > div:nth-child(2) > div > div > div:nth-child(2) > div.css-18t94o4.css-1dbjc4n.r-urgr8i.r-42olwf.r-sdzlij.r-1phboty.r-rs99b7.r-1w2pmg.r-1n0xq6e.r-1vuscfd.r-1dhvaqw.r-1ny4l3l.r-1fneopy.r-o7ynqc.r-6416eg.r-lrvibr"));
            mesajiGonderButton.Click();
            sayac += 1;
            await Task.Delay(3000);
            if (txt_tweet_sayisi.Value >= sayac)
            {
                IWebElement kesfeteTikla = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-18u37iz.r-13qz1uu.r-417010 > header > div > div > div > div.css-1dbjc4n.r-1habvwh > div.css-1dbjc4n.r-d0pm55.r-1bymd8e.r-13qz1uu > nav > a:nth-child(2)"));
                kesfeteTikla.Click();
                await Task.Delay(3000);
                IWebElement hashTageTikla = driver.FindElement(By.CssSelector("#react-root > div > div > div.css-1dbjc4n.r-18u37iz.r-13qz1uu.r-417010 > main > div > div > div > div.css-1dbjc4n.r-yfoy6g.r-18bvks7.r-1ljd8xs.r-13l2t4g.r-1phboty.r-1jgb5lz.r-11wrixw.r-61z16t.r-1ye8kvj.r-13qz1uu.r-184en5c > div > div.css-1dbjc4n.r-1jgb5lz.r-1ye8kvj.r-13qz1uu > div > div > section > div > div > div:nth-child(5) > div > div"));
                hashTageTikla.Click();
                await Task.Delay(3000);

                if (sayac == 2)
                {
                    ikinciTweeteYorumYapTikla();
                }
                else if (sayac == 3)
                {
                    ucuncuTweeteYorumYapTikla();
                }
                else if (sayac == 4)
                {
                    dorduncuTweeteYorumYapTikla();
                }
                else if (sayac == 5)
                {
                    besinciTweeteYorumYapTikla();
                }
                else if (sayac == 6)
                {
                    altinciTweeteYorumYapTikla();
                }
                else if (sayac == 7)
                {
                    yedinciTweeteYorumYapTikla();
                }
                else if (sayac == 8)
                {
                    sekizinciTweeteYorumYapTikla();
                }
                else if (sayac == 9)
                {
                    dokuzuncuTweeteYorumYapTikla();
                }
                else if (sayac == 10)
                {
                    onuncuTweeteYorumYapTikla();
                }
            }
            else
            {
                MessageBox.Show("İşlem Tamamlandı!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirisYap();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Kalan Karakter Sayısı: " + Convert.ToInt32(richTextBox1.MaxLength - richTextBox1.TextLength);
        }
    }
}
