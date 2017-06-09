using System;


namespace EPower.Bidding
{
    internal sealed class DefineConstantsGuassXyToBl
    {
        public const double PI = 3.1415926535;

        public const int A = 6378245; //北京54 长半轴  //6378140 西安80 长半轴
    }

    public class CGuassXyToBl2
    {
        public CGuassXyToBl2()
        {
            //西安80
            //e1_2 = 0.00669438499959;//0.0066943799013;
            //e2_2 = 0.00673950181947;//0.00673949674227;

            e1_2 = 0.006693421622966;//北京54;
            e2_2 = 0.006738525414683;//北京54;

            /*
            m_Para[0] = 4913116.8892232701;
            m_Para[1] = 152488.55070865253;
            m_Para[2] = 0.60056408082857626;
            m_Para[3] = -0.0043325959060130700;

            m_invPara[0] = -7605354.3076925632;
            m_invPara[1] = -305274.67890643491;
            m_invPara[2] = 1.5511493011633350;
            m_invPara[3] = 0.011190318086844047;
            */

            //平房区
            /*
            m_Para[0] = 4913171.064462;
            m_Para[1] = 152479.144311;
            m_Para[2] = 0.600405;
            m_Para[3] = -0.004451;

            m_invPara[0] = -8180764.340876;
            m_invPara[1] = -314601.923272;
            m_invPara[2] = 1.665451;
            m_invPara[3] = 0.012345;
            */
            //m_Para[0] = 4913171.064462;
            //m_Para[1] = 152479.144311;
            //m_Para[2] = 0.600405;
            //m_Para[3] = -0.004451;

            //m_invPara[0] = -8180764.340876;
            //m_invPara[1] = -314601.923272;
            //m_invPara[2] = 1.665451;
            //m_invPara[3] = 0.012345;

            //26区
            //m_Para26[0] = 4913107.481366;
            //m_Para26[1] = 152469.328757;
            //m_Para26[2] = 0.600538;
            //m_Para26[3] = -0.004260;

            //m_invPara26[0] = -8178948.441108;
            //m_invPara26[1] = -311909.211448;
            //m_invPara26[2] = 1.665087;
            //m_invPara26[3] = 0.011812;

            m_Para_new[0] = 13.907680;
            m_Para_new[1] = -6.842183;
            m_Para_new[2] = 0.0416778827;
            m_Para_new[3] = 0.000006030125;

            m_invPara_new[0] = -2250977.926975;
            m_invPara_new[1] = 1251045.889246;
            m_invPara_new[2] = -0.0416778827;
            m_invPara_new[3] = 165641.92339315263;

            //m_Para_new[0] = 4872298.3769561499;
            //m_Para_new[1] = 258961.08271025968;
            //m_Para_new[2] = 0.99724550556168345;
            //m_Para_new[3] = -0.036607401510697191;

            //m_invPara_new[0] = -4869643.7344038114;
            //m_invPara_new[1] = -438433.56453097053;
            //m_invPara_new[2] = 1.0014090893408589;
            //m_invPara_new[3] = 0.036760240493361351;
        }
        public void Dispose()
        {
        }

        public struct Jwd
        {
            public double Jd;
            public double Wd;

            public Jwd(double jd, double wd)
                : this()
            {
                Jd = jd;
                Wd = wd;
            }
        }
        public struct Pm
        {
            public double X;
            public double Y;

            public Pm(double x, double y)
                : this()
            {
                X = x;
                Y = y;
            }
        }

        public double CalcuBf(double m)
        {
            double b0, c0, e1_4, e1_6, e1_8, e1_10, e1_12, e1_14, e1_16;

            e1_4 = Math.Pow(e1_2, 2);
            e1_6 = Math.Pow(e1_2, 3);
            e1_8 = Math.Pow(e1_2, 4);
            e1_10 = Math.Pow(e1_2, 5);
            e1_12 = Math.Pow(e1_2, 6);
            e1_14 = Math.Pow(e1_2, 7);
            e1_16 = Math.Pow(e1_2, 8);
            c0 = 1 + e1_2 / 4 + 7 * e1_4 / 64 + 15 * e1_6 / 256 + 579 * e1_8 / 16384 + 1515 * e1_10 / 65536 + 16837 * e1_12 / 1048576 + 48997 * e1_14 / 4194304 + 9467419 * e1_16 / 1073741824;
            c0 = DefineConstantsGuassXyToBl.A / c0;

            b0 = m / c0;
            double d1, d2, d3, d4, d5, d6, d7;
            d1 = 3 * e1_2 / 8 + 45 * e1_4 / 128 + 175 * e1_6 / 512 + 11025 * e1_8 / 32768 + 43659 * e1_10 / 131072 + 693693 * e1_12 / 2097152 + 10863435 * e1_14 / 33554432;
            d2 = -21 * e1_4 / 64 - 277 * e1_6 / 384 - 19413 * e1_8 / 16384 - 56331 * e1_10 / 32768 - 2436477 * e1_12 / 1048576 - 196473 * e1_14 / 65536;
            d3 = 151 * e1_6 / 384 + 5707 * e1_8 / 4096 + 53189 * e1_10 / 163840 + 4599609 * e1_12 / 655360 + 15842375 * e1_14 / 1048576;
            d4 = -1097 * e1_8 / 2048 - 1687 * e1_10 / 640 - 3650333 * e1_12 / 327680 - 114459079 * e1_14 / 27525120;
            d5 = 8011 * e1_10 / 1024 + 874457 * e1_12 / 98304 + 216344925 * e1_14 / 3670016;
            d6 = -682193 * e1_12 / 245760 - 46492223 * e1_14 / 1146880;
            d7 = 36941521 * e1_14 / 3440640;

            double bf;
            bf = b0 + Math.Sin(2 * b0) * (d1 + Math.Sin(b0) * Math.Sin(b0) * (d2 + Math.Sin(b0) * Math.Sin(b0) * (d3 + Math.Sin(b0) * Math.Sin(b0) * (d4 + Math.Sin(b0) * Math.Sin(b0) * (d5 + Math.Sin(b0) * Math.Sin(b0) * (d6 + d7 * Math.Sin(b0) * Math.Sin(b0)))))));

            return bf;
        }

        public Jwd GuassXyToBl(double dx, double dy)
        {
            Jwd jwd;
            double x, y;
            double B;				    //纬度
            double L;				    //经度
            int zone;					//带号
            double l;				    //经差
            double X;				    //子午线弧长
            double L0;

            //x = dx + 4864569.8;
            //y = dy - 247300.4 + 500000 + 42000000;
            x = dx;
            y = dy;
            //注意:40000000 为代号 转换的结`果 40 000 000 对应40, 39 000 000 对应39 带号通过换算可以得投影带的中央经度 公式为 L0=zone*3-1.5; zone 为40或者39 


            zone = (int)(y / 1000000);      //求带号
            //L0 = zone * 3;			    //中央子午线经度
            L0 = 111;
            //y = y - zone * 1000000 - 500000;	//y的真实坐标
            y = y - 500000;	//y的真实坐标
            double Bf;
            Bf = CalcuBf(x);			    //求底点纬度
            double Mf, Nf, tf, etaf_2;
            Mf = (DefineConstantsGuassXyToBl.A * (1 - e1_2)) / Math.Sqrt((1 - e1_2 * Math.Sin(Bf) * Math.Sin(Bf)) * (1 - e1_2 * Math.Sin(Bf) * Math.Sin(Bf)) * (1 - e1_2 * Math.Sin(Bf) * Math.Sin(Bf)));
            Nf = DefineConstantsGuassXyToBl.A / Math.Sqrt(1 - e1_2 * Math.Sin(Bf) * Math.Sin(Bf));
            tf = Math.Tan(Bf);
            etaf_2 = e2_2 * Math.Cos(Bf) * Math.Cos(Bf);

            double tf_2, tf_4, y_2, y_3, y_4, y_5, y_6, Nf_3, Nf_5;
            tf_2 = tf * tf;
            tf_4 = tf_2 * tf_2;
            y_2 = y * y;
            y_3 = y_2 * y;
            y_4 = y_3 * y;
            y_5 = y_4 * y;
            y_6 = y_5 * y;


            Nf_3 = Math.Pow(Nf, 3);
            Nf_5 = Math.Pow(Nf, 5);

            B = Bf - tf * y_2 / (2 * Mf * Nf) + tf * (5 + 3 * tf_2 + etaf_2 - 9 * etaf_2 * tf_2) * y_4 / (24 * Mf * Nf_3) - tf * (61 + 90 * tf_2 + 45 * tf_4) * y_6 / (720 * Mf * Nf_5);
            L = y / (Nf * Math.Cos(Bf)) - y_3 * (1 + 2 * tf_2 + etaf_2) / (6 * Nf_3 * Math.Cos(Bf)) + (5 + 28 * tf_2 + 24 * tf_4 + 6 * etaf_2 + 8 * etaf_2 * tf_2) * y_5 / (120 * Nf_5 * Math.Cos(Bf));


            double db, dl;
            B = B / DefineConstantsGuassXyToBl.PI * 180;		//转换为角度小数
            L = L / DefineConstantsGuassXyToBl.PI * 180;		//转换为角度小数
            L += L0;

            jwd.Wd = B;
            jwd.Jd = L;

            return jwd;
        }

        public Pm GuassBlToXy(double B, double L)
        {
            Pm pm;

            double x, y;
            int zone;
            double l;
            double X;
            int L0;
            double dB, dL;

            /*	if (fmod(L,6) != 0)	
                    zone = int(L/6) + 1;
                else
                    zone = int(L/6);

                L0 = 6*zone - 3;		//求中央经线*/

            L0 = 111;           //默认写死中央经线是126 不重新计算中央经线

            l = L - L0;				//求经差
            l = l / 180 * DefineConstantsGuassXyToBl.PI;			//经差用弧度表示

            dB = B / 180 * DefineConstantsGuassXyToBl.PI;				//弧度表示
            dL = L / 180 * DefineConstantsGuassXyToBl.PI;				//弧度表示

            //
            double m0, m2, m4, m6, m8, a0, a2, a4, a6, a8;

            m0 = DefineConstantsGuassXyToBl.A * (1 - e1_2);
            m2 = 3 * m0 * e1_2 / 2;
            m4 = 5 * m2 * e1_2 / 4;
            m6 = 7 * m4 * e1_2 / 6;
            m8 = 9 * m6 * e1_2 / 8;

            a0 = m0 + m2 / 2 + 3 * m4 / 8 + 5 * m6 / 16 + 35 * m8 / 128;
            a2 = m2 / 2 + m4 / 2 + 15 * m6 / 32 + 7 * m8 / 16;
            a4 = m4 / 8 + 3 * m6 / 16 + 7 * m8 / 32;
            a6 = m6 / 32 + m8 / 16;
            a8 = m8 / 128;

            X = a0 * dB - a2 * Math.Sin(2 * dB) / 2 + a4 * Math.Sin(4 * dB) / 4 - a6 * Math.Sin(6 * dB) / 6 + a8 * Math.Sin(8 * dB) / 8;

            double t, eta_2, N;
            t = Math.Tan(dB);
            eta_2 = e2_2 * Math.Cos(dB) * Math.Cos(dB);
            N = DefineConstantsGuassXyToBl.A / Math.Sqrt(1 - e1_2 * Math.Sin(dB) * Math.Sin(dB));		//计算卯酉圈半径

            double cosbl_2, cosbl_3, cosbl_4, cosbl_5, cosbl_6;
            cosbl_2 = Math.Cos(dB) * Math.Cos(dB) * l * l;
            cosbl_3 = Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * l * l * l;
            cosbl_4 = Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * l * l * l * l;
            cosbl_5 = Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * l * l * l * l * l;
            cosbl_6 = Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * l * l * l * l * l * l;
            x = X + N * t * cosbl_2 / 2 + N * t * (5 - t * t + 9 * eta_2 + 4 * eta_2 * eta_2) * cosbl_4 / 24 + N * t * (61 - 58 * t * t + t * t * t * t) * cosbl_6 / 720;
            y = N * l * Math.Cos(dB) + N * (1 - t * t + eta_2) * cosbl_3 / 6 + N * (5 - 18 * t * t + t * t * t * t + 14 * eta_2 - 58 * t * t * eta_2) * cosbl_5 / 120;


            //pm.X = x - 4864569.8;
            //pm.Y = y + 247300.4;
            pm.X = x;
            pm.Y = y;
            return pm;
        }

        //专用做 2000坐标系统下的 平面到经纬度投影
        public double CalcuBf_126(double m)
        {
            double b0, c0, e1_4, e1_6, e1_8, e1_10, e1_12, e1_14, e1_16;

            e1_4 = Math.Pow(e1_2, 2);
            e1_6 = Math.Pow(e1_2, 3);
            e1_8 = Math.Pow(e1_2, 4);
            e1_10 = Math.Pow(e1_2, 5);
            e1_12 = Math.Pow(e1_2, 6);
            e1_14 = Math.Pow(e1_2, 7);
            e1_16 = Math.Pow(e1_2, 8);
            c0 = 1 + e1_2 / 4 + 7 * e1_4 / 64 + 15 * e1_6 / 256 + 579 * e1_8 / 16384 + 1515 * e1_10 / 65536 + 16837 * e1_12 / 1048576 + 48997 * e1_14 / 4194304 + 9467419 * e1_16 / 1073741824;
            c0 = DefineConstantsGuassXyToBl.A / c0;

            b0 = m / c0;
            double d1, d2, d3, d4, d5, d6, d7;
            d1 = 3 * e1_2 / 8 + 45 * e1_4 / 128 + 175 * e1_6 / 512 + 11025 * e1_8 / 32768 + 43659 * e1_10 / 131072 + 693693 * e1_12 / 2097152 + 10863435 * e1_14 / 33554432;
            d2 = -21 * e1_4 / 64 - 277 * e1_6 / 384 - 19413 * e1_8 / 16384 - 56331 * e1_10 / 32768 - 2436477 * e1_12 / 1048576 - 196473 * e1_14 / 65536;
            d3 = 151 * e1_6 / 384 + 5707 * e1_8 / 4096 + 53189 * e1_10 / 163840 + 4599609 * e1_12 / 655360 + 15842375 * e1_14 / 1048576;
            d4 = -1097 * e1_8 / 2048 - 1687 * e1_10 / 640 - 3650333 * e1_12 / 327680 - 114459079 * e1_14 / 27525120;
            d5 = 8011 * e1_10 / 1024 + 874457 * e1_12 / 98304 + 216344925 * e1_14 / 3670016;
            d6 = -682193 * e1_12 / 245760 - 46492223 * e1_14 / 1146880;
            d7 = 36941521 * e1_14 / 3440640;

            double bf;
            bf = b0 + Math.Sin(2 * b0) * (d1 + Math.Sin(b0) * Math.Sin(b0) * (d2 + Math.Sin(b0) * Math.Sin(b0) * (d3 + Math.Sin(b0) * Math.Sin(b0) * (d4 + Math.Sin(b0) * Math.Sin(b0) * (d5 + Math.Sin(b0) * Math.Sin(b0) * (d6 + d7 * Math.Sin(b0) * Math.Sin(b0)))))));
            return bf;
        }
        public Jwd GuassXyToBl_126(double dx, double dy)
        {
            #region 源代码
            //Jwd jwd;
            //double x, y;
            //double B;				    //纬度
            //double L;				    //经度
            //int zone;					//带号
            //double l;				    //经差
            //double X;				    //子午线弧长
            //double L0;

            //x = dx;
            //y = dy;
            ////	y = dy - 247300.4 + 500000 + 42000000;
            ////注意:40000000 为代号 转换的结果 40 000 000 对应40, 39 000 000 对应39 带号通过换算可以得投影带的中央经度 公式为 L0=zone*3-1.5; zone 为40或者39 

            ////	zone = int(y/1000000);      //求带号
            //L0 = 126;			    //中央子午线经度 固定在126
            //y = y - 500000;	//y的真实坐标
            //double Bf;
            //Bf = CalcuBf_126(x);			    //求底点纬度
            //double Mf, Nf, tf, etaf_2;
            //Mf = (DefineConstantsGuassXyToBl.A * (1 - e1_2)) / Math.Sqrt((1 - e1_2 * Math.Sin(Bf) * Math.Sin(Bf)) * (1 - e1_2 * Math.Sin(Bf) * Math.Sin(Bf)) * (1 - e1_2 * Math.Sin(Bf) * Math.Sin(Bf)));
            //Nf = DefineConstantsGuassXyToBl.A / Math.Sqrt(1 - e1_2 * Math.Sin(Bf) * Math.Sin(Bf));
            //tf = Math.Tan(Bf);
            //etaf_2 = e2_2 * Math.Cos(Bf) * Math.Cos(Bf);

            //double tf_2, tf_4, y_2, y_3, y_4, y_5, y_6, Nf_3, Nf_5;
            //tf_2 = tf * tf;
            //tf_4 = tf_2 * tf_2;
            //y_2 = y * y;
            //y_3 = y_2 * y;
            //y_4 = y_3 * y;
            //y_5 = y_4 * y;
            //y_6 = y_5 * y;

            //Nf_3 = Math.Pow(Nf, 3);
            //Nf_5 = Math.Pow(Nf, 5);

            //B = Bf - tf * y_2 / (2 * Mf * Nf) + tf * (5 + 3 * tf_2 + etaf_2 - 9 * etaf_2 * tf_2) * y_4 / (24 * Mf * Nf_3) - tf * (61 + 90 * tf_2 + 45 * tf_4) * y_6 / (720 * Mf * Nf_5);
            //L = y / (Nf * Math.Cos(Bf)) - y_3 * (1 + 2 * tf_2 + etaf_2) / (6 * Nf_3 * Math.Cos(Bf)) + (5 + 28 * tf_2 + 24 * tf_4 + 6 * etaf_2 + 8 * etaf_2 * tf_2) * y_5 / (120 * Nf_5 * Math.Cos(Bf));


            //double db, dl;
            //B = B / DefineConstantsGuassXyToBl.PI * 180;		//转换为角度小数
            //L = L / DefineConstantsGuassXyToBl.PI * 180;		//转换为角度小数
            //L += L0;

            ////jwd.Wd = B;
            ////jwd.Jd = L;
            //jwd.Wd = B - 17.149904054022885;
            //jwd.Jd = L - 10.86552772969242;
            //return jwd; 
            #endregion
            Jwd jwd;
            double x, y;
            double B;				    //纬度
            double L;				    //经度
            int zone;					//带号
            double l;				    //经差
            double X;				    //子午线弧长
            double L0;

            x = dx;
            y = dy;
            //	y = dy - 247300.4 + 500000 + 42000000;
            //注意:40000000 为代号 转换的结果 40 000 000 对应40, 39 000 000 对应39 带号通过换算可以得投影带的中央经度 公式为 L0=zone*3-1.5; zone 为40或者39 

            //	zone = int(y/1000000);      //求带号
            L0 = 111;			    //中央子午线经度 固定在126
            y = y - 500000;	//y的真实坐标
            double Bf;
            Bf = CalcuBf_126(x);			    //求底点纬度
            double Mf, Nf, tf, etaf_2;
            Mf = (DefineConstantsGuassXyToBl.A * (1 - e1_2)) / Math.Sqrt((1 - e1_2 * Math.Sin(Bf) * Math.Sin(Bf)) * (1 - e1_2 * Math.Sin(Bf) * Math.Sin(Bf)) * (1 - e1_2 * Math.Sin(Bf) * Math.Sin(Bf)));
            Nf = DefineConstantsGuassXyToBl.A / Math.Sqrt(1 - e1_2 * Math.Sin(Bf) * Math.Sin(Bf));
            tf = Math.Tan(Bf);
            etaf_2 = e2_2 * Math.Cos(Bf) * Math.Cos(Bf);

            double tf_2, tf_4, y_2, y_3, y_4, y_5, y_6, Nf_3, Nf_5;
            tf_2 = tf * tf;
            tf_4 = tf_2 * tf_2;
            y_2 = y * y;
            y_3 = y_2 * y;
            y_4 = y_3 * y;
            y_5 = y_4 * y;
            y_6 = y_5 * y;

            Nf_3 = Math.Pow(Nf, 3);
            Nf_5 = Math.Pow(Nf, 5);

            B = Bf - tf * y_2 / (2 * Mf * Nf) + tf * (5 + 3 * tf_2 + etaf_2 - 9 * etaf_2 * tf_2) * y_4 / (24 * Mf * Nf_3) - tf * (61 + 90 * tf_2 + 45 * tf_4) * y_6 / (720 * Mf * Nf_5);
            L = y / (Nf * Math.Cos(Bf)) - y_3 * (1 + 2 * tf_2 + etaf_2) / (6 * Nf_3 * Math.Cos(Bf)) + (5 + 28 * tf_2 + 24 * tf_4 + 6 * etaf_2 + 8 * etaf_2 * tf_2) * y_5 / (120 * Nf_5 * Math.Cos(Bf));


            double db, dl;
            B = B / DefineConstantsGuassXyToBl.PI * 180;		//转换为角度小数
            L = L / DefineConstantsGuassXyToBl.PI * 180;		//转换为角度小数
            L += L0;

            //jwd.Wd = B;
            //jwd.Jd = L;
            jwd.Wd = B;// -17.149904054022885;
            jwd.Jd = L;// -10.86552772969242;
            return jwd;
        }
        public Pm GuassBlToXy_126(double B, double L)
        {
            Pm pm;
            double x, y;
            int zone;
            double l;
            double X;
            int L0;
            double dB, dL;

            /*	if (fmod(L,6) != 0)	
                    zone = int(L/6) + 1;
                else
                    zone = int(L/6);

                L0 = 6*zone - 3;		//求中央经线*/

            L0 = 111;           //默认写死中央经线是126 不重新计算中央经线

            l = L - L0;				//求经差
            l = l / 180 * DefineConstantsGuassXyToBl.PI;			//经差用弧度表示

            dB = B / 180 * DefineConstantsGuassXyToBl.PI;				//弧度表示
            dL = L / 180 * DefineConstantsGuassXyToBl.PI;				//弧度表示

            //
            double m0, m2, m4, m6, m8, a0, a2, a4, a6, a8;

            m0 = DefineConstantsGuassXyToBl.A * (1 - e1_2);
            m2 = 3 * m0 * e1_2 / 2;
            m4 = 5 * m2 * e1_2 / 4;
            m6 = 7 * m4 * e1_2 / 6;
            m8 = 9 * m6 * e1_2 / 8;

            a0 = m0 + m2 / 2 + 3 * m4 / 8 + 5 * m6 / 16 + 35 * m8 / 128;
            a2 = m2 / 2 + m4 / 2 + 15 * m6 / 32 + 7 * m8 / 16;
            a4 = m4 / 8 + 3 * m6 / 16 + 7 * m8 / 32;
            a6 = m6 / 32 + m8 / 16;
            a8 = m8 / 128;

            X = a0 * dB - a2 * Math.Sin(2 * dB) / 2 + a4 * Math.Sin(4 * dB) / 4 - a6 * Math.Sin(6 * dB) / 6 + a8 * Math.Sin(8 * dB) / 8;

            double t, eta_2, N;
            t = Math.Tan(dB);
            eta_2 = e2_2 * Math.Cos(dB) * Math.Cos(dB);
            N = DefineConstantsGuassXyToBl.A / Math.Sqrt(1 - e1_2 * Math.Sin(dB) * Math.Sin(dB));		//计算卯酉圈半径

            double cosbl_2, cosbl_3, cosbl_4, cosbl_5, cosbl_6;
            cosbl_2 = Math.Cos(dB) * Math.Cos(dB) * l * l;
            cosbl_3 = Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * l * l * l;
            cosbl_4 = Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * l * l * l * l;
            cosbl_5 = Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * l * l * l * l * l;
            cosbl_6 = Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * Math.Cos(dB) * l * l * l * l * l * l;
            x = X + N * t * cosbl_2 / 2 + N * t * (5 - t * t + 9 * eta_2 + 4 * eta_2 * eta_2) * cosbl_4 / 24 + N * t * (61 - 58 * t * t + t * t * t * t) * cosbl_6 / 720;
            y = N * l * Math.Cos(dB) + N * (1 - t * t + eta_2) * cosbl_3 / 6 + N * (5 - 18 * t * t + t * t * t * t + 14 * eta_2 - 58 * t * t * eta_2) * cosbl_5 / 120;

            pm.X = x;
            pm.Y = y + 500000;
            return pm;
        }
        //用于将哈尔滨平面转换到84平面
        public Pm D2P4(double X0, double Y0)
        {
            #region 源代码
            //Pm pm;
            //double dx = 0;
            //double dy = 0;
            //double C = 0;
            //double D = 0;
            ////if (202505.842 < X0 && X0 < 204249.032 && Y0>297505.195 && Y0<299983.533)
            ////{
            ////    dx = m_Para26[0];
            ////    dy = m_Para26[1];
            ////    C = m_Para26[2];
            ////    D = m_Para26[3];
            ////}
            ////else
            ////{
            ////     dx = m_Para[0];
            ////     dy = m_Para[1];
            ////     C = m_Para[2];
            ////     D = m_Para[3];
            ////}

            //dx = m_Para_new[0];
            //dy = m_Para_new[1];
            //C = m_Para_new[2];
            //D = m_Para_new[3];
            //Y0 = Y0 - 500000;

            //pm.X = dx + C * X0 - D * Y0;
            //pm.Y = dy + D * X0 + C * Y0;

            //pm.Y = pm.Y + 500000;
            //return pm; 
            #endregion
            Pm pm;

           // pm.X = Y0;// (X0 + 5253183.308 * 3.448331533 * Math.Pow(10, -5)) / (1 + 3.448331533 * Math.Pow(10, -5));
           // pm.Y = X0;// (Y0 + 559626.256 * 3.448331533 * Math.Pow(10, -5)) / (1 + 3.448331533 * Math.Pow(10, -5));

            pm.X = X0;
            pm.Y = Y0;
            return pm;
        }
        //用于将84平面转换到哈尔滨平面
        public Pm invD2P4(double X0, double Y0, bool is_26)
        {
            Pm pm;
            double dx = m_invPara[0];
            double dy = m_invPara[1];
            double C = m_invPara[2];
            double D = m_invPara[3];
            //if (is_26)
            //{
            //     dx = m_invPara26[0];
            //     dy = m_invPara26[1];
            //     C = m_invPara26[2];
            //     D = m_invPara26[3];
            //}
            //else
            //{
            //     dx = m_invPara[0];
            //     dy = m_invPara[1];
            //     C = m_invPara[2];
            //     D = m_invPara[3];
            //}
            dx = m_invPara_new[0];
            dy = m_invPara_new[1];
            C = m_invPara_new[2];
            D = m_invPara_new[3];
            Y0 = Y0 - 500000;

            pm.X = dx + C * X0 - D * Y0;
            pm.Y = dy + D * X0 + C * Y0;

            pm.Y = pm.Y + 500000;

            return pm;
        }


        public Jwd haerbinPMto84BL(double dx, double dy)
        {
            Jwd jwd;
            Pm pm;

            pm = D2P4(dx, dy);
            jwd = GuassXyToBl_126(pm.X, pm.Y);

            return jwd;
        }
        bool is26 = false;
        public Pm BLtohaerbinPM(double b, double l)
        {
            Jwd jwd;
            Pm pm;
            double pm2000dx = 0;
            double pm2000dy = 0;

            is26 = true;
            //if (b > 45.440319 && b < 45.44274034 && l > 126.40492221 && l < 126.378013534)
            //{
            //    //26区范围
            //    is26 = true;
            //}
            //else
            //{
            //    is26 = false;
            //}


            pm = GuassBlToXy_126(b, l);
            //pm = invD2P4(pm.X, pm.Y, is26);

            return pm;
        }



        public double e1_2; //第一偏心率e1的平方
        public double e2_2; //第二偏心率e2的平方
        public double L, B;

        public double[] m_Para = new double[4];
        public double[] m_invPara = new double[4];

        public double[] m_Para26 = new double[4];
        public double[] m_invPara26 = new double[4];

        public double[] m_Para_new = new double[4];
        public double[] m_invPara_new = new double[4];
    }
}