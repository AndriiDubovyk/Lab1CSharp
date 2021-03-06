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

namespace Lab1CSharp.Tools
{
    /// <summary>
    /// Interaction logic for TextBlockWithCaption.xaml
    /// </summary>
    public partial class TextBlockWithCaption : UserControl
    {
        public TextBlockWithCaption()
        {
            InitializeComponent();
        }

        public string Caption
        {
            get
            {
                return TbCaption.Text;
            }
            set
            {
                TbCaption.Text = value;
            }
        }

        public string Text
        {
            get
            {
                return TbValue.Text;
            }
            set
            {
                TbValue.Text=value;
            }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register
        (
            "Text",
            typeof(string),
            typeof(TextBlockWithCaption),
            new PropertyMetadata(null)
        );
    }
}
