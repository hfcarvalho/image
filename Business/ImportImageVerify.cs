using Model;
using System;
using System.Linq;

namespace Business
{
    /// <summary>
    /// Class used to verifying of the imported resources.
    /// </summary>
    partial class ImportImage
    {
        /// <summary>
        /// Do the verifying into resources, if instance of <see cref="User"/>
        /// </summary>
        /// <param name="nameof(loggedUser)">Represents the logged user on system.</param>
        public static void VerifyImages(User loggedUser)
        {

            foreach (var resource in ResourceList)
            {
                if (resource is Folder)
                {
                    var folder = resource as Folder;
                    object ok = folder.GetType().GetMethod("VerifyFolder").Invoke(folder, new object[] { loggedUser });
                }
            }

            string message = @"
                Verify Resources status.
                Congratulations!
            ";

            //linq examples
            var resourceList = ResourceList.Select(res => {
                return res.Name;
            }).ToList();

            var resourceListFromLoggedUser = 
                from res in ResourceList
                where res.Owner.Name == loggedUser.Name
                select res;

            foreach (var res in resourceListFromLoggedUser)
            {
                Console.WriteLine($"image: {res.Name}");
            }

            Console.WriteLine($"Result for verifying whith {typeof(User)} : {loggedUser.Name}");
            Console.WriteLine(message);


        }
    }
}
