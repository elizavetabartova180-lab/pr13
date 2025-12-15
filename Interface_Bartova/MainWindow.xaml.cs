using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Interface_Bartova.Classes;

namespace Interface_Bartova
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static UsersContext UsersContext = new UsersContext();
        public static MessagesContext MessagesContext = new MessagesContext();
        public int IdSelectUser = -1;
        public static MainWindow mainWindow;
        public MainWindow()
        {
            InitializeComponent();
            mainWindow = this;
            LoadUsers();
        }
        public void LoadUsers()
        {
            foreach (Models.Users User in UsersContext.AllUsers)
            {
                ParentUser.Children.Add(new Elements.Users(User));
            }
        }
        public void SelectUser(Models.Users user) {
            if (user != null)
                IdSelectUser = UsersContext.AllUsers.FindIndex(x => x == user);
            parentMessage.Children.Clear();
            foreach(MessagesContext Message in MessagesContext.AllMessages.FindAll(x=>x.IdUser == IdSelectUser))
                parentMessage.Children.Add(new Elements.Messages(Message));
            BlockMessage.IsEnabled = true;
        }
        private void SendMessages(object sender, System.Windows.Input.KeyEventArgs e) { 
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if(IdSelectUser == -1) return;
                MessagesContext newMessages = new MessagesContext(
                    Message.Text,
                    DateTime.Now,
                    IdSelectUser);
                newMessages.Save();
                Message.Text = "";
                SelectUser(null);
            }
        }
    }
}
