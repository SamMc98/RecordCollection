using System;
using System.Collections;

class RecordCollection {
  string albumName, artist, genre, format;
  int releaseYear, discNum;
  
  //creating arraylist
  static ArrayList records = new ArrayList();
  
  //constructor
  public RecordCollection(string albName, string art, string gnr, string fmt, int year, int discNo){
    albumName = albName;
    artist = art;
    genre = gnr;
    format = fmt;
    releaseYear = year;
    discNum = discNo;
  }
  
  //ToString override method:
  public override string ToString(){
    return "\nAlbum name: " + albumName + "\nArtist: " + artist + "\nGenre: " + genre + "\nFormat: " + format + "\nRelease Year: " + releaseYear + "\nNumber of Discs: " + discNum;
  }

//enter username and be greeted
public static void enterUserName(){
  Console.WriteLine("Enter username:");
  string userName = Console.ReadLine();
  Console.WriteLine("Hello " + userName + "!");
}

//brings up the main menu
  public static void Menu(){
   Console.WriteLine("What would you like to do? \nView Collection     Add to Collection     Remove from Collection     Quit");
  string cmmd = Console.ReadLine();
  if (cmmd.ToLower().Equals("view collection")){
  Console.WriteLine("View Collection.");
  ViewCollection(records);
  }
  else if (cmmd.ToLower().Equals("add to collection")){
  Console.WriteLine("Add to Collection.");
  }
  else if (cmmd.ToLower().Equals("remove from collection")){
  Console.WriteLine("Remove from Collection.");
  }
  else if (cmmd.ToLower().Equals("quit")){
  Console.WriteLine("Quit.");
  System.Environment.Exit(0);
  }
  else {
  Console.WriteLine("Command not found.");
  Menu();
      }
}
  
public void addRecord(RecordCollection record){
    records.Add(record);
}

 public static void ViewCollection(ArrayList list)
    {
      Console.WriteLine("\nYour Record Collection:");
        foreach (var each in list){
      Console.Write(each + "\n");
    }
    }

//from menu
    public static void AddToCollection(){
      
    }

  //from menu
    public static void RemoveFromCollection(){
      
    }

  public static void Main (string[] args) {

  //creation of object:
  RecordCollection cd1 = new RecordCollection("Automatic for the People", "REM", "Alternative", "Cassette", 1992, 1);

  RecordCollection cd2 = new RecordCollection("Queen II", "Queen", "Rock", "Cassette", 1974, 1);

  //system order instructions
  enterUserName();
  cd1.addRecord(cd1);
  cd2.addRecord(cd2);
  Menu();
  }
}