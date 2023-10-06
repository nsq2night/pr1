using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Krestiki_and_Noliki
{
    public partial class MainWindow : Window
    {
        string player = "";
        public void ZaX_Click(object sender, RoutedEventArgs e)
        {
            ZaO.IsEnabled = false;
            ZaX.IsEnabled = false;
            player = "X";
            RazBlok();
        }

        public void ZaO_Click(object sender, RoutedEventArgs e)
        {
            ZaX.IsEnabled = false;
            ZaO.IsEnabled = false;
            player = "O";
            RazBlok();
        }

        public void A1_Click(object sender, RoutedEventArgs e)
        {
            if (player == "X") { A1.Content = "X"; }
            else { A1.Content = "O"; }
            A1.IsEnabled = false; Checktowin(); Checktodraw(); Bot();
        }

        public void A2_Click(object sender, RoutedEventArgs e)
        {
            if (player == "X") { A2.Content = "X"; }
            else { A2.Content = "O"; }
            A2.IsEnabled = false; Checktowin(); Checktodraw(); Bot();
        }

        public void A3_Click(object sender, RoutedEventArgs e)
        {
            if (player == "X") { A3.Content = "X"; }
            else { A3.Content = "O"; }
            A3.IsEnabled = false; Checktowin(); Checktodraw(); Bot();
        }

        public void B1_Click(object sender, RoutedEventArgs e)
        {
            if (player == "X") { B1.Content = "X"; }
            else { B1.Content = "O"; }
            B1.IsEnabled = false; Checktowin(); Checktodraw(); Bot();
        }

        public void B2_Click(object sender, RoutedEventArgs e)
        {
            if (player == "X") { B2.Content = "X"; }
            else { B2.Content = "O"; }
            B2.IsEnabled = false; Checktowin(); Checktodraw(); Bot();
        }

        public void B3_Click(object sender, RoutedEventArgs e)
        {
            if (player == "X") { B3.Content = "X"; }
            else { B3.Content = "O"; }
            B3.IsEnabled = false; Checktowin(); Checktodraw(); Bot();
        }

        public void C1_Click(object sender, RoutedEventArgs e)
        {
            if (player == "X") { C1.Content = "X"; }
            else { C1.Content = "O"; }
            C1.IsEnabled = false; Checktowin(); Checktodraw(); Bot();
        }

        public void C2_Click(object sender, RoutedEventArgs e)
        {
            if (player == "X") { C2.Content = "X"; }
            else { C2.Content = "O"; }
            C2.IsEnabled = false; Checktowin(); Checktodraw(); Bot();
        }

        public void C3_Click(object sender, RoutedEventArgs e)
        {
            if (player == "X") { C3.Content = "X"; }
            else { C3.Content = "O"; }
            C3.IsEnabled = false; 
            Checktowin(); Checktodraw(); Bot();
        }

        private void Checktowin()
        {
            int kto_wins = 0;

            //горизонталь
            if ((A1.Content == "X") && (A2.Content == "X") && (A3.Content == "X"))
                kto_wins = 1;
            else if ((B1.Content == "X") && (B2.Content == "X") && (B3.Content == "X"))
                kto_wins = 1;
            else if ((C1.Content == "X") && (C2.Content == "X") && (C3.Content == "X"))
                kto_wins = 1;

            //вертикаль
            else if ((A1.Content == "X") && (B1.Content == "X") && (C1.Content == "X"))
                kto_wins = 1;
            else if ((A2.Content == "X") && (B2.Content == "X") && (C2.Content == "X"))
                kto_wins = 1;
            else if ((A3.Content == "X") && (B3.Content == "X") && (C3.Content == "X"))
                kto_wins = 1;

            //диагональ
            else if ((A1.Content == "X") && (B2.Content == "X") && (C3.Content == "X"))
                kto_wins = 1;
            else if ((A3.Content == "X") && (B2.Content == "X") && (C1.Content == "X"))
                kto_wins = 1;

            //Вывод победы
            if (kto_wins == 1)
            {
                if (player == "X")
                    player = "O";
                else
                    player = "X";
                ZaO.IsEnabled = false; ZaX.IsEnabled = false;
                MessageBox.Show("Выйграли X");
                Clean();
                RazBlok();
            }

            //горизонталь
            if ((A1.Content == "O") && (A2.Content == "O") && (A3.Content == "O"))
                kto_wins = 2;
            if ((B1.Content == "O") && (B2.Content == "O") && (B3.Content == "O"))
                kto_wins = 2;
            if ((C1.Content == "O") && (C2.Content == "O") && (C3.Content == "O"))
                kto_wins = 2;

            //вертикаль
            else if ((A1.Content == "O") && (B1.Content == "O") && (C1.Content == "O"))
                kto_wins = 2;
            else if ((A2.Content == "O") && (B2.Content == "O") && (C2.Content == "O"))
                kto_wins = 2;
            else if ((A3.Content == "O") && (B3.Content == "O") && (C3.Content == "O"))
                kto_wins = 2;

            //диагональ
            else if ((A1.Content == "O") && (B2.Content == "O") && (C3.Content == "O"))
                kto_wins = 2;
            else if ((A3.Content == "O") && (B2.Content == "O") && (C1.Content == "O"))
                kto_wins = 2;

            //Вывод победы
            if (kto_wins == 2)
            {
                if (player == "X")
                    player = "O";
                else
                    player = "X";
                ZaO.IsEnabled = false; ZaX.IsEnabled = false;
                MessageBox.Show("Выйграли O");
                Clean();
                RazBlok();
            }
        }
        private void Checktodraw()
        {
            bool kto_wins = false;

            if (A1.IsEnabled == false && A2.IsEnabled == false && A3.IsEnabled == false && 
                B1.IsEnabled == false && B2.IsEnabled == false && B3.IsEnabled == false &&
                C1.IsEnabled == false && C2.IsEnabled == false && C3.IsEnabled == false)
                kto_wins = true;

            //Вывод ничьей
            if (kto_wins == true)
            {
                if (player == "X")
                    player = "O";
                else
                    player = "X";
                ZaO.IsEnabled = false; ZaX.IsEnabled = false;
                MessageBox.Show("Ничья");
                Clean();
                RazBlok();
            }
        }
        public void RazBlok()
        {
            A1.IsEnabled = true; A2.IsEnabled = true; A3.IsEnabled = true;
            B1.IsEnabled = true; B2.IsEnabled = true; B3.IsEnabled = true;
            C1.IsEnabled = true; C2.IsEnabled = true; C3.IsEnabled = true;

        }
        public void ZaBlok()
        {
            A1.IsEnabled = false; A2.IsEnabled = false; A3.IsEnabled = false;
            B1.IsEnabled = false; B2.IsEnabled = false; B3.IsEnabled = false;
            C1.IsEnabled = false; C2.IsEnabled = false; C3.IsEnabled = false;
        }
        public void Clean()
        {
            A1.Content = ""; A2.Content = ""; A3.Content = "";
            B1.Content = ""; B2.Content = ""; B3.Content = "";
            C1.Content = ""; C2.Content = ""; C3.Content = "";
        }
        public void Bot()
        {
            Random rnd = new();
            int value = rnd.Next(1, 9);
            if (player == "X")
            {
                if (value == 1)
                {
                    if (A1.Content != "X" && A1.Content != "O")
                    {
                        A1.Content = "O";
                        A1.IsEnabled = false;
                    }
                }
                if (value == 2)
                {
                    if (A2.Content != "X" && A2.Content != "O")
                    {
                        A2.Content = "O";
                        A2.IsEnabled = false;
                    }
                }
                if (value == 3)
                {
                    if (A3.Content != "X" && A3.Content != "O")
                    {
                        A3.Content = "O";
                        A3.IsEnabled = false;
                    }
                }
                if (value == 4)
                {
                    if (B1.Content != "X" && B1.Content != "O")
                    {
                        B1.Content = "O";
                        B1.IsEnabled = false;
                    }
                }
                if (value == 5)
                {
                    if (B2.Content != "X" && B2.Content != "O")
                    {
                        B2.Content = "O";
                        B2.IsEnabled = false;
                    }
                }
                if (value == 6)
                {
                    if (B3.Content != "X" && B3.Content != "O")
                    {
                        B3.Content = "O";
                        B3.IsEnabled = false;
                    }
                }
                if (value == 7)
                {
                    if (C1.Content != "X" && C1.Content != "O")
                    {
                        C1.Content = "O";
                        C1.IsEnabled = false;
                    }
                }
                if (value == 8)
                {

                    if (C2.Content != "X" && C2.Content != "O")
                    {
                        C2.Content = "O";
                        C2.IsEnabled = false;
                    }
                }
                if (value == 9)
                {
                    if (C3.Content != "X" && C3.Content != "O")
                    {
                        C3.Content = "O";
                        C3.IsEnabled = false;
                    }
                }
            }
            if (player == "O")
            {
                if (value == 1)
                {
                    if (A1.Content != "X" && A1.Content != "O")
                    {
                        A1.Content = "X";
                        A1.IsEnabled = false;
                    }
                }
                if (value == 2)
                {
                    if (A2.Content != "X" && A2.Content != "O")
                    {
                        A2.Content = "X";
                        A2.IsEnabled = false;
                    }
                }
                if (value == 3)
                {
                    if (A3.Content != "X" && A3.Content != "O")
                    {
                        A3.Content = "X";
                        A3.IsEnabled = false;
                    }
                }
                if (value == 4)
                {
                    if (B1.Content != "X" && B1.Content != "O")
                    {
                        B1.Content = "X";
                        B1.IsEnabled = false;
                    }
                }
                if (value == 5)
                {
                    if (B2.Content != "X" && B2.Content != "O")
                    {
                        B2.Content = "X";
                        B2.IsEnabled = false;
                    }
                }
                if (value == 6)
                {
                    if (B3.Content != "X" && B3.Content != "O")
                    {
                        B3.Content = "X";
                        B3.IsEnabled = false;
                    }
                }
                if (value == 7)
                {
                    if (C1.Content != "X" && C1.Content != "O")
                    {
                        C1.Content = "X";
                        C1.IsEnabled = false;
                    }
                }
                if (value == 8)
                {
                    if (C2.Content != "X" && C2.Content != "O")
                    {
                        C2.Content = "X";
                        C2.IsEnabled = false;
                    }
                }
                if (value == 9)
                {
                    if (C3.Content != "X" && C3.Content != "O")
                    {
                        C3.Content = "X";
                        C3.IsEnabled = false;
                    }
                }
            }
        }
        private void Repeat_Click(object sender, RoutedEventArgs e)
        {
            Clean();
            ZaBlok();
            ZaO.IsEnabled = true; ZaX.IsEnabled = true;
        }
    }   
}