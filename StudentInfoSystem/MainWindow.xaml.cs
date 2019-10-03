using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using StudentRepository;
using UserLogin;


namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Student _student;
        public Student Student
        {
            get
            {
                return _student;
            }
            set
            {
                _student = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Student"));
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            DeactivateControls();
            Student = new Student();
            this.DataContext = this;
        }

        private void ClearContain()
        {
            foreach (var item in Login.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
                if (item is PasswordBox)
                {
                    ((PasswordBox)item).Password = "";
                }
            }
            foreach (var item in PersonalData.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
            foreach (var item in StudentInfo.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }

        private void ShowMeStudent(String fNum)
        {            
            if (StudentData.IsThereStudent(fNum) == null)
            {
                MessageBox.Show("We couldn't find student with this faculty number!");
            }
            else
            {
                ClearContain();
                MessageBox.Show("Successful Login!");               
                ActivateControls();
                Student temp = StudentData.IsThereStudent(fNum);
                txtName.Text = temp.Forename;
                txtFatherName.Text = temp.FatherName;
                txtSurname.Text = temp.Surname;
                txtFaculty.Text = temp.Faculty;
                txtSpecialty.Text = temp.Specialty;
                txtEQD.Text = temp.EducationalQualificationDegree;
                txtStatus.Text = temp.Status;
                txtFacultyNumber.Text = temp.FacultyNumber;
                txtYear.Text = temp.Year.ToString();
                txtStream.Text = temp.Stream.ToString();
                txtGroup.Text = temp.Group.ToString();
            }
        }

        private void DeactivateControls()
        {
            foreach (Control c in PersonalData.Children)
            {
                c.IsEnabled = false;
            }
            foreach (Control c in StudentInfo.Children)
            {
                c.IsEnabled = false;
            }         
        }

        private void ActivateControls()
        {
            foreach (Control c in PersonalData.Children)
            {
                c.IsEnabled = true;
            }
            foreach (Control c in StudentInfo.Children)
            {
                c.IsEnabled = true;
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if(UserData.IsUserPassCorrect(txtUsername.Text,passwordBox.Password.ToString()) == null)
            {
                ClearContain();
                MessageBox.Show("Wrong username or password!");               
            }
            else
            {
                User temp = UserData.IsUserPassCorrect(txtUsername.Text, passwordBox.Password.ToString());
                if((UserRoles)temp.Role == UserRoles.STUDENT)
                {
                    //ShowMeStudent(temp.FacultyNumber);
                    if (StudentData.IsThereStudent(temp.FacultyNumber) == null)
                    {
                        MessageBox.Show("We couldn't find student with this faculty number!");
                    }
                    else
                    {
                        ClearContain();
                        MessageBox.Show("Successful Login!");
                        ActivateControls();
                        Student = StudentData.IsThereStudent(temp.FacultyNumber);                  
                    }          
                }
                else
                {
                    MessageBox.Show("Entered data is not for student!");
                }
            }
        }
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            ClearContain();
        }

    }
}
