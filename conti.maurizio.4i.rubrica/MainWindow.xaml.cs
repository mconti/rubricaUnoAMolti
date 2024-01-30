using conti.maurizio._4i.rubrica;
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

namespace conti.maurizio._4i.rubrica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Persona> Persone = new List<Persona>();
        List<Contatto> Contatti = new List<Contatto>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Persona p1 = new Persona { idPersona = 1, Nome = "Maurizio", Cognome = "Conti" };
            Persona p2 = new Persona { idPersona = 2, Nome = "Riccardo", Cognome = "Bianchi" };

            Persone.Add(p1);
            Persone.Add(p2);

            Contatto c1 = new Contatto { idPersona = 1, Tipo = TipoContatto.Telefono, Valore = "0541772233" };
            Contatto c2 = new Contatto { idPersona = 1, Tipo = TipoContatto.Web, Valore = "www.maurizio.com" };
            Contatto c3 = new Contatto { idPersona = 2, Tipo = TipoContatto.EMail, Valore = "riccardo@scuola.net" };
            Contatto c4 = new Contatto { idPersona = 2, Tipo = TipoContatto.Cellulare, Valore = "3334455443" };

            Contatti.Add(c1);
            Contatti.Add(c2);
            Contatti.Add(c3);
            Contatti.Add(c4);

            dgPersone.ItemsSource = Persone;

        }

        private void dgDat1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Persona p = e.AddedItems[0] as Persona;
            
            if (p != null)
            {
                dgContatti.ItemsSource = null;
                List<Contatto> l = new List<Contatto>();

                foreach( var item in Contatti)
                {
                    if( item.idPersona==p.idPersona )
                        l.Add(item);

                }
                dgContatti.ItemsSource = l;

            }

        }
    }
}


