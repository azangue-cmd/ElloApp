using ElloApp.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ElloApp.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        #region Status thumbs

        #region properties
        public ObservableCollection<StatusDataModel> statusThumbsCollection { get; set; }
        #endregion

        #region logic
        void LoadStatusThumbs()
        {
            //lets bind our collection to itemscontrol
            statusThumbsCollection = new ObservableCollection<StatusDataModel>()
            {
                //Since we want to keep first status blank for the use to add 
                new StatusDataModel
                {
                   IsMeAddStatus = true
                },
                new StatusDataModel
                {
                    ContactName = "Azangue",
                    ContactPhoto = new Uri("/Assets/Medias/cameroon.png", UriKind.RelativeOrAbsolute),
                     StatusImage = new Uri("/Assets/Medias/fishs.png", UriKind.RelativeOrAbsolute),
                   IsMeAddStatus = false
                },
                new StatusDataModel
                {
                    ContactName = "Kom",
                    ContactPhoto = new Uri("/Assets/Medias/ceuta.png", UriKind.RelativeOrAbsolute),
                     StatusImage = new Uri("/Assets/Medias/fishs2.png", UriKind.RelativeOrAbsolute),
                   IsMeAddStatus = false
                },
                new StatusDataModel
                {
                    ContactName = "Armel",
                    ContactPhoto = new Uri("/Assets/Medias/england.png", UriKind.RelativeOrAbsolute),
                     StatusImage = new Uri("/Assets/Medias/fishs1.png", UriKind.RelativeOrAbsolute),
                   IsMeAddStatus = false
                },
                new StatusDataModel
                {
                    ContactName = "Junior",
                    ContactPhoto = new Uri("/Assets/Medias/ethiopia_48px.png", UriKind.RelativeOrAbsolute),
                     StatusImage = new Uri("/Assets/Medias/ccnb.png", UriKind.RelativeOrAbsolute),
                   IsMeAddStatus = false
                },
            };
            OnPropertyChanged("statusThumbsCollection");
        }
        #endregion

        #endregion

        #region Chat List

        #region properties
        public ObservableCollection<ChatlistData> Chats { get; set; }
        #endregion

        #region logics
        void LoadChats()
        {
            Chats = new ObservableCollection<ChatlistData>()
            {
                new ChatlistData
                {
                    ContactName = "Azangue",
                    ContactPhoto = new Uri("/Assets/Medias/fishs.png", UriKind.RelativeOrAbsolute),
                    Message = "Bonjour! comment tu vas ?",
                    LastMessageTime = "The, 12:58 PM",
                    ChatIsSelected = true
                }, 

                new ChatlistData
                {
                    ContactName = "Kom",
                    ContactPhoto = new Uri("/Assets/Medias/fishs2.png", UriKind.RelativeOrAbsolute),
                    Message = "Bonjour! comment tu vas ?",
                    LastMessageTime = "The, 12:58 PM"
                }, 

                new ChatlistData
                {
                    ContactName = "Armel",
                    ContactPhoto = new Uri("/Assets/Medias/fishs1.png", UriKind.RelativeOrAbsolute),
                    Message = "Bonjour! comment tu vas ?",
                    LastMessageTime = "The, 12:58 PM"
                }, 

                new ChatlistData
                {
                    ContactName = "Junior",
                    ContactPhoto = new Uri("/Assets/Medias/ccnb.png", UriKind.RelativeOrAbsolute),
                    Message = "Bonjour! comment tu vas ?",
                    LastMessageTime = "The, 12:58 PM"
                },
            };
            OnPropertyChanged();
        }
        #endregion

        #endregion

        public ViewModel()
        {
            LoadStatusThumbs();
            LoadChats();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
