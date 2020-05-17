using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cezar_2._0
{
    class Class1
    {
        public string txt1; public string txt2 = ""; public string txt3; public string txt4 = "";
        public int num; public int m; public int k;
        public int low; public int big; public int t;
        public char[] Mas1; public char[] Mas2; public char[] Mas3;
        public Class1(string a, int x, int y)
        {
            txt1 = a; k = x; num = y;
        }
        public Class1(string a, string b, int x, int y)
        {
            txt1 = a; txt3 = b; k = x; num = y;
        }
        public Class1(int x, string a, int y)
        {
            k = x;   txt2 = a;   num = y;
        }
        public Class1(int x, string a, int y, string b)
        {
            k = x;   txt2 = a; num = y;   txt3 = b;
        }
        public void Alf()
        {
            Mas3 = new char[44]; int zn = 32;                                     
            for (int i = 0; i < 33; i++, zn++)
            {
                Mas3[i] = (char)zn;
            }
            zn = 91;
            for (int i = 33; i < 39; i++, zn++)
            {
                Mas3[i] = (char)zn;
            }
            zn = 123;
            for (int i = 39; i < 43; i++, zn++)
            {
                Mas3[i] = (char)zn;
            }
            Mas3[Mas3.Length - 1] = '№';
            if (num == 1)
            {
                m = 26; low = 97; big = 65;
                char[] mas1 = new char[m]; char[] mas2 = new char[m];
                Mas1 = new char[mas1.Length]; Mas2 = new char[mas2.Length];
                for (int i = 0; i < mas1.Length; i++, big++)                        
                {
                    mas1[i] = (char)(big);
                }
                for (int i = 0; i < mas2.Length; i++, low++)                        
                {
                    mas2[i] = (char)(low);
                }
                for (int i = 0; i < mas1.Length; i++)
                {
                    Mas1[i] = mas1[i];
                }
                for (int i = 0; i < mas2.Length; i++)
                {
                    Mas2[i] = mas2[i];
                }
            }
            else if (num == 2)
            {
                m = 33; low = 1072; big = 1040;
                char[] arr1 = new char[m]; char[] arr2 = new char[m];
                Mas1 = new char[arr1.Length]; Mas2 = new char[arr2.Length];
                for (int i = 0; i < 6; i++, big++)                                   
                {
                    arr1[i] = (char)(big);
                }
                arr1[6] = (char)(1025);
                for (int i = 7; i < arr1.Length; i++, big++)
                {
                    arr1[i] = (char)(big);
                }

                for (int i = 0; i < 6; i++, low++)                                   
                {
                    arr2[i] = (char)(low);
                }
                arr2[6] = (char)(1105);
                for (int i = 7; i < arr2.Length; i++, low++)
                {
                    arr2[i] = (char)(low);
                }
                for (int i = 0; i < arr1.Length; i++)
                {
                    Mas1[i] = arr1[i];
                }
                for (int i = 0; i < arr2.Length; i++)
                {
                    Mas2[i] = arr2[i];
                }
            }
            else if (num == 3)
            {
                string x, y;
                txt3.Distinct();
                y = txt3.ToUpper(); x = txt3.ToLower();
                char[] ar1 = y.ToCharArray(); char[] ar2 = x.ToCharArray();              
                Mas1 = new char[txt3.Length]; Mas2 = new char[txt3.Length];
                for (int i = 0; i < ar1.Length; i++)
                {
                    Mas1[i] = ar1[i];
                }
                for (int i = 0; i < ar2.Length; i++)
                {
                    Mas2[i] = ar2[i];
                }
                m = txt3.Length; ;
            }
        }
        public void Shifr()
        {
            bool the1 = false; bool the2 = false; bool the3 = false;
            char[] mas = txt1.ToCharArray();
            char[] arr = new char[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                the1 = false; the2 = false; the3 = false;
                for (int h = 0; h < Mas3.Length; h++)                               
                {
                    if (Mas3[h] == mas[i])
                    {
                        arr[i] = mas[i];
                        the1 = true;
                        break;
                    }
                }
                for (int j = 0; j < Mas1.Length; j++)                               
                {
                    if (Mas1[j] == mas[i])
                    {
                        t = (j + (k % m));
                        if (t >= Mas1.Length)
                        {
                            arr[i] = Mas1[t - m];
                            the2 = true;
                            break;
                        }
                        else
                        {
                            arr[i] = Mas1[t];
                            the2 = true;
                            break;
                        }
                    }
                }
                for (int p = 0; p < Mas2.Length; p++)                              
                {
                    if (Mas2[p] == mas[i])
                    {
                        t = (p + (k % m));
                        if (t >= Mas2.Length)
                        {
                            arr[i] = Mas2[t - m];
                            the3 = true;
                            break;
                        }
                        else
                        {
                            arr[i] = Mas2[t];
                            the3 = true;
                            break;
                        }
                    }
                }
                if (the1 == false && the2 == false && the3 == false)
                {
                    arr[i] = mas[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                txt2 += arr[i];
            }
        }
        public void RasShifr()
        {
            bool are1 = false; bool are2 = false; bool are3 = false;
            char[] a2 = txt2.ToCharArray();
            char[] a1 = new char[txt2.Length];
            for (int i = 0; i < a2.Length; i++)
            {
                are1 = false; are2 = false; are3 = false;
                for (int j = 0; j < Mas3.Length; j++)                                                
                {
                    if (Mas3[j] == a2[i])
                    {
                        a1[i] = a2[i];
                        are1 = true;
                        break;
                    }
                    for (int p = 0; p < Mas1.Length; p++)                                           
                    {
                        if (Mas1[p] == a2[i])
                        {
                            t = (p - (k % m));
                            if (t < 0)
                            {
                                a1[i] = Mas1[m - (Math.Abs(t))];
                                are2 = true;
                                break;
                            }
                            else
                            {
                                a1[i] = Mas1[t];
                                are3 = true;
                                break;
                            }
                        }
                    }
                    for (int h = 0; h < Mas2.Length; h++)
                    {
                        if (Mas2[h] == a2[i])
                        {
                            t = (h - (k % m));
                            if (t < 0)
                            {
                                a1[i] = Mas2[m - (Math.Abs(t))];
                                are3 = true;
                                break;
                            }
                            else
                            {
                                a1[i] = Mas2[t];
                                are3 = true;
                                break;
                            }
                        }
                        if (are1 == false && are2 == false && are3 == false)
                        {
                            a1[i] = a2[i];
                        }
                    }
                }
            }
            for (int i = 0; i < a1.Length; i++)
            {
                txt4 += a1[i];
            }
        }
    }
}
