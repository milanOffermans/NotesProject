using System;
using System.IO;
using Newtonsoft.Json;

namespace Notes.Core
{
    public class FileStore<T> : IDataStore<T>
        where T : class, new()
    {
        private readonly string _filePath ;

        public FileStore(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(filePath));
            }

            _filePath = filePath;

            if (!File.Exists(_filePath))
            {
                Write(new T());
            }
        }

        public T Read()
        {
            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public void Write(T content)
        {
            var json  = JsonConvert.SerializeObject(content);
            File.WriteAllText(_filePath, json);
        }
    }
}
