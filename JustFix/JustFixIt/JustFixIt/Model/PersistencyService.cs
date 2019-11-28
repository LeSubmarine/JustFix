using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Popups;
using JustFixIt.Model;
using Newtonsoft.Json;

namespace NoteMVVM
{
    class PersistencyService
    {
        private static string jsonFileName = "Notes.json";

        public static async void SaveNotesAsJsonAsync(ObservableCollection<User> notes)
        {
            string notesJsonString = JsonConvert.SerializeObject(notes);
            SerializeNotesFileAsync(notesJsonString, jsonFileName);
        }

        public static async Task<List<User>> LoadNotesFromJsonAsync()
        {
            string notesJsonString = await DeserializeNotesFileAsync(jsonFileName);
            if (notesJsonString != null)
                return (List<User>)JsonConvert.DeserializeObject(notesJsonString, typeof(List<User>));
            return null;
        }



        private static async void SerializeNotesFileAsync(string notesJsonString, string fileName)
        {
            StorageFile localFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(localFile, notesJsonString);
        }


        private static async Task<string> DeserializeNotesFileAsync(string fileName)
        {
            try
            {
                StorageFile localFile = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return await FileIO.ReadTextAsync(localFile);
            }
            catch (FileNotFoundException ex)
            {
                MessageDialogHelper.Show("Loading for the first time? - Try Add and Save some Notes before trying to Save for the first time", "File not Found");
                return null;
            }
        }


        private class MessageDialogHelper
        {
            public static async void Show(string content, string title)
            {
                MessageDialog messageDialog = new MessageDialog(content, title);
                await messageDialog.ShowAsync();
            }
        }


    }
}
