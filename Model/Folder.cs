namespace Model
{
    public class Folder : Resource
    {

        public FolderType FolderType;
        public bool VerifyFolder(User loggedUser)
        {
            return this.Owner.Name == loggedUser.Name;
        }
    }


    public enum FolderType
    {
        FOLDER,
        WORKSPACE
    }
}
