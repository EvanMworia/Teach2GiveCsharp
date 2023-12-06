
namespace lists.ListExamples
{
    public class ListPractice
    {

        public void practiceList()
        {
            //initializing
            List<string> teams = new List<string>();
            //adding
            teams.Add("Machester United");
            teams.Add("Real Madrid");
            teams.Add("Chelsea");
            teams.Add("Barcelona");
            teams.Add("Arsenal");


            //accessing- indexing

            Console.WriteLine(teams[1]);

            //for Each
            //foreach (string team in teams) 
            //{
            //    Console.WriteLine(team);
            //}

            //for Loop -indexes

            //for(int i =0 ; i < teams.Count; i++)
            //{
            //    Console.WriteLine(teams[i]);
            //}

            //insert
            teams.Insert(0, "Brighton");
         

            List<string> germanyteams = new List<string>() {
                "Bayern Munich", 
                "Stuggard"
            };
            teams.InsertRange(0, germanyteams);
            //for (int i = 0; i < teams.Count; i++)
            //{
            //    Console.WriteLine(teams[i]);
            //}
            //Contains -available
            Console.WriteLine(teams.Contains("Machester United"));
            Console.WriteLine(teams.Contains("Liverpool"));
            //Remove

            //teams.Remove("Arsenal");
            

            //teams.RemoveAt(teams.Count - 1);
            //for (int i = 0; i < teams.Count; i++)
            //{
            //    Console.WriteLine(teams[i]);
            //}

            //teams.Clear();
            //teams.RemoveRange(0, 2);

           
            //teams.RemoveAll(x => x.Equals("Brighton"));
            teams.Sort();
            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine(teams[i]);
            }



        }
    }
}
