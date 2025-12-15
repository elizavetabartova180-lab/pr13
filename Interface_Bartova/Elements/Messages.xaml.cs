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

using Interface_Bartova.Classes;

namespace Interface_Bartova.Elements
{
    /// <summary>
    /// Логика взаимодействия для Messages.xaml
    /// </summary>
    public partial class Messages : UserControl
    {
        public MessagesContext ThisMessage;

        public Messages(Classes.MessagesContext messages)
        {
            InitializeComponent();
            ThisMessage = messages;
            Message.Text = messages.Message;
            Date.Text = messages.Creat.ToString("dd.MM.yyyy");
        }
        private void DeleteMessage(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ThisMessage.Delete();
            MainWindow.mainWindow.parentMessage.Children.Removal(this);
        }

    }
}