namespace MovieApp.Web.main
{
    public class NoteManager
    {

        public List<INote> nodes = new List<INote>();

        public void AddNode(INote node)
        {
            nodes.Add(node);
        }

        public string DisplayAllNode()
        {
            string result = string.Empty;
            foreach (INote node in nodes) {
                result += node.GetContent();
            }
            return result;
        }


    }
}
