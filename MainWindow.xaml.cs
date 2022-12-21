using Infragistics.Windows.Editors;
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

namespace KB10130_XamEditors_DisableSpinning;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void xamNumericEditor1_ExecutingCommand(object sender, Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs e)
    {
        if (e.Command == MaskedEditorCommands.SpinUp || e.Command == MaskedEditorCommands.SpinDown)
        {
            e.Cancel = true;
        }
    }
}
