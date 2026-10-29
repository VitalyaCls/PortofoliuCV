using SalonFrumusete.ViewModels;
using SalonFrumusete.Views;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SalonFrumusete
{
    public class Programare
    {
        public string NumeClient { get; set; }
        public string Serviciu { get; set; }
        public DateTime Data { get; set; }

        public override string ToString()
        {
            return $"{Data:dd.MM.yyyy} - {NumeClient} ({Serviciu})";
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void MeniuDespre_Click(object sender, RoutedEventArgs e)
        {
            var fereastraDespre = new SalonFrumusete.Views.DespreWindow();
            fereastraDespre.ShowDialog();
        }

        private void MeniuIesire_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                "Sigur doriți să părăsiți aplicația?",
                "Confirmare Ieșire",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

    
        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true; // Permite mereu crearea
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Comandă New (Nouă programare) executată!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SaveCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Datele au fost salvate cu succes!", "Salvare", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void DeleteCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void DeleteCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Elementul selectat a fost șters.", "Ștergere", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void RapidCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("S-a apelat comanda rapidă (Ctrl + Shift + A)!", "Comandă Rapidă", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                // Acțiune pentru tasta Enter
                // MessageBox.Show("S-a apăsat tasta Enter");
            }
            else if (e.Key == Key.Escape)
            {
                Close();
            }
        }
    }
}