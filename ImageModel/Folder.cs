namespace Model
{
    public class Folder : Resource
    {
        public Folder(string name, User owner) : base(name, owner)
        {

        }

        public FolderType FolderType;
        public bool VerifyFolder(User loggedUser)
        {
            return Owner.Name == loggedUser.Name;
        }
    }


    public enum FolderType
    {
        FOLDER,
        WORKSPACE
    }
}
