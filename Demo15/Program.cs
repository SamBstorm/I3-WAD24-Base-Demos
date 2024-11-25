namespace Demo15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToolBox tb = new ToolBox();

            string text = null;

            tb.WriteVerticaly("Salut les WADs!");
            tb.WriteVerticaly(text);
            
            tb.WriteVerticaly(new char[] { 'O', 'K' });
            tb.WriteVerticaly(['\0', ' ', '\t']);
        }
    }
}
