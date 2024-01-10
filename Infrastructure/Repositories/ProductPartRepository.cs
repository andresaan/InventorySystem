using Data.Parts;
using Data.Products;
using Infrastructure.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductPartRepository : BaseRepository, IProductPartRepository
    {
        public ProductPartRepository()
        {
            this._path = "..\\..\\..\\Infrastructure\\Database\\ProductsPartsTable.json";
        }

        private void InitializeProductPartTable()
        {
            var jsonToWrite = JsonConvert.SerializeObject(new ProductPartTableDTO());

            using (var writer = new StreamWriter(_path, false))
            {
                writer.Write(jsonToWrite);
            }
        }

        public ProductPartTableDTO GetAllRefrences()
        {
            string jsonFromFile;

            using (var reader = new StreamReader(_path))
            {
                jsonFromFile = reader.ReadToEnd();
            }

            var refrenceTableDTO = JsonConvert.DeserializeObject<ProductPartTableDTO>(jsonFromFile);

            if (refrenceTableDTO != null)
            {
                return refrenceTableDTO;
            }

            InitializeProductPartTable();

            return GetAllRefrences();
        }

        public void StoreAssociatedParts(long productId, HashSet<Part> parts)
        {
            var refrenceTableDTO = GetAllRefrences();

            List<long> partRefrences = new List<long>();

            foreach (Part part in parts)
            {
                partRefrences.Add(part.Id);
            }

            if (refrenceTableDTO.ProductPartRefrences.ContainsKey(productId))
            {
                refrenceTableDTO.ProductPartRefrences[productId].Clear();
                refrenceTableDTO.ProductPartRefrences[productId].AddRange(partRefrences);
            }
            else
            {
                refrenceTableDTO.ProductPartRefrences.Add(productId, partRefrences);
            }

            var jsonToWrite = JsonConvert.SerializeObject(refrenceTableDTO);

            using (var writer = new StreamWriter(_path, false))
            {
                writer.Write(jsonToWrite);
            }
        }
    }
}
