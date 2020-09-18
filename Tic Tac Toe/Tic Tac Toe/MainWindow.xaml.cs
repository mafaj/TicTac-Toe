using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int RowCount { get; }
        public bool IsPlayer1Turn { get; set; }

        public int Counter { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        public void NewGame()
        {
            IsPlayer1Turn = false;
            Counter = 0;
            TB_Move.Text = "O";


            Button[] all = new Button[9];

            all[0] = Button_1;
            all[1] = Button_2;
            all[2] = Button_3;
            all[3] = Button_4;
            all[4] = Button_5;
            all[5] = Button_6;
            all[6] = Button_7;
            all[7] = Button_8;
            all[8] = Button_9;

            foreach(Button b in all)
            {
                b.Content = string.Empty;
                
                b.Background = Brushes.White;
                b.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IsPlayer1Turn ^= true; // operacja bitowa zmienia true na false i false na true
            
            Counter++;

            if (Counter > 9)
            {
                NewGame();
                return;
            }
            var button = sender as Button;
            button.Content = IsPlayer1Turn ? "O" : "X";

            button.IsEnabled = false;
            TB_Move.Text=(IsPlayer1Turn ? "X" : "O").ToString();

           
            if (Counter > 4)
            {

                if (IfWon() == true)
                {
                    
                    MessageBox.Show("Won player: "+(IsPlayer1Turn ? "O" : "X" ),"Game Over", MessageBoxButton.OK, MessageBoxImage.Information);
                    Counter = 9;
                    Button_1.IsEnabled = true;
                    Button_2.IsEnabled = true;
                    Button_3.IsEnabled = true;
                    Button_4.IsEnabled = true;
                    Button_5.IsEnabled = true;
                    Button_6.IsEnabled = true;
                    Button_7.IsEnabled = true;
                    Button_8.IsEnabled = true;
                    Button_9.IsEnabled = true;

                }
                else
                {
                    if(Counter==9)
                    {
                        MessageBox.Show("Remis!", "Game Over", MessageBoxButton.OK, MessageBoxImage.Stop);
                        Button_1.IsEnabled = true;
                        Button_2.IsEnabled = true;
                        Button_3.IsEnabled = true;
                        Button_4.IsEnabled = true;
                        Button_5.IsEnabled = true;
                        Button_6.IsEnabled = true;
                        Button_7.IsEnabled = true;
                        Button_8.IsEnabled = true;
                        Button_9.IsEnabled = true;

                    }
                }
            }

            
        }
        private bool IfWon()
        {
            //Poziomo
            if (Button_1.HasContent)
            {
                if (Button_1.Content.ToString() != string.Empty && Button_1.Content == Button_2.Content && Button_1.Content == Button_3.Content)
                {
                    

                    Button_1.IsEnabled = true;
                    Button_2.IsEnabled = true;
                    Button_3.IsEnabled = true;
                    
                    Button_1.Background = Brushes.Green;
                    Button_2.Background = Brushes.Green;
                    Button_3.Background = Brushes.Green;
                   
                    return true;
                }
            }

            //Poziomo
            if (Button_4.HasContent)
                {
                if (Button_4.Content.ToString() != string.Empty &&  Button_4.HasContent && Button_4.Content == Button_5.Content && Button_4.Content == Button_6.Content)
                {


                    Button_4.IsEnabled = true;
                    Button_5.IsEnabled = true;
                    Button_6.IsEnabled = true;

                    Button_4.Background = Brushes.Green;
                    Button_5.Background = Brushes.Green;
                    Button_6.Background = Brushes.Green;
                   
                    return true;
                }
            }

            //Poziomo
            if ((Button_7.HasContent) && Button_7.Content.ToString() != string.Empty && Button_7.Content == Button_8.Content && Button_7.Content == Button_9.Content)
            {

                Button_7.IsEnabled = true;
                Button_8.IsEnabled = true;
                Button_9.IsEnabled = true;

                Button_7.Background = Brushes.Green;
                Button_8.Background = Brushes.Green;
                Button_9.Background = Brushes.Green;
               
                return true;
            }

            //Pionowo
            if ((Button_1.HasContent) && Button_1.Content.ToString() != string.Empty &&  Button_1.Content == Button_4.Content && Button_1.Content == Button_7.Content)
            {

                Button_1.IsEnabled = true;
                Button_4.IsEnabled = true;
                Button_7.IsEnabled = true;

                Button_1.Background = Brushes.Green;
                Button_4.Background = Brushes.Green;
                Button_7.Background = Brushes.Green;
                
                return true;
            }
            //Pionowo
            if ((Button_2.HasContent) && Button_2.Content.ToString() != string.Empty && Button_2.Content == Button_5.Content && Button_2.Content == Button_8.Content)
            {


                Button_2.IsEnabled = true;
                Button_5.IsEnabled = true;
                Button_8.IsEnabled = true;

                Button_2.Background = Brushes.Green;
                Button_5.Background = Brushes.Green;
                Button_8.Background = Brushes.Green;
               
                return true;
            }
            //Pionowo
            if ((Button_3.HasContent) && Button_3.Content.ToString() != string.Empty &&  Button_3.Content == Button_6.Content && Button_3.Content == Button_9.Content)
            {

                Button_3.IsEnabled = true;
                Button_6.IsEnabled = true;
                Button_9.IsEnabled = true;

                Button_3.Background = Brushes.Green;
                Button_6.Background = Brushes.Green;
                Button_9.Background = Brushes.Green;
               
                return true;
            }
            //Skos
            if ((Button_1.HasContent) && Button_1.Content.ToString() != string.Empty &&  Button_1.Content == Button_5.Content && Button_1.Content == Button_9.Content)
            {


                Button_1.IsEnabled = true;
                Button_5.IsEnabled = true;
                Button_9.IsEnabled = true;

                Button_1.Background = Brushes.Green;
                Button_5.Background = Brushes.Green;
                Button_9.Background = Brushes.Green;
                
                return true;
            }
            if ((Button_3.HasContent) && Button_3.Content.ToString() != string.Empty && Button_3.Content == Button_5.Content && Button_3.Content == Button_7.Content)
            {

                Button_3.IsEnabled = true;
                Button_5.IsEnabled = true;
                Button_7.IsEnabled = true;

                Button_3.Background = Brushes.Green;
                Button_5.Background = Brushes.Green;
                Button_7.Background = Brushes.Green;
               
                return true;
            }
            return false;
        }
         
        private void Button_Restart_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }

        private void TB_Move_TextChanged(object sender, TextChangedEventArgs e)
        {
            

            
        }
    }
}
