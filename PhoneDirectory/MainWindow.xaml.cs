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
using System.Configuration;
using System.Data;
using System.Xml.Linq;
using System.Diagnostics.Contracts;
using System.IO;
using System.Media;

namespace PhoneDirectory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CollectionViewSource cs = new CollectionViewSource();
        AddPhNo phoneNum = new AddPhNo();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddPhNo_Click(object sender, RoutedEventArgs e)
        {
            string name = txtFullName.Text;
            string phoneNo = txtPhoneNo.Text;

            phoneNum.contacts.Add(phoneNo, name);
            phoneNum.WritingInFile(name, phoneNo);
            txtFullName.Clear();
            txtPhoneNo.Clear();

        }

        private void btnLookup_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone Number");
            string name = txtFullName.Text;
            string phoneNo = txtPhoneNo.Text;
            if (phoneNo != "")
            {
                phoneNum.contacts.TryGetValue(phoneNo, out name);
                dgPhoneDirectory.DataContext = false;
                dt.Rows.Add(name, phoneNo);
                cs.Source = dt.DefaultView;
                dgPhoneDirectory.ItemsSource = cs.View;
            }
            else
            {
                foreach (var contact in phoneNum.contacts)
                {
                    if (contact.Value.ToLower() == name.ToLower())
                    {
                        string key = contact.Key;
                        dgPhoneDirectory.DataContext = false;
                        dt.Rows.Add(name, key);
                        cs.Source = dt.DefaultView;
                        dgPhoneDirectory.ItemsSource = cs.View;
                    }
                }
            }

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            string name = txtFullName.Text;
            string phoneNo = txtPhoneNo.Text;
            string newNumber = txtPhoneNo_Copy.Text;
            string temp = "";

            //todo if key already exists throw error back to screen and tell user to pick a different
            //number its already in use

            bool v = phoneNum.contacts.TryGetValue(phoneNo, out temp);
            if (v)
            {
                //if we find the key remove the current one and add the new one
                phoneNum.contacts.Remove(phoneNo);
                phoneNum.contacts.Add(newNumber,name);
            }

            // now call btnview click to update the tabel again
            ViewPhoneDirectory();
            btnView_Click(sender, e);
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string name = txtFullName.Text;
            string phoneNo = txtPhoneNo.Text;
            string newNumber = txtPhoneNo_Copy.Text;
            if(name=="" || phoneNo == "" || newNumber == "")
            {
                // Break;
            }

            phoneNum.UpdateContactsFiles();

            phoneNum.contacts.Remove(phoneNo);
            phoneNum.contacts.Add(name, phoneNo);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            phoneNum.ReadingFromFile();
        }
        public void ViewPhoneDirectory()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Phone Number");


            if (phoneNum.contacts.Count == 0)
            {
                Console.WriteLine("You dont have contacts on your list");
            }
            else
            {
                foreach(var c in phoneNum.contacts)
                {
                    dt.Rows.Add(c.Value, c.Key);
                }
            }

            cs.Source = dt.DefaultView;
            dgPhoneDirectory.ItemsSource = cs.View;

        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            ViewPhoneDirectory();
        }
    }
}
