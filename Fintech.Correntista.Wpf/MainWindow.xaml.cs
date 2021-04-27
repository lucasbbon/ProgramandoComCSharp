using Fintech.Modelos;
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

namespace Fintech.Correntista.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public MainWindow()
        {
            InitializeComponent();
            PopularControles();
        }

        private void PopularControles()
        {
            sexoComboBox.Items.Add(Sexo.Feminino);
            sexoComboBox.Items.Add(Sexo.Masculino);

            clientesDataGrid.ItemsSource = Clientes;
        }

        private void incluirClienteButton_Click(object sender, RoutedEventArgs e)
        {
            Endereco endereco = new();
            endereco.Cep = cepTextBox.Text;
            endereco.Cidade = cidadeTextBox.Text;
            endereco.Logradouro = logradouroTextBox.Text;
            endereco.Numero = numeroTextBox.Text;

            Cliente cliente = new();
            cliente.Cpf = cpfTextBox.Text;
            cliente.Nascimento = Convert.ToDateTime(nascimentoTextBox.Text);
            cliente.Endereco = endereco;
            cliente.Nome = nomeTextBox.Text;
            cliente.Sexo = (Sexo)sexoComboBox.SelectedItem;

            Clientes.Add(cliente);

            MessageBox.Show("Cliente cadastrado com sucesso.");
            LimparControlesCliente();
            clientesDataGrid.Items.Refresh();
            pesquisaClienteTabItem.Focus();
        }

        private void LimparControlesCliente()
        {
            cpfTextBox.Clear();
            nomeTextBox.Clear();
            nascimentoTextBox.Clear();
            sexoComboBox.SelectedIndex = -1;
            logradouroTextBox.Clear();
            numeroTextBox.Clear();
            cidadeTextBox.Clear();
            cepTextBox.Clear();
        }
    }
}
