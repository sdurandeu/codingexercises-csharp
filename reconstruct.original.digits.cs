public class Solution {
    
    IDictionary<char, Dictionary<char, int>> lettersHash = 
    new Dictionary<char, Dictionary<char, int>>() {
        ['0'] = { ['z'] = 1 , ['e'] = 1, ['r'] = 1, ['o'] = 1 },
        ['1'] = { ['o'] = 1 , ['n'] = 1, ['e'] = 1            },
        ['2'] = { ['t'] = 1 , ['w'] = 1, ['o'] = 1            },
        ['3'] = { ['t'] = 1 , ['h'] = 1, ['r'] = 1, ['e'] = 2 },
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
                    dictionary[letter.Key] =- letter.Value;
                }
            }                
        }
        
        return result;
    }
}
