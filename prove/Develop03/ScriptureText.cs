// Source code for Develop03
// Dennis Skoy
// Last edit: Feb 2024

// ScriptureText Class:




using System.Text;

public class ScriptureText
{
	// Attributes
	private List<Word> words;// List of text

	/** characters to separate the scriptures by*/
	internal static readonly char[] separator = [' ', '.', ',', '!', '?', ';', ':', '"', '[', ']', '-', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];


	public ScriptureText() { words = []; }

	// Getter
	// public string GetText() { return text; }

	// Setter
	public void SetWords(string text)//keeps the original scripture's spacing and characters
	{
		words.Clear(); // Clears the words Lists
		var wordBuffer = new StringBuilder();// new StringBuilder to modify the string and create words

		foreach (char c in text)// for each character in the text
		{
			if (IsSeparator(c))// if a separator is found:
			{
				if (wordBuffer.Length > 0)// if it contains some characters
				{
					words.Add(new Word(wordBuffer.ToString()));// adds word accumulated in the wordBufferlist
					wordBuffer.Clear();// clears the buffer to add the next word
				}
				words.Add(new Word(c.ToString(), character: true));// adds the separator as a word
			}
			else { wordBuffer.Append(c); }// current character is added to wordBuffer if it is not a separator

		}
		if (wordBuffer.Length > 0)// if any word is left
		{ words.Add(new Word(wordBuffer.ToString())); }// adds the last word if there are any

	}


	// Member Methods
	/** EmptyWord Method: blanks new words */
	public void EmptyWords(int number)// number = how many words to replace
	{
		Random random = new();// Random integer generator

		List<int> notBlanked = MakeBlankIndex();// creates list indexing words not blank or separators

		for (int i = 0; i < number && notBlanked.Any(); i++)// for each word in the notBlanked
		{
			int index = random.Next(notBlanked.Count);// selects random index
			words[notBlanked[index]].SetIsBlank(true);// changes the word to Blank
			notBlanked.RemoveAt(index);// removes the index from the notBlanked List
		}
	}


	/** MakeBlankIndex Method: lists word indexes that are not blank or separators*/
	private List<int> MakeBlankIndex()
	{
		var wordIndexes = Enumerable.Range(0, words.Count);//Creates integer sequence from 0 to word count

		// Filters word indexes that are NOT blanked and are not separators (Alphabetic)
		var filteredIndexes = wordIndexes.Where(i => !words[i].IsBlank() && words[i].IsAlphabetic()).ToList();

		return filteredIndexes.ToList();// returns list with these word indexes
	}


	/** IsSeparator Method: checks if character is a separator */
	private static bool IsSeparator(char c) { return separator.Contains(c); }


	/** HasWordsLeft Method: checks for remaining words in list */
	public bool HasWordsLeft() { return words.Any(word => !word.IsBlank() && word.IsAlphabetic()); }


	/**Prints words: Prints words List*/
	// For every word in the words list; returns string through the Word.ToString() method
	public void PrintText() { foreach (var word in words) { Console.Write(word.ToString()); } }
}