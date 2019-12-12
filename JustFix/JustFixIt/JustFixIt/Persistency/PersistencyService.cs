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

namespace JustFixIt.Model
{
    class PersistencyService
    {
        private static string jsonAdminsFileName = "Admins.json";
        private static string jsonCustomersFileName = "Customers.json";
        private static string jsonMechanicsFileName = "Mechanics.json";

        public static async void SaveUsersAsJsonAsync(List<User> Users)
        {
            //[0] = admin, [1] = customer, [2] = mechanic
            List<User>[] SortedUsers = {new List<User>(), new List<User>(), new List<User>()};
            foreach (User user in Users)
            {
                SortedUsers[(int) user.PersonType].Add(user);
            }

            //Admin saving
            string adminsJsonString = JsonConvert.SerializeObject(SortedUsers[0]);
            SerializeNotesFileAsync(adminsJsonString, jsonAdminsFileName);
            //Customer saving
            string customersJsonString = JsonConvert.SerializeObject(SortedUsers[1]);
            SerializeNotesFileAsync(customersJsonString, jsonCustomersFileName);
            //Mechanic saving
            string mechanicsJsonString = JsonConvert.SerializeObject(SortedUsers[2]);
            SerializeNotesFileAsync(mechanicsJsonString, jsonMechanicsFileName);
        }

        public static async Task<List<User>> LoadUsersFromJsonAsync()
        {
            //Admin load
            string adminJsonString = await DeserializeNotesFileAsync(jsonAdminsFileName);
            //Customer load
            string customerJsonString = await DeserializeNotesFileAsync(jsonCustomersFileName);
            //Mechanic load
            string mechanicJsonString = await DeserializeNotesFileAsync(jsonMechanicsFileName);
            List<User> LoadedUsers = new List<User>();
            foreach (AdminUser adminUser in (List<AdminUser>)JsonConvert.DeserializeObject(adminJsonString, typeof(List<AdminUser>)))
            {
                LoadedUsers.Add(adminUser);
            }
            foreach (CustomerUser customerUser in (List<CustomerUser>)JsonConvert.DeserializeObject(customerJsonString, typeof(List<CustomerUser>)))
            {
                LoadedUsers.Add(customerUser);
            }
            foreach (MechanicUser mechanicUser in (List<MechanicUser>)JsonConvert.DeserializeObject(mechanicJsonString, typeof(List<MechanicUser>)))
            {
                LoadedUsers.Add(mechanicUser);
            }

            return LoadedUsers;
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
