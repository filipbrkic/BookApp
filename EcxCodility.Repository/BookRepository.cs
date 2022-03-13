
using AutoMapper;
using EcxCodility.Common.Models;
using EcxCodility.Repository.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EcxCodility.Repository
{
    public class BookRepository : IBookRepository
    {
        public readonly string filePath = Path.GetFullPath("DataSource.xml");

        public IEnumerable<BookDTO> GetAll()
        {
            if (File.Exists(filePath))
            {
                XmlSerializer reader = new XmlSerializer(typeof(List<BookDTO>));

                using (StreamReader file = new StreamReader(filePath))
                {
                    List<BookDTO> catalog = (List<BookDTO>)reader.Deserialize(file);
                    return catalog;
                }
            }

            return null;
        }

        public bool Update(IEnumerable<BookDTO> bookDTO)
        {
            if (File.Exists(filePath))
            {
                XmlSerializer writer = new XmlSerializer(typeof(List<BookDTO>));

                using (FileStream file = File.Create(filePath))
                {
                    writer.Serialize(file, bookDTO);
                }

                return true;
            }

            return false;
        }

    }
}
