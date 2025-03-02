/**
 * @param {string} s
 * @return {string}
 */

function isVowel(char) {
    const vowels = 'aeiouAEIOU';
    return vowels.includes(char);
}

var reverseVowels = function(s) {
   let i = 0, j = s.length - 1;
    let strArray = s.split(''); 

    while (i < j) {
        while (i < s.length && !isVowel(strArray[i])) {
            i++;
        }
        while (j >= 0 && !isVowel(strArray[j])) {
            j--;
        }

        if (i < j) {
            let temp = strArray[i];
            strArray[i] = strArray[j];
            strArray[j] = temp;
            i++;
            j--;
        }
    }
    return strArray.join('');
};