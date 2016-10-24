//Andre Moazed - 40216327
//This class is the implementation of the attendee class variables, also the main window for the GUI
//24-10-16

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
using System.Text.RegularExpressions;

namespace Coursework1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
       public  Attendee conAttendee = new Attendee();              //creating a new instance of the class
        
        public MainWindow()
        {
            InitializeComponent();
            //comBox_RegistrationType.Items.Add("Full");      // (not used anymore) To call comBox_RegistrationType.selecteditem == "Full"       or whatever string is being searched for
            //comBox_RegistrationType.Items.Add("Student");   //To create variable from comBox       var1 = comBox_RegistrationType.selecteditem.ToString
            //comBox_RegistrationType.Items.Add("Organizer");
        }

        protected void btn_Set_Click(object sender, RoutedEventArgs e) //making the Set button to take in information from each txt box/combobox/checkbox
        {
            try                                                     //Each reference is checked via the Attendee class to make sure that the user isn't missing any information input
            {                                                       //try and catch prevent user from ommiting any required information
                conAttendee.FirstName = txtBox_FirstName.Text;      //setting the variable "FirstName" in the attendee class to what is in the first name text box 
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }

            try
            {
                conAttendee.SecondName = txtBox_SecondName.Text;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            
            try
            {
                conAttendee.AttedeeRef = Int32.Parse(txtBox_AttendeeRef.Text);      //Setting the information in the AttendeeRef to become a String from an integer
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
            
            conAttendee.InstitutionName = txtBox_InstitutionName.Text;
            conAttendee.InstitutionPost = txtBox_Postcode.Text;
            
            try
            {
                conAttendee.ConferenceName = txtBox_ConferenceName.Text;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }

            try                                                                 //Making the text in the comboBox into a String
            {
                conAttendee.RegistrationType = comBox_RegistrationType.Text;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }

            conAttendee.Paid = checkBox_Paid.IsChecked.Value;

            conAttendee.Presenter = checkBox_Presenter.IsChecked.Value;             

            try
            {
                conAttendee.PaperTitle = txtBox_PaperTitle.Text;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        protected void btn_Get_Click(object sender, RoutedEventArgs e)      //retrieving already set instance of attendeeRef
        {
            txtBox_FirstName.Text = conAttendee.FirstName;
            txtBox_SecondName.Text = conAttendee.SecondName;
            txtBox_AttendeeRef.Text = conAttendee.AttedeeRef.ToString();
            txtBox_InstitutionName.Text = conAttendee.InstitutionName;
            txtBox_Postcode.Text = conAttendee.InstitutionPost;
            txtBox_ConferenceName.Text = conAttendee.ConferenceName;
            comBox_RegistrationType.Text = conAttendee.RegistrationType;
            checkBox_Paid.IsChecked = conAttendee.Paid;
            checkBox_Presenter.IsChecked = conAttendee.Presenter;
            txtBox_PaperTitle.Text = conAttendee.PaperTitle;
        }

        protected void btn_Clear_Click(object sender, RoutedEventArgs e)     //resetting the inteface to appear blank
        {
            txtBox_FirstName.Text = "";
            txtBox_SecondName.Text = "";
            txtBox_AttendeeRef.Text = "";
            txtBox_InstitutionName.Text = "";
            txtBox_Postcode.Text = "";
            txtBox_ConferenceName.Text = "";
            comBox_RegistrationType.Text = "";
            checkBox_Paid.IsChecked = false;
            checkBox_Presenter.IsChecked = false;
            txtBox_PaperTitle.Text = "";
        }

        protected void btn_Invoice_Click(object sender, RoutedEventArgs e)
        {
            Coursework1.Invoice form = new Coursework1.Invoice();                       

            form.lbl_InN.Content= conAttendee.FirstName + " " + conAttendee.SecondName;     //this displays the first name followed by a space and then the second name
            form.lbl_InInst.Content = conAttendee.InstitutionName;                          //displays institution name
            form.lbl_InConference.Content = conAttendee.ConferenceName;                     //etc.
            form.lbl_InCost.Content = conAttendee.GetCost();                                //calls GetCost method from Attendee class
    
            form.Show(); 
        }

        private void btn_Certificate_Click(object sender, RoutedEventArgs e)
        {
            Coursework1.Certificate form = new Coursework1.Certificate();
            if (conAttendee.Presenter == false)             //Message to be shown if the attendee is not a presented
            {
                form.lbl_CerCertificate.Content = "This certificate is to show that \n" + conAttendee.FirstName + " "
                + conAttendee.SecondName + " attended " + conAttendee.ConferenceName + ".";
            }
            else
            {
                form.lbl_CerCertificate.Content = "This certificate is to show that \n" + conAttendee.FirstName + " "           //Message to be shown when
                + conAttendee.SecondName + " attended " + conAttendee.ConferenceName + "\n and presented a paper entitled "     //Certificate button is clicked
                + conAttendee.PaperTitle + ".";                                                     
            }

            form.Show();
        }
    }
}
