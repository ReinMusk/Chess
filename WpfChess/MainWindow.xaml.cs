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
using ChessCore; 

namespace WpfChess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Piece piece;
        private object prevSender;

        public MainWindow()
        {
            InitializeComponent();

            lbData.ItemsSource = PieceFab.InitPieceData();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            int x = Convert.ToInt32(Grid.GetColumn(b));
            int y = Convert.ToInt32(Grid.GetRow(b));

            if (b.Content == null)
            {
                if (piece == null)
                {
                    piece = PieceFab.Make(lbData.SelectedItem as PieceData, x, y);
                    sender.GetType().GetProperty("Content").SetValue(sender, GetPieceImage((lbData.SelectedItem as PieceData).image));
                    piece.Parent = b;
                    prevSender = sender;

                }
                else if (piece.CanMove(x, y))
                {
                    b.GetType().GetProperty("Content").SetValue(sender, GetPieceImage((lbData.SelectedItem as PieceData).image));
                    prevSender.GetType().GetProperty("Content").SetValue(prevSender, null);
                    piece.Move(x, y);
                    piece = null;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            if (b.Content == null)
            {
                b.Content = null;
            }
            }

        private StackPanel GetPieceImage(Uri images)
         {
             Image img = new Image
             {
                 Source = new BitmapImage(images)
             };

             StackPanel stackPnl = new StackPanel
             {
                 Orientation = Orientation.Horizontal,
                 Margin = new Thickness(10)
             };

             stackPnl.Children.Add(img);

             return stackPnl;
         }

       /* private void Buttom_Enter(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            int x = Convert.ToInt32(Grid.GetColumn(b));
            int y = Convert.ToInt32(Grid.GetRow(b));
            if(pieceInBoard)
                sender.GetType().GetProperty("Content").SetValue(sender, piece.CanMove(x, y) ? "yes" : "no");
        }*/
    }
}
