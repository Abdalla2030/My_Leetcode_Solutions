/**
 * @param {string} pattern
 * @param {string} s
 * @return {boolean}
 */
var wordPattern = function(pattern, s) {
    let words = s.split(' ');
    if (pattern.length !== words.length) {
        return false;
    }

    let mapP = new Map();
    let mapS = new Map();

    for (let i = 0; i < pattern.length; i++) {
        
        if (mapP.has(pattern[i])) {
            if (mapP.get(pattern[i]) !== words[i]) {
                return false;
            }
        } else {
            mapP.set(pattern[i], words[i]);
        }

        if (mapS.has(words[i])) {
            if (mapS.get(words[i]) !== pattern[i]) {
                return false;
            }
        } else {
            mapS.set(words[i], pattern[i]);
        }
    }

    return true;
};
