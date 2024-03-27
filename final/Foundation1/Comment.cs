// Foundation1 source code
// Dennis Skoy
// Mar 2024

// Comment Class

class Comment
{
	private string author;//author of the comment
	private string text;//text of the comment

	// Constructor
	public Comment(string author, string text)
	{
		this.author = author;
		this.text = text;
	}

	// Getters
	public string GetAuthor() { return author; }
	public string GetText() { return text; }

	// Setters
	public void SetAuthor(string author) { this.author = author; }
	public void SetText(string text) { this.text = text; }


	// Methods
	/**ToString: returns author and comment as a string */
	public override string ToString() { return author + ": \n \t" + text; }
}