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
using System.Windows.Shapes;
using System.Xml;

namespace XML
{
	/// <summary>
	/// Logika interakcji dla klasy KategoriePojazdów.xaml
	/// </summary>
	public partial class PojazdyWidok : Window
	{
		ListBox lista;
		public PojazdyWidok()
		{
			InitializeComponent();
			lista = (ListBox)FindName("Kategorie");
		}

		private void WidokWybranegoPojazdu(object sender, RoutedEventArgs e)
		{
			XmlElement wybrana = (XmlElement)lista.SelectedItem;
			new PojazdWidok(wybrana)
				.Show();
		}
	}
}
