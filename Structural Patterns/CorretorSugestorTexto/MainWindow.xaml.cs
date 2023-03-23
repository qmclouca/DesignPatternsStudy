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
                        int suggestionQuantity = suggestions.Count();
                        suggestion_1.Content = suggestionQuantity>0 ? suggestions.ElementAt(0) : String.Empty;
                        suggestion_2.Content = suggestionQuantity>1 ? suggestions.ElementAt(1) : String.Empty;
                        suggestion_3.Content = suggestionQuantity>2 ? suggestions.ElementAt(2) : String.Empty;
                    }
                }
                pos++;
            }
        }        
    }
}
