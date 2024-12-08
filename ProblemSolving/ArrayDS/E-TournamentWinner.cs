namespace ProblemSolving.ArrayDS;

internal class E_TournamentWinner
{
    public static void TournamentWinner()
    {
        List<List<string>> competitions = [
                                               ["HTML","C#"],
                                                ["C#","Python"],
                                                ["Python","HTML"]
                                          ];

        List<int> results = [0, 0, 1];

        Dictionary<string, int> resultCount = new Dictionary<string, int>();

        #region Reduce if blocks for the below region - Brute force approach

        int HOME_WIN = 1;
        string currentBestTeam = "";

        resultCount[currentBestTeam] = 0;

        for (int i = 0; i < competitions.Count; i++)
        {

            string home = competitions[i][0];
            string away = competitions[i][1];

            string winningTeam = (results[i] == HOME_WIN) ? home : away;

            UpdateScore(winningTeam, 3, resultCount);

            if (resultCount[winningTeam] > resultCount[currentBestTeam])
            {
                currentBestTeam = winningTeam;
            }
        }

        void UpdateScore(string team, int points, Dictionary<string, int> resultCount)
        {
            if (!resultCount.ContainsKey(team))
                resultCount[team] = 0;

            resultCount[team] += points;
        }

        #endregion

        foreach (KeyValuePair<string, int> kvp in resultCount)
        {
            Console.WriteLine(kvp.Key + " -- " + kvp.Value);
        }

        #region Brute force approach (Uncomment below for testing)
        //BruteForceMethod(competitions, results, resultCount);

        //static void BruteForceMethod(List<List<string>> competitions, List<int> results, Dictionary<string, int> resultCount)
        //{
        //    string maxTeam = string.Empty;
        //    int MaxPoint = int.MinValue;
        //    for (int i = 0; i < competitions.Count; i++)
        //    {

        //        string home = competitions[i][0];
        //        string away = competitions[i][1];

        //        if (!resultCount.ContainsKey(home))
        //            resultCount[home] = 0;
        //        if (!resultCount.ContainsKey(away))
        //            resultCount[away] = 0;

        //        resultCount[home] += results[i] == 0 ? 0 : 3;
        //        resultCount[away] += results[i] == 0 ? 3 : 0;

        //        if (resultCount[home] > MaxPoint)
        //        {
        //            MaxPoint = resultCount[home];
        //            maxTeam = home;
        //        }
        //        if (resultCount[away] > MaxPoint)
        //        {
        //            MaxPoint = resultCount[away];
        //            maxTeam = away;
        //        }
        //    }

        //    //foreach(var kv in resultCount)
        //    //{
        //    //    if(kv.Value > MaxPoint)
        //    //    {
        //    //        maxTeam = kv.Key;
        //    //        MaxPoint = kv.Value;
        //    //    }
        //    //}
        //}

        #endregion BruteForce
    }
}
