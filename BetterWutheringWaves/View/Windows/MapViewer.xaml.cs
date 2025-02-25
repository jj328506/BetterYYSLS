using YYSLS.ViewModel.Windows;
using System.Windows;

namespace YYSLS.View.Windows;

public partial class MapViewer
{
    public MapViewerViewModel ViewModel { get; }

    public MapViewer()
    {
        DataContext = ViewModel = new();
        InitializeComponent();
    }
}
