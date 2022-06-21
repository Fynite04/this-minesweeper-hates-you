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

namespace ThisMinesweeperHatesYou
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int widthHeight = 20;
        Rectangle[,] mineGrid;

        public MainWindow()
        {
            InitializeComponent();
            mineGrid = new Rectangle[widthHeight, widthHeight];
            InitalizeGrid();
        }

        private void InitalizeGrid()
        {
            for (int i = 0; i < widthHeight; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int y = 0; y < widthHeight; y++)
            {
                for (int x = 0; x < widthHeight; x++)
                {
                    Rectangle cell = new Rectangle();

                    BrushConverter bc = new BrushConverter();
                    if (y % 2 == 0)
                    {
                        if (x % 2 == 0)
                            cell.Fill = (Brush)(bc.ConvertFrom("#ebecd0"));
                        else
                            cell.Fill = (Brush)(bc.ConvertFrom("#779556"));
                    }
                    else
                    {
                        if (x % 2 == 0)
                            cell.Fill = (Brush)(bc.ConvertFrom("#779556"));
                        else
                            cell.Fill = (Brush)(bc.ConvertFrom("#ebecd0"));
                    }

                    grid.Children.Add(cell);
                    mineGrid[x, y] = cell;
                    Grid.SetRow(cell, x);
                    Grid.SetColumn(cell, y);

                }
            }
        }
    }
}
