using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quiz
{
    public partial class MainPage : ContentPage
    {
        private int score = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void FinishTestButton_Clicked(object sender, EventArgs e)
        {
            CheckAnswer(question1Options, 1, 2); 
            CheckAnswer(question2Options, 3, 4); 
            CheckAnswer(question3Options, 4, 4); 
            CheckAnswer(question4Options, 2, 1); 
            CheckAnswer(question5Options, 1, 1); 
            CheckAnswer(question6Options, 1, 1); 
            CheckAnswer(question7Options, 2, 2); 
            CheckAnswer(question8Options, 4, 4); 
            CheckAnswer(question9Options, 2, 2); 
            CheckAnswer(question10Options, 2, 2); 
            CheckAnswer(question11Options, 4, 3); 
            CheckAnswer(question12Options, 4, 4); 
            CheckAnswer(question13Options, 2, 2); 
            CheckAnswer(question14Options, 2, 2); 
            CheckAnswer(question15Options, 2, 2); 
            CheckAnswer(question16Options, 4, 3); 
            CheckAnswer(question17Options, 1, 1); 
            CheckAnswer(question18Options, 1, 1); 
            CheckAnswer(question19Options, 4, 4); 
            CheckAnswer(question20Options, 3, 3); 

         
            resultLabel.Text = "Ваш результат: " + score.ToString();
        }

        private void CheckAnswer(StackLayout options, int correctOptionIndex, int questionScore)
        {
            foreach (var option in options.Children)
            {
                if (option is RadioButton radioBtn && radioBtn.IsChecked)
                {
                    int selectedOptionIndex = options.Children.IndexOf(option) + 1;
                    if (selectedOptionIndex == correctOptionIndex)
                    {
                        radioBtn.TextColor = Color.Green; 
                        score += questionScore; 
                    }
                    else
                    {
                        radioBtn.TextColor = Color.Red;
                    }
                    break;
                }
            }
        }
    }
}
