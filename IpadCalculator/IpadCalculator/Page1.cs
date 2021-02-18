using System;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Forms;

namespace IpadCalculator
{
    public class FirstPage : ContentPage
    {
        Label outputLabel;

        public FirstPage()
        {
            Grid grid = new Grid
            {
                BackgroundColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition(),
                    new RowDefinition(),
                    new RowDefinition(),                
                    new RowDefinition(),
                    new RowDefinition(),
                    new RowDefinition(),
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition(),
                    new ColumnDefinition(),
                    new ColumnDefinition(),
                    new ColumnDefinition(),
                },
            };

            outputLabel = new Label
            {
                TextColor = Color.White,
                BackgroundColor = Color.Black
            };
            outputLabel.FontSize = 20;
            grid.Children.Add(outputLabel, 0, 4, 0, 2);


            var buttonAllClear = new Button
            {
                Text = "AC",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray
            };
            buttonAllClear.Clicked += ButtonAllClear_Clicked;
            grid.Children.Add(buttonAllClear, 0, 2);


            var buttonClear = new Button
            {
                Text = "C",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray
            };
            buttonClear.Clicked += ButtonClear_Clicked;
            grid.Children.Add(buttonClear, 1, 2);


            var buttonDigitPower = new Button
            {
                Text = "^",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray
            };
            buttonDigitPower.Clicked += ButtonEvent_Clicked;
            grid.Children.Add(buttonDigitPower, 2, 2);


            var buttonDigit1 = new Button
            {
                Text = "1",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            
            buttonDigit1.Clicked += ButtonDigit_Clicked;
            grid.Children.Add(buttonDigit1, 0, 5);


            var buttonDigit2 = new Button
            {
                Text = "2",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            buttonDigit2.Clicked += ButtonDigit_Clicked;
            grid.Children.Add(buttonDigit2, 1, 5);


            var buttonDigit3 = new Button
            {
                Text = "3",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            buttonDigit3.Clicked += ButtonDigit_Clicked;
            grid.Children.Add(buttonDigit3, 2, 5);


            var buttonDigit4 = new Button
            {
                Text = "4",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            buttonDigit4.Clicked += ButtonDigit_Clicked;
            grid.Children.Add(buttonDigit4, 0, 4);


            var buttonDigit5 = new Button
            {
                Text = "5",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            buttonDigit5.Clicked += ButtonDigit_Clicked;
            grid.Children.Add(buttonDigit5, 1, 4);


            var buttonDigit6 = new Button
            {
                Text = "6",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            buttonDigit6.Clicked += ButtonDigit_Clicked;
            grid.Children.Add(buttonDigit6, 2, 4);


            var buttonDigit7 = new Button
            {
                Text = "7",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            buttonDigit7.Clicked += ButtonDigit_Clicked;
            grid.Children.Add(buttonDigit7, 0, 3);


            var buttonDigit8 = new Button
            {
                Text = "8",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            buttonDigit8.Clicked += ButtonDigit_Clicked;
            grid.Children.Add(buttonDigit8, 1, 3);


            var buttonDigit9 = new Button
            {
                Text = "9",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            buttonDigit9.Clicked += ButtonDigit_Clicked;
            grid.Children.Add(buttonDigit9, 2, 3);

            var buttonDigit0 = new Button
            {
                Text = "0",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            buttonDigit0.Clicked += ButtonDigit_Clicked;
            grid.Children.Add(buttonDigit0, 0, 6);

            var buttonDigitPoint = new Button
            {
                Text = ".",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            buttonDigitPoint.Clicked += ButtonDigit_Clicked;
            grid.Children.Add(buttonDigitPoint, 1, 6);


            var buttonEquals = new Button
            {
                Text = "=",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            buttonEquals.Clicked += ButtonEquals_Clicked;
            grid.Children.Add(buttonEquals, 3, 6);


            var buttonMultiply = new Button
            {
                Text = "*",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            buttonMultiply.Clicked += ButtonEvent_Clicked;
            grid.Children.Add(buttonMultiply, 3, 3);


            var buttonSubtract = new Button
            {
                Text = "-",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            buttonSubtract.Clicked += ButtonEvent_Clicked;
            grid.Children.Add(buttonSubtract, 3, 4);


            var buttonAdd = new Button
            {
                Text = "+",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            buttonAdd.Clicked += ButtonEvent_Clicked; 
            grid.Children.Add(buttonAdd, 3, 5);


            var buttonDivison = new Button
            {
                Text = "/",
                TextColor = Color.White,
                FontSize = 25,
                BackgroundColor = Color.DarkGray,
            };
            buttonDivison.Clicked += ButtonEvent_Clicked;
            grid.Children.Add(buttonDivison, 3, 2);

            var buttonTrap = new Button
            {
                Text = "НАЖМИ",
                TextColor = Color.Black,
                FontSize = 25,
                BackgroundColor = Color.Red,
            }; 
            buttonTrap.Clicked += ButtonLol_Clicked;
            grid.Children.Add(buttonTrap, 2, 6);


            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = grid;

        }


        private void ButtonClear_Clicked(object sender, EventArgs e) 
        {
            if (outputLabel.Text != null && outputLabel.Text.Length > 0 )
                outputLabel.Text = outputLabel.Text.Substring(0, outputLabel.Text.Length-1);
        }

        private void ButtonEvent_Clicked(object sender, EventArgs e)
        {
            string text = outputLabel.Text;

            var button = sender as Button;

            if (text == null || text.Length == 0)
            {
                outputLabel.Text = "0" + button.Text;
            }
            else if (!char.IsDigit(text[text.Length - 1]) && text != null)
            {
                    if (button.Text.ToCharArray()[0] == text[text.Length - 1])
                    {
                        outputLabel.Text += "";
                    }
                    else
                    {
                        outputLabel.Text = outputLabel.Text.Substring(0, outputLabel.Text.Length - 1) + button.Text;
                    }
            }
            else
            {
                outputLabel.Text += button.Text;
            }
        }

        private void ButtonEquals_Clicked(object sender, EventArgs e)
        {
            if (outputLabel.Text != null)
            {
                var text = outputLabel.Text;

                var calc = new PostfixNotationExpression();

                outputLabel.Text = calc.result(text).ToString();
            }
        }

        private void ButtonAllClear_Clicked(object sender, EventArgs e)
        {
            outputLabel.Text = null;
        }

        private void ButtonDigit_Clicked(object sender, EventArgs e)
        {
            string text = outputLabel.Text;

            var button = sender as Button;
            
            var digit = button.Text;

            if (button.Text == ".")
            {
                if (outputLabel.Text == null || (!char.IsDigit(text[text.Length-1]) && text[text.Length - 1] != '.'))
                    outputLabel.Text += "0" + button.Text;
                else
                {
                    bool isPointAllowed = true;
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i] == '.')
                            isPointAllowed = false;
                        switch (text[i])
                        {
                            case '+': isPointAllowed = true; break;
                            case '-': isPointAllowed = true; break;
                            case '*': isPointAllowed = true; break;
                            case '/': isPointAllowed = true; break;
                            case '^': isPointAllowed = true; break;
                        }
                    }
                    if (isPointAllowed)
                    outputLabel.Text += button.Text;
                } 
            }
            else
            {
                outputLabel.Text += button.Text;
            }
        }

        async void ButtonLol_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Ловушка Джокера", "Твой компьютер захвачен высокоинтелектуальным вирусом", "Заплалтить выкуп");
        }
    }
}