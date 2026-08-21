public class Solution {

    public static main()
    {
        Console.WriteLine("Hello");
    }

    public bool StoneGame(int[] piles) {
        int Alice = 0;
        int Bob = 0;

        int pilesLast = piles.Length - 1;
        int pilesFirst = 0;

        bool AliceTurn = true;

        while(pilesLast >= pilesFirst){
            if(piles[pilesLast] > piles[pilesFirst]){
                if(AliceTurn){
                    Alice += piles[pilesLast];
                }else{
                    Bob += piles[pilesLast];
                }
                pilesLast--;
            }else{
                if(AliceTurn){
                    Alice += piles[pilesFirst];
                }else{
                    Bob += piles[pilesFirst];
                }
                pilesFirst++;
            }
        }

        return Alice > Bob ? true : false;
    }
}

// Complexity analysis 
// time complexity O(n)
// space complexity O(1)