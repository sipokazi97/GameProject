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

namespace GameApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int qNum = 0;
        int i;
        int score;

        //public FakeMessageBox box;
        public MainWindow()
        {
            InitializeComponent();
            //box = new FakeMessageBox();
            //box.Show();
            //// Use a timer to simulate an event in which the FakeMessageBox should be closed 
            //Timer autoCloseTimer = new Timer();
            //// The FakeMessageBox closes after 5 seconds 
            //autoCloseTimer.Interval = 5000;
            //autoCloseTimer.Enabled = true;
            //autoCloseTimer.Tick += new EventHandler(autoCloseTimer_Tick);
            //StartGame();
            //NextQuestion();
        }
        //void autoCloseTimer_Tick(object sender, EventArgs e)
	    //{ 
	    //  // Close the FakeMessageBox 
	    //  box.Close(); 
	    //}

    private void RestartGame()
        {
            score = 0;//set score to zero
            qNum = -1; //set qnum to -1
            i = 0;
            StartGame();
        }
        private void StartGame()
        {
            score = 0;
            qNum = -1;
        }
        private void checkAnswer(object sender, RoutedEventArgs e)
        {

            Button senderButton = sender as Button;
            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }

            scoreText.Content = "Answered Correctly" +" "+ score + "/" + questionNumbers.Count;
            NextQuestion();
        }

        private void NextQuestion()
        {
            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                RestartGame();
            }

            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkSalmon;
            }

            switch (i)
            {
                case 1:
                    txtQuestion.Text = "What is the name of this catoon charactor?";
                    ans1.Content = "SpongeBob SquarePants";
                    ans2.Content = "Micky Mouse";
                    ans3.Content = "Shrack";
                    ans4.Content = "Betty Boop";

                    ans2.Tag = "1";
                  
                    qImage.Source = new BitmapImage(new Uri(@"images\image1.jpg" , UriKind.RelativeOrAbsolute));

                    break;

                case 2:
                    txtQuestion.Text = "What is the name of this catoon charactor?";
                    ans1.Content = "Boss Baby";
                    ans2.Content = "Shrack";
                    ans3.Content = "Betty Boop";
                    ans4.Content = "SpongeBob SquarePants";

                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri(@"images/image2.jpg" , UriKind.RelativeOrAbsolute ));

                    break;

                case 3:
                    txtQuestion.Text = "What is the name of this catoon charactor?";
                    ans1.Content = "Mr. Magoo";
                    ans2.Content = "Beavis";
                    ans3.Content = "Smurf";
                    ans4.Content = "Mickey Mouse";

                    ans3.Tag = "1";
                   qImage.Source = new BitmapImage(new Uri(@"images/image3.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case 4:
                    txtQuestion.Text = "What is the name of this catoon charactor?";
                    ans1.Content = "Charlie Brown";
                    ans2.Content = "Fred Flintstone";
                    ans3.Content = "Mickey Mouse";
                    ans4.Content = "Shrack";

                    ans4.Tag = "1";
                   qImage.Source = new BitmapImage(new Uri(@"images/image4.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case 5:
                    txtQuestion.Text = "What is the name of this catoon charactor?";
                    ans1.Content = "Ladymermaid";
                    ans2.Content = "Bart Simpson";
                    ans3.Content = "Scooby-Doo";
                    ans4.Content = "Bugs Bunny";

                    ans1.Tag = "1";
                   qImage.Source = new BitmapImage(new Uri(@"images/image5.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case 6:
                    txtQuestion.Text = "What is the name of this catoon charactor?";
                    ans1.Content = "Rocky and Bullwinkle";
                    ans2.Content = "modiki and rigby";
                    ans3.Content = "Tom and Jerry";
                    ans4.Content = "Modi and Tom";

                    ans3.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri(@"images/image6.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case 7:
                    txtQuestion.Text = "What is the name of this catoon charactor?";
                    ans1.Content = "Eric Cartman";
                    ans2.Content = "Mr Bin";
                    ans3.Content = "Daffy Duck";
                    ans4.Content = "Donkey";

                    ans2.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri(@"images/image7.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case 8:
                    txtQuestion.Text = "What is the name of this catoon charactor?";
                    ans1.Content = "Scooby-Doo";
                    ans2.Content = "SpongeBob SquarePants";
                    ans3.Content = "George Jetson";
                    ans4.Content = "Minion";

                    ans4.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri(@"images/image8.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case 9:
                    txtQuestion.Text = "What is the name of this catoon charactor?";
                    ans1.Content = "Scooby-Doo";
                    ans2.Content = "Bugs Bunny";
                    ans3.Content = "Donkey";
                    ans4.Content = "SpongeBob SquarePants";

                    ans3.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri(@"images/image9.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case 10:
                    txtQuestion.Text = "What is the name of this catoon charactor?";
                    ans1.Content = "SpongeBob SquarePants";
                    ans2.Content = "Scooby-Doo";
                    ans3.Content = "Porky Pig";
                    ans4.Content = "Donkey";

                    ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri(@"images/image10.jpg", UriKind.RelativeOrAbsolute));

                    break;

            }
        } 
    }
}
