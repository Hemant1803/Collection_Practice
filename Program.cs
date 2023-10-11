namespace Read_chapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                int N = 4; 
                Dictionary<int, int> chapterPages = new Dictionary<int, int>
        {
            { 1, 4 },
            { 5, 7 },
            { 9, 16 },
            { 17, 26 }
        };
                int K = 7; 
                int chaptersYetToRead = 0;
                foreach (var chapter in chapterPages)
                {
                    if (chapter.Key <= K && K <= chapter.Value)
                    {
                        
                        break;
                    }
                    else
                    {
                      
                        chaptersYetToRead++;
                    }
                }

             
                chaptersYetToRead++;

               
                Console.WriteLine("Number of chapters to read: " + chaptersYetToRead);
            
        }
    }
}