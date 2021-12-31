using Model;
using System;
using System.Collections.Generic;
using System.IO;
using Utilities;

namespace Business
{
    partial class ImportImage
    {
        static internal IList<Resource> ResourceList;

        public void ImportImageList(User loggedUser)
        {
            var pathFile = "images.txt";

            using (var fileStream = new FileStream(pathFile, FileMode.Open))
            using (var reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    var stringLine = reader.ReadLine();
                    var image = ConvertLineToImage(stringLine, loggedUser.Name);
                    ResourceList.Add(image);
                }
            }

            foreach(var img in ResourceList)
            {
                Console.WriteLine($"{img.Name} imported succesfully.");
            }

            //extension method
            List<string> list = new List<string>();
            list.AddVarious("test", "xpto", "123");
        }

        static Image ConvertLineToImage(string stringLine, string loggedUserName)
        {
            string[] fields = stringLine.Split(';');

            var name = fields[0];
            var path = fields[1];
            var altDescription = fields[2];
            var extension = fields[3];

            var image = new Image(name)
            {
                Path = path,
                AltDescription = altDescription,
                Extension = extension,
                Owner = {
                    Name = loggedUserName
                }
            };

            image.Auditings = new List<Audit>();

            return image;
        }
    }
}
