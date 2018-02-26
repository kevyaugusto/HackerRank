using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tutorials._30DaysOfCode
{
    public class ClimbingTheLeaderboard
    {
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            var S = new HashSet<int>(scores);
            var A = new HashSet<int>(alice);



            var alicesInitialRank = S.Count - 1;

            return null;
        }
        /*
         * SOLUTION
        
        var S = new HashSet<long>(scores).ToList();
        var A = new HashSet<long>(alice).ToList();
        
        int[] result = new int[alice.Length];
        
        var list = new Dictionary<long, int>();
        int rank = 1;
        int i = 0;
        int j = A.Count - 1;
        while(i < S.Count && j >= 0) {
            if(S[i] > A[j]) {
                rank++;
                i++;
            } else if(A[j] > S[i]){
                list.Add(A[j], rank);
                j--;
            } else {
                list.Add(A[j], rank);
                rank++;
                i++;
                j--;
            }
        }
        
        while(j >= 0) {
            list.Add(A[j--], rank);
        }
        
        for(int r = 0; r < alice.Length; r++) {
            result[r] = list[alice[r]];
        }
        
        return result;

         * */
        public void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] scores_temp = Console.ReadLine().Split(' ');
            int[] scores = Array.ConvertAll(scores_temp, Int32.Parse);
            int m = Convert.ToInt32(Console.ReadLine());
            string[] alice_temp = Console.ReadLine().Split(' ');
            int[] alice = Array.ConvertAll(alice_temp, Int32.Parse);
            int[] result = climbingLeaderboard(scores, alice);
            Console.WriteLine(String.Join("\n", result));
        }

        public List<string> Main(List<string> args)
        {
            int n = Convert.ToInt32(args[0]);

            string[] scores_temp = args[1].Split(' ');

            int[] scores = Array.ConvertAll(scores_temp, Int32.Parse);

            int m = Convert.ToInt32(args[2]);

            string[] alice_temp = args[3].Split(' ');

            int[] alice = Array.ConvertAll(alice_temp, Int32.Parse);

            int[] result = climbingLeaderboard(scores, alice);

            //Console.WriteLine(String.Join("\n", result));

            return new List<string>();
        }
    }
}
