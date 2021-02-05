﻿using System;
using System.Media;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CardIdentifier
{
    public partial class MainWindow : Window
    {

        private int Flag = 1, FlagBtn1 = 1, FlagBtn2 = 1, FlagBtn3 = 1, FlagBtn4 = 1, FlagBtn5 = 1;

        public MainWindow()
        {
            InitializeComponent();
            HideBorder();
        } 

        private void MouseClickSound() {
            
            if (Flag == 1)
            {
                SoundPlayer Music = new SoundPlayer();
                Music.SoundLocation = Environment.CurrentDirectory + "..\\..\\..\\Sound\\MouseClickSound.wav";
                Music.Play();
            }
        }
      

        private void HideBorder() {
            border.Visibility = Visibility.Hidden;
            lblShowCard.Content = "";
        }

        private void ShowBorder()
        {
            border.Visibility = Visibility.Visible;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MouseClickSound();
            if (FlagBtn1!=0)
            {
                img1.Source = new BitmapImage(new Uri("/Images/10_Spades.jpg", UriKind.Relative));
                lblShowCard.Content = "10 of Spades";
                FlagBtn1 = 0;
                ShowBorder();
                return;
            }
            else
            {
                img1.Source = new BitmapImage(new Uri("/Covers/Backface_Red.jpg", UriKind.Relative));
                FlagBtn1 = 1;
                HideBorder();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            MouseClickSound();

            if (FlagBtn2!=0)
            {
                img2.Source = new BitmapImage(new Uri("/Images/5_Hearts.jpg", UriKind.Relative));
                lblShowCard.Content = "5 of Hearts";
                FlagBtn2 = 0;
                ShowBorder();
                return;
            }
            else
            {
                img2.Source = new BitmapImage(new Uri("/Covers/Backface_Red.jpg", UriKind.Relative));
                FlagBtn2 = 1;
                HideBorder();

            }

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            MouseClickSound();

            if (FlagBtn3!=0)
            {
                img3.Source = new BitmapImage(new Uri("/Images/9_Hearts.jpg", UriKind.Relative));
                lblShowCard.Content = "9 of Hearts";
                FlagBtn3 = 0;
                ShowBorder();
                return;
            }
            else
            {
                img3.Source = new BitmapImage(new Uri("/Covers/Backface_Red.jpg", UriKind.Relative));
                FlagBtn3 = 1;
                HideBorder();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            MouseClickSound();

            if (FlagBtn4!=0)
            {
                img4.Source = new BitmapImage(new Uri("/Images/9_Spades.jpg", UriKind.Relative));
                lblShowCard.Content = "9 of Spades";
                FlagBtn4 = 0;
                ShowBorder();
                return;
            }
            else
            {
                img4.Source = new BitmapImage(new Uri("/Covers/Backface_Red.jpg", UriKind.Relative));
                FlagBtn4 = 1;
                HideBorder();
            }

        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            MouseClickSound();

            if (FlagBtn5!=0)
            {
                img5.Source = new BitmapImage(new Uri("/Images/Ace_Hearts.jpg", UriKind.Relative));
                lblShowCard.Content = "Ace of Hearts";
                FlagBtn5 = 0;
                ShowBorder();
                return;
            }
            else
            {
                img5.Source = new BitmapImage(new Uri("/Covers/Backface_Red.jpg", UriKind.Relative));
                FlagBtn5 = 1;
                HideBorder();
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            MouseClickSound();
            img1.Source = new BitmapImage(new Uri("/Covers/Backface_Red.jpg", UriKind.Relative));
            img2.Source = new BitmapImage(new Uri("/Covers/Backface_Red.jpg", UriKind.Relative));
            img3.Source = new BitmapImage(new Uri("/Covers/Backface_Red.jpg", UriKind.Relative));
            img4.Source = new BitmapImage(new Uri("/Covers/Backface_Red.jpg", UriKind.Relative));
            img5.Source = new BitmapImage(new Uri("/Covers/Backface_Red.jpg", UriKind.Relative));
            FlagBtn1 = 1;
            FlagBtn2 = 1;
            FlagBtn3 = 1;
            FlagBtn4 = 1;
            FlagBtn5 = 1;
            HideBorder();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MouseClickSound();
            Close();
        }

        private void btnSound_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == 0)
            {
                Flag = 1;
                MouseClickSound();
                imgSound.Source = new BitmapImage(new Uri("/Images/Sound_On.png", UriKind.Relative));
                
            }
            else {
                Flag = 0;
                imgSound.Source = new BitmapImage(new Uri("/Images/SoundOff.png", UriKind.Relative)); 
            }

        }
    }
}
