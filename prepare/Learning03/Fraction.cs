// Source code for Fraction Class in Learning03
// This returns two integers as a fraction in a string or a decimal value
// Dennis Skoy
// Last edit: Febrary 2024

class Fraction
{
    // Attributes
    private int _topNumber;// a fraction's top number
    private int _bottomNumber;// a fraction's bottom number


    // Constructors
    // // Default
    public Fraction() { this._topNumber = 1; this._bottomNumber = 1; }

    // // Paramaterized (1)
    public Fraction(int _topNumber) { this._topNumber = _topNumber; this._bottomNumber = 1; }

    // // Paramaterized (2)
    public Fraction(int _topNumber, int _bottomNumber) { this._topNumber = _topNumber; this._bottomNumber = _bottomNumber; }


    // Getters
    public int GetTopNumber() { return this._topNumber; }// returns _topNumber
    public int GetBottomNumber() { return this._bottomNumber; }// returns _bottomNumber

    // Setters
    public void SetTopNumber(int _topNumber) { this._topNumber = _topNumber; }// sets _topNumber
    public void SetBottomNumber(int _bottomNumber) { this._bottomNumber = _bottomNumber; }// sets _bottomNumber


    // Member Methods
    // // GetFractionString Method: returns the fraction as a string
    public string GetFractionString() { return $"{_topNumber}/{_bottomNumber}"; }


    // //GetDecimalValue Method: returns the fraction as a double
    public double GetDecimalValue() { return Math.Round((double)_topNumber / _bottomNumber, 2); }
}