public class Solution {
    public bool AsteroidsDestroyed(int mass, int[] asteroids) {
        Array.Sort(asteroids);
        long newmass = mass;
        foreach(int asteroid in asteroids){
            if(newmass >= asteroid) newmass += asteroid;
            else{
                return false;
            }
        }
        return true;
    }
}

// Complexity analysis 
// Time Complexity O(n log n) because of the sorting of the asteroids
// Space Complexity O(1)