using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using XamarinAllianceApp.Helpers;
using XamarinAllianceApp.Models;
using Microsoft.WindowsAzure.MobileServices;

namespace XamarinAllianceApp.Services
{
    public class CharacterService
    {
        private MobileServiceClient Client;
        private IMobileServiceTable<Character> CharacterTable;

        public CharacterService()
        {
            Client = new MobileServiceClient(Constants.MobileServiceURL);
            CharacterTable = Client.GetTable<Character>();
        }        

        /// <summary>
        /// Get the list of characters
        /// </summary>
        /// <returns>ObservableCollection of Character objects</returns>
        public async Task<ObservableCollection<Character>> GetCharactersAsync()
        {
            var characters = await ReadCharactersFromAzure();
            return new ObservableCollection<Character>(characters);
        }

        private async Task<List<Character>> ReadCharactersFromAzure()
        {
            try
            {
                var query = CharacterTable.OrderBy(x => x.Name);
                return await query.ToListAsync();
            }
            catch (Exception ex)
            {
                return default(List<Character>);
            }
        }

        /// <summary>
        /// Get the list of characters from an embedded JSON file, including their child entities.
        /// </summary>
        /// <returns>Array of Character objects</returns>
        private async Task<Character[]> ReadCharactersFromFile()
        {
            var assembly = typeof(CharacterService).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(Constants.CharactersFilename);
            string text;

            using (var reader = new System.IO.StreamReader(stream))
            {
                text = await reader.ReadToEndAsync();
            }

            var characters = JsonConvert.DeserializeObject<Character[]>(text);
            return characters;
        }
    }
}
