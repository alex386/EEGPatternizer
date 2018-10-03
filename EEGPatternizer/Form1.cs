/*===============================================*/
/* Program name: EEGPattternizer                 */
/* Author: Aleksander Dawid                      */
/* Organization: WSB Academy                     */
/*===============================================*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MathNet.Numerics.IntegralTransforms;
using System.Numerics;
using System.IO;
using System.Drawing.Imaging;


namespace EEGPatternizer
{
    public partial class Form1 : Form
    {      
        //---------------------------------------------------------------------------
        //  Global data
        //--------------------------------------------------------------------------
        const int SignalSize = 512;
      
        const double dt = 512;
        double skala = 2;
        int delT = 5;
        double h0, h1, h2, h3;
        double g0, g1, g2, g3;
        double s0, s1;
        double d0, d1;

        int Factor_FFT = 5000;
        double Factor_DWT = 1.0;
       
        StringBuilder sb, mb, ab;

        Color transColor;
        Point lpt_raw, lpt_fft, lpt_dwt, lpt_d4, lpt_psrt;
        int colorPS,colorVR;

        List<Point> pt_raw = new List<Point>();
        List<Point> pt_fft = new List<Point>();
        List<Point> pt_dwt = new List<Point>();
        List<Point> pt_d4 = new List<Point>();
        List<Point> phase = new List<Point>();
        List<Point> pts = new List<Point>();
        

        List<Point> phasC = new List<Point>();
        List<int> colphase = new List<int>();
        List<int> lColorVR = new List<int>();

        List<int> fdata = new List<int>();
        List<string> fdatas = new List<string>();

        Complex[] samples = new Complex[SignalSize];
        double[] signal = new double[SignalSize];
        double[] signal_prim = new double[SignalSize]; 
        double[] signaldwt = new double[SignalSize];
        double[] signald4 = new double[SignalSize];
        const int ImgW = 128; //Width of Image
        const int ImgH = 128; //Height of Image

        Pen p;
        Bitmap b_raw, b_fft, b_dwt, b_d4, b_psrt, b_psrtc, b_psrd, b_psrdc;
        bool bSave;


        public void Init_Haar_and_Daubechies()
        {
            h0 = (1.0 + Math.Sqrt(3.0)) / (4.0 * Math.Sqrt(2.0));
            h1 = (3.0 + Math.Sqrt(3.0)) / (4.0 * Math.Sqrt(2.0));
            h2 = (3.0 - Math.Sqrt(3.0)) / (4.0 * Math.Sqrt(2.0));
            h3 = (1.0 - Math.Sqrt(3.0)) / (4.0 * Math.Sqrt(2.0));
            g0 = h3;
            g1 = -h2;
            g2 = h1;
            g3 = -h0;

            s0 = s1 = d0 = d1 = 1.0 / Math.Sqrt(2);
        }

      

        public Form1()        
        {
            
            InitializeComponent();
           
            b_fft = new Bitmap(ImgW, ImgH);
            b_dwt = new Bitmap(ImgW*2, ImgH);
            b_d4 = new Bitmap(ImgW*2, ImgH);
            b_raw = new Bitmap(ImgW*4, ImgH);
            b_psrd = new Bitmap(ImgW, ImgH);
            b_psrdc = new Bitmap(ImgW, ImgH);
            b_psrt = new Bitmap(ImgW, ImgH);
            b_psrtc = new Bitmap(ImgW, ImgH);
          
            sb = new StringBuilder();
            mb = new StringBuilder();
            ab = new StringBuilder();            
            transColor = Color.White;
            bSave = false;
            Init_Haar_and_Daubechies();

        }


        public void DWT_Haar(double[] input, int len)
        {
            double[] tmp = new double[len];
            int h = len >> 1;
            int k;
            for (int i = 0; i < h; i++)
            {
                k = 2 * i;
                tmp[i] = input[k] * s0 + input[k + 1] * s1;
                tmp[i + h] = input[k] * d0 - input[k + 1] * d1;
            }


            for (int i = 0; i < tmp.Length; i++)
            {
                input[i] = tmp[i];
            }

            if (h > 1)
            { //Recurencial procedure need to be change to iteration procedure
                DWT_Haar(input, h);
            }
        }

        public void DWT_Daubechies(double[] input, int n)
        {
            if (n >= 4)
            {
                int i, j;
                int half = n >> 1;
                double[] tmp = new double[n];
                i = 0;
                for (j = 0; j < n - 3; j = j + 2)
                {
                    tmp[i] = input[j] * h0 + input[j + 1] * h1 + input[j + 2] * h2 + input[j + 3] * h3;
                    tmp[i + half] = input[j] * g0 + input[j + 1] * g1 + input[j + 2] * g2 + input[j + 3] * g3;
                    i++;
                }

                tmp[i] = input[n - 2] * h0 + input[n - 1] * h1 + input[0] * h2 + input[1] * h3;
                tmp[i + half] = input[n - 2] * g0 + input[n - 1] * g1 + input[0] * g2 + input[1] * g3;

                for (i = 0; i < n; i++)
                {
                    input[i] = tmp[i];
                }
            }
        } // transform

        //==============================================================================================
        private void CalculateTransform(int SigSize)
        {
            int cs_fft,cs_dwt,cs_raw,cs_d4;
            double s_fft,s_dwt,s_raw,s_d4;
            int half = SigSize >> 1;
            
            for (int l = 0; l < SigSize; l++)
            {
                samples[l] = new Complex(fdata[l], 0);
                signaldwt[l] = fdata[l];
                signald4[l] = fdata[l];
            }
           
           
            signal_prim[0] = 0;
            for (int k = 0; k < SigSize - 1; k++)
            {
                signal_prim[k + 1] = (fdata[k + 1] - fdata[k]) * dt;
            }
           
            double norm1,norm2;
            if (checkFFT.Checked)
            {
                Fourier.Forward(samples, FourierOptions.NumericalRecipes);                
            }
            norm1 = samples[0].Real * samples[0].Real;

            if (checkDWT.Checked)
                DWT_Haar(signaldwt, signaldwt.Length);
            if (checkD4.Checked)
                DWT_Daubechies(signald4, signald4.Length);
            norm2 = signaldwt[0];// * signaldwt[0];
            

            pt_raw.Clear();
            pt_fft.Clear();
            pt_dwt.Clear();
            pt_d4.Clear();
            phase.Clear();
            phasC.Clear();
            colphase.Clear();
            lColorVR.Clear();

           for (int l = 0; l < SigSize; l++)
            {
                lpt_raw.X = lpt_fft.X = lpt_dwt.X = lpt_d4.X = l;
               
                    s_raw = Convert.ToDouble(fdata[l]) * 0.25;
                    s_fft = samples[l].Real * samples[l].Real / norm1 * Factor_FFT;
                    
                if (l < half) { 
                    s_d4 = signald4[l + half] * Factor_DWT;
                    s_dwt = signaldwt[l+half] * Factor_DWT;
                }
                else {
                    s_d4 = 0.0;
                    s_dwt = 0.0;
                }
                    

                try
                {
                    cs_raw = Convert.ToInt32(s_raw);
                    cs_fft = Convert.ToInt32(s_fft);
                    cs_dwt = Convert.ToInt32(s_dwt);
                    cs_d4 = Convert.ToInt32(s_d4);

                }
                catch (OverflowException)
                {
                    cs_raw = 0;
                    cs_fft = 0;
                    cs_dwt = 0;
                    cs_d4 = 0;
                }

                if (l == 0) { cs_fft = 0; cs_dwt = 0; cs_d4 = 0; }
                
                lpt_raw.Y = gPanel1.Height/2 - cs_raw;
                lpt_fft.Y = gPanel2.Height - cs_fft;
                lpt_dwt.Y = gPanel2.Height/2 - cs_dwt;
                lpt_d4.Y = gPanel2.Height / 2 - cs_d4;
                pt_raw.Add(lpt_raw);
                pt_fft.Add(lpt_fft);
                pt_dwt.Add(lpt_dwt);
                pt_d4.Add(lpt_d4);

                //v(x) dynamic phase space p(q)
                lpt_raw.X = (int)(fdata[l] / skala + 32);
                lpt_raw.Y = (int)((signal_prim[l] / 256) / skala + 64);
                phase.Add(lpt_raw);
                colorVR = (int)(fdata[l]);
                lColorVR.Add(colorVR);

                // 3d phase shift space
                if (l + 2 * delT < SigSize)
                {
                    lpt_psrt.X = (int)(fdata[l] / skala + 32);
                    lpt_psrt.Y = (int)(fdata[l + delT] / skala + 32);
                    colorPS = (int)(fdata[l + 2*delT]);
                    phasC.Add(lpt_psrt);
                    colphase.Add(colorPS);
                }

            }
        }

//==============================================================================================
        private void Browse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                FilePathEdit.Text = folderBrowserDialog1.SelectedPath;
            }
            bSave = true;
        }
       
        private void ReadEEGFile(string fname)
        {
            string[] lines = File.ReadAllLines(fname);
            fdata.Clear();
            foreach (String s in lines)
            {
                string[] data_chunk = s.Split(' ');
                fdata.Add(Convert.ToInt32(data_chunk[1]));
            }
            CalculateTransform(SignalSize);
            gPanel1.Refresh();
            System.Threading.Thread.Sleep(1);
            if (checkFFT.Checked) { 
                gPanel2.Refresh();
                System.Threading.Thread.Sleep(1);
            }
            gPanel3.Refresh();
            System.Threading.Thread.Sleep(1);
            gPanel4.Refresh();
            System.Threading.Thread.Sleep(1);
            gPanel5.Refresh();
            System.Threading.Thread.Sleep(1);
            gPanel6.Refresh();
            System.Threading.Thread.Sleep(1);
            if (checkDWT.Checked)
            {
                gPanel7.Refresh();
                System.Threading.Thread.Sleep(1);
            }
            gPanel8.Refresh();
            System.Threading.Thread.Sleep(1);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            delT = Convert.ToInt32(Tdelay.Text);
            label7.Text = "PSRT" + delT.ToString() + "C";
            label5.Text = "PSRT" + delT.ToString();
            string PathName;
            PathName = FilePathEdit.Text;
            bSave = true;
            //------------------Get all filenames-------------------------
            var ext = new List<string> { ".txt"};
            var EEGFiles = Directory.GetFiles(PathName, "*.*", SearchOption.AllDirectories)
                 .Where(s => ext.Contains(Path.GetExtension(s)));
            int li = 0;
           
            foreach (string f in EEGFiles)
            {
                pLicz.Text = string.Format("{0:D3}", li);
                pLicz.Update();
                label5.Update();
                label7.Update();
                ReadEEGFile(f);
                li++;
            }

        }
      

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          //To do something before closed
        }

        private void SaveToImage(Bitmap sb,string sDir)
        {
                    
            if (bSave)
            {
                string PathToImg = FilePathEdit.Text + "\\" + sDir;
                try { Directory.CreateDirectory(PathToImg); } catch(IOException) { }         
                string FnameIMG = PathToImg + "\\EEGMap" + pLicz.Text + ".png";
                sb.Save(FnameIMG, ImageFormat.Png);
            }
           
        }
        
        private void ShowOnScreen(Bitmap bs,PaintEventArgs e)
        {
            Graphics ge = e.Graphics;
            try
            {
                ge.DrawImage(bs, 0, 0);
            }
            catch (InvalidOperationException)
            { }
        }

        private void gPanel5_Paint(object sender, PaintEventArgs e)
        {
            if (checkDWT.Checked) { 
            using (Graphics g = Graphics.FromImage(b_dwt))
            {       
                g.Clear(Color.Black);
                try
                {
                    g.DrawLines(p, pt_dwt.ToArray());
                }
                catch (ArgumentException)
                { }
            }
                ShowOnScreen(b_dwt, e);
                SaveToImage(b_dwt, "HAAR");           
            
            }
        }

        private void gPanel8_Paint(object sender, PaintEventArgs e)
        {
            if (checkD4.Checked)
            {
                using (Graphics g = Graphics.FromImage(b_d4))
                {
                    g.Clear(Color.Black);
                    try
                    {
                        g.DrawLines(p, pt_d4.ToArray());
                    }
                    catch (ArgumentException)
                    { }
                }
                ShowOnScreen(b_d4, e);
                SaveToImage(b_d4, "DAUB4");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Init form
            Tdelay.Text = string.Format("{0}", delT);
            p = new Pen(transColor, 2);
        }

        private void gPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (checkRAW.Checked) { 
            using (Graphics g = Graphics.FromImage(b_raw))
            {
               
                g.Clear(Color.Black);
                try
                {
                    g.DrawLines(p, pt_raw.ToArray());
                }
                catch (ArgumentException)
                { }
            }
                ShowOnScreen(b_raw, e);
                SaveToImage(b_raw, "RAW");
            
            }
        }

       
        private void gPanel2_Paint(object sender, PaintEventArgs e)
        {
            if (checkFFT.Checked)
            {
                using (Graphics g = Graphics.FromImage(b_fft))
                {
                    SolidBrush sfill = new SolidBrush(Color.White);

                    g.Clear(Color.Black);

                    for (int s = 0; s < pt_fft.Count; s++)
                    {
                        g.FillRectangle(sfill, s, pt_fft[s].Y, 2, b_fft.Height - pt_fft[s].Y);
                    }

                }
                ShowOnScreen(b_fft, e);
                SaveToImage(b_fft, "FFT");
                
            }
        }
 //=================================================================================      
        private Color LinearToRGB(int t)
        {
            Color output;
            int r = 0, g = 0, b = 0;
            if (2 * t < 256)
            {
                r = 2 * t;
                g = 0;
                b = 0;
            }
            else
            {
                if (2 * t < 512)
                {
                    r = 255;
                    g = 2 * t - 256;
                    b = 0;
                }
                else
                {
                    if (2 * t < 768)
                    {
                        r = 255 - (2 * t - 512);
                        g = 255;
                        b = 0;
                    }
                    else
                    {
                        if (2 * t < 1024)
                        {
                            r = 0;
                            g = 255;
                            b = (2 * t - 768);
                        }
                        else
                        {
                            if (2 * t < 1280)
                            {
                                r = 0;
                                g = 255 - (2 * t - 1024);
                                b = 255;
                            }
                            else
                            {
                                r = 0;
                                g = 0;
                                b = 0;
                            }
                        }

                    }
                }
            }

            output = Color.FromArgb(r, g, b);
            return output;
        }

        private void gPanel3_Paint(object sender, PaintEventArgs e)
        {
            if (checkPSRTC.Checked) { 
            using (Graphics gs = Graphics.FromImage(b_psrtc))
            {
                   Pen p = new Pen(Color.Blue, 2);
                
                    gs.Clear(Color.Black);
                                     
                    //General phase space
                    for (int l = 0; l < phasC.Count - 1; l++)
                    {
                        try
                        {
                            p.Color = LinearToRGB(colphase.ToArray()[l + 1] * 2 + 150);
                        }
                        catch (ArgumentException)
                        { }

                        gs.DrawLine(p, phasC.ToArray()[l], phasC.ToArray()[l + 1]);
                    }
               
            }
            ShowOnScreen(b_psrtc, e);
            SaveToImage(b_psrtc, "PSRT"+delT.ToString()+"C");

            }
        }

        private void gPanel4_Paint(object sender, PaintEventArgs e)
        {
            if (checkPSRT.Checked)
            {
                using (Graphics gs = Graphics.FromImage(b_psrt))
                {
                    gs.Clear(Color.Black);
                    //General phase space
                    for (int l = 0; l < phasC.Count - 1; l++)
                    {
                        gs.DrawLine(p, phasC.ToArray()[l], phasC.ToArray()[l + 1]);
                    }

                }
                ShowOnScreen(b_psrt, e);
                SaveToImage(b_psrt, "PSRT" + delT.ToString());
            }
        }

        private void gPanel6_Paint(object sender, PaintEventArgs e)
        {
            if (checkPSRD.Checked) { 
            using (Graphics gs = Graphics.FromImage(b_psrd))
            {
                gs.Clear(Color.Black);
                //General phase space
                for (int l = 0; l < phase.Count - 1; l++)
                {
                    gs.DrawLine(p, phase.ToArray()[l], phase.ToArray()[l + 1]);
                }

            }
                ShowOnScreen(b_psrd, e);
                SaveToImage(b_psrd, "PSRD");
            
        }
    }

        private void gPanel7_Paint(object sender, PaintEventArgs e)
        {
            if (checkPSRDC.Checked) { 
            using (Graphics gs = Graphics.FromImage(b_psrdc))
            {
                Pen p = new Pen(Color.Blue, 2);
                gs.Clear(Color.Black);
                //p(q) phase space
                for (int l = 0; l < phase.Count - 1; l++)
                {
                    try
                    {
                        p.Color = LinearToRGB(lColorVR.ToArray()[l + 1] * 2 + 150);
                    }
                    catch (ArgumentException)
                    { }
                    gs.DrawLine(p, phase.ToArray()[l], phase.ToArray()[l + 1]);
                }

            }
                ShowOnScreen(b_psrdc, e);
                SaveToImage(b_psrdc, "PSRDC");           
            }
        }

    }
}

