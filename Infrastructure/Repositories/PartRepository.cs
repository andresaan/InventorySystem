using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.IO.Ports;
using Data.Parts;
using Data;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using Infrastructure.Interfaces;
using System.Security.Cryptography;
using System.Reflection;

namespace Infrastructure.Repositories
{
    public class PartRepository : BaseRepository, IPartRepository
    {
        public PartRepository()
        {
            this._path = "..\\..\\..\\Infrastructure\\Database\\PartsTable.json";
        }

        public void InitializeData()
        {
            var testData = new PartsTableDTO()
            {
                AutoIncrement = 1
            };

            var jsonToWrite = JsonConvert.SerializeObject(testData);

            using (var writer = new StreamWriter(_path, false))
            {
                writer.Write(jsonToWrite);
            }
        }

        public PartsTableDTO GetAll()
        {
            string jsonFromFile;
            using (var reader = new StreamReader(_path))
            {
                jsonFromFile = reader.ReadToEnd();
            }

            var parts = JsonConvert.DeserializeObject<PartsTableDTO>(jsonFromFile);

            if (parts != null)
            {
                return parts;
            }

            InitializeData();
            return GetAll();
        }

        public void AddPart(Part part)
        {
            var parts = GetAll();

            part.Id = parts.AutoIncrement;
            parts.AutoIncrement++;

            if (part is OutsourcedPart)
            {
                parts.OutSourcedParts.Add((OutsourcedPart)part);
            }

            if (part is InHousePart)
            {
                parts.InHouseParts.Add((InHousePart)part);
            }

            var jsonToWrite = JsonConvert.SerializeObject(parts);

            using (var writer = new StreamWriter(_path, false))
            {
                writer.Write(jsonToWrite);
            }
        }

        public void DeletePart(long id)
        {
            var parts = GetAll();

            parts.InHouseParts.RemoveAll(i => i.Id == id);
            parts.OutSourcedParts.RemoveAll(i => i.Id == id);

            var jsonToWrite = JsonConvert.SerializeObject(parts);
            using (var writer = new StreamWriter(_path, false))
            {
                writer.Write(jsonToWrite);
            }
        }

        public void UpdatePart(Part part)
        {
            DeletePart(part.Id);
            
            var parts = GetAll();

            if (part is OutsourcedPart)
            {
                parts.OutSourcedParts.Add((OutsourcedPart)part);
            }

            if (part is InHousePart)
            {
                parts.InHouseParts.Add((InHousePart)part);
            }

            var jsonToWrite = JsonConvert.SerializeObject(parts);

            using (var writer = new StreamWriter(_path, false))
            {
                writer.Write(jsonToWrite);
            }
        }
    }
}
    

