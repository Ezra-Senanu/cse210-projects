using System;

public class Scripture{
    private Reference _reference;
    private string _words;
    public Scripture(Reference set, String text){
        _reference = set; 
        _words = text;
    }
public void HideWords(int count){
}
public bool IsCompletelyHidden(){
    return false; 
}
public string GetDisplaySet(){
    string display = ($"{_words}");
        return display;
}
    
}


