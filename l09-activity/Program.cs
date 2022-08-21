char[] letters = { 'W', 'e', ' ', 'a', 'r', 'e', ' ', 'B', 'S', 'T' };

List<string> words = new List<string>();

createWords(letters, words);

foreach (string w in words) {
    Console.Write(w);
}

Console.WriteLine();

void createWords(char[] letters, List<string> words)
{
    string temp = "";

    foreach (char l in letters) {
        if (l != ' ') {
            temp += l;
        } else {
            words.Add(temp);
            temp = " ";
        }
    }
    words.Add(temp);
}
