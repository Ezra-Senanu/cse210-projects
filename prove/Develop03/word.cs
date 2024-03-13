using System;

public class Word{
    private bool _isHidden;
    private string _content;
   
    public Word(string text){
        _content = text;
        _isHidden = false;

    }
    public void HideWords(){}
    public void ShowWord(){}
    public bool IsHidden(){
        return _isHidden;
    }

    public string GetDisplay(){
        return _content;
    }


}