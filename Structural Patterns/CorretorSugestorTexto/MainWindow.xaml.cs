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

namespace CorretorSugestorTexto
{    
    public partial class MainWindow : Window
    {
        public static MainWindow _mainWindow = new MainWindow();
        public List<SpellingError> spellingErrors = new List<SpellingError>();
        public MainWindow()
        {
            InitializeComponent();                  
        }

        private void CheckSpell(object sender, TextChangedEventArgs e)
        {
            int pos = 0;     
            foreach (char c in message.Text)
            {
                if (c == ' ')
                {
                    int errorPosition = message.GetNextSpellingErrorCharacterIndex(pos, LogicalDirection.Forward);
                    if (errorPosition >= 0)
                    {
                        IEnumerable<string> suggestions = message.GetSpellingError(errorPosition).Suggestions;
                        suggestion_1.Content = suggestions.ElementAt(0) != null ? suggestions.ElementAt(0) : String.Empty;
                        suggestion_2.Content = suggestions.ElementAt(1) != null ? suggestions.ElementAt(1) : String.Empty;
                        suggestion_3.Content = suggestions.ElementAt(2) != null ? suggestions.ElementAt(2) : String.Empty;
                    }
                }
                pos++;
            }
        }

        private void Show(object sender, RoutedEventArgs e)
        {
            List<string> suggestions = new List<string>();
            if (spellingErrors != null)
            {
                foreach (SpellingError spellingError in spellingErrors)
                {
                    foreach (string suggestion in spellingError.Suggestions)
                    {
                        suggestions.Add(suggestion);
                    }
                }

                MessageBox.Show("Sugestão 1: " + suggestions[0]);
            }
            else return;            
        }
    }
}
