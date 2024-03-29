﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace CorretorSugestorTexto
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckSpell(object sender, TextChangedEventArgs e)
        {
            var caretIndex = message.CaretIndex;

            if (caretIndex <= 0) return;

            var lastSpaceIndex = message.Text.LastIndexOf(' ', caretIndex - 1);
            var start = lastSpaceIndex >= 0 ? lastSpaceIndex + 1 : 0;
            var length = caretIndex - start;

            if (length <= 0)
            {
                // No word to check
                CleanSuggestions();
                return;
            }

            var word = message.Text.Substring(start, length);

            if (word.Length <= 0) return;

            var errorPosition = message.GetNextSpellingErrorCharacterIndex(start, LogicalDirection.Forward);

            if (errorPosition < 0)
            {
                CleanSuggestions();
                return;
            }

            var spellingError = message.GetSpellingError(errorPosition);

            if (spellingError == null) return;

            var suggestions = spellingError.Suggestions;

            suggestion_1.Content = suggestions.ElementAtOrDefault(0) ?? string.Empty;
            suggestion_2.Content = suggestions.ElementAtOrDefault(1) ?? string.Empty;
            suggestion_3.Content = suggestions.ElementAtOrDefault(2) ?? string.Empty;
        }

        private void SuggestionLabel_Click(object sender, RoutedEventArgs e)
        {
            var suggestionLabel = (Label)sender;
            var suggestion = suggestionLabel.Content.ToString();
            var caretIndex = message.CaretIndex;
            var start = 0;
            var length = 0;

            if (caretIndex > 0)
            {
                var lastSpaceIndex = message.Text.LastIndexOf(' ', caretIndex - 1);

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
                message.SelectedText = suggestion + " ";
                message.CaretIndex = message.Text.Length + 1;
            }
            catch (Exception)
            {
                CleanSuggestions();
                message.CaretIndex = message.Text.Length + 1;
                return;
            }

            CleanSuggestions();
        }

        private void CleanSuggestions()
        {
            suggestion_1.Content = string.Empty;
            suggestion_2.Content = string.Empty;
            suggestion_3.Content = string.Empty;
        }
    }
}
