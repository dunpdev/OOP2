using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OOP2V9
{
    // DOMAIN MODEL
    public class Person : INotifyPropertyChanged
    {
        private string firstName,lastName,phoneNumber,email;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value;
                OnPropertyChanged(); } }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value;
                OnPropertyChanged(); } }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value;
                OnPropertyChanged(); } }
        public string Email
        {
            get { return email; }
            set { email = value;
                OnPropertyChanged(); }}
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
