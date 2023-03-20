using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

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
            int caretIndex = message.CaretIndex;
            if (caretIndex >= 0)
            {
                int lastSpaceIndex = message.Text.LastIndexOf(' ', caretIndex - 1);
                int start = 0;
                if (lastSpaceIndex >= 0)
                {
                    start = lastSpaceIndex + 1;
                }
                int length = caretIndex - start;
                if (length <= 0)
                {
                    // no word to check
                    CleanSuggestions();
                    return;
                }
                string word = string.Empty;
                if (start >= 0 && start + length <= message.Text.Length)
                {
                    word = message.Text.Substring(start, length);
                }
                if (word.Length > 0)
                {
                    int errorPosition = message.GetNextSpellingErrorCharacterIndex(start, LogicalDirection.Forward);
                    if (errorPosition >= 0)
                    {
                        SpellingError spellingError = message.GetSpellingError(errorPosition);
                        IEnumerable<string> suggestions = spellingError.Suggestions;
                        suggestion_1.Content = suggestions.ElementAtOrDefault(0) ?? String.Empty;
                        suggestion_2.Content = suggestions.ElementAtOrDefault(1) ?? String.Empty;
                        suggestion_3.Content = suggestions.ElementAtOrDefault(2) ?? String.Empty;
                    }
                    else
                    {
                        CleanSuggestions();
                    }
                }
            }
        }

        private void SuggestionLabel_Click(object sender, RoutedEventArgs e)
        {
            Label suggestionLabel = (Label)sender;
            string suggestion = suggestionLabel.Content.ToString();
            int caretIndex = message.CaretIndex;
            int start = 0;
            int length = 0;
            if (caretIndex > 0)
            {
                int lastSpaceIndex = message.Text.LastIndexOf(' ', caretIndex - 1);
                if (lastSpaceIndex >= 0)
                {
                    start = lastSpaceIndex + 1;
                    length = caretIndex - start;
                }
                else
                {
                    length = caretIndex;
                }
            }

            message.Select(start, length);
            try
            {
                message.SelectedText = suggestion;
            }
            catch (Exception)
            {
                CleanSuggestions();
                return; 
            }

            CleanSuggestions();
        }

        private void CleanSuggestions()
        {
            suggestion_1.Content = String.Empty;
            suggestion_2.Content = String.Empty;
            suggestion_3.Content = String.Empty;
        }
    }
}
