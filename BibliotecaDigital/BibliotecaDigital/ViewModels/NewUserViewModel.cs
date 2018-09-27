using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDigital.ViewModels
{
    public class NewUserViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region CamposModelNewUser
        private int userID;
        public int UserID
        {
            get { return userID; }
            set
            {
                userID = value;
                NotifyPropertyChanged("UserID");
            }           
        }

        private string nome_completo;
        private string Nome_Completo
        {
            get { return nome_completo; }
            set
            {
                nome_completo = value;
                NotifyPropertyChanged("username_text_nome");//campo do xmal
            }
        }




        #endregion


    }


}
