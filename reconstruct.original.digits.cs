public class Solution {
    
    IDictionary<char, Dictionary<char, int>> lettersHash = 
    new Dictionary<char, Dictionary<char, int>>() {
        ['0'] = new Dictionary<char, int>() { ['z'] = 1 , ['e'] = 1, ['r'] = 1, ['o'] = 1 },
        ['1'] = new Dictionary<char, int>() { ['o'] = 1 , ['n'] = 1, ['e'] = 1            },
        ['2'] = new Dictionary<char, int>() { ['t'] = 1 , ['w'] = 1, ['o'] = 1            },
        ['3'] = new Dictionary<char, int>() { ['t'] = 1 , ['h'] = 1, ['r'] = 1, ['e'] = 2 },
        ['4'] = new Dictionary<char, int>() { ['f'] = 1 , ['o'] = 1, ['u'] = 1, ['r'] = 1 },
        ['5'] = new Dictionary<char, int>() { ['f'] = 1 , ['i'] = 1, ['v'] = 1, ['e'] = 1 },
        ['6'] = new Dictionary<char, int>() { ['s'] = 1 , ['i'] = 1, ['x'] = 1,           },
        ['7'] = new Dictionary<char, int>() { ['s'] = 1 , ['e'] = 2, ['v'] = 1, ['v'] = 1 },
        ['8'] = new Dictionary<char, int>() { ['e'] = 1 , ['i'] = 1, ['g'] = 1, ['h'] = 1, ['t'] = 1 },
        ['9'] = new Dictionary<char, int>() { ['n'] = 2 , ['i'] = 1, ['e'] = 1            },
    };
        
    public string OriginalDigits(string s) {
        
        var result = "";
        
        var dictionary = new Dictionary<char, int>();
        for(char c = 'a'; c <= 'z'; c++) {
            dictionary.Add(c, s.Count(i => i == c));
        }
        
        foreach (var number in lettersHash) {
            
            var hasAllOcurrences = true;
            var lettersDictionary = number.Value;
            foreach (var letter in lettersDictionary) {
                if (dictionary[letter.Key] < letter.Value) {
                    hasAllOcurrences = false;
                }
            }
            
            if (hasAllOcurrences) {
                result += number.Key;
                foreach (var letter in lettersDictionary) {
                    dictionary[letter.Key] -= letter.Value;
                }
            }                
        }
        
        return String.Concat(result.OrderBy(c => c));
    }
}
